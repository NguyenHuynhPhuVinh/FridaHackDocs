class <Module>
{
}

class FireMgr : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ FireMgr();
    /*0x321cf0*/ void Die();
}

class RainControl : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.ParticleSystem particle;
    /*0x28*/ UnityEngine.AudioSource audioSource;

    /*0x31c640*/ RainControl();
    /*0x32e1c0*/ void Update();
}

class FireLine : UnityEngine.MonoBehaviour
{
    /*0x20*/ float fadeTime;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.GameObject> fireArray;
    /*0x30*/ System.Collections.Generic.List<float> fireY;
    /*0x38*/ float speed;
    /*0x3c*/ int theFireRow;

    /*0x321c20*/ FireLine();
    /*0x321660*/ void InitFireLine();
    /*0x3215f0*/ System.Collections.IEnumerator Enumerator();
    /*0x321810*/ void Start();
    /*0x321ae0*/ void Update();
    /*0x3215c0*/ void Die();

    class <Enumerator>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ FireLine <>4__this;

        /*0x32f460*/ <Enumerator>d__6(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x32f270*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x32f420*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class IceExplodeControl : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.SpriteRenderer r;
    /*0x28*/ UnityEngine.Color color;

    /*0x31c640*/ IceExplodeControl();
    /*0x3247e0*/ void Start();
    /*0x324790*/ void FixedUpdate();
}

class MindControl : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ MindControl();
    /*0x32cd50*/ void Die();
}

class WaterSplashCtrl : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ WaterSplashCtrl();
    /*0x330540*/ void Die();
}

class ConveyBeltMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ConveyBeltMgr Instance;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.RectTransform> belts;
    /*0x28*/ System.Collections.Generic.List<DroppedCard> droppedCards;
    /*0x30*/ UnityEngine.RectTransform cardParents;
    /*0x38*/ float time;
    /*0x3c*/ float speed;
    /*0x40*/ float interval;
    /*0x44*/ int cardCount;
    /*0x48*/ System.Collections.Generic.List<PlantType> plants;

    /*0x31ed70*/ ConveyBeltMgr();
    /*0x31c650*/ void Awake();
    /*0x31ecf0*/ void Update();
    /*0x31cd80*/ int GetCardCount(PlantType theSeedType);
    /*0x31c6c0*/ void BeltUpdate();
    /*0x31c990*/ void CardUpdate();
    /*0x31eae0*/ void NewCardUpdate();
    /*0x31e6c0*/ PlantType GetCardType();
    /*0x31cee0*/ System.Collections.Generic.List<PlantType> GetCardPool();
    /*0x31cc00*/ bool FlagConveyPlant(PlantType theSeedType);

    class <>c__DisplayClass15_0
    {
        /*0x10*/ PlantType targetType;

        /*0x32f970*/ <>c__DisplayClass15_0();
        /*0x32f960*/ bool <GetCardType>b__0(PlantType n);
    }
}

class FlagMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ int flag;
    /*0x24*/ bool once;
    /*0x28*/ UnityEngine.UI.GridLayoutGroup grid;
    /*0x30*/ UnityEngine.RectTransform flag1;
    /*0x38*/ UnityEngine.RectTransform flag2;
    /*0x40*/ UnityEngine.RectTransform flag3;
    /*0x48*/ UnityEngine.RectTransform flag4;
    /*0x50*/ UnityEngine.RectTransform flag5;
    /*0x58*/ UnityEngine.RectTransform flag6;
    /*0x60*/ UnityEngine.RectTransform flag7;
    /*0x68*/ UnityEngine.RectTransform flag8;
    /*0x70*/ UnityEngine.RectTransform flag9;
    /*0x78*/ UnityEngine.RectTransform flag10;
    /*0x80*/ int wave;

    /*0x31c640*/ FlagMgr();
    /*0x321e60*/ void Start();
    /*0x321eb0*/ void Update();
    /*0x321d50*/ void FlagUpdate();
}

class Glove : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Glove Instance;
    /*0x20*/ bool isPickUp;
    /*0x28*/ UnityEngine.GameObject defaultParent;
    /*0x30*/ float fullCD;
    /*0x34*/ float CD;
    /*0x38*/ bool avaliable;
    /*0x40*/ UnityEngine.RectTransform r;
    /*0x48*/ Mouse m;
    /*0x50*/ UnityEngine.Sprite zombieGlove;
    /*0x58*/ UnityEngine.Sprite plantGlove;
    /*0x60*/ bool isZombie;

    /*0x323730*/ Glove();
    /*0x323270*/ void SwitchStatus();
    /*0x322d90*/ void Awake();
    /*0x3231c0*/ void Start();
    /*0x323050*/ void PickUp();
    /*0x3230f0*/ void PutDown();
    /*0x322fd0*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
    /*0x3233a0*/ void Update();
    /*0x322df0*/ void CDUpdate();
}

class GlowMgr : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ GlowMgr();
}

class HammerMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ HammerMgr Instance;
    /*0x20*/ PlantType theHammerEffect;
    /*0x24*/ bool isPickUp;
    /*0x28*/ UnityEngine.GameObject defaultParent;
    /*0x30*/ float fullCD;
    /*0x34*/ float CD;
    /*0x38*/ bool avaliable;
    /*0x40*/ UnityEngine.RectTransform r;
    /*0x48*/ Mouse m;
    /*0x50*/ UnityEngine.Animator anim;

    /*0x324770*/ HammerMgr();
    /*0x323a40*/ void Awake();
    /*0x324160*/ bool SwitchType(PlantType plantType);
    /*0x324240*/ void SwitchUpdate();
    /*0x323d00*/ void EffectZombie(Zombie zombie);
    /*0x324020*/ void Start();
    /*0x323eb0*/ void PickUp();
    /*0x323f50*/ void PutDown();
    /*0x323e40*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
    /*0x3243d0*/ void Update();
    /*0x323aa0*/ void CDUpdate();
    /*0x323c70*/ void CrushZombie();
    /*0x323750*/ void AnimCrush();
}

class InGameBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ int buttonNumber;
    /*0x30*/ UnityEngine.GameObject thisMenu;
    /*0x38*/ UnityEngine.Vector3 originPosition;
    /*0x48*/ UnityEngine.Sprite originSprite;
    /*0x50*/ UnityEngine.UI.Image image;
    /*0x58*/ UnityEngine.RectTransform rectTransform;
    /*0x60*/ bool existItemOnMouse;

    /*0x31c640*/ InGameBtn();
    /*0x324850*/ void Awake();
    /*0x3266f0*/ void Start();
    /*0x3254a0*/ void OnMouseEnter();
    /*0x325590*/ void OnMouseExit();
    /*0x325600*/ void OnMouseUpAsButton();
    /*0x325380*/ void OnMouseDown();
    /*0x3267c0*/ void Update();
    /*0x326000*/ void ShowCards();
    /*0x326670*/ void SpeedTrigger();
    /*0x324d40*/ void GetLastCards();
    /*0x3248f0*/ void ChangeScene();
    /*0x324a50*/ void ChangeStrings(SceneType sceneType);

    class <>c__DisplayClass17_0
    {
        /*0x10*/ CardUI c;

        /*0x32f970*/ <>c__DisplayClass17_0();
        /*0x32f980*/ bool <GetLastCards>b__0(GameAPP.LastCards card);
    }

    class <>c__DisplayClass17_1
    {
        /*0x10*/ GameAPP.LastCards item;

        /*0x32f970*/ <>c__DisplayClass17_1();
        /*0x32f9b0*/ bool <GetLastCards>b__1(CardUI card);
    }
}

class InGameUI : BaseMenu
{
    static /*0x0*/ InGameUI Instance;
    /*0x30*/ CardUI[] cardOnBank;
    /*0x38*/ UnityEngine.GameObject[] seed;
    /*0x40*/ TMPro.TextMeshProUGUI sun;
    /*0x48*/ string sun2;
    /*0x50*/ UnityEngine.GameObject ShovelBank;
    /*0x58*/ UnityEngine.GameObject Bottom;
    /*0x60*/ UnityEngine.GameObject SeedBank;
    /*0x68*/ UnityEngine.GameObject LevProgress;
    /*0x70*/ UnityEngine.GameObject LevelName1;
    /*0x78*/ UnityEngine.GameObject LevelName2;
    /*0x80*/ UnityEngine.GameObject LevelName3;
    /*0x88*/ UnityEngine.GameObject GloveBank;
    /*0x90*/ UnityEngine.GameObject BackToMenu;
    /*0x98*/ UnityEngine.GameObject SlowTrigger;
    /*0xa0*/ UnityEngine.GameObject Difficulty;
    /*0xa8*/ UnityEngine.GameObject IngameMenu;
    /*0xb0*/ UnityEngine.GameObject ZombieNum;
    /*0xb8*/ UnityEngine.GameObject HammerBank;
    /*0xc0*/ UnityEngine.GameObject StartBattle;
    /*0xc8*/ UnityEngine.GameObject Stars;
    /*0xd0*/ UnityEngine.GameObject MiniMap;
    /*0xd8*/ UnityEngine.GameObject MiniMapCtrl;
    /*0xe0*/ UnityEngine.GameObject CameraCtrl;
    /*0xe8*/ UnityEngine.GameObject MoneyBank;
    /*0xf0*/ UnityEngine.GameObject ConveyorBelt;
    /*0xf8*/ UnityEngine.GameObject ShowCardBank;
    /*0x100*/ UnityEngine.GameObject ShowPlantHealth;
    /*0x108*/ UnityEngine.GameObject ShowZombieHealth;
    /*0x110*/ UnityEngine.GameObject grid;
    /*0x118*/ UnityEngine.Transform sunPos;
    /*0x120*/ UnityEngine.GameObject ChangeGlove;
    /*0x128*/ UnityEngine.GameObject Inputs;
    /*0x130*/ UnityEngine.GameObject DrawCardsHead;
    /*0x138*/ UnityEngine.GameObject lookBuff;
    /*0x140*/ UnityEngine.GameObject lookRogueCard;
    /*0x148*/ TMPro.TextMeshProUGUI[] T;
    /*0x150*/ System.Collections.Generic.List<CardUI> cards;
    /*0x158*/ int avaliableCardCount;
    /*0x160*/ UnityEngine.GameObject progress2;
    /*0x168*/ UnityEngine.GameObject changeTowards;
    /*0x170*/ UnityEngine.GameObject lookNormalCard;
    /*0x178*/ UnityEngine.GameObject lookColorfulCard;
    /*0x180*/ UnityEngine.GameObject evacuate;
    /*0x188*/ System.Collections.Generic.List<CanvasUpUI> ups;
    /*0x190*/ Towards towards;
    /*0x198*/ Board board;
    /*0x1a0*/ float timer;
    /*0x1a8*/ System.Collections.Generic.Dictionary<int, string> levelDescriptions;
    /*0x1b0*/ System.Collections.Generic.Dictionary<SkinLevel, string> skinLevelDescription;

    /*0x329e50*/ InGameUI();
    /*0x32b8f0*/ System.Collections.Generic.List<CardUI> get_Cards();
    /*0x32ba00*/ bool get_Full();
    /*0x326e30*/ void ChangeTowards(UnityEngine.GameObject head);
    /*0x329dd0*/ void UpperUI();
    /*0x327f30*/ void LowerUI();
    /*0x328060*/ void OnExit();
    /*0x326a70*/ void Awake();
    /*0x328650*/ void SetLevelName(string name);
    /*0x327000*/ void GetCard(UnityEngine.GameObject obj);
    /*0x3295e0*/ bool UnlockCard(PlantType theSeedType);
    /*0x326fb0*/ void Evacuate();
    /*0x328fe0*/ void Start();
    /*0x3268c0*/ bool AddCardToBank(CardUI card, bool quick);
    /*0x328290*/ void RemoveCardFromBank(CardUI card);
    /*0x327fe0*/ System.Collections.IEnumerator MoveCard(CardUI card, bool quick);
    /*0x329780*/ void Update();
    /*0x3281a0*/ void PauseGame();
    /*0x3286e0*/ void SetUniqueText(TMPro.TextMeshProUGUI[] T);
    /*0x326db0*/ void ChangeString(TMPro.TextMeshProUGUI[] T, string name);

    class <>c
    {
        static /*0x0*/ InGameUI.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__64_0;

        static /*0x32f9e0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x32f930*/ bool <Update>b__64_0(Plant p);
    }

    class <MoveCard>d__63 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CardUI card;
        /*0x28*/ bool quick;
        /*0x2c*/ UnityEngine.Vector3 <startPosition>5__2;
        /*0x38*/ UnityEngine.Vector3 <target>5__3;
        /*0x44*/ float <elapsedTime>5__4;
        /*0x48*/ float <duration>5__5;

        /*0x32f460*/ <MoveCard>d__63(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x32f700*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x32f8f0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class EveManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ EveManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ System.Collections.Generic.List<SceneType> SceneOrder;

    static /*0x31f830*/ PlantType GetPlantType(int theColumn);
    /*0x321330*/ EveManager();
    /*0x31eed0*/ void Awake();
    /*0x3211e0*/ void StartEveMode();
    /*0x3211b0*/ void StartEveGame();
    /*0x320d60*/ void SaveThePlant();
    /*0x3203d0*/ void LoadPlants();
    /*0x320fa0*/ void SetPlant();
    /*0x31ee90*/ void AutoGame();
    /*0x3210a0*/ void ShowPlantCards();
    /*0x31f1e0*/ void Balanced(UnityEngine.Transform parent);
    /*0x3208b0*/ void SaveCustomIZ();
    /*0x31f4d0*/ void ChangeMap();
    /*0x31f700*/ SceneType GetNextSceneType(SceneType currentScene);
}

class InGameUI_IZ : BaseMenu
{
    static /*0x0*/ InGameUI_IZ Instance;
    /*0x30*/ CardUI[] cardOnBank;
    /*0x38*/ UnityEngine.GameObject[] seed;
    /*0x40*/ System.Collections.Generic.List<ZombieType> customCards;
    /*0x48*/ System.Collections.Generic.List<IZECard> zombieCards;
    /*0x50*/ TMPro.TextMeshProUGUI sun;
    /*0x58*/ UnityEngine.GameObject shovel;
    /*0x60*/ UnityEngine.GameObject glove;
    /*0x68*/ UnityEngine.Transform sunPos;

    static /*0x327630*/ IZData GetCustomIZData();
    static /*0x327580*/ IZData GetCustomIZData(string name);
    /*0x327d00*/ InGameUI_IZ();
    /*0x327e20*/ System.Collections.Generic.List<CardUI> get_Cards();
    /*0x327310*/ void Awake();
    /*0x327c30*/ void Update();
    /*0x327b20*/ void ShowZombieCard();
    /*0x327160*/ bool AddCardToBank(CardUI card);
    /*0x327770*/ void RemoveCardFromBank(CardUI card);
    /*0x327700*/ System.Collections.IEnumerator MoveCard(CardUI card);

    class <MoveCard>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CardUI card;
        /*0x28*/ UnityEngine.Vector3 <startPosition>5__2;
        /*0x34*/ UnityEngine.Vector3 <target>5__3;
        /*0x40*/ float <elapsedTime>5__4;
        /*0x44*/ float <duration>5__5;

        /*0x32f460*/ <MoveCard>d__16(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x32f490*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x32f6c0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class LoseMenuBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ LoseMenuBtn.LoseBtnType type;
    /*0x24*/ UnityEngine.Vector3 originPosition;
    /*0x30*/ UnityEngine.RectTransform rectTransform;

    /*0x31c640*/ LoseMenuBtn();
    /*0x32bfa0*/ void Start();
    /*0x32bbd0*/ void OnMouseEnter();
    /*0x32bbe0*/ void OnMouseExit();
    /*0x32bb40*/ void OnMouseDown();
    /*0x32bc20*/ void OnMouseUp();

    enum LoseBtnType
    {
        Quit = 0,
        Restart = 1,
        TryAgain = 2,
    }
}

class ProgressMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.UI.Slider slider;
    static /*0x8*/ Board board;
    /*0x20*/ Zombie zombie;

    /*0x31c640*/ ProgressMgr();
    /*0x32dd50*/ void Awake();
    /*0x32dfa0*/ void Update();
    /*0x32de10*/ Zombie GetBoss();
}

class ShovelMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool isPickUp;
    /*0x28*/ UnityEngine.GameObject defaultParent;
    /*0x30*/ Mouse m;

    /*0x31c640*/ ShovelMgr();
    /*0x32e4c0*/ void Start();
    /*0x32e350*/ void PickUp();
    /*0x32e3f0*/ void PutDown();
    /*0x32e2e0*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
    /*0x32e510*/ void Update();
}

class StartGameBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ UnityEngine.Sprite originSprite;
    /*0x30*/ UnityEngine.UI.Image image;
    /*0x38*/ UnityEngine.Vector3 originPosition;
    /*0x48*/ UnityEngine.RectTransform rectTransform;
    /*0x50*/ bool clicked;

    /*0x31c640*/ StartGameBtn();
    /*0x32f1a0*/ void Start();
    /*0x32e8a0*/ void OnMouseEnter();
    /*0x32e900*/ void OnMouseExit();
    /*0x32e800*/ void OnMouseDown();
    /*0x32e980*/ void OnMouseUp();
}

class ActiveStar : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject mask;
    /*0x28*/ UnityEngine.RectTransform rectTransform;

    /*0x31c640*/ ActiveStar();
    /*0x31c520*/ void Awake();
    /*0x31c5b0*/ void Update();
}

class PassiveStar : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject mask;
    /*0x28*/ UnityEngine.RectTransform rectTransform;

    /*0x31c640*/ PassiveStar();
    /*0x32cef0*/ void Awake();
    /*0x32cf80*/ void Update();
}

class UIDifficulty : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI t;

    /*0x31c640*/ UIDifficulty();
    /*0x32fa50*/ void Start();
    /*0x32faa0*/ void Update();
}

class UIProgress2 : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI t;
    /*0x28*/ Board Board;
    /*0x30*/ float timer;

    /*0x31c640*/ UIProgress2();
    /*0x32fd40*/ void Start();
    /*0x32fdc0*/ void Update();
}

class UIZombieNum : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI t;
    /*0x28*/ Board board;

    /*0x31c640*/ UIZombieNum();
    /*0x32fff0*/ void Start();
    /*0x330070*/ void Update();
}

class MainMenu : BaseMenu
{
    /*0x32c760*/ MainMenu();
    /*0x32c030*/ void AnimOver();
}

class MainMenu_Btn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ int buttonNumber;
    /*0x30*/ UnityEngine.GameObject thisMenu;
    /*0x38*/ UnityEngine.Sprite originSprite;
    /*0x40*/ UnityEngine.UI.Image image;
    /*0x48*/ UnityEngine.Vector3 originPosition;
    /*0x58*/ UnityEngine.RectTransform rectTransform;

    /*0x31c640*/ MainMenu_Btn();
    /*0x32c690*/ void Start();
    /*0x32c170*/ void OnMouseEnter();
    /*0x32c1f0*/ void OnMouseExit();
    /*0x32c0a0*/ void OnMouseDown();
    /*0x32c250*/ void OnMouseUp();
}

class PasueMenuRecheck : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ PasueMenuRecheck();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class PauseMenu : BaseMenu
{
    static /*0x0*/ PauseMenu Instance;
    /*0x30*/ UnityEngine.GameObject checkQuit;
    /*0x38*/ UnityEngine.GameObject checkRestart;
    /*0x40*/ UnityEngine.GameObject btnLookAlmanac;
    /*0x48*/ UnityEngine.GameObject btnRestart;
    /*0x50*/ UnityEngine.GameObject btnQuit;
    /*0x58*/ UnityEngine.GameObject backToGame;
    /*0x60*/ UnityEngine.GameObject travelBuff;
    /*0x68*/ UnityEngine.GameObject lookBuff;
    /*0x70*/ UnityEngine.GameObject save;
    /*0x78*/ UnityEngine.GameObject lookCrisis;
    /*0x80*/ UnityEngine.GameObject lookJigs;
    /*0x88*/ UnityEngine.GameObject lookTreasure;
    /*0x90*/ UnityEngine.GameObject showPlantHealth;
    /*0x98*/ UnityEngine.GameObject showZombieHealth;
    /*0xa0*/ bool isRecheck;

    /*0x32c760*/ PauseMenu();
    /*0x32d020*/ void Awake();
    /*0x32dd00*/ void Update();
    /*0x32dbd0*/ void SwitchJigs();
    /*0x32db50*/ void LookTreasure();
}

class PauseMenu_Btn : UnityEngine.MonoBehaviour
{
    /*0x20*/ int buttonNumber;
    /*0x28*/ UnityEngine.GameObject thisMenu;
    /*0x30*/ UnityEngine.Vector3 originPosition;
    /*0x40*/ UnityEngine.RectTransform rectTransform;

    /*0x31c640*/ PauseMenu_Btn();
    /*0x32dac0*/ void Start();
    /*0x32bbd0*/ void OnMouseEnter();
    /*0x32d340*/ void OnMouseExit();
    /*0x32d2b0*/ void OnMouseDown();
    /*0x32d380*/ void OnMouseUp();
    /*0x32d980*/ void Restart();
}

class MapEditor : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool build;
    /*0x24*/ int theTotalColumn;
    /*0x28*/ int theTotalRow;
    /*0x2c*/ int startColumn;
    /*0x30*/ int endColumn;
    /*0x34*/ int startRow;
    /*0x38*/ int endRow;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.GameObject> objs;
    /*0x48*/ System.Collections.Generic.List<UnityEngine.GameObject> objs2;

    /*0x32cca0*/ MapEditor();
    /*0x32cc80*/ void OnDrawGizmos();
    /*0x32c770*/ void Build();
}

class MusicVolume : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.UI.Slider slider;

    /*0x31c640*/ MusicVolume();
    /*0x32cdb0*/ void Start();
    /*0x32ce60*/ void Update();
}

class RogueShower : UnityEngine.MonoBehaviour
{
    /*0x20*/ RogueManager manager;

    /*0x31c640*/ RogueShower();
    /*0x32e2b0*/ void Awake();
}

class SoundVolume : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.UI.Slider slider;

    /*0x31c640*/ SoundVolume();
    /*0x32e6c0*/ void Start();
    /*0x32e770*/ void Update();
}

class ListExtensions
{
    static /*0x0*/ System.Random random;

    static /*0x32bac0*/ ListExtensions();
    static /*0x2a5510*/ T GetRandom<T>(System.Collections.Generic.List<T> list);
    static /*0x177be0*/ void Shuffle<T>(System.Collections.Generic.IList<T> list);
    static /*0x32ba50*/ void SetPositonIgnoreZ(UnityEngine.Transform transform, UnityEngine.Vector3 target);
}

class AbyssBuffIcon : UIButton
{
    /*0x60*/ TMPro.TextMeshProUGUI count;
    /*0x68*/ AbyssBuff theBuffType;
    /*0x70*/ UnityEngine.GameObject descriptionHead;
    /*0x78*/ TMPro.TextMeshProUGUI description;
    /*0x80*/ UnityEngine.UI.Image icon;

    /*0x317730*/ AbyssBuffIcon();
    /*0x3175b0*/ void Start();
    /*0x317440*/ void SetIconSprite();
    /*0x317170*/ void OnMouseEnter();
    /*0x3171a0*/ void OnMouseExit();
    /*0x3171d0*/ void OnMouseUpAsButton();
}

class AbyssManager : UnityEngine.MonoBehaviour
{
    static float const_damage = 0.25;
    static float const_attackSpeed = 0.25;
    static float const_moreHealth = 0.30000001192092896;
    static int const_recoverPer15s = 300;
    static float const_strikeRate = 0.10000000149011612;
    static float const_strikeDmg = 0.699999988079071;
    static float const_damage_lostHealth = 0.30000001192092896;
    static float const_defence_lostHealth = 0.05999999865889549;
    static float const_gloveSpeed = 0.30000001192092896;
    static float const_hammerSpeed = 0.30000001192092896;
    static float const_cardSpeed = 0.30000001192092896;
    static int const_cardLessCost = 10;
    static int const_extraStartSun = 150;
    static int const_moreSuperPlant = 5;
    static int const_moreUltiPlant = 1;
    static int const_morePlantCount = 10;
    static int const_healthGemCost = 150;
    static float const_speedGemCost = 0.10000000149011612;
    static float const_strikeRateGemCost = 0.10000000149011612;
    static float const_strikeDmgGemCost = 0.5;
    static float const_gem_dmg = 0.15000000596046448;
    static float const_gem_healthDmg = 0.30000001192092896;
    static float const_gem_strikeDmg = 0.25;
    static /*0x0*/ AbyssManager _instance;
    static /*0x8*/ System.Collections.Generic.Dictionary<AbyssBuff, System.ValueTuple<string, int>> abyssBuffDescription;
    /*0x20*/ int currentBuffCount;
    /*0x24*/ float damage;
    /*0x28*/ float stealHealth;
    /*0x2c*/ float strikeRate;
    /*0x30*/ float strikeDmg;
    /*0x34*/ float attackSpeed;
    /*0x38*/ float gloveSpeed;
    /*0x3c*/ float cardSpeed;
    /*0x40*/ int recoverCount;
    /*0x44*/ float moreHealth;
    /*0x48*/ int superPlantCount;
    /*0x4c*/ int ultiPlantCount;
    /*0x50*/ int maxPlantCount;
    /*0x54*/ int extraSun;
    /*0x58*/ int cardLessCost;
    /*0x5c*/ float damage_lostHealth;
    /*0x60*/ float defence_loseHealth;
    /*0x64*/ float hammerSpeed;
    /*0x68*/ int money;
    /*0x6c*/ int refreshCount;
    /*0x70*/ System.Collections.Generic.Dictionary<AbyssBuff, int> currentBuffs;
    /*0x78*/ System.Collections.Generic.Dictionary<AbyssBuff, int> currentBuffInBag;
    /*0x80*/ System.Collections.Generic.Dictionary<PlantType, int> plantLevels;
    /*0x88*/ AbyssStatistic abyssStatistic;
    /*0x98*/ System.Collections.Generic.List<AbyssBuff> buffs;
    /*0xa0*/ bool[] buffsSold;
    /*0xa8*/ AbyssHardMode hardMode;
    /*0xb0*/ System.Collections.Generic.List<AbyssManager.Timer> timers;
    /*0xb8*/ System.Collections.Generic.Dictionary<int, string> environmentDescription;

    static /*0x31ac10*/ AbyssManager();
    static /*0x31c340*/ AbyssManager get_Instance();
    /*0x31bc90*/ AbyssManager();
    /*0x317980*/ void Awake();
    /*0x319890*/ void Start();
    /*0x31a710*/ void Update();
    /*0x31c480*/ int get_MaxBuffCount();
    /*0x3199a0*/ void UpdateStatistics(TMPro.TextMeshProUGUI statistics);
    /*0x318310*/ void LevelSettings(Board board, int level);
    /*0x317fa0*/ float GetBasicDamageAdder(PlantType thePlantType);
    /*0x3194e0*/ void ReinforcePlant(Plant plant);
    /*0x318140*/ void GhostPlant(Board board);
    /*0x319870*/ void SplitZombie(Board board);
    /*0x3193e0*/ void RecoverZombie();
    /*0x317ec0*/ void FastAppear(Board board);
    /*0x317f40*/ void FastZombie(Board board);
    /*0x31a8f0*/ void ZombieMoreHealth(Board board);
    /*0x31a800*/ void ZombieDefence(Board board);
    /*0x318e00*/ void MoreZombie(Board board);
    /*0x31a890*/ void ZombieMoreDamage(Board board);
    /*0x31ab10*/ void ZombieStar();
    /*0x3191e0*/ void PlantInjury();
    /*0x31a980*/ void ZombieRecover(Board board);
    /*0x3192e0*/ void PlantRecover(Board board);
    /*0x3181f0*/ void Injury(Board board);
    /*0x319740*/ void SetZombieStar(Board board);
    /*0x3180c0*/ void GetBuff(AbyssBuff buffType);
    /*0x319550*/ void RemoveBuff(AbyssBuff buffType, bool inBag);
    /*0x318e60*/ void MoveFromBag(AbyssBuff buffType);
    /*0x3190a0*/ void MoveToBag(AbyssBuff buffType);
    /*0x318c70*/ void ListToDic(System.Collections.Generic.List<AbyssData> list, bool bag);
    /*0x317cd0*/ System.Collections.Generic.List<AbyssData> DicToList(bool bag);
    /*0x318b30*/ void ListToDic_level(System.Collections.Generic.List<AbyssPlantLevel> list);
    /*0x317ae0*/ System.Collections.Generic.List<AbyssPlantLevel> DicToList_level();
    /*0x317740*/ void AbyssUpdate(Board board);
    /*0x317870*/ void AddTimer(float interval, System.Action<Board> action, bool startImmediately);

    class Timer
    {
        /*0x10*/ float Interval;
        /*0x14*/ float RemainingTime;
        /*0x18*/ System.Action<Board> Action;

        /*0x429230*/ Timer(float interval, System.Action<Board> action, bool startImmediately);
        /*0x4291e0*/ void Update(Board board, float deltaTime);
    }
}

struct AbyssStatistic
{
    /*0x10*/ int thePlantCount;
    /*0x14*/ int theSuperCount;
    /*0x18*/ int theUltiCount;
}

enum AbyssBuff
{
    强力打击 = 0,
    光合作用 = 1,
    精准打击 = 2,
    致命暴击 = 3,
    极速连射 = 4,
    狂战士I = 5,
    狂战士II = 6,
    极速战备 = 7,
    全息制冷 = 8,
    精打细算 = 9,
    整装待发 = 10,
    再生之力 = 11,
    超级之力 = 12,
    究极之力 = 13,
    合理密植 = 14,
    生命宝石 = 15,
    速度宝石 = 16,
    力量宝石I = 17,
    力量宝石II = 18,
    合理投资 = 19,
    零元购 = 20,
    锤锤乐 = 21,
    无限火力 = 22,
    残暴之力 = 23,
    生生不息 = 24,
    高级投资 = 25,
    力量宝石III = 26,
    阳光宝石 = 27,
    高级密植 = 28,
    高级战备 = 29,
}

enum AbyssHardMode
{
    Default = 0,
    Hard = 1,
    Extreme = 2,
}

class AchievementBtn : UIBtn
{
    /*0x60*/ UnityEngine.GameObject pageToOpten;

    /*0x317730*/ AchievementBtn();
    /*0x417e40*/ void OnMouseUpAsButton();
}

class AchievementClip : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<Achievement, System.Tuple<string, string>> achievementsText;
    /*0x20*/ UnityEngine.GameObject trophy;
    /*0x28*/ UnityEngine.GameObject introduce;
    /*0x30*/ UnityEngine.UI.Image image;
    /*0x38*/ UnityEngine.Sprite highlightSprite;
    /*0x40*/ System.Collections.Generic.List<AchievementClip> childs;
    /*0x48*/ int index;
    /*0x4c*/ Achievement _index;
    /*0x50*/ UnityEngine.Sprite originalSprite;

    static /*0x418da0*/ AchievementClip();
    /*0x41a440*/ AchievementClip();
    /*0x4181c0*/ void OnDrawGizmosSelected();
    /*0x4186b0*/ void Start();
    /*0x4185a0*/ void SetText(TMPro.TextMeshProUGUI text, byte index);
    /*0x418500*/ void OnMouseEnter();
    /*0x418560*/ void OnMouseExit();
}

enum AchievementType
{
    Default = 0,
    Challenge = 1,
}

enum Achievement
{
    Welcome = 0,
    PeaSunflower = 1,
    GatlingPea = 2,
    TwinFlower = 3,
    SuperGatling = 4,
    CherryPaper = 5,
    BigWallNut = 6,
    Puff = 7,
    SunBomb = 8,
    CherryPaper95 = 9,
    BigWallNut2 = 10,
    BigWallNut3 = 11,
    HypnoShroom = 12,
    JacksonZombie = 13,
    ScaredyHypno = 14,
    HypnoNut = 15,
    LilyPad = 16,
    ThreePeater = 17,
    SquashKelp = 18,
    ThreeSpike = 19,
    SunSeaShroom = 20,
    StarBlover = 21,
    MagnetShroom = 22,
    CornCabbage = 23,
    GarlicCorn = 24,
    CabbageUmbrella = 25,
    GoldMelon = 26,
    SquashTorch = 27,
    UltimateTorch = 28,
    Superkelp = 29,
    DarkThreePeater = 30,
    AshThreePeater = 31,
    SuperThreePeater = 32,
    MagnetCactus = 33,
    SuperStar = 34,
    UltimateStar = 35,
    MagnetShroom2 = 36,
    UltimateStar2 = 37,
    HypnoMagnet = 38,
    SunMagnet = 39,
    SuperCherryShooter = 40,
    UltimateGatling = 41,
    HypnoEmperor = 42,
    CobCannon = 43,
    IceCannon = 44,
    FireCannon = 45,
    UltimateCannon = 46,
    SuperUmbrella = 47,
    EmeraldUmbrella = 48,
    RedEmeraldUmbrella = 49,
    Plantern = 50,
    SuperFume = 51,
    UltimateFume = 52,
    UltimteGloom = 53,
    CattailPlant = 54,
    CattailGirl = 55,
    Cattailour = 56,
    WallNut = 57,
    SuperChomper = 58,
    UltimateChomper = 59,
    UltimateTallNut = 60,
    SuperMachineNut = 61,
    SuperSunNut = 62,
    UltimatePumpkin = 63,
    MelonJump = 64,
    IronNut = 65,
    Sub = 999,
    WelcomeChallenge = 1000,
    Travel = 1001,
    Travel2 = 1002,
    Travel3 = 1003,
    Travel_noBuff = 1004,
    Travel_noNut = 1005,
    Travel_sun = 1006,
    Travel_fast = 1007,
    SuperMachineNut_health = 1008,
    SuperDamage = 1009,
}

class AchievementEditor : UnityEngine.MonoBehaviour
{
    /*0x20*/ AchievementClip head;

    /*0x31c640*/ AchievementEditor();
    /*0x41a4c0*/ void GetChilds();
}

class AchievementLine : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.RectTransform left;
    /*0x28*/ UnityEngine.RectTransform right;
    /*0x30*/ bool column;
    /*0x31*/ bool moveable;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.RectTransform> rectTransforms;
    /*0x40*/ UnityEngine.RectTransform rectTransform;

    /*0x41ad90*/ AchievementLine();
    /*0x41a740*/ void OnDrawGizmosSelected();
    /*0x41ad30*/ void Reset();
}

class AchievementManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.HashSet<Achievement> achievements;

    static /*0x41afa0*/ AchievementManager();
    static /*0x41ae10*/ bool CheckAchievement(Achievement index);
    static /*0x41ae90*/ void UnlockAchievement(Achievement index);
    /*0x31c640*/ AchievementManager();
}

class AchievementMenu : BaseMenu
{
    static /*0x0*/ AchievementMenu Instance;
    /*0x30*/ UnityEngine.Transform achievements;
    /*0x38*/ UnityEngine.Transform head;
    /*0x40*/ UnityEngine.UI.Mask mask;
    /*0x48*/ AchievementClip headClip;
    /*0x50*/ float moveSpeed;
    /*0x54*/ UnityEngine.Vector3 lastMousePosition;
    /*0x60*/ bool isFollowing;

    /*0x41b770*/ AchievementMenu();
    /*0x41b030*/ void Awake();
    /*0x41b650*/ void Update();
    /*0x41b540*/ void ScrollWheelUpdate();
    /*0x41b300*/ void ClickUpdate();
}

class AchievementText : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AchievementText Instance;
    /*0x20*/ TMPro.TextMeshProUGUI t1;
    /*0x28*/ TMPro.TextMeshProUGUI t2;
    /*0x30*/ float timer;

    /*0x31c640*/ AchievementText();
    /*0x41b780*/ void Awake();
    /*0x41b8a0*/ void Update();
    /*0x41b7e0*/ void ShowText(string text, float time);
}

class BigGatlingRaised : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ BigGatlingRaised();
    /*0x423980*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class DefaultStatus : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ DefaultStatus();
    /*0x426b20*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class DefaultStatus_enter : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ DefaultStatus_enter();
    /*0x426c00*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class FootballDrownShoot : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ FootballDrownShoot();
    /*0x427a30*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class EndAction : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ EndAction();
    /*0x4279b0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class UltimateJacksonTurn : UnityEngine.MonoBehaviour
{
    /*0x20*/ Zombie zombie;
    /*0x28*/ UnityEngine.Animator anim;
    /*0x30*/ bool active;

    /*0x31c640*/ UltimateJacksonTurn();
    /*0x42bc60*/ void Awake();
    /*0x42be80*/ void Turn();
    /*0x42ba30*/ void AnimSummon();
    /*0x42bcb0*/ void SummonZombie(float x, int theRow);
}

class Paper_beAngry : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Paper_beAngry();
    /*0x427f50*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class PotatoMine_rise : UnityEngine.StateMachineBehaviour
{
    /*0x18*/ string endStatus;

    /*0x4239f0*/ PotatoMine_rise();
    /*0x428060*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class State_scaredyPotato : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ State_scaredyPotato();
    /*0x4288b0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x428980*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Shulkflower_shootloop : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Shulkflower_shootloop();
    /*0x4281a0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x428200*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Snorkle_in : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Snorkle_in();
    /*0x428260*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Snorkle_out : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Snorkle_out();
    /*0x4282c0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Spider_raising : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Spider_raising();
    /*0x4286e0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Boss_headAttackOver : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Boss_headAttackOver();
    /*0x4261a0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Boss_headEnter : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Boss_headEnter();
    /*0x4262d0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Boss_headLeave : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Boss_headLeave();
    /*0x4263a0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x426430*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Boss_idle : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Boss_idle();
    /*0x426490*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class Boss_rv : UnityEngine.StateMachineBehaviour
{
    /*0x4239f0*/ Boss_rv();
    /*0x426510*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x426580*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class AutoPlant : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AutoPlant Instance;
    /*0x20*/ Board board;
    /*0x28*/ System.Collections.Generic.List<AutoPlant.Task> tasks;
    /*0x30*/ UnityEngine.GameObject head;

    /*0x423630*/ AutoPlant();
    /*0x421ff0*/ void Awake();
    /*0x423220*/ void RemoveTasks(int theColumn, int theRow);
    /*0x422f80*/ void CreateTask(int theColumn, int theRow, PlantType thePlantType, bool extra);
    /*0x422bb0*/ void CreateAdvancedTask(int theColumn, int theRow, Plant plant, bool extra);
    /*0x423410*/ void Update();
    /*0x423380*/ void TaskUpdate();
    /*0x422070*/ void ClickPlant(Plant plant);

    class Task
    {
        /*0x10*/ bool taskOver;
        /*0x14*/ int index;
        /*0x18*/ int theRow;
        /*0x1c*/ int theColumn;
        /*0x20*/ UnityEngine.GameObject preview;
        /*0x28*/ Board board;
        /*0x30*/ System.Collections.Generic.List<CardUI> cards;
        /*0x38*/ bool extra;
        /*0x40*/ System.Collections.Generic.List<PlantType> uses;

        /*0x428e90*/ Task(System.Collections.Generic.List<PlantType> uses, int theColumn, int theRow, PlantType thePlantType, Board board, System.Collections.Generic.List<CardUI> cards, bool extra);
        /*0x428a50*/ bool OnUpdate();
        /*0x428e20*/ void PlantEffect(Plant plant, CardUI card);
    }
}

class AutoPlant2
{
    /*0x32f970*/ AutoPlant2();
}

class BilliardBall : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Rigidbody2D rb;
    /*0x28*/ UnityEngine.Vector2 v;
    /*0x30*/ UnityEngine.Transform axis;
    /*0x38*/ UnityEngine.SpriteRenderer r;
    /*0x40*/ BilliardBall.BilliardBallType theBallType;

    /*0x31c640*/ BilliardBall();
    /*0x423a00*/ void Awake();
    /*0x423ae0*/ void Hit(UnityEngine.Vector2 rodPositon, float force);
    /*0x424380*/ void Update();
    /*0x423c30*/ void OnCollisionEnter2D(UnityEngine.Collision2D collision);
    /*0x423d70*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);

    enum BilliardBallType
    {
        Normal = 0,
        Cherry = 1,
        Ice = 2,
        Iron = 3,
        Hypno = 4,
        Sun = 5,
    }
}

class BilliardManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ BilliardManager Instance;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.GameObject> prefabs;
    /*0x28*/ BilliardBall whiteBall;
    /*0x30*/ BilliardRod billiardRod;
    /*0x38*/ System.Collections.Generic.List<BilliardBall> billiardBalls;

    /*0x424f60*/ BilliardManager();
    /*0x424780*/ void Awake();
    /*0x424c30*/ void Start();
    /*0x424a00*/ BilliardBall SetBall(int theColumn, int theRow, BilliardBall.BilliardBallType theBallType);
    /*0x424ee0*/ void Update();
    /*0x4247e0*/ void RodUpdate();
}

class BilliardRod : UnityEngine.MonoBehaviour
{
    /*0x20*/ float force;
    /*0x24*/ bool forcing;
    /*0x28*/ float currentForce;
    /*0x2c*/ float timer;
    /*0x30*/ UnityEngine.GameObject sprites;
    /*0x38*/ UnityEngine.LineRenderer line;
    /*0x40*/ int level;
    /*0x44*/ bool clicking;

    /*0x31c640*/ BilliardRod();
    /*0x425020*/ void Awake();
    /*0x425390*/ void OnUpdate();
    /*0x425a10*/ bool Upgrade();
    /*0x425070*/ void ForceUpdate();
    /*0x4251a0*/ void HitBall();
    /*0x425580*/ void PositionUpdate();
}

class AirProjectile : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theRow;
    /*0x24*/ int damage;
    /*0x28*/ int theHealth;
    /*0x30*/ UnityEngine.Collider2D col;
    /*0x38*/ UnityEngine.Rigidbody2D rb;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;
    /*0x48*/ float flashTimer;
    /*0x4c*/ float dy;

    /*0x41bf80*/ AirProjectile();
    /*0x41b940*/ void Awake();
    /*0x41bef0*/ int TakeDamage(int damage);
    /*0x41b9d0*/ void Die();
    /*0x41bd50*/ void Start();
    /*0x32d010*/ void OnFixedUpdate();
    /*0x41ba30*/ void FixedUpdate();
    /*0x41bab0*/ void FlashUpdate();
    /*0x41bb70*/ void SetLumen(float b);
}

class DrownProjectile : AirProjectile
{
    /*0x50*/ bool land;
    /*0x54*/ float existTime;
    /*0x58*/ bool hit;
    /*0x60*/ Plant targetPlant;
    /*0x68*/ bool horizontal;
    /*0x69*/ bool free;
    /*0x6a*/ bool big;
    /*0x6b*/ bool cold;

    /*0x4279a0*/ DrownProjectile();
    /*0x426cb0*/ void OnFixedUpdate();
    /*0x427270*/ void SetTarget(UnityEngine.Vector2 startPosition, Plant targetPlant);
    /*0x427420*/ void Start();
    /*0x427610*/ void Update();
    /*0x427110*/ void PositionUpdate();
    /*0x426e20*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class SpiderWeapon : AirProjectile
{
    /*0x50*/ bool isMindControl;
    /*0x58*/ Board board;
    /*0x60*/ Plant.DamageType damageType;

    /*0x4286d0*/ SpiderWeapon();
    /*0x428320*/ void Awake();
    /*0x4283c0*/ void OnFixedUpdate();
}

class AlmanacCardZombie : UnityEngine.MonoBehaviour
{
    /*0x20*/ ZombieType theZombieType;
    /*0x28*/ UnityEngine.SpriteRenderer r;
    /*0x30*/ UnityEngine.SpriteRenderer _r;

    /*0x31c640*/ AlmanacCardZombie();
    /*0x41c000*/ void Awake();
    /*0x41c1f0*/ void OnMouseDown();
    /*0x41c400*/ void OnMouseEnter();
    /*0x41c4c0*/ void OnMouseExit();
    /*0x41c0a0*/ void FixedUpdate();
}

class AlmanacMgrZombie : UnityEngine.MonoBehaviour
{
    /*0x20*/ ZombieType theZombieType;
    /*0x28*/ UnityEngine.GameObject zombieName;
    /*0x30*/ UnityEngine.GameObject info;
    /*0x38*/ int pageCount;
    /*0x3c*/ int currentPage;
    /*0x40*/ TMPro.TextMeshPro introduce;

    /*0x41cb60*/ AlmanacMgrZombie();
    /*0x41c580*/ void Awake();
    /*0x41ca90*/ void Start();
    /*0x41c640*/ void InitNameAndInfoFromJson();
    /*0x41ca30*/ void OnMouseDown();

    class ZombieInfo
    {
        /*0x10*/ string name;
        /*0x18*/ string introduce;
        /*0x20*/ string info;
        /*0x28*/ ZombieType theZombieType;

        /*0x32f970*/ ZombieInfo();
    }

    class ZombieAlmanacData
    {
        /*0x10*/ AlmanacMgrZombie.ZombieInfo[] zombies;

        /*0x42c1a0*/ ZombieAlmanacData();
    }
}

class AlmanacPageBtn : NormalBtn
{
    /*0x58*/ int btnType;
    /*0x60*/ AlmanacZombieCtrl almanacZombieCtrl;
    /*0x68*/ UnityEngine.GameObject groupToOpen;
    /*0x70*/ UnityEngine.GameObject turnPage;

    /*0x317730*/ AlmanacPageBtn();
    /*0x41cb70*/ void OnMouseUpAsButton();
}

class AlmanacPlantBank : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theSeedType;
    /*0x28*/ TMPro.TextMeshPro plantName;
    /*0x30*/ TMPro.TextMeshPro plantName_shadow;
    /*0x38*/ TMPro.TextMeshPro cost;
    /*0x40*/ UnityEngine.GameObject skinButton;
    /*0x48*/ UnityEngine.GameObject pvpPotSwitch;
    /*0x50*/ int pageCount;
    /*0x54*/ int currentPage;
    /*0x58*/ TMPro.TextMeshPro introduce;

    /*0x41db30*/ AlmanacPlantBank();
    /*0x41d8c0*/ void Start();
    /*0x41d210*/ void InitNameAndInfoFromJson();
    /*0x41d680*/ void OnMouseDown();
    /*0x41d050*/ void BanedInPVP(TMPro.TextMeshPro textMeshPro);
    /*0x41d6e0*/ void PVPInit();

    class PlantInfo
    {
        /*0x10*/ string name;
        /*0x18*/ string introduce;
        /*0x20*/ string info;
        /*0x28*/ string cost;
        /*0x30*/ int seedType;

        /*0x32f970*/ PlantInfo();
    }

    class PlantData
    {
        /*0x10*/ AlmanacPlantBank.PlantInfo[] plants;

        /*0x428000*/ PlantData();
    }
}

class UseablePlantTypeInPvP
{
    static /*0x0*/ System.Collections.Generic.List<PlantType> plantTypes;

    static /*0x42bf70*/ System.Collections.Generic.List<PlantType> GetPlantTypes();
    static /*0x42bfd0*/ void UpdatePlantTypes();

    class <>c
    {
        static /*0x0*/ UseablePlantTypeInPvP.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__2_0;

        static /*0x42b950*/ <>c();
        /*0x32f970*/ <>c();
        /*0x42b840*/ bool <UpdatePlantTypes>b__2_0(PlantType p);
    }
}

class AlmanacPlantCtrl : UnityEngine.MonoBehaviour
{
    /*0x20*/ int plantSelected;
    /*0x28*/ string cardGroupPath;
    /*0x30*/ bool instantiate;
    /*0x38*/ UnityEngine.GameObject localShowPlant;
    /*0x40*/ UnityEngine.GameObject localCardBank;
    /*0x48*/ UnityEngine.GameObject localMixGroup;
    /*0x50*/ UnityEngine.GameObject basicCard;
    /*0x58*/ UnityEngine.Vector3 v;

    /*0x41f0e0*/ AlmanacPlantCtrl();
    /*0x41ecd0*/ void Start();
    /*0x41eb10*/ UnityEngine.GameObject SetPlant(int theSeedType);
    /*0x41df50*/ void GetSeedType(int theSeedType, bool isBasicCard);
    /*0x41ec50*/ void ShowBasicCard();
    /*0x41db40*/ void GetImage(PlantType theSeedType, UnityEngine.Transform bank);
    /*0x41f0d0*/ void <GetSeedType>b__10_0();
}

class AlmanacZombieCtrl : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AlmanacZombieCtrl Instance;
    /*0x20*/ ZombieType zombieSelected;
    /*0x28*/ UnityEngine.GameObject localShowZombie;
    /*0x30*/ UnityEngine.GameObject localCardBank;
    /*0x38*/ UnityEngine.Vector3 v;
    /*0x44*/ int currentShowGroup;
    /*0x48*/ System.Collections.Generic.List<UnityEngine.GameObject> groups;
    /*0x50*/ UnityEngine.GameObject zombieCardPrefab;
    /*0x58*/ UnityEngine.Transform pageHead;

    /*0x41fb20*/ AlmanacZombieCtrl();
    /*0x41f110*/ void Awake();
    /*0x41f170*/ void GetZombieType(ZombieType theZombieType);
    /*0x41f350*/ void InitZombieCard();
    /*0x41fab0*/ System.Collections.IEnumerator SetZombieIcon(System.Collections.Generic.List<AlmanacCardZombie> zombies);
    /*0x41f9b0*/ void NextPage();
    /*0x41f8b0*/ void LastPage();

    class <>c
    {
        static /*0x0*/ AlmanacZombieCtrl.<> <>9;
        static /*0x8*/ System.Predicate<ZombieType> <>9__11_0;

        static /*0x42b9c0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x42b7e0*/ bool <InitZombieCard>b__11_0(ZombieType z);
    }

    class <SetZombieIcon>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ System.Collections.Generic.List<AlmanacCardZombie> zombies;
        /*0x28*/ int <i>5__2;

        /*0x32f460*/ <SetZombieIcon>d__12(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x429bd0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x42a570*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BackToAlmanac : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ UnityEngine.Sprite originSprite;
    /*0x30*/ UnityEngine.Vector3 originPosition;
    /*0x40*/ UnityEngine.SpriteRenderer r;
    /*0x48*/ int type;

    /*0x31c640*/ BackToAlmanac();
    /*0x4238e0*/ void Start();
    /*0x423760*/ void OnMouseEnter();
    /*0x423790*/ void OnMouseExit();
    /*0x4236b0*/ void OnMouseDown();
    /*0x4237f0*/ void OnMouseUp();
}

class Close : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ UnityEngine.Sprite originSprite;
    /*0x30*/ UnityEngine.Vector3 originPosition;
    /*0x40*/ UnityEngine.SpriteRenderer r;
    /*0x48*/ bool CloseGroup;

    /*0x31c640*/ Close();
    /*0x426a80*/ void Start();
    /*0x423760*/ void OnMouseEnter();
    /*0x423790*/ void OnMouseExit();
    /*0x4265f0*/ void OnMouseDown();
    /*0x4266a0*/ void OnMouseUp();
}

class LookPlant : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector3 originPosition;

    /*0x31c640*/ LookPlant();
    /*0x427d80*/ void Start();
    /*0x427c10*/ void OnMouseEnter();
    /*0x427c60*/ void OnMouseExit();
    /*0x427b60*/ void OnMouseDown();
    /*0x427cf0*/ void OnMouseUpAsButton();
}

class LookZombie : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector3 originPosition;
    /*0x30*/ UnityEngine.SpriteRenderer r;

    /*0x31c640*/ LookZombie();
    /*0x427d80*/ void Start();
    /*0x32bbd0*/ void OnMouseEnter();
    /*0x427e70*/ void OnMouseExit();
    /*0x427dc0*/ void OnMouseDown();
    /*0x427ec0*/ void OnMouseUpAsButton();
}

class ZombieInAlmanac : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ ZombieInAlmanac();
    /*0x42c200*/ void Start();
}

class AnimUIOver : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;

    /*0x31c640*/ AnimUIOver();
    /*0x421fa0*/ void Start();
    /*0x421070*/ void KillZombie();
    /*0x41fd10*/ void Die();
    /*0x421320*/ void ShowText();
    /*0x41fbc0*/ void Die1();
    /*0x41fc20*/ void DieHugeWave();
}

class JackBox : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ JackBox();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class Blow : UnityEngine.MonoBehaviour
{
    /*0x20*/ Zombie zombie;
    /*0x28*/ Blow.BlowType blowType;
    /*0x2c*/ float blowTime;
    /*0x30*/ IronBalloonZombie ironBalloonZombie;
    /*0x38*/ BombThrower bombThrower;
    /*0x40*/ float vision;

    /*0x31c640*/ Blow();
    /*0x425bb0*/ void Start();
    /*0x425de0*/ void Update();

    enum BlowType
    {
        Default = 0,
        BlowKirov = 1,
        BlowZombieOnWater = 2,
        BlowIronBalloon = 3,
        BombThrower = 4,
    }
}

enum BoxType
{
    Grass = 0,
    Water = 1,
    Dirt = 2,
    Roof = 3,
    Stone = 4,
    River = 5,
    Dirt_water = 6,
}

struct PlantStatistics
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int useTimes;
}

class Board : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Board Instance;
    /*0x20*/ System.Collections.Generic.List<PlantStatistics> plantStatistics;
    /*0x28*/ System.Collections.Generic.List<Plant> plantArray;
    /*0x30*/ System.Collections.Generic.List<Plant> hiddenPlants;
    /*0x38*/ System.Collections.Generic.List<Plant> plantHead;
    /*0x40*/ System.Collections.Generic.List<GardenPlant> gardenPlants;
    /*0x48*/ System.Collections.Generic.List<Bullet> bulletArray;
    /*0x50*/ System.Collections.Generic.List<Zombie> zombieArray;
    /*0x58*/ System.Collections.Generic.List<Zombie> zombieHead;
    /*0x60*/ System.Collections.Generic.List<Obstacle> zombieBalls;
    /*0x68*/ System.Collections.Generic.List<GridItem> griditemArray;
    /*0x70*/ System.Collections.Generic.List<Mower> mowerArray;
    /*0x78*/ FireLine[] fireLineArray;
    /*0x80*/ UnityEngine.GameObject fog;
    /*0x88*/ System.Collections.Generic.List<IceRoad> iceRoads;
    /*0x90*/ BoxType[] roadType;
    /*0x98*/ BoxType[,] boxType;
    /*0xa0*/ Board.BoxInfo[,] boxInfos;
    /*0xa8*/ System.Collections.Generic.List<PlantType> seedPool;
    /*0xb0*/ float plantMaxVisionX;
    /*0xb4*/ float boardMaxY;
    /*0xb8*/ float boardMinY;
    /*0xbc*/ float boardMaxX;
    /*0xc0*/ float boardMinX;
    /*0xc4*/ float zombieMaxX;
    /*0xc8*/ float zombieMinX;
    /*0xd0*/ System.Collections.Generic.List<JigSawData> jigSawDatas;
    /*0xd8*/ int theSun;
    /*0xdc*/ int extraSun;
    /*0xe0*/ int theUsedSun;
    /*0xe4*/ int theMoney;
    /*0xe8*/ int enermyCount;
    /*0xec*/ int theTotalNumOfZombie;
    /*0xf0*/ int theTotalNumOfCoin;
    /*0xf4*/ int theTotalNumOfPlant;
    /*0xf8*/ int plantedCount;
    /*0xfc*/ int theCurrentPlantCount;
    /*0x100*/ int theLimPlantCount;
    /*0x104*/ int theWave;
    /*0x108*/ int theMaxWave;
    /*0x10c*/ int theSurvivalMaxRound;
    /*0x110*/ int theCurrentSurvivalRound;
    /*0x114*/ int currentBulletNum;
    /*0x118*/ int musicType;
    /*0x11c*/ int rowNum;
    /*0x120*/ int columnNum;
    /*0x124*/ int izDropCount;
    /*0x128*/ int killZombieCount;
    /*0x12c*/ int savedID;
    /*0x130*/ int redLineColumn;
    /*0x134*/ float thePoints;
    /*0x138*/ float currentRoundPoint;
    /*0x13c*/ float zombieTotalHealth;
    /*0x140*/ float zombieCurrentHealth;
    /*0x144*/ float zombieHealthUpdater;
    /*0x148*/ float holdOnTime;
    /*0x14c*/ float iceDoomFreezeTime;
    /*0x150*/ float newZombieWaveCountDown;
    /*0x154*/ float nextZombieWaveCountDown;
    /*0x158*/ float happyRandomCardTimer;
    /*0x15c*/ float happyRecoverTimer;
    /*0x160*/ float punishTime;
    /*0x164*/ float bigStarPassiveCountDown;
    /*0x168*/ float solarCountDown;
    /*0x16c*/ float solarMaxTime;
    /*0x170*/ float bigStarPassiveMaxTime;
    /*0x174*/ float bigStarActiveCountDown;
    /*0x178*/ float bigStarActiveMaxTime;
    /*0x17c*/ float ultimateStarCountDown;
    /*0x180*/ float ultimateStarMaxTime;
    /*0x184*/ float zombieHealthAdder;
    /*0x188*/ float zombieDamageAdder;
    /*0x18c*/ float zombieSpeedAdder;
    /*0x190*/ float zombieBasicSpeed;
    /*0x194*/ float lastRandomBuffTime;
    /*0x198*/ float randomPresentTime;
    /*0x19c*/ float moreMultiplier;
    /*0x1a0*/ float updatingTime;
    /*0x1a4*/ bool isEveStart;
    /*0x1a5*/ bool isEveStarted;
    /*0x1a6*/ bool isAutoEve;
    /*0x1a7*/ bool isEveBalanced;
    /*0x1a8*/ bool isIZ;
    /*0x1a9*/ bool over;
    /*0x1aa*/ bool freeCD;
    /*0x1ab*/ bool allowSummonZombie;
    /*0x1ac*/ bool droppedGardenPlant;
    /*0x1ad*/ bool cardSelectable;
    /*0x1ae*/ bool cardBank;
    /*0x1af*/ bool freeSet;
    /*0x1b0*/ int showPlantHealth;
    /*0x1b4*/ bool showZombieHealth;
    /*0x1b5*/ bool uniqueTrigger;
    /*0x1b6*/ bool moreZombiesComing;
    /*0x1b7*/ bool startMove;
    /*0x1b8*/ bool fallSun;
    /*0x1b9*/ bool happyRandomCard;
    /*0x1ba*/ bool boss2;
    /*0x1bb*/ bool goldHypnoAward;
    /*0x1bc*/ bool rightPutPot;
    /*0x1bd*/ bool randomCard;
    /*0x1be*/ bool autoPlant;
    /*0x1c0*/ SettlementData settlementData;
    /*0x1c8*/ long startTime;
    /*0x1d0*/ System.Collections.Generic.List<UnityEngine.Transform> plane;
    /*0x1d8*/ System.Collections.Generic.List<UnityEngine.Transform> planeRoof;
    /*0x1e0*/ System.Collections.Generic.List<Plant> fallingPlants;
    /*0x1e8*/ System.Collections.Generic.Dictionary<ZombieType, int> enermyCountDic;
    /*0x1f0*/ Plant controledPlant;
    /*0x1f8*/ UnityEngine.GameObject background;
    /*0x200*/ BrainManager brainManager;
    /*0x208*/ Board.BoardTag boardTag;
    /*0x258*/ BoardGame boardGame;
    /*0x25c*/ SceneType sceneType;
    /*0x260*/ float time;
    /*0x264*/ float theFallingSunCountDown;
    /*0x268*/ float hugeWaveCountDown;
    /*0x26c*/ bool isHugeWave;
    /*0x270*/ float eveCountDown;
    /*0x274*/ float eveCurrentTime;
    /*0x278*/ float randomDataUpdateTimer;
    /*0x27c*/ float zombieReduceDamage;
    /*0x280*/ float tipTime;
    /*0x284*/ float bejeweledTimer;
    /*0x288*/ int maxMatchCount;
    /*0x28c*/ int matchCount;
    /*0x290*/ System.Collections.Generic.HashSet<PlantType> upgradedTypes;
    /*0x298*/ int combo;
    /*0x29c*/ int lockedDifficulty;
    /*0x2a0*/ UnityEngine.Transform UIParent;

    /*0x347460*/ Board();
    /*0x330a60*/ void Awake();
    /*0x3452f0*/ void Start();
    /*0x335920*/ void GetJigsawFromList();
    /*0x33ada0*/ void SaveJiasawToList();
    /*0x346b00*/ void Update();
    /*0x33a980*/ void RandomCardUpdate();
    /*0x3472b0*/ void UseSun(int count);
    /*0x336380*/ void GetSun(int count, int r, bool save);
    /*0x335b00*/ void GetMoney(int count);
    /*0x335ff0*/ void GetPoint(float count);
    /*0x3417f0*/ void SetSun(int count);
    /*0x335360*/ PlantType GetBejeweledPlant();
    /*0x33b300*/ void SetBejeweledPlant();
    /*0x33aae0*/ void RefrashBejeweldPlant();
    /*0x337ec0*/ void MoveControlPlant(int index);
    /*0x331870*/ void ControledPlantUpdate();
    /*0x344770*/ void ShowPlantHealth();
    /*0x344940*/ void ShowZombieHealth();
    /*0x344b60*/ System.Collections.IEnumerator SmoothlyChangeMap(SceneType sceneType);
    /*0x3312e0*/ void ChangeMap(UnityEngine.GameObject map);
    /*0x335b80*/ void GetPlane();
    /*0x33b500*/ void SetBoundaries();
    /*0x341d70*/ void SetUniqueLevel();
    /*0x333f50*/ void CustomMapSettings();
    /*0x33d6e0*/ void SetPrePlants();
    /*0x33cea0*/ void SetFreezedPlant();
    /*0x33d090*/ void SetGrave();
    /*0x337040*/ void InitIZSettings();
    /*0x336dc0*/ void InitBoxInfo();
    /*0x3472c0*/ void WaterYUpdate();
    /*0x33b630*/ void SetDeviation();
    /*0x334da0*/ void EveUpdate();
    /*0x340cf0*/ void SetRandomZombies(float t);
    /*0x3463b0*/ bool WheatLimit(PlantType plantType);
    /*0x33c960*/ UnityEngine.GameObject SetEvePlants(int theColumn, int theRow, bool fromWheat);
    /*0x3379b0*/ void LevelUpdate();
    /*0x3376e0*/ void LevelUpUpdate();
    /*0x33ac40*/ void RefreshHappyRandomCards();
    /*0x3357c0*/ void GetHappyRandomCard();
    /*0x330fc0*/ void BejeweledUpdate();
    /*0x331440*/ bool CheckMatch(Plant plant, bool tip);
    /*0x336910*/ void HeighLightPlant(System.Collections.Generic.List<Plant> plants);
    /*0x344b10*/ void SinglePresentUpdate();
    /*0x3338b0*/ void CreateRandomPresent();
    /*0x346530*/ void UniqueEvent();
    /*0x346960*/ void UpdateZombieHealth();
    /*0x3455b0*/ void SunUpdate();
    /*0x33b0a0*/ void SeedRainUpdate();
    /*0x336310*/ PlantType GetSeedInPool();
    /*0x337490*/ void InitSeedPool();
    /*0x338170*/ void NewZombieUpdate();
    /*0x345c10*/ void SupplyGrave();
    /*0x336650*/ void HammerSummonZombie();
    /*0x338f40*/ void NormalSummonZombies();
    /*0x345ef0*/ void SurvivalPunish();
    /*0x33d290*/ void SetHealthInTravel(Zombie z);
    /*0x33d480*/ void SetMoreHealth(Zombie z);
    /*0x331750*/ System.Collections.IEnumerator CheckZombieNum();
    /*0x336070*/ int GetRandomLandRow();
    /*0x3361e0*/ int GetRandomWaterRow();
    /*0x33a800*/ int[] PickUniqueRandomNumbers(int min, int max, int count);
    /*0x33b750*/ void SetDoom(int theColumn, int theRow, bool setPit, bool iceDoom, UnityEngine.Vector2 position, int damage, int effect, System.Action<Zombie> action);
    /*0x3410d0*/ void SetSmallDoom(UnityEngine.Vector2 position, int theRow, Team team, int damage);
    /*0x33d550*/ void SetPit(int theColumn, int theRow);
    /*0x331df0*/ void CreateCherryExplode(UnityEngine.Vector2 v, int theRow, CherryBombType bombType, int damage, System.Action<Zombie> action);
    /*0x332d00*/ void CreateFreeze(UnityEngine.Vector2 pos);
    /*0x332450*/ void CreateFireLine(int theFireRow, int damage, bool fromZombie, bool fix, bool shake, System.Action<Zombie> action);
    /*0x335050*/ System.Collections.IEnumerator FireLineDamage(int theFireRow, int damage, bool fix, System.Action<Zombie> action);
    /*0x332110*/ void CreateFireAnim(int row);
    /*0x335110*/ Bullet FirePeas(Bullet ob, Plant torch, int damage, BulletType theBulletType);
    /*0x334810*/ void EnterNextRound();
    /*0x3463a0*/ void Travel();
    /*0x3444b0*/ void ShowChoice(int round);
    /*0x346320*/ void TravelNextRound();
    /*0x334490*/ System.Collections.IEnumerator DelayNextRound();
    /*0x344be0*/ void StartNextRound();
    /*0x3317c0*/ void ClearTheBoard();
    /*0x341a20*/ void SetSuperTorch();
    /*0x341800*/ void SetSuperKelp();
    /*0x3461c0*/ void TempAddLightLevel(float time);
    /*0x334370*/ void DecreaseLightLevel();
    /*0x330970*/ void AddLightLevel(int level);
    /*0x337c90*/ void MeteoriteUpdate();
    /*0x333b40*/ void CreateSolar();
    /*0x3335a0*/ void CreateLunar();
    /*0x33a330*/ void PassiveCreateMeteorite();
    /*0x330750*/ void ActiveCreateMeteorite();
    /*0x3337c0*/ void CreatePassiveMateorite();
    /*0x331d00*/ void CreateActiveMateorite();
    /*0x33a5d0*/ void PassiveUltimateMeteorite();
    /*0x333e60*/ void CreateUltimateMateorite();
    /*0x334500*/ void EnableTravelBuff(bool add, bool zombie);
    /*0x345420*/ void StatisticsPlant(PlantType thePlantType);
    /*0x33a000*/ void OnPlantCreate(Plant plant);
    /*0x33a250*/ void OnPlantDie(Plant plant);
    /*0x346670*/ void UpdateRandomData(bool showText);
    /*0x336a10*/ void HugeWaveEvent(int currentWave);
    /*0x340ed0*/ void SetRedLine(int theColumn);
    /*0x335740*/ BoxType GetBoxType(int theColumn, int theRow);
    /*0x346620*/ void UpdateBox(int theColumn, int theRow);
    /*0x339d30*/ void OnDestroy();
    /*0x3463b0*/ bool <SetEvePlants>b__166_0(PlantType p);

    class BoxInfo
    {
        /*0x10*/ System.Collections.Generic.List<Plant> plants;
        /*0x18*/ int currentLightLevel;
        /*0x1c*/ BoxType boxType;
        /*0x20*/ float waterBoxY;
        /*0x24*/ float waterBoxYDeviation;
        /*0x28*/ int potNum;
        /*0x2c*/ int lilyNum;
        /*0x30*/ int ladderNum;
        /*0x34*/ int graveNum;
        /*0x38*/ int pitNum;
        /*0x3c*/ int disableLevel;
        /*0x40*/ System.Collections.Generic.List<JigsawType> jigsawType;
        /*0x48*/ bool existTreasure;
        /*0x49*/ bool existLava;

        /*0x32f970*/ BoxInfo();
    }

    struct BoardTag
    {
        /*0x10*/ bool Iz_ai;
        /*0x11*/ bool zombieDropSun;
        /*0x12*/ bool disableNormalSun;
        /*0x13*/ bool zombieRevive;
        /*0x14*/ bool isScaredyDream;
        /*0x15*/ bool isTowerDefence;
        /*0x16*/ bool isShooting;
        /*0x17*/ bool rogueShooting;
        /*0x18*/ bool newShooting;
        /*0x19*/ bool isSeedRain;
        /*0x1a*/ bool isIndestructible;
        /*0x1b*/ bool isColumn;
        /*0x1c*/ bool isSuperRandom;
        /*0x1d*/ bool isDrawCards;
        /*0x1e*/ bool isUltimateSuperRandom;
        /*0x1f*/ bool isNight;
        /*0x20*/ bool isBigMap;
        /*0x21*/ bool freeCamera;
        /*0x22*/ bool isEndless;
        /*0x23*/ bool isTravel;
        /*0x24*/ bool randomTravel;
        /*0x25*/ bool quickTravel;
        /*0x26*/ bool isCustom;
        /*0x27*/ bool isEditor;
        /*0x28*/ bool enableTravelPlant;
        /*0x29*/ bool enableAllTravelPlant;
        /*0x2a*/ bool enableTravelBuff;
        /*0x2b*/ bool isRoof;
        /*0x2c*/ bool isGarden;
        /*0x2d*/ bool isMirror;
        /*0x2e*/ bool isConvey;
        /*0x2f*/ bool isExchange;
        /*0x30*/ bool shooting_loon;
        /*0x31*/ bool isBoss;
        /*0x32*/ bool isBoss2;
        /*0x33*/ bool isFreeCardSelect;
        /*0x34*/ bool isTutor;
        /*0x35*/ bool isObsidianImp;
        /*0x36*/ bool isDixMix;
        /*0x37*/ bool isSingle;
        /*0x38*/ bool bungiBattle;
        /*0x39*/ bool isBejeweled;
        /*0x3a*/ bool isScaryPot;
        /*0x3b*/ bool isMidMap;
        /*0x3c*/ bool isChess;
        /*0x3d*/ bool isMidMap2;
        /*0x3e*/ bool isLookStar;
        /*0x3f*/ bool isGardenBattle;
        /*0x40*/ bool isRandomMix;
        /*0x41*/ bool isRandomMix2;
        /*0x42*/ bool freeGloveZombie;
        /*0x43*/ bool disableMower;
        /*0x44*/ bool isHappyRandom;
        /*0x45*/ bool oppsiteBuff;
        /*0x46*/ bool pvpScaryPot;
        /*0x47*/ bool ultimateEndless;
        /*0x48*/ bool isHammerZombie;
        /*0x49*/ bool fastZombie;
        /*0x4a*/ bool isHugeGravity;
        /*0x4b*/ bool zombieSplit;
        /*0x4c*/ bool fullStrike;
        /*0x4d*/ bool billiardBall;
        /*0x4e*/ bool isSnake;
        /*0x4f*/ bool sandBox;
        /*0x50*/ bool isSquash;
        /*0x51*/ bool zombieBattle;
        /*0x52*/ bool is2048;
        /*0x53*/ bool newTower;
        /*0x54*/ bool isRogue;
        /*0x55*/ bool isFruitNinjia;
        /*0x56*/ bool isFruitNinjia2;
        /*0x57*/ bool lightShadow;
        /*0x58*/ bool isLoonGame;
        /*0x59*/ bool snowBoss;
        /*0x5a*/ bool playerShooting;
        /*0x5b*/ bool smallZombie;
        /*0x5c*/ bool isFlagGame;
        /*0x5d*/ bool isTreasure;
        /*0x5e*/ bool isBrick;
    }

    class <>c
    {
        static /*0x0*/ Board.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__139_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__194_0;
        static /*0x18*/ System.Func<Plant, bool> <>9__215_0;

        static /*0x42b8e0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x32f930*/ bool <GetSun>b__139_0(Plant p);
        /*0x42b810*/ bool <SetSmallDoom>b__194_0(Plant p);
        /*0x42b7b0*/ bool <CreateSolar>b__215_0(Plant p);
    }

    class <>c__DisplayClass164_0
    {
        /*0x10*/ int i;

        /*0x32f970*/ <>c__DisplayClass164_0();
        /*0x42b8c0*/ bool <SetRandomZombies>b__0(Brain brain);
    }

    class <CheckZombieNum>d__189 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Board <>4__this;

        /*0x32f460*/ <CheckZombieNum>d__189(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4292a0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4294d0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <DelayNextRound>d__206 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Board <>4__this;

        /*0x32f460*/ <DelayNextRound>d__206(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x429510*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4298e0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <FireLineDamage>d__199 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ int damage;
        /*0x28*/ Board <>4__this;
        /*0x30*/ int theFireRow;
        /*0x34*/ bool fix;
        /*0x38*/ System.Action<Zombie> action;
        /*0x40*/ int <i>5__2;

        /*0x32f460*/ <FireLineDamage>d__199(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x429920*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x429b90*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <SmoothlyChangeMap>d__150 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Board <>4__this;
        /*0x28*/ SceneType sceneType;
        /*0x30*/ UnityEngine.GameObject <map>5__2;
        /*0x38*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> <newR>5__3;
        /*0x40*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> <originalR>5__4;
        /*0x48*/ System.Collections.Generic.List<Plant> <temp>5__5;
        /*0x50*/ float <timer>5__6;
        /*0x58*/ System.Collections.Generic.List<BaseMenu> <menus>5__7;

        /*0x32f460*/ <SmoothlyChangeMap>d__150(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x42a5b0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x42b770*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BallLauncher : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject ballPrefab;
    /*0x28*/ UnityEngine.Transform topPoint;
    /*0x30*/ UnityEngine.Transform bottomPoint;
    /*0x38*/ System.Collections.Generic.List<BrickBall> balls;
    /*0x40*/ float launchSpeed;
    /*0x44*/ bool waiting;

    /*0x51e710*/ BallLauncher();
    /*0x51e4e0*/ void Start();
    /*0x51e570*/ void Update();
    /*0x51e560*/ void Supply();
    /*0x51ded0*/ void CreateNewBall(PlantType plantType);
    /*0x51e220*/ void LaunchBall(BrickBall ball);
    /*0x51e2d0*/ void OnCollisionEnter2D(UnityEngine.Collision2D collision);
}

class BrickBall : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x28*/ UnityEngine.Transform paddle;
    /*0x30*/ UnityEngine.Rigidbody2D rb;
    /*0x38*/ float speed;
    /*0x3c*/ bool isLaunched;

    /*0x31c640*/ BrickBall();
    /*0x51e790*/ void Awake();
    /*0x51e910*/ void FixedUpdate();
    /*0x51e850*/ void Die();
    /*0x51eda0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x51f310*/ void SimulateCollisionBounce(UnityEngine.Collider2D collision);
    /*0x51ec60*/ void OnCollisionEnter2D(UnityEngine.Collision2D collision);
}

class BrickManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ BrickManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ int graveCount;
    /*0x2c*/ int max;
    /*0x30*/ BallLauncher launcher;
    /*0x38*/ float timer;
    /*0x3c*/ int level;

    /*0x51f9e0*/ BrickManager();
    /*0x51f3f0*/ void Awake();
    /*0x51f7f0*/ void Start();
    /*0x51f800*/ void Update();
    /*0x51f6b0*/ void SetGraves();
}

class PaddleController : UnityEngine.MonoBehaviour
{
    /*0x20*/ float speed;
    /*0x24*/ float boundaryX;
    /*0x28*/ bool mouse;
    /*0x30*/ Board board;

    /*0x530d30*/ PaddleController();
    /*0x5309b0*/ void Start();
    /*0x530a00*/ void Update();
}

class Chess : UnityEngine.MonoBehaviour
{
    /*0x20*/ ChessManager chessManager;
    /*0x28*/ ChessType chessType;
    /*0x30*/ Plant plant;

    /*0x31c640*/ Chess();
    /*0x522c90*/ int get_Column();
    /*0x522cb0*/ int get_Row();
    /*0x5227b0*/ void CopyChessData(Chess chess);
    /*0x5227f0*/ bool TryMove(int theColumn, int theRow);
}

class ChessBack : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ ChessBack();
    /*0x51fa00*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class ChessManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ChessManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ bool playerRound;
    /*0x30*/ Chess 将;
    /*0x38*/ int restMoveTimes;
    /*0x40*/ UnityEngine.GameObject fog;
    /*0x48*/ System.Collections.Generic.List<ChessManager.ZombieWithRow> _newWaveZombies;
    /*0x50*/ TMPro.TextMeshPro textMesh;
    /*0x58*/ System.Collections.Generic.List<UnityEngine.GameObject> zombiePreviews;

    /*0x5222c0*/ ChessManager();
    /*0x522350*/ System.Collections.Generic.List<ChessManager.ZombieWithRow> get_NewWaveZombies();
    /*0x4e4360*/ void set_NewWaveZombies(System.Collections.Generic.List<ChessManager.ZombieWithRow> value);
    /*0x522680*/ System.Collections.Generic.Dictionary<ZombieType, string> get_ZombieNames();
    /*0x51fb90*/ void Awake();
    /*0x521fa0*/ void Start();
    /*0x522210*/ void Update();
    /*0x51ff20*/ void InitTextMesh();
    /*0x521890*/ void ShowZombiePreviews();
    /*0x51fbf0*/ void ClearPreviews();
    /*0x520f80*/ void SetZombiePreview(int row, System.Collections.Generic.Dictionary<ZombieType, int> zombieWithCount);
    /*0x520330*/ void MoveNext();
    /*0x521f30*/ System.Collections.IEnumerator StartSummonZombie();
    /*0x522250*/ System.Collections.IEnumerator WaveEnd();
    /*0x5220b0*/ void UpdateText();
    /*0x5216d0*/ void SetZombies();
    /*0x521550*/ System.Collections.Generic.List<ChessManager.ZombieWithRow> SetZombieRow(System.Collections.Generic.List<ZombieType> zombieTypes);
    /*0x51fd70*/ System.Collections.Generic.List<ZombieType> GetZombies(int wave);
    /*0x5204f0*/ void ResetBoard();
    /*0x520e30*/ void SetChess(ChessType chessType, PlantType thePlantType, int theColumn, int theRow);
    /*0x520720*/ bool Rule_兵(Chess chess, int theColumn, int theRow);
    /*0x520b50*/ bool Rule_车(Chess chess, int theColumn, int theRow);
    /*0x520cf0*/ bool Rule_马(Chess chess, int theColumn, int theRow);
    /*0x520b50*/ bool Rule_炮(Chess chess, int theColumn, int theRow);
    /*0x520940*/ bool Rule_士(Chess chess, int theColumn, int theRow);
    /*0x520bb0*/ bool Rule_象(Chess chess, int theColumn, int theRow);
    /*0x520a40*/ bool Rule_将(Chess chess, int theColumn, int theRow);
    /*0x5201d0*/ bool IsInPalace(int column, int row);
    /*0x520270*/ bool IsStraightPathClear(int fromCol, int fromRow, int toCol, int toRow);
    /*0x5201f0*/ bool IsPositionOccupied(int theColumn, int theRow);
    /*0x5204e0*/ bool OverRiver(int theColumn);

    struct ZombieWithRow
    {
        /*0x10*/ ZombieType zombieType;
        /*0x14*/ int row;
    }

    class <>c
    {
        static /*0x0*/ ChessManager.<> <>9;
        static /*0x8*/ System.Func<ChessManager.ZombieWithRow, int> <>9__18_0;
        static /*0x10*/ System.Func<System.Linq.IGrouping<int, ChessManager.ZombieWithRow>, int> <>9__18_1;
        static /*0x18*/ System.Func<ChessManager.ZombieWithRow, ZombieType> <>9__18_2;
        static /*0x20*/ System.Func<System.Linq.IGrouping<ZombieType, ChessManager.ZombieWithRow>, ZombieType> <>9__18_3;
        static /*0x28*/ System.Func<System.Linq.IGrouping<ZombieType, ChessManager.ZombieWithRow>, int> <>9__18_4;

        static /*0x533b10*/ <>c();
        /*0x32f970*/ <>c();
        /*0x533940*/ int <ShowZombiePreviews>b__18_0(ChessManager.ZombieWithRow z);
        /*0x533950*/ int <ShowZombiePreviews>b__18_1(System.Linq.IGrouping<int, ChessManager.ZombieWithRow> g);
        /*0x415460*/ ZombieType <ShowZombiePreviews>b__18_2(ChessManager.ZombieWithRow z);
        /*0x5339a0*/ ZombieType <ShowZombiePreviews>b__18_3(System.Linq.IGrouping<ZombieType, ChessManager.ZombieWithRow> g);
        /*0x5339f0*/ int <ShowZombiePreviews>b__18_4(System.Linq.IGrouping<ZombieType, ChessManager.ZombieWithRow> g);
    }

    class <StartSummonZombie>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ChessManager <>4__this;
        /*0x28*/ float <timer>5__2;
        /*0x2c*/ UnityEngine.Vector2 <fogEnd>5__3;

        /*0x32f460*/ <StartSummonZombie>d__22(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x533550*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x533770*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <WaveEnd>d__23 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ChessManager <>4__this;
        /*0x28*/ float <timer>5__2;
        /*0x2c*/ UnityEngine.Vector2 <fogEnd>5__3;

        /*0x32f460*/ <WaveEnd>d__23(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x533bf0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x533e80*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

enum ChessType
{
    兵 = 0,
    車 = 1,
    馬 = 2,
    炮 = 3,
    相 = 4,
    士 = 5,
    将 = 6,
}

class DrawCardManager : UnityEngine.MonoBehaviour
{
    static float BASE_ULTI_RATE = 0.019999999552965164;
    static int PITY_COUNT = 90;
    static int SOFT_PITY_START = 75;
    static float SOFT_PITY_INCREMENT = 0.05999999865889549;
    static /*0x0*/ DrawCardManager Instance;
    /*0x20*/ UnityEngine.GameObject textHead;
    /*0x28*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> texts;
    /*0x30*/ PlantType up;
    /*0x38*/ string upName;
    /*0x40*/ float timer;
    /*0x44*/ float updateTimer;
    /*0x48*/ System.Collections.Generic.List<PlantType> NormalPool;
    /*0x50*/ System.Collections.Generic.List<PlantType> WeakUltiPool;
    /*0x58*/ System.Collections.Generic.List<PlantType> StrongUltiPool;
    /*0x60*/ int pullCountSinceLastUlti;
    /*0x64*/ bool lastPullWasUlti;

    /*0x525020*/ DrawCardManager();
    /*0x523db0*/ string GetName();
    /*0x523d40*/ void Awake();
    /*0x524830*/ void Start();
    /*0x524e00*/ void Update();
    /*0x524bf0*/ void UpdateText();
    /*0x524130*/ void InitializePools();
    /*0x523e90*/ System.Collections.Generic.List<PlantType> GetNormalPool();
    /*0x524510*/ System.Collections.Generic.List<PlantType> Pull(int pullCount);
    /*0x524420*/ PlantType PerformSinglePull();
    /*0x524af0*/ PlantType UltiPull();
    /*0x524110*/ PlantType GuaranteedUltiPull();
    /*0x524730*/ void SetUpPlant(PlantType upPlant);

    class <>c
    {
        static /*0x0*/ DrawCardManager.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__21_0;
        static /*0x10*/ System.Predicate<PlantType> <>9__21_1;

        static /*0x533a30*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5338a0*/ bool <InitializePools>b__21_0(PlantType p);
        /*0x5338f0*/ bool <InitializePools>b__21_1(PlantType p);
    }
}

class ContestedFlag : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject plantFlag;
    /*0x28*/ UnityEngine.GameObject zombieFlag;
    /*0x30*/ Board board;
    /*0x38*/ Team team;
    /*0x3c*/ int theColumn;
    /*0x40*/ int theRow;
    /*0x48*/ System.Collections.Generic.List<Zombie> zombies;
    /*0x50*/ System.Collections.Generic.List<Zombie> hypnoZombies;
    /*0x58*/ float summonTimer;
    /*0x5c*/ int level;
    /*0x60*/ float levelUpTimer;

    static /*0x523a00*/ ContestedFlag SetFlag(Board board, int theColumn, int theRow);
    /*0x523c90*/ ContestedFlag();
    /*0x5234a0*/ void OnUpdate();
    /*0x5232e0*/ ZombieType GetZombieType();
    /*0x522d30*/ void FixedUpdate();
    /*0x523340*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x5233f0*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x522cd0*/ void ChangeTeam(Team team);

    class <>c
    {
        static /*0x0*/ ContestedFlag.<> <>9;
        static /*0x8*/ System.Predicate<Zombie> <>9__13_0;
        static /*0x10*/ System.Predicate<Zombie> <>9__13_1;

        static /*0x533b80*/ <>c();
        /*0x32f970*/ <>c();
        /*0x533800*/ bool <FixedUpdate>b__13_0(Zombie z);
        /*0x533850*/ bool <FixedUpdate>b__13_1(Zombie z);
    }
}

class FlagGameManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ System.Collections.Generic.List<ContestedFlag> flags;
    /*0x30*/ float timer;

    /*0x525550*/ FlagGameManager();
    /*0x5250c0*/ void Start();
    /*0x5251d0*/ void Update();
}

class FruitBlade : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Camera mainCamera;
    /*0x28*/ UnityEngine.Collider2D bladeCollider;
    /*0x30*/ UnityEngine.TrailRenderer trail;
    /*0x38*/ UnityEngine.Vector2 previousPosition;
    /*0x40*/ FruitNinjaManager manager;
    /*0x48*/ float minSliceVelocity;
    /*0x4c*/ bool auto;
    /*0x4d*/ bool clicking;
    /*0x50*/ float speed;
    /*0x54*/ UnityEngine.Vector2 direction;
    /*0x5c*/ float minX;
    /*0x60*/ float maxX;
    /*0x64*/ float minY;
    /*0x68*/ float maxY;

    /*0x525c40*/ FruitBlade();
    /*0x5255d0*/ void Awake();
    /*0x5258d0*/ void Update();
    /*0x5257b0*/ void Start();
    /*0x525660*/ void CheckBoundaries();
}

class FruitBomb : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject explosionPrefab;
    /*0x28*/ UnityEngine.Rigidbody2D rb;

    /*0x31c640*/ FruitBomb();
    /*0x525c60*/ void Awake();
    /*0x525f00*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
    /*0x525cb0*/ void Explode();
    /*0x525ea0*/ void OnBecameInvisible();
}

class FruitNinjaManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ FruitNinjaManager Instance;
    /*0x20*/ bool isGameOver;
    /*0x21*/ bool rogue;
    /*0x22*/ bool combo;
    /*0x24*/ int comboCount;
    /*0x28*/ UnityEngine.GameObject bombPrefab;
    /*0x30*/ float spawnRate;
    /*0x34*/ float minSpawnForce;
    /*0x38*/ float maxSpawnForce;
    /*0x40*/ System.Collections.Generic.Dictionary<FruitType, UnityEngine.GameObject> FruitPrefabs;
    /*0x48*/ System.Collections.Generic.List<FruitType> allFruitTypes;
    /*0x50*/ float timer;
    /*0x58*/ Board board;
    /*0x60*/ int lastWave;
    /*0x68*/ System.Collections.Generic.Dictionary<FruitBuffType, System.ValueTuple<string, int>> BuffDescriptions;
    /*0x70*/ System.Collections.Generic.Dictionary<FruitBuffType, int> buffCount;

    /*0x528510*/ FruitNinjaManager();
    /*0x5263d0*/ void Awake();
    /*0x527d70*/ void Start();
    /*0x5280e0*/ void Update();
    /*0x527b20*/ void SpawnObject();
    /*0x526620*/ FruitType GetFruitType();
    /*0x526cc0*/ UnityEngine.Vector4 GetSpawnData();
    /*0x527870*/ FruitObject SpawnFruit(FruitType fruitType, UnityEngine.Vector2 position, UnityEngine.Vector2 force);
    /*0x526170*/ void AddScore(float points);
    /*0x527450*/ void LoseScore(float value);
    /*0x5283b0*/ void ZombieDeath(Zombie zombie);
    /*0x527590*/ void ShowBuff();
    /*0x527dd0*/ bool TryGetBuffCount(FruitBuffType fruitBuffType, ref int count);
    /*0x526ad0*/ void GetNewBuff(FruitBuffType fruitBuffType);
    /*0x527630*/ void SpawnBomb(UnityEngine.Vector2 position, float force);
    /*0x527e60*/ bool TryGetLeftZombieX(ref Zombie leftZombie);

    enum FruitStart
    {
        上方 = 0,
        左边 = 1,
        右边 = 2,
        下方 = 3,
    }
}

enum FruitBuffType
{
    力大砖飞 = 0,
    有丝分裂 = 1,
    多多益善 = 2,
    东风快递 = 3,
    天降甘露 = 4,
    西夷贡品 = 5,
    御剑飞行 = 6,
    一刀两断 = 7,
    回光返照 = 8,
    僵尸盛宴 = 9,
    冰封千里 = 10,
    怒火攻心 = 11,
    金瓜蛋子 = 12,
    防爆墙 = 13,
    至极手速 = 14,
    来硬的 = 15,
    火神之力 = 16,
    火神专精 = 17,
    冰神之力 = 18,
    三尺之寒 = 19,
    当头一棒 = 20,
    铁头娃 = 21,
    催眠曲 = 22,
    魅惑神力 = 23,
    大局逆转 = 24,
}

class FruitObject : UnityEngine.MonoBehaviour
{
    /*0x20*/ int scoreValue;
    /*0x28*/ UnityEngine.GameObject slicedPrefab;
    /*0x30*/ FruitType fruitType;
    /*0x38*/ FruitNinjaManager manager;
    /*0x40*/ UnityEngine.Rigidbody2D rb;
    /*0x48*/ bool split;
    /*0x4c*/ int baseDamage;
    /*0x50*/ bool isSliced;

    /*0x52a770*/ FruitObject();
    /*0x528eb0*/ void Awake();
    /*0x529160*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
    /*0x528f00*/ void FixedUpdate();
    /*0x529e40*/ void Slice();
    /*0x529210*/ void SliceEvent();
}

enum FruitType
{
    Melon = 0,
    WinterMelon = 1,
    FireMelon = 2,
    ButterMelon = 3,
    HypnoMelon = 4,
    IronMelon = 5,
    UltimateFireMelon = 6,
}

class Game2048Manager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ int range;
    /*0x2c*/ bool over;
    /*0x2d*/ bool stop;
    /*0x30*/ float moveSpeed;
    /*0x34*/ bool isAnimating;
    /*0x38*/ System.Collections.Generic.List<Plant> movingPlants;
    /*0x40*/ System.Collections.Generic.List<PlantType> UpgradeRoute;

    /*0x52bdc0*/ Game2048Manager();
    /*0x52ba30*/ void Start();
    /*0x52bbd0*/ void Update();
    /*0x52b750*/ void SetPlant();
    /*0x52b0b0*/ System.Collections.IEnumerator MoveUpWithAnimation();
    /*0x52ad50*/ System.Collections.IEnumerator MoveDownWithAnimation();
    /*0x52adc0*/ System.Collections.IEnumerator MoveLeftWithAnimation();
    /*0x52b040*/ System.Collections.IEnumerator MoveRightWithAnimation();
    /*0x52ae30*/ void MovePlantWithAnimation(Plant plant, int newCol, int newRow);
    /*0x52b120*/ void PlantPositionUpdate();
    /*0x52aad0*/ Plant MixPlant(Plant plant1, Plant plant2);
    /*0x52a790*/ bool IsGameOver();
    /*0x52bb80*/ bool <MoveUpWithAnimation>b__10_0();
    /*0x52ba90*/ bool <MoveDownWithAnimation>b__11_0();
    /*0x52bae0*/ bool <MoveLeftWithAnimation>b__12_0();
    /*0x52bb30*/ bool <MoveRightWithAnimation>b__13_0();

    class <MoveDownWithAnimation>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Game2048Manager <>4__this;
        /*0x28*/ bool <moved>5__2;

        /*0x32f460*/ <MoveDownWithAnimation>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5324c0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5328a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveLeftWithAnimation>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Game2048Manager <>4__this;
        /*0x28*/ bool <moved>5__2;

        /*0x32f460*/ <MoveLeftWithAnimation>d__12(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5328e0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x532cd0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveRightWithAnimation>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Game2048Manager <>4__this;
        /*0x28*/ bool <moved>5__2;

        /*0x32f460*/ <MoveRightWithAnimation>d__13(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x532d10*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5330f0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveUpWithAnimation>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Game2048Manager <>4__this;
        /*0x28*/ bool <moved>5__2;

        /*0x32f460*/ <MoveUpWithAnimation>d__10(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x533130*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x533510*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class LightShadowManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ float timer;

    /*0x52db80*/ LightShadowManager();
    /*0x52daa0*/ void Update();
    /*0x52da40*/ void SwitchWorld();
}

class LoonManager
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, string> LoonNutDic;

    static /*0x52df70*/ LoonManager();
    static /*0x52db90*/ LoonNut GetLoon(Board board, int theColumn, int theRow, PlantType thePlantType);
    /*0x32f970*/ LoonManager();
}

class LoonNut : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x24*/ int currentRow;
    /*0x28*/ int damage;
    /*0x30*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x38*/ LoonNut.LoonDirection direction;
    /*0x40*/ UnityEngine.Animator anim;
    /*0x48*/ Board board;
    /*0x50*/ int hitCount;
    /*0x54*/ bool hit;
    /*0x58*/ System.Collections.Generic.List<float> ys;

    /*0x52f370*/ LoonNut();
    /*0x52e330*/ void HitEffect(Zombie zombie);
    /*0x52e1a0*/ void Awake();
    /*0x52f140*/ void Start();
    /*0x52ee40*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x52ec20*/ void HitUpdate(UnityEngine.Collider2D collision);
    /*0x52f300*/ void Update();
    /*0x52ee50*/ void PositionUpdate();
    /*0x52e220*/ void GetDirection(int currentRow);
    /*0x52f290*/ bool <PositionUpdate>b__16_0(float y);

    enum LoonDirection
    {
        Right = 0,
        Up = 1,
        Down = 2,
    }
}

class IZManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ System.Collections.Generic.List<IZManager.AICard> cards;
    /*0x30*/ int sunCount;
    /*0x38*/ int[] damageLevel;
    /*0x40*/ int[] dangerLevel;
    /*0x48*/ int[] subLevel;
    /*0x50*/ Zombie[] leftestZombie;
    /*0x58*/ int minValue;
    /*0x5c*/ int targetRow;
    /*0x60*/ float timer;
    /*0x68*/ System.Collections.Generic.List<PlantType> avaliablePlants;

    /*0x52d760*/ IZManager();
    /*0x52c850*/ void Awake();
    /*0x52d550*/ void Start();
    /*0x52cc60*/ void InitZombieCard();
    /*0x52ca00*/ void InitCards();
    /*0x52cd40*/ void ObservalUpdate();
    /*0x52d680*/ void Update();
    /*0x52c2f0*/ void ActionUpdate();
    /*0x52c8b0*/ void CardUpdate();

    class AICard
    {
        /*0x10*/ PlantType thePlantType;
        /*0x14*/ int cost;
        /*0x18*/ float cd;
        /*0x1c*/ float fullcd;

        /*0x32f970*/ AICard();
        /*0x51de60*/ bool get_Avaliable();
        /*0x51dd00*/ void Update();
        /*0x51dd40*/ bool Use(int theColumn, int theRow);
    }

    class <>c
    {
        static /*0x0*/ IZManager.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__16_0;

        static /*0x533aa0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5337b0*/ bool <ActionUpdate>b__16_0(Plant p);
    }
}

class NutCannon : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Transform cannonPos;
    /*0x28*/ UnityEngine.Transform shoot;
    /*0x30*/ UnityEngine.Transform wait;
    /*0x38*/ bool auto;
    /*0x40*/ NutCannon_bullet shootObj;
    /*0x48*/ NutCannon_bullet waitObj;
    /*0x50*/ UnityEngine.Animator anim;
    /*0x58*/ float timer;

    /*0x530070*/ NutCannon();
    /*0x52f690*/ void Shoot();
    /*0x52fb00*/ void Start();
    /*0x408450*/ PlantType GetPlantType();
    /*0x52fec0*/ void Update();
    /*0x52f3f0*/ void FixedUpdate();
    /*0x52f440*/ NutCannon_bullet GetBullet(PlantType theSeedType);
}

class NutCannon_bullet : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x24*/ float maxX;
    /*0x28*/ float minX;
    /*0x2c*/ float maxY;
    /*0x30*/ float minY;
    /*0x34*/ int damage;
    /*0x38*/ float moveSpeed;
    /*0x3c*/ bool launched;
    /*0x40*/ UnityEngine.BoxCollider2D col;
    /*0x48*/ UnityEngine.Rigidbody2D rb;

    /*0x530990*/ NutCannon_bullet();
    /*0x530770*/ void Start();
    /*0x530430*/ void Launch();
    /*0x5300e0*/ void FixedUpdate();
    /*0x530080*/ void Die();
    /*0x5304b0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class PlayerShootingManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ PlayerShootingManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ Player player;
    /*0x30*/ int moneyProduction;
    /*0x34*/ bool first;
    /*0x38*/ int lastWave;
    /*0x3c*/ int moneyWave;
    /*0x40*/ System.Collections.Generic.List<Present> presents;

    static /*0x5312b0*/ ZombieType GetZombieType(int wave, ZombieType theZombieType);
    /*0x532440*/ PlayerShootingManager();
    /*0x531ca0*/ PlayerShootingMenu ShowBuff(bool first);
    /*0x530db0*/ void Evolution(bool zombie);
    /*0x530d50*/ void Awake();
    /*0x531da0*/ void Start();
    /*0x531f70*/ void Update();
    /*0x530ff0*/ void GetBuff(PlayerWeaponBuff playerBuff, PlayerWeaponType playerWeaponType);
    /*0x531b50*/ void InitPlayer();
    /*0x531200*/ string GetDescription(PlayerWeaponBuff playerBuff);
}

class Leader_UltimateGatling
{
    static /*0x54bbb0*/ void UpdateLeaderBonus(int theColumn, int theRow);
    static /*0x54ba60*/ int CountNearbyGatlings(int theColumn, int theRow);

    class <>c
    {
        static /*0x0*/ Leader_UltimateGatling.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__1_0;

        static /*0x5535b0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5534f0*/ bool <CountNearbyGatlings>b__1_0(Plant item);
    }
}

class Leader_UlitmateChomper
{
    static /*0x54b500*/ void UpdateLeaderBonus(int theColumn, int theRow);
}

class Leader_SnowGatlingPuff
{
    static /*0x54b2a0*/ void UpdateLeaderBonus(int theColumn, int theRow);
}

class Leader_UltimateCabbage
{
    static /*0x54b7a0*/ void UpdateLeaderBonus(int theColumn, int theRow);
    static /*0x54b800*/ void UpdateSingleBox(int theColumn, int theRow);
}

class RogueManager
{
    static /*0x0*/ RogueManager _instance;
    /*0x10*/ CampType campType;
    /*0x14*/ LeaderType leaderType;
    /*0x18*/ System.Collections.Generic.List<PlantType> rogueCards;
    /*0x20*/ System.Collections.Generic.List<ZombieType> zombies_a;
    /*0x28*/ System.Collections.Generic.List<ZombieType> zombies_b;
    /*0x30*/ System.Collections.Generic.List<ZombieType> zombies_c;
    /*0x38*/ ZombieType boss;
    /*0x3c*/ float timer;

    static /*0x54d550*/ RogueManager get_Instance();
    /*0x54d430*/ RogueManager();
    /*0x54be80*/ void Clear();
    /*0x54cb80*/ void OnUpdate(Board board);
    /*0x54cdd0*/ void UpdateBox(int theColumn, int theRow);
    /*0x54d350*/ void UpdateLeaderBonus(int theColumn, int theRow);
    /*0x54d1c0*/ void UpdateCampBonus(int theColumn, int theRow);
    /*0x54bf10*/ void CrisisManifested(int level, bool refresh);
    /*0x54c830*/ void InitLevel(Board board);
    /*0x54c4e0*/ System.Collections.Generic.List<ZombieType> GetZombieTypes(int round);
    /*0x54caf0*/ void LoadData(SurvivalData survivalData);
    /*0x54c0b0*/ System.Collections.Generic.List<ZombieType> GetRandomZombies(int level);

    class <>c
    {
        static /*0x0*/ RogueManager.<> <>9;
        static /*0x8*/ System.Predicate<ZombieType> <>9__20_0;

        static /*0x553620*/ <>c();
        /*0x32f970*/ <>c();
        /*0x553560*/ bool <GetRandomZombies>b__20_0(ZombieType z);
    }
}

enum CampType
{
    Land = 0,
    Water = 1,
}

enum LeaderType
{
    Nothing = 0,
    UltimateGatling = 1,
    UltimateChomper = 2,
    SuperMachineNut = 3,
    SnowGatlingPuff = 4,
    UltimateFume = 5,
    UltimateTallNut = 6,
    UltimateCabbage = 7,
    Present = 8,
    UltimateGloom = 9,
}

class ShootingManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ShootingManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ int refreshCount;
    /*0x2c*/ int lastWave;
    /*0x30*/ System.Collections.Generic.List<PlantType> YourPlants;
    /*0x38*/ System.Collections.Generic.List<PlantType> RestPlants;
    /*0x40*/ System.Collections.Generic.List<PlantType> AllPlants;
    /*0x48*/ System.Collections.Generic.List<System.Collections.Generic.List<PlantType>> UpgradeRoute;
    /*0x50*/ System.Collections.Generic.List<System.Collections.Generic.List<PlantType>> UpgradeRoute2;
    /*0x58*/ System.Collections.Generic.Dictionary<PlantType, int> UpgradeDamage;

    static /*0x54e330*/ ZombieType GetZombieType(int wave, ZombieType theZombieType);
    static /*0x54db30*/ PlantType GetPlantTypeByBuff(ShootingBuff shootingBuff);
    /*0x54f360*/ ShootingManager();
    /*0x54d6f0*/ void Awake();
    /*0x54d9a0*/ Plant FindPlant(PlantType thePlantType);
    /*0x54d750*/ bool ClickCard(CardUI card);
    /*0x54ee60*/ void Reinforce(Plant plant);
    /*0x54ea70*/ void LosePlant(PlantType thePlantType);
    /*0x54dd90*/ System.Collections.Generic.List<ShootingBuff> GetRandomUpgrades();
    /*0x54f220*/ void Update();
    /*0x54f180*/ void ShowBuff();
    /*0x54d900*/ void ContinueGame();

    class <>c__DisplayClass5_0
    {
        /*0x10*/ PlantType thePlantType;

        /*0x32f970*/ <>c__DisplayClass5_0();
        /*0x35c700*/ bool <FindPlant>b__0(Plant p);
        /*0x35c700*/ bool <FindPlant>b__1(Plant p);
    }
}

enum ShootingBuff
{
    None = 0,
    GetPeashooter = 1,
    UpgradePeashooter = 2,
    GetWallNut = 3,
    UpgradeWallNut = 4,
    GetPotatoMine = 5,
    UpgradePotatoMine = 6,
    GetChomper = 7,
    UpgradeChomper = 8,
    GetSmallPuff = 9,
    UpgradeSmallPuff = 10,
    GetFumeShroom = 11,
    UpgradeFumeShroom = 12,
    GetScaredyShroom = 13,
    UpgradeScaredyShroom = 14,
    GetThreePeater = 15,
    UpgradeThreePeater = 16,
    GetCaltrop = 17,
    UpgradeCaltrop = 18,
    GetCactus = 19,
    UpgradeCactus = 20,
    GetStarFruit = 21,
    UpgradeStarFruit = 22,
    GetCabbagepult = 23,
    UpgradeCabbagepult = 24,
    GetCornpult = 25,
    UpgradeCornpult = 26,
    GetMelonpult = 27,
    UpgradeMelonpult = 28,
}

enum UpgradeType
{
    UpgradeDamage = 0,
    UpgradeSpeed = 1,
    UniqueUpgrade = 2,
    UpgradeHealth = 3,
}

class SnakeManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ Plant head;
    /*0x30*/ SnakeManager.Direction direction;
    /*0x34*/ float moveTimer;
    /*0x38*/ float summonTimer;
    /*0x40*/ Present present;
    /*0x48*/ int restPresent;
    /*0x4c*/ bool change;
    /*0x50*/ System.Collections.Generic.List<SnakeManager.SnakeLine> lines;

    /*0x552ab0*/ SnakeManager();
    /*0x552b30*/ Plant get_Tail();
    /*0x552250*/ void Start();
    /*0x5528d0*/ void Update();
    /*0x5520f0*/ void MoveUpdate();
    /*0x551e50*/ void MoveSnake(int theColumn, int theRow);
    /*0x5527d0*/ void UpdateLines();
    /*0x5517a0*/ void MoveBox(int theColumn, int theRow);
    /*0x551410*/ PlantType GetPlantType();
    /*0x551660*/ UnityEngine.Vector2Int GetTargetGrid(int theColumn, int theRow);
    /*0x552340*/ void SummonUpdate();

    enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3,
    }

    class SnakeLine
    {
        /*0x10*/ UnityEngine.LineRenderer line;
        /*0x18*/ Plant plant1;
        /*0x20*/ Plant plant2;

        /*0x5512b0*/ SnakeLine(Plant from, Plant to);
        /*0x551050*/ void UpdateLine();
    }
}

class TowerManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ TowerManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ MusicType musicType;

    /*0x31c640*/ TowerManager();
    /*0x552bc0*/ void Awake();
    /*0x553000*/ void Update();
    /*0x552c20*/ void SummonZombies(int theWave);
}

class ZombieBattleManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ZombieBattleManager Instance;
    /*0x20*/ Zombie controlledZombie;
    /*0x28*/ UnityEngine.Vector2Int zombieBox;
    /*0x30*/ int maxHealth;
    /*0x34*/ bool lose;
    /*0x38*/ float timer;

    /*0x553fa0*/ ZombieBattleManager();
    /*0x553690*/ void Awake();
    /*0x553cf0*/ void Start();
    /*0x553a30*/ void SelectZombie(Zombie zombie);
    /*0x553780*/ void InitZombie();
    /*0x553d00*/ void Update();
    /*0x553910*/ void MoveBox(int theColumn, int theRow);
    /*0x5536f0*/ UnityEngine.Vector2 GetZombiePosition();
}

class Parameter
{
    /*0x10*/ ZombieBoss boss;

    /*0x32f970*/ Parameter();
}

class BossStatusManager : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ BossStatusManager();
}

class IdleState
{
    /*0x32f970*/ IdleState();
}

interface IState
{
    /*0x180fc0*/ void OnEnter();
    /*0x180fc0*/ void OnUpdate();
    /*0x180fc0*/ void OnExit();
}

class Brain : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theRow;
    /*0x24*/ int theHealth;
    /*0x28*/ Board board;
    /*0x30*/ BrainManager brainManager;

    /*0x31c640*/ Brain();
    /*0x53fbd0*/ void Update();
    /*0x53f9f0*/ void Die();
    /*0x53f7b0*/ void DieEvent();
    /*0x53fc80*/ void WinAction();
    /*0x53f400*/ void ClearRow(int theRow);
    /*0x53f130*/ void ClearAll();
    /*0x53fb00*/ void FlashOnce();
    /*0x53fa90*/ System.Collections.IEnumerator FlashObject(UnityEngine.Material mt);

    class <FlashObject>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.Material mt;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <FlashObject>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5530d0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x553250*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BrainManager
{
    /*0x10*/ System.Collections.Generic.List<Brain> brains;
    /*0x18*/ Board board;
    /*0x20*/ int winRoad;

    /*0x53eda0*/ BrainManager(Board board);
    /*0x53ea00*/ void SetBrain(int row);
    /*0x53ecb0*/ void Win();
}

class Bullet : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x30*/ UnityEngine.Transform shadow;
    /*0x38*/ UnityEngine.Rigidbody2D rb;
    /*0x40*/ UnityEngine.Collider2D col;
    /*0x48*/ BaseMoveWay moveWay;
    /*0x50*/ UnityEngine.LayerMask zombieLayer;
    /*0x54*/ BulletType theBulletType;
    /*0x58*/ float minX;
    /*0x5c*/ float minY;
    /*0x60*/ float maxX;
    /*0x64*/ float maxY;
    /*0x68*/ Zombie targetZombie;
    /*0x70*/ Plant targetPlant;
    /*0x78*/ System.Collections.Generic.List<AirProjectile> targetProjectiles;
    /*0x80*/ Plant torchWood;
    /*0x88*/ Plant parentPlantInDream;
    /*0x90*/ Plant from;
    /*0x98*/ BlackHole blackHole;
    /*0xa0*/ BulletStatus theStatus;
    /*0xa4*/ int rogueStatus;
    /*0xa8*/ UnityEngine.Vector2 cannonPos;
    /*0xb0*/ int theMovingWay;
    /*0xb4*/ int theBulletRow;
    /*0xb8*/ int _damage;
    /*0xbc*/ int hitTimes;
    /*0xc0*/ int penetrationTimes;
    /*0xc4*/ float theExistTime;
    /*0xc8*/ int indexInArray;
    /*0xcc*/ int shootingLevel;
    /*0xd0*/ bool hit;
    /*0xd1*/ bool isZombieBullet;
    /*0xd2*/ bool isLand;
    /*0xd3*/ bool melonSputter;
    /*0xd4*/ bool umbrellaed;
    /*0xd5*/ bool goldMagneted;
    /*0xd6*/ bool goldThreeTorch;
    /*0xd7*/ bool accelerate;
    /*0xd8*/ float Vx;
    /*0xdc*/ float Vy;
    /*0xe0*/ float detaVx;
    /*0xe4*/ float detaVy;
    /*0xe8*/ float trackSpeed;
    /*0xec*/ float normalSpeed;
    /*0xf0*/ float magnetNutAngle;
    /*0xf4*/ float height;
    /*0xf8*/ bool dying;

    /*0x31c640*/ Bullet();
    /*0x54b1d0*/ int get_Damage();
    /*0x54b1e0*/ void set_Damage(int value);
    /*0x543770*/ void InitData();
    /*0x32d010*/ void Awake();
    /*0x541790*/ void Die();
    /*0x546270*/ void Update();
    /*0x545760*/ void ShadowTransformUpdate();
    /*0x5446d0*/ void PostionUpdate();
    /*0x543bc0*/ void JumpUpdate();
    /*0x543ac0*/ void JumpLand();
    /*0x53ffa0*/ void CannonBulletUpdate();
    /*0x5459a0*/ void ThrowBulletUpdate();
    /*0x541310*/ void ConvoluteUpdate();
    /*0x542b80*/ Zombie GetSingleRowFlyingZombie();
    /*0x545a80*/ void TrackSingleRowUpdate();
    /*0x545d50*/ void TrackUpdate();
    /*0x542520*/ Zombie GetNearestLandZombie();
    /*0x542830*/ Zombie GetNearestZombie();
    /*0x543de0*/ bool NearestZombieCondition(Zombie zombie);
    /*0x542200*/ Zombie GetNearestFlyingZombie();
    /*0x542100*/ void FixedUpdate();
    /*0x543d50*/ void MoveDieUpdate(UnityEngine.Vector2 currentPosition);
    /*0x542e80*/ void HitLandUpdate();
    /*0x543200*/ void HitLand();
    /*0x542e60*/ void HitBlock();
    /*0x544f90*/ void RollingUpdate();
    /*0x543e70*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x543fa0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x544340*/ void PirouetteZombie(Zombie zombie);
    /*0x543d00*/ void KeepHiting(Zombie zombie);
    /*0x546080*/ void TrackZombieSingleRow(Zombie zombie);
    /*0x546180*/ void TrackZombie(Zombie zombie);
    /*0x540770*/ void CheckPlant(Plant plant);
    /*0x544d50*/ void Rebound(Plant plant);
    /*0x543290*/ void HitPlantInDream(Shooter shooter);
    /*0x53ff80*/ bool AllowUp(PlantType type);
    /*0x53fde0*/ bool AllowDown(PlantType type);
    /*0x5451a0*/ void Rotate(UnityEngine.GameObject obj, int angle);
    /*0x540fe0*/ void CheckZombie(Zombie zombie);
    /*0x543660*/ bool HitZombieCondition(ZombieStatus theZombieStatus);
    /*0x32d010*/ void HitPlant(Plant plant);
    /*0x543700*/ void HitZombie(Zombie zombie);
    /*0x544420*/ void PlaySound(Zombie zombie);
    /*0x541f20*/ void FireZombie(Zombie zombie, bool warm);
    /*0x5418b0*/ void FireOtherZombie(Zombie targetZombie, bool warm);
    /*0x53fe00*/ bool AllowSputter(Zombie zombie);
}

enum BulletMoveWay
{
    Jump = -1,
    MoveRight = 0,
    Roll = 1,
    Free = 2,
    Puff = 3,
    Three_up = 4,
    Three_down = 5,
    Track = 6,
    Fly = 7,
    Fly2 = 8,
    Left = 9,
    Stable = 10,
    Rounding = 11,
    LittleFly = 12,
    Throw = 13,
    Cannon = 14,
    Right_free = 15,
    Convolute = 16,
    Quick_throw = 17,
    Freefly = 18,
    Split_left = 19,
    Track_air_singleRow = 20,
    Sin = 21,
    Cos = 22,
    Pirouette = 23,
}

class Bullet_basketball : Bullet_cabbage
{
    /*0x31c640*/ Bullet_basketball();
    /*0x5463a0*/ void HitPlant(Plant plant);
    /*0x546400*/ void HitZombie(Zombie zombie);
    /*0x546390*/ void HitLand();
}

class Bullet_bigButter : Bullet_sunCabbage
{
    /*0x546660*/ Bullet_bigButter();
    /*0x546650*/ void SetPenetrationTime();
    /*0x546530*/ void HitZombie(Zombie zombie);
    /*0x546450*/ void HitLand();
}

class Bullet_bigKernal : Bullet_sunCabbage
{
    /*0x546660*/ Bullet_bigKernal();
    /*0x546650*/ void SetPenetrationTime();
    /*0x546750*/ void HitZombie(Zombie zombie);
    /*0x546670*/ void HitLand();
}

class Bullet_blackPuff : Bullet
{
    /*0x31c640*/ Bullet_blackPuff();
    /*0x546930*/ void HitZombie(Zombie zombie);
    /*0x546850*/ void HitLand();
}

class Bullet_butter : Bullet_cabbage
{
    /*0x31c640*/ Bullet_butter();
    /*0x546c30*/ void HitLand();
    /*0x546cf0*/ void HitZombie(Zombie zombie);
}

class Bullet_butterMelon : Bullet_melon
{
    /*0x546660*/ Bullet_butterMelon();
    /*0x5469f0*/ void HitLand();
    /*0x546ae0*/ void HitZombie(Zombie zombie);
}

class Bullet_butter_iron : Bullet_butter
{
    /*0x31c640*/ Bullet_butter_iron();
    /*0x546ef0*/ void HitZombie(Zombie zombie);
    /*0x546e20*/ void HitLand();
}

class Bullet_butter_portal : Bullet_butter
{
    /*0x108*/ UnityEngine.GameObject holePrefab;

    /*0x31c640*/ Bullet_butter_portal();
    /*0x547030*/ void HitLand();
    /*0x547210*/ void HitZombie(Zombie zombie);
}

class Bullet_butter_ulti : Bullet
{
    /*0x31c640*/ Bullet_butter_ulti();
    /*0x547580*/ void HitZombie(Zombie zombie);
    /*0x547490*/ void HitLand();
}

class Bullet_cabbage : Bullet
{
    /*0x100*/ UnityEngine.Transform spriteObject;

    /*0x31c640*/ Bullet_cabbage();
    /*0x548160*/ void Awake();
    /*0x548390*/ void HitZombie(Zombie zombie);
    /*0x5482b0*/ void HitLand();
    /*0x5481b0*/ void FixedUpdate();
    /*0x548450*/ void RotateUpdate();
}

class Bullet_cabbageMelon : Bullet_sunCabbage
{
    /*0x546660*/ Bullet_cabbageMelon();
    /*0x548150*/ void SetPenetrationTime();
    /*0x547f00*/ void HitLand();
    /*0x547ff0*/ void HitZombie(Zombie zombie);
    /*0x547720*/ void AttackOtherZombie(Zombie targetZombie, int damageType);
}

class Bullet_cabbage_small : Bullet_sunCabbage
{
    /*0x108*/ bool smallEffect;

    /*0x546660*/ Bullet_cabbage_small();
    /*0x548710*/ void InitData();
    /*0x546650*/ void SetPenetrationTime();
    /*0x5485c0*/ void HitZombie(Zombie zombie);
    /*0x5484e0*/ void HitLand();
}

class Bullet_cabbage_ulti : Bullet_cabbage_small
{
    /*0x546660*/ Bullet_cabbage_ulti();
    /*0x548830*/ void HitZombie(Zombie zombie);
    /*0x548730*/ void HitLand();
}

class Bullet_cactus : Bullet_pierce
{
    /*0x546660*/ Bullet_cactus();
    /*0x548b40*/ void HitZombie(Zombie zombie);
    /*0x548ac0*/ void HitLand();
    /*0x548ba0*/ void InitData();
    /*0x548c30*/ System.Collections.IEnumerator RotateTowardsTarget();
    /*0x548ca0*/ void SetPenetrationTime();

    class <RotateTowardsTarget>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Bullet_cactus <>4__this;
        /*0x28*/ float <rotationSpeed>5__2;
        /*0x2c*/ float <smoothTime>5__3;
        /*0x30*/ UnityEngine.Quaternion <startRotation>5__4;
        /*0x40*/ UnityEngine.Quaternion <targetRotation>5__5;
        /*0x50*/ float <elapsedTime>5__6;

        /*0x32f460*/ <RotateTowardsTarget>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x553290*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5534b0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Bullet_cactusStar : Bullet_star
{
    /*0x548ab0*/ Bullet_cactusStar();
    /*0x5489d0*/ Zombie GetNearestZombie();
    /*0x548a60*/ void Update();
    /*0x543700*/ void HitZombie(Zombie zombie);
    /*0x5489e0*/ void HitLand();
}

class Bullet_cannon : Bullet
{
    /*0x31c640*/ Bullet_cannon();
    /*0x54b180*/ void InitData();
    /*0x548de0*/ void HitLand();
    /*0x548cb0*/ void FireDoomAction(UnityEngine.Vector2 center, int damage);

    class <>c__DisplayClass1_0
    {
        /*0x10*/ int hugeDamage;
        /*0x18*/ Bullet_cannon <>4__this;
        /*0x20*/ System.Action <>9__1;

        /*0x32f970*/ <>c__DisplayClass1_0();
        /*0x568880*/ void <HitLand>b__1();
    }

    class <>c__DisplayClass1_1
    {
        /*0x10*/ UnityEngine.Vector3 center;
        /*0x20*/ Bullet_cannon.<> CS$<>8__locals1;
        /*0x28*/ System.Action <>9__0;

        /*0x32f970*/ <>c__DisplayClass1_1();
        /*0x568a70*/ void <HitLand>b__0();
    }
}

class Bullet_cherry : Bullet
{
    /*0x317730*/ Bullet_cherry();
    /*0x554490*/ void HitZombie(Zombie zombie);
    /*0x5542a0*/ void HitLand();
    /*0x554380*/ void HitPlant(Plant plant);
}

class Bullet_cherryJalapeno : Bullet_pierce
{
    /*0x317730*/ Bullet_cherryJalapeno();
    /*0x554100*/ void SetPenetrationTime();
    /*0x554040*/ void HitZombie(Zombie zombie);
    /*0x553fb0*/ void HitLand();
}

class Bullet_cherrySquash : Bullet_squash
{
    /*0x317730*/ Bullet_cherrySquash();
    /*0x554110*/ void AttackZombie();
}

class Bullet_cornMelon : Bullet_melon
{
    /*0x317730*/ Bullet_cornMelon();
    /*0x554560*/ void HitLand();
    /*0x554650*/ void HitZombie(Zombie zombie);
}

class Bullet_corn_ulti : Bullet_garlicKernal
{
    /*0x317730*/ Bullet_corn_ulti();
    /*0x554780*/ void HitZombie(Zombie zombie);
}

class Bullet_doom : Bullet
{
    /*0x100*/ UnityEngine.Transform sprite;

    /*0x317730*/ Bullet_doom();
    /*0x554e70*/ void HitZombie(Zombie zombie);
    /*0x554a60*/ void HitLand();
    /*0x554b40*/ void HitPlant(Plant plant);
    /*0x554a10*/ void Awake();
    /*0x555180*/ void Update();
}

class Bullet_doomCactus : Bullet_pierce
{
    /*0x317730*/ Bullet_doomCactus();
    /*0x554a00*/ void SetPenetrationTime();
    /*0x554950*/ void HitZombie(Zombie zombie);
    /*0x554870*/ void HitLand();
}

class Bullet_doom_throw : Bullet
{
    /*0x317730*/ Bullet_doom_throw();
    /*0x555570*/ void Update();
    /*0x555560*/ void HitZombie(Zombie zombie);
    /*0x555560*/ void HitLand();
    /*0x555230*/ void Explode();
}

class Bullet_endoSun : Bullet
{
    /*0x317730*/ Bullet_endoSun();
    /*0x5558e0*/ void HitZombie(Zombie zombie);
    /*0x555750*/ void HitLand();
    /*0x555680*/ void FixedUpdate();
}

class Bullet_extremeSnowPea : Bullet_snowPea
{
    /*0x100*/ UnityEngine.Transform _sprite;

    /*0x317730*/ Bullet_extremeSnowPea();
    /*0x5559f0*/ void Awake();
    /*0x555a40*/ void HitZombie(Zombie zombie);
    /*0x555bd0*/ void Update();
}

class Bullet_fireKelp : Bullet
{
    /*0x317730*/ Bullet_fireKelp();
    /*0x5561a0*/ void HitZombie(Zombie zombie);
    /*0x5560c0*/ void HitLand();
    /*0x555cc0*/ void AttackOtherZombie(Zombie targetZombie);
    /*0x555c80*/ bool AllowSputter(Zombie zombie);
}

class Bullet_fireMelon : Bullet_melon
{
    /*0x317730*/ Bullet_fireMelon();
    /*0x556330*/ void HitLand();
    /*0x556440*/ void HitZombie(Zombie zombie);
}

class Bullet_firePea : Bullet
{
    /*0x100*/ UnityEngine.Transform tail;

    /*0x317730*/ Bullet_firePea();
    /*0x554a10*/ void Awake();
    /*0x556690*/ void Update();
    /*0x556680*/ void HitZombie(Zombie zombie);
    /*0x5565a0*/ void HitLand();
}

class Bullet_firePea_purple : Bullet_firePea
{
    /*0x317730*/ Bullet_firePea_purple();
    /*0x556740*/ void HitZombie(Zombie zombie);
    /*0x5569f0*/ void SetEmbered(Zombie zombie);
}

class Bullet_firePea_super : Bullet_pierce
{
    /*0x317730*/ Bullet_firePea_super();
    /*0x556a20*/ void HitLand();
    /*0x556b00*/ void HitZombie(Zombie zombie);
    /*0x556c70*/ void SetPenetrationTime();
}

class Bullet_fireStar : Bullet_star
{
    /*0x556dc0*/ Bullet_fireStar();
    /*0x556680*/ void HitZombie(Zombie zombie);
    /*0x556ce0*/ void HitLand();
}

class Bullet_fireTrack : Bullet
{
    /*0x317730*/ Bullet_fireTrack();
    /*0x556e50*/ void HitZombie(Zombie zombie);
    /*0x556dd0*/ void HitLand();
}

class Bullet_garlicBomb : Bullet
{
    /*0x317730*/ Bullet_garlicBomb();
    /*0x5571a0*/ void HitZombie(Zombie zombie);
    /*0x5570d0*/ void HitLand();
    /*0x556ed0*/ void AttackZombie();
}

class Bullet_garlicButter : Bullet_butter
{
    /*0x317730*/ Bullet_garlicButter();
    /*0x557360*/ void HitZombie(Zombie zombie);
    /*0x557270*/ void HitLand();
}

class Bullet_garlicCabbage : Bullet_sunCabbage
{
    /*0x317730*/ Bullet_garlicCabbage();
    /*0x548150*/ void SetPenetrationTime();
    /*0x5575e0*/ void HitZombie(Zombie zombie);
    /*0x5574e0*/ void HitLand();
}

class Bullet_garlicKernal : Bullet_kernal
{
    /*0x317730*/ Bullet_garlicKernal();
    /*0x5577a0*/ void HitZombie(Zombie zombie);
}

class Bullet_garlicMelon : Bullet_melon
{
    /*0x317730*/ Bullet_garlicMelon();
    /*0x557890*/ void HitLand();
    /*0x5579b0*/ void HitZombie(Zombie zombie);
}

class Bullet_goldSquashKelp : Bullet_squashKelp
{
    /*0x317730*/ Bullet_goldSquashKelp();
    /*0x557b30*/ void AttackZombie();
}

class Bullet_helmetPea : Bullet_ironPea
{
    /*0x317730*/ Bullet_helmetPea();
    /*0x557d80*/ void HitZombie(Zombie zombie);
}

class Bullet_hypnoPea : Bullet
{
    /*0x317730*/ Bullet_hypnoPea();
    /*0x557fa0*/ void HitZombie(Zombie zombie);
    /*0x557e60*/ void HitPlant(Plant plant);
}

class Bullet_hypnoPea_fire : Bullet_firePea
{
    /*0x317730*/ Bullet_hypnoPea_fire();
    /*0x558260*/ void HitZombie(Zombie zombie);
}

class Bullet_iceBlock : Bullet_cabbage
{
    /*0x317730*/ Bullet_iceBlock();
    /*0x558580*/ void HitZombie(Zombie zombie);
    /*0x5584a0*/ void HitLand();
}

class Bullet_iceBlock_big : Bullet_iceBlock
{
    /*0x317730*/ Bullet_iceBlock_big();
    /*0x5586a0*/ void HitZombie(Zombie zombie);
}

class Bullet_iceBlock_recover : Bullet_cabbage
{
    /*0x317730*/ Bullet_iceBlock_recover();
    /*0x5587c0*/ void HitLand();
}

class Bullet_iceDoom : Bullet_pierce
{
    /*0x317730*/ Bullet_iceDoom();
    /*0x558ca0*/ void HitZombie(Zombie zombie);
    /*0x558b70*/ void HitLand();
}

class Bullet_iceSpark : Bullet_pierce
{
    /*0x317730*/ Bullet_iceSpark();
    /*0x558f20*/ void HitZombie(Zombie zombie);
    /*0x558e40*/ void HitLand();
    /*0x559100*/ void SetPenetrationTime();
}

class Bullet_iceSword : Bullet
{
    /*0x317730*/ Bullet_iceSword();
    /*0x559280*/ void HitPlant(Plant plant);
    /*0x559170*/ void FixedUpdate();
}

class Bullet_iceTrack : Bullet
{
    /*0x317730*/ Bullet_iceTrack();
    /*0x5597d0*/ void HitZombie(Zombie zombie);
    /*0x559750*/ void HitLand();
    /*0x5596d0*/ Zombie GetNearestZombie();
    /*0x559360*/ Zombie GetNearestFreezedZombie();
}

class Bullet_ironPea : Bullet
{
    /*0x317730*/ Bullet_ironPea();
    /*0x559a60*/ void HitZombie(Zombie zombie);
    /*0x559870*/ void HitLand();
    /*0x559950*/ void HitPlant(Plant plant);
}

class Bullet_ironPea_air : Bullet
{
    /*0x317730*/ Bullet_ironPea_air();
    /*0x559ec0*/ void HitZombie(Zombie zombie);
    /*0x559e90*/ void HitLand();
    /*0x559b70*/ void Bomb(int row);
}

class Bullet_ironStar : Bullet_star
{
    /*0x556dc0*/ Bullet_ironStar();
    /*0x559fe0*/ void HitZombie(Zombie zombie);
    /*0x559f00*/ void HitLand();
}

class Bullet_jackboxStar : Bullet_star
{
    /*0x556dc0*/ Bullet_jackboxStar();
    /*0x55a1f0*/ void HitZombie(Zombie zombie);
    /*0x55a0c0*/ void HitLand();
}

class Bullet_kelp : Bullet
{
    /*0x317730*/ Bullet_kelp();
    /*0x55a3b0*/ void HitZombie(Zombie zombie);
    /*0x55a330*/ void HitLand();
}

class Bullet_kernal : Bullet_cabbage
{
    /*0x317730*/ Bullet_kernal();
    /*0x55a4c0*/ void HitZombie(Zombie zombie);
    /*0x55a440*/ void HitLand();
}

class Bullet_lotusSpruce : Bullet
{
    /*0x317730*/ Bullet_lotusSpruce();
    /*0x55a890*/ void HitZombie(Zombie zombie);
    /*0x55a870*/ void HitLand();
    /*0x55a590*/ void AttackZombies();
}

class Bullet_lourCactus : Bullet_cactus
{
    /*0x100*/ CattailLour lour;
    /*0x108*/ float lourTimer;

    /*0x55aa20*/ Bullet_lourCactus();
    /*0x55a9a0*/ void InitData();
    /*0x55a9c0*/ void Update();
    /*0x55a8c0*/ void HitZombie(Zombie zombie);
}

class Bullet_lunarCabbage : Bullet_cabbage
{
    /*0x317730*/ Bullet_lunarCabbage();
    /*0x55ab10*/ void HitZombie(Zombie zombie);
    /*0x55aa30*/ void HitLand();
}

class Bullet_magicTrack : Bullet
{
    /*0x317730*/ Bullet_magicTrack();
    /*0x55ac50*/ void HitZombie(Zombie zombie);
    /*0x55abd0*/ void HitLand();
}

class Bullet_magnetCactus : Bullet
{
    /*0x317730*/ Bullet_magnetCactus();
    /*0x55ae10*/ void HitZombie(Zombie zombie);
    /*0x55ad90*/ void HitLand();
    /*0x55ad00*/ int AttackIronArmor(Zombie zombie, int damage);
}

class Bullet_magnetStar : Bullet_star
{
    /*0x556dc0*/ Bullet_magnetStar();
    /*0x55b1c0*/ void HitZombie(Zombie zombie);
    /*0x55b0e0*/ void HitLand();
    /*0x55b060*/ int AttackIronArmor(Zombie zombie, int damage);
}

class Bullet_melon : Bullet_cabbage
{
    /*0x317730*/ Bullet_melon();
    /*0x55bf10*/ void HitLand();
    /*0x55c000*/ void HitZombie(Zombie zombie);
    /*0x55b3d0*/ void AttackEffect(Zombie zombie, int dmg);
    /*0x55b410*/ void AttackOtherZombie(Zombie targetZombie, int damageType);
}

class Bullet_melonCannon : Bullet_cannon
{
    /*0x100*/ float rotateSpeed;

    /*0x317730*/ Bullet_melonCannon();
    /*0x55b2e0*/ void InitData();
    /*0x55b330*/ void Update();
}

class Bullet_melon_hypno : Bullet_melon
{
    /*0x317730*/ Bullet_melon_hypno();
    /*0x55c250*/ void HitZombie(Zombie zombie);
    /*0x55c130*/ void HitLand();
}

class Bullet_melon_iron : Bullet_melon
{
    /*0x317730*/ Bullet_melon_iron();
    /*0x55c4c0*/ void HitLand();
    /*0x55c5e0*/ void HitZombie(Zombie zombie);
    /*0x55c410*/ void AttackEffect(Zombie zombie, int dmg);
}

class Bullet_melon_magnet : Bullet_melon
{
    /*0x317730*/ Bullet_melon_magnet();
    /*0x55c930*/ void HitZombie(Zombie zombie);
    /*0x55c820*/ void HitLand();
    /*0x55c770*/ void AttackEffect(Zombie zombie, int dmg);
}

class Bullet_melon_portal : Bullet_melon
{
    /*0x317730*/ Bullet_melon_portal();
    /*0x55d040*/ void HitLand();
    /*0x55d150*/ void HitZombie(Zombie zombie);
    /*0x55cac0*/ void Attack(int row);

    class <>c
    {
        static /*0x0*/ Bullet_melon_portal.<> <>9;
        static /*0x8*/ System.Predicate<Zombie> <>9__2_0;

        static /*0x568c90*/ <>c();
        /*0x32f970*/ <>c();
        /*0x568860*/ bool <Attack>b__2_0(Zombie z);
    }
}

class Bullet_melon_small : Bullet
{
    /*0x317730*/ Bullet_melon_small();
    /*0x55d330*/ void HitZombie(Zombie zombie);
    /*0x55d280*/ void HitLand();
}

class Bullet_melon_ulti : Bullet_melon_small
{
    /*0x317730*/ Bullet_melon_ulti();
    /*0x55d540*/ void HitZombie(Zombie zombie);
    /*0x55d440*/ void HitLand();
}

class Bullet_normalSun : Bullet_smallSun
{
    /*0x317730*/ Bullet_normalSun();
    /*0x55d670*/ void HitZombie(Zombie zombie);
}

class Bullet_nut : Bullet_pierce
{
    /*0x317730*/ Bullet_nut();
    /*0x55d8c0*/ void HitZombie(Zombie zombie);
    /*0x55d980*/ void SetPenetrationTime();
    /*0x55d7e0*/ void HitLand();
}

class Bullet_passionFruit : Bullet
{
    /*0x317730*/ Bullet_passionFruit();
    /*0x55da40*/ void HitZombie(Zombie zombie);
    /*0x55d990*/ void HitLand();
}

class Bullet_pea : Bullet
{
    /*0x317730*/ Bullet_pea();
    /*0x55dfb0*/ void HitZombie(Zombie zombie);
    /*0x55dea0*/ void HitPlant(Plant plant);
    /*0x55ddc0*/ void HitLand();
}

class Bullet_pickaxeStar : Bullet_star
{
    /*0x556dc0*/ Bullet_pickaxeStar();
    /*0x55e160*/ void HitZombie(Zombie zombie);
    /*0x55e080*/ void HitLand();
}

class Bullet_pierce : Bullet
{
    /*0x317730*/ Bullet_pierce();
    /*0x55e250*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x55e220*/ void InitData();
    /*0x546650*/ void SetPenetrationTime();
    /*0x55e430*/ void TrackZombie(Zombie zombie);
}

class Bullet_portalPea : Bullet
{
    /*0x317730*/ Bullet_portalPea();
    /*0x55e720*/ void HitZombie(Zombie zombie);
    /*0x55e610*/ void HitPlant(Plant plant);
    /*0x55e530*/ void HitLand();
}

class Bullet_puff : Bullet
{
    /*0x317730*/ Bullet_puff();
    /*0x55fe60*/ void HitZombie(Zombie zombie);
    /*0x55fd80*/ void HitLand();
}

class Bullet_puffLove : Bullet
{
    /*0x317730*/ Bullet_puffLove();
    /*0x55ec50*/ void HitZombie(Zombie zombie);
    /*0x55eb60*/ void HitLand();
    /*0x55e800*/ void AttackZombie(int row);
    /*0x55ecf0*/ void TrySetMindControl(Zombie zombie);
}

class Bullet_puffNut : Bullet_pierce
{
    /*0x317730*/ Bullet_puffNut();
    /*0x554100*/ void SetPenetrationTime();
    /*0x55ef20*/ void HitZombie(Zombie zombie);
    /*0x55ee40*/ void HitLand();
}

class Bullet_puffPea : Bullet
{
    /*0x317730*/ Bullet_puffPea();
    /*0x55f0f0*/ void HitZombie(Zombie zombie);
    /*0x55f010*/ void HitLand();
}

class Bullet_puffPotato : Bullet
{
    /*0x317730*/ Bullet_puffPotato();
    /*0x55f2a0*/ void HitZombie(Zombie zombie);
    /*0x55f1c0*/ void HitLand();
}

class Bullet_puffRandomColor : Bullet
{
    /*0x100*/ UnityEngine.Sprite sprite;
    /*0x108*/ int puffColor;

    /*0x317730*/ Bullet_puffRandomColor();
    /*0x55fab0*/ void InitData();
    /*0x55f6d0*/ void HitLand();
    /*0x55f7b0*/ void HitZombie(Zombie zombie);
    /*0x55f360*/ void AttackZombie();
    /*0x55fc00*/ void TrySetMindControl(Zombie zombie);
}

class Bullet_redLunarCabbage : Bullet_cabbage
{
    /*0x317730*/ Bullet_redLunarCabbage();
    /*0x560020*/ void HitZombie(Zombie zombie);
    /*0x55ff20*/ void HitLand();
}

class Bullet_seaStar : Bullet_star
{
    /*0x556dc0*/ Bullet_seaStar();
    /*0x560200*/ void HitZombie(Zombie zombie);
    /*0x560120*/ void HitLand();
}

class Bullet_shulkLeaf : Bullet_pierce
{
    /*0x100*/ UnityEngine.Transform spriteObject;

    /*0x317730*/ Bullet_shulkLeaf();
    /*0x554a10*/ void Awake();
    /*0x55d980*/ void SetPenetrationTime();
    /*0x5603e0*/ void HitZombie(Zombie zombie);
    /*0x560360*/ void HitLand();
    /*0x5602c0*/ void FixedUpdate();
}

class Bullet_shulkLeaf_ice : Bullet_shulkLeaf
{
    /*0x317730*/ Bullet_shulkLeaf_ice();
    /*0x548150*/ void SetPenetrationTime();
    /*0x560450*/ void HitZombie(Zombie zombie);
    /*0x5607e0*/ void KeepHiting(Zombie zombie);

    class <>c__DisplayClass1_0
    {
        /*0x10*/ Bullet bullet;

        /*0x32f970*/ <>c__DisplayClass1_0();
        /*0x568970*/ void <HitZombie>b__0();
    }
}

class Bullet_shulkLeaf_ultimate : Bullet_pierce
{
    /*0x100*/ UnityEngine.Transform sprite;

    /*0x317730*/ Bullet_shulkLeaf_ultimate();
    /*0x554a10*/ void Awake();
    /*0x55d980*/ void SetPenetrationTime();
    /*0x560a60*/ void MoveDieUpdate(UnityEngine.Vector2 currentPosition);
    /*0x560920*/ void HitZombie(Zombie zombie);
    /*0x560ae0*/ void Update();
    /*0x5602c0*/ void FixedUpdate();
}

class Bullet_shulkLeaf_water : Bullet_shulkLeaf
{
    /*0x317730*/ Bullet_shulkLeaf_water();
    /*0x548150*/ void SetPenetrationTime();
    /*0x560b70*/ void HitZombie(Zombie zombie);
    /*0x560e50*/ void KeepHiting(Zombie zombie);

    class <>c__DisplayClass1_0
    {
        /*0x10*/ Bullet bullet;

        /*0x32f970*/ <>c__DisplayClass1_0();
        /*0x5689f0*/ void <HitZombie>b__0();
    }
}

class Bullet_silverButter : Bullet_butter
{
    /*0x317730*/ Bullet_silverButter();
    /*0x560f50*/ void HitLand();
    /*0x561150*/ void HitZombie(Zombie zombie);
}

class Bullet_silverCabbage : Bullet_cabbage
{
    /*0x108*/ bool miusa;

    /*0x317730*/ Bullet_silverCabbage();
    /*0x5615e0*/ void InitData();
    /*0x5614c0*/ void HitZombie(Zombie zombie);
    /*0x5613b0*/ void HitLand();
}

class Bullet_silverCoin : Bullet
{
    /*0x317730*/ Bullet_silverCoin();
    /*0x561710*/ void HitZombie(Zombie zombie);
    /*0x561600*/ void HitLand();
}

class Bullet_silverMelon : Bullet_melon
{
    /*0x317730*/ Bullet_silverMelon();
    /*0x5618b0*/ void HitLand();
    /*0x5619d0*/ void HitZombie(Zombie zombie);
}

class Bullet_smallButter : Bullet_butter
{
    /*0x317730*/ Bullet_smallButter();
    /*0x561b30*/ void HitZombie(Zombie zombie);
}

class Bullet_smallGoldCannon : Bullet
{
    /*0x317730*/ Bullet_smallGoldCannon();
    /*0x561f70*/ void InitData();
    /*0x561e10*/ void HitLand();
    /*0x561c80*/ void FixedUpdate();
}

class Bullet_smallSun : Bullet_pea
{
    /*0x100*/ UnityEngine.Animator Animator;

    /*0x317730*/ Bullet_smallSun();
    /*0x562010*/ void Awake();
    /*0x562690*/ void InitData();
    /*0x562090*/ void FixedUpdate();
    /*0x562520*/ void HitZombie(Zombie zombie);
    /*0x5623a0*/ void HitLand();
}

class Bullet_snowBall : Bullet
{
    /*0x317730*/ Bullet_snowBall();
    /*0x5626d0*/ void HitLand();
    /*0x562b60*/ void HitZombie(Zombie zombie);
    /*0x5627b0*/ void HitPlant(Plant p);
}

class Bullet_snowPea : Bullet_pea
{
    /*0x317730*/ Bullet_snowPea();
    /*0x562d50*/ void HitZombie(Zombie zombie);
    /*0x562c70*/ void HitLand();
}

class Bullet_springMelon : Bullet_fireMelon
{
    /*0x317730*/ Bullet_springMelon();
    /*0x5633c0*/ void HitLand();
    /*0x5634c0*/ void HitZombie(Zombie zombie);
    /*0x562e60*/ void ExtraDamage(Zombie originalZombie);
    /*0x5636d0*/ void RotateUpdate();
}

class Bullet_spruce : Bullet_pierce
{
    /*0x317730*/ Bullet_spruce();
    /*0x548150*/ void SetPenetrationTime();
    /*0x563d50*/ void HitZombie(Zombie zombie);
    /*0x563ca0*/ void HitBlock();
}

class Bullet_spruceBallista : Bullet_pierce
{
    /*0x317730*/ Bullet_spruceBallista();
    /*0x546650*/ void SetPenetrationTime();
    /*0x5638b0*/ void HitZombie(Zombie zombie);
    /*0x563830*/ void HitLand();
    /*0x563780*/ void HitBlock();
}

class Bullet_spruceShulk : Bullet_spruce
{
    /*0x100*/ UnityEngine.GameObject leaf;

    /*0x317730*/ Bullet_spruceShulk();
    /*0x563c50*/ void InitData();
    /*0x563980*/ void HitZombie(Zombie zombie);

    class <>c__DisplayClass2_0
    {
        /*0x10*/ Bullet bullet;

        /*0x32f970*/ <>c__DisplayClass2_0();
        /*0x568c10*/ void <HitZombie>b__0();
    }
}

class Bullet_spruce_bamboo : Bullet_spruce
{
    /*0x317730*/ Bullet_spruce_bamboo();
    /*0x563db0*/ void HitZombie(Zombie zombie);
}

class Bullet_squash : Bullet
{
    /*0x317730*/ Bullet_squash();
    /*0x564610*/ void InitData();
    /*0x564510*/ void HitZombie(Zombie zombie);
    /*0x564490*/ void HitLand();
    /*0x5646c0*/ void JumpLand();
    /*0x564280*/ void AttackZombie();
}

class Bullet_squashKelp : Bullet_squash
{
    /*0x317730*/ Bullet_squashKelp();
    /*0x5641a0*/ void HitZombie(Zombie zombie);
    /*0x564120*/ void HitLand();
    /*0x563ee0*/ void AttackZombie();
}

class Bullet_star : Bullet
{
    /*0x100*/ float accelerateTime;
    /*0x104*/ float angularSpeed;
    /*0x108*/ float angle;
    /*0x10c*/ bool movingToCircle;
    /*0x110*/ UnityEngine.Vector2 targetPosition;
    /*0x118*/ bool track;
    /*0x120*/ UnityEngine.Transform star;

    /*0x556dc0*/ Bullet_star();
    /*0x564d10*/ void InitData();
    /*0x564ef0*/ void Update();
    /*0x564c40*/ void HitZombie(Zombie zombie);
    /*0x564b30*/ void HitPlant(Plant plant);
    /*0x564a50*/ void HitLand();
    /*0x5646f0*/ Zombie GetNearestZombie();
    /*0x564e30*/ void MoveDieUpdate(UnityEngine.Vector2 currentPosition);
}

class Bullet_steelPea : Bullet_pierce
{
    /*0x317730*/ Bullet_steelPea();
    /*0x5651b0*/ void SetPenetrationTime();
    /*0x565060*/ void HitZombie(Zombie zombie);
    /*0x564f80*/ void HitLand();
}

class Bullet_sunCabbage : Bullet_pierce
{
    /*0x100*/ UnityEngine.Transform spriteObject;

    /*0x317730*/ Bullet_sunCabbage();
    /*0x554a10*/ void Awake();
    /*0x565430*/ void SetPenetrationTime();
    /*0x5651d0*/ void FixedUpdate();
    /*0x5652f0*/ void HitZombie(Zombie zombie);
    /*0x565230*/ void HitLand();
}

class Bullet_sunSpike : Bullet_iceSpark
{
    /*0x317730*/ Bullet_sunSpike();
    /*0x5654c0*/ void HitLand();
    /*0x5655a0*/ void HitZombie(Zombie zombie);
}

class Bullet_superCherry : Bullet
{
    /*0x317730*/ Bullet_superCherry();
    /*0x565b10*/ void HitZombie(Zombie zombie);
    /*0x565770*/ void HitLand();
    /*0x565880*/ void HitPlant(Plant plant);
}

class Bullet_superMelon : Bullet_melon
{
    /*0x108*/ int p;

    /*0x317730*/ Bullet_superMelon();
    /*0x565cd0*/ void HitLand();
    /*0x565e10*/ void HitZombie(Zombie zombie);
}

class Bullet_superStar : Bullet_star
{
    /*0x556dc0*/ Bullet_superStar();
    /*0x5665d0*/ void Update();
    /*0x566350*/ void TrackUpdate();
    /*0x564c40*/ void HitZombie(Zombie zombie);
    /*0x566220*/ void HitLand();
    /*0x566300*/ bool NearestZombieCondition(Zombie zombie);
}

class Bullet_sword : Bullet_pierce
{
    /*0x317730*/ Bullet_sword();
    /*0x55d980*/ void SetPenetrationTime();
    /*0x563d50*/ void HitZombie(Zombie zombie);
    /*0x566670*/ void HitLand();
}

class Bullet_threeSpike : Bullet
{
    /*0x317730*/ Bullet_threeSpike();
    /*0x566770*/ void HitZombie(Zombie zombie);
    /*0x5666f0*/ void HitLand();
}

class Bullet_ultimateCactus : Bullet_iceDoom
{
    /*0x317730*/ Bullet_ultimateCactus();
    /*0x554100*/ void SetPenetrationTime();
    /*0x5669b0*/ void HitZombie(Zombie zombie);
    /*0x5668e0*/ void HitLand();
    /*0x566b50*/ void SmallDoom(Zombie z);
    /*0x566d70*/ void TrySetMindControl(Zombie zombie, int damage);
}

class Bullet_ultimateKernal : Bullet
{
    /*0x317730*/ Bullet_ultimateKernal();
    /*0x567070*/ void HitZombie(Zombie zombie);
}

class Bullet_ultimateMelon : Bullet_superMelon
{
    /*0x317730*/ Bullet_ultimateMelon();
    /*0x5670f0*/ void HitLand();
    /*0x567210*/ void HitZombie(Zombie zombie);
}

class Bullet_ultimatePuff : Bullet_ultimateMelon
{
    /*0x317730*/ Bullet_ultimatePuff();
    /*0x567700*/ void HitLand();
    /*0x567800*/ void HitZombie(Zombie zombie);
}

class Bullet_ultimateStar : Bullet_star
{
    /*0x556dc0*/ Bullet_ultimateStar();
    /*0x568140*/ void InitData();
    /*0x5687c0*/ void Update();
    /*0x567c90*/ Zombie GetNearestZombie();
    /*0x5686a0*/ bool TryGetAirProjectile(ref AirProjectile airProjectile);
    /*0x568290*/ void TrackUpdate();
    /*0x567ef0*/ void HitZombie(Zombie zombie);
    /*0x567d10*/ void HitLand();
    /*0x568270*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class Bullet_ultimateSun : Bullet_pierce
{
    /*0x100*/ UnityEngine.Transform tail;

    /*0x546660*/ Bullet_ultimateSun();
    /*0x554a00*/ void SetPenetrationTime();
    /*0x569a60*/ void Explode(UnityEngine.Vector2 center, int damage, float range);
    /*0x569da0*/ void HitZombie(Zombie zombie);
    /*0x569c30*/ void HitLand();
    /*0x5559f0*/ void Awake();
    /*0x56a1f0*/ void Update();
}

class Bullet_water : Bullet_cabbage
{
    /*0x317730*/ Bullet_water();
    /*0x56a5d0*/ void HitZombie(Zombie zombie);
    /*0x56a4d0*/ void HitLand();
}

class Bullet_waterBallista : Bullet_spruceBallista
{
    /*0x546660*/ Bullet_waterBallista();
    /*0x56a3a0*/ void HitZombie(Zombie zombie);
}

class Bullet_waterBallista2 : Bullet_spruceBallista
{
    /*0x546660*/ Bullet_waterBallista2();
    /*0x56a2a0*/ void HitZombie(Zombie zombie);
}

class Bullet_watercan : Bullet
{
    /*0x317730*/ Bullet_watercan();
    /*0x56a980*/ void HitZombie(Zombie zombie);
    /*0x56a8d0*/ void HitLand();
    /*0x56aa90*/ bool SearchCan();

    class <>c
    {
        static /*0x0*/ Bullet_watercan.<> <>9;
        static /*0x8*/ System.Func<Tower_waterCan, int> <>9__2_0;

        static /*0x5822a0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x582280*/ int <SearchCan>b__2_0(Tower_waterCan can);
    }
}

class Bullet_water_big : Bullet
{
    /*0x317730*/ Bullet_water_big();
    /*0x56a7d0*/ void HitZombie(Zombie zombie);
    /*0x56a6d0*/ void HitLand();
}

class Bullet_winterMelon : Bullet_melon
{
    /*0x546660*/ Bullet_winterMelon();
    /*0x56afd0*/ void HitLand();
    /*0x56b0c0*/ void HitZombie(Zombie zombie);
}

class Bullet_zombieBlock : Bullet_nut
{
    /*0x546660*/ Bullet_zombieBlock();
    /*0x56b3e0*/ void HitZombie(Zombie zombie);
    /*0x56b300*/ void HitLand();
}

class Bullet_zombieBlock2 : Bullet_zombieBlock
{
    /*0x546660*/ Bullet_zombieBlock2();
    /*0x56b220*/ void HitZombie(Zombie zombie);
}

class BaseMoveWay : UnityEngine.MonoBehaviour
{
    /*0x20*/ Bullet bullet;
    /*0x28*/ BulletMoveWay theMoveWay;
    /*0x30*/ UnityEngine.Transform shadow;

    /*0x31c640*/ BaseMoveWay();
    /*0x32d010*/ void PositionUpdate();
    /*0x32d010*/ void ShadowUpdate();
    /*0x5699e0*/ void Update();
    /*0x5699c0*/ void FixedUpdate();
}

class MoveWay_jump : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ MoveWay_jump();
}

class AlmanacCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theSeedType;
    /*0x24*/ bool isBasicCard;
    /*0x28*/ UnityEngine.SpriteRenderer thePlantSprite;
    /*0x30*/ UnityEngine.SpriteRenderer back;
    /*0x38*/ TMPro.TextMeshPro textMesh;

    static /*0x568d00*/ AlmanacCard CreateAlmanacCard(UnityEngine.Transform parent, PlantType thePlantType);
    /*0x31c640*/ AlmanacCard();
    /*0x569800*/ void Start();
    /*0x5698c0*/ void Update();
    /*0x568e70*/ void OnMouseDown();
    /*0x5690e0*/ void OnMouseEnter();
    /*0x5691c0*/ void OnMouseExit();
    /*0x5692a0*/ void SetSprite(UnityEngine.Sprite sprite, float minX, float maxX, float minY, float maxY);
    /*0x569560*/ void SetTheSprite(PlantType thePlantType);
}

class Card : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool dontdestory;

    /*0x31c640*/ Card();
    /*0x56da40*/ void Start();
}

class CardUI : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theSeedType;
    /*0x24*/ int theSeedCost;
    /*0x28*/ bool isSelected;
    /*0x2c*/ int theNumberInCardSort;
    /*0x30*/ int thePlantLevel;
    /*0x38*/ UnityEngine.GameObject parent;
    /*0x40*/ bool isAvailable;
    /*0x44*/ float CD;
    /*0x48*/ float fullCD;
    /*0x4c*/ int usedTimes;
    /*0x50*/ bool preSelected;
    /*0x51*/ bool safe;
    /*0x52*/ bool fromSystem;
    /*0x53*/ bool isPickUp;
    /*0x54*/ bool isExtra;
    /*0x55*/ bool disabled;
    /*0x56*/ bool onCardBank;
    /*0x58*/ UnityEngine.UI.Slider slider;
    /*0x60*/ TMPro.TextMeshProUGUI text;
    /*0x68*/ TMPro.TextMeshProUGUI textBg;
    /*0x70*/ PlantType thePlantType;
    /*0x74*/ ZombieType theZombieType;
    /*0x78*/ System.Collections.Generic.List<UnityEngine.Sprite> sprites;
    /*0x80*/ System.Action<Plant> plantAction;
    /*0x88*/ Plant p_plant;
    /*0x90*/ CardUI p_card;
    /*0x98*/ Board board;
    /*0xa0*/ TreasureCardData data;
    /*0xa8*/ bool once;
    /*0xac*/ int Durability;
    /*0xb0*/ int MaxDurability;

    /*0x56d9a0*/ CardUI();
    /*0x56b4a0*/ void Awake();
    /*0x56d240*/ void Start();
    /*0x56c7f0*/ void MushroomExtraCost(int value);
    /*0x56be50*/ void LevelLim();
    /*0x56d5e0*/ void Update();
    /*0x56b930*/ void CDUpdate();
    /*0x56d030*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
    /*0x56c8a0*/ void OnMouseDown();
    /*0x56d0c0*/ bool PickUp();
    /*0x56d120*/ void PutDown();
    /*0x56d230*/ void SetLevel(int index);
    /*0x56d180*/ void SetImage(int index);
    /*0x56bdf0*/ void Die();
    /*0x56bba0*/ void ChangeCardSprite();
    /*0x56d8d0*/ void UseOnce();
}

class DroppedCard : CardUI
{
    static float gravity = 9.800000190734863;
    /*0xb8*/ UnityEngine.Vector2 velocity;
    /*0xc0*/ UnityEngine.Vector2 startPosition;
    /*0xc8*/ float minY;
    /*0xcc*/ bool isLand;
    /*0xd0*/ int movingWay;
    /*0xd4*/ float existTime;
    /*0xd8*/ float flashTime;
    /*0xdc*/ bool flashing;
    /*0xe0*/ UnityEngine.UI.Image image1;
    /*0xe8*/ UnityEngine.UI.Image image2;
    /*0xf0*/ bool fallByBoss;

    /*0x57f520*/ DroppedCard();
    /*0x57e110*/ void Awake();
    /*0x57ee40*/ void Start();
    /*0x57e2d0*/ void Fall();
    /*0x57eea0*/ void Update();
    /*0x57eb60*/ void PositionUpdate();
    /*0x57ea70*/ void PositionUpdate2();
    /*0x57e350*/ void OnMouseDown();
    /*0x57e530*/ bool PickUp();
}

class DroppedTreasureCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x28*/ UnityEngine.RectTransform shadow;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.Sprite> sprites;
    /*0x38*/ UnityEngine.UI.Image image;
    /*0x40*/ bool active;
    /*0x44*/ float timer;
    /*0x48*/ float maxTimer;
    /*0x50*/ UnityEngine.Collider2D col;

    /*0x57fd40*/ DroppedTreasureCard();
    /*0x57f530*/ void Awake();
    /*0x57f820*/ void Start();
    /*0x57f7d0*/ void Clicked();
    /*0x57f930*/ void Update();
    /*0x57f580*/ void ChangeSprites();
    /*0x57f800*/ void OnMouseEnter();
    /*0x57f810*/ void OnMouseExit();
}

class GardenCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ Garden garden;
    /*0x28*/ TreasureCardData data;
    /*0x30*/ UnityEngine.UI.Image image;
    /*0x38*/ UnityEngine.GameObject shadow;
    /*0x40*/ TMPro.TextMeshProUGUI text;

    /*0x31c640*/ GardenCard();
    /*0x57fff0*/ void OnMouseEnter();
    /*0x580070*/ void OnMouseExit();
    /*0x5800f0*/ void Start();
    /*0x57fdd0*/ void ChangeCardSprite();
}

class IZECard : CardUI
{
    /*0xb8*/ UnityEngine.Rendering.SortingGroup z_sortingGroup;

    /*0x57f520*/ IZECard();
    /*0x580220*/ void Awake();
    /*0x580b50*/ void UpdateSprite();
    /*0x580960*/ void Start();
    /*0x580ea0*/ void Update();
    /*0x580410*/ void IZSettings();
}

class PresentCard : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ PresentCard();
    /*0x581330*/ void Start();
}

class SpecialCard : CardUI
{
    static /*0x0*/ System.Collections.Generic.Dictionary<FunctionCardType, string> CardPath;
    /*0xb8*/ FunctionCardType theCardType;
    /*0xbc*/ float d;

    static /*0x581ea0*/ SpecialCard();
    static /*0x581bb0*/ SpecialCard GetExtract_card(FunctionCardType functionCardType);
    /*0x582010*/ SpecialCard();
    /*0x581450*/ void Awake();
    /*0x581dc0*/ void Start();
    /*0x5814b0*/ void CDUpdate();
    /*0x5814d0*/ void ClickedEvent();
}

enum FunctionCardType
{
    Default = 0,
    Extract_single = 1,
    Extract_ten = 2,
    BuyStep = 3,
    PlayerExtractBuff = 4,
    PlayerUpgrade = 5,
}

class TravelStartCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;

    /*0x31c640*/ TravelStartCard();
    /*0x582030*/ void Init();
}

class CheckAdv : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theLevel;
    /*0x24*/ bool travel;

    /*0x31c640*/ CheckAdv();
    /*0x56de30*/ void Start();
}

class CoinSun : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theMoveType;
    /*0x24*/ int theCoinType;
    /*0x28*/ int sunPrice;
    /*0x2c*/ bool save;
    /*0x30*/ int followValue;
    /*0x38*/ System.Action<int> action;
    /*0x40*/ UnityEngine.Transform target;
    /*0x48*/ bool isLand;
    /*0x4c*/ UnityEngine.Vector2 velocity;
    /*0x54*/ UnityEngine.Vector2 startPosition;

    /*0x56ede0*/ CoinSun();
    /*0x56dfa0*/ void Awake();
    /*0x56e760*/ void SetTarget();
    /*0x56e8d0*/ void Start();
    /*0x56ed70*/ void Update();
    /*0x56e470*/ void PositionUpdate();
    /*0x56e010*/ void MoveToPosition();
    /*0x56dfb0*/ void Die();
    /*0x56e660*/ void SetCost();
}

class LanternUmbrellaEffect : UnityEngine.MonoBehaviour
{
    /*0x20*/ LanternUmbrella plant;

    /*0x31c640*/ LanternUmbrellaEffect();
    /*0x5812a0*/ void Update();
    /*0x581120*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class CreateBullet : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CreateBullet Instance;

    /*0x31c640*/ CreateBullet();
    /*0x56f060*/ void Awake();
    /*0x56f2d0*/ Bullet SetBullet(float x, float y, int theRow, BulletType theBulletType, int theMovingWay, bool isZombieBullet);
    /*0x56f0c0*/ Bullet SetBullet(float x, float y, int theRow, BulletType theBulletType, BulletMoveWay theMovingWay, bool isZombieBullet);
    /*0x56ee00*/ void AddToList(Bullet bullet);
    /*0x56f4f0*/ void SetLayer(Bullet bullet, int theRow);
}

enum SunType
{
    NormalSun = 0,
    BigSun = 1,
    SmallSun = 2,
    LittleSun = 13,
    BlueSun = 53,
    SmallBlueSun = 54,
}

class CreateItem : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CreateItem Instance;

    static /*0x56fe90*/ MoneyInGarden SetMoney(UnityEngine.Vector2 position, ItemType theItemType, UnityEngine.Transform transform, float scale);
    /*0x31c640*/ CreateItem();
    /*0x56f6b0*/ void Awake();
    /*0x56f730*/ UnityEngine.GameObject SetCoin(int theColumn, int theRow, int theItemType, int theMoveType, UnityEngine.Vector3 pos, bool freeSet);
    /*0x56f710*/ bool LimSet(int theCoinType);
    /*0x56fbd0*/ void SetLayer(UnityEngine.GameObject coin);
}

class CreateMower
{
    static /*0x0*/ CreateMower _instance;
    /*0x10*/ System.Collections.Generic.Dictionary<MowerType, string> PathDic;

    static /*0x5707e0*/ CreateMower();
    static /*0x570af0*/ CreateMower get_Instance();
    /*0x570990*/ CreateMower();
    /*0x570480*/ void SetMowers(BoxType[] roadtype);
    /*0x5700a0*/ void SetMowerOnRoad(BoxType rowtype, int row);
    /*0x570110*/ Mower SetMower(MowerType mowerType, float x, int row);
    /*0x5705a0*/ void SetTransform(Mower theMower, int theRow);
}

class CreateParticle : UnityEngine.MonoBehaviour
{
    static /*0x570ea0*/ UnityEngine.GameObject SetParticle(int theParticleType, UnityEngine.Vector3 position, int row, bool setLayer);
    static /*0x570b40*/ void SetLayer(UnityEngine.GameObject obj, int row);
    /*0x31c640*/ CreateParticle();
}

class CreatePlant : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CreatePlant Instance;
    /*0x20*/ Board board;
    /*0x28*/ UnityEngine.LayerMask bulletLayer;

    static /*0x57a700*/ UnityEngine.GameObject SetPlantInGarden(int column, int row, PlantType theSeedType, UnityEngine.Transform parent, bool preview, bool inGarden, bool inWorld);
    static /*0x574f40*/ void DestoryParticle(UnityEngine.GameObject obj);
    static /*0x574600*/ UnityEngine.GameObject CreatePlantPreview(PlantType theSeedType, UnityEngine.Color color, UnityEngine.Transform parent, UnityEngine.Vector2 position);
    static /*0x57a410*/ UnityEngine.GameObject SetPlantInAlmamac(UnityEngine.Vector3 position, int theSeedType);
    /*0x31c640*/ CreatePlant();
    /*0x571330*/ void Awake();
    /*0x579920*/ void SetGhostPlant(int theColumn, int theRow, PlantType thePlantType);
    /*0x57b4f0*/ UnityEngine.GameObject SetPlant(int newColumn, int newRow, PlantType theSeedType, Plant targetPlant, UnityEngine.Vector2 puffV, bool isFreeSet, bool withEffect, Plant hitplant);
    /*0x574560*/ void CreatePlantParticle(int column, int row, UnityEngine.Vector3 position);
    /*0x5711d0*/ void AdjustLightLevel(int boxX, int boxY, int level, int range);
    /*0x571040*/ void AddToList(Plant plant);
    /*0x5713b0*/ bool CheckBox(int theBoxColumn, int theBoxRow, PlantType theSeedType);
    /*0x575040*/ bool DoubleBoxCheck(int theColumn, int theRow, PlantType theCurrentPlantType);
    /*0x575140*/ Plant[] FindNeedPlants(int theColumn, int theRow, PlantType needTheSeedType, PlantType theCurrentPlantType);
    /*0x578d70*/ bool PotCheck(int theColumn, int theRow);
    /*0x5725c0*/ bool CheckFlying(int theBoxColumn, int theBoxRow);
    /*0x578cf0*/ bool OnHardLand(PlantType theSeedType);
    /*0x574240*/ bool CheckPuff(int theColumn, int theRow);
    /*0x572780*/ UnityEngine.GameObject CheckMix(int theColumn, int theRow, PlantType theUsedType);
    /*0x577d20*/ bool MixFail(int theBoxColumn, int theBoxRow, PlantType newPlantType);
    /*0x57d930*/ UnityEngine.GameObject SpreadPuff(int theColumn, int theRow, PlantType theUsedType);
    /*0x579320*/ UnityEngine.GameObject PuffToScaredy(int column, int row, int puffNum);
    /*0x579090*/ UnityEngine.GameObject PuffToFume(int column, int row, int puffNum);
    /*0x579550*/ bool PumpkinCheck(int theBoxColumn, int theBoxRow);
    /*0x578e50*/ bool PresentCheck(int theBoxColumn, int theBoxRow);
    /*0x5778c0*/ bool MixBombCheck(int theBoxColumn, int theBoxRow);
    /*0x579f30*/ void SetLayer(Plant plant, int theColumn, int theRow);
    /*0x57a350*/ void SetPlantAttributes(Plant plant);
    /*0x57d550*/ void SetTransform(UnityEngine.GameObject plant, UnityEngine.Vector3 position);
    /*0x57d0e0*/ void SetPuffTransform(UnityEngine.GameObject plant);
    /*0x57ccc0*/ void SetPuffLayer(UnityEngine.GameObject plant, bool isLower, int theRow);
    /*0x577170*/ bool Lim(PlantType theSeedType);
    /*0x5761c0*/ bool LimTravel(PlantType theSeedType);
    /*0x577ad0*/ void MixEvent(PlantType theSeedType, UnityEngine.GameObject plant, int theRow);
    /*0x57dd10*/ void UniqueEvent(PlantType theSeedType, Plant plant, int theRow);
    /*0x576170*/ bool IsPuff(PlantType theSeedType);
    /*0x576130*/ bool InTheSameBox(Plant p1, Plant p2);

    class <>c
    {
        static /*0x0*/ CreatePlant.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.SpriteRenderer, int> <>9__6_0;
        static /*0x10*/ System.Func<UnityEngine.SpriteRenderer, int> <>9__8_0;
        static /*0x18*/ System.Func<Plant, int> <>9__20_0;
        static /*0x20*/ System.Func<Plant, int> <>9__20_1;
        static /*0x28*/ System.Predicate<Plant> <>9__21_0;
        static /*0x30*/ System.Func<Plant, bool> <>9__21_1;
        static /*0x38*/ System.Predicate<Plant> <>9__21_2;
        static /*0x40*/ System.Func<Plant, bool> <>9__21_3;
        static /*0x48*/ System.Predicate<Plant> <>9__21_4;
        static /*0x50*/ System.Predicate<Plant> <>9__21_5;

        static /*0x595b20*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5956c0*/ int <CreatePlantPreview>b__6_0(UnityEngine.SpriteRenderer p);
        /*0x5956c0*/ int <SetGhostPlant>b__8_0(UnityEngine.SpriteRenderer p);
        /*0x5955e0*/ int <CheckMix>b__20_0(Plant p);
        /*0x595650*/ int <CheckMix>b__20_1(Plant p);
        /*0x595760*/ bool <MixFail>b__21_0(Plant p);
        /*0x595790*/ bool <MixFail>b__21_1(Plant p);
        /*0x5957c0*/ bool <MixFail>b__21_2(Plant p);
        /*0x5957f0*/ bool <MixFail>b__21_3(Plant p);
        /*0x595830*/ bool <MixFail>b__21_4(Plant p);
        /*0x595860*/ bool <MixFail>b__21_5(Plant p);
    }

    class <>c__DisplayClass9_0
    {
        /*0x10*/ Plant p;

        /*0x32f970*/ <>c__DisplayClass9_0();
        /*0x5959a0*/ bool <SetPlant>b__0(Plant n);
    }
}

class CreateZombie : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CreateZombie Instance;
    static /*0x8*/ System.Collections.Generic.Dictionary<ZombieType, ZombieType> DuckZombies;
    /*0x20*/ Board board;

    static /*0x587d30*/ CreateZombie();
    static /*0x586500*/ UnityEngine.GameObject SetZombieInAlmanac(UnityEngine.Vector3 position, ZombieType theZombieType);
    static /*0x5853c0*/ UnityEngine.GameObject CreateZombiePreview(ZombieType theZombieType, UnityEngine.Color color, UnityEngine.Transform parent, UnityEngine.Vector2 position);
    static /*0x585c90*/ ZombieType GetDuckZombie(ZombieType zombieType);
    /*0x31c640*/ CreateZombie();
    /*0x585320*/ void Awake();
    /*0x5873e0*/ UnityEngine.GameObject SetZombie(int theRow, ZombieType theZombieType, float theX, bool isIdle);
    /*0x586e50*/ UnityEngine.GameObject SetZombieWithMindControl(int theRow, ZombieType theZombieType, float theX, bool withEffect);
    /*0x585fb0*/ void SetLayer(int theRow, Zombie zombie);
    /*0x5861a0*/ void SetTransform(UnityEngine.GameObject zombie, UnityEngine.Vector3 position);
    /*0x585170*/ void AddToList(Zombie zombie);
    /*0x585d30*/ void GetZombieData(Zombie zombie, ZombieType theZombieType);

    class <>c
    {
        static /*0x0*/ CreateZombie.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.SpriteRenderer, int> <>9__4_0;

        static /*0x595ab0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5956c0*/ int <CreateZombiePreview>b__4_0(UnityEngine.SpriteRenderer p);
    }
}

class EndlessShooting : UnityEngine.MonoBehaviour
{
    static /*0x0*/ EndlessShooting Instance;
    /*0x20*/ System.Collections.Generic.List<PlantType> cardOnBank;

    /*0x588770*/ EndlessShooting();
    /*0x588270*/ void Awake();
    /*0x588690*/ void SetCard(int level);
    /*0x5883d0*/ void GetCards();
}

class Entity : UnityEngine.MonoBehaviour
{
    /*0x20*/ Team team;
    /*0x28*/ UnityEngine.Animator anim;
    /*0x30*/ Board board;
    /*0x38*/ UnityEngine.Transform axis;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;

    /*0x588ca0*/ Entity();
    /*0x5887f0*/ void Awake();
    /*0x588ba0*/ void SetPosition(UnityEngine.Vector3 targetPosition);
    /*0x5889c0*/ void GetSpriteRenderers();
}

enum CherryBombType
{
    Normal = 0,
    Sun = 1,
    Bullet = 2,
    IceCharry = 3,
    Custom = 4,
    BulletAll = 5,
}

class BombCherry : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool isFromZombie;
    /*0x24*/ CherryBombType bombType;
    /*0x28*/ int bombRow;
    /*0x30*/ UnityEngine.GameObject targetPlant;
    /*0x38*/ Plant target;
    /*0x40*/ Board board;
    /*0x48*/ int maxRow;
    /*0x4c*/ float range;
    /*0x50*/ int explodeDamage;
    /*0x54*/ int killCount;
    /*0x58*/ System.Action<Zombie> zombieAction;

    /*0x583710*/ BombCherry();
    /*0x582310*/ void Awake();
    /*0x583020*/ void Start();
    /*0x5823f0*/ void Explode(UnityEngine.Vector2 explosionPosition, float explosionRadius);
    /*0x5831b0*/ void ZombieExplode(UnityEngine.Vector2 explosionPosition, float explosionRadius);
    /*0x582ad0*/ void PlantTakeDamage(Plant plant);
    /*0x582360*/ bool CherryPumpkin(Plant plant);
}

class Doom : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<DoomType, string> dic;
    /*0x20*/ UnityEngine.GameObject sprit;

    static /*0x5881b0*/ Doom();
    static /*0x587e80*/ Doom SetDoom(Board board, UnityEngine.Vector2 position, DoomType doomType, System.Action action);
    /*0x31c640*/ Doom();
    /*0x5880f0*/ void Start();
    /*0x587e20*/ void Die();
}

enum DoomType
{
    Fire = 0,
}

class IceExplodeEvent : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ IceExplodeEvent();
}

class KirovBomb : UnityEngine.MonoBehaviour
{
    /*0x20*/ float existTime;
    /*0x24*/ bool explode;
    /*0x28*/ int bombRow;
    /*0x2c*/ int bombDamage;
    /*0x30*/ bool fromHypno;
    /*0x34*/ Plant.DamageType damageType;

    /*0x593510*/ KirovBomb();
    /*0x593400*/ void Update();
    /*0x592d00*/ void Explode();
}

class Bucket : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<System.ValueTuple<PlantType, BucketType>, PlantType> Recipes;
    /*0x20*/ bool isLand;
    /*0x21*/ bool disappear;
    /*0x24*/ BucketType theBucketType;
    /*0x28*/ Mouse m;
    /*0x30*/ float existTime;
    /*0x34*/ float gravity;
    /*0x38*/ UnityEngine.Vector2 velocity;
    /*0x40*/ UnityEngine.Vector2 startPosition;
    /*0x48*/ bool isFlash;
    /*0x4c*/ float verticalSpeed;
    /*0x50*/ Magnetshroom magnetShroom;

    static /*0x584890*/ Bucket();
    /*0x584eb0*/ Bucket();
    /*0x584040*/ void Start();
    /*0x583fb0*/ void PutDown();
    /*0x584560*/ void Update();
    /*0x583730*/ void Die();
    /*0x583bb0*/ System.Collections.IEnumerator Flash();
    /*0x583d40*/ void PositionUpdate();
    /*0x583c20*/ void Pick();
    /*0x5846e0*/ void Use();

    class <Flash>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Bucket <>4__this;
        /*0x28*/ UnityEngine.Color <color>5__2;
        /*0x38*/ bool <decrease>5__3;

        /*0x32f460*/ <Flash>d__15(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5945e0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x594890*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Helmet : Bucket
{
    /*0x58ca00*/ Helmet();
    /*0x58c700*/ void Use();
}

class FloatPlants : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ FloatPlants();
}

class FloorMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theFloorRow;

    /*0x31c640*/ FloorMgr();
    /*0x588d20*/ void Start();
}

class FogBlock : UnityEngine.MonoBehaviour
{
    /*0x20*/ int fogColumn;
    /*0x24*/ int fogRow;
    /*0x28*/ bool isOver;
    /*0x29*/ bool fading;
    /*0x30*/ UnityEngine.SpriteRenderer spriteRenderer;
    /*0x38*/ UnityEngine.Color color1;
    /*0x48*/ UnityEngine.Color color2;
    /*0x58*/ float lerpT;
    /*0x5c*/ float currentA;
    /*0x60*/ float lerpTime;

    /*0x589210*/ FogBlock();
    /*0x588dc0*/ void Awake();
    /*0x588e70*/ void SetLayer();
    /*0x588e70*/ void Start();
    /*0x588ee0*/ void Update();
}

class FogMgr : UnityEngine.MonoBehaviour
{
    static float appearSpeed = 1;
    static float moveSpeed = 10;
    static float fadeSpeed = 20;
    static /*0x0*/ FogMgr Instance;
    /*0x20*/ System.Collections.Generic.List<FogBlock> fogList;
    /*0x28*/ float appearTime;
    /*0x30*/ UnityEngine.Coroutine coroutine1;
    /*0x38*/ UnityEngine.Coroutine coroutine2;
    /*0x40*/ UnityEngine.Coroutine coroutine3;

    /*0x58a1a0*/ FogMgr();
    /*0x5892e0*/ void Awake();
    /*0x5895d0*/ void FixedUpdate();
    /*0x58a010*/ void Update();
    /*0x589b30*/ void Light();
    /*0x589a50*/ bool InTorchRange(Plant p, FogBlock fog);
    /*0x5898c0*/ bool InLanternRange(Plant p, FogBlock fog);
    /*0x5895e0*/ void GetFog(UnityEngine.GameObject obj);
    /*0x589230*/ void AppearFog(UnityEngine.Vector3 pos);
    /*0x589ec0*/ void MoveFog(UnityEngine.Vector3 pos);
    /*0x589350*/ void Blown();
    /*0x5894f0*/ void FadeFog(UnityEngine.Vector3 pos);
    /*0x589f70*/ System.Collections.IEnumerator MoveObject(UnityEngine.Vector3 endPos, float speed);
    /*0x589470*/ float EaseInOut(float t);

    class <MoveObject>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ FogMgr <>4__this;
        /*0x28*/ UnityEngine.Vector3 endPos;
        /*0x34*/ float speed;
        /*0x38*/ UnityEngine.Vector3 <startPos>5__2;
        /*0x44*/ float <moveTime>5__3;
        /*0x48*/ float <elapsedTime>5__4;

        /*0x32f460*/ <MoveObject>d__20(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5952a0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5955a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class GameLose : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ GameLose();
    /*0x58a220*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class Crater : GridItem
{
    /*0x48*/ float existTime;
    /*0x50*/ UnityEngine.Sprite crater_fading;
    /*0x58*/ UnityEngine.Sprite crater;
    /*0x60*/ UnityEngine.SpriteRenderer r;

    /*0x31c640*/ Crater();
    /*0x584fe0*/ void Start();
    /*0x5850a0*/ void Update();
    /*0x584ed0*/ void CraterUpdate();
    /*0x584f80*/ void DieEvent();
}

class Grave : GridItem
{
    /*0x48*/ GraveType graveType;
    /*0x4c*/ float health;
    /*0x50*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> r;
    /*0x58*/ FlashModule flashModule;
    /*0x60*/ bool dying;

    /*0x58b480*/ Grave();
    /*0x58ae00*/ void Start();
    /*0x58a9e0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x58b410*/ void TakeDamage(int value);
    /*0x58a480*/ void Die();
    /*0x58a8f0*/ void FixedUpdate();
    /*0x58ab10*/ void SetZombie();
    /*0x58a970*/ System.Collections.IEnumerator MoveAndSummonZombie();
    /*0x58a420*/ void DieEvent();

    class <>c
    {
        static /*0x0*/ Grave.<> <>9;
        static /*0x8*/ System.Predicate<UnityEngine.SpriteRenderer> <>9__5_0;
        static /*0x10*/ System.Predicate<UnityEngine.SpriteRenderer> <>9__5_1;

        static /*0x595b90*/ <>c();
        /*0x32f970*/ <>c();
        /*0x595880*/ bool <Start>b__5_0(UnityEngine.SpriteRenderer r);
        /*0x5958e0*/ bool <Start>b__5_1(UnityEngine.SpriteRenderer r);
    }

    class <MoveAndSummonZombie>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Grave <>4__this;
        /*0x28*/ ZombieType <zombieType>5__2;
        /*0x30*/ UnityEngine.GameObject <zombie>5__3;
        /*0x38*/ float <y>5__4;

        /*0x32f460*/ <MoveAndSummonZombie>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5948d0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x595260*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

enum GraveType
{
    Default = 0,
    Sunflower = 1,
    Sunshroom = 2,
}

class GridItem : UnityEngine.MonoBehaviour
{
    /*0x20*/ GridItemType theItemType;
    /*0x24*/ int theItemRow;
    /*0x28*/ int theItemColumn;
    /*0x30*/ Board board;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> _r;
    /*0x40*/ float lightCountDown;

    static /*0x58b9f0*/ GridItem SetGridItem(int theColumn, int theRow, GridItemType theType, GraveType graveType);
    static /*0x58c290*/ void SetLayer(GridItem gridItem, int theRow, GridItemType type, int theColumn);
    static /*0x58b490*/ void AddToList(Board board, GridItem item);
    /*0x31c640*/ GridItem();
    /*0x58c4f0*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> get_R();
    /*0x58b760*/ void FlashUpdate();
    /*0x58b800*/ void Flash(float b);
    /*0x58b600*/ void Die();
    /*0x32d010*/ void DieEvent();

    class <>c__DisplayClass12_0
    {
        /*0x10*/ GraveType graveType;

        /*0x32f970*/ <>c__DisplayClass12_0();
        /*0x595940*/ bool <SetGridItem>b__0(UnityEngine.GameObject grave);
    }
}

enum GridItemType
{
    CraterDay = 0,
    CraterNight = 1,
    Ladder = 3,
    ScaryPot = 4,
    ScaryPot_plant = 5,
    ScaryPot_zombie = 6,
    Grave = 7,
    IceBlock = 8,
}

class GridLadder : GridItem
{
    /*0x48*/ bool red;

    /*0x31c640*/ GridLadder();
}

class Lava : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ int theColumn;
    /*0x2c*/ int theRow;
    /*0x30*/ float timer;
    /*0x34*/ UnityEngine.LayerMask zombieLayer;

    /*0x593bc0*/ Lava();
    /*0x593530*/ void Awake();
    /*0x593650*/ void Update();

    class <>c
    {
        static /*0x0*/ Lava.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__6_0;
        static /*0x10*/ System.Predicate<Plant> <>9__6_1;

        static /*0x595a40*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ba680*/ bool <Update>b__6_0(Plant p);
        /*0x4acd40*/ bool <Update>b__6_1(Plant p);
    }
}

class ScaryPot : GridItem
{
    /*0x48*/ PlantType thePlantType;
    /*0x4c*/ ZombieType theZombieType;

    /*0x5943d0*/ ScaryPot();
    /*0x593bd0*/ void Hitted();
    /*0x593de0*/ void OnHitted();
}

class TreasurePoint : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theColumn;
    /*0x24*/ int theRow;

    /*0x31c640*/ TreasurePoint();
}

class IceRoad : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theRow;
    /*0x28*/ UnityEngine.LineRenderer r;
    /*0x30*/ float x;
    /*0x34*/ float roadStartX;
    /*0x38*/ float fadeTimer;
    /*0x3c*/ bool active;

    /*0x58cd10*/ IceRoad();
    /*0x58cba0*/ void Update();
    /*0x58ca60*/ void PositionUpdate();
}

class InGameText : UnityEngine.MonoBehaviour
{
    static /*0x0*/ InGameText _instance;
    /*0x20*/ bool used;
    /*0x24*/ float timer;
    /*0x28*/ UnityEngine.GameObject textHead;
    /*0x30*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> textMeshes;

    static /*0x58d0b0*/ InGameText get_Instance();
    /*0x58d030*/ InGameText();
    /*0x58cda0*/ void OnDestroy();
    /*0x58cfc0*/ void Update();
    /*0x58cf80*/ void TimeOver();
    /*0x58cdf0*/ void ShowText(string text, float time, bool cover);
    /*0x58cd20*/ void DebugWarning(string text);
}

class InitBoard : UnityEngine.MonoBehaviour
{
    static /*0x0*/ InitBoard Instance;
    /*0x20*/ Board board;
    /*0x28*/ bool lookingLawn;
    /*0x29*/ bool moving;
    /*0x2c*/ UnityEngine.Vector2 cameraPosition;

    /*0x31c640*/ InitBoard();
    /*0x58e3c0*/ void Awake();
    /*0x591070*/ void QuickInGame();
    /*0x592870*/ void StartInit();
    /*0x58e500*/ void ContinueLevel();
    /*0x58e500*/ void RightMoveCamera();
    /*0x58f3a0*/ void LeftMoveCamera();
    /*0x58f870*/ System.Collections.IEnumerator MoveObject(UnityEngine.Vector3 endPos, float speed, string direction, UnityEngine.GameObject obj);
    /*0x58f940*/ void MoveOverEvent(string direction);
    /*0x58ea70*/ void InitMower();
    /*0x58e960*/ System.Collections.IEnumerator DecreaseVolume();
    /*0x591ff0*/ void ReadySetPlant();
    /*0x58f800*/ System.Collections.IEnumerator MoveMowers(UnityEngine.GameObject mower);
    /*0x381ef0*/ float EaseInOut(float t);
    /*0x58e4e0*/ bool CheckIfOptionalCard();
    /*0x58ecb0*/ void InitSelectUI();
    /*0x58ffc0*/ void PreSelectCard();
    /*0x590d60*/ CardUI PreSelect(PlantType theSeedType);
    /*0x58f770*/ System.Collections.IEnumerator MoveDirection(UnityEngine.GameObject obj, float distance, int direction);
    /*0x592750*/ void ShowUI();
    /*0x592150*/ void RemoveUI();
    /*0x58f520*/ void LookLawn();
    /*0x58f6b0*/ System.Collections.IEnumerator LookTheLawn(UnityEngine.Vector3 target, UnityEngine.GameObject obj, float moveSpeed);
    /*0x58e9b0*/ System.Collections.IEnumerator DisLookTheLawn(UnityEngine.Vector3 target, UnityEngine.GameObject obj, float moveSpeed);
    /*0x592b90*/ void Update();
    /*0x58ed40*/ void InitZombieFromList();
    /*0x592460*/ void ResetLayer(UnityEngine.GameObject obj, int baseLayer);
    /*0x58d220*/ void AddCard();
    /*0x58e860*/ CardUI CreateCard(PlantType theSeedType, bool shadow);
    /*0x58e6d0*/ CardUI CreateCard(FunctionCardType functionCardType);
    /*0x58e760*/ IZECard CreateCard(ZombieType theSeedType, bool shadow);

    class <>c
    {
        static /*0x0*/ InitBoard.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.GameObject, float> <>9__29_0;

        static /*0x5959d0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5956e0*/ float <InitZombieFromList>b__29_0(UnityEngine.GameObject z);
    }

    class <DecreaseVolume>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;

        /*0x32f460*/ <DecreaseVolume>d__14(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5943e0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5945a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <DisLookTheLawn>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.Vector3 target;
        /*0x30*/ UnityEngine.GameObject obj;
        /*0x38*/ float moveSpeed;
        /*0x40*/ InitBoard <>4__this;

        /*0x32f460*/ <DisLookTheLawn>d__27(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a8010*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a83c0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <LookTheLawn>d__26 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ InitBoard <>4__this;
        /*0x28*/ UnityEngine.Vector3 target;
        /*0x38*/ UnityEngine.GameObject obj;
        /*0x40*/ float moveSpeed;

        /*0x32f460*/ <LookTheLawn>d__26(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a8600*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a8990*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveDirection>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ float distance;
        /*0x28*/ UnityEngine.GameObject obj;
        /*0x30*/ int direction;
        /*0x34*/ float <duration>5__2;
        /*0x38*/ UnityEngine.Vector3 <endPosition>5__3;
        /*0x44*/ UnityEngine.Vector3 <startPosition>5__4;
        /*0x50*/ float <elapsedTime>5__5;

        /*0x32f460*/ <MoveDirection>d__22(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a89d0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a8ce0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveMowers>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.GameObject mower;

        /*0x32f460*/ <MoveMowers>d__16(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a8d20*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a8ec0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveObject>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.GameObject obj;
        /*0x28*/ UnityEngine.Vector3 endPos;
        /*0x34*/ float speed;
        /*0x38*/ InitBoard <>4__this;
        /*0x40*/ string direction;
        /*0x48*/ UnityEngine.Vector3 <startPos>5__2;
        /*0x54*/ float <moveTime>5__3;
        /*0x58*/ float <elapsedTime>5__4;
        /*0x60*/ UnityEngine.GameObject <levelText>5__5;
        /*0x68*/ UnityEngine.Color <col1>5__6;
        /*0x78*/ UnityEngine.Color <col2>5__7;

        /*0x32f460*/ <MoveObject>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a8f00*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a93a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class RiverBlock : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2Int position;
    /*0x28*/ Team team;
    /*0x30*/ System.Collections.Generic.List<int> targetRows;

    /*0x31c640*/ RiverBlock();
    /*0x5a5430*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class RiverWater : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2Int min;
    /*0x28*/ UnityEngine.Vector2Int max;

    /*0x31c640*/ RiverWater();
    /*0x5a55c0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class SnowMap : UnityEngine.MonoBehaviour
{
    static /*0x0*/ SnowMap Instance;
    /*0x20*/ UnityEngine.ParticleSystem particle;
    /*0x28*/ bool bigSnow;
    /*0x2c*/ float timer;
    /*0x30*/ Board board;
    /*0x38*/ UnityEngine.ParticleSystem.EmissionModule emission;

    /*0x31c640*/ SnowMap();
    /*0x5a58f0*/ void Awake();
    /*0x5a6440*/ void Start();
    /*0x5a64b0*/ void Update();
    /*0x5a6100*/ void HugeWave();
    /*0x5a5950*/ System.Collections.IEnumerator BigSnow();
    /*0x5a6180*/ void Remove(ref System.Collections.Generic.HashSet<UnityEngine.Vector2Int> boxes);
    /*0x5a59c0*/ void Freeze();

    class <>c
    {
        static /*0x0*/ SnowMap.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__11_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__12_0;

        static /*0x5a9750*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5a94e0*/ bool <Remove>b__11_0(Plant p);
        /*0x5a94c0*/ bool <Freeze>b__12_0(Plant p);
    }

    class <BigSnow>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SnowMap <>4__this;
        /*0x28*/ float <timer>5__2;
        /*0x2c*/ float <baseTime>5__3;

        /*0x32f460*/ <BigSnow>d__10(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a7e90*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a7fd0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class LookingStar : UnityEngine.MonoBehaviour
{
    /*0x20*/ LookingStar Instance;
    /*0x28*/ System.Collections.Generic.List<LookingStar.PreStar> preStars;
    /*0x30*/ ChallengeLevel level;
    /*0x38*/ Board board;
    /*0x40*/ bool over;

    /*0x5a06a0*/ LookingStar();
    /*0x59fa40*/ void Awake();
    /*0x59fde0*/ void Start();
    /*0x5a0330*/ void Update();
    /*0x59fb60*/ void SetPlantPreview(int theColumn, int theRow, PlantType thePlantType);
    /*0x59faa0*/ bool CheckPlant(int theColumn, int theRow, PlantType thePlantType);

    struct PreStar
    {
        /*0x10*/ int theColumn;
        /*0x14*/ int theRow;
        /*0x18*/ PlantType thePlantType;
        /*0x20*/ UnityEngine.GameObject preview;
    }
}

class LawnShooter : Mower
{
    /*0x60*/ float timer;
    /*0x68*/ UnityEngine.Transform shoot;
    /*0x70*/ int attackDamage;
    /*0x74*/ int shootRange;

    /*0x59d690*/ LawnShooter();
    /*0x59d500*/ void Start();
    /*0x59d1d0*/ void SetEffect();
    /*0x59d560*/ void Update();
    /*0x59d210*/ void ShootUpdate();
    /*0x59d190*/ void AttackZombie(Zombie zombie);
    /*0x59d2e0*/ bool Shootable();
    /*0x59d030*/ void AnimShoot();
}

class Mower : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theMowerRow;
    /*0x24*/ MowerType theMowerType;
    /*0x28*/ UnityEngine.Transform axis;
    /*0x30*/ bool started;
    /*0x38*/ Board board;
    /*0x40*/ float speed;
    /*0x48*/ UnityEngine.Rigidbody2D rb;
    /*0x50*/ UnityEngine.Animator anim;
    /*0x58*/ UnityEngine.LayerMask zombieLayer;

    /*0x5a4640*/ Mower();
    /*0x5a4650*/ int get_Column();
    /*0x5a3d10*/ void Awake();
    /*0x5a4510*/ void Update();
    /*0x5a3fa0*/ void MoveWaterUpdate();
    /*0x5a3ef0*/ void FixedUpdate();
    /*0x5a4210*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x5a3cd0*/ void AttackZombie(Zombie zombie);
    /*0x5a4430*/ void StartMove();
    /*0x5a3e40*/ void Die();
}

enum MowerType
{
    LawnMower = 0,
    PoolMower = 1,
    Cleaner = 2,
    LawnShooter = 3,
    SolarMower = 4,
}

class SolarMower : Mower
{
    /*0x60*/ float timer;
    /*0x64*/ float maxTimer;

    /*0x5a70f0*/ SolarMower();
    /*0x5a7030*/ void Update();
    /*0x5a6e80*/ void AnimShoot();
}

class NoticeMenu : BaseMenu
{
    static /*0x0*/ NoticeMenu Instance;

    /*0x32c760*/ NoticeMenu();
    /*0x5a46d0*/ void Awake();
    /*0x5a4830*/ void Start();
}

class AbyssSword : UnityEngine.MonoBehaviour
{
    /*0x20*/ AbyssSwordStar plant;

    /*0x31c640*/ AbyssSword();
    /*0x595c00*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x595d80*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class BallistaBomb : UnityEngine.MonoBehaviour
{
    /*0x20*/ float timer;
    /*0x28*/ Zombie zombie;
    /*0x30*/ int damage;
    /*0x34*/ ParticleType particleType;

    /*0x31c640*/ BallistaBomb();
    /*0x596220*/ void Update();
    /*0x595ec0*/ void ExplodeAction(Zombie zombie, int damage);
}

class BigSnowBall : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theRow;
    /*0x24*/ int damage;
    /*0x28*/ UnityEngine.Vector2 velocity;
    /*0x30*/ bool land;

    /*0x31c640*/ BigSnowBall();
    /*0x5967a0*/ void Update();
    /*0x5965f0*/ void PositionUpdate();
    /*0x5962b0*/ void LandEvent();
}

class BigStar : UnityEngine.MonoBehaviour
{
    /*0x20*/ float g;
    /*0x24*/ float speedX;
    /*0x28*/ float speedY;
    /*0x2c*/ bool isLand;
    /*0x30*/ float minY;
    /*0x34*/ BigStar.BigStarType type;
    /*0x38*/ bool zombie;
    /*0x39*/ bool sun;

    static /*0x5975a0*/ void SetStar(BigStar.BigStarType bigStarType);
    /*0x598090*/ BigStar();
    /*0x5967b0*/ void Awake();
    /*0x5976d0*/ void Start();
    /*0x5979b0*/ void Update();
    /*0x597b70*/ void ZombieCrash();
    /*0x596800*/ void Crash();
    /*0x5970e0*/ void CreateStars(BulletType bulletType);

    enum BigStarType
    {
        Default = 0,
        SuperStar = 1,
        UltimateStar = 2,
        IronStar = 3,
        PickaxeStar = 4,
        SolarStar = 5,
        DoomStar = 6,
    }
}

class BigSword : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 targetPosition;
    /*0x28*/ bool land;
    /*0x2c*/ float moveSpeed;
    /*0x30*/ float existTimer;
    /*0x38*/ Plant plant;
    /*0x40*/ System.Action<UnityEngine.Vector2> action;
    /*0x48*/ UnityEngine.SpriteRenderer r;
    /*0x50*/ UnityEngine.Rendering.SortingGroup sortingGroup;

    /*0x598ac0*/ BigSword();
    /*0x598530*/ void Awake();
    /*0x598640*/ void Start();
    /*0x5980b0*/ void AttackZombies();
    /*0x598650*/ void Update();
    /*0x5985d0*/ System.Collections.IEnumerator Enumerator();

    class <Enumerator>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ BigSword <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x32f460*/ <Enumerator>d__12(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5a8400*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5a85c0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BlackHole : UnityEngine.MonoBehaviour
{
    /*0x20*/ int _row;
    /*0x24*/ int theDamage;
    /*0x28*/ bool gold;
    /*0x30*/ UnityEngine.Rendering.SortingGroup g;
    /*0x38*/ float timer;
    /*0x3c*/ float existTime;
    /*0x40*/ UnityEngine.Animator anim;
    /*0x48*/ UnityEngine.ParticleSystem particle;
    /*0x50*/ bool dying;
    /*0x54*/ UnityEngine.LayerMask zombieLayer;
    /*0x58*/ UnityEngine.LayerMask bulletLayer;
    /*0x5c*/ float baseTime;

    /*0x599c70*/ BlackHole();
    /*0x3e3af0*/ int get_Row();
    /*0x599c80*/ void set_Row(int value);
    /*0x599150*/ void Awake();
    /*0x599b40*/ void Start();
    /*0x599bb0*/ void Update();
    /*0x5998b0*/ void FixedUpdate();
    /*0x598ad0*/ void AttrackUpdate();
    /*0x599930*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x5998c0*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x599830*/ void Die();
    /*0x599350*/ void Destory();
}

class CannonExplodeSplat : UnityEngine.MonoBehaviour
{
    /*0x20*/ int row;
    /*0x24*/ int damage;
    /*0x28*/ UnityEngine.Rigidbody2D rb;
    /*0x30*/ Board board;

    /*0x31c640*/ CannonExplodeSplat();
    /*0x599d10*/ void Awake();
    /*0x599db0*/ void FixedUpdate();
    /*0x599e20*/ void Update();
}

class CoinMoney : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theCoinType;
    /*0x24*/ int theMoveType;
    /*0x28*/ int moneyPrice;
    /*0x30*/ UnityEngine.Transform target;
    /*0x38*/ float moveSpeed;
    /*0x3c*/ bool isLand;
    /*0x40*/ float horizontalSpeed;
    /*0x44*/ float verticalSpeed;
    /*0x48*/ float gravity;
    /*0x4c*/ UnityEngine.Vector2 velocity;
    /*0x54*/ UnityEngine.Vector2 startPosition;

    /*0x59a900*/ CoinMoney();
    /*0x59a560*/ void Start();
    /*0x59a7d0*/ void Update();
    /*0x59a010*/ void MoveToPosition();
    /*0x599fb0*/ void Die();
}

enum ItemType
{
    NormalSun = 0,
    BigSun = 1,
    SmallSun = 2,
    Bucket = 4,
    Helmet = 6,
    Jackbox = 7,
    Pickaxe = 8,
    LittleSun = 13,
    SilverCoin = 34,
    GoldCoin = 35,
    DiamondCoin = 36,
    Bean = 37,
    SmallSilverCoin = 38,
    SmallGoldCoin = 39,
    Machine = 41,
    Portal = 42,
    BlueSun = 53,
    SmallBlueSun = 54,
}

class DisablePlant : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Collider2D col;
    /*0x28*/ Zombie Zombie;
    /*0x30*/ int nearRow;
    /*0x38*/ System.Collections.Generic.HashSet<Plant> disabledPlants;

    /*0x59ad60*/ DisablePlant();
    /*0x59ac70*/ void Start();
    /*0x59acc0*/ void Update();
    /*0x59a930*/ bool CheckRow(Plant plant);
    /*0x59aa80*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x59a9b0*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
}

class FireOcean : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theRow;
    /*0x24*/ int theDamage;
    /*0x28*/ float timer;
    /*0x2c*/ float timer2;
    /*0x30*/ UnityEngine.ParticleSystem particle;

    /*0x59b120*/ FireOcean();
    /*0x59ade0*/ void Awake();
    /*0x59afc0*/ void Update();
    /*0x59ae90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class FreezedPlant : GridItem
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, ZombieType> TurnDic;
    /*0x48*/ float health;
    /*0x4c*/ float maxHealth;
    /*0x50*/ bool dying;
    /*0x51*/ bool set;
    /*0x54*/ PlantType thePlantType;
    /*0x58*/ UnityEngine.GameObject g;
    /*0x60*/ UnityEngine.GameObject iceTrap;
    /*0x68*/ UnityEngine.GameObject iceTrap2;
    /*0x70*/ SavePlantData savedData;
    /*0x78*/ bool saved;

    static /*0x59c2a0*/ FreezedPlant();
    /*0x59c4d0*/ FreezedPlant();
    /*0x59bfb0*/ void TakeDamage(float value, Team team);
    /*0x59ba00*/ void InitFreezedPlant(PlantType thePlantType);
    /*0x59bcc0*/ void SetEntity(Team team);
    /*0x59b150*/ PlantType GetPlantType(int index);
    /*0x59b8e0*/ ZombieType GetZombieType();
    /*0x59bb40*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x59b990*/ void HitBullet(Bullet bullet);
    /*0x59b140*/ void FixedUpdate();
}

class HealthSlider : UnityEngine.MonoBehaviour
{
    /*0x20*/ float _value;
    /*0x24*/ float _value2;
    /*0x28*/ UnityEngine.GameObject background;
    /*0x30*/ UnityEngine.SpriteRenderer fill;
    /*0x38*/ UnityEngine.SpriteRenderer fill_shield;
    /*0x40*/ TMPro.TextMeshPro text;
    /*0x48*/ TMPro.TextMeshPro healthText;
    /*0x50*/ TMPro.TextMeshPro healthTextShadow;
    /*0x58*/ UnityEngine.Transform textHead;

    /*0x31c640*/ HealthSlider();
    /*0x59c600*/ void OnEnable();
    /*0x59cdd0*/ void Update();
    /*0x59c700*/ void Start();
    /*0x59c840*/ void UpdateValue(float theHealth, float theMaxHealth, float theSheildHealth);
    /*0x59c4f0*/ UnityEngine.Color Get2048Color(int value);
}

class LittleFly : UnityEngine.MonoBehaviour
{
    /*0x20*/ Zombie target;
    /*0x28*/ float shootCountDown;
    /*0x30*/ UnityEngine.Animator anim;
    /*0x38*/ bool onTarget;
    /*0x3c*/ float moveSpeed;
    /*0x40*/ float rotationSpeed;
    /*0x44*/ UnityEngine.Vector3 offset;
    /*0x50*/ UnityEngine.Transform axis;
    /*0x58*/ UnityEngine.GameObject shoot;
    /*0x60*/ int theFlyRow;
    /*0x68*/ Plant parentPlant;
    /*0x70*/ float positionOffset;

    /*0x59ea70*/ LittleFly();
    /*0x59d820*/ void Awake();
    /*0x59e4b0*/ void Update();
    /*0x59e420*/ void ShootUpdate();
    /*0x59d9d0*/ void FollowingTarget(UnityEngine.Vector3 position);
    /*0x59dde0*/ Zombie GetZombie();
    /*0x59d6b0*/ void AnimShoot();
    /*0x59e0e0*/ void SetLayer(UnityEngine.GameObject obj);
    /*0x59d940*/ void Die();
}

class LittleSquash : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Transform axis;
    /*0x28*/ UnityEngine.Transform shadow;
    /*0x30*/ int theRow;
    /*0x34*/ int theDamage;
    /*0x38*/ LittleSquash.Status status;
    /*0x3c*/ float timer;
    /*0x40*/ UnityEngine.LayerMask zombieLayer;
    /*0x48*/ UnityEngine.Animator anim;
    /*0x50*/ UnityEngine.Vector3 jumpTargetPosition;
    /*0x60*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x68*/ int crashCount;
    /*0x6c*/ float moveSpeed;
    /*0x70*/ System.Action<int, int> crashAction;

    /*0x59fa20*/ LittleSquash();
    /*0x59ee30*/ void Awake();
    /*0x59f860*/ void Start();
    /*0x59f9c0*/ void Update();
    /*0x59f180*/ void PositionUpdate();
    /*0x59efb0*/ void NextStatus();
    /*0x59ee20*/ void AnimJump();
    /*0x59f5e0*/ Zombie SearchZombie();
    /*0x59ea90*/ void AdjustPosition(UnityEngine.Vector3 targetPosition);
    /*0x59eb90*/ void AnimCrash();

    enum Status
    {
        Default = 0,
        Moving = 1,
        Waiting = 2,
        Crashing = 3,
        Crashed = 4,
    }
}

class Lunar : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Lunar Instance;
    /*0x20*/ UnityEngine.GameObject line;
    /*0x28*/ System.Collections.Generic.List<LunarLine> lines;
    /*0x30*/ bool red;
    /*0x38*/ Board board;
    /*0x40*/ float timer;
    /*0x44*/ float summonTimer;
    /*0x48*/ float lifeTimer;
    /*0x50*/ System.Collections.Generic.List<ZombieType> RedSummonZombies;
    /*0x58*/ Zombie lockedZombie;
    /*0x60*/ float lockedTimer;
    /*0x68*/ LunarLine _attackLine;

    /*0x5a2560*/ Lunar();
    /*0x5a11a0*/ void Awake();
    /*0x5a17c0*/ void Init();
    /*0x5a2460*/ void Update();
    /*0x5a1cb0*/ void RecoverUpdate();
    /*0x5a1c10*/ void LiveUpdate();
    /*0x5a1fe0*/ void SummonUpdate();
    /*0x5a1430*/ System.Collections.Generic.HashSet<UnityEngine.Vector2Int> GetFreeBoxes();
    /*0x5a1370*/ void FixedUpdate();
    /*0x5a0ce0*/ void AttackUpdate();
    /*0x5a27f0*/ LunarLine get_AttackLine();
    /*0x5a2950*/ bool get_God();

    class <>c
    {
        static /*0x0*/ Lunar.<> <>9;
        static /*0x8*/ System.Predicate<Zombie> <>9__19_0;
        static /*0x10*/ System.Func<Zombie, float> <>9__19_1;

        static /*0x5a9830*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5a93e0*/ bool <AttackUpdate>b__19_0(Zombie zombie);
        /*0x5a94a0*/ float <AttackUpdate>b__19_1(Zombie z);
    }
}

class LunarLine : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.LineRenderer lineRenderer;
    /*0x28*/ Plant plant;
    /*0x30*/ Lunar lunar;
    /*0x38*/ bool attack;

    /*0x31c640*/ LunarLine();
    /*0x5a07a0*/ void Awake();
    /*0x5a0970*/ void Start();
    /*0x5a0ae0*/ void Update();
    /*0x5a07f0*/ void NormalUpdate();
    /*0x5a0720*/ void AttackUpdate();
}

class Money : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Money Instance;
    /*0x20*/ UnityEngine.Transform moneyPos;
    /*0x28*/ TMPro.TextMeshProUGUI textMesh;
    /*0x30*/ TMPro.TextMeshProUGUI beanCount;
    /*0x38*/ TMPro.TextMeshProUGUI beanCount2;
    /*0x40*/ UnityEngine.GameObject count;
    /*0x48*/ Board board;
    /*0x50*/ System.Collections.Generic.Dictionary<PlantType, PlantType> plantUpgrades;

    /*0x5a3b50*/ Money();
    /*0x5a2a10*/ void Awake();
    /*0x5a3880*/ void Update();
    /*0x5a2a90*/ void EnableMoneyBank();
    /*0x5a30c0*/ void ReinforcePlant(Plant plant);
    /*0x5a3a20*/ void UsedEvent(int theColumn, int theRow, int cost);
    /*0x5a2dc0*/ void OtherSuperSkill(Plant originalPlant);
    /*0x5a2bc0*/ int GetUpgradeCost(PlantType thePlantType);
    /*0x5a2ac0*/ int GetSuperSkillCost(PlantType thePlantType);
}

class PrismLight : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.LineRenderer r;
    /*0x28*/ float timer;
    /*0x2c*/ UnityEngine.Color startColor;

    /*0x31c640*/ PrismLight();
    /*0x5a52f0*/ void Awake();
    /*0x5a5360*/ void Update();
}

class Solar : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Solar Instance;
    /*0x20*/ int damage;
    /*0x24*/ float deathTime;
    /*0x28*/ UnityEngine.GameObject solarBomb;
    /*0x30*/ float timer;
    /*0x34*/ float timer2;
    /*0x38*/ UnityEngine.Vector2 targetPosition;
    /*0x40*/ bool arrived;
    /*0x48*/ UnityEngine.ParticleSystem particleSystem1;
    /*0x50*/ UnityEngine.ParticleSystem particleSystem2;
    /*0x58*/ Board board;

    /*0x5a7e70*/ Solar();
    /*0x5a7110*/ void Awake();
    /*0x5a7470*/ void SetDamage();
    /*0x5a73a0*/ bool God();
    /*0x5a77b0*/ void Update();

    class <>c
    {
        static /*0x0*/ Solar.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__12_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__12_1;

        static /*0x5a97c0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x42b7b0*/ bool <SetDamage>b__12_0(Plant p);
        /*0x42b7b0*/ bool <SetDamage>b__12_1(Plant p);
    }
}

class SolarBomb : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ int row;
    /*0x2c*/ int dmg;
    /*0x30*/ int count;

    /*0x5a6e70*/ SolarBomb();
    /*0x5a6600*/ void Awake();
    /*0x5a6a40*/ void Start();
    /*0x5a6650*/ void SetStartPosition();
    /*0x5a6a50*/ void Update();
}

class LanternLaser : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.SpriteRenderer spriteRenderer;
    /*0x28*/ UnityEngine.Color color;

    /*0x31c640*/ LanternLaser();
    /*0x59ced0*/ void Awake();
    /*0x59cf10*/ void Update();
}

class Particle : UnityEngine.MonoBehaviour
{
    /*0x20*/ ParticleType theParticleType;
    /*0x24*/ float existTimer;
    /*0x28*/ float maxTimer;

    /*0x31c640*/ Particle();
    /*0x5a5160*/ void Awake();
    /*0x5a5290*/ void OnParticleSystemStopped();
    /*0x5a5280*/ void InitParticle();
    /*0x5a52a0*/ void Update();
    /*0x5a51f0*/ void Die();
}

enum ParticleType
{
    PeaSplat = 0,
    Dirt = 1,
    BombCloud = 2,
    SunBombCloud = 3,
    CherrySplat = 4,
    NutPartical = 5,
    CherryNutPartical = 6,
    NutSplat = 7,
    PotaoExplode = 8,
    PotatoRise = 9,
    GreenCherrySplat = 10,
    RandomCloud = 11,
    ZombieBlockSplat = 12,
    PurpleNutDust = 13,
    BombCloudSmall = 14,
    PotatoSplat = 15,
    Health = 16,
    PuffSplat = 17,
    IronPeaSplat = 18,
    Fume = 19,
    MindControl = 20,
    FumeColorful = 21,
    FumeColorful2 = 22,
    Star = 23,
    SnowPeaSplat = 24,
    Doom = 25,
    PuffBlackSplat = 26,
    DoomSplat = 27,
    IceDoomSplat = 28,
    IceDoom = 29,
    FumeIce = 30,
    FumeDoom = 31,
    WaterSplats = 32,
    Fire = 33,
    MachineExplode = 34,
    FireFree = 35,
    MachineExplodeRed = 36,
    Gloom = 37,
    GloomFire = 38,
    GloomIce = 39,
    LanternShine = 40,
    BombKirov = 41,
    BombJackbox = 42,
    LanternLaser = 43,
    StarSplat = 44,
    PickaxeStarSplat = 45,
    MagnetStarSplat = 46,
    JackboxStarSplat = 47,
    MagnetLight = 48,
    BombStarCloud = 49,
    UltimateStarSplat = 50,
    UltimateStarCloud = 51,
    SuperGloom = 52,
    LightningArcExplosion = 53,
    MachineExplodeBrown = 54,
    MelonSplat = 55,
    WinterMelonSplat = 56,
    Splat_white = 57,
    Splat_white_big = 58,
    CannonSplat = 59,
    MelonSplat_kernal = 60,
    MelonSplat_butter = 61,
    PrizeSplat = 62,
    BallFire = 63,
    BallIce = 64,
    ZumaSplat = 65,
    CannonMelonSplat = 66,
    SilverCoinSplat = 67,
    SmallCannonSplat = 68,
    SuperKillEffect = 69,
    MelonSplat_silver = 70,
    MelonSplat_gold = 71,
    Flame = 72,
    JalaedCloudSmall = 73,
    MelonSplat_fire = 74,
    BossExplosion = 75,
    SummonFireBall = 76,
    SummonIceBall = 77,
    GarlicCloud = 78,
    Fume_magnet = 79,
    Fume_iron = 80,
    Fume_helmet = 81,
    Fume_garlic = 82,
    SteelPeaSplat = 83,
    Splat_sun = 84,
    IceBallExplode = 85,
    Doom_solar = 86,
    ElectricSplat = 87,
    LanternCloud = 88,
    Fume_fire = 89,
    EmberedCloudSmall = 90,
    AttackEnergy = 91,
    DirtSplat = 92,
    BombCloud_vision = 93,
    FireOcean = 94,
    Pow = 95,
    ShootCloud = 96,
    ProtalPeaSplat = 97,
    ProtalGlow = 98,
    HypnoEmperorSkinCloud = 99,
    BombCloud_blue = 100,
    DirtSplat2 = 101,
    BrownCloud_small = 102,
    FastShoot = 103,
    DirtSplat3 = 104,
    BombCloud_vision_doom = 105,
    PointsSplat = 106,
    BombCloud_Darkgreen = 107,
    BombCloud_vision_water = 108,
    BambooDeath = 109,
    ShootFire = 110,
    SmallMelonSplat = 111,
    MelonSplat_hypno = 112,
    BombCloud_vision_pea = 113,
    HypnoPeaSplat = 114,
    Fume_long = 115,
    LightRedSplat = 116,
    BombCloud_sun = 117,
    BombCloud_vision_glow = 118,
    GraveSplat = 119,
    Fade = 120,
    BombCloud_black = 121,
    BigWaterSplats = 122,
    MelonSplat_magnet = 123,
    MelonSplat_iron = 124,
    MelonSplat_portal = 125,
}

class ParticleManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ParticleManager Instance;
    /*0x20*/ System.Collections.Generic.Dictionary<ParticleType, UnityEngine.Pool.ObjectPool<Particle>> pools;

    /*0x5a50e0*/ ParticleManager();
    /*0x5a4960*/ void Awake();
    /*0x5a4f10*/ Particle SetParticle(ParticleType particleType, UnityEngine.Vector2 position, int layerRow);
    /*0x5a4cc0*/ Particle CreateParticle(ParticleType particleType);
    /*0x474170*/ void GetParticle(Particle obj);
    /*0x4741b0*/ void ReleaseParticle(Particle obj);
    /*0x5a4ea0*/ void DestoryParticle(Particle obj);

    class <>c__DisplayClass2_0
    {
        /*0x10*/ ParticleType item;
        /*0x18*/ ParticleManager <>4__this;

        /*0x32f970*/ <>c__DisplayClass2_0();
        /*0x5a9560*/ Particle <Awake>b__0();
    }
}

class Plant : Entity
{
    /*0x48*/ UnityEngine.Collider2D mouseCollider;
    /*0x50*/ int thePlantMaxHealth;
    /*0x54*/ int thePlantHealth;
    /*0x58*/ int theShieldHealth;
    /*0x5c*/ int attackDamage;
    /*0x60*/ float thePlantAttackInterval;
    /*0x64*/ float thePlantProduceInterval;
    /*0x68*/ bool isLily;
    /*0x69*/ bool imitatless;
    /*0x6a*/ bool invincible;
    /*0x6b*/ bool isShort;
    /*0x6c*/ UnityEngine.Vector3 startPos;
    /*0x78*/ int thePlantColumn;
    /*0x7c*/ int thePlantRow;
    /*0x80*/ int magnetCount;
    /*0x84*/ int theLevel;
    /*0x88*/ float thePlantSpeed;
    /*0x8c*/ float thePlantAttackCountDown;
    /*0x90*/ float thePlantProduceCountDown;
    /*0x94*/ float attributeCountdown;
    /*0x98*/ float lightCountDown;
    /*0x9c*/ float flashCountDown;
    /*0xa0*/ float wheatTime;
    /*0xa4*/ float brightness;
    /*0xa8*/ float lastTakeDamgeTime;
    /*0xac*/ float disappearTime;
    /*0xb0*/ bool isFlashing;
    /*0xb4*/ int wheatType;
    /*0xb8*/ bool alwaysLightUp;
    /*0xb9*/ bool isCrashed;
    /*0xba*/ bool melonSputter;
    /*0xbb*/ bool dieMeansLose;
    /*0xbc*/ bool isGray;
    /*0xbd*/ bool isConnected;
    /*0xbe*/ bool keepShooting;
    /*0xbf*/ bool waitingDestory;
    /*0xc0*/ bool isGhost;
    /*0xc1*/ bool hid;
    /*0xc2*/ bool uncrashable;
    /*0xc4*/ UnityEngine.Vector2 targetBox;
    /*0xcc*/ float moveTime;
    /*0xd0*/ float attackSpeedAdder;
    /*0xd4*/ int disableCount;
    /*0xd8*/ int attributeCount;
    /*0xdc*/ float attributeSpeed;
    /*0xe0*/ float attributeFloat;
    /*0xe4*/ int shootingLevel;
    /*0xe8*/ int killCount;
    /*0xec*/ int puffPlace;
    /*0xf0*/ int baseLayer;
    /*0xf4*/ int currentLightLevel;
    /*0xf8*/ int p;
    /*0xfc*/ int thePlantStage;
    /*0x100*/ PlantType thePlantType;
    /*0x104*/ PlantType theLilyType;
    /*0x108*/ PlantType firstParent;
    /*0x10c*/ PlantType secondParent;
    /*0x110*/ UnityEngine.LayerMask zombieLayer;
    /*0x114*/ UnityEngine.LayerMask plantLayer;
    /*0x118*/ UnityEngine.LayerMask bulletLayer;
    /*0x11c*/ UnityEngine.LayerMask potLayer;
    /*0x120*/ UnityEngine.LayerMask airLayer;
    /*0x124*/ PlantStatus theStatus;
    /*0x128*/ Plant next;
    /*0x130*/ Plant pre;
    /*0x138*/ Plant snakeNext;
    /*0x140*/ Plant snakePre;
    /*0x148*/ Plant.PlantTag plantTag;
    /*0x160*/ UnityEngine.GameObject textHead;
    /*0x168*/ HealthSlider healthSlider;
    /*0x170*/ UnityEngine.GameObject levelIcon;
    /*0x178*/ Plant targetPlant;
    /*0x180*/ Zombie targetZombie;
    /*0x188*/ UnityEngine.GameObject autoCard;
    /*0x190*/ System.Collections.Generic.List<JigsawType> jigsawType;
    /*0x198*/ Zombie cursedZombie;
    /*0x1a0*/ bool freeMoving;
    /*0x1a1*/ bool dying;
    /*0x1a8*/ System.Collections.Generic.List<Zombie> zombieList;
    /*0x1b0*/ float theOriginSpeed;
    /*0x1b4*/ float vision;
    /*0x1b8*/ UnityEngine.Rigidbody2D rb;
    /*0x1c0*/ System.Collections.Generic.Dictionary<PlantDamageAdder, float> damageAdder;
    /*0x1c8*/ float fallSpeed;
    /*0x1cc*/ float defence;
    /*0x1d0*/ float moveSpeed;
    /*0x1d4*/ bool falling;
    /*0x1d5*/ bool moving;
    /*0x1d8*/ UnityEngine.Transform shoot;
    /*0x1e0*/ UnityEngine.Transform shoot2;
    /*0x1e8*/ float[] _timers;
    /*0x1f0*/ Plant connectPlant;
    /*0x1f8*/ UnityEngine.Vector3 cannonTarget;

    /*0x5c54c0*/ Plant();
    /*0x5c5600*/ bool get_Active();
    /*0x5c5690*/ BoxType get_BoxType();
    /*0x5c56e0*/ int get_Column();
    /*0x5c6880*/ float[] get_Timers();
    /*0x5bc240*/ void Awake();
    /*0x5beda0*/ void Hid();
    /*0x32d010*/ void FirstMeet();
    /*0x5c2e10*/ void Start();
    /*0x5c4330*/ void Update();
    /*0x5be480*/ void FixedUpdate();
    /*0x5bfa90*/ void KillZombie(Zombie zombie);
    /*0x3c0a70*/ void Charge();
    /*0x5c3c10*/ void TryBeDisable(float timer);
    /*0x5be2a0*/ bool FindPineFunrce();
    /*0x5c37b0*/ void TryBeActive();
    /*0x5bc5d0*/ bool CheckOrActive();
    /*0x5c04f0*/ void OnDestroy();
    /*0x5c2870*/ void SetGray();
    /*0x5c2bd0*/ void SetWheat();
    /*0x5be560*/ void FlashUpdate();
    /*0x5c06b0*/ void PlantUpdate();
    /*0x5c0e00*/ void PositionUpdate();
    /*0x5c0290*/ void MoveTowards(UnityEngine.Vector2 position);
    /*0x5bfc10*/ void MovePosition(UnityEngine.Vector2 position);
    /*0x5c2fd0*/ void SupplyPlantsInBejaw();
    /*0x5c0010*/ void MoveRestPlantsInBejaw();
    /*0x5bc610*/ void ClearInBejaw();
    /*0x5c0460*/ bool Near(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 endPosition);
    /*0x5bfab0*/ void MoveBox(int theColumn, int theRow);
    /*0x32d010*/ void AttributeEvent();
    /*0x5bedc0*/ UnityEngine.GameObject InitText();
    /*0x5c29d0*/ TMPro.TextMeshPro SetPlantText(string name, UnityEngine.Color color, UnityEngine.Vector2 localPosition, UnityEngine.Transform parent, string str, int order);
    /*0x5c4130*/ void UpdateText();
    /*0x5c3370*/ void TakeDamage(int damage, int damageType);
    /*0x5bd800*/ void DecreaseHealth(int value);
    /*0x5be730*/ int GetDamage(int damage);
    /*0x5bf3e0*/ bool Instead(int theDamage);
    /*0x5c50b0*/ void WheatUpdate();
    /*0x5be540*/ void FlashOnce();
    /*0x5bd810*/ void Die(Plant.DieReason reason);
    /*0x5bcae0*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x5c15b0*/ void RemoveFromList();
    /*0x5c21d0*/ UnityEngine.GameObject SearchZombie();
    /*0x5c05f0*/ void PlantShootUpdate();
    /*0x5c3eb0*/ void UpdateAttackCountDown();
    /*0x5c2d30*/ bool Shootable();
    /*0x5c1bf0*/ bool SearchGoldMagnet();
    /*0x32d010*/ void ProducerUpdate();
    /*0x5c2410*/ void SetBrightness(float b);
    /*0x5c1190*/ void Recover(float health, Plant.DamageType damageType);
    /*0x5beb90*/ void GetShield(int value);
    /*0x5bf190*/ bool InsteadRecover();
    /*0x5bfaa0*/ void LimHealth();
    /*0x32d010*/ void ReplaceSprite();
    /*0x5bc5b0*/ void Broken();
    /*0x5c2e80*/ bool SuperSkill();
    /*0x32d010*/ void DieEvent(Plant.DieReason reason);
    /*0x5bebb0*/ void GiveSunInIZ();
    /*0x5c1f80*/ bool SearchUniqueZombie(Zombie zombie);
    /*0x5bc180*/ bool AttackLandZombie(Zombie zombie);
    /*0x5c2700*/ void SetColor(UnityEngine.Color color);
    /*0x32d010*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x32d010*/ void OnCreate(int theColumn, int theRow);
    /*0x588ba0*/ void AdjustPosition(UnityEngine.Vector3 targetPosition);
    /*0x5bc040*/ void AdjustPositionY(float y);
    /*0x5bc0e0*/ void AdjustY(float y);
    /*0x32d010*/ void AnimSuperShoot();
    /*0x5c1a50*/ UnityEngine.GameObject SearchBoss();
    /*0x5c4c40*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x5c40c0*/ void UpdateMagnetCount(int count);
    /*0x5c69b0*/ bool get_WithGoldPot();
    /*0x5c58f0*/ PlantType get_PotType();
    /*0x5c5df0*/ Plant get_Pumpkin();
    /*0x5c5ab0*/ PlantType get_PumpkinType();
    /*0x5c5760*/ GridItem get_Ladder();
    /*0x5bbab0*/ void AdjustDamage(PlantDamageAdder index, float value, PlantType thePlantType, bool add);
    /*0x5bbe60*/ void AdjustDamage();
    /*0x5be970*/ int GetMaxHealth(PlantType thePlantType);
    /*0x32d010*/ void InitPlant();
    /*0x5bca30*/ void Connected(Plant plant);
    /*0x5be240*/ void DisConnected();
    /*0x5c43a0*/ bool Upgrade(int targetLevel, bool free);
    /*0x32d010*/ void UpgradeEvent(int theCurrentLevel);
    /*0x5c66a0*/ Plant get_SameUpper();
    /*0x5c62e0*/ Plant get_SameLower();
    /*0x5c6110*/ Plant get_SameLeft();
    /*0x5c64c0*/ Plant get_SameRight();

    enum DamageType
    {
        Default = 0,
        CherryExplode = 1,
        JackboxExplode = 2,
        UltimateTallNutAll = 3,
        EndlessFire = 4,
        DoomExplode = 5,
        NormalExplode = 6,
    }

    struct PlantTag
    {
        /*0x10*/ bool flyingPlant;
        /*0x11*/ bool hardLandPlant;
        /*0x12*/ bool waterPlant;
        /*0x13*/ bool pumpkinPlant;
        /*0x14*/ bool lanternPlant;
        /*0x15*/ bool smallLanternPlant;
        /*0x16*/ bool puffPlant;
        /*0x17*/ bool nutPlant;
        /*0x18*/ bool tallNutPlant;
        /*0x19*/ bool potatoPlant;
        /*0x1a*/ bool caltropPlant;
        /*0x1b*/ bool tanglekelpPlant;
        /*0x1c*/ bool magnetPlant;
        /*0x1d*/ bool potPlant;
        /*0x1e*/ bool doubleBoxPlant;
        /*0x1f*/ bool spickRockPlant;
        /*0x20*/ bool icePlant;
        /*0x21*/ bool firePlant;
    }

    enum DieReason
    {
        Default = 0,
        ByWheat = 1,
        ByMix = 2,
        ByDisMix = 3,
        ByLevelUp = 4,
        BySteal = 5,
        ByBejeweled = 6,
        ByShovel = 7,
        BySelf = 8,
        ByFreeze = 9,
        Hid = 10,
        CrashInWater = 11,
    }

    class <>c
    {
        static /*0x0*/ Plant.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__131_0;
        static /*0x10*/ System.Predicate<PlantType> <>9__133_0;
        static /*0x18*/ System.Func<Zombie, bool> <>9__145_0;
        static /*0x20*/ System.Predicate<Plant> <>9__147_0;

        static /*0x5ca2b0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5ca100*/ bool <Instead>b__131_0(Plant p);
        /*0x5ca160*/ bool <WheatUpdate>b__133_0(PlantType p);
        /*0x5ca130*/ bool <Recover>b__145_0(Zombie z);
        /*0x5ca0c0*/ bool <InsteadRecover>b__147_0(Plant p);
    }
}

class Attacker : Plant
{
    /*0x348cd0*/ Attacker();
}

class ChomperAttackRange : UnityEngine.MonoBehaviour
{
    /*0x20*/ Chomper chomper;

    /*0x31c640*/ ChomperAttackRange();
    /*0x5aaae0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class BucketDoom : DoomShroom
{
    /*0x348cd0*/ BucketDoom();
    /*0x5a98a0*/ void AnimExplode();
    /*0x5a9990*/ void ExplodeAction(Zombie zombie);
}

class CaltropKelp_land : Caltrop
{
    /*0x361060*/ CaltropKelp_land();
    /*0x5a9bc0*/ void AnimAttack();
}

class CaltropKelp_water : Attacker
{
    /*0x348cd0*/ CaltropKelp_water();
    /*0x5aa210*/ void Update();
    /*0x5a9ea0*/ void PlantShootUpdate();
    /*0x5a9f70*/ void SearchZombieUpdate(System.Action<Zombie> action);
    /*0x5a9e20*/ void AnimAttack();
    /*0x5aa1c0*/ void <PlantShootUpdate>b__1_0(Zombie zombie);
    /*0x5aa0f0*/ void <AnimAttack>b__3_0(Zombie zombie);
}

class CherryBomb : Plant
{
    /*0x348cd0*/ CherryBomb();
    /*0x5aa5e0*/ void Start();
    /*0x5aa300*/ void Bomb();
    /*0x5aa580*/ void PlaySoundStart();
}

class CherryJalapeno : Plant
{
    /*0x348cd0*/ CherryJalapeno();
    /*0x3517c0*/ void Awake();
    /*0x5aa910*/ void Start();
    /*0x5aa680*/ void AttributeEvent();
    /*0x5aa9d0*/ void Update();
    /*0x5aa6b0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void TakeDamage(int damage, int damageType);
    /*0x32d010*/ void Crashed(int level, int soundID, Zombie zombie);
}

class DoomJalapeno : Plant
{
    /*0x348cd0*/ DoomJalapeno();
    /*0x5aab10*/ void AnimExplode();
    /*0x5aaee0*/ void Crashed(int level, int soundID, Zombie zombie);
}

class DoomPuff : Plant
{
    /*0x208*/ bool exploded;

    /*0x348cd0*/ DoomPuff();
    /*0x5ab0b0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x5aaf00*/ void AttackZombie();
    /*0x5ab090*/ void DieEvent(Plant.DieReason reason);
}

class DoomShroom : Plant
{
    /*0x348cd0*/ DoomShroom();
    /*0x5ab3e0*/ void Start();
    /*0x5ab340*/ void AnimExplode();
    /*0x5ab3b0*/ void Crashed(int level, int soundID, Zombie zombie);
}

class GoldDoom : Plant
{
    /*0x348cd0*/ GoldDoom();
    /*0x5ab4c0*/ bool SuperSkill();
}

class HypnoDoom : Plant
{
    /*0x348cd0*/ HypnoDoom();
}

class HypnoMine : PotatoMine
{
    /*0x5ab700*/ HypnoMine();
    /*0x5ab540*/ void BombEffect();
}

class IceCherry : Plant
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ IceCherry();
    /*0x5ab720*/ void DieEvent(Plant.DieReason reason);
    /*0x5abac0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x5ab8d0*/ UnityEngine.GameObject InitText();
    /*0x5abe90*/ void UpdateText();

    class <>c
    {
        static /*0x0*/ IceCherry.<> <>9;
        static /*0x8*/ System.Action<Zombie> <>9__2_0;

        static /*0x5ca390*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5c9fd0*/ void <DieEvent>b__2_0(Zombie zombie);
    }
}

class IceDoom : DoomShroom
{
    /*0x348cd0*/ IceDoom();
    /*0x5abf90*/ void AnimExplode();
}

class JackboxDoom : DoomShroom
{
    /*0x348cd0*/ JackboxDoom();
    /*0x5ac010*/ void AnimExplode();
    /*0x5ac100*/ void ExplodeAction(Zombie zombie);
}

class Jalakelp : Tanglekelp
{
    /*0x5ac220*/ Jalakelp();
    /*0x3637d0*/ void DieEvent(Plant.DieReason reason);
}

class Jalapeno : Plant
{
    /*0x348cd0*/ Jalapeno();
    /*0x5ac2a0*/ void Start();
    /*0x5ac240*/ void AnimExplode();
}

class KelpMine_land : PotatoMine
{
    /*0x228*/ UnityEngine.Rendering.SortingGroup grab;

    /*0x5ab700*/ KelpMine_land();
    /*0x5ac740*/ void FixedUpdate();
    /*0x5ac800*/ void GrabUpdate();
    /*0x5ac610*/ void DieEvent(Plant.DieReason reason);
    /*0x5ac380*/ void AnimKill();
}

class KelpMine_water : Tanglekelp
{
    /*0x228*/ UnityEngine.GameObject kelpLight;
    /*0x230*/ float flashSpeed;
    /*0x234*/ float flashTimer;

    /*0x5ac220*/ KelpMine_water();
    /*0x5ad0a0*/ void FixedUpdate();
    /*0x5acce0*/ void DieEvent(Plant.DieReason reason);
    /*0x5ad1d0*/ void LightUpdate();
    /*0x5ad4e0*/ void Update();
    /*0x5ad160*/ System.Collections.IEnumerator FlashLight();

    class <FlashLight>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ KelpMine_water <>4__this;

        /*0x32f460*/ <FlashLight>d__7(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5c96c0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5c97a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class KelpTorch : Tanglekelp
{
    /*0x228*/ int count;

    /*0x5ac220*/ KelpTorch();
    /*0x5ad600*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x5ad920*/ void Summon();
}

class PortalDoom : DoomShroom
{
    /*0x348cd0*/ PortalDoom();
    /*0x5c6b80*/ void AnimExplode();
}

class PotatoMine : Plant
{
    /*0x208*/ bool isAready;
    /*0x210*/ UnityEngine.GameObject nearestZombie;
    /*0x218*/ float flashInterval;
    /*0x21c*/ float flashTime;
    /*0x220*/ bool isActive;
    /*0x221*/ bool explode;

    /*0x5ab700*/ PotatoMine();
    /*0x5c6e40*/ void Awake();
    /*0x5c74e0*/ void Update();
    /*0x5c72d0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3d4900*/ bool PotatoSearchZombie(Zombie zombie);
    /*0x34a6d0*/ void DelayDie();
    /*0x5c6c10*/ void AnimStartRise();
    /*0x5c6c00*/ void AnimRiseOver();
    /*0x5c6e80*/ void Explode();
    /*0x3595f0*/ void BombEffect();
    /*0x5c7390*/ void SetFlash();
    /*0x5c6fe0*/ UnityEngine.GameObject GetNearestZombie();
}

class SquashKelp : Tanglekelp
{
    /*0x5ac220*/ SquashKelp();
    /*0x5c7880*/ void FirstMeet();
    /*0x5c78d0*/ void GrabPrepare();
    /*0x5c7700*/ void AnimSquash();
    /*0x5c7af0*/ System.Collections.IEnumerator Moving();

    class <>c
    {
        static /*0x0*/ SquashKelp.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.AnimatorControllerParameter, bool> <>9__1_0;

        static /*0x5ca320*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5ca060*/ bool <GrabPrepare>b__1_0(UnityEngine.AnimatorControllerParameter param);
    }

    class <Moving>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SquashKelp <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x32f460*/ <Moving>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5c9bd0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5c9f90*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SunJalapeno : Jalapeno
{
    /*0x348cd0*/ SunJalapeno();
    /*0x5c7c30*/ void AnimExplode();
    /*0x5c7b60*/ void Action(Zombie zombie);
    /*0x5c7f90*/ bool <AnimExplode>b__0_0(Plant p);
}

class Tanglekelp : Plant
{
    /*0x208*/ UnityEngine.Vector2 range;
    /*0x210*/ UnityEngine.Transform grab;
    /*0x218*/ UnityEngine.Transform main;
    /*0x220*/ UnityEngine.Rendering.SortingGroup grabSort;

    /*0x5ac220*/ Tanglekelp();
    /*0x5c7fb0*/ void Awake();
    /*0x5c8270*/ void FixedUpdate();
    /*0x5c8400*/ void GrabUpdate();
    /*0x5c8810*/ void Grab();
    /*0x5c8330*/ void GrabPrepare();
    /*0x5c8120*/ void DieEvent(Plant.DieReason reason);
    /*0x5c89a0*/ System.Collections.IEnumerator Moving();
    /*0x5c8a10*/ void SetWaterSplat(UnityEngine.Vector2 position, UnityEngine.Vector2 scale);

    class <Moving>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Tanglekelp <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x32f460*/ <Moving>d__10(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x5c97e0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x5c9b90*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class TreasureMine : Plant
{
    /*0x208*/ float timer;
    /*0x20c*/ float flashTimer;
    /*0x210*/ int restPlant;

    /*0x5c96a0*/ TreasureMine();
    /*0x5c8d30*/ void Awake();
    /*0x5c9420*/ void Update();
    /*0x5c8ae0*/ void AnimGive();
    /*0x5c9150*/ void DropResources();
    /*0x5c8ed0*/ void DropCard();
    /*0x5c9280*/ void DropZombie();
    /*0x5c8d60*/ void DieEvent(Plant.DieReason reason);

    class <>c
    {
        static /*0x0*/ TreasureMine.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__7_0;

        static /*0x5ca240*/ <>c();
        /*0x32f970*/ <>c();
        /*0x5ca010*/ bool <DropCard>b__7_0(PlantType p);
    }
}

class MixData
{
    static /*0x0*/ int[,] data;
    static /*0x8*/ int[,] randomData;
    static /*0x10*/ MixData.DisMixData[] disMixDatas;

    static /*0x5bb990*/ MixData();
    static /*0x5b33c0*/ void InitDisMixData();
    static /*0x5b3740*/ void InitMixData();
    static /*0x5adc50*/ void FirstMix();
    static /*0x5b4b20*/ void PuffMix();
    static /*0x5b2680*/ void FogPlant();
    static /*0x5b5130*/ void RoofPlant();
    static /*0x5adb70*/ void AddDataUnordered(PlantType a, PlantType b, PlantType c);
    static /*0x5adad0*/ void AddDataOredered(PlantType a, PlantType b, PlantType c);
    static /*0x5b37c0*/ void InitTravel();
    static /*0x5bb0a0*/ void SubInit();
    static /*0x5baec0*/ void SpecialPlant();
    static /*0x5b9bb0*/ void SetPlants(int level);
    static /*0x5b8c40*/ void SetPlantsInLv27();
    static /*0x5b89e0*/ void SetPlantsInLv26();
    static /*0x5b8670*/ void SetPlantsInLv25();
    static /*0x5b83e0*/ void SetPlantsInLv24();
    static /*0x5b8170*/ void SetPlantsInLv23();
    static /*0x5b7ef0*/ void SetPlantsInLv22();
    static /*0x5b7c80*/ void SetPlantsInLv21();
    static /*0x5b7a00*/ void SetPlantsInLv20();
    static /*0x5b7790*/ void SetPlantsInLv19();
    static /*0x5b3330*/ PlantType GetRandomNumberInNumbers(PlantType[] numbers);
    static /*0x5b8fa0*/ void SetPlantsInLv2();
    static /*0x5b90d0*/ void SetPlantsInLv3();
    static /*0x5b9230*/ void SetPlantsInLv4();
    static /*0x5b93b0*/ void SetPlantsInLv5();
    static /*0x5b94e0*/ void SetPlantsInLv6();
    static /*0x5b9610*/ void SetPlantsInLv7();
    static /*0x5b97f0*/ void SetPlantsInLv8();
    static /*0x5b99d0*/ void SetPlantsInLv9();
    static /*0x5b6280*/ void SetPlantsInLv10();
    static /*0x5b6460*/ void SetPlantsInLv11();
    static /*0x5b6640*/ void SetPlantsInLv12();
    static /*0x5b6820*/ void SetPlantsInLv13();
    static /*0x5b6aa0*/ void SetPlantsInLv14();
    static /*0x5b6d40*/ void SetPlantsInLv15();
    static /*0x5b6fd0*/ void SetPlantsInLv16();
    static /*0x5b7270*/ void SetPlantsInLv17();
    static /*0x5b7510*/ void SetPlantsInLv18();
    /*0x32f970*/ MixData();

    class DisMixData
    {
        /*0x10*/ PlantType theFirstParent;
        /*0x14*/ PlantType theSecondParent;

        /*0x32f970*/ DisMixData();
    }
}

class CherryChomper : Chomper
{
    /*0x3493d0*/ CherryChomper();
    /*0x34da00*/ void Chomp(Zombie zombie);
}

class CherryNut : WallNut
{
    /*0x34b060*/ CherryNut();
    /*0x34fdd0*/ void DieEvent(Plant.DieReason reason);
}

class CherryNutPlus : CherryNut
{
    /*0x34b060*/ CherryNutPlus();
}

class NutChomper : Chomper
{
    /*0x228*/ UnityEngine.Sprite backCrack1;
    /*0x230*/ UnityEngine.Sprite backCrack2;
    /*0x238*/ UnityEngine.Sprite headCrack1;
    /*0x240*/ UnityEngine.Sprite headCrack2;
    /*0x248*/ UnityEngine.Sprite originBack;
    /*0x250*/ UnityEngine.Sprite originHead;
    /*0x258*/ UnityEngine.GameObject back;
    /*0x260*/ UnityEngine.GameObject head;
    /*0x268*/ bool cracked1;
    /*0x269*/ bool cracked2;

    /*0x3493d0*/ NutChomper();
    /*0x358480*/ void Awake();
    /*0x358bb0*/ void Swallow();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x3586e0*/ void ReplaceSprite();
}

class PeaChomper : Chomper
{
    /*0x3493d0*/ PeaChomper();
    /*0x358de0*/ void Update();
    /*0x358c50*/ Bullet AnimShoot();
    /*0x358db0*/ void AttributeEvent();
}

class PeaSunFlower : Shooter
{
    /*0x34b660*/ PeaSunFlower();
    /*0x358e40*/ void FirstMeet();
    /*0x359240*/ void Update();
    /*0x359080*/ Bullet Shoot1();
    /*0x358e90*/ void PeaSunProduceUpdate();
    /*0x3591d0*/ System.Collections.IEnumerator SunBright();
    /*0x358fa0*/ void ProduceSun();

    class <SunBright>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ PeaSunFlower <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__4(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x35c540*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x35c6c0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class PotatoChomper : Chomper
{
    /*0x3493d0*/ PotatoChomper();
    /*0x359480*/ void DieEvent(Plant.DieReason reason);
    /*0x3595f0*/ void Explode();
    /*0x3596f0*/ void Swallow();
    /*0x359370*/ void CreateMine();
    /*0x359660*/ void SetAttackRange();
}

class PotatoNut : WallNut
{
    /*0x208*/ bool isExplode1;
    /*0x209*/ bool isExplode2;
    /*0x20c*/ float flashInterval;
    /*0x210*/ float flashTime;

    /*0x359e40*/ PotatoNut();
    /*0x359d10*/ void Update();
    /*0x359920*/ void ReplaceSprite();
    /*0x359790*/ void DieEvent(Plant.DieReason reason);
    /*0x3597a0*/ void Explode(int dmg, bool isShake);
    /*0x359c70*/ void SetFlash();
}

class SunBomb : Plant
{
    /*0x348cd0*/ SunBomb();
    /*0x35a140*/ void Start();
    /*0x359e60*/ void Bomb();
    /*0x35a0e0*/ void PlaySoundStart();
}

class SunChomper : Chomper
{
    /*0x3493d0*/ SunChomper();
    /*0x35a450*/ void Swallow();
    /*0x35a330*/ void Produce();
    /*0x35a3e0*/ System.Collections.IEnumerator SunBright();
    /*0x35a1a0*/ void ProduceSun();

    class <SunBright>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SunChomper <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x35c1c0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x35c500*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SunMine : PotatoMine
{
    /*0x35a920*/ SunMine();
    /*0x35a880*/ void Update();
    /*0x35a700*/ void ProducerUpdate();
    /*0x35a810*/ System.Collections.IEnumerator SunBright();
    /*0x35a620*/ void ProduceSun();
    /*0x35a510*/ void DieEvent(Plant.DieReason reason);

    class <SunBright>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SunMine <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x35c340*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x35c4c0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SunNut : Producer
{
    /*0x208*/ bool produceSun1;
    /*0x209*/ bool produceSun2;

    /*0x34b060*/ SunNut();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x35a930*/ void DieEvent(Plant.DieReason reason);
    /*0x35ab00*/ void ReplaceSprite();
    /*0x35a9c0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x35a990*/ void FixedUpdate();
}

class SuperChomper : Chomper
{
    /*0x228*/ System.Collections.Generic.List<UnityEngine.GameObject> changeSprites;
    /*0x230*/ BulletType shootType;
    /*0x234*/ float timer;

    /*0x35bf40*/ SuperChomper();
    /*0x32d010*/ void AttributeEvent();
    /*0x35b320*/ void ChomperSearchZombie(UnityEngine.Collider2D collision);
    /*0x35b820*/ void FirstMeet();
    /*0x35afe0*/ void BiteEvent();
    /*0x35ae80*/ void AnimShoot();
    /*0x35b870*/ void LimHealth();
    /*0x35bef0*/ void Update();
    /*0x35b790*/ void DecreaseHealth();
    /*0x35bea0*/ void TakeDamage(int damage, int damageType);
    /*0x35b890*/ void ReplaceSprite();
    /*0x35b0e0*/ void Bite(Zombie zombie);
}

class AdvancedFurnuce : PineFurnace
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348850*/ AdvancedFurnuce();
    /*0x3484b0*/ void Awake();
    /*0x3482b0*/ void AttributeEvent();
    /*0x3484e0*/ UnityEngine.GameObject InitText();
    /*0x348710*/ void UpdateText();
}

class Bamboo : Plant
{
    /*0x348cd0*/ Bamboo();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x348bf0*/ void ReplaceSprite();
    /*0x348b10*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3488a0*/ void CrashWithZombie(Zombie zombie, float x);
    /*0x348b00*/ bool Instead(int theDamage);
}

class BigChomper : Chomper
{
    /*0x3493d0*/ BigChomper();
    /*0x348ce0*/ void Awake();
    /*0x349340*/ void SetAttackRange();
    /*0x348d20*/ void BiteEvent();
    /*0x348e70*/ bool CheckBoss(Zombie zombie);
    /*0x348ed0*/ void Chomp(Zombie zombie);
}

class BigPumpkin : JackboxPumpkin
{
    /*0x349420*/ BigPumpkin();
    /*0x3493f0*/ void TakeDamage(int damage, int damageType);
}

class BigSunNut : BigWallNut
{
    /*0x349790*/ BigSunNut();
    /*0x349490*/ void Awake();
    /*0x349530*/ void Larger();
    /*0x349430*/ void AttributeEvent();
    /*0x32d010*/ void Round();
}

class BigWallNut : Plant
{
    /*0x208*/ System.Collections.Generic.List<BigWallNut.DamageZombie> damageZombies;

    /*0x349790*/ BigWallNut();
    /*0x349810*/ void Awake();
    /*0x349ee0*/ void Start();
    /*0x349e20*/ void Round();
    /*0x349830*/ void FixedUpdate();
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x349f60*/ void Update();
    /*0x3499a0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x349b30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void Crashed(int type, int soundid, Zombie zombie);
    /*0x32d010*/ void TakeDamage(int damage, int damageType);

    struct DamageZombie
    {
        /*0x10*/ Zombie Zombie;
        /*0x18*/ int dmg;
    }
}

class Blover : Plant
{
    /*0x348cd0*/ Blover();
    /*0x34a6f0*/ void Start();
    /*0x34a440*/ void AnimBlow();
    /*0x34a6d0*/ void DelayDie();
    /*0x34a560*/ void BlowZombie();
}

class BloverPumpkin : Pumpkin
{
    /*0x34a200*/ BloverPumpkin();
    /*0x34a1e0*/ void Start();
    /*0x34a020*/ void AttributeEvent();
}

class BloverUmbrella : Plant
{
    /*0x348cd0*/ BloverUmbrella();
    /*0x34a2e0*/ void Block(Bullet bullet);
    /*0x34a210*/ void BlockBungi(BungiZombie zombie);
}

class CabbageNut : MelonNut
{
    /*0x34a200*/ CabbageNut();
    /*0x34a750*/ BulletType GetBulletType();
    /*0x34a760*/ void SaveDamage(int damage);
}

class CabbageUmbrella : CornUmbrella
{
    /*0x34b060*/ CabbageUmbrella();
    /*0x34ac30*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x34ab80*/ void BlockEffect(Zombie zombie);
    /*0x34a7c0*/ void AdjustBulletSpeed(Bullet bullet);
    /*0x34ada0*/ Zombie UmbrellaSearchZombie();
}

class CactusBlover : Shooter
{
    /*0x34b660*/ CactusBlover();
    /*0x34b570*/ void Start();
    /*0x34b070*/ void BlowZombie();
    /*0x34b410*/ Bullet Shoot1();
    /*0x34b1e0*/ UnityEngine.GameObject SearchZombie();
}

class CactusNut : WallNut
{
    /*0x208*/ System.Collections.Generic.List<UnityEngine.GameObject> changeSprites;

    /*0x34ba40*/ CactusNut();
    /*0x34b8e0*/ void ReplaceSprite();
    /*0x34b670*/ void FixedUpdate();
    /*0x34b840*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class CactusUmbrella : Umbrellaleaf
{
    /*0x34b060*/ CactusUmbrella();
    /*0x34bf90*/ void FixedUpdate();
    /*0x34bac0*/ void ConvertUpdate();
}

class Caltrop : Attacker
{
    /*0x208*/ float range;

    /*0x34d000*/ Caltrop();
    /*0x34cf70*/ void Update();
    /*0x34cda0*/ void ReadyToAttack();
    /*0x34ccb0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x34ca40*/ void KillCar();
    /*0x34c7f0*/ void AnimAttack();
}

class CaltropTorch : Plant
{
    /*0x208*/ int count;

    /*0x348cd0*/ CaltropTorch();
    /*0x34c780*/ void Update();
    /*0x34c050*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x34c310*/ void SummonCaltrop();
    /*0x34bff0*/ void FireUpdate();
    /*0x34c4c0*/ void SummonFire();
}

class CherryBlover : Plant
{
    /*0x208*/ UnityEngine.Transform head;
    /*0x210*/ UnityEngine.Vector3 headOriginalPosition;

    /*0x348cd0*/ CherryBlover();
    /*0x34d200*/ void Awake();
    /*0x34d3f0*/ void FixedUpdate();
    /*0x34d9e0*/ void Update();
    /*0x34d490*/ void MoveUpdate();
    /*0x34d360*/ void Explode(int row);
    /*0x34d9a0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x34d020*/ void AttackUpdate();
    /*0x34d280*/ bool CheckZombie(Zombie zombie);
}

class CherryLittleFly : UltimateLittleFly
{
    /*0x80*/ int dmg;

    /*0x34e420*/ CherryLittleFly();
    /*0x34dc50*/ void Update();
    /*0x34db10*/ void Die();
}

class CherryMagnet : Magnetshroom
{
    /*0x228*/ UnityEngine.Transform attrackCenter;
    /*0x230*/ float gravitationalForce;
    /*0x234*/ float minDistance;
    /*0x238*/ float timer;
    /*0x23c*/ UnityEngine.Vector2 attackPosition;
    /*0x244*/ int targetRow;
    /*0x248*/ int attackCount;

    /*0x34fa50*/ CherryMagnet();
    /*0x34ee00*/ Bucket SetItemUseable(UnityEngine.GameObject obj);
    /*0x34e550*/ Bucket AttrackItem(UnityEngine.GameObject item, int theRow);
    /*0x34e750*/ UnityEngine.Vector2 GetCounterClockwiseVector(UnityEngine.Vector2 originalVector, float angleDegrees);
    /*0x34e5f0*/ void ChangeLayer();
    /*0x34f700*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x34eab0*/ UnityEngine.Rigidbody2D SetAndGetRigidbody2D(UnityEngine.GameObject obj);
    /*0x34eec0*/ void TargetItemUpdate();
    /*0x34f570*/ void Update();
    /*0x34e6c0*/ void DieEvent(Plant.DieReason reason);
    /*0x34e430*/ void AttackUpdate();
    /*0x34e7f0*/ System.Collections.IEnumerator MoveObject(UnityEngine.GameObject obj, UnityEngine.Vector2 targetPosition, float duration);
    /*0x34e840*/ UnityEngine.GameObject SearchZombie();
    /*0x34ed30*/ void SetBucketColor(UnityEngine.Transform gameObject);

    class <MoveObject>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;

        /*0x32f460*/ <MoveObject>d__17(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x35c170*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x35c180*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class CherryMine : Plant
{
    /*0x348cd0*/ CherryMine();
    /*0x34fad0*/ void DieEvent(Plant.DieReason reason);
}

class CherryPot : Pot
{
    /*0x34b060*/ CherryPot();
    /*0x34fee0*/ void RecoverAll();
}

class CherryPumpkin : Pumpkin
{
    /*0x34a200*/ CherryPumpkin();
    /*0x3500c0*/ void ChargeByCherry(int value);
}

class CherryTorch : SquashTorch
{
    /*0x210*/ UnityEngine.GameObject cherryFlyPrefab;
    /*0x218*/ CherryLittleFly[] cherryLittleFlies;

    /*0x350580*/ CherryTorch();
    /*0x350180*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3502e0*/ bool SummonPlant(int dmg);
    /*0x3500f0*/ void DieEvent(Plant.DieReason reason);
}

class CherryUltimatePumpkin : UltimatePumpkin
{
    /*0x350630*/ CherryUltimatePumpkin();
    /*0x3505e0*/ UnityEngine.GameObject GetFly();
    /*0x32d010*/ void AttributeEvent();
}

class CherryUmbrella : CornUmbrella
{
    /*0x218*/ TMPro.TextMeshPro energyText;
    /*0x220*/ TMPro.TextMeshPro energyTextShadow;

    /*0x34b060*/ CherryUmbrella();
    /*0x350750*/ void Block(Bullet bullet);
    /*0x350640*/ void BlockEffect(Zombie zombie);
    /*0x350800*/ UnityEngine.GameObject InitText();
    /*0x3509f0*/ void UpdateText();
}

class Chomper : Attacker
{
    /*0x208*/ UnityEngine.Vector2 pos;
    /*0x210*/ float swallowMaxCountDown;
    /*0x214*/ bool canToChew;
    /*0x218*/ UnityEngine.Vector2 range;
    /*0x220*/ UnityEngine.Vector2 centerOffset;

    /*0x3493d0*/ Chomper();
    /*0x350b10*/ void Awake();
    /*0x351580*/ void UpgradeEvent(int theCurrentLevel);
    /*0x3513f0*/ void SetAttackRange();
    /*0x351550*/ void Update();
    /*0x350af0*/ void AttributeEvent();
    /*0x351480*/ void Swallow();
    /*0x350e90*/ void ChomperSearchZombie(UnityEngine.Collider2D collision);
    /*0x350c80*/ bool CheckZombie(Zombie zombie);
    /*0x3512c0*/ void FixedUpdate();
    /*0x350b40*/ void BiteEvent();
    /*0x350dc0*/ void Chomp(Zombie zombie);
    /*0x350d20*/ void ChompBack();
    /*0x3514f0*/ void ToChew();
    /*0x351370*/ void OnDrawGizmos();
}

class Chrysantheautumn : Plant
{
    /*0x348cd0*/ Chrysantheautumn();
    /*0x3517c0*/ void Awake();
    /*0x351730*/ void AttributeEvent();
    /*0x3515d0*/ void AnimLight();
    /*0x3517e0*/ void DieEvent(Plant.DieReason reason);
}

class CobCannon : Plant
{
    /*0x208*/ bool avaliable;

    /*0x348cd0*/ CobCannon();
    /*0x351a90*/ void Awake();
    /*0x351ae0*/ void FirstMeet();
    /*0x351c60*/ void Start();
    /*0x351c00*/ void StartShoot();
    /*0x351a40*/ void AttributeEvent();
    /*0x351880*/ void AnimShoot();
    /*0x351ba0*/ void ShootSound();
    /*0x351b30*/ void Shoop();
}

class CornUmbrella : Umbrellaleaf
{
    /*0x34b060*/ CornUmbrella();
    /*0x3520b0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x351cb0*/ void BlockEffect(Zombie zombie);
    /*0x351dd0*/ void BlockZombies();
}

class DeathChomper : Plant
{
    /*0x348cd0*/ DeathChomper();
    /*0x3528a0*/ void AttributeEvent();
    /*0x352900*/ void Bite();
    /*0x352270*/ void AnimBite();
    /*0x352960*/ void KillPlant(Plant plant);
    /*0x352b20*/ bool <AnimBite>b__2_0(Plant p);
    /*0x352bf0*/ void <AnimBite>b__2_2();
    /*0x352b70*/ void <AnimBite>b__2_1();

    class <>c__DisplayClass2_0
    {
        /*0x10*/ Plant plant;
        /*0x18*/ DeathChomper <>4__this;
        /*0x20*/ System.Action <>9__3;

        /*0x32f970*/ <>c__DisplayClass2_0();
        /*0x35c720*/ void <AnimBite>b__3();
    }
}

class DiamondPotatoNut : WallNut
{
    /*0x34b060*/ DiamondPotatoNut();
    /*0x352db0*/ void ReplaceSprite();
    /*0x352cc0*/ void DieEvent(Plant.DieReason reason);
    /*0x3531d0*/ void TakeDamage(int damage, int damageType);
}

class DoomBlover : Blover
{
    /*0x208*/ float timer;
    /*0x20c*/ float attackCount;

    /*0x353710*/ DoomBlover();
    /*0x353250*/ void AnimBlow();
    /*0x32d010*/ void DelayDie();
    /*0x3536c0*/ void Update();
    /*0x353620*/ void KeepEffect();
    /*0x353370*/ void BlowEffect();
}

class DoomChomper : Chomper
{
    /*0x3493d0*/ DoomChomper();
    /*0x353730*/ void Awake();
    /*0x353770*/ void Chomp(Zombie zombie);
    /*0x353910*/ System.Collections.IEnumerator Explode();

    class <Explode>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ DoomChomper <>4__this;
        /*0x28*/ int <column>5__2;
        /*0x2c*/ int <i>5__3;

        /*0x32f460*/ <Explode>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x35bfe0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x35c130*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class DoomNut : WallNut
{
    /*0x34b060*/ DoomNut();
    /*0x3539f0*/ void TakeDamage(int damage, int damageType);
    /*0x353980*/ void DieEvent(Plant.DieReason reason);
}

class DoomSeaShroom : Plant
{
    /*0x348cd0*/ DoomSeaShroom();
    /*0x353f60*/ void Eat();
    /*0x353a10*/ void AnimShoot();
    /*0x353e80*/ bool CheckZombie(Zombie zombie);
}

class DoomSeed : Plant
{
    /*0x348cd0*/ DoomSeed();
    /*0x354020*/ void Awake();
    /*0x354250*/ void Update();
    /*0x354040*/ void FixedUpdate();
    /*0x353fb0*/ void AttributeEvent();
}

class DoomTorch : TorchWood
{
    /*0x34b060*/ DoomTorch();
    /*0x354860*/ void Start();
    /*0x3545d0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x354460*/ void AttributeEvent();
    /*0x3544c0*/ void Charge(float timer);
}

class EmeraldUmbrella : SuperUmbrella
{
    /*0x350630*/ EmeraldUmbrella();
    /*0x3551d0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x354ec0*/ void FixedUpdate();
    /*0x354ca0*/ void ConvertUpdate();
    /*0x354ea0*/ void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio);
    /*0x354890*/ void AdjustBulletSpeed(Bullet bullet);
    /*0x354f90*/ Plant GetEmeraldUmbrella();
    /*0x355340*/ void ReinforceBullet(Bullet bullet, int theRow);
    /*0x354f60*/ int GetDamage(int damage);
    /*0x355520*/ Zombie UmbrellaSearchZombie();
}

class EndoFlame : Plant
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ EndoFlame();
    /*0x355fe0*/ void Awake();
    /*0x356470*/ void FixedUpdate();
    /*0x356190*/ void FireBullets();
    /*0x356000*/ void DieEvent(Plant.DieReason reason);
    /*0x356490*/ UnityEngine.GameObject InitText();
    /*0x356680*/ void UpdateText();
}

class EndoFlameGirl : Shooter
{
    /*0x210*/ System.Collections.Generic.List<UnityEngine.Transform> shoots;

    /*0x355f60*/ EndoFlameGirl();
    /*0x355a90*/ Bullet Shoot1();
    /*0x3557f0*/ void PlantShootUpdate();
    /*0x3558f0*/ UnityEngine.GameObject SearchZombie();

    class <>c__DisplayClass1_0
    {
        /*0x10*/ PlantType item;

        /*0x32f970*/ <>c__DisplayClass1_0();
        /*0x35c700*/ bool <Shoot1>b__0(Plant p);
    }
}

class FireCannon : CobCannon
{
    /*0x348cd0*/ FireCannon();
    /*0x356780*/ void AnimShoot();
}

class FireSpikeRock : SpikeRock
{
    /*0x356b90*/ FireSpikeRock();
    /*0x356940*/ void AnimAttack();
}

class FrozenPear : Plant
{
    /*0x208*/ UnityEngine.GameObject changeSprite;

    /*0x348cd0*/ FrozenPear();
    /*0x356da0*/ void Awake();
    /*0x356d20*/ void AttributeEvent();
    /*0x356ed0*/ void ReplaceSprite();
    /*0x356de0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x356dc0*/ void FixedUpdate();
    /*0x356c00*/ void AnimShoot();
    /*0x356ba0*/ void Action(Zombie zombie);
}

class Garlic : WallNut
{
    /*0x34b060*/ Garlic();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x357420*/ void AnimSuperShoot();
}

class GarlicBlover : Blover
{
    /*0x348cd0*/ GarlicBlover();
    /*0x357000*/ void BlowZombie();
}

class GarlicUltimateChomper : UltimateChomper
{
    /*0x357310*/ GarlicUltimateChomper();
    /*0x3571c0*/ void AnimShoot();
}

class GarlicUmbrella : CornUmbrella
{
    /*0x34b060*/ GarlicUmbrella();
    /*0x357320*/ void BlockEffect(Zombie zombie);
}

class GoldHypnoDoom : Plant
{
    /*0x348cd0*/ GoldHypnoDoom();
    /*0x356da0*/ void Awake();
    /*0x3575e0*/ void AttributeEvent();
    /*0x357c50*/ void SummonZombie(ZombieType bossType);
}

class GoldMagnet : Plant
{
    /*0x208*/ int attrackCount;

    /*0x348cd0*/ GoldMagnet();
    /*0x358270*/ void Awake();
    /*0x358210*/ void AttributeEvent();
    /*0x358020*/ void AttrackOver();
    /*0x357fa0*/ void AnimAttrack();
    /*0x358290*/ void FixedUpdate();
    /*0x3581a0*/ bool Attrackable(Bullet bullet);
}

class GoldNut : WallNut
{
    /*0x34b060*/ GoldNut();
    /*0x35c7f0*/ void Start();
    /*0x35c810*/ bool SuperSkill();
}

class GoldThreeTorch : TorchWood
{
    /*0x34b060*/ GoldThreeTorch();
    /*0x35cb40*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x35c950*/ void FireBullet(Bullet bullet);
    /*0x35ce20*/ void SetBullet(int theRow, BulletType theBulletType, float theDamage, float speed, int theMoveWay, float offset);
}

class Gravebuster : Plant
{
    /*0x208*/ UnityEngine.Coroutine bust;

    /*0x348cd0*/ Gravebuster();
    /*0x35d2f0*/ void Start();
    /*0x35cf70*/ void AnimBustUp();
    /*0x35d350*/ GridItem get_GridItem_();
    /*0x35d0a0*/ System.Collections.IEnumerator Busting();
    /*0x35d110*/ void DieEvent(Plant.DieReason reason);
    /*0x35d210*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);

    class <Busting>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Gravebuster <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x32f460*/ <Busting>d__5(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3708e0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x370f70*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class HugeWallNut : WallNut
{
    /*0x34b060*/ HugeWallNut();
    /*0x3517c0*/ void Awake();
    /*0x35d450*/ void AttributeEvent();
    /*0x35d470*/ void CheckNut();
    /*0x35d5c0*/ void TakeDamage(int damage, int damageType);
}

class HypnoBlover : Blover
{
    /*0x208*/ float dragSpeed;

    /*0x35dd90*/ HypnoBlover();
    /*0x35d690*/ void AnimBlow();
    /*0x35dd50*/ void Update();
    /*0x35d7c0*/ void DragZombieUpdate(bool dmg);
}

class HypnoGarlic : Plant
{
    /*0x208*/ UnityEngine.LayerMask m;

    /*0x348cd0*/ HypnoGarlic();
    /*0x35df70*/ void Awake();
    /*0x35ddb0*/ void AttributeEvent();
}

class HypnoMagnet : Plant
{
    /*0x208*/ BucketType itemType;

    /*0x348cd0*/ HypnoMagnet();
    /*0x35e480*/ void Summon(BucketType type);
    /*0x35e4f0*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x35e020*/ void AnimSummon();
}

class HypnoNut : WallNut
{
    /*0x208*/ int[] hyponos;

    /*0x35ea60*/ HypnoNut();
    /*0x35e720*/ void Awake();
    /*0x35e5e0*/ void AttributeEvent();
    /*0x35e740*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class HypnoPumpkin : Pumpkin
{
    /*0x208*/ UnityEngine.GameObject[] mushes;
    /*0x210*/ UnityEngine.LayerMask m_layer;
    /*0x218*/ Zombie m_zombie;

    /*0x35f630*/ HypnoPumpkin();
    /*0x35eac0*/ void Awake();
    /*0x35eb70*/ void FixedUpdate();
    /*0x35ef50*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x35f510*/ void Update();
    /*0x35f450*/ void TakeDamage(int damage, int damageType);
    /*0x35ee90*/ bool Instead(int theDamage);
    /*0x35ef90*/ void ReplaceSprite();
}

class HypnoQueen : HyponoEmperor
{
    /*0x35fe60*/ HypnoQueen();
    /*0x35fad0*/ void Summon();
    /*0x35f690*/ void DieEvent(Plant.DieReason reason);
    /*0x35f870*/ void SummonUpdate();
}

class HypnoSquash : Squash
{
    /*0x35fef0*/ HypnoSquash();
    /*0x35fe80*/ void ActionOnZombie(Zombie zombie);
}

class HyponoEmperor : Plant
{
    /*0x208*/ int restHealth;
    /*0x20c*/ float summonZombieTime;

    /*0x35fe60*/ HyponoEmperor();
    /*0x360130*/ void Start();
    /*0x3600e0*/ void FirstMeet();
    /*0x3609a0*/ void Update();
    /*0x360600*/ void SummonUpdate();
    /*0x360770*/ void Summon();
    /*0x3608e0*/ void Summon_skin();
    /*0x360230*/ void SummonNormal();
    /*0x360410*/ void SummonStronger();
    /*0x35ff00*/ void DieEvent(Plant.DieReason reason);
}

class IceBean : Plant
{
    /*0x348cd0*/ IceBean();
}

class IceBlover : DoomBlover
{
    /*0x360e00*/ IceBlover();
    /*0x360be0*/ void KeepEffect();
    /*0x360a50*/ void BlowEffect();
}

class IceCaltrop : Caltrop
{
    /*0x361060*/ IceCaltrop();
    /*0x360e10*/ void AnimAttack();
}

class IceCannon : CobCannon
{
    /*0x34b060*/ IceCannon();
    /*0x361070*/ void AnimShoot();
}

class IceHypno : Plant
{
    /*0x348cd0*/ IceHypno();
}

class IceLotus : Plant
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ IceLotus();
    /*0x361500*/ void Awake();
    /*0x361470*/ void AttributeEvent();
    /*0x361520*/ void Charge();
    /*0x361230*/ void AnimRecover();
    /*0x3615a0*/ UnityEngine.GameObject InitText();
    /*0x361790*/ void UpdateText();
}

class IcePot : Pot
{
    /*0x210*/ float coolTimer;

    /*0x34b060*/ IcePot();
    /*0x361890*/ void Update();
}

class IceSeaShroom : Plant
{
    /*0x348cd0*/ IceSeaShroom();
    /*0x361f60*/ void Eat();
    /*0x361ca0*/ void AnimEat();
}

class IceShroom : Plant
{
    /*0x208*/ float ExplodeCountDown;

    /*0x362060*/ IceShroom();
    /*0x361fb0*/ void Update();
}

class IceSpikeRock : SpikeRock
{
    /*0x356b90*/ IceSpikeRock();
    /*0x362080*/ void AnimAttack();
}

class IceSquash : Squash
{
    /*0x35fef0*/ IceSquash();
    /*0x3622d0*/ void AttackZombie();
}

class IceTorch : TorchWood
{
    /*0x34b060*/ IceTorch();
    /*0x362570*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x362ad0*/ void TurnAtoB(Bullet bullet, BulletType newBulletType, int damage);
}

class IFVPumpkin : Pumpkin
{
    /*0x34a200*/ IFVPumpkin();
}

class Imitater : Present
{
    /*0x34b060*/ Imitater();
    /*0x356da0*/ void Awake();
    /*0x362c50*/ void AnimExplode();
    /*0x363160*/ void AttributeEvent();
}

class JackboxPumpkin : MagnetPumpkin
{
    /*0x34a200*/ JackboxPumpkin();
    /*0x3631c0*/ void TakeDamage(int damage, int damageType);
}

class JalaMine : Plant
{
    /*0x348cd0*/ JalaMine();
    /*0x3631d0*/ void DieEvent(Plant.DieReason reason);
}

class JalaSpike : Caltrop
{
    /*0x361060*/ JalaSpike();
    /*0x363500*/ void AnimAttack();
}

class JalaSquash : Squash
{
    /*0x35fef0*/ JalaSquash();
    /*0x3637a0*/ void Awake();
    /*0x363750*/ void AttackZombie();
}

class JalaTorch : TorchWood
{
    /*0x34b060*/ JalaTorch();
    /*0x363820*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3637d0*/ void DieEvent(Plant.DieReason reason);
}

class KelpNut : Plant
{
    /*0x208*/ UnityEngine.GameObject crack;
    /*0x210*/ UnityEngine.GameObject arm1;
    /*0x218*/ UnityEngine.GameObject arm2;

    /*0x348cd0*/ KelpNut();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x363980*/ void ReplaceSprite();
    /*0x363910*/ void Crashed(int level, int soundID, Zombie zombie);
}

class LanternBlover : Blover
{
    /*0x34b060*/ LanternBlover();
    /*0x363aa0*/ void AnimBlow();
}

class LanternChomper : Chomper
{
    /*0x363f80*/ LanternChomper();
    /*0x363ae0*/ void Chomp(Zombie zombie);
    /*0x363b40*/ void SwallowEvent();
}

class LanternMagnet : Magnetshroom
{
    /*0x228*/ UnityEngine.ParticleSystem lightShine;

    /*0x3644c0*/ LanternMagnet();
    /*0x364230*/ void Awake();
    /*0x364380*/ void MagnetUpdate();
    /*0x3643d0*/ void SetRange();
    /*0x363f90*/ Bucket AttrackItem(UnityEngine.GameObject item, int theRow);
}

class LanternNut : WallNut
{
    /*0x208*/ UnityEngine.GameObject lanternLight;
    /*0x210*/ UnityEngine.Vector3 lightPos;

    /*0x34b060*/ LanternNut();
    /*0x3644f0*/ void AttributeEvent();
    /*0x364730*/ void Start();
    /*0x364930*/ void Update();
    /*0x364540*/ void DieEvent(Plant.DieReason reason);
    /*0x364670*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3645e0*/ void OnCreate(int theColumn, int theRow);
}

class LanternPot : Pot
{
    /*0x34b060*/ LanternPot();
    /*0x364ae0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x364a50*/ void OnCreate(int theColumn, int theRow);
    /*0x3649d0*/ void DieEvent(Plant.DieReason reason);
}

class LanternPumpkin : Pumpkin
{
    /*0x34a200*/ LanternPumpkin();
    /*0x364d60*/ void Start();
    /*0x364ba0*/ void DieEvent(Plant.DieReason reason);
    /*0x364ca0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x364c10*/ void OnCreate(int theColumn, int theRow);
    /*0x3644f0*/ void AttributeEvent();
}

class LanternUmbrella : CornUmbrella
{
    /*0x218*/ float recoverEnergyTimer;
    /*0x21c*/ int maxEnergy;
    /*0x220*/ TMPro.TextMeshPro energyText;
    /*0x228*/ TMPro.TextMeshPro energyTextShadow;
    /*0x230*/ UnityEngine.GameObject lanternLight;
    /*0x238*/ UnityEngine.Vector3 lightPos;
    /*0x248*/ UnityEngine.ParticleSystem par;

    /*0x365c80*/ LanternUmbrella();
    /*0x3650f0*/ void Awake();
    /*0x365120*/ void BlockEffect(Zombie zombie);
    /*0x365750*/ void Start();
    /*0x364d80*/ void AdjustEnergy(int cost);
    /*0x3652a0*/ int GetDamage(int damage);
    /*0x365bd0*/ void Update();
    /*0x365690*/ void RecoverEnergyUpdate();
    /*0x365200*/ void DieEvent(Plant.DieReason reason);
    /*0x3655d0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x365540*/ void OnCreate(int theColumn, int theRow);
    /*0x365300*/ UnityEngine.GameObject InitText();
    /*0x365a20*/ void UpdateEnergyText();
}

class LaserUmbrella : LanternUmbrella
{
    /*0x250*/ Zombie[] targetZombies;
    /*0x258*/ Plant[] targetPlants;
    /*0x260*/ UnityEngine.LineRenderer[] theLight;
    /*0x268*/ UnityEngine.ParticleSystem[] particleSystems;
    /*0x270*/ UnityEngine.Rendering.SortingGroup[] sortingGroups;
    /*0x278*/ UnityEngine.GameObject theLightPrefab;
    /*0x280*/ UnityEngine.GameObject ballPrefab;
    /*0x288*/ UnityEngine.GameObject lightBall;
    /*0x290*/ bool main;
    /*0x294*/ float explodeTimer;
    /*0x298*/ float healTimer;

    /*0x3686f0*/ LaserUmbrella();
    /*0x366180*/ void Awake();
    /*0x3673a0*/ void OnDestroy();
    /*0x367130*/ void HealUpdate();
    /*0x367840*/ void Start();
    /*0x368260*/ void Update();
    /*0x366ee0*/ void Explode(UnityEngine.Vector2 position, int row);
    /*0x3674e0*/ void SearchPlant();
    /*0x366cc0*/ void DieEvent(Plant.DieReason reason);
    /*0x367460*/ void PlantShootUpdate();
    /*0x367650*/ void SearchZombieUpdate();
    /*0x366510*/ bool CheckZombie(Zombie zombie);
    /*0x366470*/ bool CheckAir(Zombie zombie);
    /*0x3664b0*/ bool CheckLand(Zombie zombie);
    /*0x365f90*/ void AttackZombie();
    /*0x3678b0*/ void UpdateLight();
    /*0x3664f0*/ bool CheckPlant(Plant plant);
    /*0x365e10*/ bool AddZombie(Zombie zombie);
    /*0x365ca0*/ bool AddPlant(Plant plant);
    /*0x366610*/ void Connected(Plant plant);
    /*0x366e00*/ void DisConnected();
}

class LilyPad : Plant
{
    /*0x208*/ UnityEngine.BoxCollider2D[] col;
    /*0x210*/ UnityEngine.SpriteRenderer r;
    /*0x218*/ float growTime;

    /*0x348cd0*/ LilyPad();
    /*0x368e40*/ void Start();
    /*0x369240*/ void Update();
    /*0x368f20*/ void SummonUpdate();
    /*0x368a10*/ void MixUpdate();
    /*0x3689e0*/ void FixedUpdate();
    /*0x3691d0*/ void TakeDamage(int damage, int damageType);
    /*0x368880*/ void ChangeSprite(PlantType type);
    /*0x368830*/ bool AllowChange(PlantType theSeedType);
}

class LotusAloes : Plant
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ LotusAloes();
    /*0x3695e0*/ void Awake();
    /*0x369550*/ void AttributeEvent();
    /*0x3692e0*/ void AnimShoot();
    /*0x369600*/ UnityEngine.GameObject InitText();
    /*0x3697f0*/ void UpdateText();
}

class LotusBamboo : Bamboo
{
    /*0x34b060*/ LotusBamboo();
    /*0x356da0*/ void Awake();
    /*0x3698f0*/ void AttributeEvent();
    /*0x369970*/ void CrashWithZombie(Zombie zombie, float x);
    /*0x3699c0*/ int get_NearCount();
    /*0x369950*/ void Charge();

    class <>c
    {
        static /*0x0*/ LotusBamboo.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__4_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__4_1;
        static /*0x18*/ System.Func<Plant, bool> <>9__4_2;
        static /*0x20*/ System.Func<Plant, bool> <>9__4_3;

        static /*0x3715d0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3713d0*/ bool <get_NearCount>b__4_0(Plant p);
        /*0x371450*/ bool <get_NearCount>b__4_1(Plant p);
        /*0x3714d0*/ bool <get_NearCount>b__4_2(Plant p);
        /*0x371550*/ bool <get_NearCount>b__4_3(Plant p);
    }
}

class LotusSpruce : Plant
{
    /*0x208*/ float recoverTimer;
    /*0x210*/ TMPro.TextMeshPro energyText;
    /*0x218*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ LotusSpruce();
    /*0x361500*/ void Awake();
    /*0x369e90*/ void AnimShoot();
    /*0x369fc0*/ void AttributeEvent();
    /*0x36a680*/ void Update();
    /*0x36a050*/ void Charge();
    /*0x36a2d0*/ void Recover();
    /*0x36a0e0*/ UnityEngine.GameObject InitText();
    /*0x36a580*/ void UpdateText();
}

class LuckyBlover : Plant
{
    static /*0x0*/ bool lucky;

    /*0x348cd0*/ LuckyBlover();
    /*0x36a7d0*/ void Start();
    /*0x36a6f0*/ void AnimBlow();
    /*0x34a6d0*/ void DelayDie();
}

class MachineNut : WallNut
{
    /*0x208*/ int machineType;

    /*0x34b060*/ MachineNut();
    /*0x36a8f0*/ void TurnStatus(int type);
    /*0x36a830*/ void DieEvent(Plant.DieReason reason);
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x35b870*/ void LimHealth();
    /*0x36a8e0*/ void TakeDamage(int damage, int damageType);
}

class MagnetBlover : Magnetshroom
{
    /*0x3644c0*/ MagnetBlover();
    /*0x36b6a0*/ void Start();
    /*0x36b050*/ void AnimBlow();
    /*0x34a6d0*/ void DelayDie();
    /*0x36b170*/ void BlowZombie();
    /*0x36b2e0*/ void MoveIronItem();
    /*0x36b3f0*/ void SearchZombieWithIron();
}

class MagnetBox : Plant
{
    /*0x208*/ int value;
    /*0x20c*/ int outPutCount;
    /*0x210*/ TMPro.TextMeshPro valueText;
    /*0x218*/ System.Collections.Generic.List<MagnetInterface> interfaces;

    /*0x36c110*/ MagnetBox();
    /*0x3517c0*/ void Awake();
    /*0x36c040*/ void Update();
    /*0x36be40*/ void Start();
    /*0x36b820*/ void InitValueText();
    /*0x36b7f0*/ void AttributeEvent();
    /*0x36c0f0*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x36b710*/ void AddMagnet(BucketType bucketType, Bucket item);
    /*0x36be60*/ void UpdateMagnetCount(int count);
    /*0x36bb50*/ void InterfaceUpdate();
}

class MagnetInterface : Plant
{
    /*0x208*/ int energy;
    /*0x20c*/ int fullEnergy;
    /*0x210*/ BucketType setType;
    /*0x218*/ TMPro.TextMeshPro valueText;
    /*0x220*/ UnityEngine.GameObject theBucket;

    /*0x36ce40*/ MagnetInterface();
    /*0x36ca70*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x36c990*/ int Supply(int value);
    /*0x356da0*/ void Awake();
    /*0x36c1a0*/ void AttributeEvent();
    /*0x36c9c0*/ void Update();
    /*0x36c970*/ void Start();
    /*0x36c640*/ void InitValueText();

    class <>c
    {
        static /*0x0*/ MagnetInterface.<> <>9;
        static /*0x8*/ System.Func<Plant, int> <>9__8_0;
        static /*0x10*/ System.Func<Plant, int> <>9__8_1;
        static /*0x18*/ System.Func<Plant, int> <>9__8_2;
        static /*0x20*/ System.Func<Plant, int> <>9__8_3;

        static /*0x371640*/ <>c();
        /*0x32f970*/ <>c();
        /*0x371260*/ int <AttributeEvent>b__8_0(Plant p);
        /*0x371280*/ int <AttributeEvent>b__8_1(Plant p);
        /*0x3712f0*/ int <AttributeEvent>b__8_2(Plant p);
        /*0x371360*/ int <AttributeEvent>b__8_3(Plant p);
    }
}

class MagnetNut : WallNut
{
    /*0x208*/ System.Collections.Generic.List<Bullet> bullets;
    /*0x210*/ float R;
    /*0x214*/ float V;

    /*0x36d780*/ MagnetNut();
    /*0x36cfb0*/ void FixedUpdate();
    /*0x36d020*/ void SearchBullet();
    /*0x36ce60*/ void DieEvent(Plant.DieReason reason);
    /*0x36d410*/ void Update();
}

class MagnetPumpkin : Pumpkin
{
    /*0x34a200*/ MagnetPumpkin();
    /*0x36ddb0*/ void Start();
    /*0x36d820*/ void AttributeEvent();
}

class Magnetshroom : Plant
{
    /*0x208*/ BucketType attrackType;
    /*0x210*/ UnityEngine.GameObject targetItem;
    /*0x218*/ float attrackRange;
    /*0x21c*/ float attrackMaxTime;
    /*0x220*/ float rangeRow;
    /*0x224*/ UnityEngine.LayerMask magnetLayer;

    /*0x3644c0*/ Magnetshroom();
    /*0x36e790*/ void Awake();
    /*0x36eb80*/ void FixedUpdate();
    /*0x36ec20*/ void MagnetUpdate();
    /*0x36edf0*/ void SearchZombieWithIron();
    /*0x36f3a0*/ bool TryAttrackZombie(Zombie zombie);
    /*0x348b00*/ bool MoreAttrack(Zombie zombie);
    /*0x36ddd0*/ Bucket AttrackItem(UnityEngine.GameObject item, int theRow);
    /*0x36e860*/ void ChangeLayer();
    /*0x36ec50*/ void MoveIronItem();
    /*0x36f320*/ Bucket SetItemUseable(UnityEngine.GameObject obj);
    /*0x36ed50*/ System.Collections.IEnumerator MoveObject(UnityEngine.GameObject obj, UnityEngine.Vector2 targetPosition, float duration);
    /*0x36e3a0*/ void AttributeEvent();
    /*0x36ea00*/ void DieEvent(Plant.DieReason reason);

    class <MoveObject>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.GameObject obj;
        /*0x28*/ float duration;
        /*0x2c*/ UnityEngine.Vector2 targetPosition;
        /*0x34*/ UnityEngine.Vector2 <startPosition>5__2;
        /*0x3c*/ float <elapsedTime>5__3;

        /*0x32f460*/ <MoveObject>d__16(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x370fb0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x371220*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MelonCannon : CobCannon
{
    /*0x34b060*/ MelonCannon();
    /*0x36f960*/ void AnimShoot();
    /*0x36fb70*/ void AttributeEvent();
}

class MelonNut : WallNut
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x34b060*/ MelonNut();
    /*0x3707a0*/ void TakeDamage(int damage, int damageType);
    /*0x370600*/ void SaveDamage(int damage);
    /*0x36ffc0*/ void FixedUpdate();
    /*0x370680*/ void SearchUpdate();
    /*0x370370*/ System.Collections.IEnumerator GetTempShield(int value);
    /*0x3705e0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x370120*/ Zombie GetTargetZombie();
    /*0x370110*/ BulletType GetBulletType();
    /*0x36fbc0*/ void AnimShoot();
    /*0x3703f0*/ UnityEngine.GameObject InitText();
    /*0x3707e0*/ void UpdateText();

    class <GetTempShield>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ MelonNut <>4__this;
        /*0x28*/ int value;
        /*0x2c*/ int <max>5__2;

        /*0x32f460*/ <GetTempShield>d__4(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3851b0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x385300*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MelonUmbrella : CornUmbrella
{
    /*0x218*/ int storgedDamage;

    /*0x34a200*/ MelonUmbrella();
    /*0x371b30*/ void Block(Bullet bullet);
    /*0x371780*/ void BlockZombies();
}

class MixBomb : Plant
{
    /*0x348cd0*/ MixBomb();
    /*0x372dd0*/ void Awake();
    /*0x371cf0*/ void AttributeEvent();

    class <>c__DisplayClass1_0
    {
        /*0x10*/ Plant plant;

        /*0x32f970*/ <>c__DisplayClass1_0();
        /*0x3859d0*/ bool <AttributeEvent>b__0(Plant p);
        /*0x3859d0*/ bool <AttributeEvent>b__1(Plant p);
    }
}

class MoneyUmbrella : CornUmbrella
{
    /*0x34a200*/ MoneyUmbrella();
    /*0x3734e0*/ void Block(Bullet bullet);
    /*0x373400*/ void BlockEffect(Zombie zombie);
    /*0x3737b0*/ bool SuperSkill();
    /*0x372df0*/ void AnimSuperShoot();
    /*0x32d010*/ void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio);
    /*0x373670*/ void OnCreate(int theColumn, int theRow);
}

class NutBlover : Plant
{
    /*0x348cd0*/ NutBlover();
    /*0x3739a0*/ void ReplaceSprite();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x373940*/ void FixedUpdate();
}

class NutPumpkin : Pumpkin
{
    /*0x208*/ UnityEngine.GameObject nut;

    /*0x34b060*/ NutPumpkin();
    /*0x373a50*/ void Awake();
    /*0x373a70*/ void Update();
}

class NutTorch : SquashTorch
{
    /*0x34b060*/ NutTorch();
    /*0x373f40*/ bool SummonPlant(int dmg);
}

class NutUmbrella : CornUmbrella
{
    /*0x34a200*/ NutUmbrella();
    /*0x374250*/ void BlockEffect(Zombie zombie);
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x374330*/ void ReplaceSprite();
}

class ObsidianJalapeno : Plant
{
    /*0x348cd0*/ ObsidianJalapeno();
    /*0x3517c0*/ void Awake();
    /*0x374820*/ void AttributeEvent();
    /*0x374910*/ void Update();
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x374880*/ void DieEvent(Plant.DieReason reason);
}

class ObsidianPotatoNut : UltimateTallNut
{
    /*0x208*/ float storgedDamage;

    /*0x34b060*/ ObsidianPotatoNut();
    /*0x374b20*/ void TakeDamage(int damage, int damageType);
    /*0x374980*/ void Storge(int damage);
}

class ObsidianSpike : SpikeRock
{
    /*0x361060*/ ObsidianSpike();
    /*0x374ff0*/ void Awake();
    /*0x374fc0*/ void AttributeEvent();
    /*0x375010*/ void TakeDamage(int damage, int damageType);
    /*0x374d00*/ void AnimAttack();
}

class ObsidianWallNut : WallNut
{
    /*0x34b060*/ ObsidianWallNut();
    /*0x374ff0*/ void Awake();
    /*0x3750b0*/ void AttributeEvent();
    /*0x3750e0*/ void TakeDamage(int damage, int damageType);
}

class PassionFruit : Shooter
{
    /*0x34b660*/ PassionFruit();
    /*0x3752b0*/ Bullet Shoot1();
    /*0x375190*/ void AnimSuperShoot();
}

class PeaBlover : Shooter
{
    /*0x34b660*/ PeaBlover();
    /*0x3753d0*/ Bullet Shoot1();
    /*0x3754f0*/ void UpdateInterval();
}

class PeaPumpkin : Pumpkin
{
    /*0x208*/ System.Collections.Generic.Dictionary<PlantType, int> PeaPlant;

    /*0x375bf0*/ PeaPumpkin();
    /*0x356da0*/ void Awake();
    /*0x3759f0*/ void AttributeEvent();
    /*0x375710*/ void AnimShoot();
}

class PineFurnace : Plant
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, PlantType> mixDic;

    static /*0x376410*/ PineFurnace();
    /*0x348cd0*/ PineFurnace();
    /*0x3763f0*/ void Awake();
    /*0x375f50*/ void AttributeEvent();
}

class Plantern : Plant
{
    /*0x208*/ UnityEngine.GameObject lanternLight;
    /*0x210*/ UnityEngine.Vector3 lightPos;

    /*0x348cd0*/ Plantern();
    /*0x376740*/ void Start();
    /*0x364930*/ void Update();
    /*0x376550*/ void DieEvent(Plant.DieReason reason);
    /*0x376680*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3765f0*/ void OnCreate(int theColumn, int theRow);
}

class PortalNut : WallNut
{
    /*0x208*/ float snapshotInterval;
    /*0x20c*/ float lastSnapshotTime;
    /*0x210*/ System.Collections.Generic.List<System.ValueTuple<float, int>> healthSnapshots;
    /*0x218*/ bool restored;
    /*0x21c*/ float invincibleTimer;

    /*0x376da0*/ PortalNut();
    /*0x376940*/ void Die(Plant.DieReason reason);
    /*0x3769e0*/ void Revive();
    /*0x376cf0*/ void TakeDamage(int damage, int damageType);
    /*0x376d10*/ void Update();
    /*0x376ae0*/ void SnapShot(int health);
    /*0x376970*/ void RestoreHealthFromSnapshot();
}

class Pot : Plant
{
    /*0x208*/ bool carry;
    /*0x209*/ bool lowerPot;

    /*0x348cd0*/ Pot();
    /*0x376e30*/ void Awake();
    /*0x3770b0*/ void FixedUpdate();
    /*0x376e50*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x377bb0*/ void TakeDamage(int damage, int damageType);
    /*0x377470*/ void OnCreate(int theColumn, int theRow);
    /*0x3776f0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x376e70*/ void DieEvent(Plant.DieReason reason);
    /*0x377be0*/ void UniqueEffect(int theColumn, int theRow);
}

class PotatoPumpkin : Pumpkin
{
    /*0x34b060*/ PotatoPumpkin();
    /*0x378100*/ void ReplaceSprite();
    /*0x377fc0*/ void Explode(int damage);
    /*0x377fb0*/ void DieEvent(Plant.DieReason reason);
}

class Present : Plant
{
    /*0x208*/ bool buff;

    /*0x348cd0*/ Present();
    /*0x3795c0*/ void Start();
    /*0x378700*/ void AnimEvent();
    /*0x378ad0*/ void RandomPlant();
    /*0x3787c0*/ void HappyRandomPlant();
    /*0x3794a0*/ bool SetLevelPlant(int theColumn, int theRow, PlantType theSeedType, int level);
    /*0x379630*/ void SuperRandomPlant();
    /*0x379b70*/ bool TowerLim(PlantType theSeedType);

    class <>c
    {
        static /*0x0*/ Present.<> <>9;
        static /*0x8*/ System.Func<PlantType, bool> <>9__3_0;
        static /*0x10*/ System.Func<PlantType, bool> <>9__3_1;
        static /*0x18*/ System.Predicate<PlantType> <>9__6_0;

        static /*0x385a20*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3858b0*/ bool <RandomPlant>b__3_0(PlantType p);
        /*0x385900*/ bool <RandomPlant>b__3_1(PlantType p);
        /*0x385950*/ bool <SuperRandomPlant>b__6_0(PlantType p);
    }
}

class PresentZombie : Plant
{
    /*0x348cd0*/ PresentZombie();
    /*0x3786a0*/ void Start();
    /*0x378460*/ void AnimEvent();
}

class Prismflower : Attacker
{
    /*0x208*/ UnityEngine.GameObject prism;

    /*0x34b060*/ Prismflower();
    /*0x356da0*/ void Awake();
    /*0x37adc0*/ void AttributeEvent();
    /*0x37b6f0*/ void SetBrightness(float b);
    /*0x37aa30*/ void AttackOtherZombie(Zombie basicZombie, UnityEngine.Vector2 center, int damage);
    /*0x37ae00*/ UnityEngine.GameObject CreateLine(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 endPosition, float width);
    /*0x379bf0*/ void AnimShoot();
    /*0x37b280*/ void SearchZombieUpdate();
    /*0x37b050*/ System.Collections.Generic.List<Plant> GetOtherPrismflowers();
    /*0x37b880*/ bool <GetOtherPrismflowers>b__8_0(Plant n);
}

class PuffSeaShroom : SmallPuff
{
    /*0x210*/ System.Collections.Generic.List<UnityEngine.Transform> shoots;
    /*0x218*/ System.Collections.Generic.List<UnityEngine.GameObject> head;

    /*0x37bbf0*/ PuffSeaShroom();
    /*0x374ff0*/ void Awake();
    /*0x37b8b0*/ void AttributeEvent();
    /*0x37ba60*/ Bullet Shoot1();
}

class Pumpkin : WallNut
{
    /*0x34b060*/ Pumpkin();
    /*0x37bcc0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class RedEmeraldUmbrella : EmeraldUmbrella
{
    /*0x37c180*/ RedEmeraldUmbrella();
    /*0x32d010*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x37be70*/ void Block(Bullet bullet);
    /*0x37c160*/ void TakeDamage(int damage, int damageType);
}

class SeaBlover : Blover
{
    /*0x34b060*/ SeaBlover();
    /*0x37c190*/ void BlowZombie();
}

class SeaHypno : Plant
{
    /*0x348cd0*/ SeaHypno();
    /*0x37c450*/ void Eat();
    /*0x37c310*/ void AnimEat();
}

class SeaLantern : Plantern
{
    /*0x220*/ bool isGrowen;

    /*0x348cd0*/ SeaLantern();
    /*0x37ca70*/ void Start();
    /*0x37c4a0*/ void AttributeEvent();
    /*0x37c720*/ void Grow();
    /*0x37c660*/ void DieEvent(Plant.DieReason reason);
    /*0x37c950*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x37c8d0*/ void OnCreate(int theColumn, int theRow);
}

class SeaMagnet : Magnetshroom
{
    /*0x228*/ int attractTime;
    /*0x22c*/ bool isGrown;

    /*0x37cde0*/ SeaMagnet();
    /*0x37cc70*/ void AttributeEvent();
    /*0x37cd40*/ void Grow();
}

class SeaNut : WallNut
{
    /*0x208*/ UnityEngine.Vector2 originalScale;

    /*0x34b060*/ SeaNut();
    /*0x361500*/ void Awake();
    /*0x32d010*/ void ReplaceSprite();
    /*0x37cdf0*/ void AttributeEvent();
    /*0x37d120*/ void Start();
    /*0x37cf00*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x37d040*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x37d1a0*/ void Update();
    /*0x37d180*/ void TakeDamage(int damage, int damageType);
    /*0x37cee0*/ void Crashed(int level, int soundID, Zombie zombie);
}

class ShulkBamboo : Bamboo
{
    /*0x34b060*/ ShulkBamboo();
    /*0x356da0*/ void Awake();
    /*0x37d3a0*/ void AttributeEvent();
}

class Shulkflower : Shooter
{
    /*0x34b660*/ Shulkflower();
    /*0x376e30*/ void Awake();
    /*0x37da10*/ void FixedUpdate();
    /*0x37d9c0*/ void AttributeEvent();
    /*0x37d790*/ void AttackUpdate();
    /*0x37d630*/ void AttackEffect(System.Collections.Generic.List<Zombie> zombies);
    /*0x37dbe0*/ void SearchUpdate();
    /*0x37da40*/ void OnDrawGizmosSelected();
}

class ShulkLotus : IceLotus
{
    /*0x34b060*/ ShulkLotus();
    /*0x37d3e0*/ void AnimRecover();
}

class SmallIceShroom : Plant
{
    /*0x348cd0*/ SmallIceShroom();
    /*0x37dde0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class SmallUmbrella : Plant
{
    /*0x348cd0*/ SmallUmbrella();
    /*0x354020*/ void Awake();
    /*0x37e3b0*/ void AttributeEvent();
    /*0x37e450*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x37e080*/ void AnimBlock();
}

class SnowPresent : Present
{
    /*0x348cd0*/ SnowPresent();
    /*0x37e560*/ void AnimEvent();

    class <>c
    {
        static /*0x0*/ SnowPresent.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__0_0;
        static /*0x10*/ System.Predicate<PlantType> <>9__0_1;

        static /*0x385a90*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3856b0*/ bool <AnimEvent>b__0_0(PlantType p);
        /*0x385830*/ bool <AnimEvent>b__0_1(PlantType p);
    }
}

class SolarPad : LilyPad
{
    /*0x34b060*/ SolarPad();
    /*0x37ef70*/ void Produce();
    /*0x37f220*/ void Update();
    /*0x37f0b0*/ void ProducerUpdate();
    /*0x37ea60*/ System.Collections.IEnumerator Bright();
    /*0x37eb80*/ void MixUpdate();
    /*0x37ead0*/ void DieEvent(Plant.DieReason reason);

    class <Bright>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SolarPad <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <Bright>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x384ff0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x385170*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SolarPot : MoneyPot
{
    /*0x34a200*/ SolarPot();
    /*0x37f430*/ void Produce();
    /*0x37f310*/ void MarigoldUpdate();
    /*0x37f260*/ void DieEvent(Plant.DieReason reason);
}

class SpikeRock : Caltrop
{
    /*0x361060*/ SpikeRock();
    /*0x37f5a0*/ void FixedUpdate();
    /*0x37f850*/ void SpriteUpdate();
    /*0x37f5c0*/ void KillCar();
    /*0x37f570*/ void Crashed(int type, int soundID, Zombie zombie);
}

class Squalour : Squash
{
    /*0x240*/ int squashCount;
    /*0x244*/ bool squashed;

    /*0x37fdf0*/ Squalour();
    /*0x32d010*/ void Sound();
    /*0x37fa70*/ void ActionOnZombie(Zombie zombie);
    /*0x37fad0*/ void LourDie();
}

class Squash : Plant
{
    /*0x208*/ UnityEngine.Collider2D[] cols;
    /*0x210*/ bool isJump;
    /*0x218*/ UnityEngine.BoxCollider2D[] boxCols;
    /*0x220*/ UnityEngine.Vector2 range;
    /*0x228*/ float startTime;
    /*0x22c*/ float endTime;
    /*0x230*/ UnityEngine.Vector2 startJumpPos;
    /*0x238*/ UnityEngine.Vector2 endPos;

    /*0x37fdf0*/ Squash();
    /*0x382a10*/ void Start();
    /*0x381f30*/ void FixedUpdate();
    /*0x3824e0*/ void SquashUpdate();
    /*0x382470*/ void Sound();
    /*0x381fe0*/ Zombie GetNearestZombie();
    /*0x381640*/ void ActionOnZombie(Zombie zombie);
    /*0x381990*/ void AttackZombie();
    /*0x382200*/ bool InWater();
    /*0x3822c0*/ System.Collections.IEnumerator MoveToZombie(UnityEngine.Vector3 endPos, float speed);
    /*0x382360*/ void SetTransform(UnityEngine.GameObject plant, UnityEngine.Vector3 position);
    /*0x381ef0*/ float EaseInOut(float t);
    /*0x381680*/ void AnimMove();

    class <MoveToZombie>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Squash <>4__this;
        /*0x28*/ UnityEngine.Vector3 endPos;
        /*0x34*/ float speed;
        /*0x38*/ UnityEngine.Vector3 <startPos>5__2;
        /*0x44*/ float <moveTime>5__3;
        /*0x48*/ float <elapsedTime>5__4;

        /*0x32f460*/ <MoveToZombie>d__16(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x385340*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x385670*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SquashNut : WallNut
{
    /*0x208*/ System.Collections.Generic.List<UnityEngine.Collider2D> collider2Ds;

    /*0x34b060*/ SquashNut();
    /*0x380120*/ void Awake();
    /*0x3801a0*/ void FixedUpdate();
    /*0x3803a0*/ void SearchZombieUpdate();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x380570*/ void StartJump();
    /*0x37fe10*/ void AnimCrash();
}

class SquashPumpkin : Pumpkin
{
    /*0x208*/ UnityEngine.GameObject squashPrefab;
    /*0x210*/ UnityEngine.GameObject squashPrefab_jala;
    /*0x218*/ UnityEngine.GameObject squashPrefab_lour;
    /*0x220*/ LittleSquash littleSquash;

    /*0x34b060*/ SquashPumpkin();
    /*0x380cb0*/ Plant get_Squash();
    /*0x3763f0*/ void Awake();
    /*0x380680*/ void AttributeEvent();
    /*0x380c70*/ void <AttributeEvent>b__7_0(int row, int damage);
}

class SquashSpike : Caltrop
{
    /*0x361060*/ SquashSpike();
    /*0x380ea0*/ void AnimAttack();
}

class SquashTorch : TorchWood
{
    /*0x208*/ int fireTimes;

    /*0x34b060*/ SquashTorch();
    /*0x381220*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x381330*/ bool SummonPlant(int dmg);
}

class StarBlover : Blover
{
    /*0x208*/ bool attracting;
    /*0x210*/ Bullet_star[] starBullets;
    /*0x218*/ UnityEngine.Vector2 center;
    /*0x220*/ float radius;
    /*0x224*/ float transitionSpeed;
    /*0x228*/ UnityEngine.GameObject head;
    /*0x230*/ int maxBullets;

    /*0x383af0*/ StarBlover();
    /*0x382ba0*/ void AnimBlow();
    /*0x382e10*/ void FirstMeet();
    /*0x382e60*/ void FixedUpdate();
    /*0x383700*/ void SetAccelerateTime();
    /*0x382a70*/ bool AddNode(Bullet_star starBullet);
    /*0x383490*/ void RemoveNode(Bullet_star starBullet);
    /*0x383ac0*/ void Update();
    /*0x3838e0*/ void StarsUpdate();
    /*0x383060*/ void MoveToCircle(Bullet_star star);
    /*0x3835b0*/ void RotateOnCircle(Bullet_star star);
    /*0x382cf0*/ void DieEvent(Plant.DieReason reason);
}

class StarNut : WallNut
{
    /*0x34b060*/ StarNut();
    /*0x383cc0*/ void TakeDamage(int damage, int damageType);
    /*0x383b70*/ void SetBullet(int theMovingWay, float angle);
}

class SunPot : MoneyPot
{
    /*0x34a200*/ SunPot();
    /*0x383d50*/ void Produce();
}

class SuperFurnace : AdvancedFurnuce
{
    /*0x218*/ float timer;

    /*0x3849c0*/ SuperFurnace();
    /*0x384660*/ void Start();
    /*0x384380*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3840b0*/ void AttributeEvent();
    /*0x384920*/ void Update();
    /*0x383e40*/ void AnimShoot();
}

class SuperHypnoDoom : DoomShroom
{
    /*0x34b060*/ SuperHypnoDoom();
    /*0x3849d0*/ void AnimExplode();
    /*0x384ae0*/ void SetZombie(int row);
}

class SuperMachineNut : WallNut
{
    /*0x208*/ Zombie landSubmarine;

    /*0x34b060*/ SuperMachineNut();
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x384d40*/ void Summon();
    /*0x384c10*/ void DieEvent(Plant.DieReason reason);
    /*0x384ca0*/ void LimHealth();
    /*0x36a8e0*/ void TakeDamage(int damage, int damageType);
}

class SuperPumpkin : BloverPumpkin
{
    /*0x208*/ LittleFly littleFly;
    /*0x210*/ LittleFly littleFly2;
    /*0x218*/ LittleFly littleFly3;

    /*0x349420*/ SuperPumpkin();
    /*0x38a600*/ void Start();
    /*0x38a480*/ void DelaySummon(float time);
    /*0x38a020*/ void AttributeEvent();
    /*0x38a4d0*/ void DieEvent(Plant.DieReason reason);
    /*0x38a240*/ void CreateFly();
    /*0x38a5b0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x38a560*/ UnityEngine.GameObject GetFly();
}

class SuperSeaShroom : Shooter
{
    /*0x210*/ UnityEngine.Rendering.SortingGroup handGroup;
    /*0x218*/ UnityEngine.GameObject hand;

    /*0x388fb0*/ SuperSeaShroom();
    /*0x38a8f0*/ void Awake();
    /*0x38af10*/ Bullet Shoot1();
    /*0x38aef0*/ void PlantShootUpdate();
    /*0x38a920*/ void FixedUpdate();
    /*0x38a950*/ void GrabUpdate();
    /*0x38a8e0*/ void AttributeEvent();
    /*0x38a640*/ void AnimGrab();

    class <>c
    {
        static /*0x0*/ SuperSeaShroom.<> <>9;
        static /*0x8*/ System.Func<Zombie, float> <>9__6_0;
        static /*0x10*/ System.Func<Zombie, bool> <>9__6_1;

        static /*0x38f670*/ <>c();
        /*0x32f970*/ <>c();
        /*0x38f450*/ float <GrabUpdate>b__6_0(Zombie z);
        /*0x38f480*/ bool <GrabUpdate>b__6_1(Zombie z);
    }
}

class SuperSunNut : WallNut
{
    /*0x348cd0*/ SuperSunNut();
    /*0x38b330*/ void TakeDamage(int damage, int damageType);
    /*0x38b010*/ void SummonAndRecover();
}

class SuperTorch : Plant
{
    /*0x208*/ float fireCountDown;

    /*0x348cd0*/ SuperTorch();
    /*0x38bbb0*/ void Update();
    /*0x38b440*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3637d0*/ void DieEvent(Plant.DieReason reason);
    /*0x38b650*/ void ReadyToFire();
}

class SuperUmbrella : MoneyUmbrella
{
    /*0x349420*/ SuperUmbrella();
    /*0x38bd10*/ void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio);
    /*0x38bc10*/ void BlockEffect(Zombie zombie);
}

class TallNutFootball : WallNut
{
    /*0x348cd0*/ TallNutFootball();
}

class ThreeNut : Shooter
{
    /*0x210*/ CrackStatus crack;

    /*0x388fb0*/ ThreeNut();
    /*0x38c6e0*/ Bullet Shoot1();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x38c610*/ void ReplaceSprite();
    /*0x38c580*/ void Recover(float health, Plant.DamageType damageType);
}

class ThreeSpike : Caltrop
{
    /*0x210*/ float shootTime;
    /*0x214*/ float shootMaxTime;

    /*0x38d290*/ ThreeSpike();
    /*0x38d210*/ void Update();
    /*0x38cc90*/ void FirstMeet();
    /*0x38cce0*/ void PlantShootUpdate();
    /*0x38c870*/ void AnimShoot();
    /*0x38d140*/ void ShootUpper(float X, float Y, int row);
    /*0x38d070*/ void ShootLower(float X, float Y, int row);
    /*0x38cb90*/ void ExtraBullet();
    /*0x38ce30*/ UnityEngine.GameObject SearchZombie();
}

class ThreeTorch : Plant
{
    /*0x348cd0*/ ThreeTorch();
    /*0x38d730*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x38d2b0*/ void FirePeas(Bullet bullet);
}

class TorchPumpkin : Pumpkin
{
    /*0x208*/ int fireTimes;

    /*0x34a200*/ TorchPumpkin();
    /*0x38d900*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x38dac0*/ bool SummonPlant(int dmg);
    /*0x38d810*/ bool CheckFire(Bullet bullet);
}

class TorchWood : Plant
{
    /*0x348cd0*/ TorchWood();
    /*0x38e220*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x38e130*/ bool CheckFire(Bullet bullet);
}

class TwinShulk : Shulkflower
{
    /*0x386d10*/ TwinShulk();
    /*0x38e720*/ Bullet Shoot1();
    /*0x38e550*/ UnityEngine.GameObject SearchZombie();
}

class UltimateBigChomper : BigChomper
{
    /*0x228*/ bool add;

    /*0x363f80*/ UltimateBigChomper();
    /*0x38f750*/ void Awake();
    /*0x38fcc0*/ void Update();
    /*0x38f980*/ void SwallowEvent();
    /*0x38f880*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x38f7c0*/ void Chomp(Zombie zombie);
    /*0x38fca0*/ void TakeDamage(int damage, int damageType);
}

class UltimateCannon : CobCannon
{
    /*0x34b060*/ UltimateCannon();
    /*0x390060*/ void StartShoot();
    /*0x390100*/ void Start();
    /*0x390010*/ void FirstMeet();
    /*0x38fd10*/ void AnimShoot();
    /*0x390250*/ void Update();
    /*0x390120*/ void SubShootUpdate();
    /*0x38fed0*/ void AnimSubShoot();
}

class UltimateChomper : SuperChomper
{
    /*0x238*/ bool undead;
    /*0x23c*/ float undeadTimer;
    /*0x240*/ float undeadCD;
    /*0x248*/ TMPro.TextMeshPro killingText;
    /*0x250*/ TMPro.TextMeshPro killingTextShadow;

    /*0x3912e0*/ UltimateChomper();
    /*0x391300*/ bool get_Legendary();
    /*0x3909e0*/ void DecreaseHealth();
    /*0x390f00*/ void Recover(float health, Plant.DamageType damageType);
    /*0x390d40*/ void LimHealth();
    /*0x3904a0*/ void BiteEvent();
    /*0x390af0*/ void FirstMeet();
    /*0x390fb0*/ void TakeDamage(int damage, int damageType);
    /*0x390390*/ void AnimShoot();
    /*0x390770*/ void Bite(Zombie zombie);
    /*0x390b40*/ UnityEngine.GameObject InitText();
    /*0x391020*/ void UpdateText();

    class <>c
    {
        static /*0x0*/ UltimateChomper.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__4_0;

        static /*0x38f600*/ <>c();
        /*0x32f970*/ <>c();
        /*0x38f550*/ bool <get_Legendary>b__4_0(Plant p);
    }
}

class UltimateExplodeCannon : CobCannon
{
    /*0x34b060*/ UltimateExplodeCannon();
    /*0x391490*/ void AnimShoot();
}

class UltimateFly : CactusBlover
{
    /*0x386d10*/ UltimateFly();
    /*0x391650*/ Bullet Shoot1();
}

class UltimateGatlingBlover : Shooter
{
    /*0x210*/ float timer;

    /*0x388fb0*/ UltimateGatlingBlover();
    /*0x391c30*/ void Start();
    /*0x391b50*/ void PlantShootUpdate();
    /*0x3919a0*/ void AttributeEvent();
    /*0x391e10*/ void UpdateInterval();
    /*0x391d90*/ void UpdateAttackCountDown();
    /*0x391aa0*/ void DieEvent(Plant.DieReason reason);
}

class UltimateLittleFly : LittleFly
{
    /*0x78*/ UnityEngine.LayerMask layerMask;
    /*0x7c*/ bool small;

    /*0x393480*/ UltimateLittleFly();
    /*0x392660*/ void Awake();
    /*0x392da0*/ void Update();
    /*0x392030*/ void AnimShoot();
    /*0x3925d0*/ void AttackZombie(Zombie zombie);
    /*0x392a70*/ Zombie GetZombie();
    /*0x392790*/ Zombie GetFlyingZombie();
    /*0x392700*/ bool CheckZombie(Zombie zombie);
}

class UltimateMagnet : LanternMagnet
{
    /*0x230*/ float period;
    /*0x238*/ System.Collections.Generic.List<UltimateMagnet.AttrackedBucket> buckets;
    /*0x240*/ System.Collections.Generic.List<UltimateMagnet.AttrackedBucket> bullets;

    /*0x394860*/ UltimateMagnet();
    /*0x3943a0*/ void SetRange();
    /*0x393e10*/ void SearchZombieWithIron();
    /*0x393a20*/ bool MoreAttrack(Zombie zombie);
    /*0x393830*/ void BucketsUpdate();
    /*0x393490*/ void AddToBullets(UltimateMagnet.AttrackedBucket bucket);
    /*0x394410*/ void Shoot(UltimateMagnet.AttrackedBucket bucket);
    /*0x393580*/ Bucket AttrackItem(UnityEngine.GameObject item, int theRow);
    /*0x32d010*/ void AttributeEvent();
    /*0x32d010*/ void DieEvent(Plant.DieReason reason);
    /*0x3947a0*/ void Update();

    class AttrackedBucket
    {
        /*0x10*/ Bucket bucket;
        /*0x18*/ UnityEngine.Vector2 targetPosition;
        /*0x20*/ bool die;
        /*0x24*/ int damage;
        /*0x28*/ int count;
        /*0x2c*/ float angle;
        /*0x30*/ float existTimer;
        /*0x38*/ UnityEngine.Transform centerPoint;
        /*0x40*/ float radius;
        /*0x44*/ float angularSpeed;

        /*0x386a20*/ AttrackedBucket(UnityEngine.Transform centerPoint, float radius, Bucket bucket, float angularSpeed);
        /*0x386840*/ void Update();
        /*0x3864e0*/ void BulletUpdate();
    }
}

class UltimatePlantern : Plantern
{
    /*0x34b060*/ UltimatePlantern();
    /*0x3763f0*/ void Awake();
    /*0x394ee0*/ void Start();
    /*0x394920*/ void AttributeEvent();
    /*0x394fb0*/ void TakeDamage(int damage, int damageType);
    /*0x394c10*/ void DieEvent(Plant.DieReason reason);
    /*0x394de0*/ void ResetLightLevel1();
    /*0x394e60*/ void ResetLightLevel2();
}

class UltimatePortalNut : PortalNut
{
    /*0x220*/ float recoverTimer;
    /*0x224*/ float restoreTimer;
    /*0x228*/ int restoreCount;

    /*0x395440*/ UltimatePortalNut();
    /*0x395190*/ void Revive();
    /*0x395330*/ void Update();
    /*0x395290*/ void TakeDamage(int damage, int damageType);
    /*0x3950c0*/ void DecreaseHealth(int value);
}

class UltimatePumpkin : SuperPumpkin
{
    /*0x349420*/ UltimatePumpkin();
    /*0x3960b0*/ void FirstMeet();
    /*0x396150*/ void Samer();
    /*0x395450*/ void AttributeEvent();
    /*0x3959b0*/ void CreateFly();
    /*0x396430*/ void Supplement();
    /*0x395f70*/ void DieEvent(Plant.DieReason reason);
    /*0x396100*/ UnityEngine.GameObject GetFly();

    class <>c
    {
        static /*0x0*/ UltimatePumpkin.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__1_0;

        static /*0x38f590*/ <>c();
        /*0x32f970*/ <>c();
        /*0x38f4e0*/ bool <Samer>b__1_0(Plant p);
    }
}

class UltimateStarBlover : StarBlover
{
    /*0x396c40*/ UltimateStarBlover();
    /*0x396830*/ void Awake();
    /*0x396890*/ void SetAccelerateTime();
    /*0x396a70*/ void StarsUpdate();
}

class UltimateTallNut : TallNutFootball
{
    /*0x348cd0*/ UltimateTallNut();
    /*0x374ff0*/ void Awake();
    /*0x3750b0*/ void AttributeEvent();
    /*0x397170*/ void TakeDamage(int damage, int damageType);
    /*0x348b00*/ bool Instead(int theDamage);
    /*0x396c50*/ System.Collections.Generic.List<Plant> GetUltimateTallNuts();

    class <>c
    {
        static /*0x0*/ UltimateTallNut.<> <>9;
        static /*0x8*/ System.Func<Plant, bool> <>9__2_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__4_0;
        static /*0x18*/ System.Func<Plant, bool> <>9__4_1;

        static /*0x38f6e0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x38f510*/ bool <TakeDamage>b__2_0(Plant p);
        /*0x38f3f0*/ bool <GetUltimateTallNuts>b__4_0(Plant p);
        /*0x38f420*/ bool <GetUltimateTallNuts>b__4_1(Plant p);
    }
}

class UltimateTorch : SquashTorch
{
    /*0x34a200*/ UltimateTorch();
    /*0x397850*/ void Awake();
    /*0x3978b0*/ void FirstMeet();
    /*0x397900*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x397c80*/ bool SummonPlant(int dmg);
    /*0x397870*/ void DieEvent(Plant.DieReason reason);
}

class Umbrellaleaf : Plant
{
    /*0x208*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x210*/ bool blocking;

    /*0x348cd0*/ Umbrellaleaf();
    /*0x3983e0*/ Plant get_UmbrellaPot();
    /*0x398200*/ void Block(Bullet bullet);
    /*0x398060*/ void BlockBungi(BungiZombie bungi);
    /*0x398370*/ System.Collections.IEnumerator DelayBlock(Bullet bullet);
    /*0x398190*/ void BlockStart();
    /*0x398120*/ void BlockOver();
    /*0x398050*/ void AllBlockOver();

    class <DelayBlock>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Bullet bullet;
        /*0x28*/ float <time>5__2;

        /*0x32f460*/ <DelayBlock>d__6(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38ec50*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38ed90*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class WallNut : Plant
{
    /*0x348cd0*/ WallNut();
    /*0x398570*/ void FirstMeet();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x3986e0*/ void ReplaceSprite();
    /*0x3985f0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x35a990*/ void FixedUpdate();
}

class WaterAloes : Thrower
{
    /*0x220*/ TMPro.TextMeshPro energyText;
    /*0x228*/ TMPro.TextMeshPro energyTextShadow;

    /*0x398d20*/ WaterAloes();
    /*0x3989f0*/ BulletType GetBulletType();
    /*0x398a30*/ UnityEngine.GameObject InitText();
    /*0x398c20*/ void UpdateText();
}

class WaterBamboo : Bamboo
{
    /*0x208*/ UnityEngine.GameObject ice;
    /*0x210*/ TMPro.TextMeshPro energyText;
    /*0x218*/ TMPro.TextMeshPro energyTextShadow;

    /*0x34b060*/ WaterBamboo();
    /*0x398d30*/ void CrashWithZombie(Zombie zombie, float x);
    /*0x398db0*/ UnityEngine.GameObject InitText();
    /*0x398fa0*/ void UpdateText();
}

class WaterShulk : Shulkflower
{
    /*0x210*/ UnityEngine.SpriteRenderer leaf;
    /*0x218*/ TMPro.TextMeshPro energyText;
    /*0x220*/ TMPro.TextMeshPro energyTextShadow;

    /*0x386d10*/ WaterShulk();
    /*0x399100*/ void AttackEffect(System.Collections.Generic.List<Zombie> zombies);
    /*0x399530*/ UnityEngine.GameObject InitText();
    /*0x399720*/ void UpdateText();
}

class Wheat : Plant
{
    /*0x208*/ bool recover;

    /*0x348cd0*/ Wheat();
    /*0x3998f0*/ void Start();
}

class Producer : Plant
{
    /*0x348cd0*/ Producer();
    /*0x388dd0*/ void Update();
    /*0x388c50*/ void ProducerUpdate();
    /*0x388d60*/ System.Collections.IEnumerator SunBright();
    /*0x388b70*/ void ProduceSun();
    /*0x388ae0*/ void ProduceSunWithNoSound();

    class <SunBright>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Producer <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38f1f0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38f370*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BigSunShroom : Producer
{
    /*0x208*/ TMPro.TextMeshPro energyText;
    /*0x210*/ TMPro.TextMeshPro energyTextShadow;

    /*0x348cd0*/ BigSunShroom();
    /*0x386d20*/ void ChargeBySun(CoinSun sun);
    /*0x387130*/ void SunAction(int value);
    /*0x386fb0*/ void ProduceSun();
    /*0x386dc0*/ UnityEngine.GameObject InitText();
    /*0x3871e0*/ void UpdateText();
}

class DoomSunflower : SunFlower
{
    /*0x348cd0*/ DoomSunflower();
    /*0x3872e0*/ void ProduceSun();
}

class FireSunshroom : Producer
{
    /*0x208*/ float timer;

    /*0x387fd0*/ FireSunshroom();
    /*0x3876d0*/ void Awake();
    /*0x387b50*/ void Start();
    /*0x387bc0*/ void Update();
    /*0x3875f0*/ void AttributeEvent();
    /*0x3879c0*/ System.Collections.IEnumerator Grow();
    /*0x387a30*/ void ProduceSun();
    /*0x387710*/ void DieEvent(Plant.DieReason reason);

    class <Grow>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ FireSunshroom <>4__this;
        /*0x28*/ UnityEngine.Vector3 <currentScale>5__2;
        /*0x34*/ UnityEngine.Vector3 <targetScale>5__3;

        /*0x32f460*/ <Grow>d__5(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38edd0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38f030*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class GoldSunflower : Plant
{
    /*0x348cd0*/ GoldSunflower();
    /*0x3695e0*/ void Awake();
    /*0x387ff0*/ void AttributeEvent();
    /*0x3880a0*/ bool SuperSkill();
    /*0x388030*/ System.Collections.IEnumerator ContinueProduce();

    class <ContinueProduce>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GoldSunflower <>4__this;

        /*0x32f460*/ <ContinueProduce>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38ea60*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38ec10*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Ice : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ Ice();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class Marigold : Plant
{
    /*0x348cd0*/ Marigold();
    /*0x388670*/ void Update();
    /*0x388240*/ void MarigoldUpdate();
    /*0x388600*/ System.Collections.IEnumerator SunBright();
    /*0x3884b0*/ void Produce();
    /*0x388370*/ void OnCreate(int theColumn, int theRow);

    class <SunBright>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Marigold <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38f070*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38f3b0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MoneyPot : Pot
{
    /*0x34b060*/ MoneyPot();
    /*0x388a60*/ void Update();
    /*0x388860*/ void MarigoldUpdate();
    /*0x3887f0*/ System.Collections.IEnumerator Bright();
    /*0x388970*/ void Produce();

    class <Bright>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ MoneyPot <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <Bright>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x38e8a0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x38ea20*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SilverSunflower : Producer
{
    /*0x348cd0*/ SilverSunflower();
}

class SunFlower : Producer
{
    /*0x348cd0*/ SunFlower();
}

class SunMagnetShroom : Producer
{
    /*0x348cd0*/ SunMagnetShroom();
    /*0x361500*/ void Awake();
    /*0x389680*/ void AttributeEvent();
    /*0x389740*/ bool UseItem(BucketType type, Bucket bucket);
    /*0x388fd0*/ void AnimProduce();
}

class SunSeaShroom : Producer
{
    /*0x208*/ int growLevel;

    /*0x348cd0*/ SunSeaShroom();
    /*0x389b00*/ void Start();
    /*0x389880*/ void FirstMeet();
    /*0x389840*/ void AttributeEvent();
    /*0x389960*/ void ProduceSun();
    /*0x3898d0*/ void Grow();
}

class SunShroom : Producer
{
    /*0x208*/ bool isGrowen;
    /*0x20c*/ float timer;

    /*0x38a000*/ SunShroom();
    /*0x389d90*/ void Update();
    /*0x389d70*/ void Start();
    /*0x389b20*/ void AttributeEvent();
    /*0x389c50*/ void ProduceSun();
    /*0x389bc0*/ void Grow();
}

class TorchSunflower : Producer
{
    /*0x348cd0*/ TorchSunflower();
    /*0x38dda0*/ void ProduceSun();
}

class TwinFlower : SunFlower
{
    /*0x348cd0*/ TwinFlower();
    /*0x38e3b0*/ void FirstMeet();
    /*0x38e400*/ void ProduceSun();
}

class Shooter : Attacker
{
    /*0x208*/ float dreamTime;

    /*0x388fb0*/ Shooter();
    /*0x388ea0*/ void Update();
    /*0x388e70*/ Bullet AnimShoot();
    /*0x350af0*/ void AnimShoot2();
    /*0x388e90*/ Bullet Shoot1();
    /*0x388e90*/ Bullet Shoot2();
    /*0x388e90*/ BulletType GetBulletType();
}

class AbyssSwordStar : SwordStarfruit
{
    static /*0x0*/ AbyssSwordStar Instance;
    /*0x210*/ System.Collections.Generic.List<BigSword> bigSwords;
    /*0x218*/ UnityEngine.GameObject bigSwordPrefab;

    /*0x386460*/ AbyssSwordStar();
    /*0x385da0*/ void Awake();
    /*0x3862b0*/ void Start();
    /*0x385fd0*/ void SetStatus(PlantStatus plantStatus);
    /*0x385fe0*/ void SetSwords();
    /*0x385f30*/ bool CheckStatus(Zombie zombie);
    /*0x385b50*/ void AttackZombie(UnityEngine.Vector2 position);
}

class BambooSpruce : SpruceShooter
{
    /*0x386d10*/ BambooSpruce();
    /*0x386bc0*/ Bullet Shoot1();
    /*0x386a90*/ void CrashWithZombie(Zombie zombie);
}

class BigGatling : Shooter
{
    /*0x210*/ float attackSpeed;
    /*0x214*/ float multiplier;
    /*0x218*/ int shootCount;

    /*0x399e00*/ BigGatling();
    /*0x399970*/ void PlantShootUpdate();
    /*0x399da0*/ void Update();
    /*0x399ac0*/ void Raised();
    /*0x399ad0*/ Bullet Shoot1();
}

class BigGloom : Shooter
{
    /*0x34b660*/ BigGloom();
    /*0x39a1f0*/ Bullet Shoot1();
    /*0x39a380*/ Bullet Shoot2();
    /*0x399e20*/ UnityEngine.GameObject SearchZombie();
}

class BucketFume : FumeShroom
{
    /*0x39ab30*/ BucketFume();
    /*0x39a8e0*/ void Attack(Zombie zombie);
    /*0x39a9b0*/ Bullet Shoot1();
}

class Cabbage : Thrower
{
    /*0x398d20*/ Cabbage();
    /*0x34a750*/ BulletType GetBulletType();
    /*0x39acc0*/ void OnCreate(int theColumn, int theRow);
    /*0x39ad10*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
}

class CabbageMelon : Cabbage
{
    /*0x398d20*/ CabbageMelon();
    /*0x39ab50*/ BulletType GetBulletType();
    /*0x39ab60*/ void OnCreate(int theColumn, int theRow);
    /*0x39abe0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
}

class CabbagePuff : Thrower
{
    /*0x398d20*/ CabbagePuff();
    /*0x39ac50*/ BulletType GetBulletType();
    /*0x39ac60*/ void OnCreate(int theColumn, int theRow);
    /*0x39ac90*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
}

class Cactus : Shooter
{
    /*0x34b660*/ Cactus();
    /*0x39b6b0*/ Bullet Shoot1();
    /*0x39b830*/ Bullet Shoot2();
    /*0x39b060*/ BulletType GetBulletType();
    /*0x39b070*/ void PlantShootUpdate();
    /*0x39b330*/ UnityEngine.GameObject SearchZombie();
    /*0x39b260*/ bool SearchUniqueZombie(Zombie zombie);
}

class CactusStar : StarFruit
{
    /*0x386d10*/ CactusStar();
    /*0x39af40*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x39ad70*/ UnityEngine.GameObject SearchZombie();
}

class CattailGirl : Shooter
{
    /*0x34b660*/ CattailGirl();
    /*0x39bc10*/ void FirstMeet();
    /*0x39bed0*/ Bullet Shoot1();
    /*0x39bff0*/ Bullet Shoot2();
    /*0x39bd00*/ UnityEngine.GameObject SearchZombie();
    /*0x39bc60*/ bool SearchUniqueZombie(Zombie zombie);
    /*0x39b9b0*/ void DieEvent(Plant.DieReason reason);
}

class CattailLour : CattailPlant
{
    /*0x210*/ UnityEngine.GameObject flyPrefab;
    /*0x218*/ UnityEngine.Transform flyPos;

    /*0x34b660*/ CattailLour();
    /*0x39c110*/ void FirstMeet();
    /*0x39c3c0*/ void Supply();
    /*0x39c160*/ Bullet Shoot1();
    /*0x32d010*/ void DieEvent(Plant.DieReason reason);
}

class CattailPlant : CattailGirl
{
    /*0x34b660*/ CattailPlant();
    /*0x39c610*/ Bullet Shoot1();
}

class CherryGatling : Shooter
{
    /*0x34b660*/ CherryGatling();
    /*0x39c770*/ Bullet Shoot1();
}

class CherryScaredy : ScaredyShroom
{
    /*0x34b660*/ CherryScaredy();
    /*0x39c890*/ void AnimScaredy();
    /*0x39c910*/ Bullet Shoot1();
}

class CherryShooter : Shooter
{
    /*0x34b660*/ CherryShooter();
    /*0x39ca10*/ Bullet Shoot1();
}

class CherrySplit : SplitPea
{
    /*0x39ce90*/ CherrySplit();
    /*0x374ff0*/ void Awake();
    /*0x39cb20*/ Bullet Shoot1();
    /*0x39cd40*/ Bullet Shoot2();
}

class CornCabbage : Cornpult
{
    /*0x398d20*/ CornCabbage();
    /*0x39cea0*/ void FirstMeet();
    /*0x39cf10*/ void OnCreate(int theColumn, int theRow);
    /*0x39cf80*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x39cf00*/ BulletType GetBulletType();
    /*0x39cef0*/ BulletType GetBulletType2();
}

class CornMelon : Cornpult
{
    /*0x398d20*/ CornMelon();
    /*0x39d000*/ BulletType GetBulletType();
    /*0x39cff0*/ BulletType GetBulletType2();
    /*0x39d010*/ void OnCreate(int theColumn, int theRow);
    /*0x39d070*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
}

class CornPuff : Cornpult
{
    /*0x398d20*/ CornPuff();
    /*0x39d0d0*/ BulletType GetBulletType();
    /*0x39d0c0*/ BulletType GetBulletType2();
    /*0x39d0e0*/ Zombie ThrowerSearchZombie();
}

class Cornpult : Thrower
{
    /*0x398d20*/ Cornpult();
    /*0x39d500*/ void OnCreate(int theColumn, int theRow);
    /*0x39d530*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x39d4f0*/ BulletType GetBulletType();
    /*0x39d4e0*/ BulletType GetBulletType2();
    /*0x39d560*/ void PlantShootUpdate();
}

class CustomPeaShooter : PeaShooter
{
    /*0x34b660*/ CustomPeaShooter();
}

class DoomCactus : UltimateCactus
{
    /*0x228*/ System.Collections.Generic.List<bool> bools;

    /*0x39dce0*/ DoomCactus();
    /*0x39d700*/ void Awake();
    /*0x39d720*/ BulletType GetBulletType();
    /*0x32d010*/ void OnCreate(int theColumn, int theRow);
    /*0x39d730*/ void InitBool();
    /*0x39d860*/ Bullet Shoot1();
    /*0x39daa0*/ Bullet Shoot2();
}

class DoomFume : Plant
{
    /*0x348cd0*/ DoomFume();
    /*0x39e1b0*/ void AttributeEvent();
    /*0x39e200*/ void Shoot();
    /*0x39dd60*/ void AnimShoot();
    /*0x39dfc0*/ void AttackZombie();
}

class DoomGatling : Shooter
{
    /*0x210*/ int doomTimes;

    /*0x34b660*/ DoomGatling();
    /*0x39e270*/ Bullet Shoot1();
}

class DoomPeashooter : PeaShooter
{
    /*0x34b660*/ DoomPeashooter();
    /*0x39e4d0*/ Bullet Shoot1();
}

class DoomSniper : Shooter
{
    /*0x210*/ int craze;
    /*0x214*/ float crazeTimer;

    /*0x34b660*/ DoomSniper();
    /*0x39e8b0*/ UnityEngine.GameObject SearchZombie();
    /*0x39f0b0*/ void UpdateAttackCountDown();
    /*0x39eae0*/ Bullet Shoot1();
    /*0x39e780*/ bool CheckZombie(Zombie zombie);
}

class DoomStar : Plant
{
    /*0x348cd0*/ DoomStar();
    /*0x3763f0*/ void Awake();
    /*0x39f200*/ void Start();
    /*0x39f130*/ void AttributeEvent();
}

class DoubleCherry : Shooter
{
    /*0x34b660*/ DoubleCherry();
    /*0x374ff0*/ void Awake();
    /*0x39f260*/ Bullet Shoot1();
}

class DoubleSnowPeaShooter : Shooter
{
    /*0x34b660*/ DoubleSnowPeaShooter();
    /*0x374ff0*/ void Awake();
    /*0x39f500*/ Bullet Shoot1();
    /*0x39f370*/ BulletType GetBulletType();
}

class FireCattail : CattailPlant
{
    /*0x34b660*/ FireCattail();
    /*0x39f620*/ Bullet Shoot1();
}

class FireFume : FumeShroom
{
    /*0x39ab30*/ FireFume();
    /*0x39f9d0*/ Bullet Shoot1();
    /*0x39f990*/ void FixedUpdate();
    /*0x39f780*/ void AttackZombie();
}

class FireGloom : GloomShroom
{
    /*0x39ff80*/ FireGloom();
    /*0x39fb40*/ void AttackZombie();
    /*0x39fef0*/ Bullet Shoot1();
}

class FireMelon : Melonpult
{
    /*0x398d20*/ FireMelon();
    /*0x39ffa0*/ BulletType GetBulletType();
}

class FireSniper : SniperPea
{
    /*0x386d10*/ FireSniper();
    /*0x39ffb0*/ void AttackZombie(Zombie zombie, int damage, DmgType theDamageType);
}

class FumeShroom : Shooter
{
    /*0x210*/ float range;

    /*0x39ab30*/ FumeShroom();
    /*0x3a0460*/ UnityEngine.GameObject SearchZombie();
    /*0x3a0020*/ void AttackZombie();
    /*0x3a0420*/ void Attack(Zombie zombie);
    /*0x3a0700*/ Bullet Shoot1();
}

class GarlicCabbage : Cabbage
{
    /*0x398d20*/ GarlicCabbage();
    /*0x3a0840*/ BulletType GetBulletType();
}

class GarlicCorn : Cornpult
{
    /*0x398d20*/ GarlicCorn();
    /*0x3a0860*/ BulletType GetBulletType();
    /*0x3a0850*/ BulletType GetBulletType2();
}

class GarlicFume : FumeShroom
{
    /*0x39ab30*/ GarlicFume();
    /*0x3a0870*/ void Attack(Zombie zombie);
    /*0x3a08d0*/ Bullet Shoot1();
}

class GarlicMelon : Melonpult
{
    /*0x398d20*/ GarlicMelon();
    /*0x3a0a50*/ BulletType GetBulletType();
}

class GatlingPea : Shooter
{
    /*0x34b660*/ GatlingPea();
    /*0x3a0a60*/ void FirstMeet();
    /*0x3a0ab0*/ Bullet Shoot1();
}

class GloomShroom : Shooter
{
    /*0x210*/ UnityEngine.GameObject center;
    /*0x218*/ float range;
    /*0x21c*/ int maxRow;

    /*0x39ff80*/ GloomShroom();
    /*0x3a10d0*/ void Awake();
    /*0x3a13b0*/ void Start();
    /*0x3a1150*/ UnityEngine.GameObject SearchZombie();
    /*0x388e90*/ UnityEngine.GameObject SearchBoss();
    /*0x3a1320*/ Bullet Shoot1();
    /*0x3a0c10*/ void AttackZombie();
}

class Hamburger : Shooter
{
    /*0x210*/ UnityEngine.GameObject r1;
    /*0x218*/ UnityEngine.GameObject r2;
    /*0x220*/ UnityEngine.GameObject r3;

    /*0x34b660*/ Hamburger();
    /*0x3a16b0*/ void InitPlant();
    /*0x3a1660*/ int GetMaxHealth(PlantType thePlantType);
    /*0x3a1420*/ bool AddStage(PlantType thePlantType);
    /*0x3a19f0*/ Bullet Shoot1();
    /*0x3a22a0*/ Bullet Shoot2();
    /*0x3a1620*/ void AnimShoot3();
    /*0x3a1640*/ void AnimShoot4();
    /*0x3a2330*/ void Update();
    /*0x3a18e0*/ void ProducerUpdate();
    /*0x3a22c0*/ System.Collections.IEnumerator SunBright();
    /*0x3a1800*/ void ProduceSun();

    class <SunBright>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Hamburger <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__12(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ae6c0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ae840*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class HelmetFume : FumeShroom
{
    /*0x39ab30*/ HelmetFume();
    /*0x3a23d0*/ void Attack(Zombie zombie);
    /*0x3a2410*/ Bullet Shoot1();
}

class HelmetGatling : Shooter
{
    /*0x34b660*/ HelmetGatling();
    /*0x3a25c0*/ Bullet Shoot1();
    /*0x3a2590*/ BulletType GetBulletType();
}

class HypnoMelon : Thrower
{
    /*0x398d20*/ HypnoMelon();
    /*0x3a2700*/ BulletType GetBulletType();
}

class HypnoPeashooter : Shooter
{
    /*0x34b660*/ HypnoPeashooter();
    /*0x374ff0*/ void Awake();
    /*0x3a2710*/ Bullet Shoot1();
}

class HypnoSplit : SplitPea
{
    /*0x39ce90*/ HypnoSplit();
    /*0x374ff0*/ void Awake();
    /*0x3a2820*/ Bullet Shoot1();
    /*0x3a29f0*/ Bullet Shoot2();
}

class HyponoFume : FumeShroom
{
    /*0x39ab30*/ HyponoFume();
    /*0x3a2b10*/ void Attack(Zombie zombie);
    /*0x3a2c90*/ Bullet Shoot1();
    /*0x3a2b10*/ void TrySetMindControl(Zombie zombie);
}

class IceCattail : CattailPlant
{
    /*0x34b660*/ IceCattail();
    /*0x3a4690*/ Bullet Shoot1();
}

class IceDoomFume : Shooter
{
    /*0x34b660*/ IceDoomFume();
    /*0x3a47e0*/ void FirstMeet();
    /*0x3a4a30*/ Bullet Shoot1();
    /*0x3a4830*/ UnityEngine.GameObject SearchZombie();
}

class IceDoomGloom : IceGloom
{
    /*0x220*/ int power;

    /*0x39ff80*/ IceDoomGloom();
    /*0x3a4cc0*/ void FirstMeet();
    /*0x3a4d10*/ Bullet Shoot1();
    /*0x3a4b50*/ System.Collections.IEnumerator AttackZombie2(UnityEngine.Vector2[] vectors);
    /*0x3a4be0*/ void DieEvent(Plant.DieReason reason);
    /*0x3a4f40*/ void TakeDamage(int damage, int damageType);

    class <AttackZombie2>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.Vector2[] vectors;
        /*0x28*/ IceDoomGloom <>4__this;
        /*0x30*/ float <time>5__2;

        /*0x32f460*/ <AttackZombie2>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ae3d0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ae680*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class IceFumeShroom : FumeShroom
{
    /*0x39ab30*/ IceFumeShroom();
    /*0x3a5050*/ void Attack(Zombie zombie);
    /*0x3a50b0*/ Bullet Shoot1();
}

class IceGloom : GloomShroom
{
    /*0x39ff80*/ IceGloom();
    /*0x3a5360*/ void AttackZombie();
    /*0x3a55c0*/ Bullet Shoot1();
}

class IcePeach : Shooter
{
    /*0x34b660*/ IcePeach();
    /*0x3a5770*/ Bullet Shoot1();
    /*0x3a5650*/ void AngleShoot(float angel);
}

class IcePuff : PeaSmallPuff
{
    /*0x34b660*/ IcePuff();
    /*0x3a58d0*/ Bullet Shoot1();
}

class IceScaredyShroom : ScaredyShroom
{
    /*0x34b660*/ IceScaredyShroom();
    /*0x3a5e70*/ Bullet Shoot1();
    /*0x3a5a20*/ void AnimFreeze();
}

class IFVIronPuff : IronPuff
{
    /*0x210*/ float sniperTimer;
    /*0x214*/ float pultTimer;
    /*0x218*/ UnityEngine.Transform shoot_pult;
    /*0x220*/ UnityEngine.Rendering.SortingGroup heart;
    /*0x228*/ UnityEngine.Transform heartTransform;
    /*0x230*/ UnityEngine.Transform pult;
    /*0x238*/ Zombie targetZombie2;

    /*0x34b660*/ IFVIronPuff();
    /*0x3a30c0*/ void Awake();
    /*0x3a3a90*/ Bullet Shoot1();
    /*0x3a3ba0*/ Bullet Shoot2();
    /*0x3a2f40*/ void AnimShoot3();
    /*0x3a42a0*/ void Update();
    /*0x3a3750*/ void PultUpdate();
    /*0x3a4080*/ Zombie TryGetFlyingZombie();
    /*0x3a3170*/ bool CheckAir(Zombie zombie);
    /*0x3a33a0*/ void ExtraShootUpdate();
    /*0x3a3570*/ bool PultSearch();
    /*0x3a3e50*/ Zombie SniperSearch();
    /*0x3a32a0*/ bool CheckZombie(Zombie zombie);
}

class IronCorn : Cornpult
{
    /*0x398d20*/ IronCorn();
    /*0x3a5fd0*/ BulletType GetBulletType();
    /*0x3a5fc0*/ BulletType GetBulletType2();
}

class IronMelon : Melonpult
{
    /*0x398d20*/ IronMelon();
    /*0x3a5fe0*/ BulletType GetBulletType();
}

class IronPeaShooter : PeaShooter
{
    /*0x34b660*/ IronPeaShooter();
    /*0x3a5ff0*/ Bullet Shoot1();
}

class IronPuff : Shooter
{
    /*0x34b660*/ IronPuff();
    /*0x3a6150*/ Bullet Shoot1();
}

class JalaStar : Plant
{
    /*0x208*/ System.Collections.Generic.List<UnityEngine.Transform> shoots;

    /*0x3a6730*/ JalaStar();
    /*0x3517c0*/ void Awake();
    /*0x3a66a0*/ void Start();
    /*0x34a6d0*/ void AttributeEvent();
    /*0x3a62e0*/ void DieEvent(Plant.DieReason reason);
    /*0x3a62b0*/ void Crashed(int level, int soundID, Zombie zombie);
}

class LanternCactus : Cactus
{
    /*0x210*/ UnityEngine.ParticleSystem lightShine;

    /*0x34b660*/ LanternCactus();
    /*0x3a6ec0*/ void Awake();
    /*0x3a7390*/ void Update();
    /*0x3a7170*/ Bullet Shoot2();
    /*0x3a6f60*/ Bullet Shoot1();
    /*0x3a67b0*/ void AttackZombieInAir();
    /*0x3a6b40*/ void AttackZombieInLand();
}

class LanternStarFruit : StarFruit
{
    /*0x210*/ UnityEngine.ParticleSystem lightShine;

    /*0x386d10*/ LanternStarFruit();
    /*0x3a7400*/ void Awake();
    /*0x3a7390*/ void Update();
    /*0x3a77f0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3a74a0*/ void PlantShootUpdate();
    /*0x3a75e0*/ UnityEngine.GameObject SearchZombie();
}

class LourFly : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 targetPosition;
    /*0x28*/ UnityEngine.Transform shootPos;
    /*0x30*/ int theRow;
    /*0x38*/ CattailLour lour;
    /*0x40*/ bool arrived;
    /*0x44*/ float timer;
    /*0x48*/ int shootCount;

    /*0x31c640*/ LourFly();
    /*0x3a7ef0*/ void Update();
    /*0x3a7b20*/ void ShootUpdate();
    /*0x3a7920*/ void PositionUpdate();
}

class LunarCabbage : SolarCabbage
{
    static /*0x3a7f10*/ void CreateLunar(Board board);
    /*0x3a8420*/ LunarCabbage();
    /*0x3a8380*/ void UniqueEffect(Bullet bullet);
    /*0x3a8120*/ BulletType GetBulletType();
    /*0x32d010*/ void AttributeEvent();
    /*0x3a8130*/ bool SuperSkill();
}

class MagnetCactus : Cactus
{
    /*0x34b660*/ MagnetCactus();
    /*0x3a8430*/ Bullet Shoot1();
    /*0x3a8580*/ Bullet Shoot2();
}

class MagnetCorn : Cornpult
{
    /*0x398d20*/ MagnetCorn();
    /*0x3a86f0*/ BulletType GetBulletType();
    /*0x3a86e0*/ BulletType GetBulletType2();
}

class MagnetFume : FumeShroom
{
    /*0x39ab30*/ MagnetFume();
    /*0x3a8700*/ void Attack(Zombie zombie);
    /*0x3a8790*/ Bullet Shoot1();
}

class MagnetMelon : Melonpult
{
    /*0x398d20*/ MagnetMelon();
    /*0x3a8910*/ BulletType GetBulletType();
}

class MelonFume : Melonpult
{
    /*0x220*/ float timer;
    /*0x228*/ TMPro.TextMeshPro energyText;
    /*0x230*/ TMPro.TextMeshPro energyTextShadow;

    /*0x398d20*/ MelonFume();
    /*0x3a89b0*/ void Awake();
    /*0x3a8aa0*/ BulletType GetBulletType();
    /*0x3a8920*/ void AttributeEvent();
    /*0x3a8ed0*/ void Update();
    /*0x3a8d00*/ void TimerUpdate();
    /*0x3a8cd0*/ void PlantShootUpdate();
    /*0x3a8d40*/ void UniqueEffect(Bullet bullet);
    /*0x3a89d0*/ bool CheckRange(Zombie zombie);
    /*0x3a8ab0*/ UnityEngine.GameObject InitText();
    /*0x3a8da0*/ void UpdateText();
}

class MelonPuff : Thrower
{
    /*0x398d20*/ MelonPuff();
    /*0x3a8f10*/ BulletType GetBulletType();
}

class Melonpult : Thrower
{
    /*0x398d20*/ Melonpult();
    /*0x370110*/ BulletType GetBulletType();
    /*0x3a8f30*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3a8f20*/ void OnCreate(int theColumn, int theRow);
}

class MoneyCabbage : Cabbage
{
    /*0x398d20*/ MoneyCabbage();
    /*0x3a90b0*/ BulletType GetBulletType();
    /*0x3a8f40*/ void AnimSuperShoot();
    /*0x3a90d0*/ void ShootZombie(Zombie zombie);
}

class MoneyCorn : Cornpult
{
    /*0x398d20*/ MoneyCorn();
    /*0x3a9410*/ BulletType GetBulletType();
    /*0x3a93f0*/ BulletType GetBulletType2();
    /*0x3a9370*/ void AnimSuperShoot();
    /*0x3a98b0*/ void ShootZombie(Zombie zombie);
    /*0x3a9430*/ Zombie GetNearestZombie();
}

class MoneyMelon : Melonpult
{
    /*0x398d20*/ MoneyMelon();
    /*0x3a9d00*/ BulletType GetBulletType();
    /*0x3a9b00*/ void AnimSuperShoot();
}

class NutFume : Shooter
{
    /*0x210*/ System.Collections.Generic.List<UnityEngine.GameObject> changes;

    /*0x3aa380*/ NutFume();
    /*0x3a9f50*/ void ReplaceSprite();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x3aa0b0*/ Bullet Shoot1();
    /*0x3aa1e0*/ bool Shootable();
    /*0x3a9d20*/ void PlantShootUpdate();

    class <>c
    {
        static /*0x0*/ NutFume.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__4_0;
        static /*0x10*/ System.Predicate<Plant> <>9__5_0;

        static /*0x3ae8b0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ae880*/ bool <Shootable>b__4_0(Plant p);
        /*0x3ae880*/ bool <PlantShootUpdate>b__5_0(Plant p);
    }
}

class NutShooter : Shooter
{
    /*0x34b660*/ NutShooter();
    /*0x3aa6b0*/ Bullet Shoot1();
    /*0x3aa400*/ void ReplaceSprite();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
}

class PeaFume : Shooter
{
    /*0x34b660*/ PeaFume();
    /*0x3aaa40*/ Bullet Shoot1();
    /*0x3aac90*/ void StartShooting();
    /*0x38a8e0*/ void EndShooting();
    /*0x3aa810*/ void FixedUpdate();
}

class PeaMine : PotatoMine
{
    /*0x35a920*/ PeaMine();
    /*0x3ab150*/ void Update();
    /*0x3aacb0*/ Bullet AnimShoot();
    /*0x3aaff0*/ void SetInterval();
    /*0x3aae20*/ void DieEvent(Plant.DieReason reason);
}

class PeaShooter : Shooter
{
    /*0x34b660*/ PeaShooter();
    /*0x3ab330*/ Bullet Shoot1();
}

class PeaSmallPuff : Shooter
{
    /*0x34b660*/ PeaSmallPuff();
    /*0x3ab450*/ Bullet Shoot1();
}

class PortalCorn : Cornpult
{
    /*0x398d20*/ PortalCorn();
    /*0x3ab5b0*/ void Awake();
    /*0x3ab5e0*/ BulletType GetBulletType();
    /*0x3ab5d0*/ BulletType GetBulletType2();
    /*0x32d010*/ void SetShoot();
}

class PortalMelon : Melonpult
{
    /*0x398d20*/ PortalMelon();
    /*0x3ab5f0*/ BulletType GetBulletType();
}

class PotatoPuff : SmallPuff
{
    /*0x386d10*/ PotatoPuff();
    /*0x3ab780*/ void Awake();
    /*0x3ab600*/ void AttributeEvent();
    /*0x3ab930*/ Bullet Shoot1();
    /*0x3ab7f0*/ void DieEvent(Plant.DieReason reason);
}

class ProtalPea : Shooter
{
    /*0x34b660*/ ProtalPea();
    /*0x3aba80*/ Bullet Shoot1();
}

class RedLunarCabbage : LunarCabbage
{
    /*0x3a8420*/ RedLunarCabbage();
    /*0x3abb90*/ BulletType GetBulletType();
}

class ScaredFume : Shooter
{
    /*0x210*/ int shootType;

    /*0x34b660*/ ScaredFume();
    /*0x3ac750*/ Bullet Shoot1();
    /*0x3abe40*/ void AttackZombie();
    /*0x3abba0*/ void AnimShootFume();
    /*0x3ac250*/ void PlantShootUpdate();
    /*0x3ac390*/ UnityEngine.GameObject SearchZombie();
}

class ScaredyDoom : ScaredyShroom
{
    /*0x34b660*/ ScaredyDoom();
    /*0x3ac9e0*/ Bullet Shoot1();
    /*0x3ac900*/ void ScaredEvent();
    /*0x3ac860*/ void DieEvent(Plant.DieReason reason);
}

class ScaredyHypno : ScaredyShroom
{
    /*0x34b660*/ ScaredyHypno();
    /*0x3acd00*/ Bullet Shoot1();
}

class ScaredyNut : Plant
{
    /*0x208*/ UnityEngine.GameObject head;
    /*0x210*/ float timer;
    /*0x214*/ float timer2;

    /*0x348cd0*/ ScaredyNut();
    /*0x3ad190*/ void FixedUpdate();
    /*0x3ad5b0*/ void TakeDamage(int damage, int damageType);
    /*0x3ad530*/ void ReplaceSprite();
    /*0x3ad270*/ void GetNearZombies();
    /*0x3ace50*/ void Action();
    /*0x32d010*/ void ScaredEvent();
}

class ScaredyPotato : ScaredyShroom
{
    /*0x34b660*/ ScaredyPotato();
    /*0x3adc20*/ void Start();
    /*0x3ad860*/ void GetNearZombies();
    /*0x3ada70*/ Bullet Shoot1();
    /*0x3ad650*/ void AttributeEvent();
    /*0x3ad720*/ void DieEvent(Plant.DieReason reason);
}

class ScaredyShroom : Shooter
{
    /*0x34b660*/ ScaredyShroom();
    /*0x3adc50*/ void FixedUpdate();
    /*0x3add30*/ void GetNearZombies();
    /*0x32d010*/ void ScaredEvent();
    /*0x3adf40*/ Bullet Shoot1();
    /*0x3ae090*/ bool Shootable();
}

class ScaredySun : Producer
{
    /*0x34b060*/ ScaredySun();
    /*0x3ae0c0*/ void FixedUpdate();
    /*0x3ae1a0*/ void GetNearZombies();
    /*0x3ae380*/ void ProducerUpdate();
}

class SeaCactus : Shooter
{
    /*0x210*/ int growLevel;

    /*0x34b660*/ SeaCactus();
    /*0x389d70*/ void Start();
    /*0x3ae9b0*/ void AttributeEvent();
    /*0x3aea50*/ void Grow();
    /*0x3af130*/ Bullet Shoot1();
    /*0x3af230*/ Bullet Shoot2();
    /*0x3aeae0*/ void PlantShootUpdate();
    /*0x3aed70*/ UnityEngine.GameObject SearchZombie();
    /*0x3aeca0*/ bool SearchUniqueZombie(Zombie zombie);
}

class SeaFume : FumeShroom
{
    /*0x3af670*/ SeaFume();
    /*0x3af440*/ void AttributeEvent();
    /*0x3af3d0*/ void Attack(Zombie zombie);
    /*0x3af4e0*/ Bullet Shoot1();
    /*0x3af470*/ void Eat();
}

class SeaScaedyshroom : ScaredyShroom
{
    /*0x210*/ UnityEngine.Transform seashroom;

    /*0x386d10*/ SeaScaedyshroom();
    /*0x3af680*/ void AttributeEvent();
    /*0x3af700*/ void GetNearZombies();
    /*0x3af6a0*/ void EatSeashroom();
    /*0x3af770*/ void SeashroomEnterWater();
}

class SeaStarfruit : StarFruit
{
    /*0x210*/ int growLevel;

    /*0x34b660*/ SeaStarfruit();
    /*0x3afb10*/ void Start();
    /*0x3af8c0*/ void AttributeEvent();
    /*0x3af960*/ void Grow();
    /*0x3af9f0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
}

class SmallPuff : Shooter
{
    /*0x34b660*/ SmallPuff();
    /*0x3afb30*/ UnityEngine.GameObject SearchZombie();
    /*0x3afde0*/ Bullet Shoot1();
}

class SniperPea : Shooter
{
    /*0x210*/ int attackCount;
    /*0x218*/ UnityEngine.GameObject ac;
    /*0x220*/ UnityEngine.Rendering.SortingGroup r;

    /*0x34b660*/ SniperPea();
    /*0x3b0340*/ void Awake();
    /*0x3b0c00*/ void Update();
    /*0x3b0420*/ void FixedUpdate();
    /*0x3b04e0*/ void PlantShootUpdate();
    /*0x3afef0*/ void AcPositionUpdate();
    /*0x3b09c0*/ Bullet Shoot1();
    /*0x3b0180*/ void AttackZombie(Zombie zombie, int damage, DmgType theDamageType);
    /*0x3b0670*/ UnityEngine.GameObject SearchZombie();
    /*0x3b05d0*/ bool SearchUniqueZombie(Zombie zombie);
}

class SniperPuff : Shooter
{
    /*0x210*/ int shootCount;

    /*0x34b660*/ SniperPuff();
    /*0x3b0c80*/ void AttributeEvent();
    /*0x3b0dd0*/ UnityEngine.GameObject SearchZombie();
    /*0x3b1000*/ Bullet Shoot1();
    /*0x3b16f0*/ void UpdateAttackCountDown();
    /*0x3b12a0*/ Bullet Shoot2();
    /*0x3b0ce0*/ bool CheckZombie(Zombie zombie);
}

class SnowGatlingPuff : IcePuff
{
    /*0x386d10*/ SnowGatlingPuff();
    /*0x3b1720*/ Bullet Shoot1();
}

class SnowPeaShooter : PeaShooter
{
    /*0x386d10*/ SnowPeaShooter();
    /*0x3b1a40*/ Bullet Shoot1();
    /*0x3b18b0*/ BulletType GetBulletType();
}

class SnowSplit : SplitPea
{
    /*0x386d10*/ SnowSplit();
    /*0x374ff0*/ void Awake();
    /*0x3b1d10*/ Bullet Shoot1();
    /*0x3b1f60*/ Bullet Shoot2();
    /*0x3b1b80*/ BulletType GetBulletType();
}

class SolarCabbage : Thrower
{
    /*0x220*/ UnityEngine.Rendering.SortingGroup back;
    /*0x228*/ UnityEngine.GameObject solarBombPrefab;

    /*0x398d20*/ SolarCabbage();
    /*0x3b21c0*/ void Awake();
    /*0x3b2080*/ void AttributeEvent();
    /*0x3b2570*/ void UniqueEffect(Bullet bullet);
    /*0x3b2270*/ BulletType GetBulletType();
    /*0x3b2320*/ bool SuperSkill();
    /*0x3b2280*/ void OnCreate(int theColumn, int theRow);
    /*0x3b22b0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3b2530*/ void SuperStart();
    /*0x3b22e0*/ void SuperEnd();
}

class SplitPea : PeaShooter
{
    /*0x386d10*/ SplitPea();
    /*0x3b2810*/ Bullet Shoot1();
    /*0x3b2960*/ Bullet Shoot2();
    /*0x3b2630*/ UnityEngine.GameObject SearchZombie();
}

class SplitPuff : SplitPea
{
    /*0x386d10*/ SplitPuff();
    /*0x3b2ab0*/ Bullet Shoot1();
    /*0x3b2bf0*/ Bullet Shoot2();
}

class SpruceBallista : Shooter
{
    /*0x34b660*/ SpruceBallista();
    /*0x3b2d20*/ BulletType GetBulletType();
    /*0x3b2d30*/ Bullet Shoot1();
}

class SpruceShooter : Shooter
{
    /*0x34b660*/ SpruceShooter();
    /*0x3b2e70*/ Bullet Shoot1();
}

class SpruceShulk : Shooter
{
    /*0x34b660*/ SpruceShulk();
    /*0x3b2fa0*/ Bullet Shoot1();
}

class StarFruit : Shooter
{
    /*0x34b660*/ StarFruit();
    /*0x3b39d0*/ Bullet Shoot1();
    /*0x3b38b0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3b31f0*/ UnityEngine.GameObject SearchZombie();
}

class StarFruitIron : StarFruit
{
    /*0x34b660*/ StarFruitIron();
    /*0x3b30d0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
}

class StarfruitJackbox : StarFruit
{
    /*0x34b660*/ StarfruitJackbox();
    /*0x3b4880*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
}

class StarfruitMagnet : StarFruit
{
    /*0x34b660*/ StarfruitMagnet();
    /*0x3b49a0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
}

class StarfruitPickaxe : StarFruit
{
    /*0x34b660*/ StarfruitPickaxe();
    /*0x3b4ac0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x32d010*/ void TakeDamage(int damage, int damageType);
}

class StarPuff : StarFruit
{
    /*0x34b660*/ StarPuff();
}

class StarScaredyShroom : ScaredyShroom
{
    /*0x210*/ System.Collections.Generic.List<UnityEngine.Transform> shoots;

    /*0x3b4310*/ StarScaredyShroom();
    /*0x3b3be0*/ void GetNearZombies();
    /*0x3b4070*/ Bullet Shoot1();
    /*0x3b3fc0*/ void PlantShootUpdate();
}

class StarTorch : TorchWood
{
    /*0x34b060*/ StarTorch();
    /*0x3b45a0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3b4390*/ void FireStar(Bullet bullet);
}

class SunCabbage : Cabbage
{
    /*0x3a8420*/ SunCabbage();
    /*0x3b2270*/ BulletType GetBulletType();
    /*0x3b4be0*/ void OnCreate(int theColumn, int theRow);
    /*0x3b4c10*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
}

class SunGatlingPuff : Shooter
{
    /*0x34b660*/ SunGatlingPuff();
    /*0x3b4c40*/ Bullet Shoot1();
}

class SunStar : Plant
{
    /*0x348cd0*/ SunStar();
    /*0x3b4d90*/ void AnimShoot();
    /*0x3b4fa0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3b5140*/ void Update();
    /*0x3b50c0*/ void Shoot();
}

class SuperCherryShooter : Shooter
{
    /*0x34b660*/ SuperCherryShooter();
    /*0x3b5240*/ Bullet Shoot1();
    /*0x3b51f0*/ void FirstMeet();
    /*0x3b5350*/ void TakeDamage(int damage, int damageType);
}

class SuperDoomScaredy : ScaredyDoom
{
    /*0x210*/ int doomTimes;
    /*0x214*/ float timer;
    /*0x218*/ UnityEngine.ParticleSystem particle;

    /*0x386d10*/ SuperDoomScaredy();
    /*0x3b5910*/ void Start();
    /*0x3b5360*/ void FixedUpdate();
    /*0x3b5600*/ void ScaredEvent();
    /*0x3b5690*/ Bullet Shoot1();
}

class SuperGatling : SuperSnowGatling
{
    /*0x34b660*/ SuperGatling();
    /*0x3b5960*/ void FirstMeet();
    /*0x3b59b0*/ BulletType GetBulletType();
}

class SuperHypno : PeaShooter
{
    /*0x386d10*/ SuperHypno();
    /*0x3b5bd0*/ Bullet Shoot1();
}

class SuperHypnoGatling : SuperSnowGatling
{
    /*0x34b660*/ SuperHypnoGatling();
    /*0x3b5bc0*/ BulletType GetBulletType();
}

class SuperKelp : SquashKelp
{
    /*0x3b62a0*/ SuperKelp();
    /*0x3b6270*/ void Update();
    /*0x3b5fe0*/ void FirstMeet();
    /*0x3b5d20*/ void AnimShoot();
    /*0x3b6030*/ UnityEngine.GameObject SearchZombie();
}

class SuperMelon : Thrower
{
    /*0x398d20*/ SuperMelon();
    /*0x3b63c0*/ void Start();
    /*0x3b62b0*/ BulletType GetBulletType();
    /*0x3b62c0*/ void OnCreate(int theColumn, int theRow);
    /*0x3b6340*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3b63e0*/ void UniqueEffect(Bullet bullet);
}

class SuperSnowGatling : Shooter
{
    /*0x210*/ float timer;

    /*0x34b660*/ SuperSnowGatling();
    /*0x3b6a40*/ Bullet Shoot1();
    /*0x3b67e0*/ BulletType GetBulletType();
    /*0x3b6dd0*/ void Update();
    /*0x3b6970*/ void PlantShootUpdate();
    /*0x3b6da0*/ void TakeDamage(int damage, int damageType);
    /*0x3b67b0*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x3b6460*/ void AttributeEvent();
    /*0x3b6c80*/ void SuperShoot(float angle, float speed, float x, float y);
}

class SuperSpruce : WaterSpruce
{
    /*0x228*/ UnityEngine.SpriteRenderer leaf;

    /*0x39ce90*/ SuperSpruce();
    /*0x3b6e80*/ Bullet Shoot1();
    /*0x3b7040*/ void UpdateText();
}

class SuperStarfruit : LanternStarFruit
{
    /*0x39ce90*/ SuperStarfruit();
    /*0x3b7380*/ void Update();
    /*0x3b71f0*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3b7120*/ void OnCreate(int theColumn, int theRow);
}

class SuperThreeGatling : ThreePeater
{
    /*0x210*/ float timer;
    /*0x214*/ int _p;

    /*0x3b7be0*/ SuperThreeGatling();
    /*0x3b7950*/ Bullet Shoot1();
    /*0x3b7b40*/ void Update();
    /*0x3b7880*/ void PlantShootUpdate();
    /*0x3b7b20*/ void TakeDamage(int damage, int damageType);
    /*0x3b7860*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x3b73d0*/ void AttributeEvent();
    /*0x3b7a10*/ void SuperShoot(float angle, float speed, float x, float y, BulletMoveWay bulletMoveWay, int row);
}

class SuperThreePeater : ThreePeater
{
    /*0x34b660*/ SuperThreePeater();
    /*0x3b7c90*/ BulletType GetBulletType();
    /*0x3b7c00*/ void DieEvent(Plant.DieReason reason);
    /*0x3b7ca0*/ Bullet Shoot1();
}

class SwordStarfruit : StarFruit
{
    /*0x34b660*/ SwordStarfruit();
    /*0x3b8050*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3b7de0*/ void AnimAttack();
    /*0x3b7ee0*/ UnityEngine.GameObject SearchZombie();
}

class Threekelp : Tanglekelp
{
    /*0x3b62a0*/ Threekelp();
    /*0x3ba2d0*/ void Update();
    /*0x3b9d80*/ void AnimShoot();
    /*0x3ba090*/ UnityEngine.GameObject SearchZombie();
}

class ThreeMine : ThreePeater
{
    /*0x210*/ bool shooting;
    /*0x214*/ float shootingTimer;
    /*0x218*/ float shootingCD;

    /*0x34b660*/ ThreeMine();
    /*0x3b82a0*/ void Awake();
    /*0x3b8f60*/ void Update();
    /*0x3b8f40*/ void PlantShootUpdate();
    /*0x3b89a0*/ void FixedUpdate();
    /*0x3b81b0*/ void AttributeEvent();
    /*0x3b8e30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3b82e0*/ bool CheckZombie(Zombie zombie);
    /*0x3b83d0*/ Zombie DetectFirstZombie();
    /*0x3b8380*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x3b86d0*/ void Explode();
    /*0x3b8e20*/ BulletType GetBulletType();

    class <>c
    {
        static /*0x0*/ ThreeMine.<> <>9;
        static /*0x8*/ System.Action<Zombie> <>9__12_0;

        static /*0x3ba6e0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ba6a0*/ void <Explode>b__12_0(Zombie zombie);
    }
}

class ThreePeater : Shooter
{
    /*0x34b660*/ ThreePeater();
    /*0x3b93f0*/ Bullet Shoot1();
    /*0x3b96e0*/ void ShootUpper(float X, float Y, int row);
    /*0x3b9610*/ void ShootLower(float X, float Y, int row);
    /*0x3b9090*/ void ExtraBullet();
    /*0x3b91b0*/ UnityEngine.GameObject SearchZombie();
    /*0x388e90*/ BulletType GetBulletType();
}

class ThreeSquash : ThreePeater
{
    /*0x34b660*/ ThreeSquash();
    /*0x3b98e0*/ Bullet Shoot1();
    /*0x3b9cd0*/ void ShootUpper(float X, float Y, int row);
    /*0x3b9c20*/ void ShootLower(float X, float Y, int row);
    /*0x3b97b0*/ void ExtraBullet();
}

class UltimateBigGatling : BigGatling
{
    /*0x3badd0*/ UltimateBigGatling();
    /*0x3ba870*/ void PlantShootUpdate();
    /*0x3ba7c0*/ int GetDamage(int damage);
    /*0x3bacd0*/ void Update();
    /*0x3ba980*/ Bullet Shoot1();
    /*0x348b00*/ bool Instead(int theDamage);
}

class UltimateBigSniper : Shooter
{
    /*0x210*/ UnityEngine.Transform headPos;
    /*0x218*/ UnityEngine.GameObject laserPrefab;
    /*0x220*/ UnityEngine.Transform laserStart;
    /*0x228*/ System.Collections.Generic.List<UnityEngine.LineRenderer> lasers;
    /*0x230*/ float angle;
    /*0x234*/ float maxAngle;

    /*0x3bc9c0*/ UltimateBigSniper();
    /*0x3bc8a0*/ void Update();
    /*0x3bbb90*/ void PlantShootUpdate();
    /*0x3bb430*/ int GetAttackDamage();
    /*0x3bb550*/ int GetDamage(int damage);
    /*0x3bc700*/ Bullet Shoot1();
    /*0x3bb000*/ void DrawLines();
    /*0x3bae00*/ void DrawLine(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
    /*0x3bb9f0*/ void KillLine();
    /*0x3bade0*/ void DieEvent(Plant.DieReason reason);
    /*0x3bbc60*/ void RestShoots();
    /*0x3bb600*/ void HitZombies(UnityEngine.Vector2 startPositon, float angle);
    /*0x3bc0d0*/ UnityEngine.GameObject SearchZombie();
    /*0x3bbd90*/ bool SearchUltimatePlantern();
    /*0x348b00*/ bool Instead(int theDamage);
}

class UltimateCactus : Cactus
{
    /*0x210*/ float shootTimer;
    /*0x214*/ float shootTimer2;
    /*0x218*/ TMPro.TextMeshPro energyText;
    /*0x220*/ TMPro.TextMeshPro energyTextShadow;

    /*0x386d10*/ UltimateCactus();
    /*0x3bca50*/ void Awake();
    /*0x3bcd80*/ void KillZombie(Zombie zombie);
    /*0x3bcec0*/ void TakeDamage(int damage, int damageType);
    /*0x3bca70*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x3bce30*/ void OnCreate(int theColumn, int theRow);
    /*0x3bcaf0*/ BulletType GetBulletType();
    /*0x3bce80*/ void StartShooting();
    /*0x3bcea0*/ void StopShooting();
    /*0x3bd0a0*/ void Update();
    /*0x3bcb00*/ UnityEngine.GameObject InitText();
    /*0x3bcf20*/ void UpdateText();
}

class UltimateCorn : Cornpult
{
    /*0x3a8420*/ UltimateCorn();
    /*0x3bd330*/ BulletType GetBulletType();
    /*0x3bd320*/ BulletType GetBulletType2();
}

class UltimateFume : IceDoomFume
{
    /*0x210*/ UnityEngine.ParticleSystem particle;
    /*0x218*/ UnityEngine.ParticleSystem.EmissionModule emission;

    /*0x386d10*/ UltimateFume();
    /*0x3bd5e0*/ void Awake();
    /*0x3bd7f0*/ void FirstMeet();
    /*0x3bd840*/ void PlantShootUpdate();
    /*0x3bd730*/ void EnableParticle();
    /*0x3bd710*/ void DisableParticle();
    /*0x3bd340*/ void AttackZombie2();
    /*0x3bd3a0*/ void AttackZombie();
    /*0x3bdcc0*/ void TrySetMindControl(Zombie zombie);
    /*0x3bd990*/ void SmallDoom(Zombie z);
}

class UltimateGatling : SuperCherryShooter
{
    /*0x34b660*/ UltimateGatling();
    /*0x3bdf60*/ void FirstMeet();
    /*0x3be470*/ void UpdateAttackCountDown();
    /*0x3bdfb0*/ Bullet Shoot1();
}

class UltimateHypno : Shooter
{
    /*0x210*/ UnityEngine.GameObject mag1;
    /*0x218*/ UnityEngine.GameObject mag2;
    /*0x220*/ UnityEngine.GameObject mag3;

    /*0x34b660*/ UltimateHypno();
    /*0x3be6d0*/ Bullet Shoot1();
    /*0x3be4f0*/ void PlantShootUpdate();
    /*0x3be800*/ void Update();
    /*0x3af680*/ void AttributeEvent();
    /*0x3be9a0*/ bool UseItem(BucketType type, Bucket bucket);
}

class UltimateKelp : SuperKelp
{
    /*0x3b62a0*/ UltimateKelp();
    /*0x3beae0*/ void AnimShoot();
    /*0x3beda0*/ System.Collections.IEnumerator Moving();

    class <Moving>d__1 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UltimateKelp <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x32f460*/ <Moving>d__1(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ba350*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ba640*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class UltimateMelon : SuperMelon
{
    /*0x398d20*/ UltimateMelon();
    /*0x3bee10*/ void Awake();
    /*0x3bf7e0*/ BulletType GetBulletType();
    /*0x3bfa20*/ void OnCreate(int theColumn, int theRow);
    /*0x3bfaa0*/ void OnMove(int originalColumn, int originalRow, int newColumn, int newRow);
    /*0x3bfb20*/ void UniqueEffect(Bullet bullet);
    /*0x3bee30*/ void ExtraShoot();
    /*0x3bf7f0*/ Plant GetUmbrella();
}

class UltimateMinigun : Shooter
{
    /*0x34b660*/ UltimateMinigun();
    /*0x3bfd70*/ bool Shootable();
    /*0x3bfde0*/ void Start();
    /*0x3bfc40*/ Bullet Shoot1();
}

class UltimatePuff : UltimateMelon
{
    /*0x398d20*/ UltimatePuff();
    /*0x3bff10*/ BulletType GetBulletType();
}

class UltimateSpring : MelonFume
{
    /*0x3a8420*/ UltimateSpring();
    /*0x3c01b0*/ BulletType GetBulletType();
    /*0x3c0350*/ void UniqueEffect(Bullet bullet);
    /*0x3c0270*/ void TimerUpdate();
    /*0x3c01c0*/ void ShootByMouse(UnityEngine.Vector2 targetPosition);
    /*0x3bff20*/ void AnimShootByMouse();
}

class UltimateSpruce : Shooter
{
    /*0x210*/ TMPro.TextMeshPro energyText;
    /*0x218*/ TMPro.TextMeshPro energyTextShadow;

    /*0x34b660*/ UltimateSpruce();
    /*0x3695e0*/ void Awake();
    /*0x3c0a70*/ void StealHealth();
    /*0x3c0930*/ Bullet Shoot1();
    /*0x3c0400*/ void AttributeEvent();
    /*0x3c0740*/ UnityEngine.GameObject InitText();
    /*0x3c0a90*/ void UpdateText();

    class <>c
    {
        static /*0x0*/ UltimateSpruce.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__3_0;

        static /*0x3ba750*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ba680*/ bool <AttributeEvent>b__3_0(Plant p);
    }
}

class UltimateStar : StarFruit
{
    /*0x34b660*/ UltimateStar();
    /*0x3c1700*/ void FirstMeet();
    /*0x3c1e70*/ void Update();
    /*0x3c1b20*/ void SetBullet(UnityEngine.Transform _transform, int theMovingWay);
    /*0x3c1860*/ UnityEngine.GameObject SearchZombie();
    /*0x3c1750*/ void PlantShootUpdate();
}

class UltimateStarTorch : UltimateTorch
{
    /*0x349420*/ UltimateStarTorch();
    /*0x3c0dd0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3c1320*/ bool SummonPlant(int dmg);
    /*0x3c0b90*/ void FireStar(Bullet bullet);
}

class UltimateSunflower : Producer
{
    /*0x208*/ UnityEngine.GameObject blink;
    /*0x210*/ TMPro.TextMeshPro energyText;
    /*0x218*/ TMPro.TextMeshPro energyTextShadow;

    /*0x34b060*/ UltimateSunflower();
    /*0x3c27c0*/ bool SuperSkill();
    /*0x3c20e0*/ void ProduceSun();
    /*0x3c26b0*/ void SunAction(int value);
    /*0x3c2550*/ void Shoot(int damage);
    /*0x3c1ef0*/ UnityEngine.GameObject InitText();
    /*0x3c2930*/ void UpdateText();
}

class WaterBallista : SpruceBallista
{
    /*0x210*/ int magazine;
    /*0x214*/ float FillingTimer;

    /*0x386d10*/ WaterBallista();
    /*0x3d7540*/ void PlantShootUpdate();
    /*0x3d7670*/ Bullet Shoot1();
    /*0x3d77b0*/ Bullet Shoot2();
}

class WaterSpruce : SpruceShooter
{
    /*0x210*/ UnityEngine.GameObject ice;
    /*0x218*/ TMPro.TextMeshPro energyText;
    /*0x220*/ TMPro.TextMeshPro energyTextShadow;

    /*0x386d10*/ WaterSpruce();
    /*0x3d7b20*/ Bullet Shoot1();
    /*0x3d78f0*/ BulletType GetBulletType();
    /*0x3d7930*/ UnityEngine.GameObject InitText();
    /*0x3d7c70*/ void UpdateText();
}

class WinterMelon : Melonpult
{
    /*0x3a8420*/ WinterMelon();
    /*0x3d7dd0*/ BulletType GetBulletType();
}

class Thrower : Shooter
{
    /*0x210*/ UnityEngine.Vector2 firstPostion;
    /*0x218*/ float flightTime;
    /*0x21c*/ float firstTime;

    static /*0x3cce40*/ bool ThrowSearchZombie(Zombie zombie);
    /*0x3cd2c0*/ Thrower();
    /*0x3cb8b0*/ void Awake();
    /*0x3cbbb0*/ void SetShoot();
    /*0x3cb8e0*/ bool CheckRange(Zombie zombie);
    /*0x3ccf60*/ Zombie ThrowerSearchZombie();
    /*0x3cba30*/ void PlantShootUpdate();
    /*0x3ccbe0*/ void ShootZombie(Zombie zombie);
    /*0x3cbc60*/ Bullet Shoot1();
    /*0x3cc430*/ Bullet Shoot2();
    /*0x32d010*/ void UniqueEffect(Bullet bullet);
    /*0x388e90*/ BulletType GetBulletType();
    /*0x388e90*/ BulletType GetBulletType2();
    /*0x3cb940*/ UnityEngine.Vector2 GetZombiePosition(Zombie zombie);
}

class TowerNut : TowerPlant
{
    /*0x3cd3d0*/ TowerNut();
    /*0x348ca0*/ void TakeDamage(int damage, int damageType);
    /*0x348b00*/ bool Shootable();
    /*0x3986e0*/ void ReplaceSprite();
    /*0x3cd2e0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x35a990*/ void FixedUpdate();
}

class TowerPlant : Plant
{
    /*0x208*/ Towards towards;
    /*0x20c*/ TowerUpgradeType upgradeType;
    /*0x210*/ float basicDamage;
    /*0x214*/ float attackSpeed;
    /*0x218*/ float attackTimer;
    /*0x21c*/ float attackInterval;

    /*0x3cd3d0*/ TowerPlant();
    /*0x3ce1a0*/ int get_Damage();
    /*0x3ce1c0*/ BulletMoveWay get_TowardsMoveWay();
    /*0x3cd440*/ void Awake();
    /*0x3cdcc0*/ void Start();
    /*0x3cda80*/ void SetTowards(Towards towards);
    /*0x3cdce0*/ void Update();
    /*0x3cdb80*/ void ShootUpdate();
    /*0x3cdc80*/ bool Shootable();
    /*0x3cd470*/ bool CheckGrave();
    /*0x3cdc30*/ void Shoot();
    /*0x3cd900*/ void SetSpeed(float value);
    /*0x32d010*/ void AnimShoot();
    /*0x3cd760*/ UnityEngine.GameObject SearchZombie();
    /*0x3cd630*/ bool CheckZombie(Zombie zombie);
    /*0x3cd400*/ void AddDamage(float value);
    /*0x3cd420*/ void AddSpeed(float value);
    /*0x3cdd20*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3cd730*/ string GetUniqueText();

    class <>c
    {
        static /*0x0*/ TowerPlant.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.AnimatorControllerParameter, bool> <>9__18_0;

        static /*0x3d7460*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3d7370*/ bool <SetSpeed>b__18_0(UnityEngine.AnimatorControllerParameter param);
    }
}

enum TowerUpgradeType
{
    Default = 0,
    Upgraded = 1,
    BranchA = 2,
    BranchB = 3,
}

class TowerProducer : TowerPlant
{
    /*0x3cd3d0*/ TowerProducer();
    /*0x3ce1e0*/ void Shoot();
    /*0x32d010*/ void ProduceSun();
    /*0x3ce290*/ bool Shootable();
    /*0x3ce2a0*/ System.Collections.IEnumerator SunBright();

    class <SunBright>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ TowerProducer <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <SunBright>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3d70d0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3d7250*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Tower_BigSunShroom : TowerProducer
{
    /*0x220*/ float amplifier;
    /*0x228*/ TMPro.TextMeshPro energyText;
    /*0x230*/ TMPro.TextMeshPro energyTextShadow;

    /*0x3ce9b0*/ Tower_BigSunShroom();
    /*0x3ce3b0*/ string GetUniqueText();
    /*0x3ce940*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3ce310*/ void ChargeBySun(CoinSun sun);
    /*0x3ce790*/ void SunAction(int value);
    /*0x3ce610*/ void ProduceSun();
    /*0x3ce420*/ UnityEngine.GameObject InitText();
    /*0x3ce840*/ void UpdateText();
}

class Tower_cherryChomper : TowerPlant
{
    /*0x220*/ UnityEngine.Vector2 pos;
    /*0x228*/ float swallowMaxCountDown;
    /*0x22c*/ bool canToChew;
    /*0x230*/ UnityEngine.Vector2 range;
    /*0x238*/ UnityEngine.Vector2 centerOffset;

    /*0x3cf490*/ Tower_cherryChomper();
    /*0x3cf1e0*/ string GetUniqueText();
    /*0x348b00*/ bool Shootable();
    /*0x3cf410*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3cea00*/ void Awake();
    /*0x3cf250*/ void SetAttackRange();
    /*0x3cf3c0*/ void Update();
    /*0x3ce9e0*/ void AttributeEvent();
    /*0x3cf2f0*/ void Swallow();
    /*0x3ced20*/ void ChomperSearchZombie(UnityEngine.Collider2D collision);
    /*0x350c80*/ bool CheckZombie(Zombie zombie);
    /*0x3cf190*/ void FixedUpdate();
    /*0x3cea40*/ void BiteEvent();
    /*0x3cec20*/ void Chomp(Zombie zombie);
    /*0x3ceb80*/ void ChompBack();
    /*0x3cf360*/ void ToChew();
}

class Tower_cherryShooter : TowerPlant
{
    /*0x3cd3d0*/ Tower_cherryShooter();
    /*0x3cf4c0*/ void AnimShoot();
    /*0x3cf610*/ void Upgrade(TowerUpgradeType towerUpgradeType);
}

class Tower_doomFume : TowerPlant
{
    /*0x3cd3d0*/ Tower_doomFume();
    /*0x3cfcc0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3cfba0*/ void ShootUpdate();
    /*0x3cfc50*/ void Shoot();
    /*0x3cf680*/ void AnimShoot();
    /*0x3cf950*/ void AttackZombie();
}

class Tower_electricOnion : TowerPlant
{
    /*0x220*/ UnityEngine.GameObject prism;

    /*0x3cd3d0*/ Tower_electricOnion();
    /*0x3d1a00*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x348b00*/ bool Shootable();
    /*0x3d0f40*/ void Awake();
    /*0x3d0f00*/ void AttributeEvent();
    /*0x3d1870*/ void SetBrightness(float b);
    /*0x3d0ba0*/ void AttackOtherZombie(Zombie basicZombie, UnityEngine.Vector2 center, int damage);
    /*0x3d0f80*/ UnityEngine.GameObject CreateLine(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 endPosition, float width);
    /*0x3cfd30*/ void AnimShoot();
    /*0x3d1400*/ void SearchZombieUpdate();
    /*0x3d11d0*/ System.Collections.Generic.List<Plant> GetOtherPrismflowers();
    /*0x37b880*/ bool <GetOtherPrismflowers>b__10_0(Plant n);
}

class Tower_iceGloom : TowerPlant
{
    /*0x220*/ float slowTimer;
    /*0x224*/ int freezeLevel;

    /*0x3d1f60*/ Tower_iceGloom();
    /*0x3d1d30*/ string GetUniqueText();
    /*0x3d1f00*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d1ac0*/ void AttackZombie();
    /*0x3d1a50*/ void AnimShoot();
    /*0x3d1da0*/ UnityEngine.GameObject SearchZombie();
}

class Tower_peaPuff : TowerPlant
{
    /*0x3cd3d0*/ Tower_peaPuff();
    /*0x3d1f90*/ void AnimShoot();
    /*0x3d20d0*/ BulletType GetBulletType();
    /*0x3d20f0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
}

class Tower_peasunflower : TowerPlant
{
    /*0x3cd3d0*/ Tower_peasunflower();
    /*0x3d2150*/ void AnimShoot();
    /*0x3d22c0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
}

class Tower_scaredyfume : TowerPlant
{
    /*0x220*/ float attackRange;

    /*0x3d2d00*/ Tower_scaredyfume();
    /*0x3d26c0*/ void AnimShoot();
    /*0x3d2340*/ void AnimShoot2();
    /*0x3d2c70*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d2af0*/ void Shoot();
    /*0x3d28e0*/ bool FumeCheckZombie(Zombie zombie);
    /*0x3d27e0*/ void AttackZombie();
}

class Tower_squashNut : TowerNut
{
    /*0x220*/ System.Collections.Generic.List<UnityEngine.Collider2D> collider2Ds;

    /*0x3cd3d0*/ Tower_squashNut();
    /*0x3d39a0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d3430*/ void Awake();
    /*0x3d34c0*/ void FixedUpdate();
    /*0x3d36c0*/ void SearchZombieUpdate();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3d3890*/ void StartJump();
    /*0x3d2d30*/ void AnimCrash();
}

class Tower_starNut : TowerNut
{
    /*0x3cd3d0*/ Tower_starNut();
    /*0x3d3c50*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d3a00*/ void AttributeEvent();
    /*0x3d3ba0*/ void TakeDamage(int damage, int damageType);
    /*0x3d3a40*/ void SetBullet(int theMovingWay, float angle);
}

class Tower_sunmine : TowerPlant
{
    /*0x220*/ bool isAready;
    /*0x228*/ UnityEngine.GameObject nearestZombie;
    /*0x230*/ float flashInterval;
    /*0x234*/ float flashTime;
    /*0x238*/ bool isActive;
    /*0x239*/ bool explode;
    /*0x23c*/ float explodeRange;

    /*0x3d4d10*/ Tower_sunmine();
    /*0x3d4ca0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x348b00*/ bool Shootable();
    /*0x3d4260*/ void Awake();
    /*0x3d4aa0*/ void Update();
    /*0x3d4840*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3d4900*/ bool PotatoSearchZombie(Zombie zombie);
    /*0x34a6d0*/ void DelayDie();
    /*0x3d4030*/ void AnimStartRise();
    /*0x3d4020*/ void AnimRiseOver();
    /*0x3d4330*/ void Explode();
    /*0x3d42b0*/ void BombEffect();
    /*0x3d4950*/ void SetFlash();
    /*0x3d4550*/ UnityEngine.GameObject GetNearestZombie();
}

class Tower_sunShroom : TowerProducer
{
    /*0x3cd3d0*/ Tower_sunShroom();
    /*0x3d3cf0*/ void Awake();
    /*0x3d3cd0*/ void AttributeEvent();
    /*0x3d3d30*/ void Grow();
    /*0x3d3dc0*/ void ProduceSun();
    /*0x3d3fb0*/ void Upgrade(TowerUpgradeType towerUpgradeType);
}

class Tower_threeMine : TowerPlant
{
    /*0x220*/ bool shooting;
    /*0x224*/ float shootingTimer;
    /*0x228*/ float shootingCD;

    /*0x3cd3d0*/ Tower_threeMine();
    /*0x3d51e0*/ void Awake();
    /*0x3d4d50*/ void AnimShoot();
    /*0x3d6270*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d6160*/ void Update();
    /*0x3d60b0*/ void SuperUpdate();
    /*0x3d6060*/ bool Shootable();
    /*0x3d5af0*/ void FixedUpdate();
    /*0x3d5100*/ void AttributeEvent();
    /*0x3d5f90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3d5400*/ bool CheckZombie(Zombie zombie);
    /*0x3d5230*/ bool CheckGrave();
    /*0x3d5590*/ Zombie DetectFirstZombie();
    /*0x3d5540*/ void Crashed(int level, int soundID, Zombie zombie);
    /*0x3d5820*/ void Explode();

    class <>c
    {
        static /*0x0*/ Tower_threeMine.<> <>9;
        static /*0x8*/ System.Action<Zombie> <>9__16_0;

        static /*0x3d74d0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ba6a0*/ void <Explode>b__16_0(Zombie zombie);
    }
}

class Tower_waterCan : TowerPlant
{
    /*0x3cd3d0*/ Tower_waterCan();
    /*0x3d6870*/ void Upgrade(TowerUpgradeType towerUpgradeType);
    /*0x3d6740*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3d62c0*/ void AnimShoot();
    /*0x348b00*/ bool CheckGrave();
    /*0x3d6660*/ bool CheckZombie(Zombie zombie);
}

class Preview : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Transform axis;

    /*0x31c640*/ Preview();
}

class PrizeMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ float horizontalSpeed;
    /*0x24*/ float verticalSpeed;
    /*0x28*/ float gravity;
    /*0x2c*/ UnityEngine.Vector2 velocity;
    /*0x34*/ UnityEngine.Vector2 startPosition;
    /*0x3c*/ bool isLand;
    /*0x3d*/ bool isClicked;
    /*0x3e*/ bool selectAdv;
    /*0x3f*/ bool fake;

    /*0x3c7dd0*/ PrizeMgr();
    /*0x3c7750*/ void Start();
    /*0x3c7d80*/ void Update();
    /*0x3c6e90*/ void PostionUpdate();
    /*0x3c5f70*/ void Click();
    /*0x3c61f0*/ void Clicked();
    /*0x3c5bf0*/ void AdvantureSettings();
    /*0x3c7910*/ void TravelAchievement();
    /*0x3c6a80*/ void GoBack();
    /*0x3c6e20*/ System.Collections.IEnumerator MoveAndScaleObject();
    /*0x3c70b0*/ void RestartBoss2();
    /*0x3c6db0*/ System.Collections.IEnumerator LightOutT();
    /*0x3c6800*/ void CompleteAbyssLevel();

    class <LightOutT>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ PrizeMgr <>4__this;
        /*0x28*/ UnityEngine.Vector3 <initialScale>5__2;
        /*0x34*/ UnityEngine.Vector3 <targetScale>5__3;
        /*0x40*/ float <speed>5__4;
        /*0x44*/ UnityEngine.Color <col>5__5;
        /*0x54*/ float <t>5__6;

        /*0x32f460*/ <LightOutT>d__19(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3d68f0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3d6b80*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveAndScaleObject>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ PrizeMgr <>4__this;
        /*0x28*/ UnityEngine.Vector3 <initialPosition>5__2;
        /*0x34*/ UnityEngine.Vector3 <initialScale>5__3;
        /*0x40*/ UnityEngine.Vector3 <targetPosition>5__4;
        /*0x4c*/ UnityEngine.Vector3 <targetScale>5__5;
        /*0x58*/ float <moveSpeed>5__6;
        /*0x5c*/ float <t>5__7;

        /*0x32f460*/ <MoveAndScaleObject>d__17(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3d6bc0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3d6f90*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SettlementData
{
    /*0x10*/ bool firstWin;
    /*0x14*/ int restMower;
    /*0x18*/ int duringTime;

    /*0x3c9c80*/ SettlementData(bool firstWin, int restMower, int duringTime);
}

class PVPScareyPot : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ PVPScareyPot();
    /*0x3c4520*/ void Update();
}

class ScreenShine : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ScreenShine Instance;
    /*0x20*/ UnityEngine.ParticleSystem particle;

    /*0x31c640*/ ScreenShine();
    /*0x3c9b10*/ void Awake();
    /*0x3c9c20*/ void StartEmit();
    /*0x3c9b90*/ void EndEmit();
}

class ScreenShake : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.Vector3 originalPosition;
    static /*0xc*/ float shakeDuration;
    static /*0x10*/ float shakeMagnitude;
    static /*0x14*/ bool isShaking;

    static /*0x3c9aa0*/ ScreenShake();
    static /*0x3c9580*/ bool CheckShake();
    static /*0x3c9710*/ void TriggerShake(float duration);
    /*0x31c640*/ ScreenShake();
    /*0x3c9680*/ void Start();
    /*0x3c9820*/ void Update();
}

class SingleBuffManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ SingleBuffManager Instance;
    /*0x20*/ System.Collections.Generic.List<SingleBuffManager.SingleBuff> singleBuffs;

    static /*0x3cb5e0*/ bool CheckBuff(SingleBuffManager.BuffType type);
    /*0x3cb800*/ SingleBuffManager();
    /*0x3cb580*/ void Awake();
    /*0x3caf10*/ void AddNewBuff(SingleBuffManager.BuffType type, Board board, UnityEngine.Vector2 postion, int row);
    /*0x3cb6f0*/ void Update();

    enum BuffType
    {
        Damage = 0,
        IceShroom = 1,
        Jalapeno = 2,
        StealHealth = 3,
        ZombieSupport = 4,
        SunSupport = 5,
        WallNut = 6,
        BigStar = 7,
    }

    class SingleBuff
    {
        /*0x10*/ SingleBuffManager.BuffType buffType;
        /*0x14*/ float timer;

        /*0x32f970*/ SingleBuff();
        /*0x3cb880*/ void OnUpdate();
    }
}

class Corner : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theColumn;
    /*0x24*/ bool subColumn;
    /*0x25*/ bool addColumn;
    /*0x28*/ int theRow;
    /*0x2c*/ bool subRow;
    /*0x2d*/ bool addRow;
    /*0x30*/ Corner next;
    /*0x38*/ Corner pre;
    /*0x40*/ bool opp;
    /*0x41*/ bool jump;
    /*0x42*/ bool turn;
    /*0x44*/ int road;

    /*0x31c640*/ Corner();
    /*0x3c2a70*/ void OnDrawGizmos();
    /*0x3c2a70*/ void SetPosition();
    /*0x3c2bd0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3c2a50*/ void MoveRight();
    /*0x3c2a40*/ void MoveLeft();
    /*0x3c2a60*/ void MoveUp();
    /*0x3c2a30*/ void MoveDown();
}

class FruitNinjaMenu : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<FruitNinjaSelectWindow> options;

    /*0x3c3630*/ FruitNinjaMenu();
    /*0x3c35c0*/ System.Collections.IEnumerator Start();
    /*0x3c2f10*/ void Awake();
    /*0x3c34d0*/ void SetOption(FruitNinjaSelectWindow window);
    /*0x3c2f30*/ void InitOptions();

    class <Start>d__1 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ FruitNinjaMenu <>4__this;

        /*0x32f460*/ <Start>d__1(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3d6fd0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3d7090*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class OppositeBuffBtn : UIBtn
{
    /*0x60*/ OppositeBuffManager manager;
    /*0x68*/ bool A;

    /*0x317730*/ OppositeBuffBtn();
    /*0x3c36b0*/ void OnMouseUpAsButton();
}

class OppositeBuffManager : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<int> advancedPool;
    /*0x38*/ System.Collections.Generic.List<int> ultimatePool;
    /*0x40*/ System.Collections.Generic.List<int> debuffPool;
    /*0x48*/ OppositeBuffManager.OppositeBuff buffA;
    /*0x54*/ OppositeBuffManager.OppositeBuff buffB;
    /*0x60*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> textA_good;
    /*0x68*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> textA_bad;
    /*0x70*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> textB_good;
    /*0x78*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> textB_bad;

    /*0x3c4440*/ OppositeBuffManager();
    /*0x3c37a0*/ void Awake();
    /*0x3c4030*/ void SelectA();
    /*0x3c4060*/ void SelectB();
    /*0x3c4240*/ void Select(OppositeBuffManager.OppositeBuff buff);
    /*0x3c4340*/ void SetText(TMPro.TextMeshProUGUI text, BuffType type, int id);
    /*0x3c4090*/ OppositeBuffManager.OppositeBuff SelectBuff();
    /*0x3c3dc0*/ void InitBuffPool();

    struct OppositeBuff
    {
        /*0x10*/ BuffType theOptionType;
        /*0x14*/ int theOptionID;
        /*0x18*/ int theDebuffID;
    }
}

class OppsiteBuffGroup : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ OppsiteBuffGroup();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class PlayerShootingMenu : BaseMenu
{
    /*0x30*/ bool first;
    /*0x38*/ System.Collections.Generic.List<PlayerShootingWindow> options;
    /*0x40*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> refreshText;
    /*0x48*/ Player player;
    /*0x50*/ System.Collections.Generic.List<PlayerWeaponType> firstWeapons;

    /*0x3c5b30*/ PlayerShootingMenu();
    /*0x3c4590*/ void Awake();
    /*0x3c55e0*/ void Start();
    /*0x3c5740*/ void Update();
    /*0x3c54c0*/ void SetOption(PlayerShootingWindow window);
    /*0x3c50f0*/ void Refresh();
    /*0x3c4740*/ void InitOptions();
    /*0x3c4600*/ bool CheckUpgrade(PlayerWeaponType playerWeaponType);
    /*0x3c5710*/ bool <InitOptions>b__10_0(PlayerWeaponType w);

    class <>c__DisplayClass11_0
    {
        /*0x10*/ PlayerWeaponType playerWeaponType;

        /*0x32f970*/ <>c__DisplayClass11_0();
        /*0x3d73d0*/ bool <CheckUpgrade>b__0(PlayerWeapon w);
    }
}

class RogueCardMenu : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<RogueCardWindow> cards;

    /*0x3c8580*/ RogueCardMenu();
    /*0x3c8370*/ void SelectOption(RogueCardWindow rogueCardWindow);
    /*0x3c7df0*/ void Awake();
    /*0x3c7e20*/ void InitCards();

    class <>c
    {
        static /*0x0*/ RogueCardMenu.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__3_0;

        static /*0x3d73f0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3d7290*/ bool <InitCards>b__3_0(PlantType p);
    }
}

class RogueLeaderCard : UIButton
{
    /*0x60*/ RogueSelectMenu menu;
    /*0x68*/ LeaderType leaderType;

    /*0x317730*/ RogueLeaderCard();
    /*0x3c8e80*/ void Start();
    /*0x3c8d40*/ void OnMouseEnter();
    /*0x3c8dc0*/ void OnMouseExit();
    /*0x3c8c50*/ void OnDestroy();
    /*0x3c8e40*/ void SetColor(UnityEngine.Color color);
    /*0x3c8b20*/ PlantType GetPlantType();
    /*0x3c8600*/ void ChangeSprite();
}

class RogueSelectCard : UIButton
{
    /*0x60*/ RogueSelectMenu menu;
    /*0x68*/ bool weakUlti;
    /*0x69*/ bool random;
    /*0x6c*/ PlantType thePlantType;
    /*0x70*/ bool get;

    /*0x317730*/ RogueSelectCard();
    /*0x3c9480*/ void Start();
    /*0x3c9350*/ void OnMouseEnter();
    /*0x3c93d0*/ void OnMouseExit();
    /*0x3c9450*/ void OnMouseUpAsButton();
    /*0x3c9260*/ void OnDestroy();
    /*0x3c8e40*/ void SetColor(UnityEngine.Color color);
    /*0x3c8f40*/ void ChangeSprite();
}

class ShootingMenu : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<ShootingSelectWindow> shootingSelectWindows;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> refreshCount;

    /*0x3cae90*/ ShootingMenu();
    /*0x3c9cd0*/ void Awake();
    /*0x3caa00*/ System.Collections.IEnumerator Start();
    /*0x3c9d40*/ void InitBuff();
    /*0x3cad00*/ void Update();
    /*0x3c9f00*/ void Refresh();
    /*0x3c9cf0*/ void Cancel();
    /*0x3ca1e0*/ void SelectOption(ShootingSelectWindow shootingSelectWindow);
    /*0x3caa70*/ bool TryUpgradePlant(PlantType originalPlant, PlantType targetPlantType, ref Plant newPlant);

    class <Start>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ShootingMenu <>4__this;

        /*0x32f460*/ <Start>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ed040*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ed100*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class TravelBuff : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theBuffType;
    /*0x24*/ int theBuffNumber;
    /*0x28*/ float max;
    /*0x2c*/ int cost;
    /*0x30*/ PlantType thePlantType;
    /*0x38*/ UnityEngine.Material brightMaterial;
    /*0x40*/ UnityEngine.Material originalMaterial;
    /*0x48*/ UnityEngine.UI.Image image;

    /*0x3e0730*/ TravelBuff();
    /*0x3dfb80*/ void Awake();
    /*0x3e06c0*/ System.Collections.IEnumerator Start();
    /*0x3e0260*/ void OnMouseUpAsButton();
    /*0x3e0180*/ void OnMouseEnter();
    /*0x3e01f0*/ void OnMouseExit();
    /*0x3dfc80*/ void ChangeSprite();

    class <Start>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ TravelBuff <>4__this;

        /*0x32f460*/ <Start>d__9(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ed140*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ed2e0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class TravelBuffMenu : BaseMenu
{
    static /*0x0*/ TravelBuffMenu Instance;
    /*0x30*/ System.Collections.Generic.List<TravelBuffOptionButton> options;
    /*0x38*/ bool leader;
    /*0x39*/ bool withDebuff;
    /*0x3a*/ bool isDebuff;
    /*0x3c*/ int selectBuffCount;
    /*0x40*/ int debuffNeedCount;

    /*0x3de460*/ TravelBuffMenu();
    /*0x3dcd60*/ void Awake();
    /*0x3de450*/ void Start();
    /*0x3dcf20*/ void GetOptions();
    /*0x3dd5a0*/ void RefeshOptions(bool refresh);
    /*0x3ddfa0*/ void SetDebuff(TravelMgr manager, bool refresh);
    /*0x3dcdd0*/ System.Collections.Generic.List<int> GetDebuffPool(TravelMgr manager);
    /*0x3de290*/ void SetProbability(ref System.Collections.Generic.List<int> advancedPool);
    /*0x3dde10*/ void SelectBuff(TravelBuffOptionButton option);
    /*0x3dd190*/ void GiveUpBuff();
    /*0x3dd2a0*/ void Quit();
}

class TravelBuffMgr : BaseMenu
{
    static /*0x0*/ TravelBuffMgr Instance;
    /*0x30*/ TMPro.TextMeshProUGUI text;
    /*0x38*/ TMPro.TextMeshProUGUI text2;
    /*0x40*/ UnityEngine.GameObject grid;
    /*0x48*/ System.Collections.Generic.List<UnityEngine.GameObject> grids;
    /*0x50*/ int buffCount;
    /*0x54*/ int currentPage;

    /*0x3def70*/ TravelBuffMgr();
    /*0x3de4e0*/ void Awake();
    /*0x3de720*/ void NextPage();
    /*0x3dee70*/ void TurnPage(int page);
    /*0x3de730*/ void SetBuffIcon();
    /*0x3de560*/ UnityEngine.Transform GetTransform(int totalCount);
    /*0x3deda0*/ void ShowText(int buffType, int buffNumber);
}

class TravelBuffOptionButton : UIButton
{
    /*0x60*/ UnityEngine.Transform axis;
    /*0x68*/ TMPro.TextMeshProUGUI introduce;
    /*0x70*/ TravelMgr manager;
    /*0x78*/ UnityEngine.UI.Image background;
    /*0x80*/ bool set;
    /*0x84*/ BuffType buffType;
    /*0x88*/ int buffIndex;
    /*0x90*/ UnityEngine.GameObject show;

    /*0x317730*/ TravelBuffOptionButton();
    /*0x3deff0*/ void Awake();
    /*0x3dfb10*/ void Start();
    /*0x3df0c0*/ void Clear();
    /*0x3df3c0*/ void SetBuff(BuffType buffType, int buffIndex, bool refresh);
    /*0x3df440*/ void SetPlant();
    /*0x3df7b0*/ void SetPlant(PlantType thePlantType);
    /*0x3df9a0*/ void SetZombie(ZombieType theZombieType);
    /*0x3df190*/ void OnAnimOver();
    /*0x3df1b0*/ void SetBackground(TravelBuffOptionButton.BgType bgType);

    enum BgType
    {
        Day = 0,
        Night = 1,
        Pool = 2,
    }
}

class TravelLookBuff : TravelBuffOptionButton
{
    /*0x317730*/ TravelLookBuff();
    /*0x3e0c50*/ void SetBuff(BuffType buffType, int buffIndex, bool refresh);
    /*0x3e0850*/ void OnMouseUpAsButton();
    /*0x3e0750*/ void Clear();
    /*0x3e1140*/ void SetText(string text);
    /*0x3e0ef0*/ void SetText(bool have, int level);
}

class TravelLookMenu : BaseMenu
{
    static /*0x0*/ TravelLookMenu Instance;
    /*0x30*/ System.Collections.Generic.List<TravelLookBuff> theBuffs;
    /*0x38*/ TravelMgr manager;
    /*0x40*/ Board board;
    /*0x48*/ TMPro.TextMeshProUGUI treasureText;
    /*0x50*/ int currentPage;
    /*0x54*/ int maxPage;
    /*0x58*/ BuffType currentType;
    /*0x5c*/ bool showAll;

    /*0x3e2500*/ TravelLookMenu();
    /*0x3e1250*/ void Awake();
    /*0x3e23b0*/ void Update();
    /*0x3e2330*/ void Start();
    /*0x3e1d80*/ void LookBuff(string buffType);
    /*0x3e1e70*/ void NextPage();
    /*0x3e1d60*/ void LastPage();
    /*0x3e1e90*/ void ShowBuffs(bool refresh);
    /*0x3e1c90*/ void InitBuffType(BuffType buffType, bool refresh);
    /*0x3e1b70*/ System.Collections.Generic.List<int> GetUnlocks();
    /*0x3e1900*/ System.Collections.Generic.List<int> GetDebuffs();
    /*0x3e1a20*/ System.Collections.Generic.List<UnityEngine.Vector2Int> GetUltiBuffs();
    /*0x3e1370*/ System.Collections.Generic.List<int> GetAdvBuffs();
    /*0x3e1630*/ void GetBuffs();
}

class TravelRefresh : UIButton
{
    /*0x60*/ int refreshTimes;
    /*0x68*/ TMPro.TextMeshProUGUI text;
    /*0x70*/ TMPro.TextMeshProUGUI text_shadow;

    /*0x3e28f0*/ TravelRefresh();
    /*0x3e2760*/ void Start();
    /*0x3e2580*/ void OnMouseUpAsButton();
}

class PropCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ Garden garden;
    /*0x28*/ UnityEngine.GameObject shadow;
    /*0x30*/ EquipmentData data;
    /*0x38*/ TMPro.TextMeshProUGUI countText;
    /*0x40*/ EquipmentType theEquipmentType;
    /*0x44*/ int restCount;

    /*0x31c640*/ PropCard();
    /*0x3dca90*/ void Start();
    /*0x3dc920*/ void Init();
    /*0x3dc630*/ bool Check();
    /*0x3dcb20*/ void UseOnce();
    /*0x3dca60*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
    /*0x3dcaf0*/ bool <Init>b__7_0(EquipmentData data);

    class <>c__DisplayClass8_0
    {
        /*0x10*/ PropCard <>4__this;
        /*0x18*/ int cost;

        /*0x32f970*/ <>c__DisplayClass8_0();
        /*0x3ed710*/ void <Check>b__0();
    }
}

class TreasureCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType _plantType;
    /*0x24*/ int _durability;
    /*0x28*/ int _maxDurability;
    /*0x30*/ TreasureCardData data;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.Sprite> sprites;
    /*0x40*/ UnityEngine.UI.Image cardIcon;
    /*0x48*/ UnityEngine.UI.Image back;
    /*0x50*/ TMPro.TextMeshProUGUI durText;
    /*0x58*/ int cost;
    /*0x5c*/ CardLevel level;
    /*0x60*/ TreasureCard.Status theStatus;

    /*0x3e3a50*/ TreasureCard();
    /*0x3e3af0*/ PlantType get_PlantType();
    /*0x3e3cb0*/ void set_PlantType(PlantType value);
    /*0x3e3ad0*/ int get_Durability();
    /*0x3e3b30*/ void set_Durability(int value);
    /*0x3e3ae0*/ int get_MaxDurability();
    /*0x3e3bf0*/ void set_MaxDurability(int value);
    /*0x3e3b00*/ int get_RealCost();
    /*0x3e2cc0*/ void Awake();
    /*0x3e2dc0*/ void Init();
    /*0x3e3a40*/ void Start();
    /*0x3e3540*/ void OnMouseEnter();
    /*0x3e35f0*/ void OnMouseExit();
    /*0x3e3020*/ void OnMouseDown();
    /*0x3e37f0*/ void SetIcon();
    /*0x3e36a0*/ void Sell();

    enum Status
    {
        WareHouse = 0,
        Store = 1,
        Game = 2,
        Equipment = 3,
        Upgrade = 4,
    }

    class <>c
    {
        static /*0x0*/ TreasureCard.<> <>9;
        static /*0x8*/ System.Predicate<TreasureCardData> <>9__27_0;

        static /*0x3ed890*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ed5e0*/ bool <OnMouseDown>b__27_0(TreasureCardData a);
    }
}

class TreasureData
{
    static int Durbility = 40;
    static /*0x0*/ System.Collections.Generic.List<TreasureCardData> treasureCards;
    static /*0x8*/ System.Collections.Generic.List<EquipmentData> equipmentData;
    static /*0x10*/ BigGardenData gardenData;
    static /*0x18*/ TreasureDifficulty difficulty;
    static /*0x1c*/ SceneType levelSceneType;
    static /*0x20*/ int treasureMoney;
    static /*0x24*/ int wareHouseLevel;
    static /*0x28*/ bool autoCollect;
    static /*0x30*/ System.Collections.Generic.List<ZombieType> NormalZombieTypes;
    static /*0x38*/ System.Collections.Generic.List<ZombieType> HardZombieTypes;
    static /*0x40*/ System.Collections.Generic.List<ZombieType> HellZombieTypes;
    static /*0x48*/ System.Collections.Generic.List<ZombieType> NormaWaterTypes;
    static /*0x50*/ System.Collections.Generic.List<ZombieType> HardWaterTypes;
    static /*0x58*/ System.Collections.Generic.List<ZombieType> HallWaterTypes;
    static /*0x60*/ System.Collections.Generic.List<ZombieType> UpgradeWaterTypes;
    static /*0x68*/ System.Collections.Generic.Dictionary<EquipmentType, System.ValueTuple<int, string>> EquipmentCost;

    static /*0x3e5f10*/ TreasureData();
    static /*0x3e7460*/ bool get_WareHouseUnfull();
    static /*0x3e5d10*/ void ResetLevel();
    static /*0x3e48b0*/ void GetCard(TreasureCardData data);
    static /*0x3e5e10*/ TreasureSaveData SaveData();
    static /*0x3e5ba0*/ void LoadData(TreasureSaveData saved);
    static /*0x3e4d70*/ System.Collections.Generic.List<ZombieType> GetZombieType();
    static /*0x3e3cc0*/ void DropCard(UnityEngine.Vector2 position);
    static /*0x3e4740*/ CardLevel GetCardLevel(PlantType thePlantType);
    static /*0x3e4c30*/ int GetPlantCost(PlantType thePlantType);
    static /*0x3e52a0*/ void LevelEnd();
    static /*0x3e44d0*/ int GetBuffCost();
    static /*0x3e7260*/ System.Collections.Generic.List<ZombieType> get_LevelZombieTypes();
    static /*0x3e4a80*/ System.ValueTuple<int, int> GetEquipmentCount(EquipmentType equipmentType);
    static /*0x3e4980*/ System.ValueTuple<int, string> GetEquipmentCostAndName(EquipmentType equipmentType);
    /*0x32f970*/ TreasureData();

    class <>c
    {
        static /*0x0*/ TreasureData.<> <>9;
        static /*0x8*/ System.Predicate<TreasureCardData> <>9__10_0;
        static /*0x10*/ System.Predicate<PlantType> <>9__16_0;
        static /*0x18*/ System.Predicate<PlantType> <>9__16_1;
        static /*0x20*/ System.Predicate<PlantType> <>9__16_2;
        static /*0x28*/ System.Predicate<PlantType> <>9__16_3;
        static /*0x30*/ System.Predicate<PlantType> <>9__16_4;
        static /*0x38*/ System.Predicate<TreasureCardData> <>9__19_0;
        static /*0x40*/ System.Func<TreasureCardData, CardLevel> <>9__19_1;
        static /*0x48*/ System.Predicate<ZombieType> <>9__29_0;

        static /*0x3ed970*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ed6f0*/ bool <get_WareHouseUnfull>b__10_0(TreasureCardData a);
        /*0x3ed320*/ bool <DropCard>b__16_0(PlantType p);
        /*0x3ed370*/ bool <DropCard>b__16_1(PlantType p);
        /*0x3ed470*/ bool <DropCard>b__16_2(PlantType p);
        /*0x3ed4c0*/ bool <DropCard>b__16_3(PlantType p);
        /*0x3ed510*/ bool <DropCard>b__16_4(PlantType p);
        /*0x3ed560*/ bool <LevelEnd>b__19_0(TreasureCardData c);
        /*0x3ed580*/ CardLevel <LevelEnd>b__19_1(TreasureCardData a);
        /*0x3ed6a0*/ bool <get_LevelZombieTypes>b__29_0(ZombieType z);
    }
}

class TreasureSaveData
{
    /*0x10*/ System.Collections.Generic.List<TreasureCardData> treasureCards;
    /*0x18*/ System.Collections.Generic.List<EquipmentData> equipmentData;
    /*0x20*/ BigGardenData gardenData;
    /*0x28*/ int treasureMoney;
    /*0x2c*/ int wareHouseLevel;

    /*0x32f970*/ TreasureSaveData();
}

class EquipmentData
{
    /*0x10*/ EquipmentType theEquipmentType;
    /*0x14*/ int level;
    /*0x18*/ int theColumn;
    /*0x1c*/ int theRow;
    /*0x20*/ bool set;

    /*0x3dc620*/ EquipmentData();
}

class BigGardenData
{
    /*0x10*/ UnityEngine.Vector2 playerPosition;

    /*0x32f970*/ BigGardenData();
}

class TreasureCardData
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int durability;
    /*0x18*/ int maxDurability;
    /*0x20*/ long id;
    /*0x28*/ bool equiped;
    /*0x2c*/ int oldColumn;
    /*0x30*/ int oldRow;
    /*0x34*/ bool fromOldGarden;
    /*0x35*/ bool inGraden;
    /*0x38*/ int theColumn;
    /*0x3c*/ int theRow;
    /*0x40*/ ToolType needTool;
    /*0x48*/ long nextTime;
    /*0x50*/ int stage;
    /*0x54*/ int waterLevel;
    /*0x58*/ int cultivateLevel;

    /*0x3e2c70*/ TreasureCardData(PlantType thePlantType, int durability, int maxDurability);
    /*0x3e2a90*/ void Load(TreasureCard card);
    /*0x3e2900*/ void LoadGarden(BigGardenPlant plant);
    /*0x3e2c30*/ void SaveFromGarden(BigGardenPlant plant);
}

enum TreasureDifficulty
{
    Normal = 0,
    Hard = 1,
    Hell = 2,
    Upgrade = 3,
}

enum CardLevel
{
    White = 0,
    Green = 1,
    Blue = 2,
    Purple = 3,
    Gold = 4,
    Red = 5,
}

class TreasureManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ TreasureManager Instance;
    /*0x20*/ Board board;
    /*0x28*/ float maxTimer;
    /*0x2c*/ bool first;
    /*0x2d*/ bool evacuated;
    /*0x30*/ System.Collections.Generic.List<TreasureCardData> cardData;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> evaText;
    /*0x40*/ Task.TaskType taskType;
    /*0x48*/ System.Collections.Generic.Queue<Task> tasks;

    /*0x3e8260*/ TreasureManager();
    /*0x3e7610*/ void Awake();
    /*0x3e7de0*/ void Start();
    /*0x3e7980*/ void GetCard(TreasureCardData data);
    /*0x3e81a0*/ void Update();
    /*0x3e7b60*/ void GetTask(Task.TaskType taskType);
    /*0x3e7e80*/ void TaskUpdate();
    /*0x3e76e0*/ void Evacuate();
}

class Task
{
    /*0x10*/ float timer;
    /*0x14*/ Task.TaskType taskType;
    /*0x18*/ TreasureManager manager;

    /*0x3dcb90*/ Task(TreasureManager manager, Task.TaskType taskType);
    /*0x3dcb30*/ bool Check();

    enum TaskType
    {
        NormalEvacuate = 0,
        LoseBagEvacuate = 1,
        ClosesEvacuate = 2,
        MissionEvacuate = 3,
    }
}

class TreasureMoney : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI text;

    /*0x31c640*/ TreasureMoney();
    /*0x3e8370*/ void Awake();
    /*0x3e83c0*/ void Update();
}

class TutorManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ int id;
    /*0x24*/ int progress;
    /*0x28*/ float timer;
    /*0x30*/ Board board;
    /*0x38*/ Plant missionPlant;
    /*0x40*/ Zombie missionZombie;

    /*0x31c640*/ TutorManager();
    /*0x3e8480*/ void Awake();
    /*0x3ece60*/ void Update();
    /*0x3e8700*/ void TowerUpdate();
    /*0x3e97a0*/ void TutorUpdate1();
    /*0x3ec370*/ void TutorUpdate4();
    /*0x3ec680*/ void TutorUpdate7();
    /*0x3eca20*/ void TutorUpdate8();
    /*0x3e89b0*/ void TutorUpdate10();
    /*0x3e8c80*/ void TutorUpdate13();
    /*0x3e9240*/ void TutorUpdate15();
    /*0x3e9de0*/ void TutorUpdate22();
    /*0x3ea230*/ void TutorUpdate24();
    /*0x3eac20*/ void TutorUpdate30();
    /*0x3eb1b0*/ void TutorUpdate35();
    /*0x3eb940*/ void TutorUpdate42();
    /*0x3e8620*/ void SetMissionCard(int theColumn, int theRow, PlantType theSeedType);
    /*0x3e84d0*/ void ClearPlant(int theColumn, int theRow);
    /*0x3e8930*/ void TutorOver();
}

class ArmorZombie : Zombie
{
    /*0x3d7de0*/ ArmorZombie();
}

class BlackFootballZombie : TallNutFootballZ
{
    /*0x3d8060*/ BlackFootballZombie();
    /*0x3d7ed0*/ void FirstArmorBroken();
    /*0x32d010*/ void LoseHeadEvent();
    /*0x3d7df0*/ void AttackEffect(Plant plant);
}

class BucketNutZ : WallNutZ
{
    /*0x3d8370*/ BucketNutZ();
    /*0x3d81e0*/ void FirstArmorBroken();
    /*0x350af0*/ void LoseHeadEvent();
    /*0x3d8070*/ UnityEngine.GameObject DropArmor();
}

class BucketZombie : ArmorZombie
{
    /*0x3d7de0*/ BucketZombie();
    /*0x3d8470*/ void FirstArmorBroken();
    /*0x3d85f0*/ void FirstArmorFall();
}

class BucketZombieDuck : BucketZombie
{
    /*0x3d7de0*/ BucketZombieDuck();
    /*0x3d8380*/ void Start();
}

class CherryNutZ : WallNutZ
{
    /*0x3d8370*/ CherryNutZ();
    /*0x3d8a00*/ void FirstArmorBroken();
}

class ConeZombie : ArmorZombie
{
    /*0x3d7de0*/ ConeZombie();
    /*0x3d8bb0*/ void FirstArmorBroken();
    /*0x3d8d30*/ void FirstArmorFall();
}

class ConeZombieDuck : NormalZombie
{
    /*0x3d8ba0*/ ConeZombieDuck();
}

class DiamondRandomZombie : RandomZombie
{
    /*0x3d8370*/ DiamondRandomZombie();
    /*0x3d9220*/ UnityEngine.GameObject SetRandomZombie(UnityEngine.Vector3 pos);
    /*0x3d9140*/ void RandomEvent(Zombie zombie);

    class <>c
    {
        static /*0x0*/ DiamondRandomZombie.<> <>9;
        static /*0x8*/ System.Predicate<ZombieType> <>9__0_0;
        static /*0x10*/ System.Predicate<ZombieType> <>9__0_1;

        static /*0x3ed900*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ed600*/ bool <SetRandomZombie>b__0_0(ZombieType z);
        /*0x3ed650*/ bool <SetRandomZombie>b__0_1(ZombieType z);
    }
}

class DollZombie : ConeZombie
{
    /*0x3d7de0*/ DollZombie();
    /*0x3d9de0*/ void FirstArmorFall();
    /*0x3da140*/ void SummonZombie();
    /*0x3d9930*/ void FirstArmorBroken();
    /*0x3d97a0*/ void DiamondSpirte();
    /*0x3d9e20*/ void GoldSpirte();
    /*0x3d9fb0*/ void SilverSpirte();
}

class DolphinPaper : PaperZombie
{
    /*0x3d8370*/ DolphinPaper();
    /*0x3da5d0*/ void SecondArmorBroken();
    /*0x3da410*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3da380*/ void Angry();
    /*0x3da4b0*/ void OverRangeDie();
}

class DoomZombie : Zombie
{
    /*0x3d7de0*/ DoomZombie();
    /*0x3da710*/ void Awake();
    /*0x3da650*/ void AttributeEvent();
}

class DoorZombie : ArmorZombie
{
    /*0x248*/ UnityEngine.GameObject hand1;
    /*0x250*/ UnityEngine.GameObject hand2;
    /*0x258*/ UnityEngine.GameObject hand3;

    /*0x3d7de0*/ DoorZombie();
    /*0x3da770*/ void Awake();
    /*0x3da820*/ void GetHand();
    /*0x3da950*/ void SecondArmorBroken();
    /*0x3daae0*/ void SecondArmorFall();
    /*0x3da7a0*/ void DestoryHand();
}

class DriverZombie : Zombie
{
    /*0x248*/ float startSpeed;
    /*0x24c*/ float currentSpeed;

    /*0x3dc310*/ DriverZombie();
    /*0x3dc270*/ void Start();
    /*0x3dbfb0*/ void PositionUpdate();
    /*0x3db960*/ void Die(int reason);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3db660*/ void CreateIceRoad();
    /*0x3daf70*/ void BodyTakeDamage(int theDamage);
    /*0x3db780*/ void DieAndExplode();
    /*0x3db7a0*/ void DieEvent(int reason);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3db980*/ void KillByCaltrop();
}

class ElitePaperZombie : PaperZombie
{
    /*0x3d8370*/ ElitePaperZombie();
    /*0x3dc360*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3dc600*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x3dc330*/ void BodyTakeDamage(int theDamage);
    /*0x3dc410*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x3dc450*/ void SecondArmorBroken();
    /*0x3dc340*/ void Buttered(float time, bool sprite);
    /*0x3dc5e0*/ void SetFreeze(float time, int theFreezeLevel);
}

class FlagFootball : ZombieFootball
{
    /*0x3d8ba0*/ FlagFootball();
    /*0x3f15f0*/ void Awake();
    /*0x3f19f0*/ void Start();
    /*0x3f1910*/ void FixedUpdate();
    /*0x3f1610*/ void FirstArmorBroken();
}

class FootballDolphin : Zombie
{
    /*0x3d7de0*/ FootballDolphin();
    /*0x3f1a20*/ void FirstArmorBroken();
    /*0x3f1dd0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3f1aa0*/ void FixedUpdate();
}

class GatlingBlackFootball : GatlingFootballZombie
{
    /*0x3d7de0*/ GatlingBlackFootball();
    /*0x3f1e50*/ void AnimShoot();
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
}

class GatlingFootballZombie : Zombie
{
    /*0x3d7de0*/ GatlingFootballZombie();
    /*0x3eddd0*/ void Awake();
    /*0x3f2190*/ void AttributeEvent();
    /*0x3f1ff0*/ void AnimShoot();
    /*0x3f2240*/ void FirstArmorBroken();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
}

class IceZombie : Zombie
{
    /*0x3d7de0*/ IceZombie();
    /*0x3f2f70*/ void FirstArmorBroken();
    /*0x3f31e0*/ int FirstArmorTakeDamage(int theDamage);
    /*0x3f2ed0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
}

class JacksonDriver : SuperDriverZombie
{
    /*0x250*/ bool setDancer;

    /*0x3f6040*/ JacksonDriver();
    /*0x3f5170*/ void DieEvent(int reason);
    /*0x3f5d00*/ void PositionUpdate();
    /*0x3f4830*/ void BodyTakeDamage(int theDamage);
    /*0x3f5570*/ void KillByCaltrop();
}

class PaperZombie : ArmorZombie
{
    /*0x3d8ba0*/ PaperZombie();
    /*0x3f9320*/ void Start();
    /*0x3f8dc0*/ void SecondArmorBroken();
    /*0x3f8f40*/ void SecondArmorFall();
    /*0x3f8d20*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f8c80*/ void AngrySound();
    /*0x3f8d10*/ void Angry();
}

class ProtalZombie : DoorZombie
{
    /*0x260*/ int shootCount;

    /*0x3d8ba0*/ ProtalZombie();
    /*0x3fa980*/ void Awake();
    /*0x3fa9c0*/ UnityEngine.GameObject DropArmor();
    /*0x350af0*/ void LoseHeadEvent();
    /*0x3fa650*/ void AttributeEvent();
    /*0x3fa4c0*/ void AnimShoot();
    /*0x32d010*/ void SecondArmorBroken();
}

class RandomPlusZombie : RandomZombie
{
    /*0x3d8ba0*/ RandomPlusZombie();
    /*0x32d010*/ void RandomEvent(Zombie zombie);
}

class RandomZombie : NormalZombie
{
    /*0x258*/ bool summoned;

    /*0x3d8ba0*/ RandomZombie();
    /*0x3fab40*/ void FirstArmorFall();
    /*0x3fbb80*/ void LoseHeadEvent();
    /*0x3fad90*/ int FirstArmorTakeDamage(int theDamage);
    /*0x3fbc60*/ UnityEngine.GameObject SetRandomZombie(UnityEngine.Vector3 pos);
    /*0x3fadb0*/ UnityEngine.GameObject GetEveZombie(UnityEngine.Vector3 pos);
    /*0x3fbba0*/ void RandomEvent(Zombie zombie);
    /*0x348b00*/ bool Instead(int damage);

    class <>c
    {
        static /*0x0*/ RandomZombie.<> <>9;
        static /*0x8*/ System.Predicate<ZombieType> <>9__4_0;
        static /*0x10*/ System.Predicate<ZombieType> <>9__4_1;

        static /*0x3ff870*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ff7d0*/ bool <SetRandomZombie>b__4_0(ZombieType z);
        /*0x3ff820*/ bool <SetRandomZombie>b__4_1(ZombieType z);
    }
}

class SuperDoorZombie : DoorZombie
{
    /*0x3d8ba0*/ SuperDoorZombie();
    /*0x3fd6e0*/ void Awake();
    /*0x3fd700*/ void FirstArmorBroken();
    /*0x3fd880*/ void FirstArmorFall();
    /*0x3fd680*/ void AttributeEvent();
    /*0x3fd4d0*/ void AnimShoot();
}

class SuperDriverZombie : DriverZombie
{
    /*0x3f6040*/ SuperDriverZombie();
    /*0x3fdc90*/ void BodyTakeDamage(int theDamage);
    /*0x3fede0*/ void PositionUpdate();
    /*0x3fe650*/ void KillByCaltrop();
    /*0x3fe490*/ void DieEvent(int reason);
}

class TallIceNutZ : WallNutZ
{
    /*0x3d8ba0*/ TallIceNutZ();
    /*0x3ff070*/ void FirstArmorBroken();
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
}

class TallNutFootballZ : BucketNutZ
{
    /*0x3ff500*/ TallNutFootballZ();
    /*0x3ff370*/ void FirstArmorBroken();
    /*0x350af0*/ void LoseHeadEvent();
    /*0x3ff200*/ UnityEngine.GameObject DropArmor();
    /*0x32d010*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class UltimateFootballZombie : BlackFootballZombie
{
    /*0x248*/ System.Collections.Generic.List<UnityEngine.GameObject> flags;

    /*0x400390*/ UltimateFootballZombie();
    /*0x3edb00*/ void Awake();
    /*0x400310*/ void Start();
    /*0x3ffa40*/ void AttributeEvent();
    /*0x3ff8e0*/ void AttackEffect(Plant plant);
    /*0x3ffb60*/ void FirstArmorBroken();
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
}

class UltimateJacksonDriver : JacksonDriver
{
    /*0x258*/ UnityEngine.Animator jackson;

    /*0x3f6040*/ UltimateJacksonDriver();
    /*0x400dc0*/ void Start();
    /*0x400e80*/ void Update();
    /*0x400a60*/ void DieEvent(int reason);
    /*0x400410*/ void BodyTakeDamage(int theDamage);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x400d80*/ void KillByCaltrop();
    /*0x32d010*/ void SetJalaed();
    /*0x32d010*/ void SetPoison(float time);
    /*0x32d010*/ void AddPoisonLevel();
}

class WallNutZ : ArmorZombie
{
    /*0x3d8ba0*/ WallNutZ();
    /*0x400ee0*/ void FirstArmorBroken();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
}

class ZombieFootball : ArmorZombie
{
    /*0x3d8ba0*/ ZombieFootball();
    /*0x4017d0*/ void FirstArmorBroken();
    /*0x401960*/ void FirstArmorFall();
    /*0x32d010*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class Obstacle : UnityEngine.MonoBehaviour
{
    /*0x20*/ Obstacle.ObstacleType obstacleType;
    /*0x24*/ int theBallRow;
    /*0x28*/ float flashTime;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;

    /*0x3f8c00*/ Obstacle();
    /*0x3f86d0*/ void Awake();
    /*0x3f84d0*/ void AddToList();
    /*0x3f87a0*/ void GetSpriteRenderers(UnityEngine.GameObject obj);
    /*0x3f8710*/ void FixedUpdate();
    /*0x3f8710*/ void FlashUpdate();
    /*0x3f8a20*/ void SetBrightness(float b);
    /*0x32d010*/ void Die();
    /*0x3f8900*/ void OnDestroy();

    enum ObstacleType
    {
        FireBall = 0,
        IceBall = 1,
        SilverZombie = 2,
        GoldZombie = 3,
        BigWeapon = 4,
    }
}

class SuperBall : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 velocity;
    /*0x28*/ int theRow;

    /*0x31c640*/ SuperBall();
    /*0x3fd120*/ void Awake();
    /*0x3fd130*/ void Update();
}

class ZombieBall : Obstacle
{
    /*0x38*/ int bulletTime;
    /*0x3c*/ float existTime;
    /*0x40*/ UnityEngine.Rigidbody2D rb;
    /*0x48*/ UnityEngine.Animator anim;
    /*0x50*/ float Vx;
    /*0x54*/ bool boss;

    /*0x4017c0*/ ZombieBall();
    /*0x400f60*/ void Awake();
    /*0x401740*/ void Start();
    /*0x401760*/ void Update();
    /*0x4014f0*/ void PositionUpdate();
    /*0x4011d0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x4010c0*/ void Die();
    /*0x4016c0*/ void StartBigger();
    /*0x401050*/ System.Collections.IEnumerator Bigger();

    class <Bigger>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ZombieBall <>4__this;
        /*0x28*/ UnityEngine.Vector2 <scale>5__2;
        /*0x30*/ UnityEngine.Vector2 <targetScale>5__3;
        /*0x38*/ float <time>5__4;
        /*0x3c*/ float <during>5__5;

        /*0x32f460*/ <Bigger>d__13(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x3ff510*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x3ff790*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ZombieObstacle : Obstacle
{
    /*0x38*/ float theHealth;

    /*0x401ea0*/ ZombieObstacle();
    /*0x401d70*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class ZombieSquash : UnityEngine.MonoBehaviour
{
    /*0x20*/ int targetRow;
    /*0x24*/ int targetColumn;
    /*0x28*/ bool isMindControl;
    /*0x2c*/ UnityEngine.Vector2 upperPosition;
    /*0x34*/ UnityEngine.Vector2 lowerPosition;
    /*0x3c*/ float moveSpeed;
    /*0x40*/ int progress;
    /*0x44*/ bool jala;

    /*0x402720*/ ZombieSquash();
    /*0x401f30*/ void Start();
    /*0x401f20*/ void Progress1();
    /*0x401eb0*/ void DelayProgress();
    /*0x402060*/ void Update();
}

class Charred : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ Charred();
    /*0x3ede50*/ void Die();
}

class BlackFootballZombie_a : Zombie
{
    /*0x3d7de0*/ BlackFootballZombie_a();
    /*0x3ed9e0*/ void FirstArmorBroken();
}

class BlackFootballZombie_b : BlackFootballZombie_a
{
    /*0x3d7de0*/ BlackFootballZombie_b();
    /*0x3edb00*/ void Awake();
    /*0x3eda60*/ void AttributeEvent();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
}

class BlackFootballZombie_c : BlackFootballZombie_b
{
    /*0x3d7de0*/ BlackFootballZombie_c();
    /*0x3eddf0*/ void AttackEffect(Plant plant);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void Buttered(float time, bool sprite);
}

class BlackFootballZombie_c2 : BlackFootballZombie_b
{
    /*0x3d7de0*/ BlackFootballZombie_c2();
    /*0x3eddd0*/ void Awake();
    /*0x3edd30*/ void AttributeEvent();
    /*0x3edb90*/ void AnimShoot();
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void Buttered(float time, bool sprite);
}

class Driver_a : Zombie
{
    /*0x248*/ UnityEngine.GameObject smoke;
    /*0x250*/ int defence;

    /*0x3ee650*/ Driver_a();
    /*0x3ee5c0*/ void Start();
    /*0x3ee320*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3edeb0*/ void BodyTakeDamage(int theDamage);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3ee340*/ void KillByCaltrop();
    /*0x3db960*/ void Die(int reason);
    /*0x3db780*/ void DieAndExplode();
    /*0x3ee090*/ void DieEvent(int reason);
    /*0x3ee160*/ void DieParticle();
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void Buttered(float time, bool sprite);
}

class Driver_b : Driver_a
{
    /*0x3ee650*/ Driver_b();
    /*0x3ee670*/ void Awake();
    /*0x3ee690*/ void DieEvent(int reason);
}

class Driver_c : Driver_b
{
    /*0x3ee650*/ Driver_c();
    /*0x3ee760*/ void Awake();
    /*0x3ee780*/ void DieEvent(int reason);
}

class Drownpult_a : DrownCatapultZombie
{
    /*0x3ef840*/ Drownpult_a();
    /*0x3ef730*/ void Awake();
    /*0x3ef750*/ void CataUpdate();
    /*0x3ef580*/ void AnimShoot();
}

class Drownpult_b : DrownCatapultZombie
{
    /*0x3ef840*/ Drownpult_b();
    /*0x3ef730*/ void Awake();
    /*0x3efa00*/ void CataUpdate();
    /*0x3ef850*/ void AnimShoot();
}

class Drownpult_c : Drownpult_b
{
    /*0x3ef840*/ Drownpult_c();
    /*0x3efaf0*/ void DieEvent(int reason);
}

class Drown_a : Zombie
{
    static /*0x3eec90*/ bool CheckPlant(Plant plant);
    /*0x3d7de0*/ Drown_a();
    /*0x3eebb0*/ void Awake();
    /*0x3eeb40*/ void AttributeEvent();
    /*0x3eed50*/ DrownProjectile GetDrownWeapon();
    /*0x3ee850*/ void AnimThrow();
    /*0x3eecd0*/ void FirstArmorBroken();
    /*0x3eebf0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class Drown_b : Drown_a
{
    /*0x3d7de0*/ Drown_b();
    /*0x3eeee0*/ void AnimThrow();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
}

class Drown_c : Drown_b
{
    /*0x3d7de0*/ Drown_c();
    /*0x3ef270*/ void AnimThrow();
}

class EternalZombie_a : Zombie
{
    /*0x3d7de0*/ EternalZombie_a();
    /*0x3f0220*/ void DieEvent(int reason);
    /*0x3f0050*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f00f0*/ void DestoryZombie();
    /*0x3efe00*/ void AttackPlants();
}

class EternalZombie_b : EternalZombie_a
{
    /*0x248*/ bool quickmove;
    /*0x250*/ UnityEngine.ParticleSystem particle;

    /*0x3d7de0*/ EternalZombie_b();
    /*0x3f0300*/ void Awake();
    /*0x3f0280*/ void AttributeEvent();
    /*0x3f03e0*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x3f03c0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3f0670*/ void StartQuickMove();
    /*0x3f0630*/ void QuickMoveOver();
    /*0x3f0430*/ void QuickDamage(UnityEngine.Collider2D collision);
}

class EternalZombie_c : EternalZombie_a
{
    /*0x248*/ System.Collections.Generic.Queue<Plant> targets;
    /*0x250*/ UnityEngine.Vector2 startPosition;
    /*0x258*/ UnityEngine.Vector2 targetPosition;
    /*0x260*/ bool isMovingBetweenPlants;
    /*0x264*/ int plantsToMoveBetween;
    /*0x268*/ float moveDuration;
    /*0x26c*/ float moveTimer;
    /*0x270*/ float speed;
    /*0x274*/ bool alternateDirection;

    /*0x3f1550*/ EternalZombie_c();
    /*0x3f07b0*/ void Awake();
    /*0x3f0710*/ void AttributeEvent();
    /*0x3f08d0*/ void EnterMoving();
    /*0x3f1200*/ void SetNextTargetPosition();
    /*0x3f0990*/ void MoveUpdate();
    /*0x3f07f0*/ void EndSpecialMove();
    /*0x3f0f70*/ void SearchPlant();
}

class GatlingPaperZombie_a : Zombie
{
    /*0x248*/ UnityEngine.GameObject head_default;
    /*0x250*/ UnityEngine.GameObject head_angry;

    /*0x3d7de0*/ GatlingPaperZombie_a();
    /*0x3f27c0*/ void Awake();
    /*0x3f2760*/ void AttributeEvent();
    /*0x3f2810*/ void Buttered(float time, bool sprite);
    /*0x3f2a20*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x3f2980*/ void SecondArmorFall();
    /*0x3f25e0*/ void AnimShoot();
    /*0x3f24b0*/ void Angry();
    /*0x3f2900*/ void SecondArmorBroken();
    /*0x3f2820*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f27f0*/ void BodyTakeDamage(int theDamage);
    /*0x3f2a30*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x3f28c0*/ void Charred(int damage, bool fix, DmgType damageType);
}

class GatlingPaperZombie_b : GatlingPaperZombie_a
{
    /*0x3d7de0*/ GatlingPaperZombie_b();
    /*0x3f2c40*/ void Awake();
    /*0x3f2bd0*/ void AttributeEvent();
    /*0x3f2a50*/ void AnimShoot();
}

class GatlingPaperZombie_c : GatlingPaperZombie_b
{
    /*0x258*/ UnityEngine.Rendering.SortingGroup gun;
    /*0x260*/ UnityEngine.Transform shoot_gun;

    /*0x3d7de0*/ GatlingPaperZombie_c();
    /*0x3f2df0*/ void AttributeEvent();
    /*0x3f2ea0*/ void TakeGun();
    /*0x3f2c70*/ void AnimShootGun();
}

class Jackbox_a : Zombie
{
    /*0x248*/ UnityEngine.Vector2 jumpPos2;
    /*0x250*/ UnityEngine.Vector2 range;
    /*0x258*/ bool pause;
    /*0x259*/ bool startJump;
    /*0x25c*/ int wait;

    /*0x3f4040*/ Jackbox_a();
    /*0x3f32d0*/ void Awake();
    /*0x3f3fd0*/ void Start();
    /*0x3f38d0*/ void LandSound();
    /*0x3f32f0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f3b30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3f3480*/ void FixedUpdate();
    /*0x3f3b40*/ void PoloUpdate();
    /*0x3f3970*/ void LoseHeadEvent();
    /*0x3f34c0*/ void JumpFail();
    /*0x3f3a80*/ void LoseJumper();
    /*0x3f3dc0*/ void PositionUpdate();
    /*0x3f3390*/ void DieEvent(int reason);
    /*0x3f3f80*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
    /*0x3f3400*/ void FirstArmorBroken();
}

class Jackbox_b : Jackbox_a
{
    /*0x260*/ float waitTime;
    /*0x264*/ bool jumped;
    /*0x265*/ bool loseJumper;
    /*0x268*/ float jumpX;

    /*0x3f4040*/ Jackbox_b();
    /*0x3f4340*/ void Start();
    /*0x3f43e0*/ void Update();
    /*0x3f4060*/ void BigJump();
    /*0x3f40d0*/ void PositionUpdate();
}

class Jackbox_c : Jackbox_b
{
    /*0x3f4040*/ Jackbox_c();
    /*0x3f4760*/ void Start();
    /*0x3f45c0*/ void LoseHeadEvent();
}

class Jackson_a : Zombie
{
    /*0x248*/ Zombie[] zombies;

    /*0x3f69a0*/ Jackson_a();
    /*0x3f6220*/ void Awake();
    /*0x3f6910*/ void Update();
    /*0x3f62f0*/ void CheckLose();
    /*0x3f61d0*/ void AttributeEvent();
    /*0x3f6250*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f6800*/ void TurnBody(float angle);
    /*0x3f6050*/ void AnimSummon();
    /*0x3f6580*/ void SetZombie(float x, int row, int index);
    /*0x3f6470*/ bool CheckSummon(float x, int row, int index);
}

class Jackson_b : Jackson_a
{
    /*0x250*/ UnityEngine.ParticleSystem particle;

    /*0x3f69a0*/ Jackson_b();
    /*0x3f6a70*/ void Awake();
    /*0x3f6e30*/ void Start();
    /*0x3f6a00*/ void AttributeEvent();
    /*0x3f6b80*/ void PositionUpdate();
    /*0x3f6b20*/ void Die(int reason);
}

class Jackson_c : Jackson_b
{
    /*0x3f69a0*/ Jackson_c();
    /*0x3f7120*/ void Awake();
    /*0x3f6e70*/ void AnimSummon();
    /*0x3f7210*/ void CheckLose();
}

class Kirov_a : Zombie
{
    /*0x3d7de0*/ Kirov_a();
    /*0x3f7ab0*/ void Awake();
    /*0x3f7af0*/ void BodyTakeDamage(int theDamage);
    /*0x3f77a0*/ void AttributeEvent();
    /*0x3f74f0*/ void AnimShoot();
    /*0x3f7ca0*/ void DieEvent(int reason);
    /*0x3f7e60*/ void Die(int reason);
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3f7c80*/ void CrashEvent();
}

class Kirov_b : Kirov_a
{
    /*0x3d7de0*/ Kirov_b();
    /*0x3f8060*/ void Awake();
    /*0x3f80a0*/ void Start();
    /*0x3f7e80*/ void AnimShoot();
}

class Kirov_c : Kirov_b
{
    /*0x248*/ UnityEngine.Transform shoot2;
    /*0x250*/ UnityEngine.GameObject bombPrefab;

    /*0x3d7de0*/ Kirov_c();
    /*0x3f8490*/ void Awake();
    /*0x32d010*/ void AttributeEvent();
    /*0x3f8140*/ void AnimShoot();
}

class Pickaxe_a : Zombie
{
    /*0x248*/ TMPro.TextMeshPro progressText;
    /*0x250*/ UnityEngine.Rendering.SortingGroup textGroup;
    /*0x258*/ float progress;
    /*0x25c*/ float digSpeed;

    /*0x3f9880*/ Pickaxe_a();
    /*0x3f9340*/ void Awake();
    /*0x3f9440*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f94e0*/ void FirstArmorBroken();
    /*0x3f9560*/ void ZombieUpdate();
    /*0x3f93f0*/ void CancelAttack();
}

class Pickaxe_b : Pickaxe_a
{
    /*0x260*/ int targetColumn;

    /*0x3f9880*/ Pickaxe_b();
    /*0x3f98a0*/ void Awake();
    /*0x3f9980*/ void OnFixedUpdate();
    /*0x3f9c20*/ void Rise();
    /*0x3f99d0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void RiseEvent();
}

class Pickaxe_c : Pickaxe_b
{
    /*0x268*/ System.Collections.Generic.List<ZombieType> zombieTypes;
    /*0x270*/ bool a;

    /*0x3fa430*/ Pickaxe_c();
    /*0x3fa030*/ void Awake();
    /*0x3f9c80*/ void AttributeEvent();
    /*0x3fa150*/ void RiseEvent();
    /*0x3fa120*/ void DieEvent(int reason);
}

class Submarine_a : Zombie
{
    /*0x3d7de0*/ Submarine_a();
    /*0x3fc1e0*/ void Awake();
    /*0x3fc200*/ void BodyTakeDamage(int theDamage);
    /*0x3fc390*/ void DieEvent(int reason);
    /*0x3fc550*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3db960*/ void Die(int reason);
}

class Submarine_b : Submarine_a
{
    /*0x248*/ UnityEngine.GameObject bulletPrefab;

    /*0x3d7de0*/ Submarine_b();
    /*0x3fc880*/ void Awake();
    /*0x3fc820*/ void AttributeEvent();
    /*0x3fc5a0*/ void AnimShoot();
}

class Submarine_b2 : Submarine_a
{
    /*0x3d7de0*/ Submarine_b2();
    /*0x3fc570*/ void Awake();
}

class Submarine_c : Submarine_b
{
    /*0x250*/ UnityEngine.Transform shoot2;

    /*0x3d7de0*/ Submarine_c();
    /*0x3fcae0*/ void Awake();
    /*0x3fca80*/ void AttributeEvent();
    /*0x3fcb10*/ void FixedUpdate();
    /*0x3fcc90*/ Plant SearchPlant();
    /*0x3fc8b0*/ void AnimShoot();
    /*0x3fcf10*/ void SetBullet(UnityEngine.Vector2 startPosition, UnityEngine.Vector2 targetPosition);
}

class Submarine_c2 : Submarine_b2
{
    /*0x3d8ba0*/ Submarine_c2();
    /*0x417610*/ void Awake();
    /*0x4174a0*/ void AttributeEvent();
}

class AdvZombie : Zombie
{
    /*0x3d7de0*/ AdvZombie();
    /*0x402730*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class BasicZombie : Zombie
{
    /*0x3d7de0*/ BasicZombie();
}

class ChickenImp : Zombie
{
    /*0x3d7de0*/ ChickenImp();
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x3f7e60*/ void Die(int reason);
    /*0x407d30*/ void DieEvent(int reason);
}

class FlagZombie : Zombie
{
    /*0x248*/ UnityEngine.GameObject flag;
    /*0x250*/ UnityEngine.GameObject flagHand;

    /*0x3d7de0*/ FlagZombie();
    /*0x3f19f0*/ void Start();
    /*0x40ae00*/ void BodyTakeDamage(int theDamage);
    /*0x40af20*/ void LoseHeadEvent();
}

class ImpZombie : Zombie
{
    /*0x248*/ int fromRow;
    /*0x24c*/ float Vy;
    /*0x250*/ UnityEngine.Transform realShadow;
    /*0x258*/ float Vx;
    /*0x260*/ UnityEngine.Coroutine coroutine;

    /*0x40e020*/ ImpZombie();
    /*0x40d510*/ void Awake();
    /*0x3db780*/ void BeSmall(float scale);
    /*0x40dd00*/ void Start();
    /*0x40d690*/ System.Collections.IEnumerator EnableSprites();
    /*0x40d5e0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x40dc20*/ void StartLand();
    /*0x40d700*/ System.Collections.IEnumerator IAdjustPosition();
    /*0x40d770*/ void Land();
    /*0x3f3390*/ void DieEvent(int reason);
    /*0x40d7e0*/ void LoseHeadEvent();
    /*0x40df90*/ void Thrown();
    /*0x40d850*/ void PositionUpdate();
    /*0x40dbd0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x40d5c0*/ void Buttered(float time, bool sprite);

    class <EnableSprites>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ImpZombie <>4__this;

        /*0x32f460*/ <EnableSprites>d__8(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x417630*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x417840*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IAdjustPosition>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ImpZombie <>4__this;
        /*0x28*/ float <currentY>5__2;
        /*0x2c*/ float <targetY>5__3;

        /*0x32f460*/ <IAdjustPosition>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x417880*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x417bb0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class JalapenoZombie : Zombie
{
    /*0x3d7de0*/ JalapenoZombie();
    /*0x410820*/ void Awake();
    /*0x4107a0*/ void AttributeEvent();
}

class LandSubmarineZombie : SubmarineZombie
{
    /*0x3d7de0*/ LandSubmarineZombie();
    /*0x412300*/ void Update();
}

class MiniSandMonster : Zombie
{
    /*0x3d7de0*/ MiniSandMonster();
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x413e80*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x414070*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
}

class MiniSnowMonster : Zombie
{
    /*0x3d7de0*/ MiniSnowMonster();
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x414270*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4140e0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x414070*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
}

class MoneyZombie : Zombie
{
    /*0x3d7de0*/ MoneyZombie();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x414670*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x4146a0*/ void Update();
    /*0x414580*/ void Die(int reason);
    /*0x414590*/ void PositionUpdate();
    /*0x414290*/ void DieEvent(int reason);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void SetPoison(float time);
    /*0x32d010*/ void EatGarlic(Plant plant, float time, bool withSound);
}

class NewYearSnowZombie : ConeZombie
{
    /*0x3d8ba0*/ NewYearSnowZombie();
    /*0x4147c0*/ void FirstArmorBroken();
    /*0x414720*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class NormalZombie : Zombie
{
    /*0x248*/ UnityEngine.GameObject duck;
    /*0x250*/ int hash_inWater;

    /*0x3d7de0*/ NormalZombie();
    /*0x414a90*/ void Awake();
    /*0x415220*/ void Start();
    /*0x415100*/ void PositionUpdate();
    /*0x415060*/ void MoveWaterUpdate();
    /*0x414fe0*/ void FirstArmorBroken();
    /*0x4151a0*/ void SecondArmorBroken();
    /*0x414b40*/ void EnterWater();
    /*0x414d90*/ void ExitWater();
}

class ObsidianImpZombie : Zombie
{
    /*0x3d7de0*/ ObsidianImpZombie();
    /*0x415370*/ void SetParticle();
    /*0x3db780*/ void BeSmall(float scale);
    /*0x415330*/ void Awake();
    /*0x3f3b30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x415350*/ void SetFreeze(float time, int theFreezeLevel);
}

class SnowMonsterZombie : Zombie
{
    /*0x3d7de0*/ SnowMonsterZombie();
    /*0x415fa0*/ void Start();
    /*0x415f30*/ void LandEvent();
    /*0x415f90*/ void PositionUpdate();
    /*0x415f60*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4159e0*/ void BodyTakeDamage(int theDamage);
}

class SnowZombie : Zombie
{
    /*0x3d7de0*/ SnowZombie();
    /*0x410820*/ void Awake();
    /*0x4160a0*/ void AttributeEvent();
    /*0x416140*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x4161e0*/ void DieEvent(int reason);
}

class SquashZombie : Zombie
{
    /*0x248*/ UnityEngine.Transform squashHead;
    /*0x250*/ UnityEngine.GameObject squashPrefab;
    /*0x258*/ ZombieSquash squash;

    /*0x3d7de0*/ SquashZombie();
    /*0x4164a0*/ void DieEvent(int reason);
    /*0x416540*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class StoneDancer : MoneyZombie
{
    /*0x3d7de0*/ StoneDancer();
    /*0x4169e0*/ void Awake();
    /*0x416880*/ void AttributeEvent();
    /*0x416a00*/ void DieEvent(int reason);
}

class SubmarineZombie : Zombie
{
    /*0x248*/ UnityEngine.Vector3 startPos;

    /*0x3d7de0*/ SubmarineZombie();
    /*0x417310*/ void Start();
    /*0x417270*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x417400*/ void Update();
    /*0x416ab0*/ void BodyTakeDamage(int theDamage);
    /*0x4170b0*/ void DieEvent(int reason);
    /*0x3fc550*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3db960*/ void Die(int reason);
}

class ZombieDuck : Zombie
{
    /*0x3d7de0*/ ZombieDuck();
    /*0x417d40*/ void Start();
}

class ProjectileZombie : Zombie
{
    /*0x248*/ UnityEngine.Vector2 v;
    /*0x250*/ UnityEngine.Vector2 a;

    /*0x3d7de0*/ ProjectileZombie();
    /*0x410860*/ void Awake();
    /*0x4157b0*/ void Start();
    /*0x415880*/ void Update();
    /*0x4153e0*/ void FixedUpdate();
    /*0x4157d0*/ void UpdateHealthText();
    /*0x415470*/ void RbUpdate();
    /*0x414580*/ void Die(int reason);
    /*0x32d010*/ void PositionUpdate();
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void SetJalaed();
    /*0x415460*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void SetPoison(float time);
    /*0x32d010*/ void SetPortaled(float timer);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetEmbered();
    /*0x32d010*/ void BeSmall(float scale);
    /*0x32d010*/ void AddPoisonLevel();
    /*0x32d010*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class BalloonZombie : Zombie
{
    /*0x248*/ bool fall;

    /*0x3d7de0*/ BalloonZombie();
    /*0x402c40*/ void Start();
    /*0x402ce0*/ void Update();
    /*0x402bf0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4027d0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x402990*/ int FirstArmorTakeDamage(int theDamage);
    /*0x402880*/ void Fall();
    /*0x4029d0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x402a90*/ void PositionUpdate();
}

class BlueGargantuar : Gargantuar
{
    /*0x3d7de0*/ BlueGargantuar();
    /*0x402df0*/ void Start();
}

class BoatImp : Zombie
{
    /*0x3d7de0*/ BoatImp();
    /*0x3fc1e0*/ void Awake();
    /*0x4036b0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x403210*/ void BodyTakeDamage(int theDamage);
    /*0x403560*/ int GetZombieRow();
    /*0x402e30*/ void AnimPop();
    /*0x3db780*/ void AnimPopOver();
    /*0x3f7e60*/ void Die(int reason);
    /*0x4033a0*/ void DieEvent(int reason);
}

class BombThrower : KirovAirship
{
    /*0x250*/ UnityEngine.GameObject patels1;
    /*0x258*/ UnityEngine.GameObject patels2;

    /*0x403ad0*/ BombThrower();
    /*0x403760*/ void Awake();
    /*0x32d010*/ void PlayMachineSound();
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x4037a0*/ void CreateBomb();
    /*0x403a50*/ void MoveUpdate();
    /*0x403ab0*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
}

class BungiZombie : Zombie
{
    /*0x248*/ UnityEngine.GameObject BungeeCord;
    /*0x250*/ UnityEngine.GameObject bungeeTarget;
    /*0x258*/ ZombieBoss boss;
    /*0x260*/ int targetColumn;
    /*0x264*/ UnityEngine.Vector2 target;
    /*0x26c*/ float moveSpeed;
    /*0x270*/ float startY;
    /*0x274*/ bool targetLand;
    /*0x278*/ System.Collections.Generic.List<UnityEngine.Rendering.SortingGroup> hands;
    /*0x280*/ UnityEngine.SpriteRenderer s;
    /*0x288*/ bool setZombie;
    /*0x28c*/ ZombieType theSetZombieType;
    /*0x290*/ UnityEngine.GameObject preZombie;

    /*0x406180*/ BungiZombie();
    /*0x403fb0*/ void Awake();
    /*0x405640*/ void Scream();
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void EatGarlic(Plant plant, float time, bool withSound);
    /*0x403790*/ void BodyTakeDamage(int theDamage);
    /*0x403f30*/ void AttributeEvent();
    /*0x32d010*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x405b50*/ void SetZombie();
    /*0x405bb0*/ void Start();
    /*0x4046f0*/ void GetZombiePlace();
    /*0x403dc0*/ void AnimPutZombie();
    /*0x404640*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x406100*/ void Update();
    /*0x3f7e60*/ void Die(int reason);
    /*0x4056b0*/ void SetTarget();
    /*0x4049d0*/ void MoveToTarget();
    /*0x4040f0*/ void BungeeTargetPositonUpdate();
    /*0x405f00*/ bool Stealable(Plant plant);
    /*0x404e00*/ void PositionUpdate();
    /*0x404380*/ bool FindUmbrella();
    /*0x4040e0*/ void Blocked();
    /*0x403ae0*/ void AnimCatch();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void CancelAttack();
    /*0x4060e0*/ bool <Start>b__22_0(Plant p);

    class <>c
    {
        static /*0x0*/ BungiZombie.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__28_0;

        static /*0x417cd0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x417c20*/ bool <SetTarget>b__28_0(Plant plant);
    }
}

class CatapultZombie : Zombie
{
    /*0x248*/ bool shooting;
    /*0x250*/ Plant _target;
    /*0x258*/ int basketballNum;

    /*0x407260*/ CatapultZombie();
    /*0x406220*/ void AnimShoot();
    /*0x4065f0*/ void BodyTakeDamage(int theDamage);
    /*0x406a80*/ void KillByCaltrop();
    /*0x3f7c80*/ void DieAndExplde();
    /*0x3db960*/ void Die(int reason);
    /*0x4068c0*/ void DieEvent(int reason);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x407230*/ void Update();
    /*0x4067e0*/ void CataUpdate();
    /*0x406eb0*/ void SearchPlantUpdate();
}

class CherryCatapultZombie : CatapultZombie
{
    /*0x407260*/ CherryCatapultZombie();
    /*0x407280*/ void AnimShoot();
}

class CherryShooterZ : PeaShooterZ
{
    /*0x407d20*/ CherryShooterZ();
    /*0x407b30*/ Bullet AnimShoot();
}

class DancePolevaulterZombie : PolevaulterZombie
{
    /*0x408360*/ DancePolevaulterZombie();
    /*0x407ee0*/ void JumpOver();
    /*0x408120*/ void SetZombie(int row, ZombieType zombieType, float x);
}

class DolphinGatlingZombie : PeaDolphinriderZombie
{
    /*0x268*/ UnityEngine.GameObject head1;
    /*0x270*/ UnityEngine.GameObject head2;

    /*0x408640*/ DolphinGatlingZombie();
    /*0x408470*/ void Start();
    /*0x408450*/ BulletType GetBulletType();
    /*0x408460*/ int GetDamage();
    /*0x408370*/ void AttributeEvent();
}

class DolphinriderZ : Zombie
{
    /*0x248*/ UnityEngine.Vector2 jumpPos2;
    /*0x250*/ UnityEngine.Vector2 range;
    /*0x258*/ bool willJumpFail;
    /*0x25c*/ UnityEngine.Vector3 failPos;

    /*0x4092d0*/ DolphinriderZ();
    /*0x4091d0*/ void Start();
    /*0x408880*/ void Die(int reason);
    /*0x408b60*/ void FixedUpdate();
    /*0x3f3b30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x4091c0*/ void JumpOver();
    /*0x4086f0*/ void CreateWaterSplash();
    /*0x408650*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x408f20*/ void JumpFail();
    /*0x4089d0*/ bool FindTallNut(int theColumn, int theRow);
}

class DrownCatapultZombie : CatapultZombie
{
    /*0x260*/ System.Collections.Generic.List<UnityEngine.GameObject> weapons;
    /*0x268*/ System.Collections.Generic.List<UnityEngine.GameObject> weapons2;
    /*0x270*/ System.Collections.Generic.List<UnityEngine.GameObject> damaged;

    /*0x40a340*/ DrownCatapultZombie();
    /*0x409810*/ void Awake();
    /*0x409ae0*/ void CataUpdate();
    /*0x409470*/ void AnimShoot();
    /*0x40a1b0*/ void SetWeapon(UnityEngine.Vector2 position);
    /*0x409c00*/ void DestoryWeapon2();
    /*0x4092f0*/ void AnimRelodeOver();
    /*0x409830*/ void BodyTakeDamage(int theDamage);
    /*0x409d80*/ void FirstArmorBroken();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
    /*0x409ff0*/ void KillByCaltrop();
    /*0x40a0c0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x40a140*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x409a60*/ void Buttered(float time, bool sprite);
}

class DrownZombie : Zombie
{
    /*0x248*/ float throwTime;

    static /*0x3eec90*/ bool CheckPlant(Plant plant);
    /*0x3d7de0*/ DrownZombie();
    /*0x40a9a0*/ void Awake();
    /*0x40ad40*/ void Start();
    /*0x40ad80*/ void Update();
    /*0x40ace0*/ void StartThrow();
    /*0x40aa60*/ DrownProjectile GetDrownWeapon();
    /*0x40a430*/ void AnimThrow();
    /*0x40abf0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x40a9c0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);

    class <>c
    {
        static /*0x0*/ DrownZombie.<> <>9;
        static /*0x8*/ System.Comparison<Plant> <>9__6_0;

        static /*0x417c60*/ <>c();
        /*0x32f970*/ <>c();
        /*0x417bf0*/ int <AnimThrow>b__6_0(Plant a, Plant b);
    }
}

class FootballDrown : DrownZombie
{
    /*0x3d7de0*/ FootballDrown();
    /*0x32d010*/ void LoseHeadEvent();
    /*0x40afc0*/ void FirstArmorBroken();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
}

class Gargantuar : Zombie
{
    /*0x248*/ UnityEngine.LayerMask _LayerMask;

    /*0x3d7de0*/ Gargantuar();
    /*0x40c090*/ void Awake();
    /*0x40cb50*/ void SetWeapon();
    /*0x40ccd0*/ void Start();
    /*0x40c940*/ void FixedUpdate();
    /*0x40c1d0*/ void BodyTakeDamage(int theDamage);
    /*0x40bdf0*/ void AttackUpdate();
    /*0x40ba90*/ Zombie AnimThrow();
    /*0x40b230*/ void AnimCrash();
    /*0x40c8e0*/ void CrashPlant(Plant plant);
    /*0x40cac0*/ void PlayFallSound();
    /*0x40ca60*/ void PlayDieSound();
    /*0x348b00*/ bool GetLadder(Plant plant);
    /*0x40c960*/ UnityEngine.Collider2D[] GetCols();
}

class GoldBungiZombie : BungiZombie
{
    /*0x298*/ bool blocked;
    /*0x299*/ bool summoned;

    /*0x406180*/ GoldBungiZombie();
    /*0x40ccf0*/ void Blocked();
    /*0x40cd20*/ void DieEvent(int reason);
}

class GreenGargantuar : Gargantuar
{
    /*0x3d7de0*/ GreenGargantuar();
    /*0x40d140*/ void CrashPlant(Plant plant);
}

class HorseZombie : Zombie
{
    /*0x248*/ SuperHorse superHorse;

    /*0x3d7de0*/ HorseZombie();
    /*0x40d410*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x40d350*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x40d2f0*/ void DieEvent(int reason);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
}

class IronBalloonZombie : BalloonZombie
{
    /*0x250*/ UnityEngine.GameObject bucketNut;
    /*0x258*/ UnityEngine.GameObject Petals1;
    /*0x260*/ UnityEngine.GameObject Petals2;

    /*0x3d7de0*/ IronBalloonZombie();
    /*0x40e780*/ int FirstArmorTakeDamage(int theDamage);
    /*0x40e4b0*/ void Fall();
    /*0x40e5e0*/ void FirstArmorBroken();
    /*0x350af0*/ void LoseHeadEvent();
    /*0x40e340*/ UnityEngine.GameObject DropArmor();
}

class IronBalloonZombie2 : IronBalloonZombie
{
    /*0x3d7de0*/ IronBalloonZombie2();
    /*0x40e210*/ void Awake();
    /*0x402990*/ int FirstArmorTakeDamage(int theDamage);
    /*0x40e230*/ void Fall();
    /*0x40e1b0*/ void AttributeEvent();
    /*0x40e040*/ void AnimShoot();
}

class IronGargantuar : Zombie
{
    /*0x3d7de0*/ IronGargantuar();
    /*0x40f070*/ void LoseIronHead();
    /*0x40e820*/ void BodyTakeDamage(int theDamage);
    /*0x40ecc0*/ void DestoryZombie();
    /*0x40eea0*/ void DieEvent(int reason);
    /*0x40f420*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetPoison(float time);
    /*0x40f520*/ void SetMindControl(int level);
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void AddPoisonLevel();
    /*0x32d010*/ void EatGarlic(Plant plant, float time, bool withSound);
    /*0x32d010*/ void SetJalaed();
    /*0x32d010*/ void SetEmbered();
}

class IronPeaZ : PeaShooterZ
{
    /*0x407d20*/ IronPeaZ();
    /*0x40f530*/ Bullet AnimShoot();
    /*0x40f720*/ void LoseHeadEvent();
}

class JackboxJumpZombie : SuperPogoZombie
{
    /*0x40fc00*/ JackboxJumpZombie();
    /*0x40f940*/ void DieEvent(int reason);
    /*0x40f890*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class JackboxZombie : Zombie
{
    /*0x248*/ UnityEngine.AudioSource audioSource;
    /*0x250*/ bool audioSourcePlaying;
    /*0x254*/ float popCountDown;
    /*0x258*/ float originalCountDown;

    /*0x3d7de0*/ JackboxZombie();
    /*0x40ff50*/ void Awake();
    /*0x410520*/ void Update();
    /*0x4102a0*/ void Pop();
    /*0x410250*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x40fc10*/ void AnimExplode();
    /*0x410170*/ void Explode();
    /*0x4103d0*/ void Start();
    /*0x410380*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4104d0*/ void Unfreezing();
    /*0x410070*/ void Buttered(float time, bool sprite);
    /*0x410480*/ void UnButtered();
    /*0x4100c0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x40fd10*/ bool AvaliableToPlay();
    /*0x410270*/ void LoseHeadEvent();
}

class KirovAirship : Zombie
{
    /*0x248*/ bool existBomb;

    /*0x403ad0*/ KirovAirship();
    /*0x410860*/ void Awake();
    /*0x4116e0*/ void SetMindControl(int controlLevel);
    /*0x411700*/ void Start();
    /*0x411460*/ void PlayMachineSound();
    /*0x4114f0*/ void PositionUpdate();
    /*0x4116b0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x410880*/ void BodyTakeDamage(int theDamage);
    /*0x4113d0*/ void FixedUpdate();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x410ac0*/ void BombUpdate();
    /*0x410f00*/ void CreateBomb();
    /*0x4116a0*/ void ReplaceBomb();
    /*0x4111b0*/ void DieEvent(int reason);
    /*0x4113b0*/ void Die(int reason);
    /*0x410e70*/ void CrashEvent();
}

class LadderZombie : DoorZombie
{
    /*0x260*/ Plant ladderTarget;

    /*0x3d8ba0*/ LadderZombie();
    /*0x4119f0*/ void Awake();
    /*0x32d010*/ void GetHand();
    /*0x411a10*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x411d00*/ void SecondArmorBroken();
    /*0x411f10*/ void SecondArmorFall();
    /*0x411b60*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x411780*/ void AnimSetLadder();
    /*0x411ab0*/ void LoseLadder();
}

class LegionZombie : Zombie
{
    /*0x248*/ UnityEngine.ParticleSystem particle;
    /*0x250*/ int startColumn;
    /*0x254*/ int endColumn;
    /*0x258*/ LegionZombie teammate;

    /*0x3d7de0*/ LegionZombie();
    /*0x4128e0*/ void Awake();
    /*0x413a10*/ void Start();
    /*0x32d010*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x413e10*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x413120*/ void Die(int reason);
    /*0x412f30*/ bool CheckAllLegionFall();
    /*0x4127f0*/ void AttributeEvent();
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x413350*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x413360*/ void SecondArmorBroken();
    /*0x412900*/ void BodyTakeDamage(int theDamage);
    /*0x413630*/ void SecondArmorFall();
    /*0x412700*/ void AnimQuickMove();
    /*0x412430*/ void AnimQuickMoveOver();
    /*0x4123b0*/ void AnimExplode();
    /*0x4130b0*/ System.Collections.IEnumerator DelayExplode();
    /*0x413e50*/ bool <CheckAllLegionFall>b__9_0(Zombie z);

    class <DelayExplode>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ LegionZombie <>4__this;
        /*0x28*/ int <i>5__2;
        /*0x2c*/ int <j>5__3;

        /*0x32f460*/ <DelayExplode>d__19(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x43b300*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x43b630*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class LevatationZombie : Zombie
{
    /*0x3d7de0*/ LevatationZombie();
    /*0x42c2a0*/ void Awake();
    /*0x42cba0*/ void PositionUpdate();
    /*0x42c2d0*/ void BodyTakeDamage(int theDamage);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x42c910*/ void DestoryZombie();
    /*0x42ca20*/ void OverRangeDie();
}

class MachineNutZombie : Zombie
{
    /*0x248*/ MachineNutZombie.MachineType machineType;

    /*0x3d7de0*/ MachineNutZombie();
    /*0x42de20*/ void Start();
    /*0x42d600*/ void InitType();
    /*0x42d550*/ void FixedUpdate();
    /*0x42cc00*/ void BodyTakeDamage(int theDamage);
    /*0x3db960*/ void Die(int reason);
    /*0x42da80*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x42ce90*/ void DieEvent(int reason);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetPoison(float time);
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void AddPoisonLevel();
    /*0x32d010*/ void EatGarlic(Plant plant, float time, bool withSound);
    /*0x42dab0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);

    enum MachineType
    {
        Default = 0,
        Red = 1,
        Blue = 2,
    }
}

class MinerZombie : Zombie
{
    /*0x248*/ UnityEngine.AudioSource audioSource;
    /*0x250*/ bool audioSourcePlaying;

    /*0x3d7de0*/ MinerZombie();
    /*0x42e850*/ void Start();
    /*0x42dea0*/ bool AvaliableToPlay();
    /*0x42e830*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x42e810*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x42ea40*/ void Update();
    /*0x42e1a0*/ void MinerUpdate();
    /*0x42e450*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x42e9b0*/ void Surprised();
    /*0x42e0e0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x42e190*/ void ChangeStatus();
    /*0x42e680*/ void Rise();
}

class PaperCherryZ : ArmorZombie
{
    /*0x248*/ float theZombieAttackInterval;
    /*0x24c*/ float theZombieAttackCountDown;

    /*0x42ff50*/ PaperCherryZ();
    /*0x42f830*/ void SecondArmorBroken();
    /*0x42f9b0*/ void SecondArmorFall();
    /*0x42f790*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x42f520*/ void AngrySound();
    /*0x42fd80*/ void Update();
    /*0x42fea0*/ void ZombieShootUpdate();
    /*0x42f5b0*/ Bullet AnimShoot();
    /*0x3f8d10*/ void Angry();
}

class PaperCherryZ95 : PaperZombie
{
    /*0x248*/ float theZombieAttackInterval;
    /*0x24c*/ float theZombieAttackCountDown;

    /*0x42f500*/ PaperCherryZ95();
    /*0x42f2b0*/ void Start();
    /*0x42ee00*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3dc600*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x3dc330*/ void BodyTakeDamage(int theDamage);
    /*0x3dc410*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x42ef60*/ void SecondArmorBroken();
    /*0x42f310*/ void Update();
    /*0x42f410*/ void ZombieShootUpdate();
    /*0x42eba0*/ Bullet AnimShoot();
    /*0x42ed80*/ void Buttered(float time, bool sprite);
    /*0x42f160*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x42f1e0*/ void SetJalaed();
    /*0x42f240*/ void SetPoison(float time);
    /*0x42eb40*/ void AddPoisonLevel();
    /*0x42f0e0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x42eeb0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class PeaDolphinriderZombie : SnowDolphinrider
{
    /*0x408360*/ PeaDolphinriderZombie();
    /*0x4301c0*/ void Awake();
    /*0x430150*/ void AttributeEvent();
    /*0x42ff70*/ void AnimShoot();
    /*0x4301e0*/ int GetDamage();
    /*0x388e90*/ BulletType GetBulletType();
}

class PeaShooterZ : Zombie
{
    /*0x248*/ bool hypnoPea;
    /*0x250*/ UnityEngine.GameObject hypnoHead;
    /*0x258*/ UnityEngine.GameObject normalHead;
    /*0x260*/ float theZombieAttackInterval;
    /*0x264*/ float theZombieAttackCountDown;

    /*0x430670*/ PeaShooterZ();
    /*0x430410*/ void Update();
    /*0x430540*/ void ZombieShootUpdate();
    /*0x4301f0*/ Bullet AnimShoot();
    /*0x4303f0*/ BulletType GetBulletType();
}

class PickaxeZombie : ConeZombie
{
    /*0x248*/ UnityEngine.Transform pickaxe;
    /*0x250*/ UnityEngine.Transform hat;
    /*0x258*/ TMPro.TextMeshPro progressText;
    /*0x260*/ UnityEngine.Rendering.SortingGroup textGroup;
    /*0x268*/ PickaxeZombie.PickaxeType pickaxeType;
    /*0x26c*/ float digSpeed;
    /*0x270*/ float progress;

    /*0x3d8ba0*/ PickaxeZombie();
    /*0x430690*/ void Awake();
    /*0x430960*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x430a00*/ void FirstArmorBroken();
    /*0x430ad0*/ void ZombieUpdate();
    /*0x430a80*/ float GetLevelSpeed(int health);
    /*0x430910*/ void CancelAttack();

    enum PickaxeType
    {
        Iron = 0,
        Gold = 1,
        Diamond = 2,
    }
}

class PogoZombie : Zombie
{
    /*0x248*/ UnityEngine.Vector2 jumpPos2;
    /*0x250*/ UnityEngine.Vector2 range;
    /*0x258*/ bool pause;
    /*0x259*/ bool startJump;
    /*0x25c*/ int wait;

    /*0x3f4040*/ PogoZombie();
    /*0x3f32d0*/ void Awake();
    /*0x431900*/ void Start();
    /*0x431440*/ void LandSound();
    /*0x430e80*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f3b30*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x430ff0*/ void FixedUpdate();
    /*0x431680*/ void PoloUpdate();
    /*0x4314e0*/ void LoseHeadEvent();
    /*0x431030*/ void JumpFail();
    /*0x431520*/ void LoseJumper(int reason);
    /*0x3f3dc0*/ void PositionUpdate();
    /*0x3f3390*/ void DieEvent(int reason);
    /*0x3f3f80*/ void SetFreeze(float time, int theFreezeLevel);
}

class PolevaulterZombie : Zombie
{
    /*0x248*/ UnityEngine.Vector2 jumpPos2;
    /*0x250*/ UnityEngine.Vector2 range;

    /*0x4092d0*/ PolevaulterZombie();
    /*0x431970*/ void Awake();
    /*0x431a20*/ void FixedUpdate();
    /*0x431f50*/ void OnDrawGizmos();
    /*0x4321f0*/ void PolUpdate();
    /*0x4326b0*/ void StartJump();
    /*0x432070*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x431f00*/ void JumpOver();
    /*0x432130*/ void PlayJumpSound1();
    /*0x432190*/ void PlayJumpSound2();
    /*0x431990*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x431a80*/ void JumpFail();
}

class QingZombie : Zombie
{
    /*0x248*/ bool quickmove;
    /*0x250*/ UnityEngine.ParticleSystem particle;

    /*0x3d7de0*/ QingZombie();
    /*0x432a80*/ void Awake();
    /*0x433480*/ void Start();
    /*0x4329b0*/ void AttributeEvent();
    /*0x432d50*/ void DieEvent(int reason);
    /*0x432b80*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x432e20*/ void PlayEatSound();
    /*0x432dd0*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x432db0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x4331c0*/ void QuickDamage(UnityEngine.Collider2D collision);
    /*0x4333e0*/ void StartQuickMove();
    /*0x3f0630*/ void QuickMoveOver();
    /*0x432c20*/ void DestoryZombie();
    /*0x432730*/ void AttackPlants();
}

class QuickJacksonZombie : ZombieJackson
{
    /*0x260*/ UnityEngine.ParticleSystem particle;

    /*0x433a00*/ QuickJacksonZombie();
    /*0x4334f0*/ void Awake();
    /*0x4336d0*/ ZombieType GetZombieType();
    /*0x433920*/ void Start();
    /*0x433960*/ void StopMoonWalk();
    /*0x433590*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x433740*/ void PositionUpdate();
    /*0x433630*/ void Die(int reason);
    /*0x433690*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
}

class RandomGargantuar : Gargantuar
{
    /*0x250*/ bool summon;

    /*0x3d8ba0*/ RandomGargantuar();
    /*0x433a10*/ void BodyTakeDamage(int theDamage);
    /*0x434070*/ void FirstArmorBroken();
    /*0x4340f0*/ void FirstArmorFall();
}

class SandJackson : ZombieJackson
{
    /*0x433a00*/ SandJackson();
    /*0x4344d0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x434570*/ ZombieType GetZombieType();
}

class SnorkleZombie : Zombie
{
    /*0x3d7de0*/ SnorkleZombie();
    /*0x434580*/ void Awake();
    /*0x434670*/ void Start();
    /*0x4345a0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x434630*/ void Die(int reason);
    /*0x434650*/ void LoseHeadEvent();
}

class SnowDolphinrider : DolphinriderZ
{
    /*0x408360*/ SnowDolphinrider();
    /*0x434840*/ void JumpOver();
    /*0x32d010*/ void JumpFail();
    /*0x434740*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
}

class SnowDrown : DrownZombie
{
    /*0x250*/ UnityEngine.GameObject weaponPrefab;

    /*0x3d8ba0*/ SnowDrown();
    /*0x4349d0*/ DrownProjectile GetDrownWeapon();
    /*0x434930*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
}

class SnowGunZombie : Zombie
{
    /*0x248*/ bool shooting;
    /*0x24c*/ UnityEngine.Vector3 targetPosition;

    /*0x3d7de0*/ SnowGunZombie();
    /*0x434e10*/ void Awake();
    /*0x434e30*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x4351d0*/ void Update();
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x434da0*/ void AttributeEvent();
    /*0x434b40*/ void AnimShoot();
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x434ed0*/ void SearchPlantUpdate();
}

class SnowShieldZombie : Zombie
{
    /*0x248*/ UnityEngine.LayerMask bulletLayer;
    /*0x24c*/ bool bounding;

    /*0x3d7de0*/ SnowShieldZombie();
    /*0x435640*/ void Awake();
    /*0x435710*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x435fb0*/ void SecondArmorBroken();
    /*0x436280*/ void SecondArmorFall();
    /*0x3f32a0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x3f32c0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4357b0*/ void FixedUpdate();
    /*0x436690*/ void Update();
    /*0x435980*/ void ReboundUpdate();
    /*0x4357f0*/ UnityEngine.Collider2D[] GetCollider2Ds(float range, float range2);
    /*0x4358b0*/ UnityEngine.Vector2 GetReboundCenter(float range);
    /*0x4352a0*/ void AnimRebound();
}

class SuperCherryZ : PeaShooterZ
{
    /*0x430670*/ SuperCherryZ();
    /*0x4368e0*/ void Start();
    /*0x4366f0*/ Bullet AnimShoot();
}

class SuperGargantuar : Gargantuar
{
    /*0x3d8ba0*/ SuperGargantuar();
    /*0x32d010*/ void SetWeapon();
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x436900*/ void AnimCrash();
    /*0x437e60*/ void SetImps();
    /*0x437690*/ void FirstArmorBroken();
    /*0x436c50*/ void BodyTakeDamage(int theDamage);
    /*0x436950*/ Zombie AnimThrow();
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x437900*/ void FirstArmorFall();
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x437670*/ void Buttered(float time, bool sprite);
    /*0x437e40*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x437e10*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x437d10*/ UnityEngine.Collider2D[] GetCols();
}

class SuperHorse : Zombie
{
    /*0x248*/ bool summoned;

    /*0x3d7de0*/ SuperHorse();
    /*0x40e210*/ void Awake();
    /*0x438bd0*/ void Start();
    /*0x4380c0*/ void AnimFlagUp();
    /*0x438ad0*/ int SecondArmorTakeDamage(int theDamage);
    /*0x438a50*/ void SecondArmorBroken();
    /*0x438780*/ void BodyTakeDamage(int theDamage);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x4386c0*/ void AttributeEvent();
    /*0x438540*/ void AnimShoot();
    /*0x438960*/ void DestoryZombie();
    /*0x4389e0*/ System.Collections.IEnumerator FadeDeath();
    /*0x438010*/ void AnimDestoryHorse();
    /*0x438280*/ void AnimRevive();
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);

    class <FadeDeath>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ SuperHorse <>4__this;
        /*0x28*/ float <i>5__2;

        /*0x32f460*/ <FadeDeath>d__11(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x43b670*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x43bd20*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class SuperJackboxZombie : JackboxZombie
{
    /*0x3d8ba0*/ SuperJackboxZombie();
    /*0x438fd0*/ void FirstArmorBroken();
    /*0x439160*/ void FirstArmorFall();
    /*0x438be0*/ void AnimExplode();
    /*0x438d40*/ void DieEvent(int reason);
}

class SuperKirov : KirovAirship
{
    /*0x4397f0*/ SuperKirov();
    /*0x439570*/ void Awake();
    /*0x439630*/ void CreateBomb();
    /*0x439590*/ void BombUpdate();
}

class SuperLadderZombie : LadderZombie
{
    /*0x268*/ UnityEngine.Sprite redLadder;
    /*0x270*/ GridLadder ladder;
    /*0x278*/ int count;

    /*0x3d8370*/ SuperLadderZombie();
    /*0x439b80*/ void DieEvent(int reason);
    /*0x439c10*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x439800*/ void AnimSetLadder();

    class <>c
    {
        static /*0x0*/ SuperLadderZombie.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__4_0;

        static /*0x43be10*/ <>c();
        /*0x32f970*/ <>c();
        /*0x43bd60*/ bool <GetDamage>b__4_0(Plant p);
    }
}

class SuperMachineNutZombie : MachineNutZombie
{
    /*0x3d7de0*/ SuperMachineNutZombie();
    /*0x32d010*/ void InitType();
    /*0x439f00*/ void DieEvent(int reason);
}

class SuperPogoZombie : PogoZombie
{
    /*0x260*/ float waitTime;
    /*0x264*/ bool jumped;
    /*0x265*/ bool loseJumper;
    /*0x268*/ float jumpX;

    /*0x3f4040*/ SuperPogoZombie();
    /*0x43a970*/ void Start();
    /*0x43aa80*/ void Update();
    /*0x43a1b0*/ void BigJump();
    /*0x43a700*/ void PositionUpdate();
    /*0x43a220*/ void FirstArmorBroken();
    /*0x3edb20*/ int FirstArmorTakeDamage(int theDamage);
    /*0x43a490*/ void LoseJumper(int reason);
}

class SuperPolevaulterZombie : PolevaulterZombie
{
    /*0x4092d0*/ SuperPolevaulterZombie();
}

class TrainingDummy : Zombie
{
    /*0x248*/ int lastDamage;
    /*0x24c*/ float currentSecondDamage;
    /*0x250*/ System.Collections.Generic.Queue<float> last10SecondDamages;
    /*0x258*/ float dpsUpdateTimer;
    /*0x25c*/ float <CurrentDPS>k__BackingField;
    /*0x260*/ float <Average10SecDPS>k__BackingField;
    /*0x264*/ int totalDamage;

    /*0x43b230*/ TrainingDummy();
    /*0x43b2c0*/ float get_CurrentDPS();
    /*0x43b2f0*/ void set_CurrentDPS(float value);
    /*0x43b2b0*/ float get_Average10SecDPS();
    /*0x43b2e0*/ void set_Average10SecDPS(float value);
    /*0x43b2d0*/ int get_LastDamage();
    /*0x43aca0*/ void TakeDamage(DmgType theDamageType, int damage, bool fix);
    /*0x43ac60*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x43b170*/ void Update();
    /*0x43ad30*/ void UpdateDPSRecords();
    /*0x43af20*/ void UpdateHealthText();
    /*0x414580*/ void Die(int reason);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x43ac90*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3db780*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
}

class UltimateFootballDrownZombie : FootballDrown
{
    /*0x250*/ UnityEngine.GameObject weapon;
    /*0x258*/ UnityEngine.GameObject w;

    /*0x3d8ba0*/ UltimateFootballDrownZombie();
    /*0x43bfd0*/ void Awake();
    /*0x43bef0*/ void AttributeEvent();
    /*0x43c250*/ void Start();
    /*0x32d010*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x43bff0*/ DrownProjectile GetDrownWeapon();
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
}

class UltimateGargantuar : SuperGargantuar
{
    /*0x3d8ba0*/ UltimateGargantuar();
    /*0x43c9d0*/ void Start();
    /*0x43c2f0*/ Zombie AnimThrow();
    /*0x43c5f0*/ void DieEvent(int reason);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x43c790*/ void SetImps();
}

class UltimateHorse : Zombie
{
    /*0x248*/ System.Collections.Generic.List<Plant> cursedPlants;
    /*0x250*/ bool shootable;
    /*0x254*/ float startRunTimer;
    /*0x258*/ bool flaged;

    /*0x43e150*/ UltimateHorse();
    /*0x43d250*/ void Awake();
    /*0x43de80*/ void Start();
    /*0x43d8b0*/ void MoveUpdate();
    /*0x43d150*/ void AttributeEvent();
    /*0x43d4d0*/ void ClearCursed();
    /*0x43d970*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x43cfa0*/ void AnimShoot();
    /*0x43d2f0*/ void BodyTakeDamage(int theDamage);
    /*0x43cb10*/ void AnimFlagUp();
    /*0x43d720*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x43ca60*/ void AnimDestoryHorse();
    /*0x43ccd0*/ void AnimRevive();
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x43d6b0*/ void DieEvent(int reason);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x43e140*/ void <Awake>b__4_0();

    class <>c
    {
        static /*0x0*/ UltimateHorse.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__9_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__9_1;

        static /*0x43be80*/ <>c();
        /*0x32f970*/ <>c();
        /*0x43bd90*/ bool <OnTriggerStay2D>b__9_0(Plant p);
        /*0x43bde0*/ bool <OnTriggerStay2D>b__9_1(Plant p);
    }
}

class UltimateJackboxZombie : Zombie
{
    /*0x3d7de0*/ UltimateJackboxZombie();
    /*0x3edb00*/ void Awake();
    /*0x43ee80*/ void Start();
    /*0x43e720*/ void AttributeEvent();
    /*0x43e1d0*/ void AnimPop();
    /*0x43e790*/ void BodyTakeDamage(int theDamage);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x3f7e60*/ void Die(int reason);
    /*0x43ed90*/ void DieEvent(int reason);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
}

class UltimateKirovZombie : Zombie
{
    /*0x248*/ UnityEngine.GameObject weaponPrefab;

    /*0x3d7de0*/ UltimateKirovZombie();
    /*0x3edb00*/ void Awake();
    /*0x43f9a0*/ void Start();
    /*0x43f1a0*/ void AttributeEvent();
    /*0x43ef00*/ void AnimShoot();
    /*0x43f960*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x43f920*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x43f2b0*/ void BodyTakeDamage(int theDamage);
    /*0x3f7e60*/ void Die(int reason);
    /*0x43f740*/ void DieEvent(int reason);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x43f980*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetMindControl(int controlLevel);
}

class UltimateMachineNutZombie : SuperMachineNutZombie
{
    /*0x3d8ba0*/ UltimateMachineNutZombie();
    /*0x43fc60*/ void Start();
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x43fc30*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x43ac60*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x348b00*/ bool Instead(int damage);
}

class UltimatePaperZombie : Zombie
{
    /*0x248*/ UnityEngine.Transform shoot2;
    /*0x250*/ bool a;

    /*0x3d7de0*/ UltimatePaperZombie();
    /*0x440240*/ void Awake();
    /*0x4415c0*/ void Start();
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x3f7e60*/ void Die(int reason);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x440310*/ void DieEvent(int reason);
    /*0x440110*/ void AttributeEvent();
    /*0x43ff80*/ void AnimShoot();
    /*0x4409a0*/ Plant GetTargetPlant();
    /*0x43fce0*/ void AnimShoot2();
    /*0x440270*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x440c20*/ void KillByCaltrop();
    /*0x440ca0*/ void SecondArmorBroken();
    /*0x440ef0*/ void SecondArmorFall();
    /*0x4404d0*/ void FirstArmorBroken();
    /*0x440920*/ int FirstArmorTakeDamage(int theDamage);
    /*0x441640*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x3dc330*/ void BodyTakeDamage(int theDamage);
    /*0x3dc340*/ void Buttered(float time, bool sprite);
    /*0x3dc5e0*/ void SetFreeze(float time, int theFreezeLevel);
}

class UltimateSnowZombie : Zombie
{
    /*0x248*/ System.Collections.Generic.List<UnityEngine.Transform> shoots;
    /*0x250*/ UnityEngine.GameObject bigSnowBall;
    /*0x258*/ bool boss;
    /*0x25c*/ float bossTimer;

    /*0x442e50*/ UltimateSnowZombie();
    /*0x442470*/ void Awake();
    /*0x442dd0*/ void Start();
    /*0x442a80*/ void MoveUpdate();
    /*0x442290*/ void AttributeEvent();
    /*0x442b50*/ Plant SearchPlant();
    /*0x441a20*/ void AnimShoot1();
    /*0x441ec0*/ void AnimShoot2();
    /*0x441660*/ void AnimGetSword();
    /*0x4421f0*/ void AnimShoot3();
    /*0x4424a0*/ void BodyTakeDamage(int theDamage);
    /*0x3dbf90*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x32d010*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x32d010*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
}

class YellowGargantuar : Gargantuar
{
    /*0x3d8ba0*/ YellowGargantuar();
    /*0x442ee0*/ Zombie AnimThrow();
}

class Zombie9527 : Zombie
{
    /*0x248*/ bool changeRow;

    /*0x3d7de0*/ Zombie9527();
    /*0x443230*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x442fe0*/ void BodyTakeDamage(int theDamage);
}

class ZombieBoss : Zombie
{
    /*0x248*/ int targetRow;
    /*0x24c*/ int targetColumn;
    /*0x250*/ int ballType;
    /*0x254*/ int summonCount;
    /*0x258*/ int spawnCount;
    /*0x25c*/ int summonBallCount;
    /*0x260*/ float summonTime;
    /*0x264*/ float ballCountDown;
    /*0x268*/ bool ball;
    /*0x270*/ UnityEngine.Animator animDriver;
    /*0x278*/ UnityEngine.Animator animRV;
    /*0x280*/ UnityEngine.Transform ballPosition;
    /*0x288*/ UnityEngine.Transform spawnPosition;
    /*0x290*/ UnityEngine.SpriteRenderer eye;
    /*0x298*/ ZombieBoss.BossStatus bossStatus;
    /*0x2a0*/ UnityEngine.GameObject head;
    /*0x2a8*/ UnityEngine.GameObject thumb;
    /*0x2b0*/ UnityEngine.GameObject jaw;
    /*0x2b8*/ UnityEngine.GameObject hand;
    /*0x2c0*/ UnityEngine.GameObject foot_inner;
    /*0x2c8*/ UnityEngine.GameObject foot_outter;
    /*0x2d0*/ UnityEngine.GameObject eyes;

    /*0x4440c0*/ ZombieBoss();
    /*0x4472e0*/ void Start();
    /*0x444ad0*/ void BodyTakeDamage(int theDamage);
    /*0x444a80*/ void Awake();
    /*0x447320*/ void Update();
    /*0x445440*/ void BossUpdate();
    /*0x447020*/ void SpawnUpdate();
    /*0x4466a0*/ void HeadUpdate();
    /*0x446dd0*/ void Skill();
    /*0x446ce0*/ void SetBungi(int theColumn);
    /*0x4440f0*/ void AnimBungi();
    /*0x446b40*/ void RvPositionUpdate(int theColumn, int theRow);
    /*0x445f10*/ void FootCrash(int row);
    /*0x446b00*/ void RemoveDeBuff();
    /*0x445530*/ System.Collections.IEnumerator ColoredEye(UnityEngine.Color color);
    /*0x446aa0*/ void MachineSound2();
    /*0x4449a0*/ void AnimSpawn();
    /*0x4443d0*/ void AnimPutBall();
    /*0x4447d0*/ void AnimRv();
    /*0x444150*/ void AnimCrash();
    /*0x445fe0*/ ZombieType GetZombieType();
    /*0x4002e0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x3ffb30*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x447300*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x444340*/ void AnimFootSound();
    /*0x445a20*/ void DieExplode();
    /*0x4455e0*/ void DieEvent(int reason);
    /*0x445b40*/ void DriverDie();
    /*0x4455b0*/ void DieAnimOver();
    /*0x445b90*/ void DropAward();
    /*0x445b20*/ void Die(int reason);
    /*0x32d010*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x32d010*/ void Buttered(float time, bool sprite);
    /*0x32d010*/ void SetPoison(float time);
    /*0x32d010*/ void AddPoisonLevel();
    /*0x32d010*/ void EatGarlic(Plant plant, float time, bool withSound);
    /*0x32d010*/ void Garliced(bool playSound, bool certainRow);
    /*0x32d010*/ void SetMindControl(int controlLevel);
    /*0x446db0*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x43f980*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x32d010*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);

    enum BossStatus
    {
        enter = 0,
        idle = 1,
        spawn = 2,
        foot = 3,
        rv = 4,
        head_enter = 5,
        head_idle = 6,
        head_leave = 7,
        bungi = 8,
    }

    class <ColoredEye>d__35 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ZombieBoss <>4__this;
        /*0x28*/ UnityEngine.Color color;
        /*0x38*/ UnityEngine.Color <currentColor>5__2;
        /*0x48*/ float <time>5__3;
        /*0x4c*/ float <during>5__4;

        /*0x32f460*/ <ColoredEye>d__35(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x43fa20*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x43fbf0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ZombieBoss2 : ZombieBoss
{
    /*0x4440c0*/ ZombieBoss2();
    /*0x443460*/ void BodyTakeDamage(int theDamage);
    /*0x4432d0*/ void AnimRv();
}

class ZombieJackson : Zombie
{
    /*0x248*/ float moonWalkTime;
    /*0x250*/ UnityEngine.GameObject[] dancer;
    /*0x258*/ bool isMoonWalkFinish;
    /*0x259*/ bool isAbledToAttack;

    /*0x448d40*/ ZombieJackson();
    /*0x447ae0*/ void Awake();
    /*0x448c80*/ void Update();
    /*0x447d70*/ void FixedUpdate();
    /*0x4483f0*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x448840*/ void PointOver();
    /*0x448120*/ ZombieType GetZombieType();
    /*0x4475c0*/ void AnimSummon();
    /*0x448900*/ UnityEngine.GameObject SetZombie(float x, int row);
    /*0x448850*/ void SetMindControl(int controlLevel);
    /*0x448290*/ void LookForward();
    /*0x448130*/ void LookBack();
    /*0x447b40*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x447460*/ void AdjustAttackPosition();
    /*0x447bf0*/ void CreateParticle(UnityEngine.Vector3 position);
    /*0x448c30*/ void StopMoonWalk();
}

class Zombie : Entity
{
    static int butterLayer = 40;
    static int kelpLayer = 39;
    static int iceLayer = 38;
    /*0x48*/ Zombie.FirstArmorType theFirstArmorType;
    /*0x4c*/ Zombie.SecondArmorType theSecondArmorType;
    /*0x50*/ Zombie.UniqueItemType theUniqueItemType;
    /*0x54*/ ZombieStatus theStatus;
    /*0x58*/ Towards towards;
    /*0x60*/ UnityEngine.GameObject theFirstArmor;
    /*0x68*/ UnityEngine.GameObject theSecondArmor;
    /*0x70*/ System.Collections.Generic.List<UnityEngine.GameObject> theUniqueItems;
    /*0x78*/ UnityEngine.SpriteRenderer headGarlic;
    /*0x80*/ UnityEngine.SpriteRenderer jawGarlic;
    /*0x88*/ int theHealth;
    /*0x8c*/ int theMaxHealth;
    /*0x90*/ int theFirstArmorHealth;
    /*0x94*/ int theFirstArmorMaxHealth;
    /*0x98*/ int theSecondArmorHealth;
    /*0x9c*/ int theSecondArmorMaxHealth;
    /*0xa0*/ int theAttackDamage;
    /*0xa8*/ UnityEngine.GameObject theAttackTarget;
    /*0xb0*/ UnityEngine.Transform shoot;
    /*0xb8*/ UnityEngine.GameObject accurateHeart;
    /*0xc0*/ UnityEngine.Rigidbody2D rb;
    /*0xc8*/ UnityEngine.Collider2D col;
    /*0xd0*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0xd8*/ WaterSpray waterSpray;
    /*0xe0*/ ZombieType theZombieType;
    /*0xe4*/ int theZombieRow;
    /*0xe8*/ int theTargetRow;
    /*0xec*/ int freezeLevel;
    /*0xf0*/ int poisonLevel;
    /*0xf4*/ int statusLevel;
    /*0xf8*/ float theSpeed;
    /*0xfc*/ float theOriginSpeed;
    /*0x100*/ float freezeSpeed;
    /*0x104*/ float freezeTimer;
    /*0x108*/ float coldSpeed;
    /*0x10c*/ float coldTimer;
    /*0x110*/ float butterSpeed;
    /*0x114*/ float butterTimer;
    /*0x118*/ float grapSpeed;
    /*0x11c*/ float grabTimer;
    /*0x120*/ float garlicSpeed;
    /*0x124*/ float uniqueSpeed;
    /*0x128*/ float holeSpeed;
    /*0x12c*/ float scaredTimer;
    /*0x130*/ float poisonTimer;
    /*0x134*/ float attributeCountDown;
    /*0x138*/ float portaledTimer;
    /*0x13c*/ float protaledTotalTimer;
    /*0x140*/ float existTime;
    /*0x144*/ float ladderTime;
    /*0x148*/ bool inWater;
    /*0x149*/ bool isStopped;
    /*0x14a*/ bool isMindControlled;
    /*0x14b*/ bool isChangingRow;
    /*0x14c*/ bool isMoving;
    /*0x14d*/ bool isAttacking;
    /*0x14e*/ bool isJalaed;
    /*0x14f*/ bool isPortaled;
    /*0x150*/ bool isEmbered;
    /*0x151*/ bool isDoom;
    /*0x152*/ bool isSmall;
    /*0x153*/ bool doomWithPit;
    /*0x154*/ bool beforeDying;
    /*0x155*/ bool isSplited;
    /*0x156*/ bool isGold;
    /*0x158*/ bool[] controlledLevel;
    /*0x160*/ bool isBlowed;
    /*0x161*/ bool isPreview;
    /*0x164*/ int awardLevel;
    /*0x168*/ System.Collections.Generic.Dictionary<ZombieTimer, float> timers;
    /*0x170*/ TMPro.TextMeshPro healthText;
    /*0x178*/ TMPro.TextMeshPro healthTextShadow;
    /*0x180*/ Zombie pre;
    /*0x188*/ Zombie next;
    /*0x190*/ UnityEngine.LayerMask plantLayer;
    /*0x194*/ UnityEngine.LayerMask zombieLayer;
    /*0x198*/ UnityEngine.LayerMask zombieLayer2;
    /*0x19c*/ float flashTime;
    /*0x1a0*/ bool loseHand;
    /*0x1a4*/ int theFirstArmorBroken;
    /*0x1a8*/ int theSecondArmorBroken;
    /*0x1ac*/ int takeDamageTimes;
    /*0x1b0*/ float vx;
    /*0x1b4*/ float vy;
    /*0x1b8*/ float dy;
    /*0x1c0*/ UnityEngine.Sprite headOriginalSprite;
    /*0x1c8*/ UnityEngine.Material flashMaterial;
    /*0x1d0*/ UnityEngine.GameObject iceTrap;
    /*0x1d8*/ UnityEngine.GameObject grap;
    /*0x1e0*/ UnityEngine.GameObject butter;
    /*0x1e8*/ UnityEngine.GameObject butterHead;
    /*0x1f0*/ UnityEngine.GameObject portalGlow;
    /*0x1f8*/ UnityEngine.Vector2 lastLadder;
    /*0x200*/ int freezeMaxLevel;
    /*0x204*/ int dieReason;
    /*0x208*/ int grapTimes;
    /*0x20c*/ float deadRight;
    /*0x210*/ float deadLeft;
    /*0x214*/ float poisonDamageTime;
    /*0x218*/ float lastTakeDamageDuring;
    /*0x21c*/ float poisonDamageMaxTime;
    /*0x220*/ bool droppedSun;
    /*0x221*/ bool eatGarlic;
    /*0x222*/ bool revived;
    /*0x228*/ System.Collections.Generic.List<UnityEngine.Transform> changeSprites;
    /*0x230*/ System.Action defaultAction;
    /*0x238*/ int fireFlyedCount;
    /*0x240*/ UnityEngine.GameObject fireFly;

    /*0x459880*/ Zombie();
    /*0x459c70*/ int get_CurrentFirstHealth();
    /*0x459c80*/ float get_TotalFirstHealth();
    /*0x459aa0*/ bool get_Alive();
    /*0x459bf0*/ int get_Column();
    /*0x459ac0*/ BoxType get_BoxType();
    /*0x449b00*/ void Awake();
    /*0x4578e0*/ void Start();
    /*0x4592c0*/ void Update();
    /*0x32d010*/ void ZombieUpdate();
    /*0x453300*/ void PlayEatSound2();
    /*0x450a60*/ void FixedUpdate();
    /*0x452b70*/ void OnFixedUpdate();
    /*0x453280*/ void OverRangeDie();
    /*0x4527f0*/ void MoveUpdate();
    /*0x459220*/ void UpdateSpeed();
    /*0x453fa0*/ void PositionUpdate();
    /*0x4526c0*/ void LadderPositionUpdate();
    /*0x449a90*/ void AttributeUpdate();
    /*0x32d010*/ void AttributeEvent();
    /*0x452ad0*/ void OnDestroy();
    /*0x453f00*/ void PoisonUpdate();
    /*0x44aee0*/ void ChangeRowAndMove(int theTargetRow, float time);
    /*0x452760*/ System.Collections.IEnumerator MoveRowByGarlic(int theTargetRow, float time);
    /*0x4573b0*/ void SetRowLayer(int theRow);
    /*0x44bf30*/ void Die(int reason);
    /*0x454a70*/ void RemoveFromLink();
    /*0x44f4a0*/ void EmberExplode();
    /*0x452170*/ void JalaedExplode(bool jala, int damage);
    /*0x44d620*/ void DropGardenPlant();
    /*0x32d010*/ void DieEvent(int reason);
    /*0x451fc0*/ bool Instead(int damage);
    /*0x457bc0*/ void TakeDamage(DmgType theDamageType, int theDamage, bool fix);
    /*0x4513f0*/ int GetDamage(int theDamage, DmgType theDamageType, bool fix);
    /*0x454d80*/ void Scared();
    /*0x44b840*/ void DecreaseDamageByBoss(ref float damage);
    /*0x44b1e0*/ bool CheckExist(ZombieType zombieType);
    /*0x454e10*/ void SecondArmorFall();
    /*0x44f9a0*/ void FindAndDestoryZombieHand(UnityEngine.GameObject obj);
    /*0x44fc10*/ void FindAndDestoryZombieHead(UnityEngine.GameObject obj);
    /*0x449190*/ void AnimLoseActive(UnityEngine.Transform obj);
    /*0x44fea0*/ void FindAndReplaceArmUpperSprite(UnityEngine.GameObject obj);
    /*0x44adf0*/ void ChangeArmSpirte(UnityEngine.GameObject arm);
    /*0x450100*/ UnityEngine.GameObject FindJaw(UnityEngine.GameObject obj);
    /*0x44a3c0*/ void BodyTakeDamage(int theDamage);
    /*0x32d010*/ void LoseHeadEvent();
    /*0x450be0*/ void FlashUpdate();
    /*0x455170*/ void SetBrightness(float b);
    /*0x452c70*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x452b90*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
    /*0x451c20*/ bool GetLadder(Plant plant);
    /*0x44ad80*/ void CancelAttack();
    /*0x453e90*/ void PlayFallSound();
    /*0x44beb0*/ void DestoryZombie();
    /*0x44be40*/ System.Collections.IEnumerator DecreaseTransparent();
    /*0x4536d0*/ void PlayEatSound();
    /*0x44afc0*/ void ChangeStatus(ZombieStatus targetStatus);
    /*0x449510*/ void AttackBrain(Brain brain);
    /*0x449970*/ void AttackZombie(Zombie zombie);
    /*0x44d950*/ void DropItem();
    /*0x44ded0*/ void DropKilledAward();
    /*0x458240*/ bool TryDropAward();
    /*0x457440*/ void ShootingDropSun();
    /*0x44cbe0*/ void DropAward();
    /*0x44e2a0*/ void DropWheat();
    /*0x44cf20*/ void DropCardInRandomTravel();
    /*0x44d130*/ void DropCard();
    /*0x44afd0*/ void Charred(int damage, bool fix, DmgType damageType);
    /*0x455350*/ void SetCarred();
    /*0x44f7f0*/ bool ExistAnim();
    /*0x456a40*/ void SetMindControl(int controlLevel);
    /*0x456940*/ void SetLayerMask();
    /*0x449020*/ void AdjustPosition(UnityEngine.GameObject zombie, UnityEngine.Vector3 position);
    /*0x455bf0*/ void SetColor(Zombie.ZombieColor colorType);
    /*0x451d10*/ UnityEngine.Color GetMixColor(UnityEngine.Color color1, UnityEngine.Color color2);
    /*0x4512b0*/ UnityEngine.Color GetColor(Zombie.ZombieColor colorType);
    /*0x448fb0*/ void AddfreezeLevel(int level);
    /*0x457160*/ void SetPortaled(float timer);
    /*0x458510*/ void UnPortaled();
    /*0x456520*/ void SetGold();
    /*0x456910*/ void SetJalaed();
    /*0x455ec0*/ void SetEmbered();
    /*0x455ef0*/ void SetFreeze(float time, int theFreezeLevel);
    /*0x457050*/ void SetPoison(float time);
    /*0x448da0*/ void AddPoisonLevel();
    /*0x4584d0*/ void UnPoisoned();
    /*0x44f2c0*/ void EatGarlic(Plant plant, float time, bool withSound);
    /*0x44b790*/ System.Collections.IEnumerator DeLayGarliced(float during, bool playSound, bool certainRow);
    /*0x450c80*/ void Garliced(bool playSound, bool certainRow);
    /*0x4548e0*/ void RecoverGarliced();
    /*0x4585a0*/ void Unfreezing();
    /*0x455870*/ void SetCold(float time, int coldLevel, bool freeze);
    /*0x456540*/ void SetGrap(float time, bool land);
    /*0x4597a0*/ void Warm();
    /*0x44a800*/ void Buttered(float time, bool sprite);
    /*0x44b120*/ bool CheckButtered();
    /*0x4583f0*/ void UnButtered();
    /*0x450370*/ UnityEngine.GameObject FindZombieHead();
    /*0x458490*/ void UnCold();
    /*0x4524c0*/ void KillDebuff();
    /*0x4569a0*/ void SetMaskLayer();
    /*0x388e90*/ UnityEngine.GameObject DropArmor();
    /*0x32d010*/ void FirstArmorBroken();
    /*0x450700*/ void FirstArmorFall();
    /*0x450990*/ int FirstArmorTakeDamage(int theDamage);
    /*0x32d010*/ void SecondArmorBroken();
    /*0x4550a0*/ int SecondArmorTakeDamage(int theDamage);
    /*0x44b270*/ Plant CrashEntity(UnityEngine.Collider2D collision, bool inWater);
    /*0x450f40*/ int GetAvaliableRow(int originalRow);
    /*0x4510d0*/ int GetCertainRow(int originalRow);
    /*0x449670*/ void AttackPlant(Plant plant);
    /*0x4495b0*/ void AttackEffect(Plant plant);
    /*0x44e530*/ bool EatEffect(Plant plant);
    /*0x449f80*/ void BeSmall(float scale);
    /*0x452580*/ void KnockBack(float x, Zombie.KnockBackReason reason);
    /*0x451e00*/ void InitHealth();
    /*0x451940*/ UnityEngine.GameObject GetHealth(string name, int order);
    /*0x4588b0*/ void UpdateHealthText();
    /*0x32d010*/ void KillByCaltrop();
    /*0x459ca0*/ UnityEngine.Vector2 get_Velocity();
    /*0x459b10*/ UnityEngine.Vector2 get_ColliderPosition();
    /*0x454980*/ void Recover(float value);
    /*0x448ec0*/ void AddTimer(ZombieTimer zombieTimer, float value);
    /*0x451d70*/ float GetTimer(ZombieTimer zombieTimer);
    /*0x450540*/ void FireFlyed(int count);
    /*0x413e50*/ bool <Start>b__120_0(Zombie n);

    enum KnockBackReason
    {
        ByUmbrella = 0,
        ByIronPea = 1,
        ByJalapeno = 2,
        ByTangleKelp = 3,
    }

    enum FirstArmorType
    {
        Nothing = 0,
        Cone = 1,
        Bucket = 2,
        Doll = 3,
        FootballHelmet = 4,
        WallNut = 5,
        TallNut = 6,
        TallNutFootball = 7,
        BucketNut = 8,
        Balloon = 9,
        IronBalloon = 10,
    }

    enum SecondArmorType
    {
        Nothing = 0,
        Door = 1,
        Paper = 2,
        Ladder = 3,
        SnowShield = 4,
        Protal = 5,
        RedLadder = 6,
    }

    enum UniqueItemType
    {
        Nothing = 0,
        Jackbox = 1,
        Jumper = 2,
        Pickaxe = 3,
        IronHead = 4,
        RedIronHead = 5,
    }

    enum ZombieColor
    {
        Default = 0,
        Cold = 1,
        MindConrolled = 2,
        Jalaed = 3,
        Doom = 4,
        Poison = 5,
        Poison_with_cold = 6,
        Ember = 7,
        Jala_with_ember = 8,
        Gold = 9,
        DarkRed = 10,
    }

    class <>c
    {
        static /*0x0*/ Zombie.<> <>9;
        static /*0x8*/ System.Func<Zombie, bool> <>9__144_0;
        static /*0x10*/ System.Func<Plant, bool> <>9__161_0;
        static /*0x18*/ System.Predicate<PlantType> <>9__179_0;
        static /*0x20*/ System.Func<UnityEngine.AnimatorControllerParameter, bool> <>9__183_0;
        static /*0x28*/ System.Func<Zombie, bool> <>9__195_0;
        static /*0x30*/ System.Func<Zombie, bool> <>9__204_0;

        static /*0x471530*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4708c0*/ bool <Instead>b__144_0(Zombie z);
        /*0x4708f0*/ bool <OnTriggerStay2D>b__161_0(Plant p);
        /*0x470830*/ bool <DropCard>b__179_0(PlantType p);
        /*0x470950*/ bool <SetMindControl>b__183_0(UnityEngine.AnimatorControllerParameter param);
        /*0x470920*/ bool <SetFreeze>b__195_0(Zombie z);
        /*0x470920*/ bool <SetCold>b__204_0(Zombie z);
    }

    class <DeLayGarliced>d__200 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ float during;
        /*0x28*/ Zombie <>4__this;
        /*0x30*/ bool playSound;
        /*0x31*/ bool certainRow;

        /*0x32f460*/ <DeLayGarliced>d__200(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x46fa50*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x46fb20*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <DecreaseTransparent>d__167 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Zombie <>4__this;
        /*0x28*/ UnityEngine.Material <material>5__2;
        /*0x30*/ float <i>5__3;

        /*0x32f460*/ <DecreaseTransparent>d__167(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x46fb60*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x46fe80*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }

    class <MoveRowByGarlic>d__136 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ int theTargetRow;
        /*0x28*/ Zombie <>4__this;
        /*0x30*/ float time;
        /*0x34*/ int <theNextRow>5__2;
        /*0x38*/ float <startY>5__3;
        /*0x3c*/ float <elapsedTime>5__4;
        /*0x40*/ float <duringTime>5__5;

        /*0x32f460*/ <MoveRowByGarlic>d__136(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x470460*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4707f0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

enum ZombieTimer
{
    SuperSeashroom = 0,
}

class WaterSpray : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.GameObject _prefab;
    /*0x20*/ float liveTimer;
    /*0x28*/ UnityEngine.GameObject water;
    /*0x30*/ Zombie zombie;
    /*0x38*/ float coolTimer;
    /*0x3c*/ bool active;

    static /*0x471ad0*/ UnityEngine.GameObject get_Prefab();
    /*0x471ab0*/ WaterSpray();
    /*0x471600*/ void Awake();
    /*0x4715a0*/ void Active();
    /*0x4719e0*/ void Update();
    /*0x471990*/ void OnDestroy();
}

class ZombieSpawner : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ System.Collections.Generic.List<System.Collections.Generic.List<ZombieType>> zombieList;
    /*0x30*/ System.Collections.Generic.HashSet<ZombieType> appearedZombieTypes;
    /*0x38*/ float hugeWaveTimer;
    /*0x3c*/ float nextWaveTimer;
    /*0x40*/ float waveInterval;

    /*0x473100*/ ZombieSpawner();
    /*0x471f00*/ void Awake();
    /*0x472900*/ void Start();
    /*0x472500*/ void OnUpdate();
    /*0x471f10*/ void EnterNewWave();
    /*0x472760*/ void PreSummon();
    /*0x4720f0*/ void FirstWaveEvent();
    /*0x4723c0*/ void HugeWaveEvent();
    /*0x472420*/ void LastWaveEvent();
    /*0x472700*/ void OnZombieSummoned(Zombie zombie);
    /*0x472980*/ void SummonZombieFromList();
    /*0x4722c0*/ System.Collections.Generic.List<int> GetRow();
    /*0x473080*/ bool <SummonZombieFromList>b__15_0(int row);
    /*0x4730c0*/ bool <SummonZombieFromList>b__15_1(int row);
    /*0x4730c0*/ bool <SummonZombieFromList>b__15_2(int row);
    /*0x473080*/ bool <SummonZombieFromList>b__15_3(int row);
}

class MiniMapMask : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Camera mainCamera;
    /*0x28*/ UnityEngine.Vector3[] frustumCorners;

    /*0x46f0f0*/ MiniMapMask();
    /*0x46ee40*/ void Awake();
    /*0x46ee70*/ void Update();
}

class CanvasUpUI : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ CanvasUpUI();
    /*0x45c610*/ void Start();
}

class CheatKey : UnityEngine.MonoBehaviour
{
    /*0x20*/ string key;
    /*0x28*/ float timer;
    /*0x30*/ System.Collections.Generic.Dictionary<string, System.Action> CheatKeys;

    /*0x45cc90*/ CheatKey();
    /*0x45c920*/ void Update();
    /*0x45c730*/ void CheckCheatCodes();

    class <>c
    {
        static /*0x0*/ CheatKey.<> <>9;
        static /*0x8*/ System.Action <>9__5_0;
        static /*0x10*/ System.Action <>9__5_1;
        static /*0x18*/ System.Action <>9__5_2;
        static /*0x20*/ System.Action <>9__5_3;
        static /*0x28*/ System.Action <>9__5_4;
        static /*0x30*/ System.Action <>9__5_5;
        static /*0x38*/ System.Action <>9__5_6;
        static /*0x40*/ System.Action <>9__5_7;
        static /*0x48*/ System.Action <>9__5_8;

        static /*0x4714c0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4709b0*/ void <.ctor>b__5_0();
        /*0x470a80*/ void <.ctor>b__5_1();
        /*0x470b60*/ void <.ctor>b__5_2();
        /*0x470ca0*/ void <.ctor>b__5_3();
        /*0x470eb0*/ void <.ctor>b__5_4();
        /*0x471080*/ void <.ctor>b__5_5();
        /*0x471250*/ void <.ctor>b__5_6();
        /*0x4712b0*/ void <.ctor>b__5_7();
        /*0x4713a0*/ void <.ctor>b__5_8();
    }
}

class CursorChange : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.Texture2D curDefault;
    static /*0x8*/ UnityEngine.Texture2D curClick;

    static /*0x45d580*/ void SetDefaultCursor();
    static /*0x45d4d0*/ void SetClickCursor();
    /*0x31c640*/ CursorChange();
}

class CustomIZManager
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, IZData> customIZDatas;
    /*0x18*/ System.Collections.Generic.List<string> levelNames;

    /*0x460900*/ CustomIZManager(string path);
    /*0x460620*/ void LoadLevelData(string path);
}

class CustomLevelEnter : UIBtn
{
    /*0x60*/ string levelName;
    /*0x68*/ UnityEngine.Transform menu;

    /*0x317730*/ CustomLevelEnter();
    /*0x460a70*/ void Start();
    /*0x4609e0*/ void OnMouseUpAsButton();
}

class CustomLevelShower : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject levelWindowPrefab;
    /*0x28*/ UnityEngine.GameObject gridPrefab;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.Transform> pages;

    /*0x461060*/ CustomLevelShower();
    /*0x460b40*/ void Awake();
    /*0x460b50*/ void Show();
}

class SwitchBtn : UIBtn
{
    /*0x60*/ UnityEngine.GameObject normalPage;
    /*0x68*/ UnityEngine.GameObject customPage;

    /*0x317730*/ SwitchBtn();
    /*0x46f990*/ void Awake();
    /*0x46f9e0*/ void OnMouseUpAsButton();
}

class CustomBlock : UnityEngine.MonoBehaviour
{
    /*0x20*/ GridType[] gridTypes;
    /*0x28*/ UnityEngine.Vector2[] blockPostion;
    /*0x30*/ UnityEngine.SpriteRenderer r;

    /*0x45ff00*/ CustomBlock();
    /*0x45fdc0*/ void Awake();
    /*0x45fe10*/ void UpdateGridTypes();
    /*0x45f7a0*/ void AdjustSprite();
}

class CustomBlockBlack : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theColumn;
    /*0x24*/ int theRow;
    /*0x28*/ UnityEngine.SpriteRenderer r;

    /*0x31c640*/ CustomBlockBlack();
    /*0x45d660*/ void Awake();
    /*0x45d6b0*/ void UpdateTransparent();
}

class CustomBlockMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CustomBlockMgr Instance;
    static /*0x8*/ string path;
    /*0x20*/ UnityEngine.GameObject block;
    /*0x28*/ UnityEngine.GameObject darkBlock;
    /*0x30*/ UnityEngine.Material cornerLeftInner;
    /*0x38*/ UnityEngine.Material cornerRightInnner;
    /*0x40*/ UnityEngine.Material cornerLeftOutter;
    /*0x48*/ UnityEngine.Material cornerRightOutter;
    /*0x50*/ UnityEngine.Material cornersLeft;
    /*0x58*/ UnityEngine.Material cornersRight;
    /*0x60*/ UnityEngine.Material full;
    /*0x68*/ UnityEngine.Material half_x;
    /*0x70*/ UnityEngine.Material half_y;
    /*0x78*/ UnityEngine.Material nothing;
    /*0x80*/ System.Collections.Generic.List<CustomBlock> blocks;
    /*0x88*/ System.Collections.Generic.List<CustomBlockBlack> shadows;

    static /*0x45daa0*/ CustomBlockData GetBlockData();
    /*0x45f6d0*/ CustomBlockMgr();
    /*0x45d750*/ void Awake();
    /*0x45f3a0*/ void Update();
    /*0x45eb70*/ void OnBoxTypeChange(int theGridX, int theGridY, BoxType theGridType);
    /*0x45d890*/ System.Collections.Generic.List<CustomBlock> GetBlockContainBox(int theGridX, int theGridY);
    /*0x45e650*/ void LoadBlockData();
    /*0x45e900*/ void LoadResources();
    /*0x45dcf0*/ void InitBlocks();
    /*0x45dbd0*/ GridType GetBoxType(int x, int y);
    /*0x45eda0*/ void SaveBlockData();
}

class CustomBlockData
{
    /*0x10*/ bool isSaved;
    /*0x18*/ BoxType[] blockType;
    /*0x20*/ PlantType[] disabledPlantType;
    /*0x28*/ ZombieType[] appearedZombieType;
    /*0x30*/ int theMaxWave;
    /*0x34*/ int startSun;
    /*0x38*/ bool isScaredyDream;
    /*0x39*/ bool isSeedRain;
    /*0x3a*/ bool isIndestructible;
    /*0x3b*/ bool isColumn;
    /*0x3c*/ bool enableTravelPlant;
    /*0x3d*/ bool enableTravelBuff;
    /*0x3e*/ bool isSuperRandom;
    /*0x40*/ int zombieHealth;
    /*0x44*/ SceneType sceneType;
    /*0x48*/ bool isConvey;
    /*0x50*/ System.Collections.Generic.List<bool> advBuffs;
    /*0x58*/ System.Collections.Generic.List<int> ultiBuffs;
    /*0x60*/ System.Collections.Generic.List<bool> debuffs;

    /*0x32f970*/ CustomBlockData();
}

enum GridType
{
    Grass = 0,
    Water = 1,
    Dirt = 2,
}

class CustomData : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CustomData Instance;
    /*0x20*/ PlantType[] disabledPlantType;
    /*0x28*/ ZombieType[] appearedZombieType;
    /*0x30*/ int theMaxWave;
    /*0x34*/ int startSun;
    /*0x38*/ bool isScaredyDream;
    /*0x39*/ bool isSeedRain;
    /*0x3a*/ bool isIndestructible;
    /*0x3b*/ bool isColumn;
    /*0x3c*/ bool enableTravelPlant;
    /*0x3d*/ bool enableTravelBuff;
    /*0x3e*/ bool isSuperRandom;
    /*0x3f*/ bool isConvey;
    /*0x40*/ int zombieHealth;
    /*0x44*/ SceneType sceneType;
    /*0x48*/ System.Collections.Generic.HashSet<PlantType> disabledPlant;
    /*0x50*/ System.Collections.Generic.HashSet<ZombieType> appearedZombie;

    /*0x460540*/ CustomData();
    /*0x4600b0*/ void Awake();
    /*0x460280*/ void GetLastData();
    /*0x460020*/ void AddDiabledPlant(PlantType theSeedType);
    /*0x45ff90*/ void AddAppearZombie(ZombieType theZombieType);
    /*0x460410*/ void RemoveAppearZombie(ZombieType theZombieType);
    /*0x4604a0*/ void SetAppearZombie();
    /*0x4604f0*/ void SetDiabledPlant();
}

class CustomSettings : UIBtn
{
    /*0x60*/ CustomSettings.SettingsType settingsType;
    /*0x68*/ TMPro.TextMeshProUGUI textMesh;
    /*0x70*/ bool isActive;

    /*0x317730*/ CustomSettings();
    /*0x461e50*/ void Awake();
    /*0x4622e0*/ void OnMouseUpAsButton();
    /*0x461ee0*/ void ChangeText();

    enum SettingsType
    {
        isColumn = 0,
        isIndestructible = 1,
        isSeedRain = 2,
        isScaredyDream = 3,
        enableTravelPlant = 4,
        enableTravelBuff = 5,
        isSuperRandom = 6,
        isConvey = 7,
    }
}

class CustomSun : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TMP_InputField inputField;
    /*0x28*/ TMPro.TMP_InputField setFlags;
    /*0x30*/ TMPro.TMP_InputField setHealth;
    /*0x38*/ UnityEngine.GameObject lookZombie;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.GameObject> settings;

    /*0x4629b0*/ CustomSun();
    /*0x4624b0*/ void Awake();
    /*0x462780*/ void SetSun();
    /*0x4628a0*/ void SetWave();
    /*0x462680*/ void SetHealth();
}

class SelectedZombie : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ SelectedZombie();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class SelectYourPlants : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI TextMeshProUGUI;
    /*0x28*/ TMPro.TextMeshProUGUI TextMeshProUGUI2;

    /*0x31c640*/ SelectYourPlants();
    /*0x46f520*/ void Awake();
}

class SetCustomZombie : UIBtn
{
    /*0x317730*/ SetCustomZombie();
    /*0x46f7c0*/ void OnMouseUpAsButton();
}

class SetCustomZombieBtn : NormalBtn
{
    /*0x58*/ bool isRemove;

    /*0x317730*/ SetCustomZombieBtn();
    /*0x46f5d0*/ void OnMouseUpAsButton();
    /*0x46f690*/ void Update();
}

class CustomPlantManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.List<CustomPlant> plants;
    static /*0x8*/ CustomPlantManager Instance;
    /*0x20*/ PlantType thePlantType;
    /*0x24*/ int maxAbility;
    /*0x28*/ TMPro.TextMeshProUGUI abilityText;
    /*0x30*/ TMPro.TMP_InputField attackDamage;
    /*0x38*/ TMPro.TMP_InputField attackInterval;
    /*0x40*/ TMPro.TMP_InputField theHealthText;
    /*0x48*/ TMPro.TMP_InputField theCD;
    /*0x50*/ TMPro.TMP_InputField theSun;

    static /*0x4616b0*/ void SaveData(CustomPlant plant);
    static /*0x461390*/ SavedCustomPlantData GetData();
    static /*0x4615d0*/ void InitPlants();
    static /*0x461c10*/ bool SetCustomPlant(Plant plant);
    static /*0x461480*/ CustomPlant GetPlantData(PlantType thePlantType);
    static /*0x461a90*/ bool SetCustomCard(CardUI card);
    static /*0x4613f0*/ string GetPath();
    /*0x461e40*/ CustomPlantManager();
    /*0x4610e0*/ void Awake();
    /*0x461da0*/ void Update();
    /*0x461140*/ int CalculateAbility();
    /*0x461370*/ bool CheckSave();
}

class SavedCustomPlantData
{
    /*0x10*/ System.Collections.Generic.List<CustomPlant> customPlants;

    /*0x32f970*/ SavedCustomPlantData();
}

class CustomPlant
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int theAttackDamage;
    /*0x18*/ float theAttackInterval;
    /*0x1c*/ int theSun;
    /*0x20*/ float theCD;
    /*0x24*/ int theHealth;

    /*0x32f970*/ CustomPlant();
}

class PlantDataLoader
{
    static /*0x0*/ PlantDataLoader.PlantData_[] plantData;
    static /*0x8*/ System.Collections.Generic.Dictionary<PlantType, PlantDataLoader.PlantData_> plantDatas;

    static /*0x46f450*/ PlantDataLoader();
    static /*0x46f150*/ void LoadPlantData();
    /*0x32f970*/ PlantDataLoader();

    class PlantData_
    {
        /*0x10*/ PlantType 植物类型;
        /*0x14*/ float 攻击间隔;
        /*0x18*/ float 生产间隔;
        /*0x1c*/ int attackDamage;
        /*0x20*/ int 最大生命值;
        /*0x24*/ float 冷却;
        /*0x28*/ int 价格;

        /*0x32f970*/ PlantData_();
    }
}

class ZombieDataManager
{
    static /*0x0*/ System.Collections.Generic.Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic;

    static /*0x471e10*/ ZombieDataManager();
    static /*0x471ba0*/ void LoadData();
    /*0x32f970*/ ZombieDataManager();

    struct ZombieData
    {
        /*0x10*/ ZombieType theZombieType;
        /*0x14*/ int theAttackDamage;
        /*0x18*/ int theMaxHealth;
        /*0x1c*/ int theFirstArmorMaxHealth;
        /*0x20*/ int theSecondArmorMaxHealth;

        /*0x471ea0*/ void LoadData(Zombie zombie);
    }
}

class DifficultyMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.UI.Slider slider;
    /*0x28*/ TMPro.TextMeshProUGUI t;

    /*0x31c640*/ DifficultyMgr();
    /*0x462a30*/ void Start();
    /*0x462b40*/ void Update();
}

class GameAPP : UnityEngine.MonoBehaviour
{
    static float const_x = 1.350000023841858;
    static float const_y = 1.6699999570846558;
    static float const_y2 = 1.4500000476837158;
    static float mower_x = -6;
    static int MaxDamage = 1000000;
    static float 屋顶X坐标 = 1.5;
    static float 屋顶斜率 = 0.2199999988079071;
    static int 基础卡数量 = 40;
    static int 字符串长度 = 64;
    static float 屋顶偏移 = 0.10000000149011612;
    static int ultimatePlantStartID = 900;
    static /*0x0*/ UnityEngine.GameObject gameAPP;
    static /*0x8*/ GameAPP Instance;
    static /*0x10*/ UnityEngine.Transform canvas;
    static /*0x18*/ UnityEngine.Transform canvasUp;
    static /*0x20*/ UnityEngine.GameObject miniCanvas;
    static /*0x28*/ UnityEngine.GameObject mainMenuCanvas;
    static /*0x30*/ UnityEngine.GameObject board;
    static /*0x38*/ UnityEngine.Transform boardTransform;
    static /*0x40*/ UnityEngine.Camera miniCamera;
    static /*0x48*/ UnityEngine.AudioClip[] audioPrefab;
    static /*0x50*/ UnityEngine.GameObject[] particlePrefab;
    static /*0x58*/ UnityEngine.GameObject[] itemPrefab;
    static /*0x60*/ UnityEngine.Sprite[] spritePrefab;
    static /*0x68*/ System.Collections.Generic.List<GameAPP.LastCards> lastCards;
    static /*0x70*/ System.Collections.Generic.List<UnityEngine.Material> materials;
    static /*0x78*/ UnityEngine.Material flashMaterial;
    static /*0x80*/ float gameMusicVolume;
    static /*0x84*/ float currentMusicVolume;
    static /*0x88*/ float currentDrumVolume;
    static /*0x8c*/ float gameSoundVolume;
    static /*0x90*/ int difficulty;
    static /*0x98*/ long theMoneyCount;
    static /*0xa0*/ bool[] advLevelCompleted;
    static /*0xa8*/ bool[] clgLevelCompleted;
    static /*0xb0*/ bool[] gameLevelCompleted;
    static /*0xb8*/ bool[] survivalLevelCompleted;
    static /*0xc0*/ System.Collections.Generic.HashSet<int> exploreLevelCompleted;
    static /*0xc8*/ System.Collections.Generic.HashSet<int> travelLevelCompleted;
    static /*0xd0*/ System.Collections.Generic.HashSet<int> skinLevelCompleted;
    static /*0xd8*/ int abyssArrivedLevel;
    static /*0xdc*/ int newAdvArrivedLevel;
    static /*0xe0*/ System.Collections.Generic.HashSet<string> nameLevelCompleted;
    static /*0xe8*/ float gameSpeed;
    static /*0xec*/ float cameraSize;
    static /*0xf0*/ float canvasMatch;
    static /*0xf4*/ float snapassqutch;
    static /*0xf8*/ bool shootingWithoutGlove;
    static /*0xf9*/ bool disablelevelTutor;
    static /*0xfa*/ bool wheatColor;
    static /*0xfb*/ bool disablePreSelectInAdv;
    static /*0xfc*/ bool distablexplodeFlash;
    static /*0xfd*/ bool disableSolarStarEffect;
    static /*0xfe*/ bool enableLevelZombie;
    static /*0x100*/ int theBoardLevel;
    static /*0x104*/ LevelType theBoardType;
    static /*0x108*/ string theIZLevelName;
    static /*0x110*/ GameStatus theGameStatus;
    static /*0x114*/ bool developerMode;
    static /*0x118*/ System.Collections.Generic.List<SoundCtrl> sound;
    static /*0x120*/ System.Collections.Generic.List<GameAPP.EVEPlant> plantEVE;
    static /*0x128*/ bool ra2Sound;
    static /*0x129*/ bool mouseFlip;
    static /*0x12a*/ bool isFullScreen;
    static /*0x130*/ string playerName;
    static /*0x138*/ int advantureLevel;
    static /*0x13c*/ int advantureZhouMu;
    static /*0x140*/ int towerLevel;
    static /*0x148*/ System.Collections.Generic.List<PlantType> randomPlantInZhouMu;
    static /*0x150*/ System.Collections.Generic.List<PlantType> bannedInPVPScaryPot;
    static /*0x158*/ bool almanalTextSafe;
    static /*0x159*/ bool TravelMenu;
    static /*0x160*/ ResourcesManager resourcesManager;
    static /*0x168*/ CustomIZManager customIZManager;
    static /*0x170*/ SoundManager soundManager;
    static /*0x178*/ ItemManager itemManager;
    static /*0x180*/ UIResourcesLoader UIManager;
    static /*0x188*/ UnityEngine.KeyCode keyCode;
    static /*0x190*/ System.Collections.Generic.List<UnityEngine.KeyCode> keyCode2;
    static /*0x198*/ UnityEngine.AudioSource music;
    static /*0x1a0*/ UnityEngine.AudioSource musicDrum;
    static /*0x1a8*/ PreludeMusic prelude;
    static /*0x1b0*/ DelayAction delayAction;
    static /*0x1b8*/ TMPro.TMP_FontAsset font;
    static /*0x1c0*/ TMPro.TMP_FontAsset font_col;
    static /*0x1c8*/ int fertizeCount;
    static /*0x1cc*/ int bugSprayCount;
    static /*0x1d0*/ int silverCoinCount;
    static /*0x1d4*/ int goldCoinCount;
    static /*0x1d8*/ int diamondCount;
    static /*0x1dc*/ UnityEngine.Vector3 CameraLastPoint;
    static /*0x1e8*/ GameStatus gameAppLastStatus;
    static /*0x1ec*/ bool hardZombie;
    static /*0x1f0*/ long RealTime;
    /*0x20*/ UnityEngine.Material defaultMaterial;
    /*0x28*/ UnityEngine.Material grayMaterial;
    /*0x30*/ UnityEngine.Material wheatMaterial;
    /*0x38*/ bool isDrumPlaying;
    /*0x3c*/ float realTimeUpdater;

    static /*0x46e330*/ GameAPP();
    static /*0x46ecd0*/ float get_Error_Value();
    static /*0x463b50*/ long GetTime();
    static /*0x46d570*/ void PlaySoundNotPause(int theSoundID, float theVolume);
    static /*0x46d6c0*/ void PlaySound(int theSoundID, float theVolume, float pitch);
    static /*0x46c850*/ void LoadTheResources();
    static /*0x467f00*/ void LoadSound();
    static /*0x464fb0*/ void LoadParticle();
    static /*0x46b0c0*/ void LoadSprite();
    static /*0x463c10*/ void LoadItem();
    /*0x31c640*/ GameAPP();
    /*0x462f30*/ void Awake();
    /*0x46e080*/ void Start();
    /*0x46d090*/ void PlayMusic(MusicType id);
    /*0x467950*/ void LoadResources();
    /*0x46e1a0*/ void Update();
    /*0x46cb60*/ void MusicUpdate();
    /*0x463680*/ void DayMusicUpdate();
    /*0x46cd20*/ void NightMusicUpdate();
    /*0x46dc30*/ void SearchEnumBug();

    struct EVEPlant
    {
        /*0x10*/ int row;
        /*0x14*/ int column;
        /*0x18*/ PlantType type;
    }

    struct LastCards
    {
        /*0x10*/ PlantType theSeedType;
        /*0x14*/ bool isExtra;
    }
}

class GameSpeedMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.UI.Slider slider;

    /*0x31c640*/ GameSpeedMgr();
    /*0x46ecf0*/ void Start();
    /*0x46eda0*/ void Update();
}

class AnimTool : UnityEngine.MonoBehaviour
{
    /*0x20*/ GardenPlant plant;
    /*0x28*/ System.Action action;

    /*0x31c640*/ AnimTool();
    /*0x45a2f0*/ void Fertilze();
    /*0x45a4d0*/ void Water();
    /*0x45a470*/ void PlayWaterSound();
    /*0x45a230*/ void BugSpray();
    /*0x45a3b0*/ void Phonograph();
}

class BaseTool : UnityEngine.MonoBehaviour
{
    /*0x20*/ ToolType toolType;
    /*0x24*/ bool take;
    /*0x28*/ UnityEngine.Collider2D col;
    /*0x30*/ UnityEngine.Transform parent;

    /*0x31c640*/ BaseTool();
    /*0x45a590*/ void Awake();
    /*0x45a780*/ void Update();
    /*0x45afa0*/ void Use(GardenEquipment equipment);
    /*0x45a950*/ void Use(BigGardenPlant plant);
    /*0x45a6f0*/ void Take();
    /*0x45a610*/ void PutDown();

    class <>c__DisplayClass7_0
    {
        /*0x10*/ BigGardenPlant plant;
        /*0x18*/ BaseTool <>4__this;

        /*0x32f970*/ <>c__DisplayClass7_0();
        /*0x471430*/ void <Use>b__0();
    }
}

enum ToolType
{
    WaterCan = 0,
    Fertilize = 1,
    BugSpray = 2,
    Phonograph = 3,
    Glove = 4,
}

class BigGardenPlant : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x24*/ int theColumn;
    /*0x28*/ int theRow;
    /*0x30*/ UnityEngine.GameObject bubble;
    /*0x38*/ UnityEngine.GameObject body;
    /*0x40*/ UnityEngine.Animator anim;
    /*0x48*/ Garden garden;
    /*0x50*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x58*/ TreasureCardData data;
    /*0x60*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;
    /*0x68*/ ToolType needTool;
    /*0x6c*/ bool satisfied;
    /*0x70*/ long nextTime;
    /*0x78*/ int stage;
    /*0x7c*/ int waterLevel;
    /*0x80*/ int cultivateLevel;

    static /*0x45b080*/ BigGardenPlant CreatePlant(Garden garden, PlantType thePlantType, int theColumn, int theRow);
    static /*0x45b9e0*/ UnityEngine.Vector3 GetPosition(Garden garden, int theColumn, int theRow);
    /*0x45c590*/ BigGardenPlant();
    /*0x45b070*/ void Awake();
    /*0x45bf80*/ void Start();
    /*0x45b8f0*/ void Update();
    /*0x45b8f0*/ void DemandUpdae();
    /*0x45b5c0*/ void Cultivated(ToolType tool);
    /*0x45bc00*/ void GiveAward(ItemType itemType);
    /*0x45bda0*/ void HighLight(float light);
    /*0x45ba60*/ void GetSpriteRenderers(UnityEngine.GameObject obj);
    /*0x45c2e0*/ void UpdateBubbleSprite();
    /*0x45bd30*/ System.Collections.IEnumerator Grow();

    class <Grow>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ BigGardenPlant <>4__this;
        /*0x28*/ float <targetScale>5__2;

        /*0x32f460*/ <Grow>d__27(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x46fec0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x470420*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class AutoBugSpray : GardenEquipment
{
    /*0x473690*/ AutoBugSpray();
    /*0x473550*/ void TimeUp();
}

class AutoFertilizer : GardenEquipment
{
    /*0x473690*/ AutoFertilizer();
    /*0x4736a0*/ void TimeUp();
}

class AutoPhonograph : GardenEquipment
{
    /*0x473690*/ AutoPhonograph();
    /*0x4737e0*/ void TimeUp();
}

class AutoWater : GardenEquipment
{
    /*0x473690*/ AutoWater();
    /*0x473920*/ void TimeUp();
}

class FishRod : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ FishRod();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class Garden : UnityEngine.MonoBehaviour
{
    static int particleLayer = 2;
    static /*0x0*/ Garden Instance;
    /*0x20*/ UnityEngine.Tilemaps.Tilemap tilemap;
    /*0x28*/ UnityEngine.Tilemaps.Tilemap treeTile;
    /*0x30*/ UnityEngine.Tilemaps.Tilemap freeBox;
    /*0x38*/ UnityEngine.Tilemaps.Tilemap waterBox;
    /*0x40*/ GardenPlayer player;
    /*0x48*/ BigGardenUI ui;
    /*0x50*/ UnityEngine.Vector2 mousePosition;
    /*0x58*/ UnityEngine.Vector2Int mouseCell;
    /*0x60*/ UnityEngine.Vector2Int mouseStartCell;
    /*0x68*/ UnityEngine.Vector2Int mouseEndCell;
    /*0x70*/ bool free;
    /*0x78*/ BaseTool toolOnMouse;
    /*0x80*/ GardenCard cardOnMouse;
    /*0x88*/ PropCard propCardOnMouse;
    /*0x90*/ BigGardenPlant plantOnMouse;
    /*0x98*/ GardenEquipment equipmentOnMouse;
    /*0xa0*/ UnityEngine.GameObject previewFollowMouse;
    /*0xa8*/ UnityEngine.GameObject previewOnWorld;
    /*0xb0*/ System.Collections.Generic.List<BigGardenPlant> plantOnFrame;
    /*0xb8*/ UnityEngine.GameObject frameRange;
    /*0xc0*/ System.Collections.Generic.Dictionary<System.ValueTuple<int, int>, BigGardenPlant> plants;
    /*0xc8*/ BigGardenPlant highLightPlant;
    /*0xd0*/ System.Collections.Generic.Dictionary<System.ValueTuple<int, int>, GardenEquipment> equipments;
    /*0xd8*/ GardenEquipment highLightEquipment;
    /*0xe0*/ float freeBoxFlashTimer;
    /*0xe4*/ bool framing;

    /*0x484c50*/ Garden();
    /*0x47ffe0*/ void Awake();
    /*0x484a50*/ void Update();
    /*0x480050*/ void FlashUpdate();
    /*0x4820f0*/ void MouseUpdate();
    /*0x480430*/ void HighLightUpdate();
    /*0x480e50*/ void MouseInputCheck();
    /*0x483690*/ void SelectFrame();
    /*0x483210*/ void RightClick();
    /*0x483e10*/ void SetPlantByCard(GardenCard card, int theColumn, int theRow);
    /*0x4847f0*/ void SetPropByCard(PropCard card, int theColumn, int theRow);
    /*0x482cf0*/ void MovePlantByGlove(BigGardenPlant plant, int theColumn, int theRow);
    /*0x482640*/ void MoveEquipmentByGlove(GardenEquipment equipment, int theColumn, int theRow);
    /*0x482a40*/ void MoveFrame();
    /*0x480b90*/ void LoadPlants();
    /*0x480a40*/ void LoadEquipments();
    /*0x480690*/ bool IsFreeBox(int theColumn, int theRow, PlantType thePlantType);
    /*0x480220*/ BigGardenPlant GetPlant(int theColumn, int theRow);
    /*0x480170*/ GardenEquipment GetGardenEquipment(int theColumn, int theRow);
    /*0x4802d0*/ System.Collections.Generic.List<BigGardenPlant> GetPlants(int theColumn, int theRow, int range);
    /*0x484210*/ System.ValueTuple<UnityEngine.GameObject, UnityEngine.GameObject> SetPreview(PlantType thePlantType);
    /*0x4843c0*/ void SetPreview(EquipmentType theEquipmentType, int range);
    /*0x4809b0*/ bool IsWaterBox(int theColumn, int theRow);
    /*0x480a00*/ bool IsWaterBox(UnityEngine.Vector3Int box);
    /*0x483bf0*/ UnityEngine.GameObject SetParticle(ParticleType particleType, UnityEngine.Vector2 position);

    class <>c
    {
        static /*0x0*/ Garden.<> <>9;
        static /*0x8*/ System.Predicate<TreasureCardData> <>9__41_0;

        static /*0x4897e0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x3ed6f0*/ bool <LoadPlants>b__41_0(TreasureCardData c);
    }
}

class GardenBoundary : UnityEngine.MonoBehaviour
{
    /*0x20*/ GardenPlayer player;
    /*0x28*/ UnityEngine.Vector2 forceDirection;
    /*0x30*/ bool playerIn;
    /*0x34*/ float timer;

    /*0x31c640*/ GardenBoundary();
    /*0x4766e0*/ void FixedUpdate();
    /*0x476760*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x476820*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
}

class GardenCamera : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Camera theCamrea;
    /*0x28*/ UnityEngine.Transform follow;
    /*0x30*/ float moveSpeed;
    /*0x34*/ float targetSize;

    /*0x31c640*/ GardenCamera();
    /*0x476a00*/ void Awake();
    /*0x476cb0*/ void Start();
    /*0x476d90*/ void Update();
    /*0x476a50*/ void Following();
}

class GardenEquipment : UnityEngine.MonoBehaviour
{
    /*0x20*/ EquipmentData data;
    /*0x28*/ Garden garden;
    /*0x30*/ UnityEngine.GameObject preview;
    /*0x38*/ UnityEngine.GameObject main;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;
    /*0x48*/ float timer;
    /*0x4c*/ float period;

    static /*0x477420*/ GardenEquipment SetEquipment(Garden garden, EquipmentData data);
    static /*0x4770e0*/ UnityEngine.GameObject SetEquipmentPreviewWithShadow(EquipmentType type);
    static /*0x477200*/ UnityEngine.GameObject SetEquipmentPreview(Garden garden, EquipmentType type);
    /*0x477800*/ GardenEquipment();
    /*0x476e00*/ void Awake();
    /*0x477790*/ void Update();
    /*0x476f00*/ void HighLight(float light);
    /*0x32d010*/ void TimeUp();
}

enum EquipmentType
{
    AutoWater = 0,
    AutoFertilizer = 1,
    AutoBugSpray = 2,
    AutoPhonograph = 3,
}

class GardenGlove : BaseTool
{
    /*0x38*/ bool gold;

    /*0x317730*/ GardenGlove();
    /*0x477880*/ void Update();
}

class GardenPlantPreview : UnityEngine.MonoBehaviour
{
    static /*0x477a30*/ GardenPlantPreview CreatePreview(PlantType thePlantType, UnityEngine.Vector2 position);
    /*0x31c640*/ GardenPlantPreview();
}

class GardenPlayer : UnityEngine.MonoBehaviour
{
    /*0x20*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> lowerBodys;
    /*0x28*/ UnityEngine.GameObject duck;
    /*0x30*/ Garden garden;
    /*0x38*/ UnityEngine.Rigidbody2D rb;
    /*0x40*/ UnityEngine.Animator anim;
    /*0x48*/ float moveSpeed;

    /*0x47a6d0*/ GardenPlayer();
    /*0x479bd0*/ void Awake();
    /*0x47a680*/ void Start();
    /*0x47a500*/ void Update();
    /*0x47a380*/ void FixedUpdate();
    /*0x479ca0*/ void EnterWater();
    /*0x47a010*/ void ExitWater();
    /*0x47a500*/ void InputUpdate();
}

class GardenWater : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ GardenWater();
    /*0x47ff00*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x47ff70*/ void OnTriggerExit2D(UnityEngine.Collider2D collision);
}

class ConfrimBtn : UIBtn
{
    /*0x60*/ GardenPlant plant;
    /*0x68*/ GardenTool gardenTool;
    /*0x70*/ bool yes;
    /*0x71*/ bool buy;

    /*0x317730*/ ConfrimBtn();
    /*0x474270*/ void OnMouseUpAsButton();
}

class GardenBattleManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ Board board;
    /*0x28*/ int progress;

    /*0x31c640*/ GardenBattleManager();
    /*0x475aa0*/ void Awake();
    /*0x476170*/ System.Collections.Generic.Queue<GardenPlantData> GetAvaliablePlants();
    /*0x4766d0*/ void Update();
    /*0x475c50*/ void BattleUpdate();
    /*0x4763a0*/ void Supply();
}

class GardenBox : UnityEngine.MonoBehaviour
{
    /*0x20*/ int column;
    /*0x24*/ int row;

    /*0x31c640*/ GardenBox();
}

class GardenBtn : UIBtn
{
    /*0x60*/ GardenBtn.GartenBtnType type;
    /*0x64*/ bool active;

    /*0x317730*/ GardenBtn();
    /*0x4768b0*/ void OnMouseUpAsButton();

    enum GartenBtnType
    {
        NextGarden = 0,
        Help = 1,
        LastGarden = 2,
        Store = 3,
        ExitStore = 4,
    }
}

class GardenMoney : UnityEngine.MonoBehaviour
{
    static /*0x0*/ GardenMoney Instance;
    /*0x20*/ TMPro.TextMeshProUGUI textMesh;
    /*0x28*/ UnityEngine.Transform pos;

    /*0x31c640*/ GardenMoney();
    /*0x477900*/ void Awake();
    /*0x477960*/ void Update();
}

class GardenPlant : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x24*/ int thePlantColumn;
    /*0x28*/ int thePlantRow;
    /*0x2c*/ int growStage;
    /*0x30*/ int waterLevel;
    /*0x34*/ int love;
    /*0x38*/ long nextTime;
    /*0x40*/ long currentTime;
    /*0x48*/ bool ready;
    /*0x49*/ bool preview;
    /*0x4a*/ bool onWheelBarrow;
    /*0x4c*/ int page;
    /*0x50*/ float battleTimer;
    /*0x54*/ UnityEngine.Vector2 plantScale;
    /*0x60*/ UnityEngine.GameObject plantObject;
    /*0x68*/ UnityEngine.Transform plantTargetAxis;
    /*0x70*/ UnityEngine.Transform plantAxis;
    /*0x78*/ UnityEngine.Transform axis;
    /*0x80*/ UnityEngine.Animator anim;
    /*0x88*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x90*/ UnityEngine.GameObject info;
    /*0x98*/ TMPro.TextMeshPro infoText;
    /*0xa0*/ GardenToolType needTool;
    /*0xa4*/ float timeUpdater;
    /*0xa8*/ float brightness;
    /*0xac*/ float infoShowTime;
    /*0xb0*/ UnityEngine.GameObject Bubble;
    /*0xb8*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers;

    /*0x479b40*/ GardenPlant();
    /*0x4788d0*/ void OnDestroy();
    /*0x477c90*/ void Awake();
    /*0x479020*/ void Start();
    /*0x478490*/ void FixedUpdate();
    /*0x4796e0*/ void Update();
    /*0x478280*/ void EnableInfo();
    /*0x479400*/ void UpdateInfo();
    /*0x478250*/ void DisableInfo();
    /*0x4780f0*/ void Die();
    /*0x478c60*/ void SetBrightness(float b);
    /*0x478e60*/ void SetColor(float r, float g, float b, float a);
    /*0x4785f0*/ void GetSpriteRenderers(UnityEngine.GameObject obj);
    /*0x479310*/ void TimeUpdate();
    /*0x478a30*/ void Ready();
    /*0x479970*/ void Watered(GardenToolType tool);
    /*0x4782c0*/ void Fertized(GardenToolType tool);
    /*0x477eb0*/ void Develop(GardenToolType tool);
    /*0x478940*/ void Prize();
    /*0x4787a0*/ long GetTime();
    /*0x478860*/ System.Collections.IEnumerator Grow();

    class <Grow>d__47 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GardenPlant <>4__this;
        /*0x28*/ UnityEngine.Vector3 <originalScale>5__2;
        /*0x34*/ UnityEngine.Vector3 <targetScale>5__3;
        /*0x40*/ float <elapsedTime>5__4;
        /*0x44*/ float <duration>5__5;

        /*0x32f460*/ <Grow>d__47(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x489110*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x489580*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class GardenTool : UnityEngine.MonoBehaviour
{
    /*0x20*/ GardenToolType type;
    /*0x28*/ UnityEngine.RectTransform parent;
    /*0x30*/ UnityEngine.Collider2D _collider2D;
    /*0x38*/ UnityEngine.Vector3 originalPosition;
    /*0x48*/ UnityEngine.RectTransform rectTransform;
    /*0x50*/ GardenUI gardenManager;
    /*0x58*/ GardenPlant plantOnWheel;

    /*0x31c640*/ GardenTool();
    /*0x47aac0*/ void Awake();
    /*0x47b350*/ void Start();
    /*0x47af30*/ void InputUpdate();
    /*0x47b140*/ void PickUp();
    /*0x47b240*/ void PutDown();
    /*0x47b530*/ void Use(GardenPlant plant, UnityEngine.Vector2 position);
    /*0x47b3a0*/ void Update();
    /*0x47ab80*/ void CreatePreview(GardenPlant plant);
    /*0x47b0b0*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
}

class GardenUI : UnityEngine.MonoBehaviour
{
    static /*0x0*/ GardenUI Instance;
    /*0x20*/ int currentPage;
    /*0x24*/ bool inStore;
    /*0x25*/ bool inWorld;
    /*0x28*/ UnityEngine.GameObject gardenObject;
    /*0x30*/ GardenTool toolOnMouse;
    /*0x38*/ GardenPlant plantOnGlove;
    /*0x40*/ GardenPlant plantOnWheel;
    /*0x48*/ UnityEngine.GameObject plantFollowMouse;
    /*0x50*/ UnityEngine.GameObject plantPreview;
    /*0x58*/ System.Collections.Generic.List<GardenPlant> gardenPlants;
    /*0x60*/ System.Collections.Generic.List<GardenBox> gardenBoxes;
    /*0x68*/ GardenBox currentBox;
    /*0x70*/ UnityEngine.GameObject QuitStore;
    /*0x78*/ int gardenMaxPage;
    /*0x80*/ TMPro.TextMeshProUGUI currentPageText;
    /*0x88*/ TMPro.TextMeshProUGUI currentPageText2;

    /*0x47fe30*/ GardenUI();
    /*0x47f820*/ void OnDestroy();
    /*0x47bfe0*/ void Awake();
    /*0x47f9a0*/ void Start();
    /*0x47cb70*/ void GetBoxes(UnityEngine.GameObject obj);
    /*0x47fe10*/ void Update();
    /*0x47c820*/ void FixedUpdate();
    /*0x47e750*/ void LightPlant();
    /*0x47e410*/ void LeftClickWithSomething();
    /*0x47ce80*/ void GetCurrentBox();
    /*0x47ea20*/ void MouseToolUpdate();
    /*0x47ee40*/ void MouseUpdate();
    /*0x47f310*/ void MovePlant(GardenPlant plant, bool glove);
    /*0x47fbd0*/ void TryMixPlant(GardenPlant plant1, GardenPlant plant2, int theColumn, int theRow);
    /*0x47e1d0*/ void LeftClickWithNothing();
    /*0x47f870*/ void RightClick();
    /*0x47c3c0*/ void EnterStore();
    /*0x47d090*/ PlantType GetStorePlant();
    /*0x47c650*/ void ExitStore();
    /*0x47c200*/ void EnterNextPage();
    /*0x47c040*/ void EnterLastPage();
}

enum GardenType
{
    House = 0,
    Mushroom = 1,
    Water = 2,
}

enum GardenToolType
{
    Default = 0,
    Water = 1,
    Fertilze = 2,
    BugSpray = 3,
    Phonograph = 4,
    Glove = 5,
    MoneySign = 6,
    WheelBarrow = 7,
    Magnifier = 8,
}

class MoneyInGarden : UnityEngine.MonoBehaviour
{
    /*0x20*/ ItemType theCoinType;
    /*0x24*/ int treasureCost;
    /*0x28*/ UnityEngine.Color color;
    /*0x38*/ UnityEngine.SpriteRenderer r;
    /*0x40*/ float moveSpeed;
    /*0x44*/ float timer;
    /*0x48*/ float x;
    /*0x4c*/ float y;
    /*0x50*/ float startY;

    /*0x488920*/ MoneyInGarden();
    /*0x4880b0*/ void Awake();
    /*0x488400*/ void Start();
    /*0x4884c0*/ void Update();
    /*0x488140*/ void PositionUpdate(float distance);
}

class GridManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 spacing;
    /*0x28*/ int theNumberOfColumn;
    /*0x2c*/ bool allowMoving;
    /*0x2d*/ bool freezingX;
    /*0x2e*/ bool freezingY;
    /*0x30*/ float minY;
    /*0x34*/ float maxY;
    /*0x38*/ UnityEngine.Vector2 startPosition;
    /*0x40*/ bool moving;
    /*0x44*/ float offsetY;

    /*0x31c640*/ GridManager();
    /*0x485180*/ void OnDrawGizmos();
    /*0x4856e0*/ void Update();
    /*0x485430*/ void PositionUpdate();
}

class Fertilize : Bucket
{
    /*0x58*/ Plant theTargetPlant;
    /*0x60*/ UnityEngine.Animator anim;
    /*0x68*/ bool isUsing;

    /*0x475a50*/ Fertilize();
    /*0x474c40*/ void Start();
    /*0x474ca0*/ void Update();
    /*0x474be0*/ void Pick();
    /*0x475730*/ void Use();
    /*0x474db0*/ void Upgrade();
}

class GardenPrize : UnityEngine.MonoBehaviour
{
    /*0x20*/ float existTime;

    /*0x31c640*/ GardenPrize();
    /*0x47a9e0*/ void Awake();
    /*0x47aa40*/ void Update();
    /*0x47a750*/ void Active();
}

class GiveFertilize : UnityEngine.MonoBehaviour
{
    /*0x20*/ int occurrences;
    /*0x24*/ UnityEngine.Vector2 pos;

    static /*0x485070*/ bool AvaliableToGive();
    /*0x485160*/ GiveFertilize();
    /*0x484d70*/ void AnimGive();
}

class ItemBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ ItemBtn.Type type;

    /*0x31c640*/ ItemBtn();
    /*0x485940*/ UnityEngine.GameObject Clicked();
    /*0x485ad0*/ void Update();

    enum Type
    {
        Bean = 0,
    }
}

class JigsawPrize : GardenPrize
{
    /*0x31c640*/ JigsawPrize();
    /*0x487b80*/ void Active();
}

class Portal : UnityEngine.MonoBehaviour
{
    /*0x20*/ int thePortalRow;
    /*0x28*/ Portal next;
    /*0x30*/ Portal pre;
    /*0x38*/ UnityEngine.Transform axis;
    /*0x40*/ Towards Towards;

    static /*0x4889c0*/ Portal CreatePortal(int theColumn, int theRow);
    /*0x31c640*/ Portal();
    /*0x488950*/ void Awake();
    /*0x489060*/ void Start();
    /*0x488cb0*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
    /*0x488c50*/ void Die();
}

class JigsawClip : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theColumn;
    /*0x24*/ int theRow;
    /*0x28*/ JigsawType jigsawType;
    /*0x30*/ UnityEngine.SpriteRenderer r;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.Sprite> jigSprites;
    /*0x40*/ TMPro.TextMeshPro description;

    /*0x485fb0*/ JigsawClip();
    /*0x485d90*/ void Awake();
    /*0x485e30*/ void Start();
    /*0x485f40*/ void Update();
}

class JigsawManager : UnityEngine.MonoBehaviour
{
    static int JigLength = 3;
    static /*0x0*/ JigsawManager Instance;
    static /*0x8*/ System.Collections.Generic.Dictionary<JigsawType, System.ValueTuple<UnityEngine.Color, int, string>> JigColor;
    /*0x20*/ JigsawClip jigsawOnMouse;
    /*0x28*/ System.Action endAction;
    /*0x30*/ System.Collections.Generic.List<JigsawClip> jigsawClips;
    /*0x38*/ Board board;
    /*0x40*/ bool showJig;

    static /*0x487760*/ JigsawManager();
    static /*0x486190*/ UnityEngine.Color GetJigColor(JigsawType jigsawType);
    static /*0x4862f0*/ string GetJigName(JigsawType jigsawType);
    static /*0x486250*/ int GetJigIndex(JigsawType jigsawType);
    /*0x487b00*/ JigsawManager();
    /*0x486030*/ void Awake();
    /*0x4870a0*/ void SwitchJigs();
    /*0x486820*/ void GetRandomShape();
    /*0x4868f0*/ void InitCurrentJig();
    /*0x4871d0*/ void Update();
    /*0x486fd0*/ void QuitJigStatus();
    /*0x4860e0*/ UnityEngine.Vector2 GetBoxCenter(int theColumn, int theRow);
    /*0x486620*/ JigsawType GetRandomJigsawType();
    /*0x4863a0*/ JigsawClip GetJigsaw();
}

enum JigsawType
{
    Default = 0,
    Block = 1,
    Damage = 2,
    Health = 3,
    Speed = 4,
    Recover = 5,
    Instead = 6,
    Uncrashable = 7,
}

enum JigsawShape
{
    Shape1 = 0,
    Shape2 = 1,
    Shape3 = 2,
    Shape4 = 3,
    Full = 4,
}

class AudioManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AudioManager instance;
    /*0x20*/ UnityEngine.AudioSource audioSource;

    static /*0x4733c0*/ AudioManager get_Instance();
    /*0x31c640*/ AudioManager();
    /*0x4731c0*/ void Awake();
    /*0x473300*/ void PlaySound(UnityEngine.AudioClip clip, float volume, float pitch);
    /*0x473250*/ System.Collections.IEnumerator PlaySoundCoroutine(UnityEngine.AudioClip clip, float volume, float pitch);

    class <PlaySoundCoroutine>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ AudioManager <>4__this;
        /*0x28*/ UnityEngine.AudioClip clip;
        /*0x30*/ float volume;
        /*0x34*/ float pitch;
        /*0x38*/ UnityEngine.AudioSource <source>5__2;

        /*0x32f460*/ <PlaySoundCoroutine>d__6(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4895c0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4897a0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class BulletPoolManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ BulletPoolManager Instance;
    /*0x20*/ System.Collections.Generic.Dictionary<BulletType, UnityEngine.Pool.ObjectPool<Bullet>> pools;
    /*0x28*/ Board board;

    /*0x4741f0*/ BulletPoolManager();
    /*0x473a50*/ void Awake();
    /*0x473dd0*/ Bullet CreateBullet(BulletType theBulletType);
    /*0x474170*/ void GetBullet(Bullet obj);
    /*0x4741b0*/ void ReleaseBullet(Bullet obj);
    /*0x474100*/ void DestoryBullet(Bullet obj);

    class <>c__DisplayClass3_0
    {
        /*0x10*/ BulletType item;
        /*0x18*/ BulletPoolManager <>4__this;

        /*0x32f970*/ <>c__DisplayClass3_0();
        /*0x4acfc0*/ Bullet <Awake>b__0();
    }
}

class CameraManager
{
    /*0x10*/ UnityEngine.Transform camera;

    /*0x49b490*/ CameraManager(UnityEngine.Transform camera);
    /*0x32d010*/ void Update();
}

class ItemManager
{
    /*0x10*/ System.Collections.Generic.Dictionary<BucketType, UnityEngine.GameObject> bucketPrefabs;

    /*0x49b700*/ ItemManager();
    /*0x49b560*/ Bucket SetBucket(Board board, BucketType theBucketType, UnityEngine.Vector2 position);
    /*0x49b4e0*/ void LoadBuckets();
}

enum BucketType
{
    Bucket = 0,
    Helmet = 1,
    Jackbox = 2,
    Pickaxe = 3,
    Machine = 4,
    SuperMachine = 5,
    Jumper = 6,
    Ladder = 7,
    IronHead = 8,
    RedIronHead = 9,
    Door = 10,
    PortalHeart = 11,
}

class SoundManager
{
    /*0x10*/ System.Collections.Generic.Dictionary<SoundType, UnityEngine.AudioClip> sounds;
    /*0x18*/ System.Collections.Generic.Dictionary<MusicType, UnityEngine.AudioClip> musics;
    /*0x20*/ System.Collections.Generic.Dictionary<MusicType, MusicType> drumPairs;

    /*0x4a6970*/ SoundManager();
    /*0x4a6820*/ void LoadSound();
    /*0x4a67a0*/ void LoadMusic();
    /*0x4a68a0*/ bool TryGetMusicDrum(MusicType theMusicType, ref UnityEngine.AudioClip drumMusicType);
}

enum SoundType
{
}

enum MusicType
{
    MainMenu = 0,
    SelectCard = 1,
    Day = 2,
    Day_drum = 3,
    Night = 4,
    Night_drum = 5,
    Pool = 6,
    Pool_drum = 7,
    Fog = 8,
    Fog_drum = 9,
    Roof = 10,
    Roof_drum = 11,
    Roof_pre = 12,
    Loon = 13,
    UltimateBattle = 14,
    WinMusic = 15,
    IZ = 16,
    Garden = 17,
    Boss = 18,
    Boss2 = 19,
    Snow = 20,
    Snow_drum = 21,
    Snow_boss = 22,
}

class MagnetLine : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.LineRenderer lineRenderer;
    /*0x28*/ int firstColumn;
    /*0x2c*/ int firstRow;
    /*0x30*/ int secondColumn;
    /*0x34*/ int secondRow;

    /*0x31c640*/ MagnetLine();
    /*0x49bfa0*/ void Awake();
    /*0x49bff0*/ void SetLinePositions(int column0, int row0, int column1, int row1);
}

class MagnetLineMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ MagnetLineMgr Instance;
    /*0x20*/ System.Collections.Generic.List<MagnetLine> magnetLines;

    /*0x49bf20*/ MagnetLineMgr();
    /*0x49b7f0*/ void Awake();
    /*0x49b9f0*/ MagnetLine GetLine(int column0, int row0, int column1, int row1);
    /*0x49bec0*/ bool SameLine(MagnetLine magnetLine, int column0, int row0, int column1, int row1);
    /*0x49b850*/ MagnetLine DestoryLine(int column0, int row0, int column1, int row1);
}

class MagnetSystem : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.List<Plant> plants;
    static /*0x8*/ System.Collections.Generic.List<System.Collections.Generic.List<Plant>> systems;
    static /*0x10*/ System.Collections.Generic.Dictionary<Plant, System.Collections.Generic.List<Plant>> adjacencyList;
    static /*0x18*/ System.Collections.Generic.Dictionary<System.ValueTuple<Plant, Plant>, MagnetLine> edgeLines;
    static /*0x20*/ System.Collections.Generic.HashSet<System.ValueTuple<Plant, Plant>> activeEdges;

    static /*0x49daa0*/ MagnetSystem();
    static /*0x49cfb0*/ System.Collections.Generic.List<Plant> GetPlants(Plant plant);
    static /*0x49d4f0*/ void MagnetSystemUpdate();
    static /*0x49c6a0*/ void BuildAdjacencyList();
    static /*0x49d2a0*/ void GroupMushroomsIntoSystems();
    static /*0x49c1d0*/ void BFS(Plant start, System.Collections.Generic.List<Plant> system, System.Collections.Generic.HashSet<Plant> visited);
    static /*0x49cb50*/ void DestroyUnusedLines(System.Collections.Generic.HashSet<Plant> visited);
    /*0x31c640*/ MagnetSystem();
}

enum EntityType
{
    Plant = 0,
    Zombie = 1,
    Bullet = 2,
    Mower = 3,
    GridItem = 4,
}

class RoofEntity : UnityEngine.MonoBehaviour
{
    /*0x20*/ int entityRow;
    /*0x24*/ EntityType entityType;
    /*0x28*/ Plant plant;
    /*0x30*/ Zombie zombie;
    /*0x38*/ Mower mower;
    /*0x40*/ GridItem gridItem;
    /*0x48*/ UnityEngine.GameObject land;

    /*0x31c640*/ RoofEntity();
    /*0x4a1ff0*/ void Awake();
    /*0x4a22c0*/ void Update();
}

class RoofMgr : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ RoofMgr();
    /*0x32d010*/ void Awake();
}

class TravelMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ TravelMgr Instance;
    static /*0x8*/ System.Collections.Generic.Dictionary<PlantType, System.ValueTuple<int, int>> normalUltimatePlant;
    static /*0x10*/ System.Collections.Generic.List<PlantType> allWeakUltimatePlants;
    static /*0x18*/ System.Collections.Generic.List<PlantType> allStrongUltimtePlant;
    static /*0x20*/ System.Collections.Generic.HashSet<PlantType> GoldUltiPlants;
    static /*0x28*/ System.Collections.Generic.HashSet<AdvBuff> CurseBuffs;
    static /*0x30*/ System.Collections.Generic.HashSet<AdvBuff> RogueBuffs;
    static /*0x38*/ System.Collections.Generic.Dictionary<int, string> advancedBuffs;
    static /*0x40*/ System.Collections.Generic.Dictionary<int, string> ultimateBuffs;
    static /*0x48*/ System.Collections.Generic.Dictionary<int, string> unlocks;
    static /*0x50*/ System.Collections.Generic.Dictionary<int, string> debuffs;
    static /*0x58*/ System.Collections.Generic.Dictionary<int, ZombieType> debuffIconPairs;
    /*0x20*/ bool[] unlockPlant;
    /*0x28*/ bool[] advancedUpgrades;
    /*0x30*/ int[] advancedUnlockRound;
    /*0x38*/ int[] ultimateUpgrades;
    /*0x40*/ bool[] debuff;
    /*0x48*/ bool curseMode;
    /*0x50*/ System.Collections.Generic.HashSet<PlantType> ulockTemp;
    /*0x58*/ System.Collections.Generic.List<PlantType> weakUltimates;

    static /*0x4a8fc0*/ TravelMgr();
    static /*0x4a7a40*/ PlantType GetPlantTypeByAdvBuff(int index);
    static /*0x4a8370*/ bool IsCurseBuff(AdvBuff buff);
    static /*0x4a83f0*/ bool IsRogueBuff(AdvBuff buff);
    static /*0x4a7c80*/ int GetStringUltimtePlantIndex(PlantType plantType);
    static /*0x4a80c0*/ string GetUnlockText(int index);
    static /*0x4a8010*/ string GetUltimateText(int index);
    static /*0x4a76b0*/ string GetAdvancedText(int index);
    static /*0x4a7990*/ string GetDebuffText(int index);
    /*0x4ac210*/ TravelMgr();
    /*0x4ac390*/ int get_DebuffCount();
    /*0x4a6d30*/ void Awake();
    /*0x4a8470*/ void Start();
    /*0x4a87d0*/ void UnlockPlantData(int choiceIndex);
    /*0x4a8ab0*/ void UpgradeUltimatePlantData(int index, int level);
    /*0x4a6e10*/ void DebuffData(int index);
    /*0x4a8800*/ void UpgradeAdvancedPlantData(int index);
    /*0x4a7040*/ System.Collections.Generic.List<int> GetAdvancedBuffPool(bool inStore, bool look);
    /*0x4a6da0*/ bool CheckProgressiveProbability(int currentRound);
    /*0x4a7760*/ System.Collections.Generic.HashSet<int> GetAllNormalUltimatePlantBuffID();
    /*0x4a8170*/ System.Collections.Generic.HashSet<int> GetUnlockedNormalUltimatePlantBuffID();
    /*0x4a86d0*/ bool StrongUltiPlantBuffUnlock(PlantType plantType);
    /*0x4a7d00*/ string GetText(int type, int index);

    class <>c
    {
        static /*0x0*/ TravelMgr.<> <>9;
        static /*0x8*/ System.Predicate<Plant> <>9__15_0;

        static /*0x4ad060*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4acc60*/ bool <DebuffData>b__15_0(Plant p);
    }
}

enum BuffType
{
    UnlockPlant = 0,
    AdvancedBuff = 1,
    UltimateBuff = 2,
    Debuff = 3,
}

enum UltiBuffs
{
    凛风刺骨 = 4,
    三尺之寒 = 5,
    众星之力 = 9,
    万籁俱寂 = 10,
    蒜毒骤发 = 13,
    两肋插刀 = 17,
    狂战士 = 21,
    厚积薄发 = 28,
    打折券 = 29,
    万劫不复 = 31,
    爆米花 = 36,
    超载 = 37,
    连锁反应 = 38,
    大容量 = 39,
}

enum AdvBuff
{
    撒豆成兵 = 0,
    精兵强将 = 1,
    枕戈待旦 = 2,
    核能威慑 = 3,
    妙手回春 = 4,
    无关痛痒 = 5,
    尸愁之路 = 6,
    百炼成钢 = 7,
    熠熠生辉 = 8,
    极速战备 = 9,
    强力打击 = 10,
    精准打击 = 11,
    腐化 = 12,
    全副武装 = 13,
    合理投资 = 14,
    怒火攻心 = 15,
    至极手速 = 16,
    势如破竹 = 17,
    冻彻心扉 = 18,
    斗转星移 = 19,
    灯火通明 = 20,
    多多益善 = 21,
    等价交换 = 22,
    人工智能 = 23,
    弹射起步 = 24,
    聚光盆 = 25,
    运斤如风 = 26,
    全息制冷 = 27,
    致命一击 = 28,
    拆分 = 29,
    肉身成圣 = 30,
    百步穿杨 = 31,
    复制中心 = 32,
    连连看 = 33,
    特制弹药 = 34,
    一针见血 = 35,
    真樱 = 36,
    真毁 = 37,
    可控核聚变 = 38,
    人多势众 = 39,
    我是传奇 = 40,
    大富翁 = 41,
    好运连连 = 42,
    过载 = 43,
    排山倒海 = 44,
    星神合一 = 45,
    量子护盾 = 46,
    高能射线 = 47,
    极致之冰 = 48,
    枪枪爆头 = 49,
    开炮 = 50,
    火力全开 = 51,
    电磁涡轮 = 52,
    万磁王 = 53,
    升级 = 54,
    Curse_巨人杀手 = 55,
    Curse_诅咒之力 = 56,
    Curse_诸神黄昏 = 57,
    Curse_荆狂诅咒 = 58,
    Curse_贪婪诅咒 = 59,
    Rogue_后备能源 = 60,
    Rogue_究极樱桃战神专精I = 61,
    Rogue_究极樱桃战神专精II = 62,
    Rogue_究极樱桃射手专精I = 63,
    Rogue_究极樱桃射手专精II = 64,
    Rogue_究极大喷菇专精I = 65,
    Rogue_究极大喷菇专精II = 66,
    Rogue_究极窝炬专精I = 67,
    Rogue_究极窝炬专精II = 68,
    Rogue_推车保护 = 69,
    星月护符 = 70,
    罪恶之力 = 71,
    深度定制 = 72,
}

enum TravelDebuff
{
    究极马超 = 24,
    究极鱼丸 = 25,
    究极将军 = 26,
    究极裂空 = 27,
    究极白车 = 28,
    究极读报 = 29,
    究极丑皇 = 31,
    阿尔法领袖 = 34,
    黑橄榄骑兵统帅 = 37,
}

class CamaraFollowMouse : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CamaraFollowMouse Instance;
    /*0x20*/ float moveSpeed;
    /*0x24*/ UnityEngine.Vector2 minPosition;
    /*0x2c*/ UnityEngine.Vector2 maxPosition;
    /*0x34*/ UnityEngine.Vector3 lastMousePosition;
    /*0x40*/ bool isFollowing;
    /*0x48*/ UnityEngine.Camera Camera;

    /*0x49b460*/ CamaraFollowMouse();
    /*0x49ae10*/ void Awake();
    /*0x49af80*/ void Update();
    /*0x49acc0*/ void AdjustCameraPosition();
    /*0x49ae80*/ void ResetCamera();
}

class Mouse : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Mouse Instance;
    /*0x20*/ UnityEngine.Renderer r;
    /*0x28*/ int theMouseRow;
    /*0x2c*/ int theMouseColumn;
    /*0x30*/ float theBoxXofMouse;
    /*0x34*/ float theBoxYofMouse;
    /*0x38*/ PlantType thePlantTypeOnMouse;
    /*0x3c*/ Towards plantTowards;
    /*0x40*/ ZombieType theZombieTypeOnMouse;
    /*0x48*/ UnityEngine.GameObject preview;
    /*0x50*/ UnityEngine.GameObject theItemOnMouse;
    /*0x58*/ CardUI theCardOnMouse;
    /*0x60*/ MouseItemType mouseItemType;
    /*0x68*/ IZECard theIZECardOnMouse;
    /*0x70*/ Plant thePlantOnGlove;
    /*0x78*/ Zombie theZombieOnGlove;
    /*0x80*/ GardenPlant theGardenPlantOnGlove;
    /*0x88*/ Plant cannonPlant;
    /*0x90*/ Plant plantSelected;
    /*0x98*/ UnityEngine.Vector2 lastClickPosition;
    /*0xa0*/ float mouseX;
    /*0xa4*/ float mouseY;
    /*0xa8*/ Board board;

    /*0x49abb0*/ Mouse();
    /*0x4899b0*/ void Awake();
    /*0x4962b0*/ void Start();
    /*0x49a480*/ void Update();
    /*0x498390*/ void TryToSetPlantByCard();
    /*0x48cab0*/ float GetLandY(float x, int theRow);
    /*0x48ca20*/ int GetColumnFromX(float x);
    /*0x48d1f0*/ int GetRowFromY(float x, float y);
    /*0x48c970*/ float GetBoxXFromColumn(int theColumn);
    /*0x48c990*/ float GetBoxYFromRow(int theRow);
    /*0x48b8d0*/ void CreatePlantOnMouse(PlantType theSeedType);
    /*0x48bbe0*/ void CreateZombieOnMouse(ZombieType theZombieType);
    /*0x48c100*/ void DrawItemOnMouse();
    /*0x490a60*/ void PlantPreviewUpdate();
    /*0x491100*/ void PreviewPositionUpdate();
    /*0x497030*/ UnityEngine.GameObject TryRepairPlant();
    /*0x496520*/ UnityEngine.GameObject TryEatSeashroom(int theColumn, int theRow);
    /*0x496300*/ UnityEngine.GameObject TryChomperPlant();
    /*0x497290*/ UnityEngine.GameObject TrySubmarinePlant();
    /*0x496a00*/ UnityEngine.GameObject TryHamburgerPlant(PlantType thePlantType);
    /*0x490750*/ bool MoveZombie(Zombie zombie, float x, int row);
    /*0x499570*/ void TryToSetZombieByCard();
    /*0x498f60*/ void TryToSetPlantByGlove();
    /*0x4926b0*/ void SetPlantLevel(Plant plant);
    /*0x48bd90*/ bool DisassemblePlant(Plant plant);
    /*0x489900*/ void AdditionCard(PlantType type, UnityEngine.Vector2 position, PlantType baseType);
    /*0x4915a0*/ void PutDownItem();
    /*0x4905d0*/ void MouseClick();
    /*0x48fed0*/ void LeftUp();
    /*0x48fe50*/ void LeftEvent();
    /*0x48d620*/ void LeftClickWithNothing();
    /*0x48f3b0*/ void LeftClickWithSomeThing();
    /*0x491910*/ void ReinforcePlant();
    /*0x48c540*/ void FixedUpdate();
    /*0x490290*/ void LightUpPlantUnderMouse();
    /*0x497dd0*/ void TryToRemovePlant();
    /*0x490930*/ void PayBackSun(Plant plant);
    /*0x4923f0*/ void ReturnPlantToGarden(Plant plant);
    /*0x497510*/ void TryToPickPlant();
    /*0x48cb60*/ System.Collections.Generic.List<Plant> GetPlantsOnMouse(UnityEngine.RaycastHit2D[] hits);
    /*0x48d320*/ System.Collections.Generic.List<Zombie> GetZombiesOnMouse(UnityEngine.RaycastHit2D[] hits);
    /*0x496c40*/ void TryHammerZombie();
    /*0x48b650*/ void ClickOnCard(CardUI card);
    /*0x48b7a0*/ void ClickZombieCard(IZECard card);
    /*0x48ac90*/ void ClearItemOnMouse(bool clearItem);
    /*0x48d580*/ bool HammerClick(CardUI card);
    /*0x48ad80*/ bool ClickCard(CardUI card);
    /*0x494c30*/ bool Shooting5(CardUI card);
    /*0x48a350*/ bool BilliardBall2(CardUI card);
    /*0x4945c0*/ void Shooting4(CardUI card);
    /*0x489a10*/ void Bejeweled1(CardUI card);
    /*0x4951e0*/ void Single(CardUI card);
    /*0x492a90*/ void Shooting1(CardUI card);
    /*0x493490*/ void Shooting2(CardUI card);
    /*0x493cb0*/ void Shooting3(CardUI card);
    /*0x499b30*/ Plant[] TurnPlantsToNewPlants(CardUI card, PlantType newType, PlantType nextType);
    /*0x48a840*/ void ChangeCost(PlantType theSeedType, CardUI card);
    /*0x48a5e0*/ void ChangeCardSprite(PlantType theSeedType, CardUI card);
    /*0x491b10*/ void ResurrectionPlant(CardUI card);
    /*0x489850*/ void AddNewCard(PlantType theSeedType);
    /*0x496870*/ void TryExchangePlant(Plant plant1, Plant plant2);

    class <>c
    {
        static /*0x0*/ Mouse.<> <>9;
        static /*0x8*/ System.Func<Zombie, int> <>9__60_0;
        static /*0x10*/ System.Func<Plant, int> <>9__61_0;
        static /*0x18*/ System.Func<Plant, bool> <>9__61_1;
        static /*0x20*/ System.Func<Plant, bool> <>9__61_2;
        static /*0x28*/ System.Func<Plant, bool> <>9__61_3;
        static /*0x30*/ System.Func<Zombie, bool> <>9__62_0;

        static /*0x4ad0d0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4ace00*/ int <TryToPickPlant>b__60_0(Zombie p);
        /*0x4acd00*/ int <GetPlantsOnMouse>b__61_0(Plant p);
        /*0x3ba680*/ bool <GetPlantsOnMouse>b__61_1(Plant p);
        /*0x4acd20*/ bool <GetPlantsOnMouse>b__61_2(Plant p);
        /*0x4acd40*/ bool <GetPlantsOnMouse>b__61_3(Plant p);
        /*0x4acd60*/ bool <GetZombiesOnMouse>b__62_0(Zombie z);
    }
}

class MouseSlide : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 startPosition;
    /*0x28*/ bool moving;
    /*0x2c*/ float offsetY;
    /*0x30*/ bool freezingX;
    /*0x31*/ bool freezingY;
    /*0x34*/ float minY;
    /*0x38*/ float maxY;

    /*0x31c640*/ MouseSlide();
    /*0x49e030*/ void Update();
    /*0x49dcb0*/ void PositionUpdate();
}

class OpenUrl : UnityEngine.MonoBehaviour
{
    /*0x20*/ string url;
    /*0x28*/ string url2;
    /*0x30*/ int type;

    /*0x49e130*/ OpenUrl();
    /*0x49e040*/ void OnMouseUp();
    /*0x49e0c0*/ System.Collections.IEnumerator OpenURLCoroutine();

    class <OpenURLCoroutine>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ OpenUrl <>4__this;

        /*0x32f460*/ <OpenURLCoroutine>d__4(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4ac9a0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4aca50*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class OtherMenu : BaseMenu
{
    /*0x30*/ TMPro.TextMeshProUGUI text1;
    /*0x38*/ TMPro.TextMeshProUGUI text2;

    /*0x32c760*/ OtherMenu();
    /*0x49e1b0*/ void UpdateText(string text);
}

class Player : Entity
{
    /*0x48*/ System.Collections.Generic.List<PlayerWeapon> playerWeapons;
    /*0x50*/ System.Collections.Generic.List<UnityEngine.Transform> weaponTransforms;
    /*0x58*/ UnityEngine.Transform center;
    /*0x60*/ UnityEngine.Transform backShoot;
    /*0x68*/ SpriteSlider healthSlider;
    /*0x70*/ float moveSpeed;
    /*0x74*/ float basicDamage;
    /*0x78*/ float defence;
    /*0x7c*/ int currentHealth;
    /*0x80*/ int maxHealth;
    /*0x84*/ int level;
    /*0x88*/ int refreshCount;
    /*0x8c*/ bool cameraFollow;
    /*0x8d*/ bool moving;
    /*0x90*/ Towards towards;
    /*0x98*/ System.Collections.Generic.Dictionary<PlayerBuff, int> BuffCountDic;
    /*0xa0*/ FlashModule flashModule;
    /*0xa8*/ UnityEngine.Transform mainCamera;
    /*0xb0*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0xb8*/ float timer_summonZombie;
    /*0xbc*/ float timer_invisiable;

    /*0x4a1ba0*/ Player();
    /*0x4a1cf0*/ int get_Row();
    /*0x4a1b00*/ void Upgrade();
    /*0x4a1540*/ bool TryGetWeapon(PlayerWeaponType playerWeaponType, ref PlayerWeapon playerWeapon);
    /*0x4a0570*/ void GiveUpWeapon(PlayerWeaponType playerWeaponType);
    /*0x4a11b0*/ void Start();
    /*0x49f770*/ void FixedUpdate();
    /*0x4a1660*/ void Update();
    /*0x49f170*/ void CheckPresent();
    /*0x4a1270*/ void SummonZombieUpdate();
    /*0x4a0710*/ void MoveUpdate();
    /*0x49f050*/ void CameraUpdate();
    /*0x4a0e80*/ void OnTriggerStay2D(UnityEngine.Collider2D collision);
    /*0x49f890*/ void GetBuff(PlayerBuff playerBuff);
    /*0x49f800*/ int GetBuffCount(PlayerBuff playerBuff);
    /*0x49f760*/ void Die();
    /*0x4a14e0*/ void TakeDamage(float lastDamage);
    /*0x4a1170*/ void Recover(int value);

    class <>c
    {
        static /*0x0*/ Player.<> <>9;
        static /*0x8*/ System.Func<CardUI, bool> <>9__34_0;

        static /*0x4acff0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4acc90*/ bool <GetBuff>b__34_0(CardUI c);
    }

    class <>c__DisplayClass24_0
    {
        /*0x10*/ PlayerWeaponType playerWeaponType;

        /*0x32f970*/ <>c__DisplayClass24_0();
        /*0x3d73d0*/ bool <TryGetWeapon>b__0(PlayerWeapon weapon);
    }

    class <>c__DisplayClass34_0
    {
        /*0x10*/ System.Collections.Generic.List<Plant> plants;

        /*0x32f970*/ <>c__DisplayClass34_0();
        /*0x4ace30*/ void <GetBuff>b__1();
    }
}

class PlayerController : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Rendering.SortingGroup sortingGroup;
    /*0x28*/ UnityEngine.Rigidbody2D rb;
    /*0x30*/ float moveSpeed;

    /*0x49e610*/ PlayerController();
    /*0x49e360*/ void Awake();
    /*0x49e600*/ void Update();
    /*0x49e3e0*/ void InputUpdate();
}

class PlayerWeapon : UnityEngine.MonoBehaviour
{
    /*0x20*/ Player player;
    /*0x28*/ PlayerWeaponType theWeaponType;
    /*0x30*/ UnityEngine.Transform shoot;
    /*0x38*/ float shootTimer;
    /*0x3c*/ float shootInterval;
    /*0x40*/ int magazine;
    /*0x44*/ float loadingTimer;
    /*0x48*/ float loadingInterval;
    /*0x4c*/ int damage;
    /*0x50*/ int maxMagazine;
    /*0x54*/ int shootCount;
    /*0x58*/ int level;
    /*0x5c*/ int evolution;
    /*0x60*/ float loadingSpeed;
    /*0x64*/ float shootSpeed;
    /*0x68*/ float damageAdder;
    /*0x70*/ System.Collections.Generic.Dictionary<PlayerWeaponBuff, int> BuffDic;
    /*0x78*/ float attributeTimer;
    /*0x7c*/ UnityEngine.LayerMask zombieLayer;

    static /*0x49e6c0*/ PlayerWeapon GetWeapon(PlayerWeaponType playerWeaponType, Player player);
    /*0x49ef80*/ PlayerWeapon();
    /*0x49f020*/ int get_AttackDamage();
    /*0x49e620*/ void Awake();
    /*0x49ed50*/ void OnUpdate();
    /*0x49ed10*/ void Load();
    /*0x49ee00*/ void Shoot();
    /*0x388e90*/ BulletType GetBulletType();
    /*0x49ec20*/ void InitData();
}

class Weapon_doom : PlayerWeapon
{
    /*0x4ad300*/ Weapon_doom();
    /*0x4ad280*/ void Shoot();
    /*0x4ad1b0*/ bool CheckZombie(Zombie zombie);
    /*0x4ad210*/ System.Collections.IEnumerator KeepShooting();

    class <KeepShooting>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Weapon_doom <>4__this;
        /*0x28*/ UnityEngine.Vector3 <pos>5__2;
        /*0x34*/ int <restCount>5__3;

        /*0x32f460*/ <KeepShooting>d__2(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4ac3f0*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4ac960*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Weapon_fume : PlayerWeapon
{
    /*0x80*/ float height;
    /*0x88*/ UnityEngine.ParticleSystem particle;
    /*0x90*/ UnityEngine.ParticleSystem fireParticle;

    /*0x4ad300*/ Weapon_fume();
    /*0x4ad5d0*/ void FixedUpdate();
    /*0x4ad310*/ void AttackZombies();
    /*0x4ad660*/ void Shoot();
}

class Weapon_gloom : PlayerWeapon
{
    /*0x4ad300*/ Weapon_gloom();
    /*0x4ad890*/ void Shoot();
}

class Weapon_laser : PlayerWeapon
{
    /*0x80*/ System.Collections.Generic.List<Zombie> targetZombies;
    /*0x88*/ System.Collections.Generic.List<Weapon_laser_light> weapon_Laser_Lights;

    /*0x4b0180*/ Weapon_laser();
    /*0x4af530*/ void OnUpdate();
    /*0x4aff30*/ void UpdateLaser();
    /*0x4af120*/ Weapon_laser_light GetFreeWeapon();
    /*0x4aeee0*/ bool CheckLightTarget(Zombie zombie);
    /*0x4af3f0*/ void OnDestroy();
    /*0x4af050*/ bool CheckZombie(Zombie zombie);
    /*0x4af560*/ void SearchZombie();
    /*0x4aee50*/ bool AddZombie(Zombie zombie);
    /*0x4af960*/ void Shoot();
    /*0x4afe90*/ float <SearchZombie>b__8_0(Zombie z);
}

class Weapon_laser2 : PlayerWeapon
{
    /*0x80*/ UnityEngine.LineRenderer r;
    /*0x88*/ int reflectionCount;
    /*0x8c*/ float reflectionMaxY;
    /*0x90*/ float reflectionMinY;

    /*0x4aee30*/ Weapon_laser2();
    /*0x4adf80*/ void Awake();
    /*0x4ae110*/ void OnUpdate();
    /*0x4aea70*/ void UpdateLaserPath(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
    /*0x4ae3d0*/ void Shoot();
}

class Weapon_laser_light : UnityEngine.MonoBehaviour
{
    /*0x20*/ Weapon_laser weapon_Laser;
    /*0x28*/ Zombie zombie;
    /*0x30*/ UnityEngine.LineRenderer lineRenderer;
    /*0x38*/ UnityEngine.Rendering.SortingGroup sortingGroup;

    /*0x31c640*/ Weapon_laser_light();
    /*0x4b0250*/ void Awake();
    /*0x4b02f0*/ void OnUpdate();
}

class Weapon_pea : PlayerWeapon
{
    /*0x4ad300*/ Weapon_pea();
    /*0x4b0670*/ BulletType GetBulletType();
    /*0x4b0680*/ void Shoot();
}

class Weapon_puff : PlayerWeapon
{
    /*0x4ad300*/ Weapon_puff();
    /*0x4b0b00*/ BulletType GetBulletType();
    /*0x4b0b20*/ void Shoot();
}

class Weapon_star : PlayerWeapon
{
    /*0x4ad300*/ Weapon_star();
    /*0x4b0fc0*/ void InitData();
    /*0x4b10b0*/ void Shoot();
    /*0x4b0fa0*/ BulletType GetBulletType();
}

class Weapon_sword : PlayerWeapon
{
    /*0x80*/ System.Collections.Generic.List<Weapon_sword_item> swords;
    /*0x88*/ float rotationRadius;
    /*0x8c*/ float rotationSpeed;
    /*0x90*/ UnityEngine.GameObject swordPrefab;
    /*0x98*/ System.Collections.Generic.List<BigSword> bigSwords;
    /*0xa0*/ UnityEngine.GameObject bigSwordPrefab;

    /*0x4b2090*/ Weapon_sword();
    /*0x4b15d0*/ void AttackZombie(Zombie zombie);
    /*0x4b1d90*/ void Shoot();
    /*0x4b1390*/ void AttackZombie(UnityEngine.Vector2 position);
    /*0x4b1790*/ void OnUpdate();
    /*0x4b16b0*/ Weapon_sword_item GetSword();
}

class Weapon_sword_item : UnityEngine.MonoBehaviour
{
    /*0x20*/ Weapon_sword weapon_Sword;

    /*0x31c640*/ Weapon_sword_item();
    /*0x4b2170*/ void OnTriggerEnter2D(UnityEngine.Collider2D collision);
}

class Weapon_torch : PlayerWeapon
{
    /*0x4ad300*/ Weapon_torch();
    /*0x4b22f0*/ void Shoot();
    /*0x4b22d0*/ BulletType GetBulletType();
}

class Weapon_wallNut : PlayerWeapon
{
    /*0x4ad300*/ Weapon_wallNut();
    /*0x4b25a0*/ void Shoot();
}

class PreludeMusic : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.AudioSource audioSource;

    /*0x31c640*/ PreludeMusic();
    /*0x4a1d90*/ void Awake();
    /*0x4a1de0*/ void OnActive(MusicType musicType);
    /*0x4a1f80*/ System.Collections.IEnumerator PreludeOver();

    class <PreludeOver>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ PreludeMusic <>4__this;
        /*0x28*/ float <time>5__2;
        /*0x2c*/ float <duringTime>5__3;

        /*0x32f460*/ <PreludeOver>d__3(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4aca90*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4acc20*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class RoguelikeManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theMaxRound;
    /*0x24*/ int theCurrentRound;
    /*0x28*/ SceneType theCurrentSceneType;

    /*0x31c640*/ RoguelikeManager();
}

class SaveInfo : UnityEngine.MonoBehaviour
{
    static /*0x0*/ SaveInfo Instance;
    /*0x20*/ string filePath;

    /*0x31c640*/ SaveInfo();
    /*0x4a2380*/ void Awake();
    /*0x4a27a0*/ void LoadPlayerData();
    /*0x4a3270*/ void SavePlayerData();
    /*0x4a3a50*/ void SaveSurvivalData(SurvivalData data, int level, int id);
    /*0x4a3b80*/ void SaveSurvivalData(int level, bool clear, int id);
    /*0x4a24b0*/ int GetMaxRound(int level, int id);
    /*0x4a2590*/ string GetPath(int level, int id);
    /*0x4a2700*/ SurvivalData GetSurvivalData(int level, int id);
}

class PlatyerSettings
{
    /*0x10*/ bool isSaved;
    /*0x18*/ bool[] advLevelCompleted;
    /*0x20*/ bool[] clgLevelCompleted;
    /*0x28*/ bool[] gameLevelCompleted;
    /*0x30*/ int difficulty;
    /*0x34*/ float gameMusicVolume;
    /*0x38*/ float gameSoundVolume;
    /*0x3c*/ float gameSpeed;
    /*0x40*/ bool[] survivalLevelCompleted;
    /*0x48*/ float cameraSize;
    /*0x4c*/ float canvasMatch;
    /*0x50*/ bool shootingWithoutGlove;
    /*0x51*/ bool levelTutor;
    /*0x52*/ bool disableSolarStarEffect;
    /*0x58*/ System.Collections.Generic.List<int> tutorLevelCompleted;
    /*0x60*/ System.Collections.Generic.List<int> travelLevelCompleted;
    /*0x68*/ System.Collections.Generic.List<int> skinLevelCompleted;
    /*0x70*/ System.Collections.Generic.List<string> nameLevelCompleted;
    /*0x78*/ bool wheatColor;
    /*0x80*/ System.Collections.Generic.List<Achievement> achievements;
    /*0x88*/ int advLevel;
    /*0x8c*/ int advZhouMu;
    /*0x90*/ System.Collections.Generic.List<PlantType> randomPlantInZhouMu;
    /*0x98*/ bool disablePreSelectInAdv;
    /*0x99*/ bool distablexplodeFlash;
    /*0xa0*/ long theMoneyCount;
    /*0xa8*/ bool enableLevelZombie;
    /*0xb0*/ System.Collections.Generic.List<PlantSkinData> plantSkinData;
    /*0xb8*/ System.Collections.Generic.List<PlantType> bannedInPVPScaryPot;
    /*0xc0*/ int newAdvArrivedLevel;
    /*0xc4*/ int playerShootingArrivedLevel;
    /*0xc8*/ int towerLevel;
    /*0xd0*/ System.Collections.Generic.List<AbyssData> abyssDatas;
    /*0xd8*/ System.Collections.Generic.List<AbyssData> abyssBagDatas;
    /*0xe0*/ System.Collections.Generic.List<AbyssPlantLevel> abyssPlantLevels;
    /*0xe8*/ System.Collections.Generic.List<AbyssBuff> sbyssBuffs;
    /*0xf0*/ bool[] buffsSold;
    /*0xf8*/ int abyssLevel;
    /*0xfc*/ int abyssRefreshCount;
    /*0x100*/ int abyssMoney;
    /*0x108*/ TreasureSaveData treasureSaveData;

    /*0x49e210*/ PlatyerSettings();
}

class DictionaryData
{
    /*0x10*/ string key;
    /*0x18*/ int value;

    static /*0x17e030*/ System.Collections.Generic.List<DictionaryData> DicToList<T>(System.Collections.Generic.Dictionary<T, int> dic);
    static /*0x17e030*/ System.Collections.Generic.Dictionary<T, int> ListToDic<T>(System.Collections.Generic.List<DictionaryData> list);
    /*0x32f970*/ DictionaryData();
}

class PlantSkinData
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int skinIndex;

    /*0x32f970*/ PlantSkinData();
}

class AbyssData
{
    /*0x10*/ AbyssBuff theBuffType;
    /*0x14*/ int count;

    /*0x32f970*/ AbyssData();
}

class AbyssPlantLevel
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int level;

    /*0x32f970*/ AbyssPlantLevel();
}

class SurvivalData
{
    /*0x10*/ System.Collections.Generic.List<SavePlantData> plants;
    /*0x18*/ SaveBoardData boardData;
    /*0x20*/ bool[] unlockPlant;
    /*0x28*/ bool[] advancedUpgrades;
    /*0x30*/ int[] ultimateUpgrades;
    /*0x38*/ bool[] debuffs;
    /*0x40*/ bool curseMode;
    /*0x48*/ int[] advancedUnlockRound;
    /*0x50*/ System.Collections.Generic.List<PlantType> unlocked;
    /*0x58*/ System.Collections.Generic.List<PlantType> cardOnBank;
    /*0x60*/ CampType campType;
    /*0x64*/ LeaderType leaderType;
    /*0x68*/ System.Collections.Generic.List<ZombieType> zombie_a;
    /*0x70*/ System.Collections.Generic.List<ZombieType> zombie_b;
    /*0x78*/ System.Collections.Generic.List<ZombieType> zombie_c;
    /*0x80*/ ZombieType bossType;
    /*0x88*/ System.Collections.Generic.List<PlantType> rogueCards;

    /*0x4a6c10*/ SurvivalData();
}

class IZData
{
    /*0x10*/ System.Collections.Generic.List<SavePlantData> plants;
    /*0x18*/ int theSun;
    /*0x20*/ System.Collections.Generic.List<ZombieType> zombietTypes;
    /*0x28*/ int dropSunPerPlant;
    /*0x2c*/ int recommendDifficulty;
    /*0x30*/ int redlineColumn;
    /*0x34*/ SceneType sceneType;
    /*0x38*/ string tips;

    /*0x49b4d0*/ IZData();
}

class SavePlantData
{
    /*0x10*/ int thePlantColumn;
    /*0x14*/ int thePlantRow;
    /*0x18*/ PlantType thePlantType;
    /*0x1c*/ int thePlantHealth;
    /*0x20*/ PlantType theLilyType;
    /*0x24*/ int thePlantStage;
    /*0x28*/ int theAttributeCount;
    /*0x2c*/ int theLevel;
    /*0x30*/ bool imitatless;
    /*0x34*/ Towards towards;
    /*0x38*/ TowerUpgradeType upgradeType;

    /*0x4a6290*/ SavePlantData(Plant plant);
    /*0x4a6170*/ void LoadData(Plant plant);
}

struct JigSawData
{
    /*0x10*/ int theColumn;
    /*0x14*/ int theRow;
    /*0x18*/ JigsawType jigsawType;
}

class SaveBoardData
{
    /*0x10*/ SceneType sceneType;
    /*0x14*/ bool isBoardSaved;
    /*0x18*/ int theBoardSun;
    /*0x1c*/ int theBoardUsedSun;
    /*0x20*/ int theBoardMoney;
    /*0x24*/ float theBoardPoints;
    /*0x28*/ int theCurrentSurvivalRound;
    /*0x2c*/ int theEndlessSurvivalMaxRound;
    /*0x30*/ long startTime;
    /*0x38*/ System.Collections.Generic.List<PlantStatistics> plantStatistics;
    /*0x40*/ System.Collections.Generic.List<JigSawData> jigSawDatas;

    /*0x32f970*/ SaveBoardData();
}

class SaveMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.List<SavePlantData> savePlantData;
    static /*0x8*/ SaveBoardData boardData;

    static /*0x4a60e0*/ SaveMgr();
    static /*0x4a5bf0*/ void SaveBoard(int level, int id);
    static /*0x4a4210*/ void LoadBoard(int level, int id);
    static /*0x4a40d0*/ void ClearBoard(int level);
    static /*0x4a55f0*/ void LoadTravelData(SurvivalData survivalData);
    static /*0x4a5e80*/ void SavePlants();
    static /*0x4a4990*/ void LoadPlant(SurvivalData survivalData);
    static /*0x4a4410*/ void LoadLily(SurvivalData survivalData);
    static /*0x4a5070*/ void LoadPot(SurvivalData survivalData);
    /*0x31c640*/ SaveMgr();

    class <>c
    {
        static /*0x0*/ SaveMgr.<> <>9;
        static /*0x8*/ System.Predicate<SavePlantData> <>9__8_0;
        static /*0x10*/ System.Predicate<SavePlantData> <>9__9_0;

        static /*0x4ad140*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4acdc0*/ bool <LoadLily>b__8_0(SavePlantData p);
        /*0x4acde0*/ bool <LoadPot>b__9_0(SavePlantData p);
    }
}

class ShootingCard : UIButton
{
    /*0x60*/ PlantType thePlantType;

    /*0x317730*/ ShootingCard();
    /*0x4a6780*/ void Start();
    /*0x4a63a0*/ void ChangeSprite();
}

class SoundCtrl : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theSoundID;
    /*0x24*/ float existTime;
    /*0x28*/ UnityEngine.AudioSource audioSource;

    /*0x31c640*/ SoundCtrl();
    /*0x4c62f0*/ void Start();
    /*0x4c6340*/ void Update();
    /*0x4c6230*/ void Die();
}

class ThanksMenu : BaseMenu
{
    /*0x32c760*/ ThanksMenu();
    /*0x4c6540*/ void Update();
}

class SpriteShapeBuilder : UnityEngine.MonoBehaviour
{
    /*0x20*/ int pointCount;
    /*0x28*/ UnityEngine.U2D.SpriteShapeController spriteShape;

    /*0x31c640*/ SpriteShapeBuilder();
    /*0x4c64c0*/ void OnDrawGizmos();
}

class TowerData
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, int> UnlockPlantLevel;
    static /*0x8*/ System.Collections.Generic.Dictionary<PlantType, System.ValueTuple<string, string>> TowerUpgradeDescription;
    static /*0x10*/ System.Collections.Generic.Dictionary<int, string> mapData;
    static /*0x18*/ System.Collections.Generic.Dictionary<TowerBuff, string> TowerBuffDescriptions;

    static /*0x4c8830*/ TowerData();
    static /*0x4c77d0*/ ZombieType GetZombieTypeInRow(int level, int row, ZombieType zombieType);
    static /*0x4c7130*/ int GetRow(int level, int wave, ZombieType zombieType);
    static /*0x4c70c0*/ Towards GetNextTowards(Towards towards, PlantType plantType);
    static /*0x4c7760*/ int GetWave(int level);
    static /*0x4c7580*/ string GetTowerMap(int level);
    static /*0x4c8290*/ void SetBoxData(Board board, int level);
    static /*0x4c7840*/ System.Collections.Generic.List<ZombieType> GetZombieTypes(int level);
    static /*0x4c65b0*/ System.Collections.Generic.List<ZombieType> GetEndlessType(SurvivalLevel level, int round);
    static /*0x4c86e0*/ void SetCamera();
    /*0x32f970*/ TowerData();
}

enum TowerBuff
{
    Damage_1 = 0,
    Damage_2 = 1,
    Damage_3 = 2,
    Speed_1 = 3,
    Speed_2 = 4,
    Speed_3 = 5,
    Startsun_1 = 6,
    Startsun_2 = 7,
    Startsun_3 = 8,
}

class TowerWindowCheck : UnityEngine.MonoBehaviour
{
    /*0x20*/ Advanture_Btn level;
    /*0x28*/ UnityEngine.GameObject prize;

    /*0x31c640*/ TowerWindowCheck();
    /*0x4c9510*/ void Start();
}

class UpgradeArrow : UnityEngine.MonoBehaviour
{
    /*0x20*/ TowerPlant plant;
    /*0x28*/ UnityEngine.SpriteRenderer back;
    /*0x30*/ float timer;

    static /*0x4ca480*/ void SetArrow(TowerPlant plant);
    /*0x31c640*/ UpgradeArrow();
    /*0x4ca700*/ void Update();
    /*0x4ca2c0*/ void Clicked();
    /*0x32bbd0*/ void OnMouseEnter();
    /*0x323040*/ void OnMouseExit();
}

class BaseTree : UnityEngine.MonoBehaviour
{
    /*0x20*/ TreeNode head;

    /*0x31c640*/ BaseTree();
    /*0x4ba7a0*/ void Traverse(System.Action<TreeNode> action);
    /*0x4ba6e0*/ void AddNode(TreeNode parent, TreeNode treeNode);
}

class TreeNode : UnityEngine.MonoBehaviour
{
    /*0x20*/ TreeNode parent;
    /*0x28*/ System.Collections.Generic.List<TreeNode> childs;

    /*0x4c9b40*/ TreeNode();
    /*0x4c9920*/ void Clear();
    /*0x4c95e0*/ void AddNode();
    /*0x4c9ab0*/ TreeNode GetHead();
}

class AbyssBagMenu : BaseMenu
{
    static /*0x0*/ AbyssBagMenu Instance;
    /*0x30*/ UnityEngine.Transform buffIconHead;
    /*0x38*/ UnityEngine.GameObject buffIconPrefab;

    /*0x32c760*/ AbyssBagMenu();
    /*0x4b2800*/ void Awake();
    /*0x4b2870*/ void UpdateIcons();
}

class AbyssBuffButton : UIButton
{
    /*0x60*/ AbyssBuff theBuffType;
    /*0x64*/ int cost;
    /*0x68*/ TMPro.TextMeshProUGUI description;
    /*0x70*/ bool sold;
    /*0x74*/ int index;

    /*0x31c640*/ AbyssBuffButton();
    /*0x4b2ed0*/ void SetType(AbyssBuff theBuffType, bool sold);
    /*0x4b2e70*/ void SetSold();
}

class AbyssCheckInBag : BaseMenu
{
    /*0x30*/ AbyssBuffIcon icon;

    /*0x32c760*/ AbyssCheckInBag();
    /*0x4b3320*/ void SellIcon();
    /*0x4b31d0*/ void MoveFromBag();
}

class AbyssCheckResetMenu : BaseMenu
{
    /*0x32c760*/ AbyssCheckResetMenu();
    /*0x4b3400*/ void Check();
}

class AbyssCheckSellMenu : BaseMenu
{
    /*0x30*/ AbyssBuffIcon icon;

    /*0x32c760*/ AbyssCheckSellMenu();
    /*0x4b3870*/ void SellIcon();
    /*0x4b3750*/ void MoveInBag();
}

class AbyssDevelopCard : UnityEngine.MonoBehaviour
{
    /*0x20*/ PlantType thePlantType;
    /*0x28*/ UnityEngine.UI.Image plantIcon;
    /*0x30*/ UnityEngine.RectTransform rect;
    /*0x38*/ UnityEngine.UI.Image bank;
    /*0x40*/ AbyssDevelopMenu menu;

    /*0x31c640*/ AbyssDevelopCard();
    /*0x4b3d40*/ void Start();
    /*0x4b3a30*/ void OnMouseEnter();
    /*0x4b3ae0*/ void OnMouseExit();
    /*0x4b3990*/ void OnMouseDown();
    /*0x4b3b60*/ void SetImage();
}

class AbyssDevelopMenu : BaseMenu
{
    /*0x30*/ UnityEngine.Transform pageHead;
    /*0x38*/ UnityEngine.GameObject cardPrefab;
    /*0x40*/ PlantType selectedType;
    /*0x48*/ AbyssDevelopCard showPlant;
    /*0x50*/ TMPro.TextMeshProUGUI upgradeTextInfo;
    /*0x58*/ TMPro.TextMeshProUGUI currentMoney;

    /*0x32c760*/ AbyssDevelopMenu();
    /*0x4b3d50*/ void Awake();
    /*0x4b45d0*/ void UpdateInfo();
    /*0x4b4990*/ void UpgradePlant();
    /*0x4b4440*/ bool TryGetUpgradeCost(PlantType thePlantType, ref int cost, ref int currentLevel, ref int arrivedLevel);
    /*0x4b4400*/ void SetType(PlantType thePlantType);
    /*0x4b3e20*/ void InitCards();
    /*0x4b4200*/ void LastPage();
    /*0x4b4300*/ void NextPage();
}

class AbyssGoods : UIButton
{
    /*0x60*/ string goodsName;
    /*0x68*/ TMPro.TextMeshProUGUI costText;
    /*0x70*/ TMPro.TextMeshProUGUI costText_shadow;
    /*0x78*/ TMPro.TextMeshProUGUI hasText;
    /*0x80*/ TMPro.TextMeshProUGUI hasText_shadow;
    /*0x88*/ int cost;
    /*0x8c*/ bool has;

    /*0x31c640*/ AbyssGoods();
    /*0x4b4f70*/ void Start();
    /*0x4b4bb0*/ void OnMouseUpAsButton();
}

class AbyssLevelEnter : UIButton
{
    /*0x60*/ AbyssMenu abyssMenu;
    /*0x68*/ TMPro.TextMeshProUGUI levelName;
    /*0x70*/ int level;
    /*0x74*/ bool available;
    /*0x78*/ UnityEngine.UI.Image background;
    /*0x80*/ UnityEngine.GameObject arrow;

    /*0x31c640*/ AbyssLevelEnter();
    /*0x4b52b0*/ void SetLevel(int level, AbyssMenu abyssMenu);
}

class AbyssMenu : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<AbyssLevelEnter> entrances;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> levelInfo;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.Sprite> backgroundSprites;
    /*0x48*/ UnityEngine.UI.Image backgroundImage;
    /*0x50*/ int currentSelectLevel;
    /*0x58*/ System.Collections.Generic.Dictionary<SceneType, int> BgDic;

    /*0x4b7d20*/ AbyssMenu();
    /*0x4b6dd0*/ void Awake();
    /*0x4b71c0*/ void ResetProgress();
    /*0x4b7340*/ void SetLevel(int level);
    /*0x4b76a0*/ void UpdateLevelInfo(int level);
    /*0x4b6e70*/ void EnterMenu(string name);
    /*0x4b7240*/ void SelectLevel(AbyssLevelEnter enter);
    /*0x4b70e0*/ void MoveNext();
    /*0x4b7150*/ void MovePre();
    /*0x4b7030*/ int GetMaxLevel();
    /*0x4b7090*/ int GetMinLevel();
    /*0x4b6e60*/ void BackToMainMenu();
}

class AbyssMenu2 : BaseMenu
{
    static /*0x0*/ AbyssMenu2 Instance;
    /*0x30*/ int level;
    /*0x38*/ System.Collections.Generic.List<AbyssBuffButton> buffButtons;
    /*0x40*/ TMPro.TextMeshProUGUI refreshText;
    /*0x48*/ TMPro.TextMeshProUGUI money;
    /*0x50*/ TMPro.TextMeshProUGUI statistics;
    /*0x58*/ TMPro.TextMeshProUGUI buffCountText;
    /*0x60*/ UnityEngine.Transform buffIconHead;
    /*0x68*/ UnityEngine.GameObject buffIconPrefab;
    /*0x70*/ AbyssManager abyssManager;

    /*0x4b6d50*/ AbyssMenu2();
    /*0x4b54e0*/ void Awake();
    /*0x4b5930*/ void Start();
    /*0x4b6690*/ void UpdateIcons();
    /*0x4b5540*/ void BuyBuff(AbyssBuffButton abyssBuffButton);
    /*0x4b5d70*/ void UpdateBuff(bool cost);
    /*0x4b5c80*/ void UniqueCheck(ref System.Collections.Generic.List<AbyssBuff> abyssBuffs, AbyssBuff buffType);
    /*0x4b5740*/ void EnterGame();
    /*0x4b58b0*/ void ShowHelp();
    /*0x4b5830*/ void ShowBag();
}

class AbyssSelectDifficultyMenu : BaseMenu
{
    /*0x30*/ int level;

    /*0x32c760*/ AbyssSelectDifficultyMenu();
    /*0x4b80a0*/ void SelectNormal();
    /*0x4b8010*/ void SelectHard();
    /*0x4b7f80*/ void SelectExtreme();
}

class AbyssSettlementMenu : BaseMenu
{
    /*0x30*/ TMPro.TextMeshProUGUI settleInfo;

    /*0x32c760*/ AbyssSettlementMenu();
    /*0x4b8130*/ void InitSettle(SettlementData settlementData);
    /*0x4b8120*/ void Confirm();
}

class AbyssStoreMenu : BaseMenu
{
    /*0x30*/ TMPro.TextMeshProUGUI yourMoney;

    /*0x32c760*/ AbyssStoreMenu();
    /*0x4b8930*/ void Update();
}

class InputButton : UIButton
{
    /*0x60*/ UnityEngine.KeyCode keyCode;

    /*0x31c640*/ InputButton();
    /*0x4c17b0*/ void OnMouseDown();
    /*0x4c1a00*/ void OnMouseUp();
    /*0x4c1960*/ void OnMouseUpAsButton();
}

class UIButton : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Events.UnityEvent clickEvent;
    /*0x28*/ UnityEngine.Sprite highLightSprite;
    /*0x30*/ UnityEngine.UI.Image image;
    /*0x38*/ ButtonSoundType buttonSoundType;
    /*0x40*/ UnityEngine.RectTransform rectTransform;
    /*0x48*/ UnityEngine.Sprite originSprite;
    /*0x50*/ UnityEngine.Vector3 originPosition;

    /*0x31c640*/ UIButton();
    /*0x4ca150*/ void Start();
    /*0x4ca060*/ void OnMouseEnter();
    /*0x4ca090*/ void OnMouseExit();
    /*0x4ca110*/ void OnMouseUp();
    /*0x4c9f60*/ void OnMouseDown();
    /*0x4ca0c0*/ void OnMouseUpAsButton();
}

class AdvantureLevelText : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool big;
    /*0x28*/ TMPro.TextMeshProUGUI textMesh;

    /*0x31c640*/ AdvantureLevelText();
    /*0x4b89d0*/ void Start();
}

class AdvantureMgr : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ AdvantureMgr();
}

class Advanture_Btn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ LevelType levelType;
    /*0x2c*/ int buttonNumber;
    /*0x30*/ UnityEngine.GameObject thisMenu;
    /*0x38*/ ClgLevelMgr levelCtrl;
    /*0x40*/ UnityEngine.Sprite originSprite;
    /*0x48*/ UnityEngine.UI.Image image;
    /*0x50*/ UnityEngine.Vector3 originPosition;
    /*0x60*/ UnityEngine.RectTransform rectTransform;
    /*0x68*/ bool limInMobile;
    /*0x69*/ bool randomLevel;

    /*0x31c640*/ Advanture_Btn();
    /*0x4b91e0*/ void Start();
    /*0x4b8b00*/ void CheckTropy();
    /*0x4b8f00*/ void OnMouseEnter();
    /*0x4b8f30*/ void OnMouseExit();
    /*0x4b8e60*/ void OnMouseDown();
    /*0x4b8f90*/ void OnMouseUp();
}

class Almanac : BaseMenu
{
    /*0x30*/ UnityEngine.Transform plantAxis;
    /*0x38*/ UnityEngine.Transform zombieAxis;
    /*0x40*/ UnityEngine.GameObject plant;
    /*0x48*/ UnityEngine.GameObject zombie;

    /*0x32c760*/ Almanac();
    /*0x4b9f50*/ void Start();
    /*0x4b9cd0*/ void Init();
    /*0x4b9f10*/ void OnHide();
    /*0x4b9ed0*/ void OnBackEnter();
}

class AlmanacBtn : NormalBtn
{
    /*0x31c640*/ AlmanacBtn();
    /*0x4b9340*/ void OnMouseUpAsButton();
}

class AlmanacMenu : BaseMenu
{
    static /*0x0*/ AlmanacMenu Instance;
    /*0x30*/ AlmanacPlantCtrl currentShowCtrl;
    /*0x38*/ UnityEngine.GameObject plants;
    /*0x40*/ UnityEngine.GameObject plants2;
    /*0x48*/ UnityEngine.GameObject zombies;
    /*0x50*/ UnityEngine.GameObject help;
    /*0x58*/ UnityEngine.GameObject plantGroups;
    /*0x60*/ UnityEngine.GameObject currentShowObject;
    /*0x68*/ System.Collections.Generic.List<UnityEngine.Collider2D> cols;

    /*0x4b9c50*/ AlmanacMenu();
    /*0x4b93e0*/ void Awake();
    /*0x4b9440*/ void BackToIndex();
    /*0x4b9900*/ void LookPlant();
    /*0x4b9740*/ void LookPlant2();
    /*0x4b9ac0*/ void LookZombie();
    /*0x4b95b0*/ void LookHelp();
    /*0x32d010*/ void CloseCurrentPage();
}

class AlmanacPlantMenu : BaseMenu
{
    /*0x32c760*/ AlmanacPlantMenu();
}

class BaseMenu : UnityEngine.MonoBehaviour
{
    /*0x20*/ System.Collections.Generic.List<UnityEngine.Collider2D> collider2Ds;
    /*0x28*/ bool _interactable;

    /*0x4ba400*/ BaseMenu();
    /*0x4ba480*/ bool get_Interactable();
    /*0x4ba490*/ void set_Interactable(bool value);
    /*0x4b9fd0*/ void Awake();
    /*0x4b9fe0*/ void GetCol();
    /*0x32d010*/ void OnExit();
    /*0x32d010*/ void OnBackEnter();
    /*0x32d010*/ void OnHide();
    /*0x4ba240*/ void PopMenu();
    /*0x4ba1d0*/ void PopAllMenu();
    /*0x4ba2b0*/ void PushMenuUp(string name);
}

class AdvantureMenu : BaseMenu
{
    /*0x32c760*/ AdvantureMenu();
}

class IZBottomMenu : BaseMenu
{
    static /*0x0*/ IZBottomMenu Instance;
    /*0x30*/ UnityEngine.GameObject zombieLibary;
    /*0x38*/ UnityEngine.GameObject plantLibrary;
    /*0x40*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> levelName;

    /*0x32c760*/ IZBottomMenu();
    /*0x4c08b0*/ void Awake();
    /*0x4c1480*/ void Update();
    /*0x4c13c0*/ void SetSun(TMPro.TMP_InputField field);
    /*0x4c0cd0*/ void SetDropSun(TMPro.TMP_InputField field);
    /*0x4c0a40*/ void PauseGame();
    /*0x4c0b00*/ void SelectAll();
    /*0x4c0dc0*/ void SetLevelName();
    /*0x4c0920*/ void ChangeString(string name);
}

class RogueCrisisMenu : BaseMenu
{
    /*0x30*/ UnityEngine.Transform zombieHead;
    /*0x38*/ int level;
    /*0x3c*/ bool refreshable;

    /*0x4c4240*/ RogueCrisisMenu();
    /*0x4c4230*/ void Start();
    /*0x4c3c10*/ void Refresh();
    /*0x4c3d20*/ void ShowCrisis();
}

class RogueSelectMenu : BaseMenu
{
    /*0x30*/ System.Collections.Generic.List<RogueSelectCard> selectedWeakUltis;
    /*0x38*/ System.Collections.Generic.List<RogueSelectCard> selectedStrongUltis;
    /*0x40*/ bool randomStrongUlti;
    /*0x48*/ UnityEngine.Transform weakHead;
    /*0x50*/ UnityEngine.Transform strongHead;
    /*0x58*/ UnityEngine.GameObject cardPrefab;

    /*0x4c5120*/ RogueSelectMenu();
    /*0x4c4250*/ void Awake();
    /*0x4c4cb0*/ void ShowCards();
    /*0x4c49f0*/ void SelectPlant(RogueSelectCard card);
    /*0x4c4270*/ void Confirm();

    class <>c
    {
        static /*0x0*/ RogueSelectMenu.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__9_0;

        static /*0x4c9e80*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4c9bc0*/ bool <Confirm>b__9_0(PlantType p);
    }
}

class RogueStartMenu : BaseMenu
{
    static /*0x0*/ System.Collections.Generic.Dictionary<LeaderType, string> LeaderDescriptionDic;
    static /*0x8*/ System.Collections.Generic.Dictionary<LeaderType, string> LeaderNameDic;
    /*0x30*/ RogueLeaderCard currentSelected;
    /*0x38*/ TMPro.TextMeshProUGUI leaderDescription;

    static /*0x4c5cd0*/ RogueStartMenu();
    /*0x32c760*/ RogueStartMenu();
    /*0x4c51d0*/ void EnterGame();
    /*0x4c5b10*/ void SetLeader(RogueLeaderCard card);
}

class ShootingLevelMenu : BaseMenu
{
    /*0x30*/ UnityEngine.Transform cardsHead;

    /*0x32c760*/ ShootingLevelMenu();
    /*0x4c6090*/ void Start();
    /*0x4c6090*/ void InitPlants();
}

class BaseWindow : UIButton
{
    /*0x60*/ UnityEngine.Transform axis;
    /*0x68*/ TMPro.TextMeshProUGUI introduce;
    /*0x70*/ UnityEngine.GameObject show;
    /*0x78*/ UnityEngine.Animator anim;

    /*0x31c640*/ BaseWindow();
    /*0x4ba9a0*/ void Awake();
    /*0x32d010*/ void OnAnimOver();
    /*0x4baa90*/ void SetDescription(string text);
    /*0x4ba9f0*/ UnityEngine.GameObject ResetPlant(PlantType thePlantType);
    /*0x4baac0*/ UnityEngine.GameObject SetPlant(PlantType thePlantType);
    /*0x4bacb0*/ void SetZombie(ZombieType theZombieType, float scale);
}

class BigGardenUI : BaseMenu
{
    /*0x30*/ Garden garden;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.Transform> seeds;
    /*0x40*/ TMPro.TextMeshProUGUI moneyText;
    /*0x48*/ UnityEngine.GameObject inputs;

    /*0x4bb1f0*/ BigGardenUI();
    /*0x4b9fd0*/ void Awake();
    /*0x4bb0d0*/ void Update();
    /*0x4baee0*/ void QuitGarden();
}

class BackToIndex : UIBtn
{
    /*0x60*/ UnityEngine.GameObject firstBtns;

    /*0x317730*/ BackToIndex();
    /*0x4b9f60*/ void OnMouseUpAsButton();
}

class ClgLevelMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ int currentPage;

    /*0x31c640*/ ClgLevelMgr();
    /*0x4bb340*/ void ChangePage(int page);
}

class FirstBtns : UIBtn
{
    /*0x60*/ UnityEngine.GameObject pageToOpen;
    /*0x68*/ UnityEngine.GameObject firstBtns;

    /*0x317730*/ FirstBtns();
    /*0x4bf0e0*/ void OnMouseUpAsButton();
}

class PageBtn : UIBtn
{
    /*0x60*/ bool next;
    /*0x64*/ int maxPage;
    /*0x68*/ ClgLevelMgr clgLevel;

    /*0x4c3c00*/ PageBtn();
    /*0x4c3ba0*/ void OnMouseUpAsButton();
}

class CheckNewAdv : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ CheckNewAdv();
    /*0x4bb270*/ void Start();
}

class CrisisZombieWindow : BaseWindow
{
    static /*0x0*/ System.Collections.Generic.Dictionary<ZombieType, string> ZombieDescriptions;
    /*0x80*/ ZombieType zombieType;

    static /*0x4bb810*/ CrisisZombieWindow();
    /*0x31c640*/ CrisisZombieWindow();
    /*0x4bb6c0*/ void Start();
    /*0x4bb590*/ void SetZombieType(ZombieType zombieType, int round);
}

class DarkManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ bool isEnter;
    /*0x28*/ UnityEngine.SpriteRenderer r;
    /*0x30*/ UnityEngine.Color color;
    /*0x40*/ float existTime;

    /*0x4bbf80*/ DarkManager();
    /*0x4bbe30*/ void Start();
    /*0x4bbea0*/ void Update();
}

class EndlessMgr : UnityEngine.MonoBehaviour
{
    /*0x20*/ int theLevel;

    /*0x31c640*/ EndlessMgr();
    /*0x4bbfa0*/ void Awake();
}

class ExploreEnterWindow : UIButton
{
    /*0x60*/ bool basicPlant;
    /*0x64*/ int selfType;
    /*0x68*/ PlantType targetType;
    /*0x6c*/ bool disabled;
    /*0x70*/ PlantType mix1;
    /*0x74*/ PlantType mix2;
    /*0x78*/ UnityEngine.Transform sceneHead;
    /*0x80*/ UnityEngine.UI.Image plantIcon;
    /*0x88*/ UnityEngine.GameObject trophy;
    /*0x90*/ TMPro.TextMeshProUGUI nameText;

    /*0x31c640*/ ExploreEnterWindow();
    /*0x4bc110*/ void Awake();
    /*0x4bc760*/ void Start();
    /*0x4bc1a0*/ void SetDisable(bool disabled);
    /*0x4bc620*/ void SetInfo(PlantType thePlantType);
    /*0x4bc330*/ void SetIcon(PlantType thePlantType);
    /*0x4bc120*/ SceneType GetPlantScene(PlantType thePlantType);
}

class ExploreMenu : BaseMenu
{
    /*0x30*/ UnityEngine.Transform upperHead;
    /*0x38*/ UnityEngine.Transform lowerHead;
    /*0x40*/ ExploreEnterWindow sampleWindow;
    /*0x48*/ System.Collections.Generic.List<ExploreEnterWindow> upperWindows;
    /*0x50*/ System.Collections.Generic.List<ExploreEnterWindow> lowerWindows;
    /*0x58*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> titleText;
    /*0x60*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> trophyText;
    /*0x68*/ UnityEngine.UI.Image background;
    /*0x70*/ SceneType UpperScene;
    /*0x74*/ SceneType LowerScene;
    /*0x78*/ System.Collections.Generic.List<SceneType> SceneSwithSequence;
    /*0x80*/ System.Collections.Generic.Dictionary<SceneType, System.Collections.Generic.List<PlantType>> PlantsInScene;

    /*0x4be180*/ ExploreMenu();
    /*0x4bc790*/ void Awake();
    /*0x4bcfb0*/ void EnterRandomLevel();
    /*0x4bd8c0*/ void UpdateScene();
    /*0x4bdb70*/ void UpdateWindows();
    /*0x4bd3a0*/ void ResetWindows();
    /*0x4bcb60*/ void ClickWindow(ExploreEnterWindow window);
    /*0x4bd7b0*/ bool TryGetMixedType(int a, int b, ref PlantType targetType);
    /*0x4bd8e0*/ void UpdateTitleText();
    /*0x4bd570*/ void SwitchUpperScene();
    /*0x4bd690*/ void SwithLowerScene();
    /*0x4bd2a0*/ UnityEngine.Texture2D GetTexture(SceneType sceneType);
}

class FruitNinjaSelectWindow : BaseWindow
{
    /*0x80*/ FruitBuffType buffType;
    /*0x84*/ bool set;

    /*0x31c640*/ FruitNinjaSelectWindow();
    /*0x4bf150*/ void SetType(FruitBuffType fruitBuffType);
    /*0x4bf130*/ void OnAnimOver();
}

class GardenBagMenu : BaseMenu
{
    /*0x30*/ Garden garden;
    /*0x38*/ UnityEngine.GameObject sampleGrid;
    /*0x40*/ UnityEngine.Transform pageHead;
    /*0x48*/ int cardsInPage;

    /*0x4bfe10*/ GardenBagMenu();
    /*0x4bf2e0*/ void Awake();
    /*0x4bfdd0*/ void Update();
    /*0x4bfdc0*/ void Start();
    /*0x4bf450*/ void SetTreasureCards();
    /*0x4bf340*/ GardenCard SetTreasureCard(TreasureCardData data, UnityEngine.Transform parent);

    class <>c
    {
        static /*0x0*/ GardenBagMenu.<> <>9;
        static /*0x8*/ System.Predicate<TreasureCardData> <>9__7_0;
        static /*0x10*/ System.Func<TreasureCardData, bool> <>9__7_1;
        static /*0x18*/ System.Func<TreasureCardData, CardLevel> <>9__7_2;
        static /*0x20*/ System.Func<TreasureCardData, PlantType> <>9__7_3;
        static /*0x28*/ System.Func<TreasureCardData, int> <>9__7_4;

        static /*0x4c9ef0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4c9c50*/ bool <SetTreasureCards>b__7_0(TreasureCardData c);
        /*0x4c9c70*/ bool <SetTreasureCards>b__7_1(TreasureCardData p);
        /*0x4c9c90*/ CardLevel <SetTreasureCards>b__7_2(TreasureCardData p);
        /*0x4c9cf0*/ PlantType <SetTreasureCards>b__7_3(TreasureCardData p);
        /*0x4c9d10*/ int <SetTreasureCards>b__7_4(TreasureCardData p);
    }
}

class GardenPlantInfoMenu : BaseMenu
{
    /*0x30*/ PlantInfoWindow window;
    /*0x38*/ UnityEngine.GameObject upgradeButton;
    /*0x40*/ UnityEngine.GameObject sellButton;
    /*0x48*/ UnityEngine.GameObject plantButton;
    /*0x50*/ UnityEngine.GameObject plantButton2;

    /*0x32c760*/ GardenPlantInfoMenu();
    /*0x4c0010*/ void MoveToZenGarden();
    /*0x4c0480*/ void Upgrade();
    /*0x4c0250*/ void Sell();
    /*0x4bfe20*/ void MovePlantToWareHouse();
    /*0x4bfdd0*/ void Update();

    class <>c__DisplayClass6_0
    {
        /*0x10*/ GardenEquipment equip;
        /*0x18*/ GardenPlantInfoMenu <>4__this;
        /*0x20*/ int cost;

        /*0x32f970*/ <>c__DisplayClass6_0();
        /*0x4c9d30*/ void <Upgrade>b__0();
    }
}

class GardenUIMenu : BaseMenu
{
    /*0x32c760*/ GardenUIMenu();
    /*0x4c07a0*/ void EnterGardenWorld();
}

class GardenWorldUI : BaseMenu
{
    /*0x32c760*/ GardenWorldUI();
    /*0x4c08a0*/ void BackToGarden();
}

class NormalBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ ButtonSoundType buttonSoundType;
    /*0x30*/ UnityEngine.Sprite originSprite;
    /*0x38*/ UnityEngine.Vector3 originPosition;
    /*0x48*/ UnityEngine.SpriteRenderer spriteRenderer;
    /*0x50*/ UnityEngine.Events.UnityEvent clickEvent;

    /*0x31c640*/ NormalBtn();
    /*0x4c1c90*/ void Start();
    /*0x4c1b90*/ void OnMouseEnter();
    /*0x4c1bc0*/ void OnMouseExit();
    /*0x4c1ab0*/ void OnMouseDown();
    /*0x4c1c20*/ void OnMouseUpAsButton();
}

class OptionBtn : UIBtn
{
    /*0x60*/ int optionType;
    /*0x64*/ bool realReset;
    /*0x68*/ float resetTime;

    /*0x317730*/ OptionBtn();
    /*0x4c2180*/ void Awake();
    /*0x4c29a0*/ void OnMouseUpAsButton();
    /*0x4c32a0*/ void PassAdvantureLevel();
    /*0x4c3420*/ void PassAllLevel();
    /*0x4c3770*/ void ResetAllLevel();
    /*0x4c1d30*/ void AdjustCameraSize();
    /*0x4c1f00*/ void AdjustCanvasSize();
    /*0x4c3b00*/ void Update();
}

class Page : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ Page();
    /*0x4cd4f0*/ void ChangePage();
    /*0x4cd880*/ void NextPage();
    /*0x4cd740*/ void LastPage();
}

class PlantInfoWindow : BaseWindow
{
    /*0x80*/ BigGardenPlant plant;
    /*0x88*/ GardenEquipment equipment;

    /*0x317730*/ PlantInfoWindow();
    /*0x4cdf40*/ void Start();
    /*0x4cd9b0*/ void InitText();
    /*0x4cdd90*/ void OnAnimOver();
}

class PlayerName : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshProUGUI textMesh;

    /*0x31c640*/ PlayerName();
    /*0x4cdf60*/ void Update();
}

class PlayerShootingWindow : BaseWindow
{
    /*0x80*/ PlayerWeaponBuff buffType;
    /*0x84*/ PlayerWeaponType weaponType;
    /*0x88*/ bool set;
    /*0x8c*/ PlantType plantType;

    /*0x317730*/ PlayerShootingWindow();
    /*0x4ce090*/ void SetType(PlayerWeaponBuff buffType);
    /*0x4cdfe0*/ void OnAnimOver();

    class <>c__DisplayClass4_0
    {
        /*0x10*/ PlayerWeaponType _result;

        /*0x32f970*/ <>c__DisplayClass4_0();
        /*0x3d73d0*/ bool <SetType>b__0(PlayerWeapon w);
    }
}

class PVPPotBtn : NormalBtn
{
    /*0x58*/ int id;
    /*0x60*/ UnityEngine.GameObject text1;
    /*0x68*/ UnityEngine.GameObject text2;
    /*0x70*/ UnityEngine.Collider2D col;

    /*0x317730*/ PVPPotBtn();
    /*0x4ccc60*/ void Awake();
    /*0x4cd410*/ void Update();
    /*0x4cccb0*/ void OnMouseUpAsButton();
}

class RectTransformMgr : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ RectTransformMgr();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class RogueCardWindow : BaseWindow
{
    /*0x80*/ System.Collections.Generic.Dictionary<PlantType, int> plants;

    /*0x4d49a0*/ RogueCardWindow();
    /*0x4d45c0*/ void InitCard(PlantType thePlantType);
    /*0x4d46f0*/ void OnAnimOver();
}

class SaveMenu : BaseMenu
{
    static /*0x0*/ SaveMenu Instance;
    /*0x30*/ System.Collections.Generic.List<SaveMenuBtn> levels;
    /*0x38*/ bool inGame;
    /*0x40*/ TMPro.TextMeshProUGUI title;
    /*0x48*/ TMPro.TextMeshProUGUI title_shadow;
    /*0x50*/ System.Collections.Generic.List<UnityEngine.GameObject> close;
    /*0x58*/ SurvivalLevel theLevel;

    static /*0x4d5140*/ void InitSaveMenu(SurvivalLevel level);
    /*0x4d53c0*/ SaveMenu();
    /*0x4d4e50*/ void Awake();
    /*0x4d5220*/ void Start();
    /*0x4d4eb0*/ void InitLevels();
}

class SaveMenuBtn : UIBtn
{
    /*0x60*/ TMPro.TextMeshProUGUI theName;
    /*0x68*/ int id;
    /*0x6c*/ int buttonNumber;

    /*0x4d4e40*/ SaveMenuBtn();
    /*0x4d4a20*/ void OnMouseUpAsButton();
}

class SeedLibrary : UnityEngine.MonoBehaviour
{
    static int cardsInPage = 54;
    static /*0x0*/ SeedLibrary Instance;
    /*0x20*/ UnityEngine.Transform normalPageHead;
    /*0x28*/ UnityEngine.Transform colorfulPageHead;
    /*0x30*/ UnityEngine.Transform roguePageHead;
    /*0x38*/ UnityEngine.Transform towerPageHead;
    /*0x40*/ UnityEngine.Transform treasurePageHead;
    /*0x48*/ Board board;
    /*0x50*/ UnityEngine.GameObject sampleGrid;
    /*0x58*/ UnityEngine.GameObject safeBox;
    /*0x60*/ bool safeMode;
    /*0x68*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> safeText;

    /*0x4d7460*/ SeedLibrary();
    /*0x4d5480*/ void Awake();
    /*0x4d5670*/ void ChangeSafeMode();
    /*0x4d5c70*/ void OnStartGame();
    /*0x4d66f0*/ void SetTreasureCards();
    /*0x4d6320*/ CardUI SetTreasureCard(TreasureCardData data, UnityEngine.Transform parent);
    /*0x4d5890*/ UnityEngine.Transform GetParent(UnityEngine.Transform head);
    /*0x4d6160*/ void SetRogueCard(PlantType thePlantType);
    /*0x4d70e0*/ void Start();
    /*0x4d5b80*/ void NextPage(UnityEngine.Transform transform);
    /*0x4d5a90*/ void LastPage(UnityEngine.Transform transform);
    /*0x4d6da0*/ void ShowNormalCard();
    /*0x4d6cd0*/ void ShowColorfulCard();
    /*0x4d6e70*/ void ShowRogueCard();
    /*0x4d6f40*/ void ShowTowerCard();
    /*0x4d7010*/ void ShowTreasureCard();
    /*0x4d72e0*/ void <OnStartGame>b__14_0();

    class <>c
    {
        static /*0x0*/ SeedLibrary.<> <>9;
        static /*0x8*/ System.Func<TreasureCardData, CardLevel> <>9__15_0;
        static /*0x10*/ System.Func<TreasureCardData, PlantType> <>9__15_1;
        static /*0x18*/ System.Func<TreasureCardData, int> <>9__15_2;

        static /*0x4e32d0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4e2fc0*/ CardLevel <SetTreasureCards>b__15_0(TreasureCardData p);
        /*0x4c9cf0*/ PlantType <SetTreasureCards>b__15_1(TreasureCardData p);
        /*0x4c9d10*/ int <SetTreasureCards>b__15_2(TreasureCardData p);
    }
}

class SetName : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ SetName();
    /*0x32d010*/ void Start();
    /*0x32d010*/ void Update();
}

class ShootingSelectWindow : BaseWindow
{
    /*0x80*/ bool set;
    /*0x84*/ ShootingBuff buff;
    /*0x88*/ PlantType originalPlantType;
    /*0x8c*/ PlantType targetPlantType;
    /*0x90*/ UpgradeType upgradeType;

    /*0x4d8bd0*/ ShootingSelectWindow();
    /*0x4d8ba0*/ void Start();
    /*0x4d81c0*/ void InitWindow();
    /*0x4d84c0*/ void OnAnimOver();
    /*0x4d7710*/ void InitPlantType();
    /*0x4d8500*/ void SetUpgradePlantTypes(PlantType basePlantType);
    /*0x4d74e0*/ int GetMaxIndexInRoutes(PlantType plantType);
    /*0x4d8bc0*/ int <SetUpgradePlantTypes>b__9_0(PlantType p);
}

class SkinButton : UnityEngine.MonoBehaviour
{
    /*0x20*/ AlmanacPlantBank showPlant;
    /*0x28*/ TMPro.TextMeshPro textMesh;

    /*0x31c640*/ SkinButton();
    /*0x4d8bf0*/ void Awake();
    /*0x4d8c40*/ void OnMouseEnter();
    /*0x4d8c90*/ void OnMouseExit();
    /*0x4d8ce0*/ void OnMouseUpAsButton();
}

class SpriteSlider : UnityEngine.MonoBehaviour
{
    /*0x20*/ float value;
    /*0x24*/ UnityEngine.Vector2 startPosition;
    /*0x2c*/ UnityEngine.Vector2 originalSize;
    /*0x38*/ UnityEngine.SpriteRenderer spriteRenderer;

    /*0x31c640*/ SpriteSlider();
    /*0x4d8ed0*/ void OnDrawGizmos();
    /*0x4d8ed0*/ void Update();
}

class TowerUpgradeMenu : BaseMenu
{
    static /*0x0*/ TowerUpgradeMenu Instance;
    /*0x30*/ TowerPlant plant;
    /*0x38*/ UnityEngine.GameObject upgrade1;
    /*0x40*/ UnityEngine.GameObject upgrade2;
    /*0x48*/ UnityEngine.GameObject upgrade3;
    /*0x50*/ TMPro.TextMeshProUGUI des;
    /*0x58*/ TMPro.TextMeshProUGUI des2;
    /*0x60*/ UnityEngine.GameObject shootButton;
    /*0x68*/ int basicCost;

    /*0x32c760*/ TowerUpgradeMenu();
    /*0x4d8fc0*/ void Awake();
    /*0x4da690*/ void Start();
    /*0x4d9680*/ void SetText();
    /*0x4d9090*/ void Select1();
    /*0x4d9260*/ void Select2();
    /*0x4d9470*/ void Select3();
    /*0x4d9020*/ void Quit();
    /*0x4da760*/ void Update();
    /*0x4da600*/ void Shoot();
}

class TravelCurseMenu : BaseMenu
{
    /*0x32c760*/ TravelCurseMenu();
    /*0x4da8a0*/ void Confirm();
}

class TravelStart : BaseMenu
{
    static /*0x0*/ TravelStart Instance;
    /*0x30*/ System.Collections.Generic.List<TravelBuff> travelBuffs;
    /*0x38*/ System.Collections.Generic.List<PlantType> plantsSelected;
    /*0x40*/ UnityEngine.GameObject IconPrefab;
    /*0x48*/ UnityEngine.GameObject curseButton;

    /*0x4db140*/ TravelStart();
    /*0x4dad80*/ void Awake();
    /*0x4db0d0*/ System.Collections.IEnumerator Start();
    /*0x4db080*/ void Refresh();
    /*0x4daeb0*/ void InitBuff();
    /*0x4dae30*/ void EnterCurseMenu();

    class <Start>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ TravelStart <>4__this;

        /*0x32f460*/ <Start>d__6(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4e2c50*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4e2cf0*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class TravelStartBtn : UIBtn
{
    /*0x60*/ bool refresh;

    /*0x31c640*/ TravelStartBtn();
    /*0x4daa90*/ void OnMouseUpAsButton();
}

class TravelStore : BaseMenu
{
    static /*0x0*/ TravelStore Instance;
    /*0x30*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> introduces;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> points;
    /*0x40*/ System.Collections.Generic.List<TravelBuff> travelBuffs;
    /*0x48*/ TravelBuff currentSelect;
    /*0x50*/ int count;

    /*0x4dc9a0*/ TravelStore();
    /*0x4dba50*/ void Awake();
    /*0x4dc800*/ void Update();
    /*0x4dc330*/ void SelectBuff(TravelBuff travelBuff);
    /*0x4dc6c0*/ void SetText(string text);
    /*0x4dbac0*/ void RefreshBuff();
    /*0x4dc3d0*/ void SetCost(TravelBuff travelBuff);
    /*0x4dc7e0*/ void SetType(TravelBuff travelBuff, BuffType buffType, int buffNumber);
}

class TravelStoreBtn : UIBtn
{
    /*0x60*/ int id;

    /*0x31c640*/ TravelStoreBtn();
    /*0x4db200*/ void OnMouseUpAsButton();
    /*0x4db890*/ void Quit();
}

class TreasureConfirmMenu : BaseMenu
{
    /*0x30*/ TreasureCard card;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> description;
    /*0x40*/ ConfirmType confirmType;
    /*0x48*/ System.Action customAction;
    /*0x50*/ string customText;
    /*0x58*/ int cost;

    /*0x4dd430*/ TreasureConfirmMenu();
    /*0x4dd170*/ void Start();
    /*0x4dd050*/ void SetText(string text);
    /*0x4dcd00*/ void Confirm();
    /*0x4dca90*/ void Buy();
}

enum ConfirmType
{
    Buy = 0,
    Sell = 1,
    EnterNormal = 2,
    EnterHard = 3,
    EnterHell = 4,
    EnterUpgrade = 5,
    Reset = 6,
    Tell = 7,
    Custom = 8,
}

class TreasureEquipmentMenu : BaseMenu
{
    static /*0x0*/ TreasureEquipmentMenu Instance;
    /*0x30*/ UnityEngine.Transform library;
    /*0x38*/ UnityEngine.GameObject samplePage;
    /*0x40*/ UnityEngine.Transform equipedLibrary;
    /*0x48*/ TMPro.TextMeshProUGUI armament;
    /*0x50*/ System.Collections.Generic.List<TreasureCard> localCards;

    /*0x4de520*/ TreasureEquipmentMenu();
    /*0x4dd4b0*/ void Awake();
    /*0x4de070*/ void UpdateCards();
    /*0x4dd520*/ void InitCards(int show);

    class <>c
    {
        static /*0x0*/ TreasureEquipmentMenu.<> <>9;
        static /*0x8*/ System.Func<TreasureCardData, CardLevel> <>9__8_0;
        static /*0x10*/ System.Func<TreasureCardData, PlantType> <>9__8_1;
        static /*0x18*/ System.Func<TreasureCardData, int> <>9__8_2;
        static /*0x20*/ System.Func<TreasureCardData, bool> <>9__8_3;

        static /*0x4e3110*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4e2f10*/ CardLevel <InitCards>b__8_0(TreasureCardData c);
        /*0x4c9cf0*/ PlantType <InitCards>b__8_1(TreasureCardData c);
        /*0x4c9d10*/ int <InitCards>b__8_2(TreasureCardData c);
        /*0x3ed5e0*/ bool <InitCards>b__8_3(TreasureCardData c);
    }

    class <>c__DisplayClass8_0
    {
        /*0x10*/ System.Collections.Generic.List<TreasureCardData> equipedCards;

        /*0x32f970*/ <>c__DisplayClass8_0();
        /*0x4e30b0*/ bool <InitCards>b__4(TreasureCardData c);
    }
}

class TreasureEvacuateMenu : BaseMenu
{
    /*0x30*/ TreasureManager manager;
    /*0x38*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> eva1Text;
    /*0x40*/ Task.TaskType taskType1;
    /*0x48*/ System.Collections.Generic.List<TMPro.TextMeshProUGUI> eva2Text;
    /*0x50*/ Task.TaskType taskType2;

    /*0x4deb60*/ TreasureEvacuateMenu();
    /*0x4de620*/ void Start();
    /*0x4de5a0*/ void Evacuate1();
    /*0x4de5e0*/ void Evacuate2();
}

class TreasureMainMenu : BaseMenu
{
    static /*0x0*/ TreasureMainMenu Instance;
    /*0x30*/ TMPro.TextMeshProUGUI mapText;
    /*0x38*/ TMPro.TextMeshProUGUI autoCollectText;

    /*0x32c760*/ TreasureMainMenu();
    /*0x4decd0*/ void Awake();
    /*0x4df860*/ void Update();
    /*0x4dedd0*/ void EnterGarden();
    /*0x4df650*/ void SetSceneType(string name);
    /*0x4df5d0*/ void EnterWareHouse();
    /*0x4df390*/ void EnterStore();
    /*0x4ded50*/ void EnterEquipment();
    /*0x4df550*/ void EnterUpgrade();
    /*0x4ded30*/ void Back();
    /*0x4df250*/ void EnterNormalLevel();
    /*0x4defd0*/ void EnterHardLevel();
    /*0x4df110*/ void EnterHellLevel();
    /*0x4df410*/ void EnterUpgradeLevel();
    /*0x4df780*/ void TryReset();
    /*0x4dec10*/ void AutoCollect();
}

class TreasureSettleMenu : BaseMenu
{
    /*0x30*/ UnityEngine.GameObject samplePage;
    /*0x38*/ UnityEngine.Transform library;

    /*0x32c760*/ TreasureSettleMenu();
    /*0x4e0210*/ void Start();
    /*0x4dfa30*/ void InitCards();

    class <>c
    {
        static /*0x0*/ TreasureSettleMenu.<> <>9;
        static /*0x8*/ System.Func<TreasureCardData, CardLevel> <>9__3_0;
        static /*0x10*/ System.Func<TreasureCardData, PlantType> <>9__3_1;
        static /*0x18*/ System.Func<TreasureCardData, int> <>9__3_2;

        static /*0x4e3180*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4e2d90*/ CardLevel <InitCards>b__3_0(TreasureCardData c);
        /*0x4c9cf0*/ PlantType <InitCards>b__3_1(TreasureCardData c);
        /*0x4c9d10*/ int <InitCards>b__3_2(TreasureCardData c);
    }
}

class TreasureStoreMenu : BaseMenu
{
    /*0x30*/ UnityEngine.Transform library;
    /*0x38*/ UnityEngine.GameObject samplePage;

    /*0x32c760*/ TreasureStoreMenu();
    /*0x4e0b50*/ void Start();
    /*0x4e0230*/ void InitCards();

    class <>c
    {
        static /*0x0*/ TreasureStoreMenu.<> <>9;
        static /*0x8*/ System.Func<PlantType, int> <>9__3_0;
        static /*0x10*/ System.Predicate<PlantType> <>9__3_1;
        static /*0x18*/ System.Predicate<PlantType> <>9__3_2;

        static /*0x4e3340*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4e2df0*/ int <InitCards>b__3_0(PlantType a);
        /*0x4e2e40*/ bool <InitCards>b__3_1(PlantType p);
        /*0x4e2e90*/ bool <InitCards>b__3_2(PlantType p);
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ System.Collections.Generic.HashSet<PlantType> plantsToRemove;

        /*0x32f970*/ <>c__DisplayClass3_0();
        /*0x4e3020*/ bool <InitCards>b__3(PlantType plant);
    }
}

class TreasureUpgradeMenu : BaseMenu
{
    /*0x30*/ TMPro.TextMeshProUGUI wareHouseText;
    /*0x38*/ System.Collections.Generic.List<TreasureCard> wareHouseCost;
    /*0x40*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PlantType>> UpgradeCards;

    /*0x4e1560*/ TreasureUpgradeMenu();
    /*0x4e0fa0*/ void Start();
    /*0x4e0fa0*/ void OnBackEnter();
    /*0x4e0fb0*/ void UpgradeWareHouse();
    /*0x4e0b70*/ void InitWareHouseUpgrade();

    class <>c__DisplayClass4_0
    {
        /*0x10*/ TreasureCard item;

        /*0x32f970*/ <>c__DisplayClass4_0();
        /*0x4e3080*/ bool <UpgradeWareHouse>b__0(TreasureCardData c);
    }

    class <>c__DisplayClass5_0
    {
        /*0x10*/ TreasureCard card;

        /*0x32f970*/ <>c__DisplayClass5_0();
        /*0x4e3080*/ bool <InitWareHouseUpgrade>b__0(TreasureCardData c);
    }
}

class TreasureWarehouseMenu : BaseMenu
{
    static /*0x0*/ TreasureWarehouseMenu Instance;
    /*0x30*/ System.Collections.Generic.List<TreasureCard> cards;
    /*0x38*/ UnityEngine.Transform library;
    /*0x40*/ UnityEngine.GameObject samplePage;
    /*0x48*/ TMPro.TextMeshProUGUI quickSellText;
    /*0x50*/ bool quickSell;

    /*0x4e2a80*/ TreasureWarehouseMenu();
    /*0x4e1e10*/ void Awake();
    /*0x4e29e0*/ void QuickSell();
    /*0x4e2a60*/ void Start();
    /*0x4e1e70*/ void EnterStore();
    /*0x4e20f0*/ void InitCards();
    /*0x4e1ef0*/ void FastSell(string str);

    class <>c
    {
        static /*0x0*/ TreasureWarehouseMenu.<> <>9;
        static /*0x8*/ System.Predicate<TreasureCardData> <>9__10_0;
        static /*0x10*/ System.Func<TreasureCardData, CardLevel> <>9__10_1;
        static /*0x18*/ System.Func<TreasureCardData, PlantType> <>9__10_2;
        static /*0x20*/ System.Func<TreasureCardData, int> <>9__10_3;

        static /*0x4e3260*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4c9c50*/ bool <InitCards>b__10_0(TreasureCardData a);
        /*0x4e2d30*/ CardLevel <InitCards>b__10_1(TreasureCardData c);
        /*0x4c9cf0*/ PlantType <InitCards>b__10_2(TreasureCardData c);
        /*0x4c9d10*/ int <InitCards>b__10_3(TreasureCardData c);
    }
}

class UIBtn : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite highLightSprite;
    /*0x28*/ ButtonSoundType buttonSoundType;
    /*0x30*/ UnityEngine.RectTransform rectTransform;
    /*0x38*/ UnityEngine.Events.UnityEvent clickEvent;
    /*0x40*/ UnityEngine.Sprite originSprite;
    /*0x48*/ UnityEngine.UI.Image image;
    /*0x50*/ UnityEngine.Vector3 originPosition;

    /*0x31c640*/ UIBtn();
    /*0x4e33b0*/ void Awake();
    /*0x4b8f00*/ void OnMouseEnter();
    /*0x4e3520*/ void OnMouseExit();
    /*0x4e3450*/ void OnMouseDown();
    /*0x4e3580*/ void OnMouseUpAsButton();
}

enum ButtonSoundType
{
    Default = 0,
    Grave = 1,
}

class WarningBtn : UIBtn
{
    /*0x60*/ bool confirm;

    /*0x31c640*/ WarningBtn();
    /*0x4e35f0*/ void OnMouseUpAsButton();
}

class ZombieCardInstantiater : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.GameObject example;

    /*0x31c640*/ ZombieCardInstantiater();
}

class BezierPathController : UnityEngine.MonoBehaviour
{
    static /*0x0*/ BezierPathController Instance;
    /*0x20*/ UnityEngine.Transform t;
    /*0x28*/ bool debug;
    /*0x30*/ UnityEngine.GameObject ballPrefab;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.GameObject> controlPointList;
    /*0x40*/ int segmentsPerCurve;
    /*0x44*/ float r;
    /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector3> ballPointList;
    /*0x50*/ float distance;

    /*0x4cb840*/ BezierPathController();
    /*0x4ca7e0*/ void Awake();
    /*0x4caf00*/ void OnDrawGizmos();
    /*0x4cab90*/ System.Collections.Generic.List<UnityEngine.Vector3> GetDrawingPoints(System.Collections.Generic.List<UnityEngine.Vector3> controlPoints, int segmentsPerCurve);
    /*0x4ca9f0*/ UnityEngine.Vector3 CalculateBezierPoint(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3);

    class <>c
    {
        static /*0x0*/ BezierPathController.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.GameObject, UnityEngine.Vector3> <>9__10_0;

        static /*0x4e31f0*/ <>c();
        /*0x32f970*/ <>c();
        /*0x4e2f70*/ UnityEngine.Vector3 <OnDrawGizmos>b__10_0(UnityEngine.GameObject point);
    }
}

class MapConfig : UnityEngine.MonoBehaviour
{
    static /*0x0*/ MapConfig Instance;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.Vector3> pathPointList;
    /*0x28*/ float minDistance;
    /*0x2c*/ float <EndPoint>k__BackingField;

    /*0x4ccbc0*/ MapConfig();
    /*0x4cc980*/ void Awake();
    /*0x4cca10*/ UnityEngine.Vector3 GetPosition(float progress);
    /*0x4ccb70*/ void InitMapConfig();
    /*0x4ccc40*/ float get_EndPoint();
    /*0x4ccc50*/ void set_EndPoint(float value);
}

class Zuma : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Zuma Instance;
    /*0x20*/ int nextLayer;
    /*0x24*/ float maxSpeed;
    /*0x28*/ float headSpeed;
    /*0x2c*/ int maxBallCount;
    /*0x30*/ int summonBallCount;
    /*0x34*/ ZumaBall.BallType lastType;
    /*0x38*/ bool gameOver;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.GameObject> ballPrefab;
    /*0x48*/ System.Collections.Generic.List<ZumaBall> ballSegmentList;
    /*0x50*/ bool isBomb;
    /*0x58*/ System.Collections.Generic.List<Zuma.BackSegment> backSegmentList;
    /*0x60*/ float backTime;
    /*0x64*/ float backSpeed;
    /*0x68*/ System.Collections.Generic.List<ZumaBall> searchDestoryList;
    /*0x70*/ System.Collections.Generic.List<ZumaBall> fallBackList;

    static /*0x4e6c00*/ ZumaBall.BallType GetShootBallType();
    /*0x4e87f0*/ Zuma();
    /*0x4e5a90*/ void Awake();
    /*0x4e81f0*/ System.Collections.IEnumerator Start();
    /*0x4e8330*/ void Update();
    /*0x4e6780*/ void FirstSegmentMove();
    /*0x4e6390*/ void CheckGameFail();
    /*0x4e7900*/ void ShootBallInsert();
    /*0x4e6c40*/ void SearchDestory();
    /*0x4e5f00*/ void CheckFallbackBall();
    /*0x4e8260*/ void UpdateBallProgress(ZumaBall ball);
    /*0x4e5c10*/ void BallSegmentConnect();
    /*0x4e7fd0*/ void StartBack(int segment, float speed, int combo);
    /*0x4e5af0*/ void BackSegments();
    /*0x4e7600*/ Zuma.BackSegment SegmentBack(Zuma.BackSegment segment, int index);
    /*0x4e64d0*/ void CheckVictory();
    /*0x4e8640*/ void Victory();
    /*0x4e6590*/ ZumaBall CreateBall(UnityEngine.Vector2 position, UnityEngine.Quaternion quaternion, ZumaBall.BallType ballType);
    /*0x4e6ba0*/ ZumaBall.BallType GetRoadBallType();

    struct BackSegment
    {
        /*0x10*/ int segment;
        /*0x14*/ float speed;
        /*0x18*/ int combo;
    }

    class <Start>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Zuma <>4__this;

        /*0x32f460*/ <Start>d__17(int <>1__state);
        /*0x32d010*/ void System.IDisposable.Dispose();
        /*0x4e2b00*/ bool MoveNext();
        /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x4e2c10*/ void System.Collections.IEnumerator.Reset();
        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ZumaBall : UnityEngine.MonoBehaviour
{
    /*0x20*/ float progress;
    /*0x24*/ float lastProgress;
    /*0x28*/ bool deleteFlag;
    /*0x30*/ ZumaBall fallbackTarget;
    /*0x38*/ UnityEngine.Rigidbody2D rb;
    /*0x40*/ ZumaBall.BallType theBallType;
    /*0x44*/ ZumaBall.BallStatus theBallStatus;
    /*0x48*/ ZumaBall <Next>k__BackingField;
    /*0x50*/ ZumaBall <Pre>k__BackingField;

    /*0x31c640*/ ZumaBall();
    /*0x4e3720*/ void Awake();
    /*0x4e3d70*/ void Update();
    /*0x4e3a70*/ int SameColorCount(ref System.Collections.Generic.List<ZumaBall> list);
    /*0x4e3770*/ void CheckOutOfScreen();
    /*0x4e3820*/ void Die();
    /*0x4e38d0*/ bool ISExitStartHole();
    /*0x4e38e0*/ bool IsArriveFailHole();
    /*0x4e40d0*/ ZumaBall get_Next();
    /*0x4e4360*/ void set_Next(ZumaBall value);
    /*0x4e40e0*/ ZumaBall get_Pre();
    /*0x4e4370*/ void set_Pre(ZumaBall value);
    /*0x4e40f0*/ int get_SegmentIndex();
    /*0x4e42d0*/ ZumaBall get_Tail();
    /*0x4e4040*/ ZumaBall get_Head();
    /*0x4e3940*/ bool IsCross(UnityEngine.Vector3 targetPos, float distance);

    enum BallType
    {
        BrownBall = 0,
        IronBall = 1,
        DarkBall = 2,
        HyponoBall = 3,
        BlueBall = 4,
        ExplodeBall = 5,
    }

    enum BallStatus
    {
        Moving = 0,
        OnShooter = 1,
        OnRoad = 2,
        Waiting = 3,
    }
}

class ZumaBtn : UIBtn
{
    /*0x60*/ int btnType;
    /*0x64*/ bool trigger;

    /*0x31c640*/ ZumaBtn();
    /*0x4e4480*/ void OnMouseUpAsButton();
    /*0x4e4380*/ void OnMouseEnter();
    /*0x4e43f0*/ void OnMouseExit();
}

class ZumaPrize : PrizeMgr
{
    /*0x4e4d20*/ ZumaPrize();
    /*0x4e4c10*/ void Update();
    /*0x4e4680*/ void Click();
    /*0x4e4b60*/ void GoBack();
}

class ZumaShooter : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ZumaShooter Instance;
    /*0x20*/ System.Collections.Generic.List<ZumaBall> shootBallList;
    /*0x28*/ ZumaBall currentBall;
    /*0x30*/ ZumaBall nextball;
    /*0x38*/ UnityEngine.Transform cannonPos;
    /*0x40*/ UnityEngine.Transform cannonPos2;
    /*0x48*/ bool freeMouse;

    /*0x4e5a10*/ ZumaShooter();
    /*0x4e4e50*/ void Awake();
    /*0x4e53d0*/ void Start();
    /*0x4e5740*/ void Update();
    /*0x4e4f30*/ void Shoot(UnityEngine.Vector2 direction, float speed);
    /*0x4e4d30*/ void AddToList(ZumaBall ball);
}

class ExploreDataManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, ExploreData> levelDataDic;

    static /*0x4cc7e0*/ ExploreDataManager();
    static /*0x4cbc80*/ void LoadData();
    static /*0x4cbf10*/ void LoadFile(string fileName, string jsonData);
    static /*0x4cbae0*/ ExploreData GetExploreData(PlantType thePlantType);
    static /*0x4cb910*/ ExploreData GetExploreData(int level);
    /*0x31c640*/ ExploreDataManager();
    /*0x4cc760*/ void TryLoad();
    /*0x4cc2a0*/ void Test();
}

class ExploreData
{
    /*0x10*/ PlantType level;
    /*0x14*/ SceneType sceneType;
    /*0x18*/ int maxWave;
    /*0x20*/ System.Collections.Generic.List<ZombieType> zombiesToAppear;
    /*0x28*/ System.Collections.Generic.List<PrePlantData> prePlant;
    /*0x30*/ System.Collections.Generic.List<PlantType> usePlant;
    /*0x38*/ bool convay;
    /*0x3c*/ float convayTimer;
    /*0x40*/ float gloveCD;
    /*0x48*/ string tips;

    /*0x4cc870*/ ExploreData();
}

class PrePlantData
{
    /*0x10*/ PlantType thePlantType;
    /*0x14*/ int theColumn;
    /*0x18*/ int theRow;

    /*0x32f970*/ PrePlantData();
}

class ResourcesManager
{
    /*0x10*/ System.Collections.Generic.Dictionary<PlantType, UnityEngine.GameObject> plantPrefabs;
    /*0x18*/ System.Collections.Generic.Dictionary<PlantType, System.Collections.Generic.List<UnityEngine.GameObject>> _plantPrefabs;
    /*0x20*/ System.Collections.Generic.Dictionary<PlantType, UnityEngine.GameObject> plantPreviews;
    /*0x28*/ System.Collections.Generic.Dictionary<PlantType, System.Collections.Generic.List<UnityEngine.GameObject>> _plantPreviews;
    /*0x30*/ System.Collections.Generic.Dictionary<PlantType, int> plantSkinDic;
    /*0x38*/ System.Collections.Generic.Dictionary<ZombieType, UnityEngine.GameObject> zombiePrefabs;
    /*0x40*/ System.Collections.Generic.Dictionary<BulletType, UnityEngine.GameObject> bulletPrefabs;
    /*0x48*/ System.Collections.Generic.Dictionary<ParticleType, UnityEngine.GameObject> particlePrefabs;
    /*0x50*/ System.Collections.Generic.Dictionary<GridItemType, UnityEngine.GameObject> gridItemPrefabs;
    /*0x58*/ System.Collections.Generic.Dictionary<EquipmentType, UnityEngine.GameObject> equipmentPrefabs;
    /*0x60*/ System.Collections.Generic.List<PlantType> allPlants;
    /*0x68*/ System.Collections.Generic.List<ZombieType> allZombieTypes;
    /*0x70*/ System.Collections.Generic.List<BulletType> allBullets;
    /*0x78*/ System.Collections.Generic.List<ParticleType> allParticles;
    /*0x80*/ System.Collections.Generic.List<UnityEngine.GameObject> gravePrefabs;

    /*0x4d3db0*/ ResourcesManager();
    /*0x4cefb0*/ void LoadNormalSkin();
    /*0x4d36e0*/ void LoadSkin();
    /*0x4d2f40*/ void LoadPlant();
    /*0x4d3340*/ void LoadPlant(PlantType thePlantType, string path);
    /*0x4ce600*/ void LoadBullet();
    /*0x4cea20*/ void LoadGraves();
    /*0x4ceb90*/ void LoadGridItem();
    /*0x4cee80*/ void LoadGridItem(GridItemType theItemType, string path);
    /*0x4d3c50*/ void SkinListToDic(System.Collections.Generic.List<PlantSkinData> list);
    /*0x4d3a70*/ System.Collections.Generic.List<PlantSkinData> SkinDicToList();
    /*0x4d38b0*/ void SetSkin(PlantType thePlantType, int index);
}

enum SkinType
{
    Default = 0,
    First = 1,
}

class MenuMaker : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Sprite topLeft;
    /*0x28*/ UnityEngine.Sprite topRight;
    /*0x30*/ UnityEngine.Sprite top;
    /*0x38*/ UnityEngine.Sprite leftMid;
    /*0x40*/ UnityEngine.Sprite mid;
    /*0x48*/ UnityEngine.Sprite rightMid;
    /*0x50*/ UnityEngine.Sprite bottomLeft;
    /*0x58*/ UnityEngine.Sprite bottomRight;
    /*0x60*/ UnityEngine.Sprite bottom;
    /*0x68*/ System.Collections.Generic.List<UnityEngine.UI.Image> clips;
    /*0x70*/ bool set;

    /*0x512ec0*/ MenuMaker();
    /*0x5124d0*/ void OnDrawGizmos();
    /*0x5126b0*/ void SetMenu(int x, int y);
    /*0x512860*/ void SetPosition(int x, int y);
    /*0x511c70*/ void CreateObjects(int x, int y);
}

class FlashModule : UnityEngine.MonoBehaviour
{
    /*0x20*/ float flashTimer;

    /*0x31c640*/ FlashModule();
    /*0x502740*/ void FlashOnce();
    /*0x502750*/ void OnFixedUpdate(System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers);
    /*0x502810*/ void SetBrightness(float b, System.Collections.Generic.List<UnityEngine.SpriteRenderer> spriteRenderers);
}

class ZombieHead : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ ZombieHead();
    /*0x51db70*/ void OnParticleCollision(UnityEngine.GameObject other);
}

class QuestManager : UnityEngine.MonoBehaviour
{
    /*0x20*/ System.Collections.Generic.List<QuestNode> questNodes;

    /*0x516570*/ QuestManager();
}

class QuestNode : UnityEngine.MonoBehaviour
{
    /*0x20*/ QuestNode parent;
    /*0x28*/ System.Collections.Generic.List<QuestNode> childs;
    /*0x30*/ int id;
    /*0x38*/ string questName;
    /*0x40*/ string questDescription;
    /*0x48*/ QuestType questType;
    /*0x4c*/ QuestTarget questTarget;
    /*0x50*/ int target;
    /*0x54*/ QuestAward questAward;
    /*0x58*/ int award;
    /*0x5c*/ bool onTask;
    /*0x5d*/ bool completed;

    /*0x31c640*/ QuestNode();
    /*0x348b00*/ bool Check();
    /*0x5165f0*/ void AddQuest();
}

enum QuestAward
{
    Sun = 0,
    Money = 1,
    PlantCard = 2,
    Plant = 3,
    AdvBuff = 4,
    UltiBuff = 5,
}

enum QuestTarget
{
    GetSun = 0,
    GetMoney = 1,
    KillZombie = 2,
    SetPlant = 3,
}

enum QuestType
{
    Check = 0,
    Cost = 1,
}

class AoeDamage : UnityEngine.MonoBehaviour
{
    static /*0x501560*/ bool Bomb(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage, int rangeRow);
    static /*0x501330*/ void BombPotato(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage, int rangeRow, System.Action<Zombie> action);
    static /*0x501800*/ void SmallBombPotato(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage, System.Action<Zombie> action);
    static /*0x501850*/ void SmallBomb(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage);
    static /*0x5017b0*/ bool MidBomb(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage);
    static /*0x5012f0*/ void BigBomb(UnityEngine.Vector3 position, float range, UnityEngine.LayerMask layerMask, int theRow, int theDamage);
    static /*0x501740*/ bool InLandAoeRange(ZombieStatus theZombieStatus);
    static /*0x5017f0*/ bool PotatoAoeRange(ZombieStatus theZombieStatus);
    /*0x31c640*/ AoeDamage();
}

class DelayAction : UnityEngine.MonoBehaviour
{
    /*0x20*/ System.Collections.Generic.List<DelayAction.ActionClip> actions;

    /*0x501b60*/ DelayAction();
    /*0x501920*/ void SetAction(System.Action action, float timer);
    /*0x501a20*/ void Update();

    class ActionClip
    {
        /*0x10*/ float timer;
        /*0x18*/ System.Action action;
        /*0x20*/ bool active;

        /*0x5012a0*/ ActionClip(System.Action action, float timer);
        /*0x501240*/ void Update();
    }
}

class DoubleArrIO
{
    static /*0x17e030*/ string ArrToString<T>(T[,] arr);
    static /*0x17e030*/ T[,] StringToArr<T>(string str);
    /*0x32f970*/ DoubleArrIO();
}

class DY : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TextMeshPro TextMeshPro;
    /*0x28*/ bool a;

    /*0x31c640*/ DY();
    /*0x501890*/ void Update();
}

class EndlessData : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<ZombieType, int> SandZombiePool;
    /*0x20*/ int round;

    static /*0x5020c0*/ EndlessData();
    static /*0x501be0*/ System.Collections.Generic.List<ZombieType> GetSandZombieTypes(int round);
    /*0x31c640*/ EndlessData();
    /*0x501e80*/ void Test();

    class <>c__DisplayClass2_0
    {
        /*0x10*/ int maxLevel;

        /*0x32f970*/ <>c__DisplayClass2_0();
        /*0x51d8e0*/ bool <GetSandZombieTypes>b__0(System.Collections.Generic.KeyValuePair<ZombieType, int> a);
    }
}

enum PlantType
{
    Nothing = -1,
    Peashooter = 0,
    SunFlower = 1,
    CherryBomb = 2,
    WallNut = 3,
    PotatoMine = 4,
    Chomper = 5,
    SmallPuff = 6,
    FumeShroom = 7,
    HypnoShroom = 8,
    ScaredyShroom = 9,
    IceShroom = 10,
    DoomShroom = 11,
    LilyPad = 12,
    Squash = 13,
    ThreePeater = 14,
    Tanglekelp = 15,
    Jalapeno = 16,
    Caltrop = 17,
    TorchWood = 18,
    SeaShroom = 19,
    Plantern = 20,
    Cactus = 21,
    Blover = 22,
    StarFruit = 23,
    Pumpkin = 24,
    Magnetshroom = 25,
    Cabbagepult = 26,
    Pot = 27,
    Cornpult = 28,
    Garlic = 29,
    Umbrellaleaf = 30,
    Marigold = 31,
    Melonpult = 32,
    Shulkflower = 33,
    ElectricOnion = 34,
    PineFurnace = 35,
    SpruceShooter = 36,
    IceLotus = 37,
    WaterAloes = 38,
    Bamboo = 39,
    LuckyBlover = 229,
    FireSunshroom_a = 230,
    FireSunshroom_b = 231,
    FireSunshroom_c = 232,
    SnowPresent = 233,
    DiamondPotatoNut = 234,
    PassionFruit = 235,
    FrozenPear = 236,
    IcePeach = 237,
    Chrysantheautumn = 238,
    Gravebuster = 239,
    ObsidianWheat = 240,
    IceBean = 241,
    EndoFlameGirl = 242,
    Hamburger = 243,
    MixBomb = 244,
    Imitater = 245,
    MagnetBox = 246,
    MagnetInterface = 247,
    Squalour = 248,
    SwordStar = 249,
    PresentZombie = 250,
    BigSunNut = 251,
    CattailGirl = 252,
    Wheat = 253,
    EndoFlame = 254,
    BigWallNut = 255,
    Present = 256,
    Pit = 257,
    Refrash = 258,
    Extract_single = 259,
    Extract_ten = 260,
    AbyssSwordStar = 300,
    UltimateMinigun = 301,
    UltimateRedLunar = 302,
    Tower_peasunflower = 350,
    Tower_BigSunShroom = 351,
    Tower_cherryShooter = 352,
    Tower_starNut = 353,
    Tower_sunmine = 354,
    Tower_iceGloom = 355,
    Tower_cherryChomper = 356,
    Tower_electricOnion = 357,
    Tower_peaPuff = 358,
    Tower_sunShroom = 359,
    Tower_doomFume = 360,
    Tower_gravebuster = 361,
    Tower_scaredyfume = 362,
    Tower_iceblover = 363,
    Tower_doomStar = 364,
    Tower_waterCan = 365,
    Tower_lilyPad = 366,
    Tower_squashNut = 367,
    Tower_threeMine = 368,
    HypnoEmperor = 900,
    UltimateGatling = 901,
    UltimateTorch = 902,
    UltimateChomper = 903,
    UltimateFume = 904,
    SuperSunNut = 905,
    ObsidianSpike = 906,
    DoomGatling = 907,
    SnowGatlingPuff = 908,
    UltimateStar = 909,
    UltimateGloom = 910,
    UltimatePumpkin = 911,
    UltimateFly = 912,
    UltimateTallNut = 913,
    UltimateMelon = 914,
    UltimateCannon = 915,
    EmeraldUmbrella = 916,
    HypnoQueen = 917,
    AshThreePeater = 918,
    SuperThreePeater = 919,
    UltimateBlover = 920,
    GarlicUltimateChomper = 921,
    CherryUltimatePumpkin = 922,
    RedEmeraldUmbrella = 923,
    UltimateHypno = 924,
    UltimatePotatoNut = 925,
    CattailLour = 926,
    UltimateBigGatling = 927,
    SuperHypnoDoom = 928,
    SunGatlingPuff = 929,
    GatlingDoomScaredy = 930,
    ObsidianWallNut = 931,
    GoldThreeTorch = 932,
    UltimateCactus = 933,
    UltimateCabbage = 934,
    IFVPumpkin = 935,
    SolarPot = 936,
    LaserUmbrella = 937,
    GoldHypnoDoom = 938,
    UltimateGatlingBlover = 939,
    UltimateSpring = 940,
    UltimateKelp = 941,
    IFVIronPuff = 942,
    UltimateCorn = 943,
    UltimateMagnet = 944,
    UltimatePortalNut = 945,
    UltimateBigSniper = 946,
    UltimateSpruce = 947,
    UltimateStarTorch = 948,
    UltimatePlantern = 949,
    SolarLily = 950,
    UltimateBigChomper = 951,
    UltimatePuff = 952,
    UltimateExplodeCannon = 953,
    UltimateSunflower = 954,
    UltimateLunarCabbage = 955,
    DeathChomper = 956,
    PeaSunFlower = 1000,
    Cherryshooter = 1001,
    SunBomb = 1002,
    CherryNut = 1003,
    PeaNut = 1004,
    SuperCherryShooter = 1005,
    SunNut = 1006,
    PeaMine = 1007,
    DoubleCherry = 1008,
    SunMine = 1009,
    PotatoNut = 1010,
    PeaChomper = 1011,
    NutChomper = 1012,
    SuperChomper = 1013,
    SunChomper = 1014,
    PotatoChomper = 1015,
    CherryChomper = 1016,
    CherryGatling = 1017,
    PeaPuff = 1018,
    DoublePuff = 1019,
    IronPea = 1020,
    PuffNut = 1021,
    HypnoPuff = 1022,
    HypnoFume = 1023,
    ScaredyHypno = 1024,
    ScaredFume = 1025,
    SuperHypno = 1026,
    TallNut = 1027,
    TallNutFootball = 1028,
    IronNut = 1029,
    DoubleShooer = 1030,
    SunShroom = 1031,
    GatlingPea = 1032,
    TwinFlower = 1033,
    SnowPeaShooter = 1034,
    IcePuff = 1035,
    SmallIceShroom = 1036,
    IceFumeShroom = 1037,
    IceScaredyShroom = 1038,
    TallIceNut = 1039,
    IceDoom = 1040,
    IceHypno = 1041,
    ScaredyDoom = 1042,
    DoomFume = 1043,
    PuffDoom = 1044,
    HypnoDoom = 1045,
    SuperFume = 1046,
    ThreeSquash = 1047,
    CaltropNut = 1048,
    Jalakelp = 1049,
    Squashkelp = 1050,
    Threekelp = 1051,
    SuperTorch = 1052,
    JalaTorch = 1053,
    JalaSquash = 1054,
    ThreeTorch = 1055,
    KelpTorch = 1056,
    FireSquash = 1057,
    DarkThreePeater = 1058,
    SquashTorch = 1059,
    SpikeRock = 1060,
    TorchSpike = 1061,
    JalaSpike = 1062,
    SquashSpike = 1063,
    ThreeSpike = 1064,
    GatlingPuff = 1065,
    SuperKelp = 1066,
    CattailPlant = 1067,
    IceCattail = 1068,
    FireCattail = 1069,
    GloomShroom = 1070,
    FireGloom = 1071,
    IceGloom = 1072,
    TallFireNut = 1073,
    IceSpikeRock = 1074,
    FireSpikeRock = 1075,
    SeaCactus = 1076,
    SeaSunShroom = 1077,
    SeaLantern = 1078,
    LanternCactus = 1079,
    LanternBlover = 1080,
    LanternStar = 1081,
    CactusBlover = 1082,
    SeaStarfruit = 1083,
    StarBlover = 1084,
    CacstusStar = 1085,
    SeaBlover = 1086,
    LanternPumpkin = 1087,
    CactusPumpkin = 1088,
    StarPumpkin = 1089,
    SplitPea = 1090,
    BlowerPumpkin = 1091,
    MagnetPumpkin = 1092,
    MagnetStar = 1093,
    JackboxStar = 1094,
    PickaxeStar = 1095,
    IronStar = 1096,
    IronPumpkin = 1097,
    JackboxPumpkin = 1098,
    PickaxePumpkin = 1099,
    LanternMagnet = 1100,
    SeaMagnet = 1101,
    MagnetBlover = 1102,
    MagnetCactus = 1103,
    SuperStar = 1104,
    DoubleSnow = 1105,
    SnowGatling = 1106,
    SnowSplit = 1107,
    CherrySplit = 1108,
    SniperPea = 1109,
    SuperPumpkin = 1110,
    SunCabbage = 1111,
    CabbagePot = 1112,
    CornCabbage = 1113,
    CornPot = 1114,
    CornUmbrella = 1115,
    WinterMelon = 1116,
    GarlicCorn = 1117,
    GarlicCabbage = 1118,
    GarlicMelon = 1119,
    CobCannon = 1120,
    CornMelon = 1121,
    FireCannon = 1122,
    IceCannon = 1123,
    CabbageMelon = 1124,
    MelonPot = 1125,
    SuperMelon = 1126,
    GarlicUmbrella = 1127,
    CabbageUmbrella = 1128,
    MachineNut = 1129,
    GarlicPot = 1130,
    MelonUmbrella = 1131,
    MelonCannon = 1132,
    UmbrellaPot = 1133,
    SilverCabbage = 1134,
    GoldCabbage = 1135,
    SilverPot = 1136,
    GoldPot = 1137,
    SilverCorn = 1138,
    GoldCorn = 1139,
    TwinMarigold = 1140,
    SilverMelon = 1141,
    GoldMelon = 1142,
    SilverUmbrella = 1143,
    GoldUmbrella = 1144,
    SilverGarlic = 1145,
    GoldGarlic = 1146,
    HypnoNut = 1147,
    SuperUmbrella = 1148,
    FireMelon = 1149,
    GoldMagnet = 1150,
    SuperMachineNut = 1151,
    IronPuff = 1152,
    SplitPuff = 1153,
    SunMagnet = 1154,
    FireCaltrop = 1155,
    Firekelp = 1156,
    HypnoMagnet = 1157,
    MagnetFume = 1158,
    IronFume = 1159,
    HelmetFume = 1160,
    BigGatling = 1161,
    CherryMine = 1162,
    JalaMine = 1163,
    CherryPumpkin = 1164,
    SuperSnowGatling = 1165,
    CherryMagnet = 1166,
    FireSniper = 1167,
    SuperGatling = 1168,
    BigPumpkin = 1169,
    PotatoPuff = 1170,
    ScaredyPotato = 1171,
    GarlicFume = 1172,
    ObsidianJalapeno = 1173,
    BigChomper = 1174,
    BigSeaShroom = 1175,
    HypnoBlover = 1176,
    Twinshulk = 1177,
    CherryTorch = 1178,
    CherryJalapeno = 1179,
    IceCaltrop = 1180,
    GarlicBlover = 1181,
    IceTorch = 1182,
    StarPuff = 1183,
    SunPot = 1184,
    LanternUmbrella = 1185,
    CactusUmbrella = 1186,
    SilverSunflower = 1187,
    GoldSunflower = 1188,
    IceNut = 1189,
    PotatoPumpkin = 1190,
    DoomCactus = 1191,
    DoomChomper = 1192,
    FireFume = 1193,
    DoomPeashooter = 1194,
    LanternPot = 1195,
    MelonFume = 1196,
    StarTorch = 1197,
    JalaStar = 1198,
    DoomTorch = 1199,
    ScaredyPumpkin = 1200,
    ScaredyStar = 1201,
    SquashPumpkin = 1202,
    CornPuff = 1203,
    BloverUmbrella = 1204,
    HypnoPumpkin = 1205,
    NutUmbrella = 1206,
    CherryUmbrella = 1207,
    PortalPea = 1208,
    MagnetCorn = 1209,
    PortalCorn = 1210,
    IronCorn = 1211,
    IceCherry = 1212,
    MagnetDoom = 1213,
    PortalDoom = 1214,
    PortalNut = 1215,
    PeaBlover = 1216,
    SpruceShulk = 1217,
    WaterShulk = 1218,
    WaterSpruce = 1219,
    SuperSpruce = 1220,
    LotusSpruce = 1221,
    ShulkLotus = 1222,
    SpruceFurnace = 1223,
    ShulkFurnace = 1224,
    IceFurnace = 1225,
    WaterFurnace = 1226,
    LotusAloes = 1227,
    IceSquash = 1228,
    HypnoSquash = 1229,
    HypnoGarlic = 1230,
    HypnoMine = 1231,
    KelpMine_land = 1232,
    KelpMine_water = 1233,
    SuperFurnace = 1234,
    FireNut = 1235,
    DoomNut = 1236,
    CaltropKelp_water = 1237,
    CaltropKelp_land = 1238,
    BucketDoom = 1239,
    ThreeMine = 1240,
    LanternChomper = 1241,
    JackboxDoom = 1242,
    CherryPot = 1243,
    CherryBlover = 1244,
    BigSunShroom = 1245,
    ScaredSun = 1246,
    SpruceBallista = 1247,
    DoomSunflower = 1248,
    DoomSeed = 1249,
    SquashNut = 1250,
    SilverDoom = 1251,
    GoldDoom = 1252,
    IronSquash = 1253,
    WaterBallista = 1254,
    NutBlover = 1255,
    CactusNut = 1256,
    StarNut = 1257,
    LotusBamboo = 1258,
    WaterBamboo = 1259,
    BambooSpruce = 1260,
    MelonNut = 1261,
    CabbageNut = 1262,
    CornNut = 1263,
    ShulkBamboo = 1264,
    BambooFurnace = 1265,
    HugeWallNut = 1266,
    HypnoPeashooter = 1267,
    HypnoRepeater = 1268,
    HypnoSplit = 1269,
    HypnoGatling = 1270,
    SuperThreeGatling = 1271,
    DoomSniper = 1272,
    ScaredyBlover = 1273,
    CherryScaredy = 1274,
    DoomBlover = 1275,
    IceBlover = 1276,
    DoomStar = 1277,
    GarlicNut = 1278,
    MagnetNut = 1279,
    MelonPuff = 1280,
    CabbagePuff = 1281,
    NutTorch = 1282,
    TorchFireNut = 1283,
    SilverNut = 1284,
    GoldNut = 1285,
    HypnoMelon = 1286,
    IcePot = 1287,
    TorchPumpkin = 1288,
    TorchFirePumpkin = 1289,
    SniperPuff = 1290,
    SeaFume = 1291,
    SuperHypnoGatling = 1292,
    SeaNut = 1293,
    SeaScaredyshroom = 1294,
    ThreeNut = 1295,
    TreasureMine = 1296,
    IceSeashroom = 1297,
    PeaFume = 1298,
    NutPumpkin = 1299,
    BigGloom = 1300,
    SmallUmbrella = 1301,
    PuffSeaShroom = 1302,
    DoomSeaShroom = 1303,
    TorchSunflower = 1304,
    SeaHypno = 1305,
    HelmetGatling = 1306,
    SunStar = 1307,
    SunJalapeno = 1308,
    LanternNut = 1309,
    ScaredyNut = 1310,
    NutPot = 1311,
    NutFume = 1312,
    KelpNut = 1313,
    MagnetMelon = 1314,
    IronMelon = 1315,
    PortalMelon = 1316,
    DoomJalapeno = 1317,
    PeaPumpkin = 1318,
}

enum PlantTimer
{
    RecoverLess = 0,
    MoreDamage = 1,
    BloodTimer = 2,
    IronCurtain = 3,
    LotusFastShoot = 4,
    CherryFastShoot = 5,
}

enum SurvivalLevel
{
    DayNormal = 1,
    NightNormal = 2,
    PoolNormal = 3,
    DayHard = 4,
    NightHard = 5,
    PoolHard = 6,
    PoolEndless = 7,
    Travel = 8,
    FogNormal = 9,
    FogHard = 10,
    EndlessTower = 11,
    Travel2 = 12,
    RoofNormal = 13,
    RoofHard = 14,
    EndlessSuperRandom = 15,
    Travel3 = 16,
    DayEndless = 17,
    NightEndless = 18,
    FogEndless = 19,
    RoofEndless = 20,
    Travel4 = 21,
    UltimateEndless = 22,
    SnowEndless = 23,
    QuickTravel = 24,
    RandomTravel = 25,
    EndlessTravel = 26,
    EndlessReversePool = 27,
    EndlessBigPool = 28,
    EndlessRoofPool = 29,
    TravelRogue = 30,
    TowerDayEndless = 31,
    TowerNightEndless = 32,
    EndlessPool_crisis = 33,
}

enum SceneType
{
    Day = 0,
    Night = 1,
    Pool = 2,
    NightPool = 3,
    Roof = 4,
    NightRoof = 5,
    Day_6 = 6,
    Night_6 = 7,
    SuperDay = 8,
    SuperPool = 9,
    Travel_roof = 10,
    Test_green = 11,
    Travel_roof_dusk = 12,
    Travel_roof_night = 13,
    MidDay = 14,
    BilliardBallDay = 15,
    BilliardBallMidDay = 16,
    PVPScaryPot = 17,
    Snow = 18,
    Chess = 19,
    Snow_6 = 20,
    ReversalPool = 21,
    BigPool = 22,
    Roof_Pool = 23,
    River = 24,
    IZDay = 25,
    SnowPool = 26,
    LongMap = 27,
    TreasureBeach = 28,
    MidMap = 29,
    LavaBeach = 30,
}

enum PlantStatus
{
    Defalut = 0,
    GoldMagnet_attrack = 1,
    HypnoMagnet_summon = 2,
    MagnetInterface_active = 3,
    UltimateHypno_Charge1 = 4,
    UltimateHypno_Charge2 = 5,
    UltimateHypno_Charge3 = 6,
    BigGatling_moving = 7,
    BigGatling_raised = 8,
    Blover_blow = 9,
    Shulkflower_shooting = 10,
    Prism_shoot = 11,
    CherryJalapeno_fly = 12,
    UltimateCactus_superskill = 13,
    Solar_super = 14,
    Rest = 15,
    Fume_shooting = 16,
    Melonfume_charge = 17,
    DoomTorch_active = 18,
    Umbrella_blocking = 19,
    Kelp_grab = 20,
    AbyssSwordStar_attacking = 21,
    Chomper_bite = 22,
    Chomper_chew = 23,
    FindEnermy = 24,
    Raised = 25,
    Furnace = 26,
    BigSunNut_round = 27,
    BigSniper_readyToShoot = 28,
    Potato_waiting = 29,
    Potato_rising = 30,
    Potato_raised = 31,
    Squash_findZombie = 32,
    MelonNut_shoot = 33,
    Sunshroom_small = 34,
}

enum Towards
{
    Left = 0,
    Right = 1,
    Up = 2,
    Down = 3,
}

enum LevelType
{
    Nothing = -1,
    Advanture = 0,
    Challenge = 1,
    IZ = 2,
    Survival = 3,
    Explore = 4,
    TravelAdvanture = 5,
    SkinLevel = 6,
    AbyssLevel = 7,
    NewAdvanture = 8,
    TowerLevel = 9,
}

enum ZombieStatus
{
    Default = 0,
    Dying = 1,
    Pol_run = 2,
    Pol_jump = 3,
    Paper_lookPaper = 4,
    Paper_losePaper = 5,
    Paper_angry = 6,
    Snokle_inWater = 7,
    Dolphinrider_fast = 8,
    Dolphinrider_jump = 9,
    Flying = 10,
    Jackbox_surprise = 11,
    Miner_digging = 12,
    Miner_rising = 13,
    Polo_jump = 14,
    Gargantuar_withImp = 15,
    Imp_fly = 16,
    Imp_Land = 17,
    WithLadder = 18,
    Polo_waiting = 19,
    Polo_bigJump = 20,
    Boss = 21,
    Bungi_wating = 22,
    Bungi_down = 23,
    Bungi_up = 24,
    Spider_raising = 25,
    WithSnowShield = 26,
    Legion_fall = 27,
    Legion_summon = 28,
    Legion_bigSummon = 29,
    Drown_withDrown = 30,
    SnowMonster_jump = 31,
    Jackson_moonWalk = 32,
    Eternal_moving = 33,
    Football_beforeRoll = 34,
    Rider_waiting = 35,
    Horse_run = 36,
    Horse_hit = 37,
}

enum ZombieType
{
    Nothing = -1,
    NormalZombie = 0,
    FlagZombie = 1,
    ConeZombie = 2,
    PolevaulterZombie = 3,
    BucketZombie = 4,
    PaperZombie = 5,
    DancePolZombie = 6,
    DancePolZombie2 = 7,
    DoorZombie = 8,
    FootballZombie = 9,
    JacksonZombie = 10,
    ZombieDuck = 11,
    ConeZombieDuck = 12,
    BucketZombieDuck = 13,
    SubmarineZombie = 14,
    ElitePaperZombie = 15,
    DriverZombie = 16,
    SnorkleZombie = 17,
    SuperDriver = 18,
    Dolphinrider = 19,
    DrownZombie = 20,
    DollDiamond = 21,
    DollGold = 22,
    DollSilver = 23,
    JackboxZombie = 24,
    BalloonZombie = 25,
    KirovZombie = 26,
    SnowDolphinrider = 27,
    MinerZombie = 28,
    IronBalloonZombie = 29,
    SuperJackboxZombie = 30,
    CatapultZombie = 31,
    PogoZombie = 32,
    LadderZombie = 33,
    SuperPogoZombie = 34,
    Gargantuar = 35,
    RedGargantuar = 36,
    ImpZombie = 37,
    IronGargantuar = 38,
    IronRedGargantuar = 39,
    MachineNutZombie = 40,
    SilverZombie = 41,
    GoldZombie = 42,
    SuperGargantuar = 43,
    ZombieBoss = 44,
    BungiZombie = 45,
    ZombieBoss2 = 46,
    SnowZombie = 47,
    NewYearZombie = 48,
    SnowGunZombie = 49,
    SnowShieldZombie = 50,
    SnowDrownZombie = 51,
    ProtalZombie = 52,
    LevatationZombie = 53,
    TrainingDummy = 54,
    IceZombie = 55,
    SnowMonsterZombie = 56,
    SuperSnowMonsterZombie = 57,
    PickaxeZombie = 58,
    DolphinPaper = 59,
    ProjectileZombie = 60,
    FootballDolphin = 61,
    MiniSnowMonster = 62,
    GoldBungiZombie = 63,
    SandJackson = 64,
    StoneDancer = 65,
    FlagFootball = 66,
    MiniSandMonster = 67,
    ChickenImp = 68,
    HorseZombie = 69,
    SuperHorse = 70,
    BoatImp = 71,
    SuperLadderZombie = 72,
    PeaShooterZombie = 100,
    CherryShooterZombie = 101,
    SuperCherryShooterZombie = 102,
    WallNutZombie = 103,
    CherryPaperZombie = 104,
    RandomZombie = 105,
    BucketNutZombie = 106,
    CherryNutZombie = 107,
    IronPeaZombie = 108,
    TallNutFootballZombie = 109,
    RandomPlusZombie = 110,
    TallIceNutZombie = 111,
    CherryCatapultZombie = 112,
    DolphinPeaZombie = 113,
    IronPeaDoorZombie = 114,
    SquashZombie = 115,
    JalaSquashZombie = 116,
    JalapenoZombie = 117,
    GatlingFootballZombie = 118,
    IronBalloonZombie2 = 119,
    DoomZombie = 120,
    RandomGargantuar = 121,
    BlueGargantuar = 122,
    GreenGargantuar = 123,
    YellowGargantuar = 124,
    Zombie9527 = 125,
    SuperSubmarine = 200,
    JacksonDriver = 201,
    FootballDrown = 202,
    CherryPaperZ95 = 203,
    BlackFootball = 204,
    SuperKirov = 205,
    SuperBombThrower = 206,
    QuickJacksonZombie = 207,
    QingZombie = 208,
    JackboxJumpZombie = 209,
    SuperMachineNutZombie = 210,
    LandSubmarine = 211,
    UltimateGargantuar = 212,
    ObsidianImpZombie = 213,
    DolphinGatlingZombie = 214,
    DiamondRandomZombie = 215,
    DrownpultZombie = 216,
    SuperDancePolZombie = 217,
    UltimateFootballDrown = 218,
    UltimateMachineNutZombie = 219,
    UltimateFootballZombie = 220,
    UltimateKirovZombie = 221,
    UltimateJacksonDriver = 222,
    UltimatePaperZombie = 223,
    UltimateJackboxZombie = 224,
    GatlingBlackFootball = 225,
    LegionZombie = 226,
    IceClawZombie = 227,
    UltimateSnowZombie = 228,
    UltimateHorse = 229,
    GatlingBlackFootball2 = 230,
    GatlingPaper_a = 300,
    GatlingPaper_b = 301,
    GatlingPaper_c = 302,
    BlackFootball_a = 303,
    BlackFootball_b = 304,
    BlackFootball_c = 305,
    BlackFootball_c2 = 306,
    Jackson_a = 307,
    Jackson_b = 308,
    Jackson_c = 309,
    Submarine_a = 310,
    Submarine_b = 311,
    Submarine_b2 = 312,
    Submarine_c = 313,
    Submarine_c2 = 314,
    Drown_a = 315,
    Drown_b = 316,
    Drown_c = 317,
    Pickaxe_a = 318,
    Pickaxe_b = 319,
    Pickaxe_c = 320,
    Driver_a = 321,
    Driver_b = 322,
    Driver_c = 323,
    Jackbox_a = 324,
    Jackbox_b = 325,
    Jackbox_c = 326,
    Kirov_a = 327,
    Kirov_b = 328,
    Kirov_c = 329,
    EternalZombie_a = 330,
    EternalZombie_b = 331,
    EternalZombie_c = 332,
    Drownpult_a = 333,
    Drownpult_b = 334,
    Drownpult_c = 335,
}

enum BulletType
{
    Bullet_pea = 0,
    Bullet_cherry = 1,
    Bullet_nut = 2,
    Bullet_superCherry = 3,
    Bullet_zombieBlock = 4,
    Bullet_zombieBlock2 = 5,
    Bullet_zombieBlock3 = 6,
    Bullet_potato = 7,
    Bullet_smallSun = 8,
    Bullet_puff = 9,
    Bullet_puffPea = 10,
    Bullet_ironPea = 11,
    Bullet_threeSpike = 12,
    Bullet_puffRandomColor = 13,
    Bullet_puffLove = 14,
    Bullet_snowPea = 15,
    Bullet_snowPuffPea = 16,
    Bullet_iceSpark = 17,
    Bullet_smallIceSpark = 18,
    Bullet_magicTrack = 20,
    Bullet_snowPuff = 21,
    Bullet_blackPuff = 22,
    Bullet_doom = 23,
    Bullet_iceDoom = 24,
    Bullet_firePea_yellow = 25,
    Bullet_firePea_orange = 26,
    Bullet_firePea_red = 27,
    Bullet_squash = 28,
    Bullet_kelp = 29,
    Bullet_fireKelp = 30,
    Bullet_squashKelp = 32,
    Bullet_normalTrack = 33,
    Bullet_iceTrack = 34,
    Bullet_fireTrack = 35,
    Bullet_cherrySquash = 36,
    Bullet_cactus = 37,
    Bullet_lanternCactus_glow = 38,
    Bullet_star = 39,
    Bullet_lanternStar = 40,
    Bullet_seaStar = 41,
    Bullet_cactusStar = 42,
    Bullet_jackboxStar = 43,
    Bullet_pickaxeStar = 44,
    Bullet_magnetStar = 45,
    Bullet_ironStar = 46,
    Bullet_magnetCactus = 47,
    Bullet_superStar = 48,
    Bullet_ultimateStar = 49,
    Bullet_firePea_small = 50,
    Bullet_sword = 51,
    Bullet_cabbage = 52,
    Bullet_sunCabbage = 53,
    Bullet_kernal = 54,
    Bullet_butter = 55,
    Bullet_bigKernal = 56,
    Bullet_bigButter = 57,
    Bullet_basketball = 58,
    Bullet_melon = 59,
    Bullet_winterMelon = 60,
    Bullet_garlicKernal = 61,
    Bullet_garlicButter = 62,
    Bullet_garlicCabbage = 63,
    Bullet_garlicMelon = 64,
    Bullet_cannon = 65,
    Bullet_cornMelon = 66,
    Bullet_butterMelon = 67,
    Bullet_fireCannon = 68,
    Bullet_iceCannon = 69,
    Bullet_cabbageMelon = 70,
    Bullet_superMelon = 71,
    Bullet_ultimateMelon = 72,
    Bullet_melonCannon = 73,
    Bullet_silverCabbage = 74,
    Bullet_goldCabbage = 75,
    Bullet_silverKernal = 76,
    Bullet_goldKernal = 77,
    Bullet_silverButter = 78,
    Bullet_goldButter = 79,
    Bullet_smallGoldCannon = 80,
    Bullet_silverMelon = 81,
    Bullet_goldMelon = 82,
    Bullet_goldMelonCannon = 83,
    Bullet_ultimateCannon = 84,
    Bullet_ultimateKernal = 85,
    Bullet_fireMelon = 86,
    Bullet_firePea_super = 87,
    Bullet_garlicBomb = 89,
    Bullet_puffIronPea = 90,
    Bullet_lourCactus = 91,
    Bullet_puffPotato = 92,
    Bullet_steelPea = 93,
    Bullet_shulkLeaf = 94,
    Bullet_sunSpike = 95,
    Bullet_endoSun = 96,
    Bullet_extremeSnowPea = 97,
    Bullet_silverCoin = 98,
    Bullet_goldCoin = 99,
    Bullet_ultimateCactus = 100,
    Bullet_snowBall = 101,
    Bullet_doomCactus = 102,
    Bullet_bigMelon = 103,
    Bullet_fireStar = 104,
    Bullet_fireCherry = 105,
    Bullet_lanternCactus_dark = 106,
    Bullet_firePea_ultimate = 107,
    Bullet_redIronPea = 108,
    Bullet_normalSun = 109,
    Bullet_firePea_purple = 110,
    Bullet_springMelon = 111,
    Bullet_smallKernal = 112,
    Bullet_smallButter = 113,
    Bullet_portalPea = 114,
    Bullet_goldSquashKelp = 115,
    Bullet_ironPea_air = 116,
    Bullet_kernal_magnet = 117,
    Bullet_butter_magnet = 118,
    Bullet_kernal_portal = 119,
    Bullet_butter_portal = 120,
    Bullet_kernal_iron = 121,
    Bullet_butter_iron = 122,
    Bullet_pea_doom = 123,
    Bullet_pea_doom_fire = 124,
    Bullet_doom_fire = 125,
    Bullet_doom_big = 126,
    Bullet_spruce = 127,
    Bullet_spruceShulk = 128,
    Bullet_icePeach = 129,
    Bullet_passionFruit = 130,
    Bullet_passionFruit2 = 131,
    Bullet_water = 132,
    Bullet_iceBlock = 133,
    Bullet_water_big = 134,
    Bullet_iceBlock_big = 135,
    Bullet_shulkLeaf_water = 136,
    Bullet_iceBlock_recover = 137,
    Bullet_shulkLeaf_ice = 138,
    Bullet_lotusSpruce = 139,
    Bullet_kernal_ultimate = 140,
    Bullet_BlackHole_gold = 141,
    Bullet_shulkLeaf_ultimate = 142,
    Bullet_iceSword = 143,
    Bullet_fireStar_red = 144,
    Bullet_cherryStar = 145,
    Bullet_jalaStar = 146,
    Bullet_ultimateStar_fire = 147,
    Bullet_spruceBallista = 148,
    Bullet_waterBallista = 149,
    Bullet_waterBallista2 = 150,
    Bullet_spruce_bamboo = 151,
    Bullet_doom_throw = 152,
    Bullet_hypnoPea = 153,
    Bullet_hypnoPea_fire = 154,
    Bullet_puff_cherry = 155,
    Bullet_melon_small = 156,
    Bullet_cabbage_small = 157,
    Bullet_melon_hypno = 158,
    Bullet_ultimatePuff = 159,
    Bullet_corn_ulti = 160,
    Bullet_butter_ulti = 161,
    Bullet_cabbage_ulti = 162,
    Bullet_melon_ulti = 163,
    Bullet_watercan = 164,
    Bullet_ultimateSun = 165,
    Bullet_ultimateExplodeCannon = 166,
    Bullet_cherryJalapeno = 167,
    Bullet_helmetPea = 168,
    Bullet_lunarCabbage = 169,
    Bullet_redLunarCabbage = 170,
    Bullet_puffNut = 171,
    Bullet_melon_magnet = 172,
    Bullet_melon_iron = 173,
    Bullet_melon_portal = 174,
}

enum ChallengeLevel
{
    Travel1 = 1,
    Travel2 = 2,
    Travel3 = 3,
    Travel4 = 4,
    Travel5 = 5,
    Travel6 = 6,
    SuperCherryShooter = 7,
    SuperCherryShooter2 = 8,
    SuperCherryShooter3 = 9,
    SuperChomper = 10,
    SuperChomper2 = 11,
    SuperChomper3 = 12,
    FlagDay = 13,
    FlagPlantZombie = 14,
    FlagRandomPlant = 15,
    FlagRandomZombie = 16,
    FlagRandomAll = 17,
    FlagNight = 18,
    SuperHypno = 19,
    SuperHypno2 = 20,
    SuperHypno3 = 21,
    SuperFume = 22,
    SuperFume2 = 23,
    SuperFume3 = 24,
    ScaredDream = 25,
    FlagDream = 26,
    FlagElite = 27,
    PolDance = 28,
    PuffTime = 29,
    PaperBattle = 30,
    SuperTorch = 31,
    SuperKelp = 32,
    FlagPool = 33,
    DriverBattle = 34,
    TowerDefense = 35,
    TowerDefense2 = 36,
    Doll = 37,
    Column = 38,
    SuperPresent = 39,
    Shooting = 40,
    FlagShooting = 41,
    SeedRain = 42,
    Indestructible = 43,
    AirBattle = 44,
    Travel7 = 45,
    Travel8 = 46,
    BigMapDay = 47,
    UltimatePresent = 48,
    BigMapPool = 49,
    TowerDefense3 = 50,
    Travel9 = 51,
    CustomMapEditor = 52,
    CustomMap = 53,
    SuperStar = 54,
    SuperPumpkin = 55,
    RandomTower = 56,
    FlagFog = 57,
    Explosion = 58,
    PogoParty = 59,
    Travel10 = 60,
    Garden1 = 61,
    Gargantuar = 62,
    ZumaGame = 63,
    WheatProtection = 64,
    Squalour = 65,
    Mirror = 66,
    HypnoNut = 67,
    FlagExchange = 68,
    FlagExchange2 = 69,
    Travel11 = 70,
    Travel12 = 71,
    Shooting2 = 72,
    FlagShooting2 = 73,
    SuperMelon = 74,
    SuperUmbrella = 75,
    Loon = 76,
    Boss = 77,
    GoldMagnet = 78,
    Travel13 = 79,
    FlagConvey = 80,
    TowerDefense4 = 81,
    PuffTime2 = 82,
    TowerDefense5 = 83,
    Shooting3 = 84,
    FlagShooting3 = 85,
    ObsidianImp = 86,
    FlagRoof = 87,
    ShootingAll = 88,
    Garden2 = 89,
    Garden3 = 90,
    Garden4 = 91,
    Garden5 = 92,
    ImitaterRandom = 93,
    Travel14 = 94,
    ImitaterRandom2 = 95,
    DisMix = 96,
    TowerDefense6 = 97,
    Single = 98,
    BungiBattle = 99,
    Bejeweled = 100,
    Travel15 = 101,
    ScaryPot = 102,
    ScaryPot2 = 103,
    NewGarden = 104,
    TravelAll = 105,
    UltimateBattle = 106,
    LookStar = 107,
    Travel16 = 108,
    RandomMix = 109,
    RandomMix2 = 110,
    GloveZombie = 111,
    UltimateRandom = 112,
    Shooting4 = 113,
    HappyRandom = 114,
    ScaryPot3 = 115,
    BilliardBall = 116,
    BilliardBall2 = 117,
    BilliardBall3 = 118,
    OppositeRandom = 119,
    UltimateRandom2 = 120,
    Shooting5 = 121,
    PVPScaryPot = 122,
    HammerZombie = 123,
    HammerZombie2 = 124,
    FastZombie = 125,
    HugeGravity = 126,
    Snake = 127,
    SuperSpruce = 128,
    TravelSandBox = 129,
    Shooting6 = 130,
    Chess = 131,
    SeriousSquash2 = 132,
    ZombieBattle = 133,
    ZombieBattle2 = 134,
    Game2048 = 135,
    DrawCards = 136,
    River = 137,
    NewTower = 138,
    FruitNinjia = 139,
    RogueShooting = 140,
    LightShadow = 141,
    LoonGame = 142,
    FruitNinjia2 = 143,
    SnowBoss = 144,
    PlayerShooting = 145,
    BambooCrash = 146,
    CharredZombie = 147,
    FlagGame = 148,
    EndlessShooting = 149,
    Gargantuar2 = 150,
    TreasureMiner = 151,
    TreasureLevel1 = 152,
    TreasureLevel2 = 153,
    TreasureLevel3 = 154,
    TreasureLevel4 = 155,
    BrickBall = 156,
    BrickEndless = 157,
    BrickBall2 = 158,
    Shooting7 = 159,
    LavaBeach = 160,
    LookNut = 161,
    MixBomb = 162,
    IZ_ai = 163,
}

enum GameStatus
{
    OpenOptions = -2,
    OutGame = -1,
    InGame = 0,
    Pause = 1,
    InInterlude = 2,
    Selecting = 3,
    Almanac = 4,
    Car = 5,
    Wating = 6,
    BigGarden = 7,
}

enum DamageType
{
    Normal = 0,
    Ice = 1,
    Fire = 2,
    Jala = 3,
    Butter = 4,
    Poison = 5,
    Explode = 6,
    Ashy = 7,
    Squash = 8,
}

enum DamageEffect
{
    Default = 0,
    SetCold = 1,
    SetFreeze = 2,
    SetJalaed = 3,
    SetButtered = 4,
    Warm = 5,
    AddPoisonLevel = 6,
    AddFreezeLevel = 7,
    SetPoison = 8,
}

enum DamageMode
{
    Normal = 0,
    Shieldless = 1,
    All = 2,
    Squash = 3,
}

enum DmgType
{
    Normal = 0,
    NormalAll = 1,
    Ice = 2,
    IceAll = 3,
    Shieldless = 4,
    IceShieldless = 5,
    RealDamage = 6,
    Explode = 10,
    Squash = 11,
    Carred = 12,
    Hammer = 13,
    MaxDamage = 14,
}

enum MouseItemType
{
    Nothing = 0,
    Plant_preview = 1,
    Zombie_preview = 2,
    Shovel = 3,
    Glove = 4,
    Hammer = 5,
    Cannon = 6,
    Bucket = 7,
    Bean = 8,
}

enum PlantDieReason
{
    Default = 0,
    ByMix = 2,
}

enum BoardGame
{
    Default = 0,
    WheatProtection = 1,
}

enum PlantDamageAdder
{
    TravelNormalBuff = 0,
    Connect = 1,
    Level = 2,
    PointEffect = 3,
    AbyssBuff = 4,
    Abyss_loseHealth = 5,
    Curse = 6,
    NewTower = 7,
    Leader_UltimateGatling = 8,
    Camp_Land = 9,
    Leader_UltimteChomper = 10,
    Leader_SnowGatlingPuff = 11,
    Jigsaw = 12,
    Leader_UltimateCabbage = 13,
    Shooting = 14,
    DeathChomper = 15,
}

enum ExploreLevel
{
    BigGatling = 1,
    MorePotatoMine = 2,
    BigPumpkin = 3,
    PotatoPuff = 4,
    ScaredyPotato = 5,
    BigChomper = 6,
    GarlicFume = 7,
    HypnoBlover = 8,
    CherryTorch = 9,
    CherryJalapeno = 10,
    CaltropNut = 11,
    BigSeashroom = 12,
}

enum TravelAdvanture
{
    DoomGatling = 1,
    SuperSunNut = 2,
    SnowGatlingPuff = 3,
    HypnoEmperor = 4,
    SuperHypnoDoom = 5,
    SuperThreePeater = 6,
    ObsidianSpike = 7,
    CattailLour = 8,
    IFVPumpkin = 9,
    EmeraldUmbrella = 10,
    GoldThreeTorch = 11,
    SolarPot = 12,
    LaserUmbrella = 13,
    IFVIronPuff = 14,
    UltimateMagnet = 15,
    DeathChomper = 16,
}

enum SkinLevel
{
    UltimateGatling = 1,
    UltimateTorch = 2,
    HypnoEmperor = 3,
    UltimateChomper = 4,
    UltimateFume = 5,
    SuperSunNut = 6,
    DoomGatling = 7,
    ObsidianSpike = 8,
    UltimateSunflower = 9,
}

enum BulletStatus
{
    Default = 0,
    Melon_cannon = 1,
    GoldMelon_cannon = 2,
    Endoflame_sun = 3,
    Lanternstar_advanced = 4,
    Super = 5,
    Doom_big = 6,
    SpringMelon_sub = 7,
    Water_cold = 8,
    Raised = 9,
}

enum Team
{
    Player = 0,
    AI = 1,
}

enum CrackStatus
{
    Good = 0,
    Normal = 1,
    Bad = 2,
}

enum PlantLoadout
{
    Default = 0,
    Fly = 1,
    Pumpkin = 2,
    Pot = 3,
}

class GameMassage
{
    static /*0x0*/ GameMassage _instance;
    /*0x10*/ System.Collections.Generic.Dictionary<string, EventInfo> _eventDic;

    static /*0x502ea0*/ GameMassage get_Instance();
    /*0x502e20*/ GameMassage();
    /*0x5029f0*/ void AddEventListener(string name, UnityEngine.Events.UnityAction action);
    /*0x502c50*/ void EventTrigger(string name);
    /*0x183150*/ void AddEventListener<T>(string name, UnityEngine.Events.UnityAction action);
    /*0x17aec0*/ void EventTrigger<T>(string name);
    /*0x502d10*/ void RemoveEventLister(string name, UnityEngine.Events.UnityAction action);
    /*0x502c00*/ void Clear();
}

interface IEventInfo
{
}

class EventInfo : IEventInfo
{
    /*0x10*/ UnityEngine.Events.UnityAction actions;

    /*0x502690*/ EventInfo(UnityEngine.Events.UnityAction action);
}

class EventInfo<T> : IEventInfo
{
    /*0x0*/ UnityEngine.Events.UnityAction actions;

    /*0x17aec0*/ EventInfo(UnityEngine.Events.UnityAction action);
}

class GameStrategy
{
    static int OnePeaDamage = 20;
    static int ThreeTorchYellowFireDamage = 30;
    static int FirePeaDamage = 40;
    static int ThreeTorchOrangeFireDamage = 45;
    static int OrangeFirePeaDamage = 60;
    static int ThreeTorchRedFireDamage = 60;
    static int RedFirePeaDamage = 80;
    static int FireCherryDamage = 120;
    static int ZombieSuperCherryDamage = 1000;
    static int SuperCherryDamage = 300;
    static int RedIronPeaDamage = 320;
    static int BigSunDamage = 400;
    static int ThreeSpikeBulletDamage = 5;
    static int AshDamage = 1800;
    static int BasketBallDamage = 60;
    static string t = "融合版唯一官方：
哔哩哔哩up主-蓝飘飘fly";

    /*0x32f970*/ GameStrategy();
}

class GardenData : UnityEngine.MonoBehaviour
{
    static /*0x5035f0*/ string GetPath(int page);
    static /*0x503580*/ GardenAllData GetGardenData(int page);
    static /*0x503780*/ void LoadGardenData(UnityEngine.Transform parent, ref System.Collections.Generic.List<GardenPlant> plants, int page);
    static /*0x502fa0*/ bool AddNewPlantOutOfGarden(GardenPlantData plantData);
    static /*0x503710*/ PlantType GetPlantType();
    static /*0x503a60*/ void SaveGardenData(GardenUI gardenUI);
    static /*0x5039c0*/ void SaveFromCurrentData(GardenAllData data, int page);
    /*0x31c640*/ GardenData();
}

class GardenPlantData
{
    /*0x10*/ int thePlantRow;
    /*0x14*/ int thePlantColumn;
    /*0x18*/ PlantType thePlantType;
    /*0x1c*/ int growStage;
    /*0x20*/ int waterLevel;
    /*0x24*/ int love;
    /*0x28*/ long nextTime;
    /*0x30*/ GardenToolType needTool;
    /*0x34*/ int page;

    /*0x32f970*/ GardenPlantData();
}

class GardenAllData
{
    /*0x10*/ System.Collections.Generic.List<GardenPlantData> plantData;

    /*0x32f970*/ GardenAllData();
}

class GetNearestEntity : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ GetNearestEntity();
}

class InitZombieList
{
    static /*0x0*/ int multiplier;
    static /*0x4*/ int theMaxWave;
    static /*0x8*/ System.Collections.Generic.List<System.Collections.Generic.List<ZombieType>> zombieList;
    static /*0x10*/ System.Collections.Generic.HashSet<ZombieType> zombieTypeList;
    static /*0x18*/ bool[] allow;
    static /*0x20*/ int zombiePoint;
    static /*0x28*/ System.Collections.Generic.Dictionary<ZombieType, int> zombieWeights;
    static /*0x30*/ System.Collections.Generic.List<ZombieType> zombieInLandNormal;
    static /*0x38*/ System.Collections.Generic.List<ZombieType> zombieInLandHard;
    static /*0x40*/ System.Collections.Generic.List<ZombieType> zombieInPoolNormal;
    static /*0x48*/ System.Collections.Generic.List<ZombieType> zombieInPoolHard;
    static /*0x50*/ System.Collections.Generic.List<ZombieType> zombieInTravel_water;
    static /*0x58*/ System.Collections.Generic.List<ZombieType> zombieInTravel_snow;
    static /*0x60*/ System.Collections.Generic.List<ZombieType> zombieInTravel_land;

    static /*0x4fee30*/ InitZombieList();
    static /*0x4f6cf0*/ void InitZombie(LevelType theLevelType, int theLevelNumber, SceneType sceneType, int theSurvivalRound);
    static /*0x4febf0*/ void UltimateBoss(int currentWave);
    static /*0x4feb00*/ void TryAddBoss(ZombieType zombieType, int currentWave, int minWave);
    static /*0x4faef0*/ bool ShootingLimit(ZombieType theZombieType, int wave);
    static /*0x4fc500*/ bool TowerLimit(ZombieType theZombieType, int wave);
    static /*0x4fed50*/ bool WheatProtectionLimit(ZombieType theZombieType, int wave);
    static /*0x4e9af0*/ int AddZombieToList(ZombieType zombieType, int wave);
    static /*0x4f5ed0*/ int GetPoint(ZombieType zombieType);
    static /*0x4fbb50*/ void SurvivalZombieTypeSpawn(int theLevelNumber, int theRound, SceneType sceneType);
    static /*0x4f8f50*/ void SetTravelZombie(int theLevel, int theRound, SceneType sceneType);
    static /*0x4fd190*/ void TravelLandGroup(int group);
    static /*0x4fe630*/ void TravelWaterGroup(int group);
    static /*0x4ea100*/ void AdvantureZombieTypeSpawn(int theLevelNumber);
    static /*0x4f8d50*/ void SetAllowZombieTypeSpawn(LevelType theLevelType, int theLevelNumber);
    static /*0x4f7e80*/ void NewAdvSpawner(int theLevelNumber);
    static /*0x4e8970*/ void AbyssLevelSpawner(int theLevelNumber);
    static /*0x4fafb0*/ void SkinLevelSpawner(int theLevelNumber);
    static /*0x4fc5c0*/ void TravelAdvSpawner(int theLevelNumber);
    static /*0x4ed8f0*/ void AllowZombies(System.Collections.Generic.List<ZombieType> zombieTypes);
    static /*0x4eda40*/ void ChallengeSpawner(int theLevelNumber);
    static /*0x4f6280*/ System.Collections.Generic.List<ZombieType> GetRandomZombiesFromLandNormal();
    static /*0x4f6090*/ System.Collections.Generic.List<ZombieType> GetRandomZombiesFromLandHard();
    static /*0x4f6630*/ System.Collections.Generic.List<ZombieType> GetRandomZombiesFromPoolNormal();
    static /*0x4f6440*/ System.Collections.Generic.List<ZombieType> GetRandomZombiesFromPoolHard();
    static /*0x4f69d0*/ System.Collections.Generic.List<ZombieType> GetTravelZombieWater();
    static /*0x4f67f0*/ System.Collections.Generic.List<ZombieType> GetTravelZombieLand();
    static /*0x4f8520*/ ZombieType PickZombie();
    static /*0x4f6b90*/ void InitList();
    static /*0x4f7b60*/ void LandNormal();
    static /*0x4f79f0*/ void LandHard();
    static /*0x4fb7d0*/ void SnowHard();
    static /*0x4f89c0*/ void PoolNormal();
    static /*0x4f8850*/ void PoolHard();
    static /*0x4f8ce0*/ void RoofHard();
    static /*0x4fe7e0*/ void TravelWater();
    static /*0x4fe200*/ void TravelUltimate(int count);
    static /*0x4fe090*/ void TravelLand();
    static /*0x4ed1e0*/ void AllowNormal();
    static /*0x4ecab0*/ void AllowDay();
    static /*0x4ec930*/ void AllowDayNormal();
    static /*0x4ece40*/ void AllowNightNormal();
    static /*0x4ecf90*/ void AllowNight();
    static /*0x4ecce0*/ void AllowEliteNight();
    static /*0x4ed290*/ void AllowPlantZombie();
    static /*0x4ec6c0*/ void AllowAllTravel();
    static /*0x4ed450*/ void AllowUltimate(int count);
}

class Lawnf : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<PlantType, string> PlantNameDic;

    static /*0x50f1e0*/ Lawnf();
    static /*0x503da0*/ float[] CalculateProjectileParameters(UnityEngine.Vector2 startPosition, float t1, UnityEngine.Vector2 firstPlace, float t2, UnityEngine.Vector2 secondPlace, float flightTime);
    static /*0x503f20*/ float[] CalculateProjectileWithSpeed(UnityEngine.Vector2 projetilePosition, UnityEngine.Vector2 targetVelocity, UnityEngine.Vector2 targetCurrentPosition, float flightTime);
    static /*0x503eb0*/ UnityEngine.Vector2 CalculateProjectileWithGravity(UnityEngine.Vector2 projectilePosition, UnityEngine.Vector2 targetVelocity, UnityEngine.Vector2 targetCurrentPosition, float flightTime, float gravity);
    static /*0x50cfa0*/ void SetBulletTarget(Bullet bullet, UnityEngine.Vector2 projetilePosition, UnityEngine.Vector2 targetVelocity, UnityEngine.Vector2 targetCurrentPosition, float flightTime);
    static /*0x50e870*/ bool ValueBetween(float min, float value, float max);
    static /*0x50ac60*/ UnityEngine.Vector2 GetRandomGrid(int column, int row, ref int Row, int columnRange, int rowRange);
    static /*0x509b50*/ int GetPlantCount(PlantType theSeedType, Board board);
    static /*0x50a130*/ System.Collections.Generic.List<Plant> GetPlants(PlantType theSeedType, Board board);
    static /*0x5082a0*/ Plant GetCertainPlant(int theColumn, int theRow, PlantType thePlantType, Board board);
    static /*0x507450*/ System.Collections.Generic.List<Plant> GetAllPlants();
    static /*0x507620*/ System.Collections.Generic.List<Zombie> GetAllZombies();
    static /*0x50e920*/ void ZombieExplode(UnityEngine.Vector2 position, Board board, bool isMindControlled, int theRow, Plant.DamageType damageType);
    static /*0x50e260*/ bool TravelUnlockedPlant(int i);
    static /*0x50dbd0*/ bool TravelAdvanced(int i);
    static /*0x50dae0*/ bool TravelAdvanced(AdvBuff buff);
    static /*0x50e080*/ bool TravelUltimate(int i);
    static /*0x50e170*/ bool TravelUltimate(UltiBuffs i);
    static /*0x50df90*/ int TravelUltimateLevel(int index);
    static /*0x50dd90*/ bool TravelDebuff(int i);
    static /*0x50dcc0*/ bool TravelCurse();
    static /*0x506360*/ bool EveBalaced();
    static /*0x50b5c0*/ System.Collections.Generic.List<Plant> GetRangePlants(int theColumn, int theRow, int range);
    static /*0x506900*/ System.Collections.Generic.List<Plant> Get3x3Plants(int theColumn, int theRow);
    static /*0x5066c0*/ System.Collections.Generic.List<Plant> Get1x1Plants(int theColumn, int theRow);
    static /*0x50d090*/ DroppedCard SetDroppedCard(UnityEngine.Vector2 position, PlantType theSeedType, int theSeedCost);
    static /*0x50c7c0*/ bool IsTravelLevel(LevelType theLevelType, int theLevelNumber);
    static /*0x50e880*/ bool WithTravelBuff(LevelType theLevelType, int theLevelNumber);
    static /*0x506630*/ void FastBuffs(TravelMgr travel);
    static /*0x50d6f0*/ void SetWaterSplat(UnityEngine.Vector2 position, UnityEngine.Vector2 scale, int row);
    static /*0x50bab0*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> GetSprites(UnityEngine.GameObject gameObject);
    static /*0x5084a0*/ System.Collections.Generic.List<UnityEngine.GameObject> GetChilds(UnityEngine.Transform transform);
    static /*0x50da00*/ void SetZombieHealth(Zombie zombie, float ratio);
    static /*0x50c580*/ bool IsCurrentAnimationComplete(UnityEngine.Animator animator, int layer);
    static /*0x50f0e0*/ bool ZombieWithIron(Zombie zombie);
    static /*0x505ed0*/ CardUI CreateCard(PlantType theSeedType, UnityEngine.Vector2 position);
    static /*0x5061a0*/ IZECard CreateZombieCardCard(ZombieType theZombieType, UnityEngine.Vector2 position);
    static /*0x504090*/ void ChangeCardSprite(PlantType theSeedType, UnityEngine.GameObject card);
    static /*0x50d270*/ void SetMusic(Board board);
    static /*0x509290*/ int GetMagnetValue(BucketType bucketType);
    static /*0x508760*/ float GetGloveCD();
    static /*0x505b60*/ void ConnectPlant(int column);
    static /*0x5058d0*/ void ClearPlant(PlantType thePlantType, Board board);
    static /*0x50a310*/ UnityEngine.Vector2Int GetRandomBox(Board board);
    static /*0x50a360*/ System.Collections.Generic.List<UnityEngine.Vector2Int> GetRandomBoxes(Board board, int count);
    static /*0x50b160*/ ZombieType GetRandomUltimateZombie(System.Collections.Generic.List<ZombieType> excludeTypes, System.Collections.Generic.List<ZombieType> extraTypes);
    static /*0x50a4f0*/ ZombieType GetRandomBungiType(bool ultimate);
    static /*0x509c90*/ UnityEngine.Vector2 GetPlantPosition(Board board, int theColumn, int theRow, PlantType theSeedType, UnityEngine.Vector2 pos);
    static /*0x507800*/ System.Collections.Generic.List<Plant> GetBejeweledConnect(Plant plant);
    static /*0x509f50*/ Plant GetPlant(int theColumn, int theRow, Board board);
    static /*0x5063c0*/ void ExchangePlant(Plant plant1, Plant plant2, Board board);
    static /*0x50cbd0*/ PrizeMgr SetAward(Board board, UnityEngine.Vector2 position, bool killZombie);
    static /*0x50b950*/ int GetScaryPotNum(Board board);
    static /*0x50af00*/ System.Collections.Generic.List<PlantType> GetRandomPlant();
    static /*0x508b30*/ PlantType GetHappyRandomPlantType(Board board);
    static /*0x50ca70*/ bool PresentLim(PlantType theSeedType);
    static /*0x50aeb0*/ int GetRandomPlantLevel();
    static /*0x5058a0*/ int CheckPlantClass(PlantType thePlantType);
    static /*0x50c6c0*/ bool IsSuperPlant(PlantType thePlantType);
    static /*0x50c610*/ bool IsSecondPlant(PlantType thePlantType);
    static /*0x50c570*/ bool IsBasicPlant(PlantType thePlantType);
    static /*0x50c800*/ bool IsUltiPlant(PlantType thePlantType);
    static /*0x503d90*/ bool BannedInAbyss(PlantType thePlantType);
    static /*0x506c00*/ AbyssStatistic GetAbyssStatistic(Board board);
    static /*0x50bca0*/ int GetSuperPlantCount(Board board);
    static /*0x5099f0*/ int GetPlantCount(Board board);
    static /*0x50be30*/ int GetUltiPlantCount(Board board);
    static /*0x509ec0*/ int GetPlantUpgradeCost(PlantType thePlantType, int targetLevel);
    static /*0x50c170*/ int GetUpgradedPlantCost(PlantType thePlantType, int targetLevel);
    static /*0x504640*/ bool CheckIfPlantUnlock(PlantType thePlantType);
    static /*0x50b8c0*/ UnityEngine.Quaternion GetRotateFromSpeed(UnityEngine.Vector2 direction);
    static /*0x50c210*/ UnityEngine.Vector2 GetVectorFromQuaternion(UnityEngine.Quaternion quaternion);
    static /*0x50df10*/ bool TravelHell();
    static /*0x50de80*/ bool TravelEndless();
    static /*0x50cb50*/ bool RogueLevel();
    static /*0x50bfc0*/ System.Collections.Generic.List<PlantType> GetUltimatePlants();
    static /*0x507260*/ System.Collections.Generic.List<PlantType> GetAllPlantTypes();
    static /*0x50c410*/ bool InDodgeStatus(ZombieStatus zombieStatus);
    static bool TryGetType<EnumType>(int id, ref EnumType value);
    static /*0x50c930*/ void LessThan(int min, ref int value);
    static /*0x50c940*/ void MoreThan(int max, ref int value);
    static /*0x50c910*/ void LessThan(float min, ref float value);
    static /*0x17e030*/ System.Collections.Generic.Dictionary<TKey, Tvalue> GetDict<TKey, Tvalue>(string path);
    static /*0x50dac0*/ bool TowerPlant(PlantType thePlantType);
    static /*0x509300*/ int GetMowerCount(Board board);
    static /*0x50e350*/ int TryGetStrikeDamage(float dmg);
    static /*0x5086a0*/ CrackStatus GetCrackStatus(float value, float fullValue);
    static /*0x504330*/ void ChangeSprite(float value, float fullValue, UnityEngine.GameObject obj);
    static /*0x509150*/ bool GetKeyDown(UnityEngine.KeyCode keyCode);
    static /*0x5091f0*/ bool GetKey(UnityEngine.KeyCode keyCode);
    static /*0x508250*/ float GetBoxXFromColumn(int theColumn);
    static /*0x508270*/ float GetBoxYFromRow(int theRow, int rowNum);
    static /*0x50b930*/ int GetRowFromY(float y);
    static /*0x508680*/ int GetColumnFromX(float x);
    static /*0x507f00*/ UnityEngine.Bounds GetBounds(UnityEngine.Vector2Int box, int rowNum);
    static /*0x50c4b0*/ bool InLandStatus(ZombieStatus status);
    static /*0x509460*/ int GetMultiply(float a, float b);
    static /*0x50e440*/ bool UnlockRandomTravelBuff(Board board);
    static /*0x50c950*/ bool NearPlant3x3(Plant centerPlant, UnityEngine.Vector2Int position, PlantType plantType);
    static /*0x506e40*/ AirProjectile GetAirProjectile(UnityEngine.Vector2 center, float r, UnityEngine.LayerMask layerMask);
    static /*0x506ff0*/ System.Collections.Generic.List<AirProjectile> GetAirProjectiles(UnityEngine.Vector2 center, float r, UnityEngine.LayerMask layerMask);
    static /*0x5097d0*/ Zombie GetNearestZombie(Board board, UnityEngine.Vector2 position, System.Func<Zombie, bool> condition);
    static /*0x50c370*/ float GetZombieY(float x, int row);
    static /*0x50c550*/ bool InRange(float a, float range1, float range2);
    static /*0x17baf0*/ System.Collections.Generic.List<T> GetRandom<T>(System.Collections.Generic.List<T> list, int count);
    static /*0x509470*/ string GetName(PlantType thePlantType);
    /*0x31c640*/ Lawnf();

    class <>c
    {
        static /*0x0*/ Lawnf.<> <>9;
        static /*0x8*/ System.Predicate<PlantType> <>9__53_0;

        static /*0x51da20*/ <>c();
        /*0x32f970*/ <>c();
        /*0x51d560*/ bool <GetHappyRandomPlantType>b__53_0(PlantType p);
    }

    class <>c__DisplayClass44_0
    {
        /*0x10*/ System.Collections.Generic.List<ZombieType> excludeTypes;

        /*0x32f970*/ <>c__DisplayClass44_0();
        /*0x51d920*/ bool <GetRandomUltimateZombie>b__0(ZombieType p);
    }

    class <>c__DisplayClass6_0
    {
        /*0x10*/ PlantType theSeedType;

        /*0x32f970*/ <>c__DisplayClass6_0();
        /*0x35c700*/ bool <GetPlantCount>b__0(Plant p);
    }

    class <>c__DisplayClass7_0
    {
        /*0x10*/ PlantType theSeedType;

        /*0x32f970*/ <>c__DisplayClass7_0();
        /*0x35c700*/ bool <GetPlants>b__0(Plant p);
    }

    class <>c__DisplayClass97_0
    {
        /*0x10*/ Plant centerPlant;
        /*0x18*/ PlantType plantType;

        /*0x32f970*/ <>c__DisplayClass97_0();
        /*0x51d980*/ bool <NearPlant3x3>b__0(Plant plant);
    }
}

class LayerMaskMgr : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.LayerMask plantBulletExclude;
    static /*0x4*/ UnityEngine.LayerMask zombieBulletExclude;
    static /*0x8*/ UnityEngine.LayerMask dreamBulletExclude;
    static /*0xc*/ UnityEngine.LayerMask plantExclude;
    static /*0x10*/ UnityEngine.LayerMask zombieExclude;
    static /*0x14*/ UnityEngine.LayerMask hypnoZombieExclude;
    static /*0x18*/ UnityEngine.LayerMask BulletLayer;
    static /*0x1c*/ UnityEngine.LayerMask ZombieBulletLayer;
    static /*0x20*/ UnityEngine.LayerMask MindControlledZombie;
    static /*0x24*/ UnityEngine.LayerMask DreamInclude;

    static /*0x50f270*/ void InitLayer();
    /*0x31c640*/ LayerMaskMgr();
}

class LevelName2 : UnityEngine.MonoBehaviour
{
    static /*0x0*/ LevelName2 Instance;

    /*0x31c640*/ LevelName2();
    /*0x50f780*/ void Awake();
}

class LevelName3 : UnityEngine.MonoBehaviour
{
    static /*0x0*/ LevelName3 Instance;

    /*0x31c640*/ LevelName3();
    /*0x50f7e0*/ void Awake();
}

class MapDataReader
{
    static /*0x50f840*/ MapData GetMapData(LevelType levelType, int level);
}

class MapData
{
    /*0x10*/ int Wave;
    /*0x18*/ string SceneType;
    /*0x20*/ System.Collections.Generic.List<ZombieType> allowZombies;

    /*0x50fa50*/ MapData();
}

class MapData_cs
{
    static /*0x0*/ System.Collections.Generic.Dictionary<SceneType, string> MapPath;
    static /*0x8*/ System.Collections.Generic.Dictionary<SceneType, string> SceneName;

    static /*0x511570*/ MapData_cs();
    static /*0x50fad0*/ string GetMapPath(SceneType sceneType);
    static /*0x510170*/ SceneType GetTravelSceneType(int round);
    static /*0x50fb80*/ SceneType GetQuickTravelSceneType(int round);
    static /*0x50fc90*/ SceneType GetRandomTravelSceneType();
    static /*0x50fbf0*/ SceneType GetRandomTravelSceneType(int level);
    static /*0x510080*/ SceneType GetRogueSceneType(CampType campType, int level, int round);
    static /*0x5101c0*/ void SceneSettings(Board board, SceneType sceneType);
}

class PlayerShootingData
{
    static /*0x0*/ System.Collections.Generic.List<PlayerWeaponType> UnlockedWeapons;
    static /*0x8*/ int arrivedLevel;
    static /*0x10*/ System.Collections.Generic.Dictionary<PlayerWeaponBuff, System.ValueTuple<PlayerWeaponType, System.Action<PlayerWeapon>>> buffActions;
    static /*0x18*/ System.Collections.Generic.Dictionary<PlayerWeaponBuff, string> BuffData;
    static /*0x20*/ System.Collections.Generic.Dictionary<PlayerWeaponType, string> EvolutionDescription;
    static /*0x28*/ System.Collections.Generic.Dictionary<PlayerWeaponType, System.ValueTuple<int, float, float>> WeaponDataDic;
    static /*0x30*/ System.Collections.Generic.Dictionary<PlayerWeaponType, PlantType> WeaponPlantPairs;
    static /*0x38*/ System.Collections.Generic.Dictionary<PlayerWeaponType, PlayerWeaponBuff[]> _weaponBuffsMap;
    static /*0x40*/ System.Collections.Generic.Dictionary<PlayerBuff, System.ValueTuple<string, int>> PlayerDescription;

    static /*0x512f80*/ PlayerShootingData();
    static /*0x512f40*/ int GetWave(int level);
    /*0x32f970*/ PlayerShootingData();

    class <>c
    {
        static /*0x0*/ PlayerShootingData.<> <>9;

        static /*0x51db00*/ <>c();
        /*0x32f970*/ <>c();
        /*0x51d6e0*/ void <.cctor>b__11_0(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_1(PlayerWeapon w);
        /*0x51d720*/ void <.cctor>b__11_2(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_3(PlayerWeapon w);
        /*0x51d6e0*/ void <.cctor>b__11_4(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_5(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_6(PlayerWeapon w);
        /*0x51d720*/ void <.cctor>b__11_7(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_8(PlayerWeapon w);
        /*0x51d6e0*/ void <.cctor>b__11_9(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_10(PlayerWeapon w);
        /*0x51d720*/ void <.cctor>b__11_11(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_12(PlayerWeapon w);
        /*0x51d780*/ void <.cctor>b__11_13(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_14(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_15(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_16(PlayerWeapon w);
        /*0x51d7d0*/ void <.cctor>b__11_17(PlayerWeapon w);
        /*0x51d850*/ void <.cctor>b__11_18(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_19(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_20(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_21(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_22(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_23(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_24(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_25(PlayerWeapon w);
        /*0x51d870*/ void <.cctor>b__11_26(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_27(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_28(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_29(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_30(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_31(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_32(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_33(PlayerWeapon w);
        /*0x51d700*/ void <.cctor>b__11_34(PlayerWeapon w);
        /*0x51d7a0*/ void <.cctor>b__11_35(PlayerWeapon w);
        /*0x51d750*/ void <.cctor>b__11_36(PlayerWeapon w);
    }
}

enum PlayerBuff
{
    Defence = 0,
    ZombieHelp = 1,
    LevelUp = 2,
    Refresh = 3,
    BigStar = 4,
    UltimateCactus = 5,
    Solar = 6,
    Sun = 7,
    Turn = 8,
    Weapons1 = 9,
    Weapons2 = 10,
    Weapons3 = 11,
    Weapons4 = 12,
    DamageFromRefresh = 13,
    CheapRefresh = 14,
    Money = 15,
    DamageLessHealth = 16,
    Boss = 17,
    SunFromRefresh = 18,
    LevelUpWeapon = 19,
    Invincible = 20,
    BulletTime = 21,
}

enum PlayerWeaponType
{
    Pea = 0,
    Puff = 1,
    Star = 2,
    Fume = 3,
    Gloom = 4,
    WallNut = 5,
    Laser = 6,
    BigLaser = 7,
    Torch = 8,
    Doom = 9,
    Sword = 10,
}

enum PlayerWeaponBuff
{
    GetNewWeapon = 0,
    Pea_maganize = 1,
    Pea_count = 2,
    Pea_damage = 3,
    Pea_shootSpeed = 4,
    Pea_loadSpeed = 5,
    Puff_maganize = 6,
    Puff_count = 7,
    Puff_shootSpeed = 8,
    Puff_loadSpeed = 9,
    Star_loadSpeed = 10,
    Star_damage = 11,
    Star_count = 12,
    Fume_damage = 13,
    Fume_length = 14,
    Fume_height = 15,
    Gloom_damage = 16,
    Gloom_loadSpeed = 17,
    Gloom_range = 18,
    WallNut_maganize = 19,
    WallNut_damage = 20,
    WallNut_shootSpeed = 21,
    WallNut_loadSpeed = 22,
    Laser_damage = 23,
    Laser_loadSpeed = 24,
    Laser_count = 25,
    BigLaser_damage = 26,
    BigLaser_count = 27,
    BigLaser_loadSpeed = 28,
    Torch_damage = 29,
    Torch_count = 30,
    Torch_loadSpeed = 31,
    Doom_damage = 32,
    Doom_count = 33,
    Doom_loadSpeed = 34,
    Sword_damage = 35,
    Sword_count = 36,
    Sword_range = 37,
}

class PotEffects
{
    static /*0x515f30*/ void CabbagePotEffect(Plant cabbage, int theColumn, int theRow, float originalValue, float targetValue);
    static /*0x516160*/ void CornPotEffect(Plant corn, int theColumn, int theRow, int originalValue, int targetValue);
    static /*0x516370*/ void MelonPotEffect(Plant melon, int theColumn, int theRow);
    /*0x32f970*/ PotEffects();
}

class QuickTravel
{
    /*0x32f970*/ QuickTravel();
}

class RandomVectorGenerator : UnityEngine.MonoBehaviour
{
    static /*0x516660*/ UnityEngine.Vector2[] GenerateRandomVectors(int numberOfVectorsToGenerate, float minX, float maxX, float minY, float maxY, float minDistance);
    /*0x31c640*/ RandomVectorGenerator();
}

class ScaryPotManager : UnityEngine.MonoBehaviour
{
    static /*0x518c40*/ void SetPots(LevelType theBoardType, ChallengeLevel theBoardLevel, Board board);
    static /*0x518710*/ void SetPVPPots();
    static /*0x517770*/ ZombieType GetRandomZombieType();
    static /*0x518880*/ void SetPots(System.Collections.Generic.Queue<PlantType> plantTypes, System.Collections.Generic.Queue<ZombieType> zombieTypes, int startColumn, int numberOfColumns, int numberOfRows, int greenCount);
    static /*0x517670*/ System.Collections.Generic.Queue<PlantType> GetPlantTypes(ChallengeLevel level);
    static /*0x518610*/ System.Collections.Generic.Queue<ZombieType> GetZombieTypes(ChallengeLevel level);
    static /*0x516830*/ System.Collections.Generic.List<PlantType> GetPlantPool(ChallengeLevel level);
    static /*0x517990*/ System.Collections.Generic.List<ZombieType> GetZombiePool(ChallengeLevel level);
    /*0x31c640*/ ScaryPotManager();

    class <>c
    {
        static /*0x0*/ ScaryPotManager.<> <>9;
        static /*0x8*/ System.Predicate<ZombieType> <>9__2_0;

        static /*0x51da90*/ <>c();
        /*0x32f970*/ <>c();
        /*0x51d670*/ bool <GetRandomZombieType>b__2_0(ZombieType p);
    }
}

class ShootingData
{
    static /*0x0*/ System.Collections.Generic.List<System.Collections.Generic.List<PlantType>> UpgradeRoute_7;
    static /*0x8*/ System.Collections.Generic.Dictionary<PlantType, int> UpgradeCost_7;
    static /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<PlantType>> UpgradeRoute_6;
    static /*0x18*/ System.Collections.Generic.Dictionary<PlantType, int> UpgradeCost_6;
    static /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<PlantType>> UpgradeRoute_Chess;
    static /*0x28*/ System.Collections.Generic.Dictionary<PlantType, int> UpgradeCost_Chess;

    static /*0x51be60*/ ShootingData();
    static /*0x519a60*/ System.Collections.Generic.List<PlantType> GetPlants(ChallengeLevel level);
    static /*0x5193a0*/ bool Chess(CardUI card);
    static /*0x51a420*/ bool Shooting6(CardUI card);
    static /*0x51ad70*/ bool Shooting7(CardUI card);
    static /*0x51b780*/ System.Collections.Generic.List<Plant> TurnPlantsToNewPlants(CardUI card, PlantType newType, PlantType nextType);
    static /*0x519250*/ void ChangeCost(PlantType theSeedType, CardUI card);
    static /*0x519df0*/ void ResurrectionPlant(CardUI card);
    static /*0x518ff0*/ void ChangeCardSprite(PlantType theSeedType, CardUI card);

    class <>c__DisplayClass8_0
    {
        /*0x10*/ PlantType thePlantType;
        /*0x18*/ System.Func<Plant, bool> <>9__0;

        /*0x32f970*/ <>c__DisplayClass8_0();
        /*0x35c700*/ bool <Shooting6>b__0(Plant p);
    }

    class <>c__DisplayClass9_0
    {
        /*0x10*/ PlantType thePlantType;
        /*0x18*/ System.Func<Plant, bool> <>9__0;

        /*0x32f970*/ <>c__DisplayClass9_0();
        /*0x35c700*/ bool <Shooting7>b__0(Plant p);
    }
}

class SlowTrigger : UnityEngine.MonoBehaviour
{
    static /*0x0*/ SlowTrigger Instance;

    /*0x31c640*/ SlowTrigger();
    /*0x5342d0*/ void Awake();
}

class Statistics : UnityEngine.MonoBehaviour
{
    /*0x31c640*/ Statistics();
}

class Touch : UnityEngine.MonoBehaviour
{
    static /*0x534330*/ void CheckTouchUp();
    /*0x31c640*/ Touch();
}

class TravelDictionary
{
    static /*0x0*/ System.Collections.Generic.Dictionary<AdvBuff, PlantType> AdvBuffPlantPairs;

    static /*0x534620*/ TravelDictionary();
}

class TypeMgr
{
    static /*0x0*/ System.Collections.Generic.HashSet<PlantType> SnowPlants;
    static /*0x8*/ System.Collections.Generic.HashSet<ZombieType> BossZombies;
    static /*0x10*/ System.Collections.Generic.HashSet<ZombieType> LeaderZombies;
    static /*0x18*/ System.Collections.Generic.HashSet<PlantType> UncrashablePlants;
    static /*0x20*/ System.Collections.Generic.HashSet<ZombieType> UltiZombie_level_a;
    static /*0x28*/ System.Collections.Generic.HashSet<ZombieType> UltiZombie_level_b;
    static /*0x30*/ System.Collections.Generic.HashSet<ZombieType> UltiZombie_level_c;
    static /*0x38*/ System.Collections.Generic.HashSet<ZombieType> UltieZombie_level_water;
    static /*0x40*/ System.Collections.Generic.HashSet<PlantType> RedPlant;
    static /*0x48*/ System.Collections.Generic.HashSet<PlantType> ClassicPlant;

    static /*0x537380*/ TypeMgr();
    static /*0x534bd0*/ void GetPlantTag(Plant plant);
    static /*0x536770*/ bool IsSnowPlant(PlantType theSeedType);
    static /*0x535a60*/ bool IsFirePlant(PlantType theSeedType);
    static /*0x535cb0*/ bool IsIcePlant(PlantType theSeedType);
    static /*0x5364c0*/ bool IsPuff(PlantType theSeedType);
    static /*0x5363b0*/ bool IsPot(PlantType thePlantType);
    static /*0x536450*/ bool IsPotatoMine(PlantType theSeedType);
    static /*0x534900*/ bool BigNut(PlantType theSeedType);
    static /*0x5360b0*/ bool IsNut(PlantType theSeedType);
    static /*0x5358b0*/ bool IsCaltrop(PlantType theSeedType);
    static /*0x536830*/ bool IsSpickRock(PlantType theSeedType);
    static /*0x536850*/ bool IsTallNut(PlantType theSeedType);
    static /*0x5365c0*/ bool IsPumpkin(PlantType theSeedType);
    static /*0x5368c0*/ bool IsTangkelp(PlantType theSeedType);
    static /*0x535f40*/ bool IsLily(PlantType theSeedType);
    static /*0x5369f0*/ bool IsWaterPlant(PlantType theSeedType);
    static /*0x536920*/ bool IsTorch(PlantType theSeedType);
    static /*0x5366d0*/ bool IsSmallRangeLantern(PlantType theSeedType);
    static /*0x536350*/ bool IsPlantern(PlantType theSeedType);
    static /*0x534b30*/ bool FlyingPlants(PlantType thePlantType);
    static /*0x5370d0*/ bool UmbrellaPlants(PlantType thePlantType);
    static /*0x5349e0*/ bool DoubleBoxPlants(PlantType thePlantType);
    static /*0x535f60*/ bool IsMagnetPlants(PlantType thePlantType);
    static /*0x5357f0*/ bool IsAirZombie(ZombieType theZombieType);
    static /*0x534850*/ bool AppearFreeZombie(ZombieType theZombieType);
    static /*0x536da0*/ bool NotRandomZombie(ZombieType theZombieType);
    static /*0x536bb0*/ bool NotRandomBungiZombie(ZombieType theZombieType);
    static /*0x537230*/ bool UselessHypnoZombie(ZombieType theZombieType);
    static /*0x534920*/ bool BigZombie(ZombieType theZombieType);
    static /*0x5372f0*/ bool WaterZombie(ZombieType theZombieType);
    static /*0x5359d0*/ bool IsDriverZombie(ZombieType theZombieType);
    static /*0x535c00*/ bool IsGargantuar(ZombieType theZombieType);
    static /*0x5370c0*/ bool UltimateZombie(ZombieType theZombieType);
    static /*0x534aa0*/ bool EliteZombie(ZombieType theZombieType);
    static /*0x5367f0*/ bool IsSpecialPlant(PlantType theSeedType);
    static /*0x535830*/ bool IsBossZombie(ZombieType theZombieType);
    static /*0x535ec0*/ bool IsLeaderZombie(ZombieType theZombieType);
    static /*0x537160*/ bool UncrashablePlant(Plant plant);
    static /*0x536f30*/ bool UltiZombie_level(ZombieType zombieType);
    static /*0x537040*/ bool UltiZombie_level_water(ZombieType zombieType);
    static /*0x535950*/ bool IsClassicPlant(PlantType thePlantType);
    /*0x32f970*/ TypeMgr();
}

class UIMgr : UnityEngine.MonoBehaviour
{
    static /*0x5396b0*/ void EnterGame(LevelType levelType, int levelNumber, int id, string name);
    static /*0x53b8f0*/ void EnterTravelGame(LevelType levelType, int levelNumber, int theRound);
    static /*0x53c200*/ SceneType GetSceneType(LevelType theLevelType, int theLevelNumber);
    static /*0x53a7f0*/ void EnterIZGame(int levelNumber, string name, SceneType sceneType);
    static /*0x53aee0*/ void EnterMainMenu();
    static /*0x538640*/ void BackToMenu();
    static /*0x5393e0*/ void EnterChallengeMenu();
    static /*0x5394d0*/ void EnterClassicTravel();
    static /*0x53b710*/ void EnterTravelAdv();
    static /*0x53bda0*/ void EnterTravelGame();
    static /*0x53b800*/ void EnterTravelChallenge();
    static /*0x538f50*/ void EnterAbyssMenu();
    static /*0x53be90*/ void EnterTreasureMenu();
    static /*0x53b620*/ void EnterTowerMenu();
    static /*0x53a700*/ void EnterIZEMenu();
    static /*0x53b530*/ void EnterSurvivalEMenu();
    static /*0x53c800*/ void MenuNormalSettings();
    static /*0x53b2c0*/ void EnterPauseMenu(int place);
    static /*0x538a50*/ void EVEAuto(int road);
    static /*0x538460*/ void BackToGame();
    static /*0x53ac70*/ void EnterLoseMenu(UnityEngine.GameObject obj);
    static /*0x53a670*/ void EnterHelpMenu();
    static /*0x53b1f0*/ OtherMenu EnterOtherMenu();
    static /*0x53b170*/ void EnterOptionMenu();
    static /*0x5395c0*/ void EnterExploreMenu();
    static /*0x539040*/ void EnterAchievement();
    static /*0x539130*/ void EnterAlmanac(bool changeMusic, bool changeStatus);
    static /*0x53c0d0*/ string GetMapName(LevelType theLevelType, int theLevelNumber);
    static /*0x53a3d0*/ void EnterGarden();
    static /*0x53bf80*/ void EnterZuma();
    /*0x31c640*/ UIMgr();
}

class UIResourcesLoader
{
    /*0x10*/ System.Collections.Generic.Dictionary<UIType, UnityEngine.GameObject> UIPrefabs;
    /*0x18*/ System.Collections.Generic.Stack<System.Collections.Generic.List<BaseMenu>> menuStack;

    /*0x53d070*/ UIResourcesLoader();
    /*0x53ccf0*/ BaseMenu Push(UIType uIType, UnityEngine.Transform transform, bool group);
    /*0x53c930*/ System.Collections.Generic.List<BaseMenu> Peak();
    /*0x53ca30*/ void Pop();
    /*0x53c9d0*/ void PopAll();
}

enum UIType
{
    MainMenu = 0,
    MainMenu_travel = 1,
    LoseMenu = 2,
    OtherMenu = 3,
    OptionMenu = 4,
    NoticePauseMenu = 5,
    AchievementMenu = 6,
    ChallengeMenu = 7,
    IZMenu = 8,
    IZBottomMenu = 9,
    SurvivalMenu = 10,
    ExploreMenu = 11,
    TravelAdvantureMenu = 12,
    TravelGameMenu = 13,
    TravelChallengeMenu = 14,
    TravelMenu = 15,
    PauseMenu = 16,
    PauseMenu_buff = 17,
    PauseMenu_checkQuit = 18,
    PauseMenu_checkRestart = 19,
    GardenUI = 20,
    ZumaUI = 21,
    InGameUI = 22,
    InGameUI_IZ = 23,
    Almanac = 24,
    WarningMenu_travel = 25,
    WarningMenu_editor = 26,
    WarningMenu_custom = 27,
    OppsiteMenu = 28,
    TravelStartMenu = 29,
    TravelStore = 30,
    TravelBuffMenu = 31,
    TravelLookMenu = 32,
    TravelCurseMenu = 33,
    LevelSaveMenu = 34,
    SellConfirm = 35,
    BuyConfirm = 36,
    AbyssMenu = 37,
    AbyssMenu2 = 38,
    AbyssStoreMenu = 39,
    AbyssDevelopMenu = 40,
    AbyssCheckSellBuff = 41,
    AbyssSettlementMenu = 42,
    AbyssCheckReset = 43,
    AbyssSelectDifficulty = 44,
    AbyssHelpMenu = 45,
    AbyssBagMenu = 46,
    AbyssCheckInBag = 47,
    RogueStart = 48,
    RogueSelectMenu = 49,
    RogueCrisisMenu = 50,
    RogueCardMenu = 51,
    JigsawHelpMenu = 52,
    ShootingMenu = 53,
    FruitNinjaMenu = 54,
    PlayerShootingMenu = 55,
    GardenWorldUI = 56,
    TowerMenu = 57,
    TowerUpgradeMenu = 58,
    TreasureMainMenu = 59,
    TreasureWarehouseMenu = 60,
    TreasureStoreMenu = 61,
    TreasureConfirmMenu = 62,
    TreasureSettleMenu = 63,
    TreasureEquipmentMenu = 64,
    TreasureUpgradeMenu = 65,
    TreasureEvacuateMenu = 66,
    BigGardenUI = 67,
    GardenBagMenu = 68,
    PlantInfoMenu = 69,
    AlmanacMenu = 70,
    AlmanacPlantMenu = 71,
}

class WaveManager
{
    static /*0x53de00*/ int GetMaxWave(LevelType levelType, int level);
    static /*0x53e380*/ int GetNewAdvantureMaxWave(int levelNumber);
    static /*0x53e460*/ int InitAdvWave(int theLevelNumber);
    static /*0x53e550*/ int InitChallengeWave(int theLevelNumber);
    static /*0x53e710*/ int InitSurvivalWave(int theLevelNumber);
    static /*0x53e9a0*/ int InitTravelAdvWave(int theLevelNumber);
    static /*0x53e3f0*/ int InitAbyssWave(int theLevelNumber);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x53d190*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace VarietyFX
{
    class VarietyCycler : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.List<UnityEngine.GameObject> listOfEffects;
        /*0x28*/ float loopTimeLength;
        /*0x2c*/ float timeOfLastInstantiate;
        /*0x30*/ UnityEngine.GameObject instantiatedEffect;
        /*0x38*/ int effectIndex;

        /*0x53d540*/ VarietyCycler();
        /*0x53d270*/ void Start();
        /*0x53d3b0*/ void Update();
    }

    class VarietyLoop : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.GameObject chosenEffect;
        /*0x28*/ float loopTimeLimit;

        /*0x53d600*/ VarietyLoop();
        /*0x53d5c0*/ void Start();
        /*0x53d5c0*/ void PlayEffect();
        /*0x53d550*/ System.Collections.IEnumerator EffectLoop();

        class <EffectLoop>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ VarietyFX.VarietyLoop <>4__this;
            /*0x28*/ UnityEngine.GameObject <effectPlayer>5__2;

            /*0x32f460*/ <EffectLoop>d__4(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x538250*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x538420*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class VarietySceneSelect : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool GUIHide;

        /*0x31c640*/ VarietySceneSelect();
        /*0x53d9d0*/ void LoadSceneDemo1();
        /*0x53da30*/ void LoadSceneDemo2();
        /*0x53da90*/ void LoadSceneDemo3();
        /*0x53daf0*/ void LoadSceneDemo4();
        /*0x53db50*/ void LoadSceneDemo5();
        /*0x53dbb0*/ void LoadSceneDemo6();
        /*0x53dc10*/ void LoadSceneDemo7();
        /*0x53dc70*/ void LoadSceneDemo8();
        /*0x53dcd0*/ void LoadSceneDemo9();
        /*0x53d610*/ void LoadSceneDemo10();
        /*0x53d670*/ void LoadSceneDemo11();
        /*0x53d6d0*/ void LoadSceneDemo12();
        /*0x53d730*/ void LoadSceneDemo13();
        /*0x53d790*/ void LoadSceneDemo14();
        /*0x53d7f0*/ void LoadSceneDemo15();
        /*0x53d850*/ void LoadSceneDemo16();
        /*0x53d8b0*/ void LoadSceneDemo17();
        /*0x53d910*/ void LoadSceneDemo18();
        /*0x53d970*/ void LoadSceneDemo19();
        /*0x53dd30*/ void Update();
    }
}

namespace com
{
    namespace cyborgAssets
    {
        namespace internalIBP
        {
            class ObjectExtensions
            {
                static /*0x348b00*/ bool IsPrefab(UnityEngine.Object obj);
            }

            struct SerializedMethod
            {
                static string NameProp = "name";
                static string SignatureProp = "signature";
                static string ParametersProp = "parameters";
                static string UnsupportedArgs = "unsupportedArgs";
                /*0x10*/ string name;
                /*0x18*/ string signature;
                /*0x20*/ com.cyborgAssets.internalIBP.SerializedParameter[] parameters;
                /*0x28*/ string[] unsupportedArgs;
            }

            enum SerializedParameterType
            {
                Integer = 0,
                Boolean = 1,
                Float = 2,
                String = 3,
                Color = 4,
                ObjectReference = 5,
                Enum = 6,
                Vector2 = 7,
                Vector3 = 8,
                Vector4 = 9,
                Rect = 10,
                AnimationCurve = 11,
                Bounds = 12,
                Quaternion = 13,
                Vector2Int = 14,
                Vector3Int = 15,
                RectInt = 16,
                BoundsInt = 17,
            }

            struct SerializedParameter
            {
                static string NameProp = "name";
                static string TypeProp = "type";
                static string IntegerProp = "integerValue";
                static string BooleanProp = "booleanValue";
                static string FloatProp = "floatValue";
                static string StringProp = "stringValue";
                static string ColorProp = "colorValue";
                static string ObjectReferenceProp = "objectReferenceValue";
                static string EnumProp = "enumValue";
                static string Vector2Prop = "vector2Value";
                static string Vector3Prop = "vector3Value";
                static string Vector4Prop = "vector4Value";
                static string RectProp = "rectValue";
                static string AnimationCurveProp = "animationCurveValue";
                static string BoundsProp = "boundsValue";
                static string QuaternionProp = "quaternionValue";
                static string Vector2IntProp = "vector2IntValue";
                static string Vector3IntProp = "vector3IntValue";
                static string RectIntProp = "rectIntValue";
                static string BoundsInProp = "boundsInValue";
                static string UnsupportedProp = "unsupported";
                static string RealTypeProp = "realType";
                /*0x10*/ string name;
                /*0x18*/ com.cyborgAssets.internalIBP.SerializedParameterType type;
                /*0x19*/ bool unsupported;
                /*0x1c*/ int integerValue;
                /*0x20*/ bool booleanValue;
                /*0x24*/ float floatValue;
                /*0x28*/ string stringValue;
                /*0x30*/ UnityEngine.Color colorValue;
                /*0x40*/ UnityEngine.Object objectReferenceValue;
                /*0x48*/ string realType;
                /*0x50*/ int enumValue;
                /*0x54*/ UnityEngine.Vector2 vector2Value;
                /*0x5c*/ UnityEngine.Vector3 vector3Value;
                /*0x68*/ UnityEngine.Vector4 vector4Value;
                /*0x78*/ UnityEngine.Rect rectValue;
                /*0x88*/ UnityEngine.AnimationCurve animationCurveValue;
                /*0x90*/ UnityEngine.Bounds boundsValue;
                /*0xa8*/ UnityEngine.Quaternion quaternionValue;
                /*0xb8*/ UnityEngine.Vector2Int vector2IntValue;
                /*0xc0*/ UnityEngine.Vector3Int vector3IntValue;
                /*0xcc*/ UnityEngine.RectInt rectIntValue;
                /*0xdc*/ UnityEngine.BoundsInt boundsInValue;
            }
        }

        namespace inspectorButtonPro
        {
            class ButtonMonoBehavior : UnityEngine.MonoBehaviour
            {
                /*0x31c640*/ ButtonMonoBehavior();
            }

            class ButtonScriptableObject : UnityEngine.ScriptableObject
            {
                /*0x533ec0*/ ButtonScriptableObject();
            }

            interface IButtonAttribute
            {
                /*0x1803b0*/ string get_Error();
                /*0x17e620*/ bool PerformCheck(UnityEngine.Object obj);
            }

            class ProButtonAttribute : System.Attribute, com.cyborgAssets.inspectorButtonPro.IButtonAttribute
            {
                /*0x534220*/ ProButtonAttribute();
                /*0x534230*/ string get_Error();
                /*0x3ce290*/ bool PerformCheck(UnityEngine.Object obj);
            }

            class ProPlayButtonAttribute : System.Attribute, com.cyborgAssets.inspectorButtonPro.IButtonAttribute
            {
                /*0x534220*/ ProPlayButtonAttribute();
                /*0x5342a0*/ string get_Error();
                /*0x534260*/ bool PerformCheck(UnityEngine.Object obj);
            }
        }

        namespace internalIBPExample
        {
            class ExampleInspectorButtonMonoBehavior : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.GameObject[] targets;

                static /*0x534030*/ void LoadScene(int sceneIndex);
                /*0x31c640*/ ExampleInspectorButtonMonoBehavior();
                /*0x534000*/ string GetGameObjectName();
                /*0x5340e0*/ void SpecialAttack(float attackPower);
                /*0x533ed0*/ void DestroyAllEnemies();
            }

            class ExampleInspectorButtonScriptableObject : UnityEngine.ScriptableObject
            {
                /*0x533ec0*/ ExampleInspectorButtonScriptableObject();
                /*0x534160*/ float Add2Numbers(int a, int b);
                /*0x534170*/ void LoadScene(int sceneIndex);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 03D3DFBE840FDAEE112950E1C15EBB9586E6534A47A392BA9D49C51158DE5C3B;
    static /*0x14*/ <PrivateImplementationDetails> 08A65C194F7E52161DE20BA77479F1F3FAFBBB8AB5571A55B6160ADF895E7B3D;
    static /*0x38*/ <PrivateImplementationDetails> 0AA8E1336C8949318EC8B1D1A9F372435E8E2F95BD7B8C2F640A2F90912E525E;
    static /*0x50*/ <PrivateImplementationDetails> 0C061DC20B16A471B10578034B7EFE0FC65CD9DFB07136595270B9153C4C4B41;
    static /*0x6c*/ <PrivateImplementationDetails> 11EBA057836C376D81DEEA698FCBFA725C3DC1D149EBB361DE85DBB922B06F2C;
    static /*0x7c*/ <PrivateImplementationDetails> 16032D9B3134D1A45A41B7EA21B6528526A77ACB6A10845C264DF58705B9D3D8;
    static /*0x94*/ <PrivateImplementationDetails> 2429D53D54EA7B97AB4AD2B9202C6C5247A3CEEB0852E077D87A87D8407AE0D9;
    static /*0xa4*/ <PrivateImplementationDetails> 29E053C379B9E2C67A95EE3D762B8FF68732C117EF68D0E5F43E6ADB616AF435;
    static /*0xbc*/ <PrivateImplementationDetails> 2CE571A411D3611A576117D1C18F193008A96D0A0DA6A57D9B3E3662DF0B873F;
    static /*0xdc*/ <PrivateImplementationDetails> 2D13FFD1981F7B8FC2D1E38437E25A43F5890ED0AC516CE671BB59BC2DB19621;
    static /*0xe8*/ <PrivateImplementationDetails> 2DC88E92396FCF6B5F061569340F9A3FC32FA517983F1B5FF5AE10272EA8BA4E;
    static /*0xf4*/ <PrivateImplementationDetails> 353B71A5698DD314AA469E23F470F09835A6576C0D41FD926BD63B91086022C4;
    static /*0x158*/ <PrivateImplementationDetails> 4699A5C817EF0EDD622E28F747AF40890A66FBE4FE44E45D9BD0416F4C1CE029;
    static /*0x170*/ <PrivateImplementationDetails> 47A696487DD1E818E2E1E0C043C22CAD421DC3113043F9BA418EAAB2A8B882AB;
    static /*0x184*/ <PrivateImplementationDetails> 483CDEF851C82131F31E541647EC1075F1746D034C5BF8EFF5141D2B41048B33;
    static /*0x190*/ <PrivateImplementationDetails> 4C849C6A04ABA99DAA0046F412EACEE8448189A607ADCEFD4A42EC523DC44E21;
    static /*0x1a8*/ <PrivateImplementationDetails> 4CD685DEF9EA6EC701C6CAD2ADDB5D8A6FD908E47D731BB8F16F4171674E2B09;
    static /*0x1bc*/ <PrivateImplementationDetails> 4D24AAB50EC33EAB43D376A390307842EB38F6BC05F1B3A6731F4E235F81968E;
    static /*0x1c8*/ <PrivateImplementationDetails> 5541850543A0654D8E7223FF683E8C39C16E20566D2B63EB8926C5AC7119D98F;
    static /*0x1e8*/ <PrivateImplementationDetails> 5CA55D957A616CBAABACBBCE6E5CD0ECB9FF2D4D5557FC6CF05E9AD33CCD4885;
    static /*0x200*/ <PrivateImplementationDetails> 5E77CF4991ECCF11216CB22A25C530910DF0256F5A2D12C5657E8DBE11EB9236;
    static /*0x224*/ <PrivateImplementationDetails> 5FB959F1B937C22567D37E54F62DB79949D4C18750D875F0AE3D99B4F01BCE9C;
    static /*0x25c*/ <PrivateImplementationDetails> 60C81F9E3E57E2F3ED13F588185D65E0C33F656198AD6B5606156886A55A3032;
    static /*0x270*/ <PrivateImplementationDetails> 685DBFD809F7001DD41C0919A2E19655597A0A5D0F7BD810D5BBBC28DC5154CA;
    static /*0x5e17*/ <PrivateImplementationDetails> 69057598F0A98F0A916B0764E19D071217DA5C3CBAACB50C88DA42CEAB544BC5;
    static /*0x5e27*/ <PrivateImplementationDetails> 6BE766069E65CCA02F04F067846448C285E7024EAD538F616406238D996117F3;
    static /*0x5e37*/ <PrivateImplementationDetails> 7131CE8A8E89D0B47A87EA381E7D960D9A51A4E47267B2183E7B4B315A11E67C;
    static /*0x17759*/ <PrivateImplementationDetails> 7BD838AC8FA5D9025F61F2D0F88186997895AD4FD2DBE007A6660204E4EC0435;
    static /*0x17769*/ <PrivateImplementationDetails> 7F0DDE11D9480136B86363BFCA0BE6FAC2EBD957758D742E69E94054DFB860E8;
    static /*0x17775*/ <PrivateImplementationDetails> 88C0B71E5469E6E70A64D591A780B6ABA78FB13A00904C5C11F4092CF429D417;
    static /*0x17781*/ <PrivateImplementationDetails> 8B0B8AFD73C83FE46E523E8011C822ADCEB41979955117E17AC4EA5446215E1B;
    static /*0x177a1*/ <PrivateImplementationDetails> 8B872F4FA850F6A05E5E3C9CBE7452D0BC6A964D920C412F5859CDFD56B86A3B;
    static /*0x177b9*/ <PrivateImplementationDetails> 9290AB548294BA6BFDDD1E2EE079ABB3E02A463A085D6CFA86701AE11DAF4E85;
    static /*0x177c5*/ <PrivateImplementationDetails> 996D0B9055C2F8CC3A26FF228B8C668A1F7F957C0B0E961C7252D8FE603C9961;
    static /*0x177dd*/ <PrivateImplementationDetails> 9D065320CB380F8026DBD8618E109BDDBE91CF53C86A367BE07E648663591C95;
    static /*0x177e9*/ <PrivateImplementationDetails> AA1D64808B0CB5324AD7D3F1EC8996F13FB0E9583034329526AE9AB299B6D154;
    static /*0x17809*/ <PrivateImplementationDetails> B75BFAB405F0BCAE577AD3B047D607ED167945B6F49D947951C4265B5471962A;
    static /*0x17825*/ <PrivateImplementationDetails> B8027CE639E871C72CD95B4AFB432B992744FF36213B69CDD597750031709B2A;
    static /*0x17835*/ <PrivateImplementationDetails> C1D7A2DEEFC78B093A70ED10B2F7FBFC2F718DD708B34785A8DF6946CCAC4C05;
    static /*0x1784d*/ <PrivateImplementationDetails> CA06628AC2E34FFB0DB56EDFA98EE518D8078BA61DB73321ADA7BE12BE789ED4;
    static /*0x17869*/ <PrivateImplementationDetails> D392E39CB0653F757056DB01D7399BEAF96C50F0C9E1F75CCB9A3ED47D36EC51;
    static /*0x17875*/ <PrivateImplementationDetails> D72C0824A20D2FF108C84FF076298DD8C1FEA4B42396DA183AA8857F518C4E51;
    static /*0x17881*/ <PrivateImplementationDetails> D74660B0241A09D9ED7631D613C8BB72E9D4FC925C584D5203DBA7D203C9EC90;
    static /*0x1789d*/ <PrivateImplementationDetails> DDB8B8D2EC1B2082A1A21EA36FDB1C9987BD672EC2B4DA77A40E3B64BD5E995D;
    static /*0x178ad*/ <PrivateImplementationDetails> DFB4092AF07DE305203217B42CC23B90727B87D970CC39DD30B8D14EB8F896D0;
    static /*0x178d5*/ <PrivateImplementationDetails> E39F3C2F260617F3E0A448861B45455DF7B1EA72177E9D3258297CC55AD91132;
    static /*0x178e1*/ <PrivateImplementationDetails> E9D3F03399CBA55E1D164BD83B1E197A7BD893E9A793054F562433A2B093FC9B;
    static /*0x17945*/ <PrivateImplementationDetails> EE4BA88B31FB309BBB82C90353C879ED4DDBDBB9A6C38A6057F8020100FB9C4A;
    static /*0x17951*/ <PrivateImplementationDetails> EF9EA59815ECD3591C4713FE7BDF07767C0727BC0CDB6FFC414393B8565303E8;
    static /*0x17969*/ <PrivateImplementationDetails> F5E281A017EE9C2EE594C53EE1D85C58044F1F96D32D95209766005C3300318F;
    static /*0x17975*/ <PrivateImplementationDetails> FA0D922A2B761C99F400D9F6004CBCC4088122F46CDCC50A028DF7204DB119C0;
    static /*0x179a1*/ <PrivateImplementationDetails> FB7DF4CC245675695076A87E5DFF19451D9CE586DE803D965FDE323C2756D48B;
    static /*0x17a05*/ <PrivateImplementationDetails> FC5FC8320C68D22BE7DF067BF0F6D9D187F4CB2E83BC3329FC2A3A49B5647EFD;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=28
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=40
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=56
    {
    }

    struct __StaticArrayInitTypeSize=100
    {
    }

    struct __StaticArrayInitTypeSize=23463
    {
    }

    struct __StaticArrayInitTypeSize=71970
    {
    }
}
