# Tổng Hợp Hàm Hook Sát Thương (Damage Hook Summary)

## Giới Thiệu

Tổng hợp các hàm và thuộc tính chính liên quan đến sát thương (damage) trong game Unity (dựa trên tệp Assembly-CSharp.cs của com.gamepub.pt/2.5.04). Các hàm này có thể được hook bằng Frida để thay đổi giá trị sát thương, như giảm sát thương nhận hoặc tăng sát thương đánh.

## Struct Battle.StatTransfer - Cấu Trúc Sát Thương Chính

Struct này chứa tất cả thông tin về sát thương được truyền giữa các hàm. Đây là mục tiêu chính để hook God Mode và One-Hit Kill.

### Các Trường Chính:

- `/*0x10*/ Battle.AttackType AttackType;` - Loại tấn công (vật lý/phép thuật)
- `/*0x14*/ Battle.Hit_WpnType HitWeaponType;` - Loại vũ khí
- `/*0x18*/ float ACC;` - Độ chính xác
- `/*0x1c*/ float Damage;` - **Sát thương chính** (đã sửa từ fDamage)
- `/*0x20*/ float DamageMULT_ForStageData;` - Nhân sát thương theo stage
- `/*0x24*/ float CRI;` - Tỷ lệ chí mạng
- `/*0x28*/ float CRIMult;` - Nhân sát thương chí mạng
- `/*0x2c*/ float MPPAY;` - MP tiêu thụ
- `/*0x30*/ int FactionID;` - ID phe phái
- `/*0x34*/ int SkillID;` - ID kỹ năng
- `/*0x38*/ Battle.StatTransferFlag flag;` - Cờ trạng thái
- `/*0x3c*/ float DamageMult;` - Nhân sát thương tổng quát

## Hàm Chính Để Hook

### 1. RecieveDamage (God Mode)

- **Lớp:** `CharacterBase`
- **Chữ ký hàm:** `Battle.DamageResult RecieveDamage(CharacterBase _attacker, ref Battle.StatTransfer _statTransfer, bool _bAddDamage, System.Nullable<UnityEngine.Vector2> _vAttackPOS);`
- **Offset:** `/*0xd7f560*/`
- **Mô tả:** Hàm chính xử lý logic nhận sát thương. Hook để set `statTransfer.Damage = 0` cho God Mode.
- **Ví dụ hook Frida:**
  ```javascript
  // Hook RecieveDamage trong CharacterBase
  const statTransfer = new Il2Cpp.Object(args[2]); // args[2] là ref Battle.StatTransfer
  statTransfer.field("Damage").value = 0.0; // Set sát thương về 0
  ```

### 2. HandleCheckHitDamage (One-Hit Kill)

- **Lớp:** `CharacterBase` (đã sửa từ Skill.PlayerSkillComponent)
- **Chữ ký hàm:** `void HandleCheckHitDamage(CharacterBase _attacker, float _fDamage);`
- **Offset:** `/*0xf76e40*/`
- **Mô tả:** Xử lý sát thương khi đánh trúng mục tiêu. Hook để set `_fDamage` về giá trị rất cao.
- **Ví dụ hook Frida:**
  ```javascript
  // Hook HandleCheckHitDamage trong CharacterBase
  args[2] = ptr("0x4B189680"); // Set sát thương về 1e9 (rất cao)
  ```

### 3. CalcDamage

- **Chữ ký hàm:** `float CalcDamage(float _fDamage, float _fDEF);`
- **Offset:** `/*0xd80054*/`
- **Mô tả:** Tính toán sát thương dựa trên DEF (phòng thủ). Hook để thay đổi công thức tính toán.
- **Ví dụ sử dụng:** Thay đổi `_fDamage` hoặc `_fDEF` để điều chỉnh sát thương.

### 4. Các Hàm Liên Quan Khác

- `Battle.DamageResult RecieveDotDamage(CharacterBase _attacker, ref Battle.StatTransfer _statTransfer);` - Offset: `/*0xd7e568*/`
- `void RecieveDamageToTarget(CharacterBase _attacker, CharacterBase _target, ref Battle.StatTransfer _transfer);` - Offset: `/*0x16f501c*/`
- `void RecieveDamage(CharacterBase _target, Battle.StatTransfer _stat);` - Offset: `/*0x15156ec*/` và `/*0x1516138*/`
- `void RecieveAddDamage(CharacterBase _target, ref Battle.StatTransfer _stat);` - Offset: `/*0x15199e8*/`
- `Battle.StatTransfer GetStatTransfer();` - Offset: `/*0x1519d8c*/`
- `Battle.StatTransfer GetStarTransferWithDamage(Battle.AttackType _eAttackType, float _fDamage);` - Offset: `/*0x15180dc*/`
- `Battle.StatTransfer GetStatTransferWithCOEF(Battle.AttackType _eAttackType, float _fCOEFNum);` - Offset: `/*0x1519dd8*/`

## Thuộc Tính Nhân Tố Sát Thương Trong CharacterBase

Các thuộc tính này có thể được hook để thay đổi nhân tố sát thương:

- `/*0x58*/ Battle.StatTransfer m_ReleaseTransfer;` - StatTransfer được release
- `/*0x174*/ Battle.StatTransfer m_StatTransferTmp;` - StatTransfer tạm thời
- `/*0xb0*/ Battle.StatTransfer m_StatTransfer;` - StatTransfer chính

## Lưu Ý Khi Hook Với Frida

### Sửa Lỗi Thường Gặp:

1. **Trường sai:** Sử dụng `"Damage"` thay vì `"fDamage"` trong Battle.StatTransfer
2. **Lớp sai:** HandleCheckHitDamage nằm trong `"CharacterBase"` chứ không phải `"Skill.PlayerSkillComponent"`
3. **Offset:** Sử dụng offset chính xác từ dump để tìm địa chỉ trong bộ nhớ

### Cách Hook An Toàn:

- **Ưu tiên hook:** `RecieveDamage` cho God Mode, `HandleCheckHitDamage` cho One-Hit Kill
- **Kiểm tra game khác:** Thư mục exize.tapas.girlAdrift có hàm `Fight_Attack(double damage, bool isCrit)`
- **Test trên emulator:** Tránh crash game thật

### Ví Dụ Script Frida Hoàn Chỉnh:

```javascript
Java.perform(function () {
  const Il2Cpp = Il2Cpp.Api;
  Il2Cpp.perform(function () {
    // Tìm CharacterBase class
    const CharacterBase = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("CharacterBase");

    // God Mode: Hook RecieveDamage
    const RecieveDamage = CharacterBase.method("RecieveDamage", 4);
    RecieveDamage.implementation = Il2Cpp.Api.intercept(RecieveDamage.handle, {
      onEnter: function (args) {
        const statTransfer = new Il2Cpp.Object(args[2]);
        statTransfer.field("Damage").value = 0.0; // God Mode
      },
    });

    // One-Hit Kill: Hook HandleCheckHitDamage
    const HandleCheckHitDamage = CharacterBase.method(
      "HandleCheckHitDamage",
      2
    );
    HandleCheckHitDamage.implementation = Il2Cpp.Api.intercept(
      HandleCheckHitDamage.handle,
      {
        onEnter: function (args) {
          args[2] = ptr("0x4B189680"); // One-Hit Kill
        },
      }
    );
  });
});
```

## Tài Liệu Tham Khảo

- **Tệp nguồn:** `com.gamepub.pt/2.5.04/Assembly-CSharp.cs`
- **Công cụ:** Frida, frida-il2cpp-bridge để dump và hook
- **Ngày cập nhật:** September 13, 2025
- **Phiên bản game:** com.gamepub.pt/2.5.04

## Các Phát Hiện Chính Từ Dump

1. **Struct StatTransfer:** Chứa đầy đủ thông tin sát thương với trường `Damage` chính xác
2. **Lớp CharacterBase:** Chứa hầu hết các hàm xử lý sát thương
3. **Offset chính xác:** Đã verify qua grep search trong Assembly-CSharp.cs
4. **Signature đầy đủ:** Bao gồm các tham số và kiểu trả về chính xác

Nếu cần chi tiết hơn hoặc hook cụ thể, hãy cung cấp thêm thông tin!</content>
<parameter name="filePath">c:\Users\tomis\Documents\FridaHackDocs\Damage_Hook_Summary.md
