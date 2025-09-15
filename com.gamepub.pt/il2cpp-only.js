import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[IL2CPP ONLY] Hooking NetworkManager...");
  try {
    const NetworkManager = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("NetworkManager");
    NetworkManager.methods.forEach((method) => {
      if (method.name.startsWith("Send_") && !method.virtualAddress.isNull()) {
        try {
          Interceptor.attach(method.virtualAddress, {
            onEnter(args) {
              console.log(`\n>>> API Call: ${method.name}`);
            },
          });
        } catch (e) {}
      }
    });
    console.log("[IL2CPP ONLY] Hooks active.");
  } catch (err) {}
});
