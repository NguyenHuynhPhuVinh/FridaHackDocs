console.log("Frida script loaded. Tracing low-level file operations...");

Java.perform(function () {
  console.log("Inside Java.perform()...");

  // Hook mmap
  const mmap_ptr = Module.getExportByName("libc.so", "mmap");
  if (mmap_ptr) {
    console.log("Hooking mmap at " + mmap_ptr);
    Interceptor.attach(mmap_ptr, {
      onEnter: function (args) {
        // mmap có nhiều tham số, chúng ta quan tâm đến file descriptor (fd) ở args[4]
        // Việc lấy tên file từ fd hơi phức tạp, nhưng chúng ta có thể thử
        // Tạm thời chỉ log ra là có lời gọi
        console.log("\n[+] mmap called!");
        console.log(
          "Call stack:\n" +
            Thread.backtrace(this.context, Backtracer.ACCURATE)
              .map(DebugSymbol.fromAddress)
              .join("\n")
        );
      },
    });
  }

  // Hook openat (phổ biến hơn open trên Android mới)
  const openat_ptr = Module.getExportByName("libc.so", "openat");
  if (openat_ptr) {
    console.log("Hooking openat at " + openat_ptr);
    Interceptor.attach(openat_ptr, {
      onEnter: function (args) {
        // Tham số thứ 2 (args[1]) là đường dẫn file
        this.path = args[1].readCString();
        if (
          this.path &&
          (this.path.includes("classes.dex") || this.path.includes("base.apk"))
        ) {
          console.log("\n[+] openat called with path: " + this.path);
          console.log(
            "Call stack:\n" +
              Thread.backtrace(this.context, Backtracer.ACCURATE)
                .map(DebugSymbol.fromAddress)
                .join("\n")
          );
        }
      },
    });
  }
});
