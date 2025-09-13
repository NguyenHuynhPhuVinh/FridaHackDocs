### **Tổng Kết Hành Trình Bypass & Mod Game "Chuyện Công Chúa"**

**Mục tiêu:** Bypass cơ chế bảo vệ AppGuard và tích hợp Mod Menu (God Mode, One-Hit Kill) vào game.

**Giai đoạn 1: Phân Tích Tĩnh và Xác Định "Nghi Phạm"**

1.  **Decompile APK:** Sử dụng Apktool để dịch ngược file APK của game.
2.  **Xác định "Nghi phạm":** Dựa trên cấu trúc file và tên package, xác định các thành phần đáng ngờ nhất:
    - `com.nhnent.appguard.*`: Rõ ràng là SDK bảo vệ chính (AppGuard).
    - `android.support.v4.soft.ApplicationMain`: Lớp Application tùy chỉnh, là điểm khởi đầu lý tưởng để tiêm mã bảo vệ.
    - `com.extrainfov3.etc.*`: Các lớp thu thập thông tin và giao tiếp mạng, có thể dùng để báo cáo về server.
3.  **Xác định Điểm Yếu:** Lớp `ApplicationMain` được xác định là điểm khởi đầu của chuỗi bảo vệ, đặc biệt là các phương thức `attachBaseContext` (chạy rất sớm) và `onCreate`.

**Giai đoạn 2: Bypass Lớp Bảo Vệ Tầng Java/Smali (Thử & Sai)**

**Lần thử 1: Vô hiệu hóa `AppGuard.timeCheck`**

- **Hành động:** Sửa file `AppGuard.smali`, làm rỗng phương thức `timeCheck` (thay bằng `return-void`).
- **Gặp lỗi:** Khi compile lại, gặp lỗi `A .registers or .locals directive must be present...`.
- **Bài học:** Mọi phương thức trong Smali, kể cả khi rỗng, đều phải có khai báo `.locals` (ví dụ: `.locals 0`).
- **Sửa lỗi:** Thêm `.locals 0` vào phương thức `timeCheck` đã làm rỗng. Compile thành công.

**Lần thử 2: Game Crash với lỗi Native (`D.o`)**

- **Kết quả:** Sau khi vá lỗi `timeCheck`, game chạy được nhưng crash khi Activity được tạo.
- **Phân tích Logcat:** Lỗi `JNI DETECTED ERROR IN APPLICATION ... from int android.support.v4.soft.D.o(...)`.
- **Nguyên nhân:** Việc vô hiệu hóa `timeCheck` đã khiến một số thành phần mà hàm native `D.o()` cần không được khởi tạo. Đây là một cơ chế kiểm tra phụ thuộc (dependency check).
- **Hành động:** Sửa file `D.smali`, tìm phương thức `native o(...)` và thay thế nó bằng một hàm Smali rỗng trả về `0`.

**Lần thử 3: Game Crash với lỗi `NoSuchMethodError`**

- **Kết quả:** Sau khi sửa `D.o()`, game crash ngay lập tức khi khởi động.
- **Phân tích Logcat:** Lỗi `java.lang.NoSuchMethodError: no native method "Landroid/support/v4/soft/D;.o(...)"`.
- **Nguyên nhân:** Thư viện native của AppGuard, khi được load, đã kiểm tra và yêu cầu phương thức `o` phải được khai báo là `native`. Việc chúng ta xóa từ khóa `native` đã bị phát hiện. Đây là một cơ chế anti-tampering.
- **Bài học:** Không thể thay đổi chữ ký của các hàm `native` mà cơ chế bảo vệ dựa vào.

**Lần thử 4: Vô hiệu hóa Nơi Gọi Hàm Gây Lỗi**

- **Hành động:**
  1.  Hoàn tác các thay đổi trên `D.smali`.
  2.  Tìm đến nơi gọi `D.o()`, chính là lớp `ApplicationMain$m.smali`.
  3.  Làm rỗng toàn bộ các phương thức `onActivity...` trong `ApplicationMain$m.smali`.
- **Kết quả:** Game không còn crash vì các lỗi trên. **Bypass tầng Java thành công.**

**Giai đoạn 3: Tích hợp Mod Menu và Xử lý các vấn đề mới**

**Lần thử 5: Tích hợp Mod Menu ImGui & Crash do Xung đột SDK**

- **Hành động:**
  1.  Thực hiện lại quy trình vá Smali ở Lần thử 4.
  2.  Tiêm thư viện `libLoader.so` và `libModMenu.so` của template ImGui.
  3.  Sửa `UnityPlayerActivity.smali` để load `libLoader.so`.
- **Kết quả:** Game bị màn hình đen và crash.
- **Phân tích Logcat:** Lỗi `SIGABRT` hoặc `SIGSEGV` trong các luồng của Firebase (`lytics.startup1`, `firebase-instal`).
- **Nguyên nhân:** Việc vá Smali, dù bypass được AppGuard, nhưng đã quá "mạnh tay", làm ảnh hưởng đến quá trình khởi tạo của các SDK khác (Firebase, Facebook...) gây ra crash.

**Lần thử 6: "Phẫu thuật chính xác" Smali**

- **Hành động:**
  1.  **Không làm rỗng** toàn bộ các phương thức nữa.
  2.  Trong `ApplicationMain.smali`, chỉ xóa/comment các dòng `invoke-static` gọi đến `AppGuard` và `D`.
  3.  Trong `onCreate`, chỉ xóa/comment dòng gọi đến `AppGuard.timeCheck`.
- **Kết quả:** Vẫn crash, nhưng lần này logcat chỉ thẳng vào `libloader.so` và lỗi `destroying mutex`.
- **Nguyên nhân:** Xung đột luồng do `RemapTools` và việc load thư viện không đồng bộ.

**Lần thử 7 (Thành công): Vô hiệu hóa `libdiresu.so`**

- **Vấn đề cuối cùng:** Sau tất cả, game vẫn crash do lỗi JNI cross-thread từ `com.nhnent.appguard.Diresu.su()`.
- **Phân tích:** Một phần native của AppGuard (`libdiresu.so`) vẫn được load và hoạt động.
- **Hành động cuối cùng:**
  1.  Tìm file `Diresu.smali` (nằm trong `smali_classes3`).
  2.  **Làm rỗng `clinit`** để ngăn `System.loadLibrary("diresu")`.
  3.  **Làm rỗng tất cả các hàm `native`** trong `Diresu.smali` để chúng không gây lỗi khi được gọi.
- **Kết quả:** Toàn bộ cơ chế bảo vệ của AppGuard ở cả tầng Java và Native đã bị vô hiệu hóa hoàn toàn. Mod menu được tiêm vào một môi trường sạch và hoạt động thành công.

---

**Tổng kết các bài học kinh nghiệm:**

- **Bảo vệ đa lớp:** Các cơ chế bảo vệ hiện đại có nhiều lớp (Java, Native) và các cơ chế phụ thuộc lẫn nhau.
- **Logcat là vua:** Phân tích logcat là kỹ năng quan trọng nhất để tìm ra nguyên nhân gốc rễ của các vụ crash.
- **"Phẫu thuật" hơn là "Phá hủy":** Can thiệp một cách tối thiểu và chính xác vào mã nguồn sẽ ít gây ra tác dụng phụ hơn là xóa sổ toàn bộ.
- **Thời điểm là tất cả:** Thời điểm tiêm mã (ví dụ: `onCreate` vs. `Update`) và cách quản lý luồng (`pthread_join`, `pthread_detach`) cực kỳ quan trọng để tránh xung đột.
- **Luôn tin vào file dump:** File dump là nguồn thông tin chính xác nhất về cấu trúc của ứng dụng.
