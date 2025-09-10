class <Module>
{
}

class MadPlugin : UnityEngine.MonoBehaviour
{
    static /*0x0*/ MadPlugin _instance;
    /*0x18*/ UnityEngine.AndroidJavaObject pluginObj;
    /*0x20*/ UnityEngine.AndroidJavaObject androidPermissionGrant;
    /*0x28*/ MadPlugin.RequestPermissionResult _requestResultDelegate;

    static /*0x19f9a78*/ MadPlugin get_instance();
    /*0x19fa3f4*/ MadPlugin();
    /*0x19f9cdc*/ void init();
    /*0x19f9e74*/ void setPluginDebug(bool debug);
    /*0x19f9fac*/ bool checkPermission(string permissionName);
    /*0x19fa084*/ bool shouldShowRequestPermissionRationale(string permissionName);
    /*0x19fa15c*/ void requestPermission(string permissionNames, MadPlugin.RequestPermissionResult resultDelegate);
    /*0x19fa2ac*/ void onRequestPermission(string result);

    class RequestPermissionResult : System.MulticastDelegate
    {
        /*0x19fa3fc*/ RequestPermissionResult(object object, nint method);
        /*0x19fa4c0*/ void Invoke(bool success, string[] failPermission);
        /*0x19fa4d8*/ System.IAsyncResult BeginInvoke(bool success, string[] failPermission, System.AsyncCallback callback, object object);
        /*0x19fa56c*/ void EndInvoke(System.IAsyncResult result);
    }
}

class iTween : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.List<System.Collections.Hashtable> tweens;
    /*0x18*/ string id;
    /*0x20*/ string type;
    /*0x28*/ string method;
    /*0x30*/ iTween.EaseType easeType;
    /*0x34*/ float time;
    /*0x38*/ float delay;
    /*0x3c*/ iTween.LoopType loopType;
    /*0x40*/ bool isRunning;
    /*0x41*/ bool isPaused;
    /*0x48*/ string _name;
    /*0x50*/ float runningTime;
    /*0x54*/ float percentage;
    /*0x58*/ float delayStarted;
    /*0x5c*/ bool kinematic;
    /*0x5d*/ bool isLocal;
    /*0x5e*/ bool loop;
    /*0x5f*/ bool reverse;
    /*0x60*/ bool wasPaused;
    /*0x61*/ bool physics;
    /*0x68*/ System.Collections.Hashtable tweenArguments;
    /*0x70*/ UnityEngine.Space space;
    /*0x78*/ iTween.EasingFunction ease;
    /*0x80*/ iTween.ApplyTween apply;
    /*0x88*/ UnityEngine.AudioSource audioSource;
    /*0x90*/ UnityEngine.Vector3[] vector3s;
    /*0x98*/ UnityEngine.Vector2[] vector2s;
    /*0xa0*/ UnityEngine.Color[,] colors;
    /*0xa8*/ float[] floats;
    /*0xb0*/ UnityEngine.Rect[] rects;
    /*0xb8*/ iTween.CRSpline path;
    /*0xc0*/ UnityEngine.Vector3 preUpdate;
    /*0xcc*/ UnityEngine.Vector3 postUpdate;
    /*0xd8*/ iTween.NamedValueColor namedcolorvalue;
    /*0xdc*/ float lastRealTime;
    /*0xe0*/ bool useRealTime;
    /*0xe8*/ UnityEngine.Transform thisTransform;

    static /*0x15d4020*/ iTween();
    static /*0x15b2fa4*/ void Init(UnityEngine.GameObject target);
    static /*0x15b3240*/ void ValueTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b43b0*/ void FadeFrom(UnityEngine.GameObject target, float alpha, float time);
    static /*0x15b469c*/ void FadeFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b5200*/ void FadeTo(UnityEngine.GameObject target, float alpha, float time);
    static /*0x15b53c8*/ void FadeTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b5a08*/ void ColorFrom(UnityEngine.GameObject target, UnityEngine.Color color, float time);
    static /*0x15b4700*/ void ColorFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b5c04*/ void ColorTo(UnityEngine.GameObject target, UnityEngine.Color color, float time);
    static /*0x15b542c*/ void ColorTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b5e00*/ void AudioFrom(UnityEngine.GameObject target, float volume, float pitch, float time);
    static /*0x15b6050*/ void AudioFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b64f4*/ void AudioTo(UnityEngine.GameObject target, float volume, float pitch, float time);
    static /*0x15b6744*/ void AudioTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b68d8*/ void Stab(UnityEngine.GameObject target, UnityEngine.AudioClip audioclip, float delay);
    static /*0x15b6a8c*/ void Stab(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b6b44*/ void LookFrom(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time);
    static /*0x15b6d34*/ void LookFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b749c*/ void LookTo(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time);
    static /*0x15b768c*/ void LookTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b79c8*/ void MoveTo(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time);
    static /*0x15b7bb8*/ void MoveTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b7f58*/ void MoveFrom(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time);
    static /*0x15b8148*/ void MoveFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b8ab4*/ void MoveAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15b8ca4*/ void MoveAdd(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b3050*/ void MoveBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15b8da0*/ void MoveBy(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b8e9c*/ void ScaleTo(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time);
    static /*0x15b908c*/ void ScaleTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b9418*/ void ScaleFrom(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time);
    static /*0x15b9608*/ void ScaleFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b9b10*/ void ScaleAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15b9d00*/ void ScaleAdd(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b9dfc*/ void ScaleBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15b9fec*/ void ScaleBy(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15ba0e8*/ void RotateTo(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time);
    static /*0x15ba2d8*/ void RotateTo(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15ba678*/ void RotateFrom(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time);
    static /*0x15ba868*/ void RotateFrom(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bae58*/ void RotateAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bb048*/ void RotateAdd(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bb144*/ void RotateBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bb334*/ void RotateBy(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bb430*/ void ShakePosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bb620*/ void ShakePosition(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bb71c*/ void ShakeScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bb90c*/ void ShakeScale(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bba08*/ void ShakeRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bbbf8*/ void ShakeRotation(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bbcf4*/ void PunchPosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bbee4*/ void PunchPosition(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bc044*/ void PunchRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bc234*/ void PunchRotation(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15bc394*/ void PunchScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time);
    static /*0x15bc584*/ void PunchScale(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15c7d1c*/ UnityEngine.Rect RectUpdate(UnityEngine.Rect currentValue, UnityEngine.Rect targetValue, float speed);
    static /*0x15c7ed0*/ UnityEngine.Vector3 Vector3Update(UnityEngine.Vector3 currentValue, UnityEngine.Vector3 targetValue, float speed);
    static /*0x15c7f38*/ UnityEngine.Vector2 Vector2Update(UnityEngine.Vector2 currentValue, UnityEngine.Vector2 targetValue, float speed);
    static /*0x15c7e94*/ float FloatUpdate(float currentValue, float targetValue, float speed);
    static /*0x15c7f84*/ void FadeUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15c8b28*/ void FadeUpdate(UnityEngine.GameObject target, float alpha, float time);
    static /*0x15c804c*/ void ColorUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15c8cf0*/ void ColorUpdate(UnityEngine.GameObject target, UnityEngine.Color color, float time);
    static /*0x15c8eec*/ void AudioUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15c9454*/ void AudioUpdate(UnityEngine.GameObject target, float volume, float pitch, float time);
    static /*0x15c96a4*/ void RotateUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15c9e00*/ void RotateUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time);
    static /*0x15c9ff0*/ void ScaleUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15ca640*/ void ScaleUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time);
    static /*0x15ca830*/ void MoveUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15cbbdc*/ void MoveUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time);
    static /*0x15cb114*/ void LookUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15cbdcc*/ void LookUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time);
    static /*0x15cbfbc*/ float PathLength(UnityEngine.Transform[] path);
    static /*0x15c3b5c*/ float PathLength(UnityEngine.Vector3[] path);
    static /*0x15cc5d8*/ void PutOnPath(UnityEngine.GameObject target, UnityEngine.Vector3[] path, float percent);
    static /*0x15cc670*/ void PutOnPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float percent);
    static /*0x15cc6f8*/ void PutOnPath(UnityEngine.GameObject target, UnityEngine.Transform[] path, float percent);
    static /*0x15cc824*/ void PutOnPath(UnityEngine.Transform target, UnityEngine.Transform[] path, float percent);
    static /*0x15cc938*/ UnityEngine.Vector3 PointOnPath(UnityEngine.Transform[] path, float percent);
    static /*0x15cca30*/ void DrawLine(UnityEngine.Vector3[] line);
    static /*0x15ccc98*/ void DrawLine(UnityEngine.Vector3[] line, UnityEngine.Color color);
    static /*0x15ccd58*/ void DrawLine(UnityEngine.Transform[] line);
    static /*0x15ccec4*/ void DrawLine(UnityEngine.Transform[] line, UnityEngine.Color color);
    static /*0x15cd00c*/ void DrawLineGizmos(UnityEngine.Vector3[] line);
    static /*0x15cd0f0*/ void DrawLineGizmos(UnityEngine.Vector3[] line, UnityEngine.Color color);
    static /*0x15cd1b0*/ void DrawLineGizmos(UnityEngine.Transform[] line);
    static /*0x15cd31c*/ void DrawLineGizmos(UnityEngine.Transform[] line, UnityEngine.Color color);
    static /*0x15cd464*/ void DrawLineHandles(UnityEngine.Vector3[] line);
    static /*0x15cd548*/ void DrawLineHandles(UnityEngine.Vector3[] line, UnityEngine.Color color);
    static /*0x15cd608*/ void DrawLineHandles(UnityEngine.Transform[] line);
    static /*0x15cd774*/ void DrawLineHandles(UnityEngine.Transform[] line, UnityEngine.Color color);
    static /*0x15cd8bc*/ UnityEngine.Vector3 PointOnPath(UnityEngine.Vector3[] path, float percent);
    static /*0x15cd924*/ void DrawPath(UnityEngine.Vector3[] path);
    static /*0x15cdc04*/ void DrawPath(UnityEngine.Vector3[] path, UnityEngine.Color color);
    static /*0x15cdcc4*/ void DrawPath(UnityEngine.Transform[] path);
    static /*0x15cde30*/ void DrawPath(UnityEngine.Transform[] path, UnityEngine.Color color);
    static /*0x15cdf78*/ void DrawPathGizmos(UnityEngine.Vector3[] path);
    static /*0x15ce05c*/ void DrawPathGizmos(UnityEngine.Vector3[] path, UnityEngine.Color color);
    static /*0x15ce11c*/ void DrawPathGizmos(UnityEngine.Transform[] path);
    static /*0x15ce288*/ void DrawPathGizmos(UnityEngine.Transform[] path, UnityEngine.Color color);
    static /*0x15ce3d0*/ void DrawPathHandles(UnityEngine.Vector3[] path);
    static /*0x15ce4b4*/ void DrawPathHandles(UnityEngine.Vector3[] path, UnityEngine.Color color);
    static /*0x15ce574*/ void DrawPathHandles(UnityEngine.Transform[] path);
    static /*0x15ce6e0*/ void DrawPathHandles(UnityEngine.Transform[] path, UnityEngine.Color color);
    static /*0x15ce828*/ void Resume(UnityEngine.GameObject target);
    static /*0x15ce90c*/ void Resume(UnityEngine.GameObject target, bool includechildren);
    static /*0x15cec3c*/ void Resume(UnityEngine.GameObject target, string type);
    static /*0x15ced90*/ void Resume(UnityEngine.GameObject target, string type, bool includechildren);
    static /*0x15cf1b4*/ void Resume();
    static /*0x15cf2dc*/ void Resume(string type);
    static /*0x15cf510*/ void Pause(UnityEngine.GameObject target);
    static /*0x15cf664*/ void Pause(UnityEngine.GameObject target, bool includechildren);
    static /*0x15cf994*/ void Pause(UnityEngine.GameObject target, string type);
    static /*0x15cfb48*/ void Pause(UnityEngine.GameObject target, string type, bool includechildren);
    static /*0x15cffcc*/ void Pause();
    static /*0x15d00f4*/ void Pause(string type);
    static /*0x15d0328*/ int Count();
    static /*0x15d0398*/ int Count(string type);
    static /*0x15d0590*/ int Count(UnityEngine.GameObject target);
    static /*0x15d05ec*/ int Count(UnityEngine.GameObject target, string type);
    static /*0x15d0744*/ void Stop();
    static /*0x15d0994*/ void Stop(string type);
    static /*0x15d0d14*/ void StopByName(string name);
    static /*0x15d08b8*/ void Stop(UnityEngine.GameObject target);
    static /*0x15d104c*/ void Stop(UnityEngine.GameObject target, bool includechildren);
    static /*0x15d0bc8*/ void Stop(UnityEngine.GameObject target, string type);
    static /*0x15d0f48*/ void StopByName(UnityEngine.GameObject target, string name);
    static /*0x15d137c*/ void Stop(UnityEngine.GameObject target, string type, bool includechildren);
    static /*0x15d1798*/ void StopByName(UnityEngine.GameObject target, string name, bool includechildren);
    static /*0x15b4578*/ System.Collections.Hashtable Hash(object[] args);
    static /*0x15ccb14*/ void DrawLineHelper(UnityEngine.Vector3[] line, UnityEngine.Color color, string method);
    static /*0x15cda08*/ void DrawPathHelper(UnityEngine.Vector3[] path, UnityEngine.Color color, string method);
    static /*0x15cc1c4*/ UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path);
    static /*0x15cc3e4*/ UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t);
    static /*0x15b422c*/ void Launch(UnityEngine.GameObject target, System.Collections.Hashtable args);
    static /*0x15b37b4*/ System.Collections.Hashtable CleanArgs(System.Collections.Hashtable args);
    static /*0x15d30e8*/ string GenerateID();
    /*0x15d1b6c*/ iTween(System.Collections.Hashtable h);
    /*0x15bc6e4*/ void GenerateTargets();
    /*0x15bd920*/ void GenerateRectTargets();
    /*0x15bd7a8*/ void GenerateColorTargets();
    /*0x15bd4f8*/ void GenerateVector3Targets();
    /*0x15bd268*/ void GenerateVector2Targets();
    /*0x15bd058*/ void GenerateFloatTargets();
    /*0x15bda68*/ void GenerateColorToTargets();
    /*0x15be3c4*/ void GenerateAudioToTargets();
    /*0x15c35cc*/ void GenerateStabTargets();
    /*0x15c2c50*/ void GenerateLookToTargets();
    /*0x15be6f4*/ void GenerateMoveToPathTargets();
    /*0x15bedc4*/ void GenerateMoveToTargets();
    /*0x15bf494*/ void GenerateMoveByTargets();
    /*0x15bfac4*/ void GenerateScaleToTargets();
    /*0x15c007c*/ void GenerateScaleByTargets();
    /*0x15c04e8*/ void GenerateScaleAddTargets();
    /*0x15c0948*/ void GenerateRotateToTargets();
    /*0x15c105c*/ void GenerateRotateAddTargets();
    /*0x15c14c4*/ void GenerateRotateByTargets();
    /*0x15c1964*/ void GenerateShakePositionTargets();
    /*0x15c1c80*/ void GenerateShakeScaleTargets();
    /*0x15c1f70*/ void GenerateShakeRotationTargets();
    /*0x15c2260*/ void GeneratePunchPositionTargets();
    /*0x15c25d0*/ void GeneratePunchRotationTargets();
    /*0x15c2914*/ void GeneratePunchScaleTargets();
    /*0x15c3ce4*/ void ApplyRectTargets();
    /*0x15c3ff0*/ void ApplyColorTargets();
    /*0x15c423c*/ void ApplyVector3Targets();
    /*0x15c4444*/ void ApplyVector2Targets();
    /*0x15c45e8*/ void ApplyFloatTargets();
    /*0x15c473c*/ void ApplyColorToTargets();
    /*0x15c4c58*/ void ApplyAudioToTargets();
    /*0x15c4dc8*/ void ApplyStabTargets();
    /*0x15c4dcc*/ void ApplyMoveToPathTargets();
    /*0x15c50dc*/ void ApplyMoveToTargets();
    /*0x15c52f0*/ void ApplyMoveByTargets();
    /*0x15c55d0*/ void ApplyScaleToTargets();
    /*0x15c5744*/ void ApplyLookToTargets();
    /*0x15c58a4*/ void ApplyRotateToTargets();
    /*0x15c5b18*/ void ApplyRotateAddTargets();
    /*0x15c5d40*/ void ApplyShakePositionTargets();
    /*0x15c6094*/ void ApplyShakeScaleTargets();
    /*0x15c6214*/ void ApplyShakeRotationTargets();
    /*0x15c6434*/ void ApplyPunchPositionTargets();
    /*0x15c6900*/ void ApplyPunchRotationTargets();
    /*0x15c6ca4*/ void ApplyPunchScaleTargets();
    /*0x15c6f50*/ System.Collections.IEnumerator TweenDelay();
    /*0x15c6fb8*/ void TweenStart();
    /*0x15c7a54*/ System.Collections.IEnumerator TweenRestart();
    /*0x15c7abc*/ void TweenUpdate();
    /*0x15c7b94*/ void TweenComplete();
    /*0x15c7c78*/ void TweenLoop();
    /*0x15d1b94*/ void Awake();
    /*0x15d2e5c*/ System.Collections.IEnumerator Start();
    /*0x15d2ec4*/ void Update();
    /*0x15d2f00*/ void FixedUpdate();
    /*0x15d2f3c*/ void LateUpdate();
    /*0x15d3070*/ void OnEnable();
    /*0x15d30e4*/ void OnDisable();
    /*0x15d1bc4*/ void RetrieveArgs();
    /*0x15d3114*/ void GetEasingFunction();
    /*0x15c7b28*/ void UpdatePercentage();
    /*0x15c7188*/ void CallBack(string callbackType);
    /*0x15c3940*/ void Dispose();
    /*0x15c749c*/ void ConflictCheck();
    /*0x15c7a50*/ void EnableKinematic();
    /*0x15c7d18*/ void DisableKinematic();
    /*0x15d3098*/ void ResumeDelay();
    /*0x15d3614*/ float linear(float start, float end, float value);
    /*0x15c3af8*/ float clerp(float start, float end, float value);
    /*0x15d3638*/ float spring(float start, float end, float value);
    /*0x15d36e8*/ float easeInQuad(float start, float end, float value);
    /*0x15d36fc*/ float easeOutQuad(float start, float end, float value);
    /*0x15d3718*/ float easeInOutQuad(float start, float end, float value);
    /*0x15d376c*/ float easeInCubic(float start, float end, float value);
    /*0x15d3784*/ float easeOutCubic(float start, float end, float value);
    /*0x15d37ac*/ float easeInOutCubic(float start, float end, float value);
    /*0x15d3804*/ float easeInQuart(float start, float end, float value);
    /*0x15d3820*/ float easeOutQuart(float start, float end, float value);
    /*0x15d3848*/ float easeInOutQuart(float start, float end, float value);
    /*0x15d38a4*/ float easeInQuint(float start, float end, float value);
    /*0x15d38c4*/ float easeOutQuint(float start, float end, float value);
    /*0x15d38f4*/ float easeInOutQuint(float start, float end, float value);
    /*0x15d395c*/ float easeInSine(float start, float end, float value);
    /*0x15d3994*/ float easeOutSine(float start, float end, float value);
    /*0x15d39c8*/ float easeInOutSine(float start, float end, float value);
    /*0x15d3a0c*/ float easeInExpo(float start, float end, float value);
    /*0x15d3a44*/ float easeOutExpo(float start, float end, float value);
    /*0x15d3a7c*/ float easeInOutExpo(float start, float end, float value);
    /*0x15d3aec*/ float easeInCirc(float start, float end, float value);
    /*0x15d3b14*/ float easeOutCirc(float start, float end, float value);
    /*0x15d3b3c*/ float easeInOutCirc(float start, float end, float value);
    /*0x15d3b90*/ float easeInBounce(float start, float end, float value);
    /*0x15d3bc8*/ float easeOutBounce(float start, float end, float value);
    /*0x15d3c90*/ float easeInOutBounce(float start, float end, float value);
    /*0x15d3d10*/ float easeInBack(float start, float end, float value);
    /*0x15d3d40*/ float easeOutBack(float start, float end, float value);
    /*0x15d3d80*/ float easeInOutBack(float start, float end, float value);
    /*0x15c6890*/ float punch(float amplitude, float value);
    /*0x15d3e04*/ float easeInElastic(float start, float end, float value);
    /*0x15d3e94*/ float easeOutElastic(float start, float end, float value);
    /*0x15d3f24*/ float easeInOutElastic(float start, float end, float value);

    class EasingFunction : System.MulticastDelegate
    {
        /*0x19fa578*/ EasingFunction(object object, nint method);
        /*0x19fa63c*/ float Invoke(float start, float end, float Value);
        /*0x19fa650*/ System.IAsyncResult BeginInvoke(float start, float end, float Value, System.AsyncCallback callback, object object);
        /*0x19fa700*/ float EndInvoke(System.IAsyncResult result);
    }

    class ApplyTween : System.MulticastDelegate
    {
        /*0x19fa728*/ ApplyTween(object object, nint method);
        /*0x19fa7e4*/ void Invoke();
        /*0x19fa7f8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x19fa818*/ void EndInvoke(System.IAsyncResult result);
    }

    enum EaseType
    {
        easeInQuad = 0,
        easeOutQuad = 1,
        easeInOutQuad = 2,
        easeInCubic = 3,
        easeOutCubic = 4,
        easeInOutCubic = 5,
        easeInQuart = 6,
        easeOutQuart = 7,
        easeInOutQuart = 8,
        easeInQuint = 9,
        easeOutQuint = 10,
        easeInOutQuint = 11,
        easeInSine = 12,
        easeOutSine = 13,
        easeInOutSine = 14,
        easeInExpo = 15,
        easeOutExpo = 16,
        easeInOutExpo = 17,
        easeInCirc = 18,
        easeOutCirc = 19,
        easeInOutCirc = 20,
        linear = 21,
        spring = 22,
        easeInBounce = 23,
        easeOutBounce = 24,
        easeInOutBounce = 25,
        easeInBack = 26,
        easeOutBack = 27,
        easeInOutBack = 28,
        easeInElastic = 29,
        easeOutElastic = 30,
        easeInOutElastic = 31,
        punch = 32,
    }

    enum LoopType
    {
        none = 0,
        loop = 1,
        pingPong = 2,
    }

    enum NamedValueColor
    {
        _Color = 0,
        _SpecColor = 1,
        _Emission = 2,
        _ReflectColor = 3,
    }

    class Defaults
    {
        static /*0x0*/ float time;
        static /*0x4*/ float delay;
        static /*0x8*/ iTween.NamedValueColor namedColorValue;
        static /*0xc*/ iTween.LoopType loopType;
        static /*0x10*/ iTween.EaseType easeType;
        static /*0x14*/ float lookSpeed;
        static /*0x18*/ bool isLocal;
        static /*0x1c*/ UnityEngine.Space space;
        static /*0x20*/ bool orientToPath;
        static /*0x24*/ UnityEngine.Color color;
        static /*0x34*/ float updateTimePercentage;
        static /*0x38*/ float updateTime;
        static /*0x3c*/ float lookAhead;
        static /*0x40*/ bool useRealTime;
        static /*0x44*/ UnityEngine.Vector3 up;

        static /*0x19fa824*/ Defaults();
    }

    class CRSpline
    {
        /*0x10*/ UnityEngine.Vector3[] pts;

        /*0x19fa8f8*/ CRSpline(UnityEngine.Vector3[] pts);
        /*0x19fa970*/ UnityEngine.Vector3 Interp(float t);
    }

    class <TweenDelay>d__145 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ iTween <>4__this;

        /*0x19fab70*/ <TweenDelay>d__145(int <>1__state);
        /*0x19fab98*/ void System.IDisposable.Dispose();
        /*0x19fab9c*/ bool MoveNext();
        /*0x19fac6c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x19fac74*/ void System.Collections.IEnumerator.Reset();
        /*0x19facb4*/ object System.Collections.IEnumerator.get_Current();
    }

    class <TweenRestart>d__147 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ iTween <>4__this;

        /*0x19facbc*/ <TweenRestart>d__147(int <>1__state);
        /*0x19face4*/ void System.IDisposable.Dispose();
        /*0x19face8*/ bool MoveNext();
        /*0x19fadc0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x19fadc8*/ void System.Collections.IEnumerator.Reset();
        /*0x19fae08*/ object System.Collections.IEnumerator.get_Current();
    }

    class <Start>d__229 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ iTween <>4__this;

        /*0x19fae10*/ <Start>d__229(int <>1__state);
        /*0x19fae38*/ void System.IDisposable.Dispose();
        /*0x19fae3c*/ bool MoveNext();
        /*0x19faee0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x19faee8*/ void System.Collections.IEnumerator.Reset();
        /*0x19faf28*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MoveSample : UnityEngine.MonoBehaviour
{
    /*0x19fb228*/ MoveSample();
    /*0x19faf30*/ void Start();
}

class RotateSample : UnityEngine.MonoBehaviour
{
    /*0x19fb514*/ RotateSample();
    /*0x19fb230*/ void Start();
}

class SampleInfo : UnityEngine.MonoBehaviour
{
    /*0x19fb6d4*/ SampleInfo();
    /*0x19fb51c*/ void OnGUI();
}

class PreciseLocaleText : UnityEngine.MonoBehaviour
{
    /*0x19fbba4*/ PreciseLocaleText();
    /*0x19fb6dc*/ void Start();
}

class PreciseLocale
{
    static /*0x0*/ PreciseLocale.PlatformBridge _platform;

    static /*0x19fbbac*/ PreciseLocale.PlatformBridge get_platform();
    static /*0x19fb9d4*/ string GetRegion();
    static /*0x19fb89c*/ string GetLanguageID();
    static /*0x19fb938*/ string GetLanguage();
    static /*0x19fba6c*/ string GetCurrencyCode();
    static /*0x19fbb08*/ string GetCurrencySymbol();
    /*0x19fbc48*/ PreciseLocale();

    interface PlatformBridge
    {
        string GetRegion();
        string GetLanguage();
        string GetLanguageID();
        string GetCurrencyCode();
        string GetCurrencySymbol();
    }

    class EditorBridge : PreciseLocale.PlatformBridge
    {
        /*0x19fbd90*/ EditorBridge();
        /*0x19fbc50*/ string GetRegion();
        /*0x19fbc90*/ string GetLanguage();
        /*0x19fbcd0*/ string GetLanguageID();
        /*0x19fbd10*/ string GetCurrencyCode();
        /*0x19fbd50*/ string GetCurrencySymbol();
    }

    class PreciseLocaleAndroid : PreciseLocale.PlatformBridge
    {
        static /*0x0*/ UnityEngine.AndroidJavaClass _preciseLocale;

        static /*0x19fc234*/ PreciseLocaleAndroid();
        /*0x19fbc40*/ PreciseLocaleAndroid();
        /*0x19fbd98*/ string GetRegion();
        /*0x19fbe84*/ string GetLanguage();
        /*0x19fbf70*/ string GetLanguageID();
        /*0x19fc05c*/ string GetCurrencyCode();
        /*0x19fc148*/ string GetCurrencySymbol();
    }
}

namespace XsollaSimpleJSON
{
    enum JSONBinaryTag
    {
        Array = 1,
        Class = 2,
        Value = 3,
        IntValue = 4,
        DoubleValue = 5,
        BoolValue = 6,
        FloatValue = 7,
    }

    class JSONNode
    {
        static /*0x19fcc18*/ XsollaSimpleJSON.JSONNode op_Implicit(string s);
        static /*0x19fcca4*/ string op_Implicit(XsollaSimpleJSON.JSONNode d);
        static /*0x19fcce0*/ bool op_Equality(XsollaSimpleJSON.JSONNode a, object b);
        static /*0x19fcd68*/ bool op_Inequality(XsollaSimpleJSON.JSONNode a, object b);
        static /*0x19fcd94*/ string Escape(string aText);
        static /*0x19fcf60*/ XsollaSimpleJSON.JSONNode Parse(string aJSON);
        static /*0x19fdcb8*/ XsollaSimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader);
        static /*0x19fe124*/ XsollaSimpleJSON.JSONNode LoadFromCompressedFile(string aFileName);
        static /*0x19fe174*/ XsollaSimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData);
        static /*0x19fe1c4*/ XsollaSimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64);
        static /*0x19fe214*/ XsollaSimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData);
        static /*0x19fe3a8*/ XsollaSimpleJSON.JSONNode LoadFromFile(string aFileName);
        static /*0x19fe524*/ XsollaSimpleJSON.JSONNode LoadFromBase64(string aBase64);
        /*0x19fe5d8*/ JSONNode();
        /*0x19fc2c4*/ void Add(string aKey, XsollaSimpleJSON.JSONNode aItem);
        /*0x19fc2c8*/ XsollaSimpleJSON.JSONNode get_Item(int aIndex);
        /*0x19fc2d0*/ void set_Item(int aIndex, XsollaSimpleJSON.JSONNode value);
        /*0x19fc2d4*/ XsollaSimpleJSON.JSONNode get_Item(string aKey);
        /*0x19fc2dc*/ void set_Item(string aKey, XsollaSimpleJSON.JSONNode value);
        /*0x19fc2e0*/ string get_Value();
        /*0x19fc320*/ void set_Value(string value);
        /*0x19fc324*/ int get_Count();
        /*0x19fc32c*/ void Add(XsollaSimpleJSON.JSONNode aItem);
        /*0x19fc38c*/ XsollaSimpleJSON.JSONNode Remove(string aKey);
        /*0x19fc394*/ XsollaSimpleJSON.JSONNode Remove(int aIndex);
        /*0x19fc39c*/ XsollaSimpleJSON.JSONNode Remove(XsollaSimpleJSON.JSONNode aNode);
        /*0x19fc3a4*/ System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode> get_Childs();
        /*0x19fc448*/ System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode> get_DeepChilds();
        /*0x19fc4f4*/ string ToString();
        /*0x19fc534*/ string ToString(string aPrefix);
        /*0x19fc574*/ int get_AsInt();
        /*0x19fc5a8*/ void set_AsInt(int value);
        /*0x19fc5e4*/ float get_AsFloat();
        /*0x19fc688*/ void set_AsFloat(float value);
        /*0x19fc710*/ double get_AsDouble();
        /*0x19fc7b4*/ void set_AsDouble(double value);
        /*0x19fc83c*/ decimal get_AsDecimal();
        /*0x19fc914*/ void set_AsDecimal(decimal value);
        /*0x19fc9c4*/ long get_AsLong();
        /*0x19fc9f8*/ bool get_AsBool();
        /*0x19fcab0*/ void set_AsBool(bool value);
        /*0x19fcb28*/ XsollaSimpleJSON.JSONArray get_AsArray();
        /*0x19fcba0*/ XsollaSimpleJSON.JSONClass get_AsObject();
        /*0x19fcd80*/ bool Equals(object obj);
        /*0x19fcd8c*/ int GetHashCode();
        /*0x19fd774*/ void Serialize(System.IO.BinaryWriter aWriter);
        /*0x19fd778*/ void SaveToStream(System.IO.Stream aData);
        /*0x19fd7f8*/ void SaveToCompressedStream(System.IO.Stream aData);
        /*0x19fd848*/ void SaveToCompressedFile(string aFileName);
        /*0x19fd898*/ string SaveToCompressedBase64();
        /*0x19fd8e8*/ void SaveToFile(string aFileName);
        /*0x19fdab8*/ string SaveToBase64();

        class <get_Childs>d__17 : System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ XsollaSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0x19fc414*/ <get_Childs>d__17(int <>1__state);
            /*0x19fe5e0*/ void System.IDisposable.Dispose();
            /*0x19fe5e4*/ bool MoveNext();
            /*0x19fe5fc*/ XsollaSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>.get_Current();
            /*0x19fe604*/ void System.Collections.IEnumerator.Reset();
            /*0x19fe644*/ object System.Collections.IEnumerator.get_Current();
            /*0x19fe64c*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>.GetEnumerator();
            /*0x19fe6e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_DeepChilds>d__19 : System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ XsollaSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ XsollaSimpleJSON.JSONNode <>4__this;
            /*0x30*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> <>7__wrap1;
            /*0x38*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> <>7__wrap2;

            /*0x19fc4c0*/ <get_DeepChilds>d__19(int <>1__state);
            /*0x19fe6e8*/ void System.IDisposable.Dispose();
            /*0x19fe7a0*/ bool MoveNext();
            /*0x19fec84*/ void <>m__Finally1();
            /*0x19febd4*/ void <>m__Finally2();
            /*0x19fed34*/ XsollaSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>.get_Current();
            /*0x19fed3c*/ void System.Collections.IEnumerator.Reset();
            /*0x19fed7c*/ object System.Collections.IEnumerator.get_Current();
            /*0x19fed84*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>.GetEnumerator();
            /*0x19fee28*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONArray : XsollaSimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<XsollaSimpleJSON.JSONNode> m_List;

        /*0x19fd6f8*/ JSONArray();
        /*0x19fee2c*/ XsollaSimpleJSON.JSONNode get_Item(int aIndex);
        /*0x19fef08*/ void set_Item(int aIndex, XsollaSimpleJSON.JSONNode value);
        /*0x19ff010*/ XsollaSimpleJSON.JSONNode get_Item(string aKey);
        /*0x19ff074*/ void set_Item(string aKey, XsollaSimpleJSON.JSONNode value);
        /*0x19ff11c*/ int get_Count();
        /*0x19ff164*/ void Add(string aKey, XsollaSimpleJSON.JSONNode aItem);
        /*0x19ff20c*/ XsollaSimpleJSON.JSONNode Remove(int aIndex);
        /*0x19ff2c0*/ XsollaSimpleJSON.JSONNode Remove(XsollaSimpleJSON.JSONNode aNode);
        /*0x19ff320*/ System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode> get_Childs();
        /*0x19ff3cc*/ System.Collections.IEnumerator GetEnumerator();
        /*0x19ff45c*/ string ToString();
        /*0x19ff674*/ string ToString(string aPrefix);
        /*0x19ff8f4*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Childs>d__13 : System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ XsollaSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ XsollaSimpleJSON.JSONArray <>4__this;
            /*0x30*/ System.Collections.Generic.List.Enumerator<XsollaSimpleJSON.JSONNode> <>7__wrap1;

            /*0x19ff398*/ <get_Childs>d__13(int <>1__state);
            /*0x19ff9d0*/ void System.IDisposable.Dispose();
            /*0x19ff9ec*/ bool MoveNext();
            /*0x19ffb80*/ void <>m__Finally1();
            /*0x19ffbd0*/ XsollaSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>.get_Current();
            /*0x19ffbd8*/ void System.Collections.IEnumerator.Reset();
            /*0x19ffc18*/ object System.Collections.IEnumerator.get_Current();
            /*0x19ffc20*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>.GetEnumerator();
            /*0x19ffcc4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ XsollaSimpleJSON.JSONArray <>4__this;
            /*0x28*/ System.Collections.Generic.List.Enumerator<XsollaSimpleJSON.JSONNode> <>7__wrap1;

            /*0x19ff434*/ <GetEnumerator>d__14(int <>1__state);
            /*0x19ffcc8*/ void System.IDisposable.Dispose();
            /*0x19ffce4*/ bool MoveNext();
            /*0x19ffe78*/ void <>m__Finally1();
            /*0x19ffec8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x19ffed0*/ void System.Collections.IEnumerator.Reset();
            /*0x19fff10*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONClass : XsollaSimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, XsollaSimpleJSON.JSONNode> m_Dict;

        /*0x19fd67c*/ JSONClass();
        /*0x19fff18*/ XsollaSimpleJSON.JSONNode get_Item(string aKey);
        /*0x1a00008*/ void set_Item(string aKey, XsollaSimpleJSON.JSONNode value);
        /*0x1a000d4*/ XsollaSimpleJSON.JSONNode get_Item(int aIndex);
        /*0x1a00174*/ void set_Item(int aIndex, XsollaSimpleJSON.JSONNode value);
        /*0x1a00250*/ int get_Count();
        /*0x1a002a0*/ void Add(string aKey, XsollaSimpleJSON.JSONNode aItem);
        /*0x1a003b4*/ XsollaSimpleJSON.JSONNode Remove(string aKey);
        /*0x1a00478*/ XsollaSimpleJSON.JSONNode Remove(int aIndex);
        /*0x1a00554*/ XsollaSimpleJSON.JSONNode Remove(XsollaSimpleJSON.JSONNode aNode);
        /*0x1a0071c*/ System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode> get_Childs();
        /*0x1a007c8*/ System.Collections.IEnumerator GetEnumerator();
        /*0x1a00858*/ bool ContainsKey(string s);
        /*0x1a008b0*/ System.Collections.ArrayList GetKeys();
        /*0x1a00a3c*/ System.Collections.Generic.Dictionary<string, XsollaSimpleJSON.JSONNode> GetKeyValueDict();
        /*0x1a00a44*/ string ToString();
        /*0x1a00e2c*/ string ToString(string aPrefix);
        /*0x1a01298*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <>c__DisplayClass12_0
        {
            /*0x10*/ XsollaSimpleJSON.JSONNode aNode;

            /*0x1a00714*/ <>c__DisplayClass12_0();
            /*0x1a014b8*/ bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, XsollaSimpleJSON.JSONNode> k);
        }

        class <get_Childs>d__14 : System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ XsollaSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ XsollaSimpleJSON.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, XsollaSimpleJSON.JSONNode> <>7__wrap1;

            /*0x1a00794*/ <get_Childs>d__14(int <>1__state);
            /*0x1a014fc*/ void System.IDisposable.Dispose();
            /*0x1a01518*/ bool MoveNext();
            /*0x1a016c0*/ void <>m__Finally1();
            /*0x1a01710*/ XsollaSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode>.get_Current();
            /*0x1a01718*/ void System.Collections.IEnumerator.Reset();
            /*0x1a01758*/ object System.Collections.IEnumerator.get_Current();
            /*0x1a01760*/ System.Collections.Generic.IEnumerator<XsollaSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<XsollaSimpleJSON.JSONNode>.GetEnumerator();
            /*0x1a01804*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ XsollaSimpleJSON.JSONClass <>4__this;
            /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, XsollaSimpleJSON.JSONNode> <>7__wrap1;

            /*0x1a00830*/ <GetEnumerator>d__15(int <>1__state);
            /*0x1a01808*/ void System.IDisposable.Dispose();
            /*0x1a01824*/ bool MoveNext();
            /*0x1a019f8*/ void <>m__Finally1();
            /*0x1a01a48*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1a01a50*/ void System.Collections.IEnumerator.Reset();
            /*0x1a01a90*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONData : XsollaSimpleJSON.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0x19fcc7c*/ JSONData(string aData);
        /*0x19fe0ec*/ JSONData(float aData);
        /*0x19fe07c*/ JSONData(double aData);
        /*0x19fe0b4*/ JSONData(bool aData);
        /*0x19fe044*/ JSONData(int aData);
        /*0x1a01a98*/ string get_Value();
        /*0x1a01aa0*/ void set_Value(string value);
        /*0x1a01aa8*/ string ToString();
        /*0x1a01b00*/ string ToString(string aPrefix);
        /*0x1a01b58*/ void Serialize(System.IO.BinaryWriter aWriter);
    }

    class JSONLazyCreator : XsollaSimpleJSON.JSONNode
    {
        /*0x10*/ XsollaSimpleJSON.JSONNode m_Node;
        /*0x18*/ string m_Key;

        static /*0x1a02150*/ bool op_Equality(XsollaSimpleJSON.JSONLazyCreator a, object b);
        static /*0x1a02168*/ bool op_Inequality(XsollaSimpleJSON.JSONLazyCreator a, object b);
        /*0x19feee0*/ JSONLazyCreator(XsollaSimpleJSON.JSONNode aNode);
        /*0x19fffdc*/ JSONLazyCreator(XsollaSimpleJSON.JSONNode aNode, string aKey);
        /*0x1a01e18*/ void Set(XsollaSimpleJSON.JSONNode aVal);
        /*0x1a01e6c*/ XsollaSimpleJSON.JSONNode get_Item(int aIndex);
        /*0x1a01ed0*/ void set_Item(int aIndex, XsollaSimpleJSON.JSONNode value);
        /*0x1a01f50*/ XsollaSimpleJSON.JSONNode get_Item(string aKey);
        /*0x1a01fc0*/ void set_Item(string aKey, XsollaSimpleJSON.JSONNode value);
        /*0x1a02048*/ void Add(XsollaSimpleJSON.JSONNode aItem);
        /*0x1a020c8*/ void Add(string aKey, XsollaSimpleJSON.JSONNode aItem);
        /*0x1a02180*/ bool Equals(object obj);
        /*0x1a02198*/ int GetHashCode();
        /*0x1a021a0*/ string ToString();
        /*0x1a021e0*/ string ToString(string aPrefix);
        /*0x1a02220*/ int get_AsInt();
        /*0x1a022a4*/ void set_AsInt(int value);
        /*0x1a0232c*/ float get_AsFloat();
        /*0x1a023b0*/ void set_AsFloat(float value);
        /*0x1a02438*/ double get_AsDouble();
        /*0x1a024bc*/ void set_AsDouble(double value);
        /*0x1a02544*/ bool get_AsBool();
        /*0x1a025c8*/ void set_AsBool(bool value);
        /*0x1a02650*/ XsollaSimpleJSON.JSONArray get_AsArray();
        /*0x1a026b8*/ XsollaSimpleJSON.JSONClass get_AsObject();
    }

    class JSON
    {
        static /*0x1a02720*/ XsollaSimpleJSON.JSONNode Parse(string aJSON);
    }
}

namespace Garlic
{
    class GarlicRuntimeMemoryTracker
    {
        static /*0x0*/ System.Collections.Generic.List<Garlic.GarlicRuntimeMemoryTracker.mem_line_pair> mem_list;

        static /*0x1a02724*/ void init();
        static /*0x1a02808*/ void record();
        static /*0x1a029b8*/ void print_log();

        class mem_line_pair
        {
            /*0x10*/ long mem_used_byte;
            /*0x18*/ int line_number;

            /*0x1a02988*/ mem_line_pair(long mem_used_byte, int line_number);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x1a02c04*/ uint ComputeStringHash(string s);
}
