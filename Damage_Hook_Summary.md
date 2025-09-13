# Tổng Hợp Hàm Hook Sát Thương (Damage Hook Summary)

## Giới Thiệu

Tổng hợp các hàm và thuộc tính chính liên quan đến sát thương (damage) trong game Unity (dựa trên tệp Assembly-CSharp.cs của com.gamepub.pt/2.5.04). Các hàm này có thể được hook bằng Frida để thay đổi giá trị sát thương, như giảm sát thương nhận hoặc tăng sát thương đánh.

## Hàm Chính Để Hook

### 1. RecieveDamage

- **Chữ ký hàm:** `Battle.DamageResult RecieveDamage(CharacterBase _attacker, ref Battle.StatTransfer _statTransfer, bool _bAddDamage, System.Nullable<UnityEngine.Vector2> _vAttackPOS);`
- **Offset:** `/*0xd7f560*/`
- **Mô tả:** Hàm chính xử lý logic nhận sát thương, bao gồm tính toán và áp dụng sát thương. Hook để thay đổi `_statTransfer` (chứa thông tin sát thương) hoặc giá trị trả về.
- **Ví dụ sử dụng:** Hook để giảm sát thương nhận từ kẻ địch.

### 2. CalcDamage

- **Chữ ký hàm:** `float CalcDamage(float _fDamage, float _fDEF);`
- **Offset:** `/*0xd80054*/`
- **Mô tả:** Tính toán sát thương dựa trên DEF (phòng thủ). Hook để thay đổi công thức tính toán, ví dụ giảm DEF hoặc tăng sát thương.
- **Ví dụ sử dụng:** Thay đổi `_fDamage` hoặc `_fDEF` để điều chỉnh sát thương vật lý/phép thuật.

### 3. HandleCheckHitDamage

- **Chữ ký hàm:** `void HandleCheckHitDamage(CharacterBase _attacker, float _fDamage);`
- **Offset:** `/*0xf76e40*/`
- **Mô tả:** Xử lý sát thương khi nhân vật đánh trúng mục tiêu. Hook để thay đổi `_fDamage` trước khi gửi đến mục tiêu.
- **Ví dụ sử dụng:** Tăng sát thương đánh của nhân vật.

### 4. HandleCheckRecieveDamage

- **Chữ ký hàm:** `void HandleCheckRecieveDamage(CharacterBase _, float _fDamage);`
- **Offset:** `/*0x13229f4*/`
- **Mô tả:** Xử lý sát thương khi nhân vật nhận đòn. Hook để giảm hoặc tăng sát thương nhận vào.
- **Ví dụ sử dụng:** Giảm sát thương nhận từ boss hoặc kẻ địch.

## Thuộc Tính Nhân Tố Sát Thương

Các thuộc tính này có thể được hook để thay đổi nhân tố sát thương. Chúng thường là float và nằm trong class CharacterBase.

- `float MultHitDamage;` - Nhân sát thương đánh tổng quát.
- `float MultHitDamage_Physical;` - Nhân sát thương vật lý.
- `float MultHitDamage_Magical;` - Nhân sát thương phép thuật.
- `float MultDamageBoss;` - Nhân sát thương khi đánh boss.
- `float MultDamageCritical_Buff;` - Nhân sát thương chí mạng từ buff.
- `float IgnoreDamagePerMaxHP;` - Bỏ qua sát thương dựa trên % HP tối đa.

## Lưu Ý Khi Hook Với Frida

- **Tìm địa chỉ thực tế:** Sử dụng offset để tìm địa chỉ trong bộ nhớ của game.
- **Ưu tiên hook:** `RecieveDamage` hoặc `CalcDamage` cho hiệu quả toàn cục.
- **Kiểm tra game khác:** Nếu cần, kiểm tra thư mục exize.tapas.girlAdrift (có hàm như `Fight_Attack(double damage, bool isCrit)`).
- **Ví dụ script Frida cơ bản:**
  ```javascript
  Java.perform(function () {
    // Hook RecieveDamage
    var addr = Module.findBaseAddress("libil2cpp.so").add(0xd7f560); // Thay bằng địa chỉ thực tế
    Interceptor.attach(addr, {
      onEnter: function (args) {
        // Thay đổi args[2] (sát thương) nếu cần
      },
      onLeave: function (retval) {
        // Thay đổi retval nếu cần
      },
    });
  });
  ```
- **Cẩn thận:** Hook có thể gây crash nếu không chính xác. Test trên emulator trước.

## Tài Liệu Tham Khảo

- Tệp nguồn: `com.gamepub.pt/2.5.04/Assembly-CSharp.cs`
- Công cụ: Frida, Il2CppDumper để dump offset.
- Ngày cập nhật: September 13, 2025

Nếu cần chi tiết hơn hoặc hook cụ thể, hãy cung cấp thêm thông tin!</content>
<parameter name="filePath">c:\Users\tomis\Documents\FridaHackDocs\Damage_Hook_Summary.md
