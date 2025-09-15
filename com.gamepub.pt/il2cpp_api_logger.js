import "frida-il2cpp-bridge";
Il2Cpp.perform(() => {
  console.log("[IL2CPP LOGGER] Bridge ready. Hooking NetworkManager...");
  try {
    const NetworkManager = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("NetworkManager");
    NetworkManager.methods.forEach((method) => {
      if (method.name.startsWith("Send_") && !method.virtualAddress.isNull()) {
        try {
          Interceptor.attach(method.virtualAddress, {
            onEnter(args) {
              // Gửi message về Python/console
              send({
                type: "il2cpp",
                apiName: `NetworkManager::${method.name}`,
              });
            },
          });
        } catch (e) {}
      }
    });
    console.log("[IL2CPP LOGGER] Hooks are active.");
  } catch (err) {}
});
