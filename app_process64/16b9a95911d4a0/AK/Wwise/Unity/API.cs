class <Module>
{
}

class AkSoundEngine
{
    static string AkGameObjTypeString = "AkGameObj, AK.Wwise.Unity.MonoBehaviour";
    static int AK_SIMD_ALIGNMENT = 16;
    static int AK_BUFFER_ALIGNMENT = 16;
    static int AK_MAX_PATH = 260;
    static int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
    static string AK_OSCHAR_FMT = "%s";
    static uint AK_INVALID_PLUGINID = 4294967295;
    static ulong AK_INVALID_GAME_OBJECT = 18446744073709551615;
    static uint AK_INVALID_UNIQUE_ID = 0;
    static uint AK_INVALID_RTPC_ID = 0;
    static uint AK_INVALID_LISTENER_INDEX = 4294967295;
    static uint AK_INVALID_PLAYING_ID = 0;
    static uint AK_DEFAULT_SWITCH_STATE = 0;
    static int AK_INVALID_POOL_ID = -1;
    static int AK_DEFAULT_POOL_ID = -1;
    static uint AK_INVALID_AUX_ID = 0;
    static uint AK_INVALID_FILE_ID = 4294967295;
    static uint AK_INVALID_DEVICE_ID = 4294967295;
    static uint AK_INVALID_BANK_ID = 0;
    static uint AK_FALLBACK_ARGUMENTVALUE_ID = 0;
    static uint AK_INVALID_CHANNELMASK = 0;
    static uint AK_INVALID_OUTPUT_DEVICE_ID = 0;
    static uint AK_MIXER_FX_SLOT = 4294967295;
    static ulong AK_DEFAULT_LISTENER_OBJ = 0;
    static uint AK_DEFAULT_PRIORITY = 50;
    static uint AK_MIN_PRIORITY = 0;
    static uint AK_MAX_PRIORITY = 100;
    static uint AK_DEFAULT_BANK_IO_PRIORITY = 50;
    static double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;
    static uint AKCOMPANYID_AUDIOKINETIC = 0;
    static uint AK_LISTENERS_MASK_ALL = 4294967295;
    static int NULL = 0;
    static int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;
    static int AK_MAX_LANGUAGE_NAME_SIZE = 32;
    static int AKCOMPANYID_PLUGINDEV_MIN = 64;
    static int AKCOMPANYID_PLUGINDEV_MAX = 255;
    static int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;
    static int AKCOMPANYID_MCDSP = 256;
    static int AKCOMPANYID_WAVEARTS = 257;
    static int AKCOMPANYID_PHONETICARTS = 258;
    static int AKCOMPANYID_IZOTOPE = 259;
    static int AKCOMPANYID_CRANKCASEAUDIO = 261;
    static int AKCOMPANYID_IOSONO = 262;
    static int AKCOMPANYID_AUROTECHNOLOGIES = 263;
    static int AKCOMPANYID_DOLBY = 264;
    static int AKCOMPANYID_TWOBIGEARS = 265;
    static int AKCOMPANYID_OCULUS = 266;
    static int AKCOMPANYID_BLUERIPPLESOUND = 267;
    static int AKCOMPANYID_ENZIEN = 268;
    static int AKCOMPANYID_KROTOS = 269;
    static int AKCOMPANYID_NURULIZE = 270;
    static int AKCOMPANYID_SUPERPOWERED = 271;
    static int AKCOMPANYID_GOOGLE = 272;
    static int AKCOMPANYID_VISISONICS = 277;
    static int AKCODECID_BANK = 0;
    static int AKCODECID_PCM = 1;
    static int AKCODECID_ADPCM = 2;
    static int AKCODECID_XMA = 3;
    static int AKCODECID_VORBIS = 4;
    static int AKCODECID_WIIADPCM = 5;
    static int AKCODECID_PCMEX = 7;
    static int AKCODECID_EXTERNAL_SOURCE = 8;
    static int AKCODECID_XWMA = 9;
    static int AKCODECID_FILE_PACKAGE = 11;
    static int AKCODECID_ATRAC9 = 12;
    static int AKCODECID_VAG = 13;
    static int AKCODECID_PROFILERCAPTURE = 14;
    static int AKCODECID_ANALYSISFILE = 15;
    static int AKCODECID_MIDI = 16;
    static int AKCODECID_OPUSNX = 17;
    static int AKCODECID_CAF = 18;
    static int AKCODECID_AKOPUS = 19;
    static int AKCODECID_AKOPUS_WEM = 20;
    static int AKCODECID_MEMORYMGR_DUMP = 21;
    static int AKCODECID_SONY360 = 22;
    static int AKCODECID_BANK_EVENT = 30;
    static int AKCODECID_BANK_BUS = 31;
    static int AKPLUGINID_METER = 129;
    static int AKPLUGINID_RECORDER = 132;
    static int AKPLUGINID_IMPACTER = 184;
    static int AKPLUGINID_SYSTEM_OUTPUT_META = 900;
    static int AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META = 901;
    static int AKPLUGINID_AUDIO_OBJECT_PRIORITY_META = 902;
    static int AKEXTENSIONID_SPATIALAUDIO = 800;
    static int AKEXTENSIONID_INTERACTIVEMUSIC = 801;
    static int AKEXTENSIONID_MIDIDEVICEMGR = 802;
    static int AK_WAVE_FORMAT_VAG = 65531;
    static int AK_WAVE_FORMAT_AT9 = 65532;
    static int AK_WAVE_FORMAT_VORBIS = 65535;
    static int AK_WAVE_FORMAT_OPUSNX = 12345;
    static int AK_WAVE_FORMAT_OPUS = 12352;
    static int AK_WAVE_FORMAT_OPUS_WEM = 12353;
    static int WAVE_FORMAT_XMA2 = 358;
    static int AK_PANNER_NUM_STORAGE_BITS = 3;
    static int AK_POSSOURCE_NUM_STORAGE_BITS = 3;
    static int AK_SPAT_NUM_STORAGE_BITS = 3;
    static int AK_MAX_BITS_METERING_FLAGS = 5;
    static bool AK_ASYNC_OPEN_DEFAULT = false;
    static int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;
    static double AK_DEFAULT_LISTENER_POSITION_X = 0;
    static double AK_DEFAULT_LISTENER_POSITION_Y = 0;
    static double AK_DEFAULT_LISTENER_POSITION_Z = 0;
    static double AK_DEFAULT_LISTENER_FRONT_X = 0;
    static double AK_DEFAULT_LISTENER_FRONT_Y = 0;
    static double AK_DEFAULT_LISTENER_FRONT_Z = 1;
    static double AK_DEFAULT_TOP_X = 0;
    static double AK_DEFAULT_TOP_Y = 1;
    static double AK_DEFAULT_TOP_Z = 0;
    static double AK_SA_EPSILON = 0.001;
    static double AK_SA_DIFFRACTION_EPSILON = 0.002;
    static double AK_SA_PLANE_THICKNESS = 0.01;
    static double AK_SA_MIN_ENVIRONMENT_ABSORPTION = 0.01;
    static double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA = 1;
    static int AK_MIDI_EVENT_TYPE_INVALID = 0;
    static int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;
    static int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;
    static int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;
    static int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;
    static int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;
    static int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;
    static int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;
    static int AK_MIDI_EVENT_TYPE_SYSEX = 240;
    static int AK_MIDI_EVENT_TYPE_ESCAPE = 247;
    static int AK_MIDI_EVENT_TYPE_WWISE_CMD = 254;
    static int AK_MIDI_EVENT_TYPE_META = 255;
    static int AK_MIDI_CC_BANK_SELECT_COARSE = 0;
    static int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;
    static int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;
    static int AK_MIDI_CC_CTRL_3_COARSE = 3;
    static int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;
    static int AK_MIDI_CC_PORTAMENTO_COARSE = 5;
    static int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;
    static int AK_MIDI_CC_VOLUME_COARSE = 7;
    static int AK_MIDI_CC_BALANCE_COARSE = 8;
    static int AK_MIDI_CC_CTRL_9_COARSE = 9;
    static int AK_MIDI_CC_PAN_POSITION_COARSE = 10;
    static int AK_MIDI_CC_EXPRESSION_COARSE = 11;
    static int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;
    static int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;
    static int AK_MIDI_CC_CTRL_14_COARSE = 14;
    static int AK_MIDI_CC_CTRL_15_COARSE = 15;
    static int AK_MIDI_CC_GEN_SLIDER_1 = 16;
    static int AK_MIDI_CC_GEN_SLIDER_2 = 17;
    static int AK_MIDI_CC_GEN_SLIDER_3 = 18;
    static int AK_MIDI_CC_GEN_SLIDER_4 = 19;
    static int AK_MIDI_CC_CTRL_20_COARSE = 20;
    static int AK_MIDI_CC_CTRL_21_COARSE = 21;
    static int AK_MIDI_CC_CTRL_22_COARSE = 22;
    static int AK_MIDI_CC_CTRL_23_COARSE = 23;
    static int AK_MIDI_CC_CTRL_24_COARSE = 24;
    static int AK_MIDI_CC_CTRL_25_COARSE = 25;
    static int AK_MIDI_CC_CTRL_26_COARSE = 26;
    static int AK_MIDI_CC_CTRL_27_COARSE = 27;
    static int AK_MIDI_CC_CTRL_28_COARSE = 28;
    static int AK_MIDI_CC_CTRL_29_COARSE = 29;
    static int AK_MIDI_CC_CTRL_30_COARSE = 30;
    static int AK_MIDI_CC_CTRL_31_COARSE = 31;
    static int AK_MIDI_CC_BANK_SELECT_FINE = 32;
    static int AK_MIDI_CC_MOD_WHEEL_FINE = 33;
    static int AK_MIDI_CC_BREATH_CTRL_FINE = 34;
    static int AK_MIDI_CC_CTRL_3_FINE = 35;
    static int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;
    static int AK_MIDI_CC_PORTAMENTO_FINE = 37;
    static int AK_MIDI_CC_DATA_ENTRY_FINE = 38;
    static int AK_MIDI_CC_VOLUME_FINE = 39;
    static int AK_MIDI_CC_BALANCE_FINE = 40;
    static int AK_MIDI_CC_CTRL_9_FINE = 41;
    static int AK_MIDI_CC_PAN_POSITION_FINE = 42;
    static int AK_MIDI_CC_EXPRESSION_FINE = 43;
    static int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;
    static int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;
    static int AK_MIDI_CC_CTRL_14_FINE = 46;
    static int AK_MIDI_CC_CTRL_15_FINE = 47;
    static int AK_MIDI_CC_CTRL_20_FINE = 52;
    static int AK_MIDI_CC_CTRL_21_FINE = 53;
    static int AK_MIDI_CC_CTRL_22_FINE = 54;
    static int AK_MIDI_CC_CTRL_23_FINE = 55;
    static int AK_MIDI_CC_CTRL_24_FINE = 56;
    static int AK_MIDI_CC_CTRL_25_FINE = 57;
    static int AK_MIDI_CC_CTRL_26_FINE = 58;
    static int AK_MIDI_CC_CTRL_27_FINE = 59;
    static int AK_MIDI_CC_CTRL_28_FINE = 60;
    static int AK_MIDI_CC_CTRL_29_FINE = 61;
    static int AK_MIDI_CC_CTRL_30_FINE = 62;
    static int AK_MIDI_CC_CTRL_31_FINE = 63;
    static int AK_MIDI_CC_HOLD_PEDAL = 64;
    static int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;
    static int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;
    static int AK_MIDI_CC_SOFT_PEDAL = 67;
    static int AK_MIDI_CC_LEGATO_PEDAL = 68;
    static int AK_MIDI_CC_HOLD_PEDAL_2 = 69;
    static int AK_MIDI_CC_SOUND_VARIATION = 70;
    static int AK_MIDI_CC_SOUND_TIMBRE = 71;
    static int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;
    static int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;
    static int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;
    static int AK_MIDI_CC_SOUND_CTRL_6 = 75;
    static int AK_MIDI_CC_SOUND_CTRL_7 = 76;
    static int AK_MIDI_CC_SOUND_CTRL_8 = 77;
    static int AK_MIDI_CC_SOUND_CTRL_9 = 78;
    static int AK_MIDI_CC_SOUND_CTRL_10 = 79;
    static int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;
    static int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;
    static int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;
    static int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;
    static int AK_MIDI_CC_REVERB_LEVEL = 91;
    static int AK_MIDI_CC_TREMOLO_LEVEL = 92;
    static int AK_MIDI_CC_CHORUS_LEVEL = 93;
    static int AK_MIDI_CC_CELESTE_LEVEL = 94;
    static int AK_MIDI_CC_PHASER_LEVEL = 95;
    static int AK_MIDI_CC_DATA_BUTTON_P1 = 96;
    static int AK_MIDI_CC_DATA_BUTTON_M1 = 97;
    static int AK_MIDI_CC_NON_REGISTER_COARSE = 98;
    static int AK_MIDI_CC_NON_REGISTER_FINE = 99;
    static int AK_MIDI_CC_ALL_SOUND_OFF = 120;
    static int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;
    static int AK_MIDI_CC_LOCAL_KEYBOARD = 122;
    static int AK_MIDI_CC_ALL_NOTES_OFF = 123;
    static int AK_MIDI_CC_OMNI_MODE_OFF = 124;
    static int AK_MIDI_CC_OMNI_MODE_ON = 125;
    static int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;
    static int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;
    static int AK_MIDI_WWISE_CMD_PLAY = 0;
    static int AK_MIDI_WWISE_CMD_STOP = 1;
    static int AK_MIDI_WWISE_CMD_PAUSE = 2;
    static int AK_MIDI_WWISE_CMD_RESUME = 3;
    static int AK_MIDI_WWISE_CMD_SEEK_MS = 4;
    static int AK_MIDI_WWISE_CMD_SEEK_SAMPLES = 5;
    static int AK_SPEAKER_FRONT_LEFT = 1;
    static int AK_SPEAKER_FRONT_RIGHT = 2;
    static int AK_SPEAKER_FRONT_CENTER = 4;
    static int AK_SPEAKER_LOW_FREQUENCY = 8;
    static int AK_SPEAKER_BACK_LEFT = 16;
    static int AK_SPEAKER_BACK_RIGHT = 32;
    static int AK_SPEAKER_BACK_CENTER = 256;
    static int AK_SPEAKER_SIDE_LEFT = 512;
    static int AK_SPEAKER_SIDE_RIGHT = 1024;
    static int AK_SPEAKER_TOP = 2048;
    static int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;
    static int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;
    static int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;
    static int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;
    static int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;
    static int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;
    static int AK_SPEAKER_SETUP_MONO = 4;
    static int AK_SPEAKER_SETUP_0POINT1 = 8;
    static int AK_SPEAKER_SETUP_1POINT1 = 12;
    static int AK_SPEAKER_SETUP_STEREO = 3;
    static int AK_SPEAKER_SETUP_2POINT1 = 11;
    static int AK_SPEAKER_SETUP_3STEREO = 7;
    static int AK_SPEAKER_SETUP_3POINT1 = 15;
    static int AK_SPEAKER_SETUP_4 = 1539;
    static int AK_SPEAKER_SETUP_4POINT1 = 1547;
    static int AK_SPEAKER_SETUP_5 = 1543;
    static int AK_SPEAKER_SETUP_5POINT1 = 1551;
    static int AK_SPEAKER_SETUP_6 = 1587;
    static int AK_SPEAKER_SETUP_6POINT1 = 1595;
    static int AK_SPEAKER_SETUP_7 = 1591;
    static int AK_SPEAKER_SETUP_7POINT1 = 1599;
    static int AK_SPEAKER_SETUP_SURROUND = 259;
    static int AK_SPEAKER_SETUP_DPL2 = 1539;
    static int AK_SPEAKER_SETUP_HEIGHT_2 = 20480;
    static int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;
    static int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;
    static int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;
    static int AK_SPEAKER_SETUP_HEIGHT_4_TOP = 186368;
    static int AK_SPEAKER_SETUP_HEIGHT_5_TOP = 194560;
    static int AK_SPEAKER_SETUP_AURO_222 = 22019;
    static int AK_SPEAKER_SETUP_AURO_8 = 185859;
    static int AK_SPEAKER_SETUP_AURO_9 = 185863;
    static int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;
    static int AK_SPEAKER_SETUP_AURO_10 = 187911;
    static int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;
    static int AK_SPEAKER_SETUP_AURO_11 = 196103;
    static int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;
    static int AK_SPEAKER_SETUP_AURO_11_740 = 185911;
    static int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;
    static int AK_SPEAKER_SETUP_AURO_13_751 = 196151;
    static int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;
    static int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;
    static int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;
    static int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;
    static int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;
    static int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;
    static int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;
    static int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;
    static int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;
    static int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;
    static int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;
    static int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;
    static int AK_IDX_SETUP_FRONT_LEFT = 0;
    static int AK_IDX_SETUP_FRONT_RIGHT = 1;
    static int AK_IDX_SETUP_CENTER = 2;
    static int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;
    static int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;
    static int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;
    static int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;
    static int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;
    static int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;
    static int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;
    static int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;
    static int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT = 7;
    static int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT = 8;
    static int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT = 9;
    static int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT = 10;
    static int AK_IDX_SETUP_0_LFE = 0;
    static int AK_IDX_SETUP_1_CENTER = 0;
    static int AK_IDX_SETUP_1_LFE = 1;
    static int AK_IDX_SETUP_2_LEFT = 0;
    static int AK_IDX_SETUP_2_RIGHT = 1;
    static int AK_IDX_SETUP_2_LFE = 2;
    static int AK_IDX_SETUP_3_LEFT = 0;
    static int AK_IDX_SETUP_3_RIGHT = 1;
    static int AK_IDX_SETUP_3_CENTER = 2;
    static int AK_IDX_SETUP_3_LFE = 3;
    static int AK_IDX_SETUP_4_FRONTLEFT = 0;
    static int AK_IDX_SETUP_4_FRONTRIGHT = 1;
    static int AK_IDX_SETUP_4_REARLEFT = 2;
    static int AK_IDX_SETUP_4_REARRIGHT = 3;
    static int AK_IDX_SETUP_4_LFE = 4;
    static int AK_IDX_SETUP_5_FRONTLEFT = 0;
    static int AK_IDX_SETUP_5_FRONTRIGHT = 1;
    static int AK_IDX_SETUP_5_CENTER = 2;
    static int AK_IDX_SETUP_5_REARLEFT = 3;
    static int AK_IDX_SETUP_5_REARRIGHT = 4;
    static int AK_IDX_SETUP_5_LFE = 5;
    static int AK_IDX_SETUP_6_FRONTLEFT = 0;
    static int AK_IDX_SETUP_6_FRONTRIGHT = 1;
    static int AK_IDX_SETUP_6_REARLEFT = 2;
    static int AK_IDX_SETUP_6_REARRIGHT = 3;
    static int AK_IDX_SETUP_6_SIDELEFT = 4;
    static int AK_IDX_SETUP_6_SIDERIGHT = 5;
    static int AK_IDX_SETUP_6_LFE = 6;
    static int AK_IDX_SETUP_7_FRONTLEFT = 0;
    static int AK_IDX_SETUP_7_FRONTRIGHT = 1;
    static int AK_IDX_SETUP_7_CENTER = 2;
    static int AK_IDX_SETUP_7_REARLEFT = 3;
    static int AK_IDX_SETUP_7_REARRIGHT = 4;
    static int AK_IDX_SETUP_7_SIDELEFT = 5;
    static int AK_IDX_SETUP_7_SIDERIGHT = 6;
    static int AK_IDX_SETUP_7_LFE = 7;
    static int AK_SPEAKER_SETUP_0_1 = 8;
    static int AK_SPEAKER_SETUP_1_0_CENTER = 4;
    static int AK_SPEAKER_SETUP_1_1_CENTER = 12;
    static int AK_SPEAKER_SETUP_2_0 = 3;
    static int AK_SPEAKER_SETUP_2_1 = 11;
    static int AK_SPEAKER_SETUP_3_0 = 7;
    static int AK_SPEAKER_SETUP_3_1 = 15;
    static int AK_SPEAKER_SETUP_FRONT = 7;
    static int AK_SPEAKER_SETUP_4_0 = 1539;
    static int AK_SPEAKER_SETUP_4_1 = 1547;
    static int AK_SPEAKER_SETUP_5_0 = 1543;
    static int AK_SPEAKER_SETUP_5_1 = 1551;
    static int AK_SPEAKER_SETUP_6_0 = 1587;
    static int AK_SPEAKER_SETUP_6_1 = 1595;
    static int AK_SPEAKER_SETUP_7_0 = 1591;
    static int AK_SPEAKER_SETUP_7_1 = 1599;
    static int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;
    static int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;
    static int AK_STANDARD_MAX_NUM_CHANNELS = 8;
    static int AK_MAX_AMBISONICS_ORDER = 5;
    static int AK_MAX_NUM_TEXTURE = 4;
    static int AK_MAX_REFLECT_ORDER = 4;
    static int AK_MAX_REFLECTION_PATH_LENGTH = 8;
    static int AK_STOCHASTIC_RESERVE_LENGTH = 8;
    static int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;
    static int AK_MAX_SOUND_PROPAGATION_WIDTH = 8;
    static double AK_SA_DIFFRACTION_DOT_EPSILON = 0.000002;
    static double AK_DEFAULT_GEOMETRY_POSITION_X = 0;
    static double AK_DEFAULT_GEOMETRY_POSITION_Y = 0;
    static double AK_DEFAULT_GEOMETRY_POSITION_Z = 0;
    static double AK_DEFAULT_GEOMETRY_FRONT_X = 0;
    static double AK_DEFAULT_GEOMETRY_FRONT_Y = 0;
    static double AK_DEFAULT_GEOMETRY_FRONT_Z = 1;
    static double AK_DEFAULT_GEOMETRY_TOP_X = 0;
    static double AK_DEFAULT_GEOMETRY_TOP_Y = 1;
    static double AK_DEFAULT_GEOMETRY_TOP_Z = 0;
    static string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";
    static string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";
    static string Deprecation_2019_2_0 = "This functionality is deprecated as of Wwise v2019.2.0 and will be removed in a future release.";
    static string Deprecation_2019_2_2 = "This functionality is deprecated as of Wwise v2019.2.2 and will be removed in a future release.";
    static string Deprecation_2021_1_0 = "This functionality is deprecated as of Wwise v2021.1.0 and will be removed in a future release.";
    static string Deprecation_2022_1_0 = "This functionality is deprecated as of Wwise v2022.1.0 and will be removed in a future release.";
    static string Deprecation_2023_1_0 = "This functionality is deprecated as of Wwise v2023.1.0 and will be removed in a future release.";
    static uint AK_PENDING_EVENT_LOAD_ID = 4294967295;
    static /*0x0*/ System.Collections.Generic.HashSet<ulong> RegisteredGameObjects;
    static /*0x8*/ AkSoundEngine.GameObjectHashFunction gameObjectHash;

    static /*0x20f94bc*/ AkSoundEngine();
    static /*0x20d7ae0*/ void AutoRegister(UnityEngine.GameObject gameObject, ulong id);
    static /*0x20d7dd0*/ bool IsInRegisteredList(ulong id);
    static /*0x20d7e64*/ bool IsGameObjectRegistered(UnityEngine.GameObject in_gameObject);
    static /*0x20d7f30*/ uint get_AK_INVALID_SHARE_SET_ID();
    static /*0x20d7fe0*/ uint get_AK_INVALID_PIPELINE_ID();
    static /*0x20d8090*/ ulong get_AK_INVALID_AUDIO_OBJECT_ID();
    static /*0x20d8140*/ uint get_AK_SOUNDBANK_VERSION();
    static /*0x20d81f0*/ uint get_AkJobType_Generic();
    static /*0x20d82a0*/ uint get_AkJobType_AudioProcessing();
    static /*0x20d8350*/ uint get_AkJobType_SpatialAudio();
    static /*0x20d8400*/ uint get_AK_NUM_JOB_TYPES();
    static /*0x20d84b0*/ UnityEngine.Vector3 ConvertAkVector64ToAkVector(AkVector64 in_);
    static /*0x20d8588*/ AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_);
    static /*0x20d86ac*/ AkVector64 ConvertAkVectorToAkVector64(UnityEngine.Vector3 in_);
    static /*0x20d8820*/ AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_);
    static /*0x20d8944*/ ushort get_AK_INT();
    static /*0x20d89f4*/ ushort get_AK_FLOAT();
    static /*0x20d8aa4*/ byte get_AK_INTERLEAVED();
    static /*0x20d8b54*/ byte get_AK_NONINTERLEAVED();
    static /*0x20d8c04*/ uint get_AK_LE_NATIVE_BITSPERSAMPLE();
    static /*0x20d8cb4*/ uint get_AK_LE_NATIVE_SAMPLETYPE();
    static /*0x20d8d64*/ uint get_AK_LE_NATIVE_INTERLEAVE();
    static /*0x20d8e14*/ bool IsBankCodecID(uint in_codecID);
    static /*0x20d8eec*/ uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType);
    static /*0x20d90b4*/ uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20d9264*/ uint DynamicSequenceOpen(ulong in_gameObjectID);
    static /*0x20d9374*/ AKRESULT DynamicSequenceClose(uint in_playingID);
    static /*0x20d9444*/ AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20d9544*/ AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration);
    static /*0x20d962c*/ AKRESULT DynamicSequencePlay(uint in_playingID);
    static /*0x20d96fc*/ AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20d97fc*/ AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration);
    static /*0x20d98e4*/ AKRESULT DynamicSequencePause(uint in_playingID);
    static /*0x20d99b4*/ AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20d9ab4*/ AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration);
    static /*0x20d9b9c*/ AKRESULT DynamicSequenceResume(uint in_playingID);
    static /*0x20d9c6c*/ AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20d9d6c*/ AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration);
    static /*0x20d9e54*/ AKRESULT DynamicSequenceStop(uint in_playingID);
    static /*0x20d9f24*/ AKRESULT DynamicSequenceBreak(uint in_playingID);
    static /*0x20d9ff4*/ AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker);
    static /*0x20da0f4*/ AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker);
    static /*0x20da1fc*/ AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, ref uint out_uTime, ref uint out_uDuration);
    static /*0x20da2fc*/ AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID);
    static /*0x20da414*/ AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID);
    static /*0x20da4e4*/ bool IsInitialized();
    static /*0x20da59c*/ AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings);
    static /*0x20da680*/ AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput);
    static /*0x20da7c4*/ AkChannelConfig GetSpeakerConfiguration();
    static /*0x20da8b8*/ AKRESULT GetOutputDeviceConfiguration(ulong in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities);
    static /*0x20da9e0*/ AKRESULT GetPanningRule(ref int out_ePanningRule, ulong in_idOutput);
    static /*0x20daac8*/ AKRESULT GetPanningRule(ref int out_ePanningRule);
    static /*0x20dab98*/ AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput);
    static /*0x20dac80*/ AKRESULT SetPanningRule(AkPanningRule in_ePanningRule);
    static /*0x20dad50*/ AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, ref float out_fHeightAngle, ulong in_idOutput);
    static /*0x20dae70*/ AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, ref float out_fHeightAngle);
    static /*0x20daf78*/ AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput);
    static /*0x20db0a0*/ AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle);
    static /*0x20db1b0*/ AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB);
    static /*0x20db284*/ AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices);
    static /*0x20db354*/ AKRESULT SetJobMgrMaxActiveWorkers(uint in_jobType, uint in_uNewMaxActiveWorkers);
    static /*0x20db43c*/ AKRESULT RenderAudio(bool in_bAllowSyncRender);
    static /*0x20db50c*/ AKRESULT RenderAudio();
    static /*0x20db5bc*/ AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath);
    static /*0x20db6d4*/ AKRESULT RegisterPluginDLL(string in_DllName);
    static /*0x20db7bc*/ bool IsPluginRegistered(AkPluginType in_eType, uint in_ulCompanyID, uint in_ulPluginID);
    static /*0x20db8c4*/ uint GetIDFromString(string in_pszString);
    static /*0x20db9ac*/ uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID);
    static /*0x20dbbd8*/ uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources);
    static /*0x20dbdec*/ uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20dbfb4*/ uint PostEvent(uint in_eventID, ulong in_gameObjectID);
    static /*0x20dc0dc*/ uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID);
    static /*0x20dc320*/ uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources);
    static /*0x20dc54c*/ uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20dc72c*/ uint PostEvent(string in_pszEventName, ulong in_gameObjectID);
    static /*0x20dc86c*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID);
    static /*0x20dc9b4*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20dcae4*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration);
    static /*0x20dcbfc*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID);
    static /*0x20dccfc*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType);
    static /*0x20dcde4*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID);
    static /*0x20dcf44*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20dd08c*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration);
    static /*0x20dd1bc*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID);
    static /*0x20dd2d4*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType);
    static /*0x20dd3d4*/ uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID);
    static /*0x20dd610*/ uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20dd82c*/ uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets);
    static /*0x20dd9a8*/ uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts);
    static /*0x20ddb04*/ AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_playingID);
    static /*0x20ddc04*/ AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID);
    static /*0x20ddcec*/ AKRESULT StopMIDIOnEvent(uint in_eventID);
    static /*0x20dddbc*/ AKRESULT StopMIDIOnEvent();
    static /*0x20dde6c*/ AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority);
    static /*0x20ddf6c*/ AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority);
    static /*0x20de084*/ AKRESULT UnpinEventInStreamCache(uint in_eventID);
    static /*0x20de154*/ AKRESULT UnpinEventInStreamCache(string in_pszEventName);
    static /*0x20de23c*/ AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, ref float out_fPercentBuffered, ref int out_bCachePinnedMemoryFull);
    static /*0x20de33c*/ AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, ref float out_fPercentBuffered, ref int out_bCachePinnedMemoryFull);
    static /*0x20de454*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20de584*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker);
    static /*0x20de69c*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition);
    static /*0x20de79c*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20de8e4*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker);
    static /*0x20dea14*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition);
    static /*0x20deb2c*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20dec64*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker);
    static /*0x20ded84*/ AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent);
    static /*0x20dee8c*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20defdc*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker);
    static /*0x20df114*/ AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent);
    static /*0x20df234*/ void CancelEventCallbackCookie(object in_pCookie);
    static /*0x20df28c*/ void CancelEventCallbackGameObject(ulong in_gameObjectID);
    static /*0x20df35c*/ void CancelEventCallback(uint in_playingID);
    static /*0x20df3b4*/ AKRESULT GetSourcePlayPosition(uint in_PlayingID, ref int out_puPosition, bool in_bExtrapolate);
    static /*0x20df4b4*/ AKRESULT GetSourcePlayPosition(uint in_PlayingID, ref int out_puPosition);
    static /*0x20df59c*/ AKRESULT GetSourceStreamBuffering(uint in_PlayingID, ref int out_buffering, ref int out_bIsBuffering);
    static /*0x20df69c*/ void StopAll(ulong in_gameObjectID);
    static /*0x20df76c*/ void StopAll();
    static /*0x20df81c*/ void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20df91c*/ void StopPlayingID(uint in_playingID, int in_uTransitionDuration);
    static /*0x20dfa04*/ void StopPlayingID(uint in_playingID);
    static /*0x20dfad4*/ void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20dfbec*/ void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration);
    static /*0x20dfcec*/ void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID);
    static /*0x20dfdd4*/ void SetRandomSeed(uint in_uSeed);
    static /*0x20dfea4*/ void MuteBackgroundMusic(bool in_bMute);
    static /*0x20dff74*/ bool GetBackgroundMusicMute();
    static /*0x20e002c*/ AKRESULT SendPluginCustomGameData(uint in_busID, ulong in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, nint in_pData, uint in_uSizeInBytes);
    static /*0x20e018c*/ AKRESULT UnregisterAllGameObj();
    static /*0x20e023c*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags);
    static /*0x20e0378*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType);
    static /*0x20e0494*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions);
    static /*0x20e05a0*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags);
    static /*0x20e06dc*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType);
    static /*0x20e07f8*/ AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions);
    static /*0x20e0904*/ AKRESULT SetScalingFactor(ulong in_GameObjectID, float in_fAttenuationScalingFactor);
    static /*0x20e09f4*/ AKRESULT SetDistanceProbe(ulong in_listenerGameObjectID, ulong in_distanceProbeGameObjectID);
    static /*0x20e0adc*/ AKRESULT ClearBanks();
    static /*0x20e0b8c*/ AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority);
    static /*0x20e0c7c*/ AKRESULT LoadBank(string in_pszString, ref uint out_bankID, uint in_bankType);
    static /*0x20e0d94*/ AKRESULT LoadBank(string in_pszString, ref uint out_bankID);
    static /*0x20e0e94*/ AKRESULT LoadBank(uint in_bankID, uint in_bankType);
    static /*0x20e0f7c*/ AKRESULT LoadBank(uint in_bankID);
    static /*0x20e104c*/ AKRESULT LoadBankMemoryView(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, ref uint out_bankID);
    static /*0x20e114c*/ AKRESULT LoadBankMemoryView(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, ref uint out_bankID, ref uint out_bankType);
    static /*0x20e1264*/ AKRESULT LoadBankMemoryCopy(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, ref uint out_bankID);
    static /*0x20e1364*/ AKRESULT LoadBankMemoryCopy(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, ref uint out_bankID, ref uint out_bankType);
    static /*0x20e147c*/ AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID, uint in_bankType);
    static /*0x20e161c*/ AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID);
    static /*0x20e17a4*/ AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType);
    static /*0x20e1914*/ AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e1a6c*/ AKRESULT LoadBankMemoryView(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID);
    static /*0x20e1bf4*/ AKRESULT LoadBankMemoryView(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID, ref uint out_bankType);
    static /*0x20e1d94*/ AKRESULT LoadBankMemoryCopy(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID);
    static /*0x20e1f1c*/ AKRESULT LoadBankMemoryCopy(nint in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, ref uint out_bankID, ref uint out_bankType);
    static /*0x20e20bc*/ AKRESULT UnloadBank(string in_pszString, nint in_pInMemoryBankPtr, uint in_bankType);
    static /*0x20e21d4*/ AKRESULT UnloadBank(string in_pszString, nint in_pInMemoryBankPtr);
    static /*0x20e22d4*/ AKRESULT UnloadBank(uint in_bankID, nint in_pInMemoryBankPtr, uint in_bankType);
    static /*0x20e23d4*/ AKRESULT UnloadBank(uint in_bankID, nint in_pInMemoryBankPtr);
    static /*0x20e24bc*/ AKRESULT UnloadBank(string in_pszString, nint in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType);
    static /*0x20e265c*/ AKRESULT UnloadBank(string in_pszString, nint in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e27e4*/ AKRESULT UnloadBank(uint in_bankID, nint in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType);
    static /*0x20e296c*/ AKRESULT UnloadBank(uint in_bankID, nint in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e2adc*/ void CancelBankCallbackCookie(object in_pCookie);
    static /*0x20e2b34*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags, uint in_bankType);
    static /*0x20e2c68*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags);
    static /*0x20e2d84*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString);
    static /*0x20e2e88*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags, uint in_bankType);
    static /*0x20e2fa0*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags);
    static /*0x20e30a0*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID);
    static /*0x20e3188*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType);
    static /*0x20e3344*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags);
    static /*0x20e34e8*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e3674*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType);
    static /*0x20e3814*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags);
    static /*0x20e399c*/ AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e3b0c*/ AKRESULT ClearPreparedEvents();
    static /*0x20e3bbc*/ AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent);
    static /*0x20e3ef4*/ AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent);
    static /*0x20e3ffc*/ AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e43c0*/ AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e4550*/ AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings);
    static /*0x20e4648*/ AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings);
    static /*0x20e4740*/ AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs);
    static /*0x20e4ac0*/ AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs);
    static /*0x20e4bf8*/ AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e500c*/ AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie);
    static /*0x20e51cc*/ AKRESULT AddListener(ulong in_emitterGameObj, ulong in_listenerGameObj);
    static /*0x20e52b4*/ AKRESULT RemoveListener(ulong in_emitterGameObj, ulong in_listenerGameObj);
    static /*0x20e539c*/ AKRESULT AddDefaultListener(ulong in_listenerGameObj);
    static /*0x20e546c*/ AKRESULT RemoveDefaultListener(ulong in_listenerGameObj);
    static /*0x20e553c*/ AKRESULT ResetListenersToDefault(ulong in_emitterGameObj);
    static /*0x20e560c*/ AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets);
    static /*0x20e572c*/ AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig);
    static /*0x20e5834*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e5984*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e5abc*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20e5bdc*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID);
    static /*0x20e5ce4*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value);
    static /*0x20e5dd4*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e5f3c*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e608c*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20e61c4*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID);
    static /*0x20e62e4*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value);
    static /*0x20e63ec*/ AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e653c*/ AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e6674*/ AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration);
    static /*0x20e6794*/ AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID);
    static /*0x20e689c*/ AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e6a04*/ AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e6b54*/ AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration);
    static /*0x20e6c8c*/ AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID);
    static /*0x20e6dac*/ AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e6edc*/ AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e6ff4*/ AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20e70f4*/ AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID);
    static /*0x20e71dc*/ AKRESULT ResetRTPCValue(uint in_rtpcID);
    static /*0x20e72ac*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20e73f4*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20e7524*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20e763c*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID);
    static /*0x20e773c*/ AKRESULT ResetRTPCValue(string in_pszRtpcName);
    static /*0x20e7824*/ AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, ulong in_gameObjectID);
    static /*0x20e7924*/ AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, ulong in_gameObjectID);
    static /*0x20e7a50*/ AKRESULT PostTrigger(uint in_triggerID, ulong in_gameObjectID);
    static /*0x20e7b38*/ AKRESULT PostTrigger(string in_pszTrigger, ulong in_gameObjectID);
    static /*0x20e7c38*/ AKRESULT SetState(uint in_stateGroup, uint in_state);
    static /*0x20e7d20*/ AKRESULT SetState(string in_pszStateGroup, string in_pszState);
    static /*0x20e7e38*/ AKRESULT SetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues);
    static /*0x20e7f44*/ AKRESULT SetGameObjectOutputBusVolume(ulong in_emitterObjID, ulong in_listenerObjID, float in_fControlValue);
    static /*0x20e804c*/ AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID);
    static /*0x20e814c*/ AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID);
    static /*0x20e824c*/ AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID);
    static /*0x20e8364*/ AKRESULT SetOutputDeviceEffect(ulong in_outputDeviceID, uint in_uFXIndex, uint in_FXShareSetID);
    static /*0x20e8464*/ AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID);
    static /*0x20e854c*/ AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID);
    static /*0x20e864c*/ AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig);
    static /*0x20e8734*/ AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig);
    static /*0x20e8834*/ AKRESULT SetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel);
    static /*0x20e894c*/ AKRESULT SetMultipleObstructionAndOcclusion(ulong in_EmitterID, ulong in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction);
    static /*0x20e8a74*/ AKRESULT StartOutputCapture(string in_CaptureFileName);
    static /*0x20e8b5c*/ AKRESULT StopOutputCapture();
    static /*0x20e8c0c*/ AKRESULT AddOutputCaptureMarker(string in_MarkerText);
    static /*0x20e8cf4*/ AKRESULT AddOutputCaptureBinaryMarker(nint in_pMarkerData, uint in_uMarkerDataSize);
    static /*0x20e8ddc*/ uint GetSampleRate();
    static /*0x20e8e8c*/ AKRESULT StartProfilerCapture(string in_CaptureFileName);
    static /*0x20e8f74*/ AKRESULT StopProfilerCapture();
    static /*0x20e9024*/ AKRESULT SetOfflineRenderingFrameTime(float in_fFrameTimeInSeconds);
    static /*0x20e90f8*/ AKRESULT SetOfflineRendering(bool in_bEnableOfflineRendering);
    static /*0x20e91c8*/ AKRESULT RemoveOutput(ulong in_idOutput);
    static /*0x20e9298*/ AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, ref ulong out_pOutputDeviceId);
    static /*0x20e93ac*/ AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId);
    static /*0x20e94a8*/ ulong GetOutputID(uint in_idShareset, uint in_idDevice);
    static /*0x20e9590*/ ulong GetOutputID(string in_szShareSet, uint in_idDevice);
    static /*0x20e9690*/ AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice);
    static /*0x20e9778*/ AKRESULT SetBusDevice(string in_BusName, string in_DeviceName);
    static /*0x20e9890*/ AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, ref uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions);
    static /*0x20e99b8*/ AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, ref uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions);
    static /*0x20e9ad0*/ AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume);
    static /*0x20e9bc0*/ AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice);
    static /*0x20e9c90*/ AKRESULT Suspend(bool in_bRenderAnyway, bool in_bFadeOut);
    static /*0x20e9d78*/ AKRESULT Suspend(bool in_bRenderAnyway);
    static /*0x20e9e48*/ AKRESULT Suspend();
    static /*0x20e9ef8*/ AKRESULT WakeupFromSuspend(uint in_uDelayMs);
    static /*0x20e9fc8*/ AKRESULT WakeupFromSuspend();
    static /*0x20ea078*/ uint GetBufferTick();
    static /*0x20ea128*/ ulong GetSampleTick();
    static /*0x20ea1d8*/ byte get_AK_INVALID_MIDI_CHANNEL();
    static /*0x20ea288*/ byte get_AK_INVALID_MIDI_NOTE();
    static /*0x20ea338*/ AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate);
    static /*0x20ea44c*/ AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo);
    static /*0x20ea548*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus);
    static /*0x20ea690*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID);
    static /*0x20ea7c0*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID);
    static /*0x20ea8d8*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID);
    static /*0x20ea9d8*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel);
    static /*0x20eaac0*/ AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext);
    static /*0x20eabd4*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus);
    static /*0x20ead34*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID);
    static /*0x20eae7c*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID);
    static /*0x20eafac*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID);
    static /*0x20eb0c4*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel);
    static /*0x20eb1c4*/ AKRESULT ResetTranslator();
    static /*0x20eb274*/ int GetTimeStamp();
    static /*0x20eb324*/ void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings);
    static /*0x20eb408*/ void MonitorStreamingDeviceInit(uint in_deviceID, AkDeviceSettings in_deviceSettings);
    static /*0x20eb4fc*/ void MonitorStreamingDeviceDestroyed(uint in_deviceID);
    static /*0x20eb5cc*/ void MonitorStreamMgrTerm();
    static /*0x20eb67c*/ void AkMemCpy(nint pDest, nint pSrc, uint uSize);
    static /*0x20eb77c*/ void AkMemMove(nint pDest, nint pSrc, uint uSize);
    static /*0x20eb87c*/ void AkMemSet(nint pDest, int iVal, uint uSize);
    static /*0x20eb97c*/ void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties);
    static /*0x20eba60*/ uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence);
    static /*0x20ebb80*/ uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments);
    static /*0x20ebc88*/ AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, ref int out_iValue);
    static /*0x20ebd88*/ AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, ref float out_fValue);
    static /*0x20ebe88*/ AKRESULT GetPosition(ulong in_GameObjectID, AkWorldTransform out_rPosition);
    static /*0x20ebf84*/ AKRESULT GetListenerPosition(ulong in_uListenerID, AkWorldTransform out_rPosition);
    static /*0x20ec080*/ AKRESULT GetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, uint in_playingID, ref float out_rValue, ref int io_rValueType);
    static /*0x20ec1b0*/ AKRESULT GetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, uint in_playingID, ref float out_rValue, ref int io_rValueType);
    static /*0x20ec2f8*/ AKRESULT GetSwitch(uint in_switchGroup, ulong in_gameObjectID, ref uint out_rSwitchState);
    static /*0x20ec3f8*/ AKRESULT GetSwitch(string in_pstrSwitchGroupName, ulong in_GameObj, ref uint out_rSwitchState);
    static /*0x20ec50c*/ AKRESULT GetState(uint in_stateGroup, ref uint out_rState);
    static /*0x20ec5f4*/ AKRESULT GetState(string in_pstrStateGroupName, ref uint out_rState);
    static /*0x20ec6f4*/ AKRESULT GetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues);
    static /*0x20ec800*/ AKRESULT GetGameObjectDryLevelValue(ulong in_EmitterID, ulong in_ListenerID, ref float out_rfControlValue);
    static /*0x20ec900*/ AKRESULT GetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, ref float out_rfObstructionLevel, ref float out_rfOcclusionLevel);
    static /*0x20eca18*/ AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos);
    static /*0x20ecb30*/ AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos);
    static /*0x20ecc60*/ AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo);
    static /*0x20ecd5c*/ bool GetIsGameObjectActive(ulong in_GameObjId);
    static /*0x20ece34*/ float GetMaxRadius(ulong in_GameObjId);
    static /*0x20ecf04*/ uint GetEventIDFromPlayingID(uint in_playingID);
    static /*0x20ecfd4*/ ulong GetGameObjectFromPlayingID(uint in_playingID);
    static /*0x20ed0a4*/ AKRESULT GetPlayingIDsFromGameObject(ulong in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs);
    static /*0x20ed238*/ AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, ref int out_iValue);
    static /*0x20ed338*/ AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, ref float out_fValue);
    static /*0x20ed438*/ void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask);
    static /*0x20ed508*/ void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask);
    static /*0x20ed5d8*/ void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask);
    static /*0x20ed6a8*/ byte ChannelMaskToNumChannels(uint in_uChannelMask);
    static /*0x20ed778*/ uint ChannelMaskFromNumChannels(uint in_uNumChannels);
    static /*0x20ed848*/ byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask);
    static /*0x20ed930*/ bool HasSurroundChannels(uint in_uChannelMask);
    static /*0x20eda08*/ bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask);
    static /*0x20edae0*/ bool HasSideAndRearChannels(uint in_uChannelMask);
    static /*0x20edbb8*/ bool HasHeightChannels(uint in_uChannelMask);
    static /*0x20edc90*/ uint BackToSideChannels(uint in_uChannelMask);
    static /*0x20edd60*/ uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx);
    static /*0x20ede60*/ uint get_kDefaultDiffractionMaxEdges();
    static /*0x20edf10*/ uint get_kDefaultDiffractionMaxPaths();
    static /*0x20edfc0*/ float get_kMaxDiffraction();
    static /*0x20ee070*/ uint get_kHashListBlockAllocItemCount();
    static /*0x20ee120*/ uint get_kDiffractionMaxEdges();
    static /*0x20ee1d0*/ uint get_kDiffractionMaxPaths();
    static /*0x20ee280*/ uint get_kPortalToPortalDiffractionMaxPaths();
    static /*0x20ee330*/ AKRESULT SetGameObjectRadius(ulong in_gameObjectID, float in_outerRadius, float in_innerRadius);
    static /*0x20ee430*/ AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID, ulong in_gameObjectID);
    static /*0x20ee590*/ AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID);
    static /*0x20ee6c4*/ AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name);
    static /*0x20ee7e8*/ AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, ulong in_gameObjectID);
    static /*0x20ee8e8*/ AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID);
    static /*0x20ee9d0*/ AKRESULT RemoveImageSource(uint in_srcID);
    static /*0x20eeaa0*/ AKRESULT ClearImageSources(uint in_AuxBusID, ulong in_gameObjectID);
    static /*0x20eeb88*/ AKRESULT ClearImageSources(uint in_AuxBusID);
    static /*0x20eec58*/ AKRESULT ClearImageSources();
    static /*0x20eed08*/ AKRESULT RemoveGeometry(ulong in_SetID);
    static /*0x20eedd8*/ AKRESULT RemoveGeometryInstance(ulong in_GeometryInstanceID);
    static /*0x20eeea8*/ AKRESULT RemoveRoom(ulong in_RoomID);
    static /*0x20eef78*/ AKRESULT RemovePortal(ulong in_PortalID);
    static /*0x20ef048*/ AKRESULT SetReverbZone(ulong in_ReverbZone, ulong in_ParentRoom, float in_transitionRegionWidth);
    static /*0x20ef14c*/ AKRESULT RemoveReverbZone(ulong in_ReverbZone);
    static /*0x20ef21c*/ AKRESULT SetGameObjectInRoom(ulong in_gameObjectID, ulong in_CurrentRoomID);
    static /*0x20ef304*/ AKRESULT UnsetGameObjectInRoom(ulong in_gameObjectID);
    static /*0x20ef3d4*/ AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths);
    static /*0x20ef4bc*/ AKRESULT SetDiffractionOrder(uint in_uDiffractionOrder, bool in_bUpdatePaths);
    static /*0x20ef5a4*/ AKRESULT SetMaxEmitterRoomAuxSends(uint in_uMaxEmitterRoomAuxSends);
    static /*0x20ef674*/ AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays);
    static /*0x20ef744*/ AKRESULT SetLoadBalancingSpread(uint in_uNbFrames);
    static /*0x20ef814*/ AKRESULT SetEarlyReflectionsAuxSend(ulong in_gameObjectID, uint in_auxBusID);
    static /*0x20ef8fc*/ AKRESULT SetEarlyReflectionsVolume(ulong in_gameObjectID, float in_fSendVolume);
    static /*0x20ef9ec*/ AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion);
    static /*0x20efaec*/ AKRESULT SetGameObjectToPortalObstruction(ulong in_gameObjectID, ulong in_PortalID, float in_fObstruction);
    static /*0x20efbf4*/ AKRESULT SetPortalToPortalObstruction(ulong in_PortalID0, ulong in_PortalID1, float in_fObstruction);
    static /*0x20efcfc*/ AKRESULT QueryWetDiffraction(ulong in_portal, ref float out_wetDiffraction);
    static /*0x20efde4*/ AKRESULT ResetStochasticEngine();
    static /*0x20efe94*/ AKRESULT GetFastPathSettings(AkInitSettings in_settings, AkPlatformInitSettings in_pfSettings);
    static /*0x20eff9c*/ void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger);
    static /*0x20f0070*/ void SetErrorLogger();
    static /*0x20f0120*/ void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat);
    static /*0x20f021c*/ AKRESULT Init(AkInitializationSettings settings);
    static /*0x20f0300*/ AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings);
    static /*0x20f03e4*/ AKRESULT InitCommunication(AkCommunicationSettings settings);
    static /*0x20f04c8*/ void Term();
    static /*0x20f0578*/ AKRESULT RegisterGameObjInternal(ulong in_GameObj);
    static /*0x20f0648*/ AKRESULT UnregisterGameObjInternal(ulong in_GameObj);
    static /*0x20f0718*/ AKRESULT RegisterGameObjInternal_WithName(ulong in_GameObj, string in_pszObjName);
    static /*0x20f081c*/ AKRESULT SetBasePath(string in_pszBasePath);
    static /*0x20f0904*/ AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath);
    static /*0x20f09ec*/ AKRESULT LoadFilePackage(string in_pszFilePackageName, ref uint out_uPackageID);
    static /*0x20f0aec*/ AKRESULT AddBasePath(string in_pszBasePath);
    static /*0x20f0bd4*/ AKRESULT SetGameName(string in_GameName);
    static /*0x20f0cbc*/ AKRESULT SetDecodedBankPath(string in_DecodedPath);
    static /*0x20f0da4*/ AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, ref uint out_bankID);
    static /*0x20f0ebc*/ AKRESULT LoadAndDecodeBankFromMemory(nint in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, ref uint out_bankID);
    static /*0x20f1020*/ string GetCurrentLanguage();
    static /*0x20f1158*/ AKRESULT UnloadFilePackage(uint in_uPackageID);
    static /*0x20f1228*/ AKRESULT UnloadAllFilePackages();
    static /*0x20f12d8*/ AKRESULT SetObjectPosition(ulong in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top);
    static /*0x20f14b0*/ AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate);
    static /*0x20f1734*/ AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions);
    static /*0x20f19a0*/ AKRESULT SetListeners(ulong in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners);
    static /*0x20f1aa8*/ AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners);
    static /*0x20f1b98*/ uint GetNumOutputDevices(uint in_AudioDeviceShareSetID);
    static /*0x20f1c68*/ AKRESULT AddOutput(AkOutputSettings in_Settings, ref ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners);
    static /*0x20f1d9c*/ AKRESULT AddOutput(AkOutputSettings in_Settings, ref ulong out_pDeviceID, ulong[] in_pListenerIDs);
    static /*0x20f1eb4*/ AKRESULT AddOutput(AkOutputSettings in_Settings, ref ulong out_pDeviceID);
    static /*0x20f1fb0*/ AKRESULT AddOutput(AkOutputSettings in_Settings);
    static /*0x20f2094*/ void GetDefaultStreamSettings(AkStreamMgrSettings out_settings);
    static /*0x20f2178*/ void GetDefaultDeviceSettings(AkDeviceSettings out_settings);
    static /*0x20f2250*/ void GetDefaultMusicSettings(AkMusicSettings out_settings);
    static /*0x20f2334*/ void GetDefaultInitSettings(AkInitSettings out_settings);
    static /*0x20f240c*/ void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings);
    static /*0x20f24e4*/ uint GetMajorMinorVersion();
    static /*0x20f2594*/ uint GetSubminorBuildVersion();
    static /*0x20f2644*/ void StartResourceMonitoring();
    static /*0x20f26f4*/ void StopResourceMonitoring();
    static /*0x20f27a4*/ void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary);
    static /*0x20f2888*/ void StartDeviceCapture(ulong in_idOutputDeviceID);
    static /*0x20f2958*/ void StopDeviceCapture(ulong in_idOutputDeviceID);
    static /*0x20f2a28*/ void ClearCaptureData();
    static /*0x20f2ad8*/ uint UpdateCaptureSampleCount(ulong in_idOutputDeviceID);
    static /*0x20f2ba8*/ uint GetCaptureSamples(ulong in_idOutputDeviceID, float[] out_pSamples, uint in_uBufferSize);
    static /*0x20f2cb0*/ AKRESULT SetRoomPortal(ulong in_PortalID, ulong FrontRoom, ulong BackRoom, AkTransform Transform, AkExtent Extent, bool bEnabled, string in_pName);
    static /*0x20f2e50*/ AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, ulong GeometryInstanceID, string in_pName);
    static /*0x20f2f98*/ AKRESULT RegisterSpatialAudioListener(ulong in_gameObjectID);
    static /*0x20f3068*/ AKRESULT UnregisterSpatialAudioListener(ulong in_gameObjectID);
    static /*0x20f3138*/ AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, UnityEngine.Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges);
    static /*0x20f3304*/ AKRESULT SetGeometryInstance(ulong in_GeomInstanceID, AkTransform Transform, UnityEngine.Vector3 Scale, ulong GeometrySetID, ulong RoomID, bool UseForReflectionAndDiffraction);
    static /*0x20f3498*/ AKRESULT QueryReflectionPaths(ulong in_gameObjectID, uint in_positionIndex, ref UnityEngine.Vector3 out_listenerPos, ref UnityEngine.Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, ref uint io_uArraySize);
    static /*0x20f35f0*/ AKRESULT QueryDiffractionPaths(ulong in_gameObjectID, uint in_positionIndex, ref UnityEngine.Vector3 out_listenerPos, ref UnityEngine.Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, ref uint io_uArraySize);
    static /*0x20f3748*/ void PerformStreamMgrIO();
    static /*0x20f1104*/ string StringFromIntPtrOSString(nint ptr);
    static /*0x20f37f8*/ string StringFromIntPtrString(nint ptr);
    static /*0x20f3850*/ string StringFromIntPtrWString(nint ptr);
    static /*0x20f38a8*/ ulong InternalGameObjectHash(UnityEngine.GameObject gameObject);
    static /*0x20f392c*/ void set_GameObjectHash(AkSoundEngine.GameObjectHashFunction value);
    static /*0x20d7ebc*/ ulong GetAkGameObjectID(UnityEngine.GameObject gameObject);
    static /*0x20f3a80*/ AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject);
    static /*0x20f3bb8*/ AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject, string name);
    static /*0x20f3c64*/ AKRESULT UnregisterGameObj(UnityEngine.GameObject gameObject);
    static /*0x20f3ddc*/ AKRESULT UnregisterAllGameObjects();
    static /*0x20f3eb0*/ string get_WwiseVersion();
    static /*0x20f40b4*/ AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Transform transform);
    static /*0x20f41e0*/ AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ);
    static /*0x20f42dc*/ void PreGameObjectAPICall(UnityEngine.GameObject gameObject, ulong id);
    static /*0x20f4340*/ void PreGameObjectAPICallUserHook(UnityEngine.GameObject gameObject, ulong id);
    static /*0x20f3b1c*/ void PostRegisterGameObjUserHook(AKRESULT result, UnityEngine.GameObject gameObject, ulong id);
    static /*0x20f3d40*/ void PostUnregisterGameObjUserHook(AKRESULT result, UnityEngine.GameObject gameObject, ulong id);
    static /*0x20f3e38*/ void ClearRegisteredGameObjects();
    static /*0x20f43e4*/ uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType);
    static /*0x20f453c*/ uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20f468c*/ uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID);
    static /*0x20f4764*/ uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID);
    static /*0x20f4900*/ uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources);
    static /*0x20f4a8c*/ uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20f4be4*/ uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f4cc4*/ uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID);
    static /*0x20f4e60*/ uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources);
    static /*0x20f4fec*/ uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    static /*0x20f5144*/ uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f5224*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID);
    static /*0x20f52f4*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f53b4*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration);
    static /*0x20f546c*/ AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f5514*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID);
    static /*0x20f55e4*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f56a4*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration);
    static /*0x20f575c*/ AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f5804*/ AKRESULT PostMIDIOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts);
    static /*0x20f58c8*/ AKRESULT StopMIDIOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f5968*/ AKRESULT StopMIDIOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_playingID);
    static /*0x20f5a10*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20f5ad0*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker);
    static /*0x20f5b88*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition);
    static /*0x20f5c30*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20f5cf0*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker);
    static /*0x20f5da8*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition);
    static /*0x20f5e50*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20f5f18*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker);
    static /*0x20f5fd0*/ AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent);
    static /*0x20f6080*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID);
    static /*0x20f6148*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker);
    static /*0x20f6200*/ AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent);
    static /*0x20f62b0*/ void CancelEventCallbackGameObject(UnityEngine.GameObject in_gameObjectID);
    static /*0x20f6340*/ void StopAll(UnityEngine.GameObject in_gameObjectID);
    static /*0x20f63d0*/ AKRESULT SendPluginCustomGameData(uint in_busID, UnityEngine.GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, nint in_pData, uint in_uSizeInBytes);
    static /*0x20f64a8*/ AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType);
    static /*0x20f6560*/ AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions);
    static /*0x20f6608*/ AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType);
    static /*0x20f66c0*/ AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions);
    static /*0x20f6768*/ AKRESULT SetScalingFactor(UnityEngine.GameObject in_GameObjectID, float in_fAttenuationScalingFactor);
    static /*0x20f6800*/ AKRESULT AddListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj);
    static /*0x20f68b8*/ AKRESULT RemoveListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj);
    static /*0x20f6970*/ AKRESULT AddDefaultListener(UnityEngine.GameObject in_listenerGameObj);
    static /*0x20f6a00*/ AKRESULT RemoveDefaultListener(UnityEngine.GameObject in_listenerGameObj);
    static /*0x20f6a90*/ AKRESULT ResetListenersToDefault(UnityEngine.GameObject in_emitterGameObj);
    static /*0x20f6b20*/ AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets);
    static /*0x20f6be0*/ AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig);
    static /*0x20f6c90*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20f6d60*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f6e28*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20f6ee0*/ AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f6f90*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20f7060*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f7128*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20f71e0*/ AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7290*/ AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20f7350*/ AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f7408*/ AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20f74b0*/ AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7550*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation);
    static /*0x20f7610*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve);
    static /*0x20f76c8*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration);
    static /*0x20f7770*/ AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7810*/ AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f78b8*/ AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7960*/ AKRESULT PostTrigger(uint in_triggerID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7a00*/ AKRESULT PostTrigger(string in_pszTrigger, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f7aa0*/ AKRESULT SetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues);
    static /*0x20f7b54*/ AKRESULT SetGameObjectOutputBusVolume(UnityEngine.GameObject in_emitterObjID, UnityEngine.GameObject in_listenerObjID, float in_fControlValue);
    static /*0x20f7c1c*/ AKRESULT SetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel);
    static /*0x20f7cec*/ AKRESULT SetMultipleObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction);
    static /*0x20f7dd4*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus);
    static /*0x20f7ea4*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID);
    static /*0x20f7f64*/ AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID);
    static /*0x20f801c*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus);
    static /*0x20f80ec*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID);
    static /*0x20f81ac*/ AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID);
    static /*0x20f8264*/ AKRESULT GetPosition(UnityEngine.GameObject in_GameObjectID, AkTransform out_rPosition);
    static /*0x20f830c*/ AKRESULT GetListenerPosition(UnityEngine.GameObject in_uIndex, AkTransform out_rPosition);
    static /*0x20f83c0*/ AKRESULT GetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, uint in_playingID, ref float out_rValue, ref int io_rValueType);
    static /*0x20f8480*/ AKRESULT GetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, uint in_playingID, ref float out_rValue, ref int io_rValueType);
    static /*0x20f8540*/ AKRESULT GetSwitch(uint in_switchGroup, UnityEngine.GameObject in_gameObjectID, ref uint out_rSwitchState);
    static /*0x20f85e8*/ AKRESULT GetSwitch(string in_pstrSwitchGroupName, UnityEngine.GameObject in_GameObj, ref uint out_rSwitchState);
    static /*0x20f8688*/ AKRESULT GetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues);
    static /*0x20f873c*/ AKRESULT GetGameObjectDryLevelValue(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, ref float out_rfControlValue);
    static /*0x20f87fc*/ AKRESULT GetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, ref float out_rfObstructionLevel, ref float out_rfOcclusionLevel);
    static /*0x20f88cc*/ bool GetIsGameObjectActive(UnityEngine.GameObject in_GameObjId);
    static /*0x20f895c*/ float GetMaxRadius(UnityEngine.GameObject in_GameObjId);
    static /*0x20f89ec*/ AKRESULT GetPlayingIDsFromGameObject(UnityEngine.GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs);
    static /*0x20f8a94*/ AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_imageSourceName, uint in_AuxBusID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f8b5c*/ AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f8c04*/ AKRESULT ClearImageSources(uint in_AuxBusID, UnityEngine.GameObject in_gameObjectID);
    static /*0x20f8ca4*/ AKRESULT QueryReflectionPaths(UnityEngine.GameObject in_gameObjectID, uint in_positionIndex, ref UnityEngine.Vector3 out_listenerPos, ref UnityEngine.Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, ref uint io_uArraySize);
    static /*0x20f8d8c*/ AKRESULT SetGameObjectInRoom(UnityEngine.GameObject in_gameObjectID, ulong in_CurrentRoomID);
    static /*0x20f8e2c*/ AKRESULT SetEarlyReflectionsAuxSend(UnityEngine.GameObject in_gameObjectID, uint in_auxBusID);
    static /*0x20f8ecc*/ AKRESULT SetEarlyReflectionsVolume(UnityEngine.GameObject in_gameObjectID, float in_fSendVolume);
    static /*0x20f8f6c*/ AKRESULT QueryDiffractionPaths(UnityEngine.GameObject in_gameObjectID, uint in_positionIndex, ref UnityEngine.Vector3 out_listenerPos, ref UnityEngine.Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, ref uint io_uArraySize);
    static /*0x20f9054*/ AKRESULT RegisterGameObjInternal(UnityEngine.GameObject in_GameObj);
    static /*0x20f90dc*/ AKRESULT UnregisterGameObjInternal(UnityEngine.GameObject in_GameObj);
    static /*0x20f9164*/ AKRESULT RegisterGameObjInternal_WithName(UnityEngine.GameObject in_GameObj, string in_pszObjName);
    static /*0x20f91fc*/ AKRESULT SetObjectPosition(UnityEngine.GameObject in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top);
    static /*0x20f92ec*/ AKRESULT SetListeners(UnityEngine.GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners);
    static /*0x20f9394*/ AKRESULT RegisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID);
    static /*0x20f9424*/ AKRESULT UnregisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID);
    /*0x20f94b4*/ AkSoundEngine();

    class AutoObject
    {
        /*0x10*/ UnityEngine.GameObject gameObject;

        /*0x20d7cb8*/ AutoObject(UnityEngine.GameObject go);
        /*0x20f95b0*/ void Finalize();
    }

    class GameObjectHashFunction : System.MulticastDelegate
    {
        /*0x20f39d0*/ GameObjectHashFunction(object object, nint method);
        /*0x20f9684*/ ulong Invoke(UnityEngine.GameObject gameObject);
        /*0x20f9698*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject gameObject, System.AsyncCallback callback, object object);
        /*0x20f96b8*/ ulong EndInvoke(System.IAsyncResult result);
    }
}

enum AkAudioAPI
{
    AkAudioAPI_AAudio = 1,
    AkAudioAPI_OpenSL_ES = 2,
    AkAudioAPI_Default = 3,
}

class AkCommunicationSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20f0440*/ nint getCPtr(AkCommunicationSettings obj);
    /*0x20f96e0*/ AkCommunicationSettings(nint cPtr, bool cMemoryOwn);
    /*0x20f99f4*/ AkCommunicationSettings();
    /*0x20f9710*/ void setCPtr(nint cPtr);
    /*0x20f97a0*/ void Finalize();
    /*0x20f9734*/ void Dispose();
    /*0x20f9830*/ void Dispose(bool disposing);
    /*0x20f9ac8*/ void set_uPoolSize(uint value);
    /*0x20f9bb4*/ uint get_uPoolSize();
    /*0x20f9c88*/ void set_uDiscoveryBroadcastPort(ushort value);
    /*0x20f9d74*/ ushort get_uDiscoveryBroadcastPort();
    /*0x20f9e48*/ void set_uCommandPort(ushort value);
    /*0x20f9f34*/ ushort get_uCommandPort();
    /*0x20fa008*/ void set_commSystem(AkCommunicationSettings.AkCommSystem value);
    /*0x20fa0f4*/ AkCommunicationSettings.AkCommSystem get_commSystem();
    /*0x20fa1c8*/ void set_bInitSystemLib(bool value);
    /*0x20fa2b4*/ bool get_bInitSystemLib();
    /*0x20fa390*/ void set_szAppNetworkName(string value);
    /*0x20fa490*/ string get_szAppNetworkName();

    enum AkCommSystem
    {
        AkCommSystem_Socket = 0,
        AkCommSystem_HTCS = 1,
    }
}

class AkPlatformInitSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20eff0c*/ nint getCPtr(AkPlatformInitSettings obj);
    /*0x20fa598*/ AkPlatformInitSettings(nint cPtr, bool cMemoryOwn);
    /*0x20fa5c8*/ void setCPtr(nint cPtr);
    /*0x20fa658*/ void Finalize();
    /*0x20fa5ec*/ void Dispose();
    /*0x20fa6e8*/ void Dispose(bool disposing);
    /*0x20fa8ac*/ void set_threadLEngine(AkThreadProperties value);
    /*0x20fa998*/ AkThreadProperties get_threadLEngine();
    /*0x20faae4*/ void set_threadOutputMgr(AkThreadProperties value);
    /*0x20fabd0*/ AkThreadProperties get_threadOutputMgr();
    /*0x20facec*/ void set_threadBankManager(AkThreadProperties value);
    /*0x20fadd8*/ AkThreadProperties get_threadBankManager();
    /*0x20faef4*/ void set_threadMonitor(AkThreadProperties value);
    /*0x20fafe0*/ AkThreadProperties get_threadMonitor();
    /*0x20fb0fc*/ void set_eAudioAPI(AkAudioAPI value);
    /*0x20fb1e8*/ AkAudioAPI get_eAudioAPI();
    /*0x20fb2bc*/ void set_uSampleRate(uint value);
    /*0x20fb3a8*/ uint get_uSampleRate();
    /*0x20fb47c*/ void set_uNumRefillsInVoice(ushort value);
    /*0x20fb568*/ ushort get_uNumRefillsInVoice();
    /*0x20fb63c*/ void set_bRoundFrameSizeToHWSize(bool value);
    /*0x20fb728*/ bool get_bRoundFrameSizeToHWSize();
    /*0x20fb804*/ void set_bVerboseSink(bool value);
    /*0x20fb8f0*/ bool get_bVerboseSink();
    /*0x20fb9cc*/ void set_bEnableLowLatency(bool value);
    /*0x20fbab8*/ bool get_bEnableLowLatency();
}

class AkSoundEnginePINVOKE
{
    static /*0x20fbb94*/ AkSoundEnginePINVOKE();
    static /*0x20d7f7c*/ uint CSharp_AK_INVALID_SHARE_SET_ID_get();
    static /*0x20d802c*/ uint CSharp_AK_INVALID_PIPELINE_ID_get();
    static /*0x20d80dc*/ ulong CSharp_AK_INVALID_AUDIO_OBJECT_ID_get();
    static /*0x20d818c*/ uint CSharp_AK_SOUNDBANK_VERSION_get();
    static /*0x20d823c*/ uint CSharp_AkJobType_Generic_get();
    static /*0x20d82ec*/ uint CSharp_AkJobType_AudioProcessing_get();
    static /*0x20d839c*/ uint CSharp_AkJobType_SpatialAudio_get();
    static /*0x20d844c*/ uint CSharp_AK_NUM_JOB_TYPES_get();
    static /*0x20fbb98*/ void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(nint jarg1, uint jarg2);
    static /*0x20fbc1c*/ uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(nint jarg1);
    static /*0x20fbc98*/ void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(nint jarg1, uint jarg2);
    static /*0x20fbd1c*/ uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(nint jarg1);
    static /*0x20fbd98*/ nint CSharp_new_AkAudioSettings();
    static /*0x20fbdfc*/ void CSharp_delete_AkAudioSettings(nint jarg1);
    static /*0x20fbe78*/ void CSharp_AkDeviceDescription_idDevice_set(nint jarg1, uint jarg2);
    static /*0x20fbefc*/ uint CSharp_AkDeviceDescription_idDevice_get(nint jarg1);
    static /*0x20fbf78*/ void CSharp_AkDeviceDescription_deviceName_set(nint jarg1, string jarg2);
    static /*0x20fc010*/ nint CSharp_AkDeviceDescription_deviceName_get(nint jarg1);
    static /*0x20fc08c*/ void CSharp_AkDeviceDescription_deviceStateMask_set(nint jarg1, int jarg2);
    static /*0x20fc110*/ int CSharp_AkDeviceDescription_deviceStateMask_get(nint jarg1);
    static /*0x20fc18c*/ void CSharp_AkDeviceDescription_isDefaultDevice_set(nint jarg1, bool jarg2);
    static /*0x20fc210*/ bool CSharp_AkDeviceDescription_isDefaultDevice_get(nint jarg1);
    static /*0x20fc294*/ void CSharp_AkDeviceDescription_Clear(nint jarg1);
    static /*0x20fc310*/ int CSharp_AkDeviceDescription_GetSizeOf();
    static /*0x20fc374*/ void CSharp_AkDeviceDescription_Clone(nint jarg1, nint jarg2);
    static /*0x20fc3f8*/ nint CSharp_new_AkDeviceDescription();
    static /*0x20fc45c*/ void CSharp_delete_AkDeviceDescription(nint jarg1);
    static /*0x20fc4d8*/ AkVector64 CSharp_AkWorldTransform_Position(nint jarg1);
    static /*0x20fc5bc*/ UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationFront(nint jarg1);
    static /*0x20fc638*/ UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationTop(nint jarg1);
    static /*0x20fc6b4*/ void CSharp_AkWorldTransform_Set__SWIG_0(nint jarg1, AkVector64 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4);
    static /*0x20fc788*/ void CSharp_AkWorldTransform_Set__SWIG_1(nint jarg1, double jarg2, double jarg3, double jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);
    static /*0x20fc86c*/ void CSharp_AkWorldTransform_SetPosition__SWIG_0(nint jarg1, AkVector64 jarg2);
    static /*0x20fc8f8*/ void CSharp_AkWorldTransform_SetPosition__SWIG_1(nint jarg1, double jarg2, double jarg3, double jarg4);
    static /*0x20fc99c*/ void CSharp_AkWorldTransform_SetOrientation__SWIG_0(nint jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3);
    static /*0x20fca60*/ void CSharp_AkWorldTransform_SetOrientation__SWIG_1(nint jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);
    static /*0x20fcb24*/ nint CSharp_new_AkWorldTransform();
    static /*0x20fcb88*/ void CSharp_delete_AkWorldTransform(nint jarg1);
    static /*0x20fcc04*/ UnityEngine.Vector3 CSharp_AkTransform_Position(nint jarg1);
    static /*0x20fcc80*/ UnityEngine.Vector3 CSharp_AkTransform_OrientationFront(nint jarg1);
    static /*0x20fccfc*/ UnityEngine.Vector3 CSharp_AkTransform_OrientationTop(nint jarg1);
    static /*0x20fcd78*/ void CSharp_AkTransform_Set__SWIG_0(nint jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4);
    static /*0x20fce54*/ void CSharp_AkTransform_Set__SWIG_1(nint jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);
    static /*0x20fcf38*/ void CSharp_AkTransform_SetPosition__SWIG_0(nint jarg1, UnityEngine.Vector3 jarg2);
    static /*0x20fcfdc*/ void CSharp_AkTransform_SetPosition__SWIG_1(nint jarg1, float jarg2, float jarg3, float jarg4);
    static /*0x20fd080*/ void CSharp_AkTransform_SetOrientation__SWIG_0(nint jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3);
    static /*0x20fd144*/ void CSharp_AkTransform_SetOrientation__SWIG_1(nint jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);
    static /*0x20fd208*/ nint CSharp_new_AkTransform();
    static /*0x20fd26c*/ void CSharp_delete_AkTransform(nint jarg1);
    static /*0x20d8504*/ UnityEngine.Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1);
    static /*0x20d8630*/ nint CSharp_ConvertAkWorldTransformToAkTransform(nint jarg1);
    static /*0x20d8720*/ AkVector64 CSharp_ConvertAkVectorToAkVector64(UnityEngine.Vector3 jarg1);
    static /*0x20d88c8*/ nint CSharp_ConvertAkTransformToAkWorldTransform(nint jarg1);
    static /*0x20fd2e8*/ void CSharp_AkObstructionOcclusionValues_occlusion_set(nint jarg1, float jarg2);
    static /*0x20fd374*/ float CSharp_AkObstructionOcclusionValues_occlusion_get(nint jarg1);
    static /*0x20fd3f0*/ void CSharp_AkObstructionOcclusionValues_obstruction_set(nint jarg1, float jarg2);
    static /*0x20fd47c*/ float CSharp_AkObstructionOcclusionValues_obstruction_get(nint jarg1);
    static /*0x20fd4f8*/ void CSharp_AkObstructionOcclusionValues_Clear(nint jarg1);
    static /*0x20fd574*/ int CSharp_AkObstructionOcclusionValues_GetSizeOf();
    static /*0x20fd5d8*/ void CSharp_AkObstructionOcclusionValues_Clone(nint jarg1, nint jarg2);
    static /*0x20fd65c*/ nint CSharp_new_AkObstructionOcclusionValues();
    static /*0x20fd6c0*/ void CSharp_delete_AkObstructionOcclusionValues(nint jarg1);
    static /*0x20fd73c*/ void CSharp_AkChannelEmitter_position_set(nint jarg1, nint jarg2);
    static /*0x20fd7c0*/ nint CSharp_AkChannelEmitter_position_get(nint jarg1);
    static /*0x20fd83c*/ void CSharp_AkChannelEmitter_uInputChannels_set(nint jarg1, uint jarg2);
    static /*0x20fd8c0*/ uint CSharp_AkChannelEmitter_uInputChannels_get(nint jarg1);
    static /*0x20fd93c*/ void CSharp_AkChannelEmitter_padding_set(nint jarg1, string jarg2);
    static /*0x20fd9d4*/ nint CSharp_AkChannelEmitter_padding_get(nint jarg1);
    static /*0x20fda50*/ void CSharp_delete_AkChannelEmitter(nint jarg1);
    static /*0x20fdacc*/ void CSharp_AkAuxSendValue_listenerID_set(nint jarg1, ulong jarg2);
    static /*0x20fdb50*/ ulong CSharp_AkAuxSendValue_listenerID_get(nint jarg1);
    static /*0x20fdbcc*/ void CSharp_AkAuxSendValue_auxBusID_set(nint jarg1, uint jarg2);
    static /*0x20fdc50*/ uint CSharp_AkAuxSendValue_auxBusID_get(nint jarg1);
    static /*0x20fdccc*/ void CSharp_AkAuxSendValue_fControlValue_set(nint jarg1, float jarg2);
    static /*0x20fdd58*/ float CSharp_AkAuxSendValue_fControlValue_get(nint jarg1);
    static /*0x20fddd4*/ void CSharp_AkAuxSendValue_Set(nint jarg1, ulong jarg2, uint jarg3, float jarg4);
    static /*0x20fde78*/ bool CSharp_AkAuxSendValue_IsSame(nint jarg1, ulong jarg2, uint jarg3);
    static /*0x20fdf14*/ int CSharp_AkAuxSendValue_GetSizeOf();
    static /*0x20fdf78*/ void CSharp_delete_AkAuxSendValue(nint jarg1);
    static /*0x20fdff4*/ nint CSharp_new_AkRamp__SWIG_0();
    static /*0x20fe058*/ nint CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2);
    static /*0x20fe0d8*/ void CSharp_AkRamp_fPrev_set(nint jarg1, float jarg2);
    static /*0x20fe164*/ float CSharp_AkRamp_fPrev_get(nint jarg1);
    static /*0x20fe1e0*/ void CSharp_AkRamp_fNext_set(nint jarg1, float jarg2);
    static /*0x20fe26c*/ float CSharp_AkRamp_fNext_get(nint jarg1);
    static /*0x20fe2e8*/ void CSharp_delete_AkRamp(nint jarg1);
    static /*0x20d8990*/ ushort CSharp_AK_INT_get();
    static /*0x20d8a40*/ ushort CSharp_AK_FLOAT_get();
    static /*0x20d8af0*/ byte CSharp_AK_INTERLEAVED_get();
    static /*0x20d8ba0*/ byte CSharp_AK_NONINTERLEAVED_get();
    static /*0x20d8c50*/ uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get();
    static /*0x20d8d00*/ uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get();
    static /*0x20d8db0*/ uint CSharp_AK_LE_NATIVE_INTERLEAVE_get();
    static /*0x20fe364*/ void CSharp_AkAudioFormat_uSampleRate_set(nint jarg1, uint jarg2);
    static /*0x20fe3e8*/ uint CSharp_AkAudioFormat_uSampleRate_get(nint jarg1);
    static /*0x20fe464*/ void CSharp_AkAudioFormat_channelConfig_set(nint jarg1, nint jarg2);
    static /*0x20fe4e8*/ nint CSharp_AkAudioFormat_channelConfig_get(nint jarg1);
    static /*0x20fe564*/ void CSharp_AkAudioFormat_uBitsPerSample_set(nint jarg1, uint jarg2);
    static /*0x20fe5e8*/ uint CSharp_AkAudioFormat_uBitsPerSample_get(nint jarg1);
    static /*0x20fe664*/ void CSharp_AkAudioFormat_uBlockAlign_set(nint jarg1, uint jarg2);
    static /*0x20fe6e8*/ uint CSharp_AkAudioFormat_uBlockAlign_get(nint jarg1);
    static /*0x20fe764*/ void CSharp_AkAudioFormat_uTypeID_set(nint jarg1, uint jarg2);
    static /*0x20fe7e8*/ uint CSharp_AkAudioFormat_uTypeID_get(nint jarg1);
    static /*0x20fe864*/ void CSharp_AkAudioFormat_uInterleaveID_set(nint jarg1, uint jarg2);
    static /*0x20fe8e8*/ uint CSharp_AkAudioFormat_uInterleaveID_get(nint jarg1);
    static /*0x20fe964*/ uint CSharp_AkAudioFormat_GetNumChannels(nint jarg1);
    static /*0x20fe9e0*/ uint CSharp_AkAudioFormat_GetBitsPerSample(nint jarg1);
    static /*0x20fea5c*/ uint CSharp_AkAudioFormat_GetBlockAlign(nint jarg1);
    static /*0x20fead8*/ uint CSharp_AkAudioFormat_GetTypeID(nint jarg1);
    static /*0x20feb54*/ uint CSharp_AkAudioFormat_GetInterleaveID(nint jarg1);
    static /*0x20febd0*/ void CSharp_AkAudioFormat_SetAll(nint jarg1, uint jarg2, nint jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7);
    static /*0x20fec94*/ nint CSharp_new_AkAudioFormat();
    static /*0x20fecf8*/ void CSharp_delete_AkAudioFormat(nint jarg1);
    static /*0x20d8e68*/ bool CSharp_IsBankCodecID(uint jarg1);
    static /*0x20fed74*/ nint CSharp_new_Ak3dData();
    static /*0x20fedd8*/ void CSharp_Ak3dData_xform_set(nint jarg1, nint jarg2);
    static /*0x20fee5c*/ nint CSharp_Ak3dData_xform_get(nint jarg1);
    static /*0x20feed8*/ void CSharp_Ak3dData_spread_set(nint jarg1, float jarg2);
    static /*0x20fef64*/ float CSharp_Ak3dData_spread_get(nint jarg1);
    static /*0x20fefe0*/ void CSharp_Ak3dData_focus_set(nint jarg1, float jarg2);
    static /*0x20ff06c*/ float CSharp_Ak3dData_focus_get(nint jarg1);
    static /*0x20ff0e8*/ void CSharp_Ak3dData_uEmitterChannelMask_set(nint jarg1, uint jarg2);
    static /*0x20ff16c*/ uint CSharp_Ak3dData_uEmitterChannelMask_get(nint jarg1);
    static /*0x20ff1e8*/ void CSharp_delete_Ak3dData(nint jarg1);
    static /*0x20ff264*/ nint CSharp_new_AkBehavioralPositioningData();
    static /*0x20ff2c8*/ void CSharp_AkBehavioralPositioningData_center_set(nint jarg1, float jarg2);
    static /*0x20ff354*/ float CSharp_AkBehavioralPositioningData_center_get(nint jarg1);
    static /*0x20ff3d0*/ void CSharp_AkBehavioralPositioningData_panLR_set(nint jarg1, float jarg2);
    static /*0x20ff45c*/ float CSharp_AkBehavioralPositioningData_panLR_get(nint jarg1);
    static /*0x20ff4d8*/ void CSharp_AkBehavioralPositioningData_panBF_set(nint jarg1, float jarg2);
    static /*0x20ff564*/ float CSharp_AkBehavioralPositioningData_panBF_get(nint jarg1);
    static /*0x20ff5e0*/ void CSharp_AkBehavioralPositioningData_panDU_set(nint jarg1, float jarg2);
    static /*0x20ff66c*/ float CSharp_AkBehavioralPositioningData_panDU_get(nint jarg1);
    static /*0x20ff6e8*/ void CSharp_AkBehavioralPositioningData_panSpatMix_set(nint jarg1, float jarg2);
    static /*0x20ff774*/ float CSharp_AkBehavioralPositioningData_panSpatMix_get(nint jarg1);
    static /*0x20ff7f0*/ void CSharp_AkBehavioralPositioningData_spatMode_set(nint jarg1, int jarg2);
    static /*0x20ff874*/ int CSharp_AkBehavioralPositioningData_spatMode_get(nint jarg1);
    static /*0x20ff8f0*/ void CSharp_AkBehavioralPositioningData_panType_set(nint jarg1, int jarg2);
    static /*0x20ff974*/ int CSharp_AkBehavioralPositioningData_panType_get(nint jarg1);
    static /*0x20ff9f0*/ void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(nint jarg1, bool jarg2);
    static /*0x20ffa74*/ bool CSharp_AkBehavioralPositioningData_enableHeightSpread_get(nint jarg1);
    static /*0x20ffaf8*/ void CSharp_delete_AkBehavioralPositioningData(nint jarg1);
    static /*0x20ffb74*/ void CSharp_AkPositioningData_threeD_set(nint jarg1, nint jarg2);
    static /*0x20ffbf8*/ nint CSharp_AkPositioningData_threeD_get(nint jarg1);
    static /*0x20ffc74*/ void CSharp_AkPositioningData_behavioral_set(nint jarg1, nint jarg2);
    static /*0x20ffcf8*/ nint CSharp_AkPositioningData_behavioral_get(nint jarg1);
    static /*0x20ffd74*/ nint CSharp_new_AkPositioningData();
    static /*0x20ffdd8*/ void CSharp_delete_AkPositioningData(nint jarg1);
    static /*0x20ffe54*/ void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(nint jarg1, nint jarg2);
    static /*0x20ffed8*/ nint CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(nint jarg1);
    static /*0x20fff54*/ void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(nint jarg1, uint jarg2);
    static /*0x20fffd8*/ uint CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(nint jarg1);
    static /*0x2100054*/ void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(nint jarg1, uint jarg2);
    static /*0x21000d8*/ uint CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(nint jarg1);
    static /*0x2100154*/ void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(nint jarg1, bool jarg2);
    static /*0x21001d8*/ bool CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(nint jarg1);
    static /*0x210025c*/ void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(nint jarg1, bool jarg2);
    static /*0x21002e0*/ bool CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(nint jarg1);
    static /*0x2100364*/ nint CSharp_new_Ak3DAudioSinkCapabilities();
    static /*0x21003c8*/ void CSharp_delete_Ak3DAudioSinkCapabilities(nint jarg1);
    static /*0x2100444*/ void CSharp_AkIterator_pItem_set(nint jarg1, nint jarg2);
    static /*0x21004c8*/ nint CSharp_AkIterator_pItem_get(nint jarg1);
    static /*0x2100544*/ nint CSharp_AkIterator_NextIter(nint jarg1);
    static /*0x21005c0*/ nint CSharp_AkIterator_PrevIter(nint jarg1);
    static /*0x210063c*/ nint CSharp_AkIterator_GetItem(nint jarg1);
    static /*0x21006b8*/ bool CSharp_AkIterator_IsEqualTo(nint jarg1, nint jarg2);
    static /*0x2100744*/ bool CSharp_AkIterator_IsDifferentFrom(nint jarg1, nint jarg2);
    static /*0x21007d0*/ nint CSharp_new_AkIterator();
    static /*0x2100834*/ void CSharp_delete_AkIterator(nint jarg1);
    static /*0x21008b0*/ bool CSharp_AkStdMovePolicy_IsTrivial();
    static /*0x210091c*/ nint CSharp_new_AkStdMovePolicy();
    static /*0x2100980*/ void CSharp_delete_AkStdMovePolicy(nint jarg1);
    static /*0x21009fc*/ bool CSharp_AkTrivialStdMovePolicy_IsTrivial();
    static /*0x2100a68*/ nint CSharp_new_AkTrivialStdMovePolicy();
    static /*0x2100acc*/ void CSharp_delete_AkTrivialStdMovePolicy(nint jarg1);
    static /*0x2100b48*/ nint CSharp_new_AkPlaylistItem__SWIG_0();
    static /*0x2100bac*/ nint CSharp_new_AkPlaylistItem__SWIG_1(nint jarg1);
    static /*0x2100c28*/ void CSharp_delete_AkPlaylistItem(nint jarg1);
    static /*0x2100ca4*/ nint CSharp_AkPlaylistItem_Assign(nint jarg1, nint jarg2);
    static /*0x2100d28*/ bool CSharp_AkPlaylistItem_IsEqualTo(nint jarg1, nint jarg2);
    static /*0x2100db4*/ int CSharp_AkPlaylistItem_SetExternalSources(nint jarg1, uint jarg2, nint jarg3);
    static /*0x2100e48*/ void CSharp_AkPlaylistItem_audioNodeID_set(nint jarg1, uint jarg2);
    static /*0x2100ecc*/ uint CSharp_AkPlaylistItem_audioNodeID_get(nint jarg1);
    static /*0x2100f48*/ void CSharp_AkPlaylistItem_msDelay_set(nint jarg1, int jarg2);
    static /*0x2100fcc*/ int CSharp_AkPlaylistItem_msDelay_get(nint jarg1);
    static /*0x2101048*/ void CSharp_AkPlaylistItem_pCustomInfo_set(nint jarg1, nint jarg2);
    static /*0x21010cc*/ nint CSharp_AkPlaylistItem_pCustomInfo_get(nint jarg1);
    static /*0x2101148*/ nint CSharp_new_AkPlaylistArray();
    static /*0x21011ac*/ void CSharp_delete_AkPlaylistArray(nint jarg1);
    static /*0x2101228*/ nint CSharp_AkPlaylistArray_Begin(nint jarg1);
    static /*0x21012a4*/ nint CSharp_AkPlaylistArray_End(nint jarg1);
    static /*0x2101320*/ nint CSharp_AkPlaylistArray_FindEx(nint jarg1, nint jarg2);
    static /*0x21013a4*/ nint CSharp_AkPlaylistArray_Erase__SWIG_0(nint jarg1, nint jarg2);
    static /*0x2101428*/ void CSharp_AkPlaylistArray_Erase__SWIG_1(nint jarg1, uint jarg2);
    static /*0x21014ac*/ nint CSharp_AkPlaylistArray_EraseSwap__SWIG_0(nint jarg1, nint jarg2);
    static /*0x2101530*/ void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(nint jarg1, uint jarg2);
    static /*0x21015b4*/ bool CSharp_AkPlaylistArray_IsGrowingAllowed(nint jarg1);
    static /*0x2101638*/ int CSharp_AkPlaylistArray_Reserve(nint jarg1, uint jarg2);
    static /*0x21016bc*/ int CSharp_AkPlaylistArray_ReserveExtra(nint jarg1, uint jarg2);
    static /*0x2101740*/ uint CSharp_AkPlaylistArray_Reserved(nint jarg1);
    static /*0x21017bc*/ void CSharp_AkPlaylistArray_Term(nint jarg1);
    static /*0x2101838*/ uint CSharp_AkPlaylistArray_Length(nint jarg1);
    static /*0x21018b4*/ nint CSharp_AkPlaylistArray_Data(nint jarg1);
    static /*0x2101930*/ bool CSharp_AkPlaylistArray_IsEmpty(nint jarg1);
    static /*0x21019b4*/ nint CSharp_AkPlaylistArray_Exists(nint jarg1, nint jarg2);
    static /*0x2101a38*/ nint CSharp_AkPlaylistArray_AddLast__SWIG_0(nint jarg1);
    static /*0x2101ab4*/ nint CSharp_AkPlaylistArray_AddLast__SWIG_1(nint jarg1, nint jarg2);
    static /*0x2101b38*/ nint CSharp_AkPlaylistArray_Last(nint jarg1);
    static /*0x2101bb4*/ void CSharp_AkPlaylistArray_RemoveLast(nint jarg1);
    static /*0x2101c30*/ int CSharp_AkPlaylistArray_Remove(nint jarg1, nint jarg2);
    static /*0x2101cb4*/ int CSharp_AkPlaylistArray_RemoveSwap(nint jarg1, nint jarg2);
    static /*0x2101d38*/ void CSharp_AkPlaylistArray_RemoveAll(nint jarg1);
    static /*0x2101db4*/ nint CSharp_AkPlaylistArray_ItemAtIndex(nint jarg1, uint jarg2);
    static /*0x2101e38*/ nint CSharp_AkPlaylistArray_Insert__SWIG_0(nint jarg1, nint jarg2);
    static /*0x2101ebc*/ nint CSharp_AkPlaylistArray_Insert__SWIG_1(nint jarg1, uint jarg2);
    static /*0x2101f40*/ bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(nint jarg1);
    static /*0x2101fc4*/ bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(nint jarg1, uint jarg2);
    static /*0x2102050*/ bool CSharp_AkPlaylistArray_Resize(nint jarg1, uint jarg2);
    static /*0x21020dc*/ void CSharp_AkPlaylistArray_Transfer(nint jarg1, nint jarg2);
    static /*0x2102160*/ int CSharp_AkPlaylistArray_Copy(nint jarg1, nint jarg2);
    static /*0x21021e4*/ int CSharp_AkPlaylist_Enqueue__SWIG_0(nint jarg1, uint jarg2, int jarg3, nint jarg4, uint jarg5, nint jarg6);
    static /*0x2102298*/ int CSharp_AkPlaylist_Enqueue__SWIG_1(nint jarg1, uint jarg2, int jarg3, nint jarg4, uint jarg5);
    static /*0x2102344*/ int CSharp_AkPlaylist_Enqueue__SWIG_2(nint jarg1, uint jarg2, int jarg3, nint jarg4);
    static /*0x21023e0*/ int CSharp_AkPlaylist_Enqueue__SWIG_3(nint jarg1, uint jarg2, int jarg3);
    static /*0x2102474*/ int CSharp_AkPlaylist_Enqueue__SWIG_4(nint jarg1, uint jarg2);
    static /*0x21024f8*/ nint CSharp_new_AkPlaylist();
    static /*0x210255c*/ void CSharp_delete_AkPlaylist(nint jarg1);
    static /*0x20d9008*/ uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, nint jarg3, nint jarg4, int jarg5);
    static /*0x20d91c8*/ uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, nint jarg3, nint jarg4);
    static /*0x20d92f8*/ uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1);
    static /*0x20d93c8*/ int CSharp_DynamicSequenceClose(uint jarg1);
    static /*0x20d94b0*/ int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3);
    static /*0x20d95a8*/ int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2);
    static /*0x20d9680*/ int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1);
    static /*0x20d9768*/ int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3);
    static /*0x20d9860*/ int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2);
    static /*0x20d9938*/ int CSharp_DynamicSequencePause__SWIG_2(uint jarg1);
    static /*0x20d9a20*/ int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3);
    static /*0x20d9b18*/ int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2);
    static /*0x20d9bf0*/ int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1);
    static /*0x20d9cd8*/ int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3);
    static /*0x20d9dd0*/ int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2);
    static /*0x20d9ea8*/ int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1);
    static /*0x20d9f78*/ int CSharp_DynamicSequenceBreak(uint jarg1);
    static /*0x20da060*/ int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3);
    static /*0x20da168*/ int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3);
    static /*0x20da268*/ int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, ref uint jarg2, ref uint jarg3);
    static /*0x20da398*/ nint CSharp_DynamicSequenceLockPlaylist(uint jarg1);
    static /*0x20da468*/ int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1);
    static /*0x21025d8*/ nint CSharp_new_AkOutputSettings__SWIG_0();
    static /*0x210263c*/ nint CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, nint jarg3, int jarg4);
    static /*0x21026f0*/ nint CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, nint jarg3);
    static /*0x210279c*/ nint CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2);
    static /*0x2102838*/ nint CSharp_new_AkOutputSettings__SWIG_4(string jarg1);
    static /*0x21028cc*/ void CSharp_AkOutputSettings_audioDeviceShareset_set(nint jarg1, uint jarg2);
    static /*0x2102950*/ uint CSharp_AkOutputSettings_audioDeviceShareset_get(nint jarg1);
    static /*0x21029cc*/ void CSharp_AkOutputSettings_idDevice_set(nint jarg1, uint jarg2);
    static /*0x2102a50*/ uint CSharp_AkOutputSettings_idDevice_get(nint jarg1);
    static /*0x2102acc*/ void CSharp_AkOutputSettings_ePanningRule_set(nint jarg1, int jarg2);
    static /*0x2102b50*/ int CSharp_AkOutputSettings_ePanningRule_get(nint jarg1);
    static /*0x2102bcc*/ void CSharp_AkOutputSettings_channelConfig_set(nint jarg1, nint jarg2);
    static /*0x2102c50*/ nint CSharp_AkOutputSettings_channelConfig_get(nint jarg1);
    static /*0x2102ccc*/ void CSharp_delete_AkOutputSettings(nint jarg1);
    static /*0x2102d48*/ void CSharp_AkInitSettings_uMaxNumPaths_set(nint jarg1, uint jarg2);
    static /*0x2102dcc*/ uint CSharp_AkInitSettings_uMaxNumPaths_get(nint jarg1);
    static /*0x2102e48*/ void CSharp_AkInitSettings_uCommandQueueSize_set(nint jarg1, uint jarg2);
    static /*0x2102ecc*/ uint CSharp_AkInitSettings_uCommandQueueSize_get(nint jarg1);
    static /*0x2102f48*/ void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(nint jarg1, bool jarg2);
    static /*0x2102fcc*/ bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(nint jarg1);
    static /*0x2103050*/ void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(nint jarg1, uint jarg2);
    static /*0x21030d4*/ uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(nint jarg1);
    static /*0x2103150*/ void CSharp_AkInitSettings_uNumSamplesPerFrame_set(nint jarg1, uint jarg2);
    static /*0x21031d4*/ uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(nint jarg1);
    static /*0x2103250*/ void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(nint jarg1, uint jarg2);
    static /*0x21032d4*/ uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(nint jarg1);
    static /*0x2103350*/ void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(nint jarg1, uint jarg2);
    static /*0x21033d4*/ uint CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(nint jarg1);
    static /*0x2103450*/ void CSharp_AkInitSettings_settingsMainOutput_set(nint jarg1, nint jarg2);
    static /*0x21034d4*/ nint CSharp_AkInitSettings_settingsMainOutput_get(nint jarg1);
    static /*0x2103550*/ void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(nint jarg1, uint jarg2);
    static /*0x21035d4*/ uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(nint jarg1);
    static /*0x2103650*/ void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(nint jarg1, bool jarg2);
    static /*0x21036d4*/ bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(nint jarg1);
    static /*0x2103758*/ void CSharp_AkInitSettings_bUseLEngineThread_set(nint jarg1, bool jarg2);
    static /*0x21037dc*/ bool CSharp_AkInitSettings_bUseLEngineThread_get(nint jarg1);
    static /*0x2103860*/ void CSharp_AkInitSettings_szPluginDLLPath_set(nint jarg1, string jarg2);
    static /*0x21038f8*/ nint CSharp_AkInitSettings_szPluginDLLPath_get(nint jarg1);
    static /*0x2103974*/ void CSharp_AkInitSettings_eFloorPlane_set(nint jarg1, int jarg2);
    static /*0x21039f8*/ int CSharp_AkInitSettings_eFloorPlane_get(nint jarg1);
    static /*0x2103a74*/ void CSharp_AkInitSettings_fGameUnitsToMeters_set(nint jarg1, float jarg2);
    static /*0x2103b00*/ float CSharp_AkInitSettings_fGameUnitsToMeters_get(nint jarg1);
    static /*0x2103b7c*/ void CSharp_AkInitSettings_uBankReadBufferSize_set(nint jarg1, uint jarg2);
    static /*0x2103c00*/ uint CSharp_AkInitSettings_uBankReadBufferSize_get(nint jarg1);
    static /*0x2103c7c*/ void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(nint jarg1, float jarg2);
    static /*0x2103d08*/ float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(nint jarg1);
    static /*0x2103d84*/ void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(nint jarg1, bool jarg2);
    static /*0x2103e08*/ bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(nint jarg1);
    static /*0x2103e8c*/ void CSharp_delete_AkInitSettings(nint jarg1);
    static /*0x2103f08*/ void CSharp_AkSourceSettings_sourceID_set(nint jarg1, uint jarg2);
    static /*0x2103f8c*/ uint CSharp_AkSourceSettings_sourceID_get(nint jarg1);
    static /*0x2104008*/ void CSharp_AkSourceSettings_pMediaMemory_set(nint jarg1, nint jarg2);
    static /*0x210408c*/ nint CSharp_AkSourceSettings_pMediaMemory_get(nint jarg1);
    static /*0x2104108*/ void CSharp_AkSourceSettings_uMediaSize_set(nint jarg1, uint jarg2);
    static /*0x210418c*/ uint CSharp_AkSourceSettings_uMediaSize_get(nint jarg1);
    static /*0x2104208*/ void CSharp_AkSourceSettings_Clear(nint jarg1);
    static /*0x2104284*/ int CSharp_AkSourceSettings_GetSizeOf();
    static /*0x21042e8*/ void CSharp_AkSourceSettings_Clone(nint jarg1, nint jarg2);
    static /*0x210436c*/ nint CSharp_new_AkSourceSettings();
    static /*0x21043d0*/ void CSharp_delete_AkSourceSettings(nint jarg1);
    static /*0x20da530*/ bool CSharp_IsInitialized();
    static /*0x20da604*/ int CSharp_GetAudioSettings(nint jarg1);
    static /*0x20da718*/ nint CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1);
    static /*0x20da854*/ nint CSharp_GetSpeakerConfiguration__SWIG_1();
    static /*0x20da94c*/ int CSharp_GetOutputDeviceConfiguration(ulong jarg1, nint jarg2, nint jarg3);
    static /*0x20daa44*/ int CSharp_GetPanningRule__SWIG_0(ref int jarg1, ulong jarg2);
    static /*0x20dab1c*/ int CSharp_GetPanningRule__SWIG_1(ref int jarg1);
    static /*0x20dabfc*/ int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2);
    static /*0x20dacd4*/ int CSharp_SetPanningRule__SWIG_1(int jarg1);
    static /*0x20dadcc*/ int CSharp_GetSpeakerAngles__SWIG_0(float[] jarg1, ref uint jarg2, ref float jarg3, ulong jarg4);
    static /*0x20daedc*/ int CSharp_GetSpeakerAngles__SWIG_1(float[] jarg1, ref uint jarg2, ref float jarg3);
    static /*0x20daff4*/ int CSharp_SetSpeakerAngles__SWIG_0(float[] jarg1, uint jarg2, float jarg3, ulong jarg4);
    static /*0x20db114*/ int CSharp_SetSpeakerAngles__SWIG_1(float[] jarg1, uint jarg2, float jarg3);
    static /*0x20db20c*/ int CSharp_SetVolumeThreshold(float jarg1);
    static /*0x20db2d8*/ int CSharp_SetMaxNumVoicesLimit(ushort jarg1);
    static /*0x20db3b8*/ int CSharp_SetJobMgrMaxActiveWorkers(uint jarg1, uint jarg2);
    static /*0x20db490*/ int CSharp_RenderAudio__SWIG_0(bool jarg1);
    static /*0x20db558*/ int CSharp_RenderAudio__SWIG_1();
    static /*0x20db620*/ int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2);
    static /*0x20db728*/ int CSharp_RegisterPluginDLL__SWIG_1(string jarg1);
    static /*0x20db828*/ bool CSharp_IsPluginRegistered(int jarg1, uint jarg2, uint jarg3);
    static /*0x20db918*/ uint CSharp_GetIDFromString(string jarg1);
    static /*0x20dbb0c*/ uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5, uint jarg6, nint jarg7, uint jarg8);
    static /*0x20dbd28*/ uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5, uint jarg6, nint jarg7);
    static /*0x20dbf08*/ uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5);
    static /*0x20dc058*/ uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2);
    static /*0x20dc23c*/ uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5, uint jarg6, nint jarg7, uint jarg8);
    static /*0x20dc470*/ uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5, uint jarg6, nint jarg7);
    static /*0x20dc668*/ uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, nint jarg4, nint jarg5);
    static /*0x20dc7d0*/ uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2);
    static /*0x20dc900*/ int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);
    static /*0x20dca38*/ int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);
    static /*0x20dcb60*/ int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4);
    static /*0x20dcc68*/ int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3);
    static /*0x20dcd60*/ int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2);
    static /*0x20dce78*/ int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);
    static /*0x20dcfc8*/ int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);
    static /*0x20dd108*/ int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4);
    static /*0x20dd228*/ int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3);
    static /*0x20dd338*/ int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2);
    static /*0x20dd534*/ uint CSharp_PostMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, nint jarg3, ushort jarg4, bool jarg5, uint jarg6, nint jarg7, nint jarg8, uint jarg9);
    static /*0x20dd760*/ uint CSharp_PostMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2, nint jarg3, ushort jarg4, bool jarg5, uint jarg6, nint jarg7, nint jarg8);
    static /*0x20dd8fc*/ uint CSharp_PostMIDIOnEvent__SWIG_2(uint jarg1, ulong jarg2, nint jarg3, ushort jarg4, bool jarg5);
    static /*0x20dda68*/ uint CSharp_PostMIDIOnEvent__SWIG_3(uint jarg1, ulong jarg2, nint jarg3, ushort jarg4);
    static /*0x20ddb70*/ int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3);
    static /*0x20ddc68*/ int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2);
    static /*0x20ddd40*/ int CSharp_StopMIDIOnEvent__SWIG_2(uint jarg1);
    static /*0x20dde08*/ int CSharp_StopMIDIOnEvent__SWIG_3();
    static /*0x20dded8*/ int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3);
    static /*0x20ddfd8*/ int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3);
    static /*0x20de0d8*/ int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1);
    static /*0x20de1a8*/ int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1);
    static /*0x20de2a8*/ int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, ref float jarg2, ref int jarg3);
    static /*0x20de3a8*/ int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, ref float jarg2, ref int jarg3);
    static /*0x20de4d8*/ int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);
    static /*0x20de600*/ int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4);
    static /*0x20de708*/ int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3);
    static /*0x20de820*/ int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);
    static /*0x20de960*/ int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4);
    static /*0x20dea80*/ int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3);
    static /*0x20debb8*/ int CSharp_SeekOnEvent__SWIG_6(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);
    static /*0x20dece0*/ int CSharp_SeekOnEvent__SWIG_7(uint jarg1, ulong jarg2, float jarg3, bool jarg4);
    static /*0x20dedf8*/ int CSharp_SeekOnEvent__SWIG_8(uint jarg1, ulong jarg2, float jarg3);
    static /*0x20def18*/ int CSharp_SeekOnEvent__SWIG_9(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);
    static /*0x20df058*/ int CSharp_SeekOnEvent__SWIG_10(string jarg1, ulong jarg2, float jarg3, bool jarg4);
    static /*0x20df188*/ int CSharp_SeekOnEvent__SWIG_11(string jarg1, ulong jarg2, float jarg3);
    static /*0x210444c*/ void CSharp_CancelEventCallbackCookie(nint jarg1);
    static /*0x20df2e0*/ void CSharp_CancelEventCallbackGameObject(ulong jarg1);
    static /*0x21044c8*/ void CSharp_CancelEventCallback(uint jarg1);
    static /*0x20df420*/ int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, ref int jarg2, bool jarg3);
    static /*0x20df518*/ int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, ref int jarg2);
    static /*0x20df608*/ int CSharp_GetSourceStreamBuffering(uint jarg1, ref int jarg2, ref int jarg3);
    static /*0x20df6f0*/ void CSharp_StopAll__SWIG_0(ulong jarg1);
    static /*0x20df7b8*/ void CSharp_StopAll__SWIG_1();
    static /*0x20df888*/ void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3);
    static /*0x20df980*/ void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2);
    static /*0x20dfa58*/ void CSharp_StopPlayingID__SWIG_2(uint jarg1);
    static /*0x20dfb50*/ void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4);
    static /*0x20dfc58*/ void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3);
    static /*0x20dfd50*/ void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2);
    static /*0x20dfe28*/ void CSharp_SetRandomSeed(uint jarg1);
    static /*0x20dfef8*/ void CSharp_MuteBackgroundMusic(bool jarg1);
    static /*0x20dffc0*/ bool CSharp_GetBackgroundMusicMute();
    static /*0x20e00c8*/ int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, nint jarg6, uint jarg7);
    static /*0x20e01d8*/ int CSharp_UnregisterAllGameObj();
    static /*0x20e02cc*/ int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, nint jarg2, ushort jarg3, int jarg4, int jarg5);
    static /*0x20e03f8*/ int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, nint jarg2, ushort jarg3, int jarg4);
    static /*0x20e050c*/ int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, nint jarg2, ushort jarg3);
    static /*0x20e0630*/ int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, nint jarg2, ushort jarg3, int jarg4, int jarg5);
    static /*0x20e075c*/ int CSharp_SetMultiplePositions__SWIG_4(ulong jarg1, nint jarg2, ushort jarg3, int jarg4);
    static /*0x20e0870*/ int CSharp_SetMultiplePositions__SWIG_5(ulong jarg1, nint jarg2, ushort jarg3);
    static /*0x20e0968*/ int CSharp_SetScalingFactor(ulong jarg1, float jarg2);
    static /*0x20e0a58*/ int CSharp_SetDistanceProbe(ulong jarg1, ulong jarg2);
    static /*0x20e0b28*/ int CSharp_ClearBanks();
    static /*0x20e0bf0*/ int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2);
    static /*0x20e0ce8*/ int CSharp_LoadBank__SWIG_0(string jarg1, ref uint jarg2, uint jarg3);
    static /*0x20e0df8*/ int CSharp_LoadBank__SWIG_1(string jarg1, ref uint jarg2);
    static /*0x20e0ef8*/ int CSharp_LoadBank__SWIG_2(uint jarg1, uint jarg2);
    static /*0x20e0fd0*/ int CSharp_LoadBank__SWIG_3(uint jarg1);
    static /*0x20e10b8*/ int CSharp_LoadBankMemoryView__SWIG_0(nint jarg1, uint jarg2, ref uint jarg3);
    static /*0x20e11c8*/ int CSharp_LoadBankMemoryView__SWIG_1(nint jarg1, uint jarg2, ref uint jarg3, ref uint jarg4);
    static /*0x20e12d0*/ int CSharp_LoadBankMemoryCopy__SWIG_0(nint jarg1, uint jarg2, ref uint jarg3);
    static /*0x20e13e0*/ int CSharp_LoadBankMemoryCopy__SWIG_1(nint jarg1, uint jarg2, ref uint jarg3, ref uint jarg4);
    static /*0x20e1558*/ int CSharp_LoadBank__SWIG_4(string jarg1, nint jarg2, nint jarg3, ref uint jarg4, uint jarg5);
    static /*0x20e16f0*/ int CSharp_LoadBank__SWIG_5(string jarg1, nint jarg2, nint jarg3, ref uint jarg4);
    static /*0x20e1878*/ int CSharp_LoadBank__SWIG_6(uint jarg1, nint jarg2, nint jarg3, uint jarg4);
    static /*0x20e19d8*/ int CSharp_LoadBank__SWIG_7(uint jarg1, nint jarg2, nint jarg3);
    static /*0x20e1b48*/ int CSharp_LoadBankMemoryView__SWIG_2(nint jarg1, uint jarg2, nint jarg3, nint jarg4, ref uint jarg5);
    static /*0x20e1ce0*/ int CSharp_LoadBankMemoryView__SWIG_3(nint jarg1, uint jarg2, nint jarg3, nint jarg4, ref uint jarg5, ref uint jarg6);
    static /*0x20e1e70*/ int CSharp_LoadBankMemoryCopy__SWIG_2(nint jarg1, uint jarg2, nint jarg3, nint jarg4, ref uint jarg5);
    static /*0x20e2008*/ int CSharp_LoadBankMemoryCopy__SWIG_3(nint jarg1, uint jarg2, nint jarg3, nint jarg4, ref uint jarg5, ref uint jarg6);
    static /*0x20e2128*/ int CSharp_UnloadBank__SWIG_0(string jarg1, nint jarg2, uint jarg3);
    static /*0x20e2238*/ int CSharp_UnloadBank__SWIG_1(string jarg1, nint jarg2);
    static /*0x20e2340*/ int CSharp_UnloadBank__SWIG_2(uint jarg1, nint jarg2, uint jarg3);
    static /*0x20e2438*/ int CSharp_UnloadBank__SWIG_3(uint jarg1, nint jarg2);
    static /*0x20e2598*/ int CSharp_UnloadBank__SWIG_4(string jarg1, nint jarg2, nint jarg3, nint jarg4, uint jarg5);
    static /*0x20e2730*/ int CSharp_UnloadBank__SWIG_5(string jarg1, nint jarg2, nint jarg3, nint jarg4);
    static /*0x20e28c0*/ int CSharp_UnloadBank__SWIG_6(uint jarg1, nint jarg2, nint jarg3, nint jarg4, uint jarg5);
    static /*0x20e2a40*/ int CSharp_UnloadBank__SWIG_7(uint jarg1, nint jarg2, nint jarg3, nint jarg4);
    static /*0x2104544*/ void CSharp_CancelBankCallbackCookie(nint jarg1);
    static /*0x20e2bb0*/ int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3, uint jarg4);
    static /*0x20e2cd4*/ int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2, int jarg3);
    static /*0x20e2de8*/ int CSharp_PrepareBank__SWIG_2(int jarg1, string jarg2);
    static /*0x20e2f04*/ int CSharp_PrepareBank__SWIG_3(int jarg1, uint jarg2, int jarg3, uint jarg4);
    static /*0x20e300c*/ int CSharp_PrepareBank__SWIG_4(int jarg1, uint jarg2, int jarg3);
    static /*0x20e3104*/ int CSharp_PrepareBank__SWIG_5(int jarg1, uint jarg2);
    static /*0x20e3274*/ int CSharp_PrepareBank__SWIG_6(int jarg1, string jarg2, nint jarg3, nint jarg4, int jarg5, uint jarg6);
    static /*0x20e3420*/ int CSharp_PrepareBank__SWIG_7(int jarg1, string jarg2, nint jarg3, nint jarg4, int jarg5);
    static /*0x20e35bc*/ int CSharp_PrepareBank__SWIG_8(int jarg1, string jarg2, nint jarg3, nint jarg4);
    static /*0x20e3760*/ int CSharp_PrepareBank__SWIG_9(int jarg1, uint jarg2, nint jarg3, nint jarg4, int jarg5, uint jarg6);
    static /*0x20e38f0*/ int CSharp_PrepareBank__SWIG_10(int jarg1, uint jarg2, nint jarg3, nint jarg4, int jarg5);
    static /*0x20e3a70*/ int CSharp_PrepareBank__SWIG_11(int jarg1, uint jarg2, nint jarg3, nint jarg4);
    static /*0x20e3b58*/ int CSharp_ClearPreparedEvents();
    static /*0x20e3e60*/ int CSharp_PrepareEvent__SWIG_0(int jarg1, nint jarg2, uint jarg3);
    static /*0x20e3f60*/ int CSharp_PrepareEvent__SWIG_1(int jarg1, uint[] jarg2, uint jarg3);
    static /*0x20e4314*/ int CSharp_PrepareEvent__SWIG_2(int jarg1, nint jarg2, uint jarg3, nint jarg4, nint jarg5);
    static /*0x20e449c*/ int CSharp_PrepareEvent__SWIG_3(int jarg1, uint[] jarg2, uint jarg3, nint jarg4, nint jarg5);
    static /*0x20e45c4*/ int CSharp_SetMedia(nint jarg1, uint jarg2);
    static /*0x20e46bc*/ int CSharp_UnsetMedia(nint jarg1, uint jarg2);
    static /*0x20e49f8*/ int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, nint jarg4, uint jarg5);
    static /*0x20e4b44*/ int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, uint[] jarg4, uint jarg5);
    static /*0x20e4f2c*/ int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, nint jarg4, uint jarg5, nint jarg6, nint jarg7);
    static /*0x20e5100*/ int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, uint[] jarg4, uint jarg5, nint jarg6, nint jarg7);
    static /*0x20e5230*/ int CSharp_AddListener(ulong jarg1, ulong jarg2);
    static /*0x20e5318*/ int CSharp_RemoveListener(ulong jarg1, ulong jarg2);
    static /*0x20e53f0*/ int CSharp_AddDefaultListener(ulong jarg1);
    static /*0x20e54c0*/ int CSharp_RemoveDefaultListener(ulong jarg1);
    static /*0x20e5590*/ int CSharp_ResetListenersToDefault(ulong jarg1);
    static /*0x20e5688*/ int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, nint jarg3, float[] jarg4);
    static /*0x20e57a0*/ int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, nint jarg3);
    static /*0x20e58c8*/ int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);
    static /*0x20e5a10*/ int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);
    static /*0x20e5b38*/ int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4);
    static /*0x20e5c50*/ int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3);
    static /*0x20e5d48*/ int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2);
    static /*0x20e5e68*/ int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);
    static /*0x20e5fc8*/ int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);
    static /*0x20e6108*/ int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4);
    static /*0x20e6238*/ int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3);
    static /*0x20e6348*/ int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2);
    static /*0x20e6480*/ int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);
    static /*0x20e65c8*/ int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);
    static /*0x20e66f0*/ int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4);
    static /*0x20e6808*/ int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3);
    static /*0x20e6930*/ int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);
    static /*0x20e6a90*/ int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);
    static /*0x20e6bd0*/ int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4);
    static /*0x20e6d00*/ int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3);
    static /*0x20e6e30*/ int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);
    static /*0x20e6f58*/ int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4);
    static /*0x20e7060*/ int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3);
    static /*0x20e7158*/ int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2);
    static /*0x20e7230*/ int CSharp_ResetRTPCValue__SWIG_4(uint jarg1);
    static /*0x20e7330*/ int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);
    static /*0x20e7470*/ int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4);
    static /*0x20e7590*/ int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3);
    static /*0x20e76a0*/ int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2);
    static /*0x20e7790*/ int CSharp_ResetRTPCValue__SWIG_9(string jarg1);
    static /*0x20e7890*/ int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3);
    static /*0x20e7990*/ int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3);
    static /*0x20e7ab4*/ int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2);
    static /*0x20e7b9c*/ int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2);
    static /*0x20e7c9c*/ int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2);
    static /*0x20e7d84*/ int CSharp_SetState__SWIG_1(string jarg1, string jarg2);
    static /*0x20e7eb0*/ int CSharp_SetGameObjectAuxSendValues(ulong jarg1, nint jarg2, uint jarg3);
    static /*0x20e7fb8*/ int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3);
    static /*0x20e80b8*/ int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3);
    static /*0x20e81b8*/ int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3);
    static /*0x20e82b8*/ int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3);
    static /*0x20e83d0*/ int CSharp_SetOutputDeviceEffect(ulong jarg1, uint jarg2, uint jarg3);
    static /*0x20e84c8*/ int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2);
    static /*0x20e85b0*/ int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2);
    static /*0x20e86b0*/ int CSharp_SetBusConfig__SWIG_0(uint jarg1, nint jarg2);
    static /*0x20e8798*/ int CSharp_SetBusConfig__SWIG_1(string jarg1, nint jarg2);
    static /*0x20e88b0*/ int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4);
    static /*0x20e89d8*/ int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, nint jarg3, uint jarg4);
    static /*0x20e8ac8*/ int CSharp_StartOutputCapture(string jarg1);
    static /*0x20e8ba8*/ int CSharp_StopOutputCapture();
    static /*0x20e8c60*/ int CSharp_AddOutputCaptureMarker(string jarg1);
    static /*0x20e8d58*/ int CSharp_AddOutputCaptureBinaryMarker(nint jarg1, uint jarg2);
    static /*0x20e8e28*/ uint CSharp_GetSampleRate();
    static /*0x20e8ee0*/ int CSharp_StartProfilerCapture(string jarg1);
    static /*0x20e8fc0*/ int CSharp_StopProfilerCapture();
    static /*0x20e9080*/ int CSharp_SetOfflineRenderingFrameTime(float jarg1);
    static /*0x20e914c*/ int CSharp_SetOfflineRendering(bool jarg1);
    static /*0x20e921c*/ int CSharp_RemoveOutput(ulong jarg1);
    static /*0x20e9318*/ int CSharp_ReplaceOutput__SWIG_0(nint jarg1, ulong jarg2, ref ulong jarg3);
    static /*0x20e9424*/ int CSharp_ReplaceOutput__SWIG_1(nint jarg1, ulong jarg2);
    static /*0x20e950c*/ ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2);
    static /*0x20e95f4*/ ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2);
    static /*0x20e96f4*/ int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2);
    static /*0x20e97dc*/ int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2);
    static /*0x20e991c*/ int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, ref uint jarg3, nint jarg4);
    static /*0x20e9a3c*/ int CSharp_GetDeviceList__SWIG_1(uint jarg1, ref uint jarg2, nint jarg3);
    static /*0x20e9b34*/ int CSharp_SetOutputVolume(ulong jarg1, float jarg2);
    static /*0x20e9c14*/ int CSharp_GetDeviceSpatialAudioSupport(uint jarg1);
    static /*0x20e9cf4*/ int CSharp_Suspend__SWIG_0(bool jarg1, bool jarg2);
    static /*0x20e9dcc*/ int CSharp_Suspend__SWIG_1(bool jarg1);
    static /*0x20e9e94*/ int CSharp_Suspend__SWIG_2();
    static /*0x20e9f4c*/ int CSharp_WakeupFromSuspend__SWIG_0(uint jarg1);
    static /*0x20ea014*/ int CSharp_WakeupFromSuspend__SWIG_1();
    static /*0x20ea0c4*/ uint CSharp_GetBufferTick();
    static /*0x20ea174*/ ulong CSharp_GetSampleTick();
    static /*0x21045c0*/ void CSharp_AkSegmentInfo_iCurrentPosition_set(nint jarg1, int jarg2);
    static /*0x2104644*/ int CSharp_AkSegmentInfo_iCurrentPosition_get(nint jarg1);
    static /*0x21046c0*/ void CSharp_AkSegmentInfo_iPreEntryDuration_set(nint jarg1, int jarg2);
    static /*0x2104744*/ int CSharp_AkSegmentInfo_iPreEntryDuration_get(nint jarg1);
    static /*0x21047c0*/ void CSharp_AkSegmentInfo_iActiveDuration_set(nint jarg1, int jarg2);
    static /*0x2104844*/ int CSharp_AkSegmentInfo_iActiveDuration_get(nint jarg1);
    static /*0x21048c0*/ void CSharp_AkSegmentInfo_iPostExitDuration_set(nint jarg1, int jarg2);
    static /*0x2104944*/ int CSharp_AkSegmentInfo_iPostExitDuration_get(nint jarg1);
    static /*0x21049c0*/ void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(nint jarg1, int jarg2);
    static /*0x2104a44*/ int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(nint jarg1);
    static /*0x2104ac0*/ void CSharp_AkSegmentInfo_fBeatDuration_set(nint jarg1, float jarg2);
    static /*0x2104b4c*/ float CSharp_AkSegmentInfo_fBeatDuration_get(nint jarg1);
    static /*0x2104bc8*/ void CSharp_AkSegmentInfo_fBarDuration_set(nint jarg1, float jarg2);
    static /*0x2104c54*/ float CSharp_AkSegmentInfo_fBarDuration_get(nint jarg1);
    static /*0x2104cd0*/ void CSharp_AkSegmentInfo_fGridDuration_set(nint jarg1, float jarg2);
    static /*0x2104d5c*/ float CSharp_AkSegmentInfo_fGridDuration_get(nint jarg1);
    static /*0x2104dd8*/ void CSharp_AkSegmentInfo_fGridOffset_set(nint jarg1, float jarg2);
    static /*0x2104e64*/ float CSharp_AkSegmentInfo_fGridOffset_get(nint jarg1);
    static /*0x2104ee0*/ nint CSharp_new_AkSegmentInfo();
    static /*0x2104f44*/ void CSharp_delete_AkSegmentInfo(nint jarg1);
    static /*0x2104fc0*/ void CSharp_AkResourceMonitorDataSummary_totalCPU_set(nint jarg1, float jarg2);
    static /*0x210504c*/ float CSharp_AkResourceMonitorDataSummary_totalCPU_get(nint jarg1);
    static /*0x21050c8*/ void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(nint jarg1, float jarg2);
    static /*0x2105154*/ float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(nint jarg1);
    static /*0x21051d0*/ void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(nint jarg1, uint jarg2);
    static /*0x2105254*/ uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(nint jarg1);
    static /*0x21052d0*/ void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(nint jarg1, uint jarg2);
    static /*0x2105354*/ uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(nint jarg1);
    static /*0x21053d0*/ void CSharp_AkResourceMonitorDataSummary_totalVoices_set(nint jarg1, uint jarg2);
    static /*0x2105454*/ uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(nint jarg1);
    static /*0x21054d0*/ void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(nint jarg1, uint jarg2);
    static /*0x2105554*/ uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(nint jarg1);
    static /*0x21055d0*/ nint CSharp_new_AkResourceMonitorDataSummary();
    static /*0x2105634*/ void CSharp_delete_AkResourceMonitorDataSummary(nint jarg1);
    static /*0x20ea224*/ byte CSharp_AK_INVALID_MIDI_CHANNEL_get();
    static /*0x20ea2d4*/ byte CSharp_AK_INVALID_MIDI_NOTE_get();
    static /*0x21056b0*/ void CSharp_AkMIDIEvent_byChan_set(nint jarg1, byte jarg2);
    static /*0x2105734*/ byte CSharp_AkMIDIEvent_byChan_get(nint jarg1);
    static /*0x21057b0*/ void CSharp_AkMIDIEvent_tGen_byParam1_set(nint jarg1, byte jarg2);
    static /*0x2105834*/ byte CSharp_AkMIDIEvent_tGen_byParam1_get(nint jarg1);
    static /*0x21058b0*/ void CSharp_AkMIDIEvent_tGen_byParam2_set(nint jarg1, byte jarg2);
    static /*0x2105934*/ byte CSharp_AkMIDIEvent_tGen_byParam2_get(nint jarg1);
    static /*0x21059b0*/ nint CSharp_new_AkMIDIEvent_tGen();
    static /*0x2105a14*/ void CSharp_delete_AkMIDIEvent_tGen(nint jarg1);
    static /*0x2105a90*/ void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(nint jarg1, byte jarg2);
    static /*0x2105b14*/ byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(nint jarg1);
    static /*0x2105b90*/ void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(nint jarg1, byte jarg2);
    static /*0x2105c14*/ byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(nint jarg1);
    static /*0x2105c90*/ nint CSharp_new_AkMIDIEvent_tNoteOnOff();
    static /*0x2105cf4*/ void CSharp_delete_AkMIDIEvent_tNoteOnOff(nint jarg1);
    static /*0x2105d70*/ void CSharp_AkMIDIEvent_tCc_byCc_set(nint jarg1, byte jarg2);
    static /*0x2105df4*/ byte CSharp_AkMIDIEvent_tCc_byCc_get(nint jarg1);
    static /*0x2105e70*/ void CSharp_AkMIDIEvent_tCc_byValue_set(nint jarg1, byte jarg2);
    static /*0x2105ef4*/ byte CSharp_AkMIDIEvent_tCc_byValue_get(nint jarg1);
    static /*0x2105f70*/ nint CSharp_new_AkMIDIEvent_tCc();
    static /*0x2105fd4*/ void CSharp_delete_AkMIDIEvent_tCc(nint jarg1);
    static /*0x2106050*/ void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(nint jarg1, byte jarg2);
    static /*0x21060d4*/ byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(nint jarg1);
    static /*0x2106150*/ void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(nint jarg1, byte jarg2);
    static /*0x21061d4*/ byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(nint jarg1);
    static /*0x2106250*/ nint CSharp_new_AkMIDIEvent_tPitchBend();
    static /*0x21062b4*/ void CSharp_delete_AkMIDIEvent_tPitchBend(nint jarg1);
    static /*0x2106330*/ void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(nint jarg1, byte jarg2);
    static /*0x21063b4*/ byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(nint jarg1);
    static /*0x2106430*/ void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(nint jarg1, byte jarg2);
    static /*0x21064b4*/ byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(nint jarg1);
    static /*0x2106530*/ nint CSharp_new_AkMIDIEvent_tNoteAftertouch();
    static /*0x2106594*/ void CSharp_delete_AkMIDIEvent_tNoteAftertouch(nint jarg1);
    static /*0x2106610*/ void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(nint jarg1, byte jarg2);
    static /*0x2106694*/ byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(nint jarg1);
    static /*0x2106710*/ nint CSharp_new_AkMIDIEvent_tChanAftertouch();
    static /*0x2106774*/ void CSharp_delete_AkMIDIEvent_tChanAftertouch(nint jarg1);
    static /*0x21067f0*/ void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(nint jarg1, byte jarg2);
    static /*0x2106874*/ byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(nint jarg1);
    static /*0x21068f0*/ nint CSharp_new_AkMIDIEvent_tProgramChange();
    static /*0x2106954*/ void CSharp_delete_AkMIDIEvent_tProgramChange(nint jarg1);
    static /*0x21069d0*/ void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(nint jarg1, ushort jarg2);
    static /*0x2106a54*/ ushort CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(nint jarg1);
    static /*0x2106ad0*/ void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(nint jarg1, uint jarg2);
    static /*0x2106b54*/ uint CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(nint jarg1);
    static /*0x2106bd0*/ nint CSharp_new_AkMIDIEvent_tWwiseCmd();
    static /*0x2106c34*/ void CSharp_delete_AkMIDIEvent_tWwiseCmd(nint jarg1);
    static /*0x2106cb0*/ void CSharp_AkMIDIEvent_Gen_set(nint jarg1, nint jarg2);
    static /*0x2106d34*/ nint CSharp_AkMIDIEvent_Gen_get(nint jarg1);
    static /*0x2106db0*/ void CSharp_AkMIDIEvent_Cc_set(nint jarg1, nint jarg2);
    static /*0x2106e34*/ nint CSharp_AkMIDIEvent_Cc_get(nint jarg1);
    static /*0x2106eb0*/ void CSharp_AkMIDIEvent_NoteOnOff_set(nint jarg1, nint jarg2);
    static /*0x2106f34*/ nint CSharp_AkMIDIEvent_NoteOnOff_get(nint jarg1);
    static /*0x2106fb0*/ void CSharp_AkMIDIEvent_PitchBend_set(nint jarg1, nint jarg2);
    static /*0x2107034*/ nint CSharp_AkMIDIEvent_PitchBend_get(nint jarg1);
    static /*0x21070b0*/ void CSharp_AkMIDIEvent_NoteAftertouch_set(nint jarg1, nint jarg2);
    static /*0x2107134*/ nint CSharp_AkMIDIEvent_NoteAftertouch_get(nint jarg1);
    static /*0x21071b0*/ void CSharp_AkMIDIEvent_ChanAftertouch_set(nint jarg1, nint jarg2);
    static /*0x2107234*/ nint CSharp_AkMIDIEvent_ChanAftertouch_get(nint jarg1);
    static /*0x21072b0*/ void CSharp_AkMIDIEvent_ProgramChange_set(nint jarg1, nint jarg2);
    static /*0x2107334*/ nint CSharp_AkMIDIEvent_ProgramChange_get(nint jarg1);
    static /*0x21073b0*/ void CSharp_AkMIDIEvent_WwiseCmd_set(nint jarg1, nint jarg2);
    static /*0x2107434*/ nint CSharp_AkMIDIEvent_WwiseCmd_get(nint jarg1);
    static /*0x21074b0*/ void CSharp_AkMIDIEvent_byType_set(nint jarg1, int jarg2);
    static /*0x2107534*/ int CSharp_AkMIDIEvent_byType_get(nint jarg1);
    static /*0x21075b0*/ void CSharp_AkMIDIEvent_byOnOffNote_set(nint jarg1, byte jarg2);
    static /*0x2107634*/ byte CSharp_AkMIDIEvent_byOnOffNote_get(nint jarg1);
    static /*0x21076b0*/ void CSharp_AkMIDIEvent_byVelocity_set(nint jarg1, byte jarg2);
    static /*0x2107734*/ byte CSharp_AkMIDIEvent_byVelocity_get(nint jarg1);
    static /*0x21077b0*/ void CSharp_AkMIDIEvent_byCc_set(nint jarg1, int jarg2);
    static /*0x2107834*/ int CSharp_AkMIDIEvent_byCc_get(nint jarg1);
    static /*0x21078b0*/ void CSharp_AkMIDIEvent_byCcValue_set(nint jarg1, byte jarg2);
    static /*0x2107934*/ byte CSharp_AkMIDIEvent_byCcValue_get(nint jarg1);
    static /*0x21079b0*/ void CSharp_AkMIDIEvent_byValueLsb_set(nint jarg1, byte jarg2);
    static /*0x2107a34*/ byte CSharp_AkMIDIEvent_byValueLsb_get(nint jarg1);
    static /*0x2107ab0*/ void CSharp_AkMIDIEvent_byValueMsb_set(nint jarg1, byte jarg2);
    static /*0x2107b34*/ byte CSharp_AkMIDIEvent_byValueMsb_get(nint jarg1);
    static /*0x2107bb0*/ void CSharp_AkMIDIEvent_byAftertouchNote_set(nint jarg1, byte jarg2);
    static /*0x2107c34*/ byte CSharp_AkMIDIEvent_byAftertouchNote_get(nint jarg1);
    static /*0x2107cb0*/ void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(nint jarg1, byte jarg2);
    static /*0x2107d34*/ byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(nint jarg1);
    static /*0x2107db0*/ void CSharp_AkMIDIEvent_byChanAftertouchValue_set(nint jarg1, byte jarg2);
    static /*0x2107e34*/ byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(nint jarg1);
    static /*0x2107eb0*/ void CSharp_AkMIDIEvent_byProgramNum_set(nint jarg1, byte jarg2);
    static /*0x2107f34*/ byte CSharp_AkMIDIEvent_byProgramNum_get(nint jarg1);
    static /*0x2107fb0*/ void CSharp_AkMIDIEvent_uCmd_set(nint jarg1, ushort jarg2);
    static /*0x2108034*/ ushort CSharp_AkMIDIEvent_uCmd_get(nint jarg1);
    static /*0x21080b0*/ void CSharp_AkMIDIEvent_uArg_set(nint jarg1, uint jarg2);
    static /*0x2108134*/ uint CSharp_AkMIDIEvent_uArg_get(nint jarg1);
    static /*0x21081b0*/ nint CSharp_new_AkMIDIEvent();
    static /*0x2108214*/ void CSharp_delete_AkMIDIEvent(nint jarg1);
    static /*0x2108290*/ void CSharp_AkMIDIPost_uOffset_set(nint jarg1, ulong jarg2);
    static /*0x2108314*/ ulong CSharp_AkMIDIPost_uOffset_get(nint jarg1);
    static /*0x2108390*/ uint CSharp_AkMIDIPost_PostOnEvent__SWIG_0(nint jarg1, uint jarg2, ulong jarg3, uint jarg4);
    static /*0x210842c*/ uint CSharp_AkMIDIPost_PostOnEvent__SWIG_1(nint jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5);
    static /*0x21084d8*/ uint CSharp_AkMIDIPost_PostOnEvent__SWIG_2(nint jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, nint jarg7, nint jarg8);
    static /*0x21085a4*/ uint CSharp_AkMIDIPost_PostOnEvent__SWIG_3(nint jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, nint jarg7, nint jarg8, uint jarg9);
    static /*0x2108680*/ void CSharp_AkMIDIPost_Clone(nint jarg1, nint jarg2);
    static /*0x2108704*/ int CSharp_AkMIDIPost_GetSizeOf();
    static /*0x2108768*/ nint CSharp_new_AkMIDIPost();
    static /*0x21087cc*/ void CSharp_delete_AkMIDIPost(nint jarg1);
    static /*0x2108848*/ void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(nint jarg1, float jarg2);
    static /*0x21088d4*/ float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(nint jarg1);
    static /*0x2108950*/ void CSharp_delete_AkMusicSettings(nint jarg1);
    static /*0x20ea3b8*/ int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, nint jarg2, bool jarg3);
    static /*0x20ea4c4*/ int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, nint jarg2);
    static /*0x21089cc*/ nint CSharp_AkSerializedCallbackHeader_pPackage_get(nint jarg1);
    static /*0x2108a48*/ uint CSharp_AkSerializedCallbackHeader_eType_get(nint jarg1);
    static /*0x2108ac4*/ nint CSharp_AkSerializedCallbackHeader_GetData(nint jarg1);
    static /*0x2108b40*/ nint CSharp_AkSerializedCallbackHeader_pNext_get(nint jarg1);
    static /*0x2108bbc*/ nint CSharp_new_AkSerializedCallbackHeader();
    static /*0x2108c20*/ void CSharp_delete_AkSerializedCallbackHeader(nint jarg1);
    static /*0x2108c9c*/ nint CSharp_AkCallbackInfo_pCookie_get(nint jarg1);
    static /*0x2108d18*/ ulong CSharp_AkCallbackInfo_gameObjID_get(nint jarg1);
    static /*0x2108d94*/ nint CSharp_new_AkCallbackInfo();
    static /*0x2108df8*/ void CSharp_delete_AkCallbackInfo(nint jarg1);
    static /*0x2108e74*/ uint CSharp_AkEventCallbackInfo_playingID_get(nint jarg1);
    static /*0x2108ef0*/ uint CSharp_AkEventCallbackInfo_eventID_get(nint jarg1);
    static /*0x2108f6c*/ nint CSharp_new_AkEventCallbackInfo();
    static /*0x2108fd0*/ void CSharp_delete_AkEventCallbackInfo(nint jarg1);
    static /*0x210904c*/ byte CSharp_AkMIDIEventCallbackInfo_byChan_get(nint jarg1);
    static /*0x21090c8*/ byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(nint jarg1);
    static /*0x2109144*/ byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(nint jarg1);
    static /*0x21091c0*/ int CSharp_AkMIDIEventCallbackInfo_byType_get(nint jarg1);
    static /*0x210923c*/ byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(nint jarg1);
    static /*0x21092b8*/ byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(nint jarg1);
    static /*0x2109334*/ int CSharp_AkMIDIEventCallbackInfo_byCc_get(nint jarg1);
    static /*0x21093b0*/ byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(nint jarg1);
    static /*0x210942c*/ byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(nint jarg1);
    static /*0x21094a8*/ byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(nint jarg1);
    static /*0x2109524*/ byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(nint jarg1);
    static /*0x21095a0*/ byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(nint jarg1);
    static /*0x210961c*/ byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(nint jarg1);
    static /*0x2109698*/ byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(nint jarg1);
    static /*0x2109714*/ nint CSharp_new_AkMIDIEventCallbackInfo();
    static /*0x2109778*/ void CSharp_delete_AkMIDIEventCallbackInfo(nint jarg1);
    static /*0x21097f4*/ uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(nint jarg1);
    static /*0x2109870*/ uint CSharp_AkMarkerCallbackInfo_uPosition_get(nint jarg1);
    static /*0x21098ec*/ nint CSharp_AkMarkerCallbackInfo_strLabel_get(nint jarg1);
    static /*0x2109968*/ nint CSharp_new_AkMarkerCallbackInfo();
    static /*0x21099cc*/ void CSharp_delete_AkMarkerCallbackInfo(nint jarg1);
    static /*0x2109a48*/ float CSharp_AkDurationCallbackInfo_fDuration_get(nint jarg1);
    static /*0x2109ac4*/ float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(nint jarg1);
    static /*0x2109b40*/ uint CSharp_AkDurationCallbackInfo_audioNodeID_get(nint jarg1);
    static /*0x2109bbc*/ uint CSharp_AkDurationCallbackInfo_mediaID_get(nint jarg1);
    static /*0x2109c38*/ bool CSharp_AkDurationCallbackInfo_bStreaming_get(nint jarg1);
    static /*0x2109cbc*/ nint CSharp_new_AkDurationCallbackInfo();
    static /*0x2109d20*/ void CSharp_delete_AkDurationCallbackInfo(nint jarg1);
    static /*0x2109d9c*/ uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(nint jarg1);
    static /*0x2109e18*/ uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(nint jarg1);
    static /*0x2109e94*/ nint CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(nint jarg1);
    static /*0x2109f10*/ nint CSharp_new_AkDynamicSequenceItemCallbackInfo();
    static /*0x2109f74*/ void CSharp_delete_AkDynamicSequenceItemCallbackInfo(nint jarg1);
    static /*0x2109ff0*/ uint CSharp_AkMusicSyncCallbackInfo_playingID_get(nint jarg1);
    static /*0x210a06c*/ int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(nint jarg1);
    static /*0x210a0e8*/ int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(nint jarg1);
    static /*0x210a164*/ int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(nint jarg1);
    static /*0x210a1e0*/ int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(nint jarg1);
    static /*0x210a25c*/ int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(nint jarg1);
    static /*0x210a2d8*/ float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(nint jarg1);
    static /*0x210a354*/ float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(nint jarg1);
    static /*0x210a3d0*/ float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(nint jarg1);
    static /*0x210a44c*/ float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(nint jarg1);
    static /*0x210a4c8*/ int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(nint jarg1);
    static /*0x210a544*/ nint CSharp_AkMusicSyncCallbackInfo_userCueName_get(nint jarg1);
    static /*0x210a5c0*/ nint CSharp_new_AkMusicSyncCallbackInfo();
    static /*0x210a624*/ void CSharp_delete_AkMusicSyncCallbackInfo(nint jarg1);
    static /*0x210a6a0*/ uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(nint jarg1);
    static /*0x210a71c*/ uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(nint jarg1);
    static /*0x210a798*/ uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(nint jarg1);
    static /*0x210a814*/ uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(nint jarg1);
    static /*0x210a890*/ nint CSharp_new_AkMusicPlaylistCallbackInfo();
    static /*0x210a8f4*/ void CSharp_delete_AkMusicPlaylistCallbackInfo(nint jarg1);
    static /*0x210a970*/ uint CSharp_AkBankCallbackInfo_bankID_get(nint jarg1);
    static /*0x210a9ec*/ nint CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(nint jarg1);
    static /*0x210aa68*/ int CSharp_AkBankCallbackInfo_loadResult_get(nint jarg1);
    static /*0x210aae4*/ nint CSharp_new_AkBankCallbackInfo();
    static /*0x210ab48*/ void CSharp_delete_AkBankCallbackInfo(nint jarg1);
    static /*0x210abc4*/ int CSharp_AkMonitoringCallbackInfo_errorCode_get(nint jarg1);
    static /*0x210ac40*/ int CSharp_AkMonitoringCallbackInfo_errorLevel_get(nint jarg1);
    static /*0x210acbc*/ uint CSharp_AkMonitoringCallbackInfo_playingID_get(nint jarg1);
    static /*0x210ad38*/ ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(nint jarg1);
    static /*0x210adb4*/ nint CSharp_AkMonitoringCallbackInfo_message_get(nint jarg1);
    static /*0x210ae30*/ nint CSharp_new_AkMonitoringCallbackInfo();
    static /*0x210ae94*/ void CSharp_delete_AkMonitoringCallbackInfo(nint jarg1);
    static /*0x210af10*/ bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(nint jarg1);
    static /*0x210af94*/ nint CSharp_new_AkAudioInterruptionCallbackInfo();
    static /*0x210aff8*/ void CSharp_delete_AkAudioInterruptionCallbackInfo(nint jarg1);
    static /*0x210b074*/ bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(nint jarg1);
    static /*0x210b0f8*/ nint CSharp_new_AkAudioSourceChangeCallbackInfo();
    static /*0x210b15c*/ void CSharp_delete_AkAudioSourceChangeCallbackInfo(nint jarg1);
    static /*0x210b1d8*/ int CSharp_AkCallbackSerializer_Init();
    static /*0x210b23c*/ void CSharp_AkCallbackSerializer_Term();
    static /*0x210b2a0*/ nint CSharp_AkCallbackSerializer_Lock();
    static /*0x210b304*/ void CSharp_AkCallbackSerializer_Unlock();
    static /*0x210b368*/ void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1, string jarg2, uint jarg3, string jarg4, uint jarg5, uint jarg6);
    static /*0x210b444*/ int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, nint jarg2);
    static /*0x210b4c8*/ nint CSharp_new_AkCallbackSerializer();
    static /*0x210b52c*/ void CSharp_delete_AkCallbackSerializer(nint jarg1);
    static /*0x210b5a8*/ nint CSharp_new_MsgContext__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, bool jarg4);
    static /*0x210b644*/ nint CSharp_new_MsgContext__SWIG_1(uint jarg1, ulong jarg2, uint jarg3);
    static /*0x210b6d8*/ nint CSharp_new_MsgContext__SWIG_2(uint jarg1, ulong jarg2);
    static /*0x210b75c*/ nint CSharp_new_MsgContext__SWIG_3(uint jarg1);
    static /*0x210b7d8*/ nint CSharp_new_MsgContext__SWIG_4();
    static /*0x210b83c*/ void CSharp_MsgContext_in_playingID_set(nint jarg1, uint jarg2);
    static /*0x210b8c0*/ uint CSharp_MsgContext_in_playingID_get(nint jarg1);
    static /*0x210b93c*/ void CSharp_MsgContext_in_gameObjID_set(nint jarg1, ulong jarg2);
    static /*0x210b9c0*/ ulong CSharp_MsgContext_in_gameObjID_get(nint jarg1);
    static /*0x210ba3c*/ void CSharp_MsgContext_in_soundID_set(nint jarg1, uint jarg2);
    static /*0x210bac0*/ uint CSharp_MsgContext_in_soundID_get(nint jarg1);
    static /*0x210bb3c*/ void CSharp_MsgContext_in_bIsBus_set(nint jarg1, bool jarg2);
    static /*0x210bbc0*/ bool CSharp_MsgContext_in_bIsBus_get(nint jarg1);
    static /*0x210bc44*/ void CSharp_delete_MsgContext(nint jarg1);
    static /*0x210bcc0*/ nint CSharp_new_MonitorErrorInfo__SWIG_0(string jarg1, string jarg2);
    static /*0x210bd74*/ nint CSharp_new_MonitorErrorInfo__SWIG_1(string jarg1);
    static /*0x210be08*/ nint CSharp_new_MonitorErrorInfo__SWIG_2();
    static /*0x210be6c*/ void CSharp_MonitorErrorInfo_m_name_set(nint jarg1, string jarg2);
    static /*0x210bf04*/ nint CSharp_MonitorErrorInfo_m_name_get(nint jarg1);
    static /*0x210bf80*/ void CSharp_MonitorErrorInfo_m_message_set(nint jarg1, string jarg2);
    static /*0x210c018*/ nint CSharp_MonitorErrorInfo_m_message_get(nint jarg1);
    static /*0x210c094*/ void CSharp_delete_MonitorErrorInfo(nint jarg1);
    static /*0x20ea5dc*/ int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);
    static /*0x20ea714*/ int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);
    static /*0x20ea83c*/ int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4);
    static /*0x20ea944*/ int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3);
    static /*0x20eaa3c*/ int CSharp_PostCode__SWIG_4(int jarg1, int jarg2);
    static /*0x20eab40*/ int CSharp_PostCodeVarArg(int jarg1, int jarg2, nint jarg3);
    static /*0x20eac68*/ int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);
    static /*0x20eadb8*/ int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);
    static /*0x20eaef8*/ int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4);
    static /*0x20eb018*/ int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3);
    static /*0x20eb128*/ int CSharp_PostString__SWIG_4(string jarg1, int jarg2);
    static /*0x20eb210*/ int CSharp_ResetTranslator();
    static /*0x20eb2c0*/ int CSharp_GetTimeStamp();
    static /*0x20eb38c*/ void CSharp_MonitorStreamMgrInit(nint jarg1);
    static /*0x20eb478*/ void CSharp_MonitorStreamingDeviceInit(uint jarg1, nint jarg2);
    static /*0x20eb550*/ void CSharp_MonitorStreamingDeviceDestroyed(uint jarg1);
    static /*0x20eb618*/ void CSharp_MonitorStreamMgrTerm();
    static /*0x20eb6e8*/ void CSharp_AkMemCpy(nint jarg1, nint jarg2, uint jarg3);
    static /*0x20eb7e8*/ void CSharp_AkMemMove(nint jarg1, nint jarg2, uint jarg3);
    static /*0x20eb8e8*/ void CSharp_AkMemSet(nint jarg1, int jarg2, uint jarg3);
    static /*0x20eb9e4*/ void CSharp_AkGetDefaultHighPriorityThreadProperties(nint jarg1);
    static /*0x20ebadc*/ uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, uint[] jarg2, uint jarg3, uint jarg4);
    static /*0x20ebbec*/ uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, uint[] jarg2, uint jarg3);
    static /*0x20ebcf4*/ int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, ref int jarg3);
    static /*0x20ebdf4*/ int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, ref float jarg3);
    static /*0x210c110*/ void CSharp_AkPositioningInfo_fCenterPct_set(nint jarg1, float jarg2);
    static /*0x210c19c*/ float CSharp_AkPositioningInfo_fCenterPct_get(nint jarg1);
    static /*0x210c218*/ void CSharp_AkPositioningInfo_pannerType_set(nint jarg1, int jarg2);
    static /*0x210c29c*/ int CSharp_AkPositioningInfo_pannerType_get(nint jarg1);
    static /*0x210c318*/ void CSharp_AkPositioningInfo_e3dPositioningType_set(nint jarg1, int jarg2);
    static /*0x210c39c*/ int CSharp_AkPositioningInfo_e3dPositioningType_get(nint jarg1);
    static /*0x210c418*/ void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(nint jarg1, bool jarg2);
    static /*0x210c49c*/ bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(nint jarg1);
    static /*0x210c520*/ void CSharp_AkPositioningInfo_e3DSpatializationMode_set(nint jarg1, int jarg2);
    static /*0x210c5a4*/ int CSharp_AkPositioningInfo_e3DSpatializationMode_get(nint jarg1);
    static /*0x210c620*/ void CSharp_AkPositioningInfo_bEnableAttenuation_set(nint jarg1, bool jarg2);
    static /*0x210c6a4*/ bool CSharp_AkPositioningInfo_bEnableAttenuation_get(nint jarg1);
    static /*0x210c728*/ void CSharp_AkPositioningInfo_bUseConeAttenuation_set(nint jarg1, bool jarg2);
    static /*0x210c7ac*/ bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(nint jarg1);
    static /*0x210c830*/ void CSharp_AkPositioningInfo_fInnerAngle_set(nint jarg1, float jarg2);
    static /*0x210c8bc*/ float CSharp_AkPositioningInfo_fInnerAngle_get(nint jarg1);
    static /*0x210c938*/ void CSharp_AkPositioningInfo_fOuterAngle_set(nint jarg1, float jarg2);
    static /*0x210c9c4*/ float CSharp_AkPositioningInfo_fOuterAngle_get(nint jarg1);
    static /*0x210ca40*/ void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(nint jarg1, float jarg2);
    static /*0x210cacc*/ float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(nint jarg1);
    static /*0x210cb48*/ void CSharp_AkPositioningInfo_LPFCone_set(nint jarg1, float jarg2);
    static /*0x210cbd4*/ float CSharp_AkPositioningInfo_LPFCone_get(nint jarg1);
    static /*0x210cc50*/ void CSharp_AkPositioningInfo_HPFCone_set(nint jarg1, float jarg2);
    static /*0x210ccdc*/ float CSharp_AkPositioningInfo_HPFCone_get(nint jarg1);
    static /*0x210cd58*/ void CSharp_AkPositioningInfo_fMaxDistance_set(nint jarg1, float jarg2);
    static /*0x210cde4*/ float CSharp_AkPositioningInfo_fMaxDistance_get(nint jarg1);
    static /*0x210ce60*/ void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(nint jarg1, float jarg2);
    static /*0x210ceec*/ float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(nint jarg1);
    static /*0x210cf68*/ void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(nint jarg1, float jarg2);
    static /*0x210cff4*/ float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(nint jarg1);
    static /*0x210d070*/ void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(nint jarg1, float jarg2);
    static /*0x210d0fc*/ float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(nint jarg1);
    static /*0x210d178*/ void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(nint jarg1, float jarg2);
    static /*0x210d204*/ float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(nint jarg1);
    static /*0x210d280*/ void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(nint jarg1, float jarg2);
    static /*0x210d30c*/ float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(nint jarg1);
    static /*0x210d388*/ nint CSharp_new_AkPositioningInfo();
    static /*0x210d3ec*/ void CSharp_delete_AkPositioningInfo(nint jarg1);
    static /*0x210d468*/ void CSharp_AkObjectInfo_objID_set(nint jarg1, uint jarg2);
    static /*0x210d4ec*/ uint CSharp_AkObjectInfo_objID_get(nint jarg1);
    static /*0x210d568*/ void CSharp_AkObjectInfo_parentID_set(nint jarg1, uint jarg2);
    static /*0x210d5ec*/ uint CSharp_AkObjectInfo_parentID_get(nint jarg1);
    static /*0x210d668*/ void CSharp_AkObjectInfo_iDepth_set(nint jarg1, int jarg2);
    static /*0x210d6ec*/ int CSharp_AkObjectInfo_iDepth_get(nint jarg1);
    static /*0x210d768*/ void CSharp_AkObjectInfo_Clear(nint jarg1);
    static /*0x210d7e4*/ int CSharp_AkObjectInfo_GetSizeOf();
    static /*0x210d848*/ void CSharp_AkObjectInfo_Clone(nint jarg1, nint jarg2);
    static /*0x210d8cc*/ nint CSharp_new_AkObjectInfo();
    static /*0x210d930*/ void CSharp_delete_AkObjectInfo(nint jarg1);
    static /*0x20ebf00*/ int CSharp_GetPosition(ulong jarg1, nint jarg2);
    static /*0x20ebffc*/ int CSharp_GetListenerPosition(ulong jarg1, nint jarg2);
    static /*0x20ec104*/ int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, ref float jarg4, ref int jarg5);
    static /*0x20ec234*/ int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, ref float jarg4, ref int jarg5);
    static /*0x20ec364*/ int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, ref uint jarg3);
    static /*0x20ec464*/ int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, ref uint jarg3);
    static /*0x20ec570*/ int CSharp_GetState__SWIG_0(uint jarg1, ref uint jarg2);
    static /*0x20ec658*/ int CSharp_GetState__SWIG_1(string jarg1, ref uint jarg2);
    static /*0x20ec76c*/ int CSharp_GetGameObjectAuxSendValues(ulong jarg1, nint jarg2, ref uint jarg3);
    static /*0x20ec86c*/ int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, ref float jarg3);
    static /*0x20ec97c*/ int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, ref float jarg3, ref float jarg4);
    static /*0x20eca9c*/ int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, nint jarg3);
    static /*0x20ecbb4*/ int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, nint jarg3);
    static /*0x20eccd8*/ int CSharp_GetPositioningInfo(uint jarg1, nint jarg2);
    static /*0x20ecdb0*/ bool CSharp_GetIsGameObjectActive(ulong jarg1);
    static /*0x20ece88*/ float CSharp_GetMaxRadius(ulong jarg1);
    static /*0x20ecf58*/ uint CSharp_GetEventIDFromPlayingID(uint jarg1);
    static /*0x20ed028*/ ulong CSharp_GetGameObjectFromPlayingID(uint jarg1);
    static /*0x20ed110*/ int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, uint[] jarg3);
    static /*0x20ed2a4*/ int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, ref int jarg3);
    static /*0x20ed3a4*/ int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, ref float jarg3);
    static /*0x20ed48c*/ void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1);
    static /*0x20ed55c*/ void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1);
    static /*0x20ed62c*/ void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1);
    static /*0x20ed6fc*/ byte CSharp_ChannelMaskToNumChannels(uint jarg1);
    static /*0x20ed7cc*/ uint CSharp_ChannelMaskFromNumChannels(uint jarg1);
    static /*0x20ed8ac*/ byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2);
    static /*0x20ed984*/ bool CSharp_HasSurroundChannels(uint jarg1);
    static /*0x20eda5c*/ bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1);
    static /*0x20edb34*/ bool CSharp_HasSideAndRearChannels(uint jarg1);
    static /*0x20edc0c*/ bool CSharp_HasHeightChannels(uint jarg1);
    static /*0x20edce4*/ uint CSharp_BackToSideChannels(uint jarg1);
    static /*0x20eddcc*/ uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3);
    static /*0x210d9ac*/ void CSharp_AkChannelConfig_uNumChannels_set(nint jarg1, uint jarg2);
    static /*0x210da30*/ uint CSharp_AkChannelConfig_uNumChannels_get(nint jarg1);
    static /*0x210daac*/ void CSharp_AkChannelConfig_eConfigType_set(nint jarg1, uint jarg2);
    static /*0x210db30*/ uint CSharp_AkChannelConfig_eConfigType_get(nint jarg1);
    static /*0x210dbac*/ void CSharp_AkChannelConfig_uChannelMask_set(nint jarg1, uint jarg2);
    static /*0x210dc30*/ uint CSharp_AkChannelConfig_uChannelMask_get(nint jarg1);
    static /*0x210dcac*/ nint CSharp_AkChannelConfig_Standard(uint jarg1);
    static /*0x210dd28*/ nint CSharp_AkChannelConfig_Anonymous(uint jarg1);
    static /*0x210dda4*/ nint CSharp_AkChannelConfig_Ambisonic(uint jarg1);
    static /*0x210de20*/ nint CSharp_AkChannelConfig_Object();
    static /*0x210de84*/ nint CSharp_new_AkChannelConfig__SWIG_0();
    static /*0x210dee8*/ nint CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2);
    static /*0x210df6c*/ void CSharp_AkChannelConfig_Clear(nint jarg1);
    static /*0x210dfe8*/ void CSharp_AkChannelConfig_SetStandard(nint jarg1, uint jarg2);
    static /*0x210e06c*/ void CSharp_AkChannelConfig_SetStandardOrAnonymous(nint jarg1, uint jarg2, uint jarg3);
    static /*0x210e100*/ void CSharp_AkChannelConfig_SetAnonymous(nint jarg1, uint jarg2);
    static /*0x210e184*/ void CSharp_AkChannelConfig_SetAmbisonic(nint jarg1, uint jarg2);
    static /*0x210e208*/ void CSharp_AkChannelConfig_SetObject(nint jarg1);
    static /*0x210e284*/ void CSharp_AkChannelConfig_SetSameAsMainMix(nint jarg1);
    static /*0x210e300*/ void CSharp_AkChannelConfig_SetSameAsPassthrough(nint jarg1);
    static /*0x210e37c*/ bool CSharp_AkChannelConfig_IsValid(nint jarg1);
    static /*0x210e400*/ uint CSharp_AkChannelConfig_Serialize(nint jarg1);
    static /*0x210e47c*/ void CSharp_AkChannelConfig_Deserialize(nint jarg1, uint jarg2);
    static /*0x210e500*/ nint CSharp_AkChannelConfig_RemoveLFE(nint jarg1);
    static /*0x210e57c*/ nint CSharp_AkChannelConfig_RemoveCenter(nint jarg1);
    static /*0x210e5f8*/ void CSharp_delete_AkChannelConfig(nint jarg1);
    static /*0x210e674*/ nint CSharp_new_AkImageSourceParams__SWIG_0();
    static /*0x210e6d8*/ nint CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3);
    static /*0x210e774*/ void CSharp_AkImageSourceParams_sourcePosition_set(nint jarg1, AkVector64 jarg2);
    static /*0x210e800*/ AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(nint jarg1);
    static /*0x210e8e4*/ void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(nint jarg1, float jarg2);
    static /*0x210e970*/ float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(nint jarg1);
    static /*0x210e9ec*/ void CSharp_AkImageSourceParams_fLevel_set(nint jarg1, float jarg2);
    static /*0x210ea78*/ float CSharp_AkImageSourceParams_fLevel_get(nint jarg1);
    static /*0x210eaf4*/ void CSharp_AkImageSourceParams_fDiffraction_set(nint jarg1, float jarg2);
    static /*0x210eb80*/ float CSharp_AkImageSourceParams_fDiffraction_get(nint jarg1);
    static /*0x210ebfc*/ void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(nint jarg1, byte jarg2);
    static /*0x210ec80*/ byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(nint jarg1);
    static /*0x210ecfc*/ void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(nint jarg1, byte jarg2);
    static /*0x210ed80*/ byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(nint jarg1);
    static /*0x210edfc*/ void CSharp_delete_AkImageSourceParams(nint jarg1);
    static /*0x20edeac*/ uint CSharp_kDefaultDiffractionMaxEdges_get();
    static /*0x20edf5c*/ uint CSharp_kDefaultDiffractionMaxPaths_get();
    static /*0x20ee00c*/ float CSharp_kMaxDiffraction_get();
    static /*0x20ee0bc*/ uint CSharp_kHashListBlockAllocItemCount_get();
    static /*0x20ee16c*/ uint CSharp_kDiffractionMaxEdges_get();
    static /*0x20ee21c*/ uint CSharp_kDiffractionMaxPaths_get();
    static /*0x20ee2cc*/ uint CSharp_kPortalToPortalDiffractionMaxPaths_get();
    static /*0x210ee78*/ nint CSharp_new_AkSpatialAudioInitSettings();
    static /*0x210eedc*/ void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(nint jarg1, uint jarg2);
    static /*0x210ef60*/ uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(nint jarg1);
    static /*0x210efdc*/ void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(nint jarg1, float jarg2);
    static /*0x210f068*/ float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(nint jarg1);
    static /*0x210f0e4*/ void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(nint jarg1, uint jarg2);
    static /*0x210f168*/ uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(nint jarg1);
    static /*0x210f1e4*/ void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(nint jarg1, uint jarg2);
    static /*0x210f268*/ uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(nint jarg1);
    static /*0x210f2e4*/ void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(nint jarg1, uint jarg2);
    static /*0x210f368*/ uint CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(nint jarg1);
    static /*0x210f3e4*/ void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(nint jarg1, uint jarg2);
    static /*0x210f468*/ uint CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(nint jarg1);
    static /*0x210f4e4*/ void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(nint jarg1, uint jarg2);
    static /*0x210f568*/ uint CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(nint jarg1);
    static /*0x210f5e4*/ void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(nint jarg1, float jarg2);
    static /*0x210f670*/ float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(nint jarg1);
    static /*0x210f6ec*/ void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(nint jarg1, float jarg2);
    static /*0x210f778*/ float CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(nint jarg1);
    static /*0x210f7f4*/ void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(nint jarg1, uint jarg2);
    static /*0x210f878*/ uint CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(nint jarg1);
    static /*0x210f8f4*/ void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(nint jarg1, bool jarg2);
    static /*0x210f978*/ bool CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(nint jarg1);
    static /*0x210f9fc*/ void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(nint jarg1, bool jarg2);
    static /*0x210fa80*/ bool CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(nint jarg1);
    static /*0x210fb04*/ void CSharp_delete_AkSpatialAudioInitSettings(nint jarg1);
    static /*0x210fb80*/ nint CSharp_new_AkImageSourceSettings__SWIG_0();
    static /*0x210fbe4*/ nint CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3);
    static /*0x210fc80*/ void CSharp_AkImageSourceSettings_SetOneTexture(nint jarg1, uint jarg2);
    static /*0x210fd04*/ void CSharp_AkImageSourceSettings_params__set(nint jarg1, nint jarg2);
    static /*0x210fd88*/ nint CSharp_AkImageSourceSettings_params__get(nint jarg1);
    static /*0x210fe04*/ void CSharp_delete_AkImageSourceSettings(nint jarg1);
    static /*0x210fe80*/ nint CSharp_new_AkExtent__SWIG_0();
    static /*0x210fee4*/ nint CSharp_new_AkExtent__SWIG_1(float jarg1, float jarg2, float jarg3);
    static /*0x210ff74*/ void CSharp_AkExtent_halfWidth_set(nint jarg1, float jarg2);
    static /*0x2110000*/ float CSharp_AkExtent_halfWidth_get(nint jarg1);
    static /*0x211007c*/ void CSharp_AkExtent_halfHeight_set(nint jarg1, float jarg2);
    static /*0x2110108*/ float CSharp_AkExtent_halfHeight_get(nint jarg1);
    static /*0x2110184*/ void CSharp_AkExtent_halfDepth_set(nint jarg1, float jarg2);
    static /*0x2110210*/ float CSharp_AkExtent_halfDepth_get(nint jarg1);
    static /*0x211028c*/ void CSharp_delete_AkExtent(nint jarg1);
    static /*0x2110308*/ nint CSharp_new_AkTriangle__SWIG_0();
    static /*0x211036c*/ nint CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4);
    static /*0x2110408*/ void CSharp_AkTriangle_point0_set(nint jarg1, ushort jarg2);
    static /*0x211048c*/ ushort CSharp_AkTriangle_point0_get(nint jarg1);
    static /*0x2110508*/ void CSharp_AkTriangle_point1_set(nint jarg1, ushort jarg2);
    static /*0x211058c*/ ushort CSharp_AkTriangle_point1_get(nint jarg1);
    static /*0x2110608*/ void CSharp_AkTriangle_point2_set(nint jarg1, ushort jarg2);
    static /*0x211068c*/ ushort CSharp_AkTriangle_point2_get(nint jarg1);
    static /*0x2110708*/ void CSharp_AkTriangle_surface_set(nint jarg1, ushort jarg2);
    static /*0x211078c*/ ushort CSharp_AkTriangle_surface_get(nint jarg1);
    static /*0x2110808*/ void CSharp_AkTriangle_Clear(nint jarg1);
    static /*0x2110884*/ int CSharp_AkTriangle_GetSizeOf();
    static /*0x21108e8*/ void CSharp_AkTriangle_Clone(nint jarg1, nint jarg2);
    static /*0x211096c*/ void CSharp_delete_AkTriangle(nint jarg1);
    static /*0x21109e8*/ nint CSharp_new_AkAcousticSurface();
    static /*0x2110a4c*/ void CSharp_AkAcousticSurface_textureID_set(nint jarg1, uint jarg2);
    static /*0x2110ad0*/ uint CSharp_AkAcousticSurface_textureID_get(nint jarg1);
    static /*0x2110b4c*/ void CSharp_AkAcousticSurface_transmissionLoss_set(nint jarg1, float jarg2);
    static /*0x2110bd8*/ float CSharp_AkAcousticSurface_transmissionLoss_get(nint jarg1);
    static /*0x2110c54*/ void CSharp_AkAcousticSurface_strName_set(nint jarg1, string jarg2);
    static /*0x2110cec*/ nint CSharp_AkAcousticSurface_strName_get(nint jarg1);
    static /*0x2110d68*/ void CSharp_AkAcousticSurface_Clear(nint jarg1);
    static /*0x2110de4*/ void CSharp_AkAcousticSurface_DeleteName(nint jarg1);
    static /*0x2110e60*/ int CSharp_AkAcousticSurface_GetSizeOf();
    static /*0x2110ec4*/ void CSharp_AkAcousticSurface_Clone(nint jarg1, nint jarg2);
    static /*0x2110f48*/ void CSharp_delete_AkAcousticSurface(nint jarg1);
    static /*0x2110fc4*/ void CSharp_AkReflectionPathInfo_imageSource_set(nint jarg1, AkVector64 jarg2);
    static /*0x2111050*/ AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(nint jarg1);
    static /*0x2111134*/ void CSharp_AkReflectionPathInfo_numPathPoints_set(nint jarg1, uint jarg2);
    static /*0x21111b8*/ uint CSharp_AkReflectionPathInfo_numPathPoints_get(nint jarg1);
    static /*0x2111234*/ void CSharp_AkReflectionPathInfo_numReflections_set(nint jarg1, uint jarg2);
    static /*0x21112b8*/ uint CSharp_AkReflectionPathInfo_numReflections_get(nint jarg1);
    static /*0x2111334*/ void CSharp_AkReflectionPathInfo_level_set(nint jarg1, float jarg2);
    static /*0x21113c0*/ float CSharp_AkReflectionPathInfo_level_get(nint jarg1);
    static /*0x211143c*/ void CSharp_AkReflectionPathInfo_isOccluded_set(nint jarg1, bool jarg2);
    static /*0x21114c0*/ bool CSharp_AkReflectionPathInfo_isOccluded_get(nint jarg1);
    static /*0x2111544*/ int CSharp_AkReflectionPathInfo_GetSizeOf();
    static /*0x21115a8*/ UnityEngine.Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(nint jarg1, uint jarg2);
    static /*0x211162c*/ nint CSharp_AkReflectionPathInfo_GetAcousticSurface(nint jarg1, uint jarg2);
    static /*0x21116b0*/ float CSharp_AkReflectionPathInfo_GetDiffraction(nint jarg1, uint jarg2);
    static /*0x2111734*/ void CSharp_AkReflectionPathInfo_Clone(nint jarg1, nint jarg2);
    static /*0x21117b8*/ nint CSharp_new_AkReflectionPathInfo();
    static /*0x211181c*/ void CSharp_delete_AkReflectionPathInfo(nint jarg1);
    static /*0x2111898*/ void CSharp_AkDiffractionPathInfo_emitterPos_set(nint jarg1, AkVector64 jarg2);
    static /*0x2111924*/ AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(nint jarg1);
    static /*0x2111a08*/ void CSharp_AkDiffractionPathInfo_virtualPos_set(nint jarg1, nint jarg2);
    static /*0x2111a8c*/ nint CSharp_AkDiffractionPathInfo_virtualPos_get(nint jarg1);
    static /*0x2111b08*/ void CSharp_AkDiffractionPathInfo_nodeCount_set(nint jarg1, uint jarg2);
    static /*0x2111b8c*/ uint CSharp_AkDiffractionPathInfo_nodeCount_get(nint jarg1);
    static /*0x2111c08*/ void CSharp_AkDiffractionPathInfo_diffraction_set(nint jarg1, float jarg2);
    static /*0x2111c94*/ float CSharp_AkDiffractionPathInfo_diffraction_get(nint jarg1);
    static /*0x2111d10*/ void CSharp_AkDiffractionPathInfo_transmissionLoss_set(nint jarg1, float jarg2);
    static /*0x2111d9c*/ float CSharp_AkDiffractionPathInfo_transmissionLoss_get(nint jarg1);
    static /*0x2111e18*/ void CSharp_AkDiffractionPathInfo_totLength_set(nint jarg1, float jarg2);
    static /*0x2111ea4*/ float CSharp_AkDiffractionPathInfo_totLength_get(nint jarg1);
    static /*0x2111f20*/ void CSharp_AkDiffractionPathInfo_obstructionValue_set(nint jarg1, float jarg2);
    static /*0x2111fac*/ float CSharp_AkDiffractionPathInfo_obstructionValue_get(nint jarg1);
    static /*0x2112028*/ void CSharp_AkDiffractionPathInfo_occlusionValue_set(nint jarg1, float jarg2);
    static /*0x21120b4*/ float CSharp_AkDiffractionPathInfo_occlusionValue_get(nint jarg1);
    static /*0x2112130*/ int CSharp_AkDiffractionPathInfo_GetSizeOf();
    static /*0x2112194*/ UnityEngine.Vector3 CSharp_AkDiffractionPathInfo_GetNodes(nint jarg1, uint jarg2);
    static /*0x2112218*/ float CSharp_AkDiffractionPathInfo_GetAngles(nint jarg1, uint jarg2);
    static /*0x211229c*/ ulong CSharp_AkDiffractionPathInfo_GetPortals(nint jarg1, uint jarg2);
    static /*0x2112320*/ ulong CSharp_AkDiffractionPathInfo_GetRooms(nint jarg1, uint jarg2);
    static /*0x21123a4*/ void CSharp_AkDiffractionPathInfo_Clone(nint jarg1, nint jarg2);
    static /*0x2112428*/ nint CSharp_new_AkDiffractionPathInfo();
    static /*0x211248c*/ void CSharp_delete_AkDiffractionPathInfo(nint jarg1);
    static /*0x2112508*/ nint CSharp_new_AkRoomParams();
    static /*0x211256c*/ void CSharp_AkRoomParams_Front_set(nint jarg1, UnityEngine.Vector3 jarg2);
    static /*0x2112610*/ UnityEngine.Vector3 CSharp_AkRoomParams_Front_get(nint jarg1);
    static /*0x211268c*/ void CSharp_AkRoomParams_Up_set(nint jarg1, UnityEngine.Vector3 jarg2);
    static /*0x2112730*/ UnityEngine.Vector3 CSharp_AkRoomParams_Up_get(nint jarg1);
    static /*0x21127ac*/ void CSharp_AkRoomParams_ReverbAuxBus_set(nint jarg1, uint jarg2);
    static /*0x2112830*/ uint CSharp_AkRoomParams_ReverbAuxBus_get(nint jarg1);
    static /*0x21128ac*/ void CSharp_AkRoomParams_ReverbLevel_set(nint jarg1, float jarg2);
    static /*0x2112938*/ float CSharp_AkRoomParams_ReverbLevel_get(nint jarg1);
    static /*0x21129b4*/ void CSharp_AkRoomParams_TransmissionLoss_set(nint jarg1, float jarg2);
    static /*0x2112a40*/ float CSharp_AkRoomParams_TransmissionLoss_get(nint jarg1);
    static /*0x2112abc*/ void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(nint jarg1, float jarg2);
    static /*0x2112b48*/ float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(nint jarg1);
    static /*0x2112bc4*/ void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(nint jarg1, bool jarg2);
    static /*0x2112c48*/ bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(nint jarg1);
    static /*0x2112ccc*/ void CSharp_AkRoomParams_RoomPriority_set(nint jarg1, uint jarg2);
    static /*0x2112d50*/ uint CSharp_AkRoomParams_RoomPriority_get(nint jarg1);
    static /*0x2112dcc*/ void CSharp_delete_AkRoomParams(nint jarg1);
    static /*0x2112e48*/ nint CSharp_new_AkGeometryInstanceParams();
    static /*0x2112eac*/ void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(nint jarg1, nint jarg2);
    static /*0x2112f30*/ nint CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(nint jarg1);
    static /*0x2112fac*/ void CSharp_AkGeometryInstanceParams_Scale_set(nint jarg1, UnityEngine.Vector3 jarg2);
    static /*0x2113050*/ UnityEngine.Vector3 CSharp_AkGeometryInstanceParams_Scale_get(nint jarg1);
    static /*0x21130cc*/ void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(nint jarg1, bool jarg2);
    static /*0x2113150*/ bool CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(nint jarg1);
    static /*0x21131d4*/ void CSharp_delete_AkGeometryInstanceParams(nint jarg1);
    static /*0x20ee39c*/ int CSharp_SetGameObjectRadius(ulong jarg1, float jarg2, float jarg3);
    static /*0x20ee4c8*/ int CSharp_SetImageSource__SWIG_0(uint jarg1, nint jarg2, string jarg3, uint jarg4, ulong jarg5);
    static /*0x20ee60c*/ int CSharp_SetImageSource__SWIG_1(uint jarg1, nint jarg2, string jarg3, uint jarg4);
    static /*0x20ee738*/ int CSharp_SetImageSource__SWIG_2(uint jarg1, nint jarg2, string jarg3);
    static /*0x20ee854*/ int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3);
    static /*0x20ee94c*/ int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2);
    static /*0x20eea24*/ int CSharp_RemoveImageSource__SWIG_2(uint jarg1);
    static /*0x20eeb04*/ int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2);
    static /*0x20eebdc*/ int CSharp_ClearImageSources__SWIG_1(uint jarg1);
    static /*0x20eeca4*/ int CSharp_ClearImageSources__SWIG_2();
    static /*0x20eed5c*/ int CSharp_RemoveGeometry(ulong jarg1);
    static /*0x20eee2c*/ int CSharp_RemoveGeometryInstance(ulong jarg1);
    static /*0x20eeefc*/ int CSharp_RemoveRoom(ulong jarg1);
    static /*0x20eefcc*/ int CSharp_RemovePortal(ulong jarg1);
    static /*0x20ef0bc*/ int CSharp_SetReverbZone(ulong jarg1, ulong jarg2, float jarg3);
    static /*0x20ef1a0*/ int CSharp_RemoveReverbZone(ulong jarg1);
    static /*0x20ef280*/ int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2);
    static /*0x20ef358*/ int CSharp_UnsetGameObjectInRoom(ulong jarg1);
    static /*0x20ef438*/ int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2);
    static /*0x20ef520*/ int CSharp_SetDiffractionOrder(uint jarg1, bool jarg2);
    static /*0x20ef5f8*/ int CSharp_SetMaxEmitterRoomAuxSends(uint jarg1);
    static /*0x20ef6c8*/ int CSharp_SetNumberOfPrimaryRays(uint jarg1);
    static /*0x20ef798*/ int CSharp_SetLoadBalancingSpread(uint jarg1);
    static /*0x20ef878*/ int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2);
    static /*0x20ef960*/ int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2);
    static /*0x20efa58*/ int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3);
    static /*0x20efb60*/ int CSharp_SetGameObjectToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3);
    static /*0x20efc68*/ int CSharp_SetPortalToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3);
    static /*0x20efd60*/ int CSharp_QueryWetDiffraction(ulong jarg1, ref float jarg2);
    static /*0x20efe30*/ int CSharp_ResetStochasticEngine();
    static /*0x20fa914*/ void CSharp_AkPlatformInitSettings_threadLEngine_set(nint jarg1, nint jarg2);
    static /*0x20faa38*/ nint CSharp_AkPlatformInitSettings_threadLEngine_get(nint jarg1);
    static /*0x20fab4c*/ void CSharp_AkPlatformInitSettings_threadOutputMgr_set(nint jarg1, nint jarg2);
    static /*0x20fac70*/ nint CSharp_AkPlatformInitSettings_threadOutputMgr_get(nint jarg1);
    static /*0x20fad54*/ void CSharp_AkPlatformInitSettings_threadBankManager_set(nint jarg1, nint jarg2);
    static /*0x20fae78*/ nint CSharp_AkPlatformInitSettings_threadBankManager_get(nint jarg1);
    static /*0x20faf5c*/ void CSharp_AkPlatformInitSettings_threadMonitor_set(nint jarg1, nint jarg2);
    static /*0x20fb080*/ nint CSharp_AkPlatformInitSettings_threadMonitor_get(nint jarg1);
    static /*0x20fb164*/ void CSharp_AkPlatformInitSettings_eAudioAPI_set(nint jarg1, int jarg2);
    static /*0x20fb240*/ int CSharp_AkPlatformInitSettings_eAudioAPI_get(nint jarg1);
    static /*0x20fb324*/ void CSharp_AkPlatformInitSettings_uSampleRate_set(nint jarg1, uint jarg2);
    static /*0x20fb400*/ uint CSharp_AkPlatformInitSettings_uSampleRate_get(nint jarg1);
    static /*0x20fb4e4*/ void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(nint jarg1, ushort jarg2);
    static /*0x20fb5c0*/ ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(nint jarg1);
    static /*0x20fb6a4*/ void CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_set(nint jarg1, bool jarg2);
    static /*0x20fb780*/ bool CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_get(nint jarg1);
    static /*0x20fb86c*/ void CSharp_AkPlatformInitSettings_bVerboseSink_set(nint jarg1, bool jarg2);
    static /*0x20fb948*/ bool CSharp_AkPlatformInitSettings_bVerboseSink_get(nint jarg1);
    static /*0x20fba34*/ void CSharp_AkPlatformInitSettings_bEnableLowLatency_set(nint jarg1, bool jarg2);
    static /*0x20fbb10*/ bool CSharp_AkPlatformInitSettings_bEnableLowLatency_get(nint jarg1);
    static /*0x20fa830*/ void CSharp_delete_AkPlatformInitSettings(nint jarg1);
    static /*0x20eff18*/ int CSharp_GetFastPathSettings(nint jarg1, nint jarg2);
    static /*0x2113250*/ void CSharp_delete_AkStreamMgrSettings(nint jarg1);
    static /*0x21132cc*/ void CSharp_AkDeviceSettings_pIOMemory_set(nint jarg1, nint jarg2);
    static /*0x2113350*/ nint CSharp_AkDeviceSettings_pIOMemory_get(nint jarg1);
    static /*0x21133cc*/ void CSharp_AkDeviceSettings_uIOMemorySize_set(nint jarg1, uint jarg2);
    static /*0x2113450*/ uint CSharp_AkDeviceSettings_uIOMemorySize_get(nint jarg1);
    static /*0x21134cc*/ void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(nint jarg1, uint jarg2);
    static /*0x2113550*/ uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(nint jarg1);
    static /*0x21135cc*/ void CSharp_AkDeviceSettings_ePoolAttributes_set(nint jarg1, uint jarg2);
    static /*0x2113650*/ uint CSharp_AkDeviceSettings_ePoolAttributes_get(nint jarg1);
    static /*0x21136cc*/ void CSharp_AkDeviceSettings_uGranularity_set(nint jarg1, uint jarg2);
    static /*0x2113750*/ uint CSharp_AkDeviceSettings_uGranularity_get(nint jarg1);
    static /*0x21137cc*/ void CSharp_AkDeviceSettings_threadProperties_set(nint jarg1, nint jarg2);
    static /*0x2113850*/ nint CSharp_AkDeviceSettings_threadProperties_get(nint jarg1);
    static /*0x21138cc*/ void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(nint jarg1, float jarg2);
    static /*0x2113958*/ float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(nint jarg1);
    static /*0x21139d4*/ void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(nint jarg1, uint jarg2);
    static /*0x2113a58*/ uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(nint jarg1);
    static /*0x2113ad4*/ void CSharp_AkDeviceSettings_bUseStreamCache_set(nint jarg1, bool jarg2);
    static /*0x2113b58*/ bool CSharp_AkDeviceSettings_bUseStreamCache_get(nint jarg1);
    static /*0x2113bdc*/ void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(nint jarg1, uint jarg2);
    static /*0x2113c60*/ uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(nint jarg1);
    static /*0x2113cdc*/ void CSharp_delete_AkDeviceSettings(nint jarg1);
    static /*0x2113d58*/ void CSharp_AkThreadProperties_nPriority_set(nint jarg1, int jarg2);
    static /*0x2113ddc*/ int CSharp_AkThreadProperties_nPriority_get(nint jarg1);
    static /*0x2113e58*/ void CSharp_AkThreadProperties_uStackSize_set(nint jarg1, uint jarg2);
    static /*0x2113edc*/ uint CSharp_AkThreadProperties_uStackSize_get(nint jarg1);
    static /*0x2113f58*/ void CSharp_AkThreadProperties_uSchedPolicy_set(nint jarg1, int jarg2);
    static /*0x2113fdc*/ int CSharp_AkThreadProperties_uSchedPolicy_get(nint jarg1);
    static /*0x2114058*/ void CSharp_AkThreadProperties_dwAffinityMask_set(nint jarg1, uint jarg2);
    static /*0x21140dc*/ uint CSharp_AkThreadProperties_dwAffinityMask_get(nint jarg1);
    static /*0x2114158*/ nint CSharp_new_AkThreadProperties();
    static /*0x21141bc*/ void CSharp_delete_AkThreadProperties(nint jarg1);
    static /*0x20efff0*/ void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1);
    static /*0x20f00bc*/ void CSharp_SetErrorLogger__SWIG_1();
    static /*0x20f0184*/ void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2);
    static /*0x2114238*/ void CSharp_delete_AkUnityPlatformSpecificSettings(nint jarg1);
    static /*0x20f9a64*/ nint CSharp_new_AkCommunicationSettings();
    static /*0x20f9b30*/ void CSharp_AkCommunicationSettings_uPoolSize_set(nint jarg1, uint jarg2);
    static /*0x20f9c0c*/ uint CSharp_AkCommunicationSettings_uPoolSize_get(nint jarg1);
    static /*0x20f9cf0*/ void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(nint jarg1, ushort jarg2);
    static /*0x20f9dcc*/ ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(nint jarg1);
    static /*0x20f9eb0*/ void CSharp_AkCommunicationSettings_uCommandPort_set(nint jarg1, ushort jarg2);
    static /*0x20f9f8c*/ ushort CSharp_AkCommunicationSettings_uCommandPort_get(nint jarg1);
    static /*0x20fa070*/ void CSharp_AkCommunicationSettings_commSystem_set(nint jarg1, int jarg2);
    static /*0x20fa14c*/ int CSharp_AkCommunicationSettings_commSystem_get(nint jarg1);
    static /*0x20fa230*/ void CSharp_AkCommunicationSettings_bInitSystemLib_set(nint jarg1, bool jarg2);
    static /*0x20fa30c*/ bool CSharp_AkCommunicationSettings_bInitSystemLib_get(nint jarg1);
    static /*0x20fa3f8*/ void CSharp_AkCommunicationSettings_szAppNetworkName_set(nint jarg1, string jarg2);
    static /*0x20fa51c*/ nint CSharp_AkCommunicationSettings_szAppNetworkName_get(nint jarg1);
    static /*0x20f9978*/ void CSharp_delete_AkCommunicationSettings(nint jarg1);
    static /*0x21142b4*/ nint CSharp_new_AkInitializationSettings();
    static /*0x2114318*/ void CSharp_delete_AkInitializationSettings(nint jarg1);
    static /*0x2114394*/ void CSharp_AkInitializationSettings_streamMgrSettings_set(nint jarg1, nint jarg2);
    static /*0x2114418*/ nint CSharp_AkInitializationSettings_streamMgrSettings_get(nint jarg1);
    static /*0x2114494*/ void CSharp_AkInitializationSettings_deviceSettings_set(nint jarg1, nint jarg2);
    static /*0x2114518*/ nint CSharp_AkInitializationSettings_deviceSettings_get(nint jarg1);
    static /*0x2114594*/ void CSharp_AkInitializationSettings_initSettings_set(nint jarg1, nint jarg2);
    static /*0x2114618*/ nint CSharp_AkInitializationSettings_initSettings_get(nint jarg1);
    static /*0x2114694*/ void CSharp_AkInitializationSettings_platformSettings_set(nint jarg1, nint jarg2);
    static /*0x2114718*/ nint CSharp_AkInitializationSettings_platformSettings_get(nint jarg1);
    static /*0x2114794*/ void CSharp_AkInitializationSettings_musicSettings_set(nint jarg1, nint jarg2);
    static /*0x2114818*/ nint CSharp_AkInitializationSettings_musicSettings_get(nint jarg1);
    static /*0x2114894*/ void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(nint jarg1, nint jarg2);
    static /*0x2114918*/ nint CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(nint jarg1);
    static /*0x2114994*/ void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(nint jarg1, uint jarg2);
    static /*0x2114a18*/ uint CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(nint jarg1);
    static /*0x2114a94*/ void CSharp_AkInitializationSettings_uMemDebugLevel_set(nint jarg1, uint jarg2);
    static /*0x2114b18*/ uint CSharp_AkInitializationSettings_uMemDebugLevel_get(nint jarg1);
    static /*0x2114b94*/ void CSharp_AkInitializationSettings_uMemSpanCount_set(nint jarg1, uint jarg2);
    static /*0x2114c18*/ uint CSharp_AkInitializationSettings_uMemSpanCount_get(nint jarg1);
    static /*0x2114c94*/ nint CSharp_new_AkExternalSourceInfo__SWIG_0();
    static /*0x2114cf8*/ void CSharp_delete_AkExternalSourceInfo(nint jarg1);
    static /*0x2114d74*/ nint CSharp_new_AkExternalSourceInfo__SWIG_1(nint jarg1, uint jarg2, uint jarg3, uint jarg4);
    static /*0x2114e10*/ nint CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3);
    static /*0x2114ebc*/ nint CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3);
    static /*0x2114f50*/ void CSharp_AkExternalSourceInfo_Clear(nint jarg1);
    static /*0x2114fcc*/ void CSharp_AkExternalSourceInfo_Clone(nint jarg1, nint jarg2);
    static /*0x2115050*/ int CSharp_AkExternalSourceInfo_GetSizeOf();
    static /*0x21150b4*/ void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(nint jarg1, uint jarg2);
    static /*0x2115138*/ uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(nint jarg1);
    static /*0x21151b4*/ void CSharp_AkExternalSourceInfo_idCodec_set(nint jarg1, uint jarg2);
    static /*0x2115238*/ uint CSharp_AkExternalSourceInfo_idCodec_get(nint jarg1);
    static /*0x21152b4*/ void CSharp_AkExternalSourceInfo_szFile_set(nint jarg1, string jarg2);
    static /*0x211534c*/ nint CSharp_AkExternalSourceInfo_szFile_get(nint jarg1);
    static /*0x21153c8*/ void CSharp_AkExternalSourceInfo_pInMemory_set(nint jarg1, nint jarg2);
    static /*0x211544c*/ nint CSharp_AkExternalSourceInfo_pInMemory_get(nint jarg1);
    static /*0x21154c8*/ void CSharp_AkExternalSourceInfo_uiMemorySize_set(nint jarg1, uint jarg2);
    static /*0x211554c*/ uint CSharp_AkExternalSourceInfo_uiMemorySize_get(nint jarg1);
    static /*0x21155c8*/ void CSharp_AkExternalSourceInfo_idFile_set(nint jarg1, uint jarg2);
    static /*0x211564c*/ uint CSharp_AkExternalSourceInfo_idFile_get(nint jarg1);
    static /*0x20f0284*/ int CSharp_Init(nint jarg1);
    static /*0x20f0368*/ int CSharp_InitSpatialAudio(nint jarg1);
    static /*0x20f044c*/ int CSharp_InitCommunication(nint jarg1);
    static /*0x20f0514*/ void CSharp_Term();
    static /*0x20f05cc*/ int CSharp_RegisterGameObjInternal(ulong jarg1);
    static /*0x20f069c*/ int CSharp_UnregisterGameObjInternal(ulong jarg1);
    static /*0x20f077c*/ int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2);
    static /*0x20f0870*/ int CSharp_SetBasePath(string jarg1);
    static /*0x20f0958*/ int CSharp_SetCurrentLanguage(string jarg1);
    static /*0x20f0a50*/ int CSharp_LoadFilePackage(string jarg1, ref uint jarg2);
    static /*0x20f0b40*/ int CSharp_AddBasePath(string jarg1);
    static /*0x20f0c28*/ int CSharp_SetGameName(string jarg1);
    static /*0x20f0d10*/ int CSharp_SetDecodedBankPath(string jarg1);
    static /*0x20f0e10*/ int CSharp_LoadAndDecodeBank(string jarg1, bool jarg2, ref uint jarg3);
    static /*0x20f0f50*/ int CSharp_LoadAndDecodeBankFromMemory(nint jarg1, uint jarg2, bool jarg3, string jarg4, bool jarg5, ref uint jarg6);
    static /*0x20f10a0*/ nint CSharp_GetCurrentLanguage();
    static /*0x20f11ac*/ int CSharp_UnloadFilePackage(uint jarg1);
    static /*0x20f1274*/ int CSharp_UnloadAllFilePackages();
    static /*0x20f13d4*/ int CSharp_SetObjectPosition(ulong jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4);
    static /*0x20f1544*/ int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, uint[] jarg2, uint[] jarg3, int[] jarg4, ref uint jarg5, bool jarg6);
    static /*0x20f17b8*/ int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, uint[] jarg2, uint[] jarg3, int[] jarg4, ref uint jarg5);
    static /*0x20f1a0c*/ int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3);
    static /*0x20f1b0c*/ int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2);
    static /*0x20f1bec*/ uint CSharp_GetNumOutputDevices(uint jarg1);
    static /*0x20f1cf8*/ int CSharp_AddOutput__SWIG_0(nint jarg1, ref ulong jarg2, ulong[] jarg3, uint jarg4);
    static /*0x20f1e1c*/ int CSharp_AddOutput__SWIG_1(nint jarg1, ref ulong jarg2, ulong[] jarg3);
    static /*0x20f1f2c*/ int CSharp_AddOutput__SWIG_2(nint jarg1, ref ulong jarg2);
    static /*0x20f2018*/ int CSharp_AddOutput__SWIG_3(nint jarg1);
    static /*0x20f20fc*/ void CSharp_GetDefaultStreamSettings(nint jarg1);
    static /*0x20f21d4*/ void CSharp_GetDefaultDeviceSettings(nint jarg1);
    static /*0x20f22b8*/ void CSharp_GetDefaultMusicSettings(nint jarg1);
    static /*0x20f2390*/ void CSharp_GetDefaultInitSettings(nint jarg1);
    static /*0x20f2468*/ void CSharp_GetDefaultPlatformInitSettings(nint jarg1);
    static /*0x20f2530*/ uint CSharp_GetMajorMinorVersion();
    static /*0x20f25e0*/ uint CSharp_GetSubminorBuildVersion();
    static /*0x20f2690*/ void CSharp_StartResourceMonitoring();
    static /*0x20f2740*/ void CSharp_StopResourceMonitoring();
    static /*0x20f280c*/ void CSharp_GetResourceMonitorDataSummary(nint jarg1);
    static /*0x20f28dc*/ void CSharp_StartDeviceCapture(ulong jarg1);
    static /*0x20f29ac*/ void CSharp_StopDeviceCapture(ulong jarg1);
    static /*0x20f2a74*/ void CSharp_ClearCaptureData();
    static /*0x20f2b2c*/ uint CSharp_UpdateCaptureSampleCount(ulong jarg1);
    static /*0x20f2c14*/ uint CSharp_GetCaptureSamples(ulong jarg1, float[] jarg2, uint jarg3);
    static /*0x20f2d70*/ int CSharp_SetRoomPortal(ulong jarg1, ulong jarg2, ulong jarg3, nint jarg4, nint jarg5, bool jarg6, string jarg7);
    static /*0x20f2ee0*/ int CSharp_SetRoom(ulong jarg1, nint jarg2, ulong jarg3, string jarg4);
    static /*0x20f2fec*/ int CSharp_RegisterSpatialAudioListener(ulong jarg1);
    static /*0x20f30bc*/ int CSharp_UnregisterSpatialAudioListener(ulong jarg1);
    static /*0x20f321c*/ int CSharp_SetGeometry(ulong jarg1, nint jarg2, uint jarg3, UnityEngine.Vector3[] jarg4, uint jarg5, nint jarg6, uint jarg7, bool jarg8, bool jarg9);
    static /*0x20f33c4*/ int CSharp_SetGeometryInstance(ulong jarg1, nint jarg2, UnityEngine.Vector3 jarg3, ulong jarg4, ulong jarg5, bool jarg6);
    static /*0x20f353c*/ int CSharp_QueryReflectionPaths(ulong jarg1, uint jarg2, ref UnityEngine.Vector3 jarg3, ref UnityEngine.Vector3 jarg4, nint jarg5, ref uint jarg6);
    static /*0x20f3694*/ int CSharp_QueryDiffractionPaths(ulong jarg1, uint jarg2, ref UnityEngine.Vector3 jarg3, ref UnityEngine.Vector3 jarg4, nint jarg5, ref uint jarg6);
    static /*0x20f3794*/ void CSharp_PerformStreamMgrIO();
    static /*0x21156c8*/ nint CSharp_AkPlaylist_SWIGUpcast(nint jarg1);
    static /*0x2115744*/ nint CSharp_AkMIDIPost_SWIGUpcast(nint jarg1);
    static /*0x21157c0*/ nint CSharp_AkEventCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x211583c*/ nint CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x21158b8*/ nint CSharp_AkMarkerCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x2115934*/ nint CSharp_AkDurationCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x21159b0*/ nint CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x2115a2c*/ nint CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(nint jarg1);
    static /*0x2115aa8*/ nint CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(nint jarg1);
    /*0x2115b24*/ AkSoundEnginePINVOKE();
}

class AkThreadProperties : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20eb9d8*/ nint getCPtr(AkThreadProperties obj);
    /*0x20faab4*/ AkThreadProperties(nint cPtr, bool cMemoryOwn);
    /*0x2116094*/ AkThreadProperties();
    /*0x2115b2c*/ void setCPtr(nint cPtr);
    /*0x2115bbc*/ void Finalize();
    /*0x2115b50*/ void Dispose();
    /*0x2115c4c*/ void Dispose(bool disposing);
    /*0x2115d94*/ void set_nPriority(int value);
    /*0x2115dfc*/ int get_nPriority();
    /*0x2115e54*/ void set_uStackSize(uint value);
    /*0x2115ebc*/ uint get_uStackSize();
    /*0x2115f14*/ void set_uSchedPolicy(int value);
    /*0x2115f7c*/ int get_uSchedPolicy();
    /*0x2115fd4*/ void set_dwAffinityMask(uint value);
    /*0x211603c*/ uint get_dwAffinityMask();
}

class AkUnityPlatformSpecificSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2116134*/ nint getCPtr(AkUnityPlatformSpecificSettings obj);
    /*0x2116104*/ AkUnityPlatformSpecificSettings(nint cPtr, bool cMemoryOwn);
    /*0x2116140*/ void setCPtr(nint cPtr);
    /*0x21161d0*/ void Finalize();
    /*0x2116164*/ void Dispose();
    /*0x2116260*/ void Dispose(bool disposing);
}

class Ak3DAudioSinkCapabilities : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20da940*/ nint getCPtr(Ak3DAudioSinkCapabilities obj);
    /*0x21163a8*/ Ak3DAudioSinkCapabilities(nint cPtr, bool cMemoryOwn);
    /*0x2116a48*/ Ak3DAudioSinkCapabilities();
    /*0x21163d8*/ void setCPtr(nint cPtr);
    /*0x2116468*/ void Finalize();
    /*0x21163fc*/ void Dispose();
    /*0x21164f8*/ void Dispose(bool disposing);
    /*0x2116640*/ void set_channelConfig(AkChannelConfig value);
    /*0x21166a8*/ AkChannelConfig get_channelConfig();
    /*0x2116748*/ void set_uMaxSystemAudioObjects(uint value);
    /*0x21167b0*/ uint get_uMaxSystemAudioObjects();
    /*0x2116808*/ void set_uAvailableSystemAudioObjects(uint value);
    /*0x2116870*/ uint get_uAvailableSystemAudioObjects();
    /*0x21168c8*/ void set_bPassthrough(bool value);
    /*0x2116930*/ bool get_bPassthrough();
    /*0x2116988*/ void set_bMultiChannelObjects(bool value);
    /*0x21169f0*/ bool get_bMultiChannelObjects();
}

class Ak3dData : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2116ae8*/ nint getCPtr(Ak3dData obj);
    /*0x2116ab8*/ Ak3dData(nint cPtr, bool cMemoryOwn);
    /*0x2116d5c*/ Ak3dData();
    /*0x2116af4*/ void setCPtr(nint cPtr);
    /*0x2116b84*/ void Finalize();
    /*0x2116b18*/ void Dispose();
    /*0x2116c14*/ void Dispose(bool disposing);
    /*0x2116dcc*/ void set_xform(AkTransform value);
    /*0x2116e48*/ AkTransform get_xform();
    /*0x2116ee8*/ void set_spread(float value);
    /*0x2116f50*/ float get_spread();
    /*0x2116fa8*/ void set_focus(float value);
    /*0x2117010*/ float get_focus();
    /*0x2117068*/ void set_uEmitterChannelMask(uint value);
    /*0x21170d0*/ uint get_uEmitterChannelMask();
}

enum Ak3DPositionType
{
    AK_3DPositionType_Emitter = 0,
    AK_3DPositionType_EmitterWithAutomation = 1,
    AK_3DPositionType_ListenerWithAutomation = 2,
}

enum Ak3DSpatializationMode
{
    AK_SpatializationMode_None = 0,
    AK_SpatializationMode_PositionOnly = 1,
    AK_SpatializationMode_PositionAndOrientation = 2,
}

class AkAcousticSurface : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2117158*/ nint getCPtr(AkAcousticSurface obj);
    static /*0x2117760*/ int GetSizeOf();
    /*0x2117128*/ AkAcousticSurface(nint cPtr, bool cMemoryOwn);
    /*0x21173cc*/ AkAcousticSurface();
    /*0x2117164*/ void setCPtr(nint cPtr);
    /*0x21171f4*/ void Finalize();
    /*0x2117188*/ void Dispose();
    /*0x2117284*/ void Dispose(bool disposing);
    /*0x211743c*/ void set_textureID(uint value);
    /*0x21174a4*/ uint get_textureID();
    /*0x21174fc*/ void set_transmissionLoss(float value);
    /*0x2117564*/ float get_transmissionLoss();
    /*0x21175bc*/ void set_strName(string value);
    /*0x2117624*/ string get_strName();
    /*0x21176b0*/ void Clear();
    /*0x2117708*/ void DeleteName();
    /*0x21177ac*/ void Clone(AkAcousticSurface other);
}

enum AkActionOnEventType
{
    AkActionOnEventType_Stop = 0,
    AkActionOnEventType_Pause = 1,
    AkActionOnEventType_Resume = 2,
    AkActionOnEventType_Break = 3,
    AkActionOnEventType_ReleaseEnvelope = 4,
}

enum AkAttenuationCurveType
{
    AttenuationCurveID_VolumeDry = 0,
    AttenuationCurveID_VolumeAuxGameDef = 1,
    AttenuationCurveID_VolumeAuxUserDef = 2,
    AttenuationCurveID_LowPassFilter = 3,
    AttenuationCurveID_HighPassFilter = 4,
    AttenuationCurveID_Spread = 5,
    AttenuationCurveID_Focus = 6,
    AttenuationCurveID_ObstructionVolume = 7,
    AttenuationCurveID_ObstructionLPF = 8,
    AttenuationCurveID_ObstructionHPF = 9,
    AttenuationCurveID_OcclusionVolume = 10,
    AttenuationCurveID_OcclusionLPF = 11,
    AttenuationCurveID_OcclusionHPF = 12,
    AttenuationCurveID_DiffractionVolume = 13,
    AttenuationCurveID_DiffractionLPF = 14,
    AttenuationCurveID_DiffractionHPF = 15,
    AttenuationCurveID_TransmissionVolume = 16,
    AttenuationCurveID_TransmissionLPF = 17,
    AttenuationCurveID_TransmissionHPF = 18,
    AttenuationCurveID_MaxCount = 19,
    AttenuationCurveID_Project = 254,
    AttenuationCurveID_None = 255,
}

enum AkAudioDeviceState
{
    AkDeviceState_Unknown = 0,
    AkDeviceState_Active = 1,
    AkDeviceState_Disabled = 2,
    AkDeviceState_NotPresent = 4,
    AkDeviceState_Unplugged = 8,
    AkDeviceState_All = 15,
}

class AkAudioFormat : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2117844*/ nint getCPtr(AkAudioFormat obj);
    /*0x2117814*/ AkAudioFormat(nint cPtr, bool cMemoryOwn);
    /*0x21181e0*/ AkAudioFormat();
    /*0x2117850*/ void setCPtr(nint cPtr);
    /*0x21178e0*/ void Finalize();
    /*0x2117874*/ void Dispose();
    /*0x2117970*/ void Dispose(bool disposing);
    /*0x2117ab8*/ void set_uSampleRate(uint value);
    /*0x2117b20*/ uint get_uSampleRate();
    /*0x2117b78*/ void set_channelConfig(AkChannelConfig value);
    /*0x2117be0*/ AkChannelConfig get_channelConfig();
    /*0x2117c80*/ void set_uBitsPerSample(uint value);
    /*0x2117ce8*/ uint get_uBitsPerSample();
    /*0x2117d40*/ void set_uBlockAlign(uint value);
    /*0x2117da8*/ uint get_uBlockAlign();
    /*0x2117e00*/ void set_uTypeID(uint value);
    /*0x2117e68*/ uint get_uTypeID();
    /*0x2117ec0*/ void set_uInterleaveID(uint value);
    /*0x2117f28*/ uint get_uInterleaveID();
    /*0x2117f80*/ uint GetNumChannels();
    /*0x2117fd8*/ uint GetBitsPerSample();
    /*0x2118030*/ uint GetBlockAlign();
    /*0x2118088*/ uint GetTypeID();
    /*0x21180e0*/ uint GetInterleaveID();
    /*0x2118138*/ void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID);
}

class AkAudioInterruptionCallbackInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2118280*/ nint getCPtr(AkAudioInterruptionCallbackInfo obj);
    /*0x2118250*/ AkAudioInterruptionCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x211854c*/ AkAudioInterruptionCallbackInfo();
    /*0x211828c*/ void setCPtr(nint cPtr);
    /*0x211831c*/ void Finalize();
    /*0x21182b0*/ void Dispose();
    /*0x21183ac*/ void Dispose(bool disposing);
    /*0x21184f4*/ bool get_bEnterInterruption();
}

enum AkAudioObjectDestination
{
    eDefault = 0,
    eMainMix = 1,
    ePassthrough = 2,
    eSystemAudioObject = 3,
}

class AkAudioSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20da5f8*/ nint getCPtr(AkAudioSettings obj);
    /*0x21185bc*/ AkAudioSettings(nint cPtr, bool cMemoryOwn);
    /*0x21189d4*/ AkAudioSettings();
    /*0x21185ec*/ void setCPtr(nint cPtr);
    /*0x211867c*/ void Finalize();
    /*0x2118610*/ void Dispose();
    /*0x211870c*/ void Dispose(bool disposing);
    /*0x2118854*/ void set_uNumSamplesPerFrame(uint value);
    /*0x21188bc*/ uint get_uNumSamplesPerFrame();
    /*0x2118914*/ void set_uNumSamplesPerSecond(uint value);
    /*0x211897c*/ uint get_uNumSamplesPerSecond();
}

class AkAudioSourceChangeCallbackInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2118a74*/ nint getCPtr(AkAudioSourceChangeCallbackInfo obj);
    /*0x2118a44*/ AkAudioSourceChangeCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x2118d40*/ AkAudioSourceChangeCallbackInfo();
    /*0x2118a80*/ void setCPtr(nint cPtr);
    /*0x2118b10*/ void Finalize();
    /*0x2118aa4*/ void Dispose();
    /*0x2118ba0*/ void Dispose(bool disposing);
    /*0x2118ce8*/ bool get_bOtherAudioPlaying();
}

class AkAuxSendValue : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2118de0*/ nint getCPtr(AkAuxSendValue obj);
    static /*0x211949c*/ int GetSizeOf();
    /*0x2118db0*/ AkAuxSendValue(nint cPtr, bool cMemoryOwn);
    /*0x2118dec*/ void setCPtr(nint cPtr);
    /*0x2118e7c*/ void Finalize();
    /*0x2118e10*/ void Dispose();
    /*0x2118f0c*/ void Dispose(bool disposing);
    /*0x2119054*/ void set_listenerID(ulong value);
    /*0x21190bc*/ ulong get_listenerID();
    /*0x2119114*/ void set_auxBusID(uint value);
    /*0x211917c*/ uint get_auxBusID();
    /*0x21191d4*/ void set_fControlValue(float value);
    /*0x211923c*/ float get_fControlValue();
    /*0x2119294*/ void Set(ulong listener, uint id, float value);
    /*0x2119314*/ bool IsSame(ulong listener, uint id);
    /*0x2119384*/ void Set(UnityEngine.GameObject listener, uint id, float value);
    /*0x2119418*/ bool IsSame(UnityEngine.GameObject listener, uint id);
}

class AkBankCallbackInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2119518*/ nint getCPtr(AkBankCallbackInfo obj);
    /*0x21194e8*/ AkBankCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x2119894*/ AkBankCallbackInfo();
    /*0x2119524*/ void setCPtr(nint cPtr);
    /*0x21195b4*/ void Finalize();
    /*0x2119548*/ void Dispose();
    /*0x2119644*/ void Dispose(bool disposing);
    /*0x211978c*/ uint get_bankID();
    /*0x21197e4*/ nint get_inMemoryBankPtr();
    /*0x211983c*/ AKRESULT get_loadResult();
}

enum AkBankContent
{
    AkBankContent_StructureOnly = 0,
    AkBankContent_All = 1,
}

enum AkBankTypeEnum
{
    AkBankType_User = 0,
    AkBankType_Event = 30,
    AkBankType_Bus = 31,
}

class AkBehavioralPositioningData : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2119934*/ nint getCPtr(AkBehavioralPositioningData obj);
    /*0x2119904*/ AkBehavioralPositioningData(nint cPtr, bool cMemoryOwn);
    /*0x2119ba8*/ AkBehavioralPositioningData();
    /*0x2119940*/ void setCPtr(nint cPtr);
    /*0x21199d0*/ void Finalize();
    /*0x2119964*/ void Dispose();
    /*0x2119a60*/ void Dispose(bool disposing);
    /*0x2119c18*/ void set_center(float value);
    /*0x2119c80*/ float get_center();
    /*0x2119cd8*/ void set_panLR(float value);
    /*0x2119d40*/ float get_panLR();
    /*0x2119d98*/ void set_panBF(float value);
    /*0x2119e00*/ float get_panBF();
    /*0x2119e58*/ void set_panDU(float value);
    /*0x2119ec0*/ float get_panDU();
    /*0x2119f18*/ void set_panSpatMix(float value);
    /*0x2119f80*/ float get_panSpatMix();
    /*0x2119fd8*/ void set_spatMode(Ak3DSpatializationMode value);
    /*0x211a040*/ Ak3DSpatializationMode get_spatMode();
    /*0x211a09c*/ void set_panType(AkSpeakerPanningType value);
    /*0x211a104*/ AkSpeakerPanningType get_panType();
    /*0x211a160*/ void set_enableHeightSpread(bool value);
    /*0x211a1c8*/ bool get_enableHeightSpread();
}

enum AkBusHierarchyFlags
{
    AkBusHierarchy_Primary = 1,
    AkBusHierarchy_Secondary = 2,
    AkBusHierarchy_IsMaster = 128,
}

class AkCallbackInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211a250*/ nint getCPtr(AkCallbackInfo obj);
    /*0x211a220*/ AkCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x211a574*/ AkCallbackInfo();
    /*0x211a25c*/ void setCPtr(nint cPtr);
    /*0x211a2ec*/ void Finalize();
    /*0x211a280*/ void Dispose();
    /*0x211a37c*/ void Dispose(bool disposing);
    /*0x211a4c4*/ nint get_pCookie();
    /*0x211a51c*/ ulong get_gameObjID();
}

class AkCallbackSerializer : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211a614*/ nint getCPtr(AkCallbackSerializer obj);
    static /*0x211a888*/ AKRESULT Init();
    static /*0x211a8d4*/ void Term();
    static /*0x211a920*/ nint Lock();
    static /*0x211a96c*/ void Unlock();
    static /*0x211a9b8*/ void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout);
    static /*0x211aa4c*/ AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie);
    /*0x211a5e4*/ AkCallbackSerializer(nint cPtr, bool cMemoryOwn);
    /*0x211aac8*/ AkCallbackSerializer();
    /*0x211a620*/ void setCPtr(nint cPtr);
    /*0x211a6b0*/ void Finalize();
    /*0x211a644*/ void Dispose();
    /*0x211a740*/ void Dispose(bool disposing);
}

enum AkCallbackType
{
    AK_EndOfEvent = 1,
    AK_EndOfDynamicSequenceItem = 2,
    AK_Marker = 4,
    AK_Duration = 8,
    AK_SpeakerVolumeMatrix = 16,
    AK_Starvation = 32,
    AK_MusicPlaylistSelect = 64,
    AK_MusicPlayStarted = 128,
    AK_MusicSyncBeat = 256,
    AK_MusicSyncBar = 512,
    AK_MusicSyncEntry = 1024,
    AK_MusicSyncExit = 2048,
    AK_MusicSyncGrid = 4096,
    AK_MusicSyncUserCue = 8192,
    AK_MusicSyncPoint = 16384,
    AK_MusicSyncAll = 32512,
    AK_MIDIEvent = 65536,
    AK_CallbackBits = 1048575,
    AK_EnableGetSourcePlayPosition = 1048576,
    AK_EnableGetMusicPlayPosition = 2097152,
    AK_EnableGetSourceStreamBuffering = 4194304,
    AK_Monitoring = 536870912,
    AK_Bank = 1073741824,
    AK_AudioInterruption = 570425344,
    AK_AudioSourceChange = 587202560,
}

class AkChannelConfig : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20da934*/ nint getCPtr(AkChannelConfig obj);
    static /*0x211afe0*/ AkChannelConfig Standard(uint in_uChannelMask);
    static /*0x211b078*/ AkChannelConfig Anonymous(uint in_uNumChannels);
    static /*0x211b110*/ AkChannelConfig Ambisonic(uint in_uNumChannels);
    static /*0x211b1a8*/ AkChannelConfig Object();
    /*0x20da794*/ AkChannelConfig(nint cPtr, bool cMemoryOwn);
    /*0x211b238*/ AkChannelConfig();
    /*0x211b2a8*/ AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask);
    /*0x211ab38*/ void setCPtr(nint cPtr);
    /*0x211abc8*/ void Finalize();
    /*0x211ab5c*/ void Dispose();
    /*0x211ac58*/ void Dispose(bool disposing);
    /*0x211ada0*/ void set_uNumChannels(uint value);
    /*0x211ae08*/ uint get_uNumChannels();
    /*0x211ae60*/ void set_eConfigType(uint value);
    /*0x211aec8*/ uint get_eConfigType();
    /*0x211af20*/ void set_uChannelMask(uint value);
    /*0x211af88*/ uint get_uChannelMask();
    /*0x211b330*/ void Clear();
    /*0x211b388*/ void SetStandard(uint in_uChannelMask);
    /*0x211b3f0*/ void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask);
    /*0x211b460*/ void SetAnonymous(uint in_uNumChannels);
    /*0x211b4c8*/ void SetAmbisonic(uint in_uNumChannels);
    /*0x211b530*/ void SetObject();
    /*0x211b588*/ void SetSameAsMainMix();
    /*0x211b5e0*/ void SetSameAsPassthrough();
    /*0x211b638*/ bool IsValid();
    /*0x211b690*/ uint Serialize();
    /*0x211b6e8*/ void Deserialize(uint in_uChannelConfig);
    /*0x211b750*/ AkChannelConfig RemoveLFE();
    /*0x211b7ec*/ AkChannelConfig RemoveCenter();
}

enum AkChannelConfigType
{
    AK_ChannelConfigType_Anonymous = 0,
    AK_ChannelConfigType_Standard = 1,
    AK_ChannelConfigType_Ambisonic = 2,
    AK_ChannelConfigType_Objects = 3,
    AK_ChannelConfigType_UseDeviceMain = 14,
    AK_ChannelConfigType_UseDevicePassthrough = 15,
}

class AkChannelEmitter : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211b8b8*/ nint getCPtr(AkChannelEmitter obj);
    /*0x211b888*/ AkChannelEmitter(nint cPtr, bool cMemoryOwn);
    /*0x211b8c4*/ void setCPtr(nint cPtr);
    /*0x211b954*/ void Finalize();
    /*0x211b8e8*/ void Dispose();
    /*0x211b9e4*/ void Dispose(bool disposing);
    /*0x211bb2c*/ void set_position(AkWorldTransform value);
    /*0x211bba8*/ AkWorldTransform get_position();
    /*0x211bc48*/ void set_uInputChannels(uint value);
    /*0x211bcb0*/ uint get_uInputChannels();
    /*0x211bd08*/ void set_padding(string value);
    /*0x211bd70*/ string get_padding();
}

enum AkChannelOrdering
{
    ChannelOrdering_Standard = 0,
    ChannelOrdering_RunTime = 1,
}

enum AkConnectionType
{
    ConnectionType_Direct = 0,
    ConnectionType_GameDefSend = 1,
    ConnectionType_UserDefSend = 2,
    ConnectionType_ReflectionsSend = 3,
}

enum AkCurveInterpolation
{
    AkCurveInterpolation_Log3 = 0,
    AkCurveInterpolation_Sine = 1,
    AkCurveInterpolation_Log1 = 2,
    AkCurveInterpolation_InvSCurve = 3,
    AkCurveInterpolation_Linear = 4,
    AkCurveInterpolation_SCurve = 5,
    AkCurveInterpolation_Exp1 = 6,
    AkCurveInterpolation_SineRecip = 7,
    AkCurveInterpolation_Exp3 = 8,
    AkCurveInterpolation_LastFadeCurve = 8,
    AkCurveInterpolation_Constant = 9,
}

class AkDeviceDescription : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211be2c*/ nint getCPtr(AkDeviceDescription obj);
    static /*0x211c42c*/ int GetSizeOf();
    /*0x211bdfc*/ AkDeviceDescription(nint cPtr, bool cMemoryOwn);
    /*0x211c4e0*/ AkDeviceDescription();
    /*0x211be38*/ void setCPtr(nint cPtr);
    /*0x211bec8*/ void Finalize();
    /*0x211be5c*/ void Dispose();
    /*0x211bf58*/ void Dispose(bool disposing);
    /*0x211c0a0*/ void set_idDevice(uint value);
    /*0x211c108*/ uint get_idDevice();
    /*0x211c160*/ void set_deviceName(string value);
    /*0x211c1c8*/ string get_deviceName();
    /*0x211c254*/ void set_deviceStateMask(AkAudioDeviceState value);
    /*0x211c2bc*/ AkAudioDeviceState get_deviceStateMask();
    /*0x211c314*/ void set_isDefaultDevice(bool value);
    /*0x211c37c*/ bool get_isDefaultDevice();
    /*0x211c3d4*/ void Clear();
    /*0x211c478*/ void Clone(AkDeviceDescription other);
}

class AkDeviceSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20eb46c*/ nint getCPtr(AkDeviceSettings obj);
    /*0x211c550*/ AkDeviceSettings(nint cPtr, bool cMemoryOwn);
    /*0x211c580*/ void setCPtr(nint cPtr);
    /*0x211c610*/ void Finalize();
    /*0x211c5a4*/ void Dispose();
    /*0x211c6a0*/ void Dispose(bool disposing);
    /*0x211c7e8*/ void set_pIOMemory(nint value);
    /*0x211c850*/ nint get_pIOMemory();
    /*0x211c8a8*/ void set_uIOMemorySize(uint value);
    /*0x211c910*/ uint get_uIOMemorySize();
    /*0x211c968*/ void set_uIOMemoryAlignment(uint value);
    /*0x211c9d0*/ uint get_uIOMemoryAlignment();
    /*0x211ca28*/ void set_ePoolAttributes(uint value);
    /*0x211ca90*/ uint get_ePoolAttributes();
    /*0x211cae8*/ void set_uGranularity(uint value);
    /*0x211cb50*/ uint get_uGranularity();
    /*0x211cba8*/ void set_threadProperties(AkThreadProperties value);
    /*0x211cc10*/ AkThreadProperties get_threadProperties();
    /*0x211ccb0*/ void set_fTargetAutoStmBufferLength(float value);
    /*0x211cd18*/ float get_fTargetAutoStmBufferLength();
    /*0x211cd70*/ void set_uMaxConcurrentIO(uint value);
    /*0x211cdd8*/ uint get_uMaxConcurrentIO();
    /*0x211ce30*/ void set_bUseStreamCache(bool value);
    /*0x211ce98*/ bool get_bUseStreamCache();
    /*0x211cef0*/ void set_uMaxCachePinnedBytes(uint value);
    /*0x211cf58*/ uint get_uMaxCachePinnedBytes();
}

class AkDiffractionPathInfo : System.IDisposable
{
    static uint kMaxNodes = 8;
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211cfe0*/ nint getCPtr(AkDiffractionPathInfo obj);
    static /*0x211d8b0*/ int GetSizeOf();
    /*0x211cfb0*/ AkDiffractionPathInfo(nint cPtr, bool cMemoryOwn);
    /*0x211db04*/ AkDiffractionPathInfo();
    /*0x211cfec*/ void setCPtr(nint cPtr);
    /*0x211d07c*/ void Finalize();
    /*0x211d010*/ void Dispose();
    /*0x211d10c*/ void Dispose(bool disposing);
    /*0x211d254*/ void set_emitterPos(AkVector64 value);
    /*0x211d2bc*/ AkVector64 get_emitterPos();
    /*0x211d314*/ void set_virtualPos(AkWorldTransform value);
    /*0x211d390*/ AkWorldTransform get_virtualPos();
    /*0x211d430*/ void set_nodeCount(uint value);
    /*0x211d498*/ uint get_nodeCount();
    /*0x211d4f0*/ void set_diffraction(float value);
    /*0x211d558*/ float get_diffraction();
    /*0x211d5b0*/ void set_transmissionLoss(float value);
    /*0x211d618*/ float get_transmissionLoss();
    /*0x211d670*/ void set_totLength(float value);
    /*0x211d6d8*/ float get_totLength();
    /*0x211d730*/ void set_obstructionValue(float value);
    /*0x211d798*/ float get_obstructionValue();
    /*0x211d7f0*/ void set_occlusionValue(float value);
    /*0x211d858*/ float get_occlusionValue();
    /*0x211d8fc*/ UnityEngine.Vector3 GetNodes(uint idx);
    /*0x211d964*/ float GetAngles(uint idx);
    /*0x211d9cc*/ ulong GetPortals(uint idx);
    /*0x211da34*/ ulong GetRooms(uint idx);
    /*0x211da9c*/ void Clone(AkDiffractionPathInfo other);
}

class AkDurationCallbackInfo : AkEventCallbackInfo
{
    /*0x28*/ nint swigCPtr;

    static /*0x211dc78*/ nint getCPtr(AkDurationCallbackInfo obj);
    /*0x211db74*/ AkDurationCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x211e1d8*/ AkDurationCallbackInfo();
    /*0x211dc84*/ void setCPtr(nint cPtr);
    /*0x211dd70*/ void Dispose(bool disposing);
    /*0x211e020*/ float get_fDuration();
    /*0x211e078*/ float get_fEstimatedDuration();
    /*0x211e0d0*/ uint get_audioNodeID();
    /*0x211e128*/ uint get_mediaID();
    /*0x211e180*/ bool get_bStreaming();
}

class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
    /*0x20*/ nint swigCPtr;

    static /*0x211e2c0*/ nint getCPtr(AkDynamicSequenceItemCallbackInfo obj);
    /*0x211e238*/ AkDynamicSequenceItemCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x211e5a4*/ AkDynamicSequenceItemCallbackInfo();
    /*0x211e2cc*/ void setCPtr(nint cPtr);
    /*0x211e344*/ void Dispose(bool disposing);
    /*0x211e49c*/ uint get_playingID();
    /*0x211e4f4*/ uint get_audioNodeID();
    /*0x211e54c*/ nint get_pCustomInfo();
}

enum AkDynamicSequenceType
{
    DynamicSequenceType_SampleAccurate = 0,
    DynamicSequenceType_NormalTransition = 1,
}

class AkEventCallbackInfo : AkCallbackInfo
{
    /*0x20*/ nint swigCPtr;

    static /*0x211e604*/ nint getCPtr(AkEventCallbackInfo obj);
    /*0x211dbf0*/ AkEventCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x211e6c0*/ AkEventCallbackInfo();
    /*0x211dcf8*/ void setCPtr(nint cPtr);
    /*0x211dec8*/ void Dispose(bool disposing);
    /*0x211e610*/ uint get_playingID();
    /*0x211e668*/ uint get_eventID();
}

class AkExtent : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20f2d64*/ nint getCPtr(AkExtent obj);
    /*0x211e720*/ AkExtent(nint cPtr, bool cMemoryOwn);
    /*0x211e9b8*/ AkExtent();
    /*0x211ea28*/ AkExtent(float in_halfWidth, float in_halfHeight, float in_halfDepth);
    /*0x211e750*/ void setCPtr(nint cPtr);
    /*0x211e7e0*/ void Finalize();
    /*0x211e774*/ void Dispose();
    /*0x211e870*/ void Dispose(bool disposing);
    /*0x211eac0*/ void set_halfWidth(float value);
    /*0x211eb28*/ float get_halfWidth();
    /*0x211eb80*/ void set_halfHeight(float value);
    /*0x211ebe8*/ float get_halfHeight();
    /*0x211ec40*/ void set_halfDepth(float value);
    /*0x211eca8*/ float get_halfDepth();
}

class AkExternalSourceInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211ed30*/ nint getCPtr(AkExternalSourceInfo obj);
    static /*0x211f2a4*/ int GetSizeOf();
    /*0x211ed00*/ AkExternalSourceInfo(nint cPtr, bool cMemoryOwn);
    /*0x211efa4*/ AkExternalSourceInfo();
    /*0x211f014*/ AkExternalSourceInfo(nint in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec);
    /*0x211f0b4*/ AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec);
    /*0x211f14c*/ AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec);
    /*0x211ed3c*/ void setCPtr(nint cPtr);
    /*0x211edcc*/ void Finalize();
    /*0x211ed60*/ void Dispose();
    /*0x211ee5c*/ void Dispose(bool disposing);
    /*0x211f1e4*/ void Clear();
    /*0x211f23c*/ void Clone(AkExternalSourceInfo other);
    /*0x211f2f0*/ void set_iExternalSrcCookie(uint value);
    /*0x211f358*/ uint get_iExternalSrcCookie();
    /*0x211f3b0*/ void set_idCodec(uint value);
    /*0x211f418*/ uint get_idCodec();
    /*0x211f470*/ void set_szFile(string value);
    /*0x211f4d8*/ string get_szFile();
    /*0x211f564*/ void set_pInMemory(nint value);
    /*0x211f5cc*/ nint get_pInMemory();
    /*0x211f624*/ void set_uiMemorySize(uint value);
    /*0x211f68c*/ uint get_uiMemorySize();
    /*0x211f6e4*/ void set_idFile(uint value);
    /*0x211f74c*/ uint get_idFile();
}

enum AkFloorPlane
{
    AkFloorPlane_XZ = 0,
    AkFloorPlane_XY = 1,
    AkFloorPlane_YZ = 2,
    AkFloorPlane_Default = 0,
}

class AkGeometryInstanceParams : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211f7d4*/ nint getCPtr(AkGeometryInstanceParams obj);
    /*0x211f7a4*/ AkGeometryInstanceParams(nint cPtr, bool cMemoryOwn);
    /*0x211fa48*/ AkGeometryInstanceParams();
    /*0x211f7e0*/ void setCPtr(nint cPtr);
    /*0x211f870*/ void Finalize();
    /*0x211f804*/ void Dispose();
    /*0x211f900*/ void Dispose(bool disposing);
    /*0x211fab8*/ void set_PositionAndOrientation(AkWorldTransform value);
    /*0x211fb34*/ AkWorldTransform get_PositionAndOrientation();
    /*0x211fbd4*/ void set_Scale(UnityEngine.Vector3 value);
    /*0x211fc54*/ UnityEngine.Vector3 get_Scale();
    /*0x211fcac*/ void set_UseForReflectionAndDiffraction(bool value);
    /*0x211fd14*/ bool get_UseForReflectionAndDiffraction();
}

enum AkGlobalCallbackLocation
{
    AkGlobalCallbackLocation_Register = 1,
    AkGlobalCallbackLocation_Begin = 2,
    AkGlobalCallbackLocation_PreProcessMessageQueueForRender = 4,
    AkGlobalCallbackLocation_PostMessagesProcessed = 8,
    AkGlobalCallbackLocation_BeginRender = 16,
    AkGlobalCallbackLocation_EndRender = 32,
    AkGlobalCallbackLocation_End = 64,
    AkGlobalCallbackLocation_Term = 128,
    AkGlobalCallbackLocation_Monitor = 256,
    AkGlobalCallbackLocation_MonitorRecap = 512,
    AkGlobalCallbackLocation_Init = 1024,
    AkGlobalCallbackLocation_Suspend = 2048,
    AkGlobalCallbackLocation_WakeupFromSuspend = 4096,
    AkGlobalCallbackLocation_Num = 13,
}

enum AkGroupType
{
    AkGroupType_Switch = 0,
    AkGroupType_State = 1,
}

class AkImageSourceParams : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x211fd9c*/ nint getCPtr(AkImageSourceParams obj);
    /*0x211fd6c*/ AkImageSourceParams(nint cPtr, bool cMemoryOwn);
    /*0x2120010*/ AkImageSourceParams();
    /*0x2120080*/ AkImageSourceParams(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel);
    /*0x211fda8*/ void setCPtr(nint cPtr);
    /*0x211fe38*/ void Finalize();
    /*0x211fdcc*/ void Dispose();
    /*0x211fec8*/ void Dispose(bool disposing);
    /*0x2120118*/ void set_sourcePosition(AkVector64 value);
    /*0x2120180*/ AkVector64 get_sourcePosition();
    /*0x21201d8*/ void set_fDistanceScalingFactor(float value);
    /*0x2120240*/ float get_fDistanceScalingFactor();
    /*0x2120298*/ void set_fLevel(float value);
    /*0x2120300*/ float get_fLevel();
    /*0x2120358*/ void set_fDiffraction(float value);
    /*0x21203c0*/ float get_fDiffraction();
    /*0x2120418*/ void set_uDiffractionEmitterSide(byte value);
    /*0x2120480*/ byte get_uDiffractionEmitterSide();
    /*0x21204d8*/ void set_uDiffractionListenerSide(byte value);
    /*0x2120540*/ byte get_uDiffractionListenerSide();
}

class AkImageSourceSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20ee4bc*/ nint getCPtr(AkImageSourceSettings obj);
    /*0x2120598*/ AkImageSourceSettings(nint cPtr, bool cMemoryOwn);
    /*0x2120830*/ AkImageSourceSettings();
    /*0x21208a0*/ AkImageSourceSettings(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel);
    /*0x21205c8*/ void setCPtr(nint cPtr);
    /*0x2120658*/ void Finalize();
    /*0x21205ec*/ void Dispose();
    /*0x21206e8*/ void Dispose(bool disposing);
    /*0x2120938*/ void SetOneTexture(uint in_texture);
    /*0x21209a0*/ void set_params_(AkImageSourceParams value);
    /*0x2120a08*/ AkImageSourceParams get_params_();
}

class AkInitializationSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20f0278*/ nint getCPtr(AkInitializationSettings obj);
    /*0x2120aa8*/ AkInitializationSettings(nint cPtr, bool cMemoryOwn);
    /*0x2120d40*/ AkInitializationSettings();
    /*0x2120ad8*/ void setCPtr(nint cPtr);
    /*0x2120b68*/ void Finalize();
    /*0x2120afc*/ void Dispose();
    /*0x2120bf8*/ void Dispose(bool disposing);
    /*0x2120db0*/ void set_streamMgrSettings(AkStreamMgrSettings value);
    /*0x2120e2c*/ AkStreamMgrSettings get_streamMgrSettings();
    /*0x2120ecc*/ void set_deviceSettings(AkDeviceSettings value);
    /*0x2120f34*/ AkDeviceSettings get_deviceSettings();
    /*0x2120fd4*/ void set_initSettings(AkInitSettings value);
    /*0x212103c*/ AkInitSettings get_initSettings();
    /*0x212110c*/ void set_platformSettings(AkPlatformInitSettings value);
    /*0x2121174*/ AkPlatformInitSettings get_platformSettings();
    /*0x2121214*/ void set_musicSettings(AkMusicSettings value);
    /*0x2121290*/ AkMusicSettings get_musicSettings();
    /*0x2121330*/ void set_unityPlatformSpecificSettings(AkUnityPlatformSpecificSettings value);
    /*0x2121398*/ AkUnityPlatformSpecificSettings get_unityPlatformSpecificSettings();
    /*0x2121438*/ void set_uMemAllocationSizeLimit(uint value);
    /*0x21214a0*/ uint get_uMemAllocationSizeLimit();
    /*0x21214f8*/ void set_uMemDebugLevel(uint value);
    /*0x2121560*/ uint get_uMemDebugLevel();
    /*0x21215b8*/ void set_uMemSpanCount(uint value);
    /*0x2121620*/ uint get_uMemSpanCount();
}

class AkInitSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x20eff00*/ nint getCPtr(AkInitSettings obj);
    /*0x21210dc*/ AkInitSettings(nint cPtr, bool cMemoryOwn);
    /*0x2121678*/ void setCPtr(nint cPtr);
    /*0x2121708*/ void Finalize();
    /*0x212169c*/ void Dispose();
    /*0x2121798*/ void Dispose(bool disposing);
    /*0x21218e0*/ void set_uMaxNumPaths(uint value);
    /*0x2121948*/ uint get_uMaxNumPaths();
    /*0x21219a0*/ void set_uCommandQueueSize(uint value);
    /*0x2121a08*/ uint get_uCommandQueueSize();
    /*0x2121a60*/ void set_bEnableGameSyncPreparation(bool value);
    /*0x2121ac8*/ bool get_bEnableGameSyncPreparation();
    /*0x2121b20*/ void set_uContinuousPlaybackLookAhead(uint value);
    /*0x2121b88*/ uint get_uContinuousPlaybackLookAhead();
    /*0x2121be0*/ void set_uNumSamplesPerFrame(uint value);
    /*0x2121c48*/ uint get_uNumSamplesPerFrame();
    /*0x2121ca0*/ void set_uMonitorQueuePoolSize(uint value);
    /*0x2121d08*/ uint get_uMonitorQueuePoolSize();
    /*0x2121d60*/ void set_uCpuMonitorQueueMaxSize(uint value);
    /*0x2121dc8*/ uint get_uCpuMonitorQueueMaxSize();
    /*0x2121e20*/ void set_settingsMainOutput(AkOutputSettings value);
    /*0x2121e9c*/ AkOutputSettings get_settingsMainOutput();
    /*0x2121f3c*/ void set_uMaxHardwareTimeoutMs(uint value);
    /*0x2121fa4*/ uint get_uMaxHardwareTimeoutMs();
    /*0x2121ffc*/ void set_bUseSoundBankMgrThread(bool value);
    /*0x2122064*/ bool get_bUseSoundBankMgrThread();
    /*0x21220bc*/ void set_bUseLEngineThread(bool value);
    /*0x2122124*/ bool get_bUseLEngineThread();
    /*0x212217c*/ void set_szPluginDLLPath(string value);
    /*0x21221e4*/ string get_szPluginDLLPath();
    /*0x2122270*/ void set_eFloorPlane(AkFloorPlane value);
    /*0x21222d8*/ AkFloorPlane get_eFloorPlane();
    /*0x2122330*/ void set_fGameUnitsToMeters(float value);
    /*0x2122398*/ float get_fGameUnitsToMeters();
    /*0x21223f0*/ void set_uBankReadBufferSize(uint value);
    /*0x2122458*/ uint get_uBankReadBufferSize();
    /*0x21224b0*/ void set_fDebugOutOfRangeLimit(float value);
    /*0x2122518*/ float get_fDebugOutOfRangeLimit();
    /*0x2122570*/ void set_bDebugOutOfRangeCheckEnabled(bool value);
    /*0x21225d8*/ bool get_bDebugOutOfRangeCheckEnabled();
}

class AkIterator : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212449c*/ nint getCPtr(AkIterator obj);
    /*0x212446c*/ AkIterator(nint cPtr, bool cMemoryOwn);
    /*0x2124b0c*/ AkIterator();
    /*0x21244a8*/ void setCPtr(nint cPtr);
    /*0x2124538*/ void Finalize();
    /*0x21244cc*/ void Dispose();
    /*0x21245c8*/ void Dispose(bool disposing);
    /*0x2124714*/ void set_pItem(AkPlaylistItem value);
    /*0x212478c*/ AkPlaylistItem get_pItem();
    /*0x2124860*/ AkIterator NextIter();
    /*0x21248fc*/ AkIterator PrevIter();
    /*0x2124998*/ AkPlaylistItem GetItem();
    /*0x2124a34*/ bool IsEqualTo(AkIterator in_rOp);
    /*0x2124aa0*/ bool IsDifferentFrom(AkIterator in_rOp);
}

class AkMarkerCallbackInfo : AkEventCallbackInfo
{
    /*0x28*/ nint swigCPtr;

    static /*0x2124c04*/ nint getCPtr(AkMarkerCallbackInfo obj);
    /*0x2124b80*/ AkMarkerCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x2124f3c*/ AkMarkerCallbackInfo();
    /*0x2124c10*/ void setCPtr(nint cPtr);
    /*0x2124c8c*/ void Dispose(bool disposing);
    /*0x2124df0*/ uint get_uIdentifier();
    /*0x2124e4c*/ uint get_uPosition();
    /*0x2124ea8*/ string get_strLabel();
}

enum AkMeteringFlags
{
    AK_NoMetering = 0,
    AK_EnableBusMeter_Peak = 1,
    AK_EnableBusMeter_TruePeak = 2,
    AK_EnableBusMeter_RMS = 4,
    AK_EnableBusMeter_KPower = 16,
    AK_EnableBusMeter_3DMeter = 32,
}

enum AkMIDICcTypes
{
    BANK_SELECT_COARSE = 0,
    MOD_WHEEL_COARSE = 1,
    BREATH_CTRL_COARSE = 2,
    CTRL_3_COARSE = 3,
    FOOT_PEDAL_COARSE = 4,
    PORTAMENTO_COARSE = 5,
    DATA_ENTRY_COARSE = 6,
    VOLUME_COARSE = 7,
    BALANCE_COARSE = 8,
    CTRL_9_COARSE = 9,
    PAN_POSITION_COARSE = 10,
    EXPRESSION_COARSE = 11,
    EFFECT_CTRL_1_COARSE = 12,
    EFFECT_CTRL_2_COARSE = 13,
    CTRL_14_COARSE = 14,
    CTRL_15_COARSE = 15,
    GEN_SLIDER_1 = 16,
    GEN_SLIDER_2 = 17,
    GEN_SLIDER_3 = 18,
    GEN_SLIDER_4 = 19,
    CTRL_20_COARSE = 20,
    CTRL_21_COARSE = 21,
    CTRL_22_COARSE = 22,
    CTRL_23_COARSE = 23,
    CTRL_24_COARSE = 24,
    CTRL_25_COARSE = 25,
    CTRL_26_COARSE = 26,
    CTRL_27_COARSE = 27,
    CTRL_28_COARSE = 28,
    CTRL_29_COARSE = 29,
    CTRL_30_COARSE = 30,
    CTRL_31_COARSE = 31,
    BANK_SELECT_FINE = 32,
    MOD_WHEEL_FINE = 33,
    BREATH_CTRL_FINE = 34,
    CTRL_3_FINE = 35,
    FOOT_PEDAL_FINE = 36,
    PORTAMENTO_FINE = 37,
    DATA_ENTRY_FINE = 38,
    VOLUME_FINE = 39,
    BALANCE_FINE = 40,
    CTRL_9_FINE = 41,
    PAN_POSITION_FINE = 42,
    EXPRESSION_FINE = 43,
    EFFECT_CTRL_1_FINE = 44,
    EFFECT_CTRL_2_FINE = 45,
    CTRL_14_FINE = 46,
    CTRL_15_FINE = 47,
    CTRL_20_FINE = 52,
    CTRL_21_FINE = 53,
    CTRL_22_FINE = 54,
    CTRL_23_FINE = 55,
    CTRL_24_FINE = 56,
    CTRL_25_FINE = 57,
    CTRL_26_FINE = 58,
    CTRL_27_FINE = 59,
    CTRL_28_FINE = 60,
    CTRL_29_FINE = 61,
    CTRL_30_FINE = 62,
    CTRL_31_FINE = 63,
    HOLD_PEDAL = 64,
    PORTAMENTO_ON_OFF = 65,
    SUSTENUTO_PEDAL = 66,
    SOFT_PEDAL = 67,
    LEGATO_PEDAL = 68,
    HOLD_PEDAL_2 = 69,
    SOUND_VARIATION = 70,
    SOUND_TIMBRE = 71,
    SOUND_RELEASE_TIME = 72,
    SOUND_ATTACK_TIME = 73,
    SOUND_BRIGHTNESS = 74,
    SOUND_CTRL_6 = 75,
    SOUND_CTRL_7 = 76,
    SOUND_CTRL_8 = 77,
    SOUND_CTRL_9 = 78,
    SOUND_CTRL_10 = 79,
    GENERAL_BUTTON_1 = 80,
    GENERAL_BUTTON_2 = 81,
    GENERAL_BUTTON_3 = 82,
    GENERAL_BUTTON_4 = 83,
    REVERB_LEVEL = 91,
    TREMOLO_LEVEL = 92,
    CHORUS_LEVEL = 93,
    CELESTE_LEVEL = 94,
    PHASER_LEVEL = 95,
    DATA_BUTTON_P1 = 96,
    DATA_BUTTON_M1 = 97,
    NON_REGISTER_COARSE = 98,
    NON_REGISTER_FINE = 99,
    ALL_SOUND_OFF = 120,
    ALL_CONTROLLERS_OFF = 121,
    LOCAL_KEYBOARD = 122,
    ALL_NOTES_OFF = 123,
    OMNI_MODE_OFF = 124,
    OMNI_MODE_ON = 125,
    OMNI_MONOPHONIC_ON = 126,
    OMNI_POLYPHONIC_ON = 127,
}

class AkMIDIEvent : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2124fd0*/ nint getCPtr(AkMIDIEvent obj);
    /*0x2124fa0*/ AkMIDIEvent(nint cPtr, bool cMemoryOwn);
    /*0x2126798*/ AkMIDIEvent();
    /*0x2124fdc*/ void setCPtr(nint cPtr);
    /*0x212506c*/ void Finalize();
    /*0x2125000*/ void Dispose();
    /*0x21250fc*/ void Dispose(bool disposing);
    /*0x2125248*/ void set_byChan(byte value);
    /*0x21252b4*/ byte get_byChan();
    /*0x2125310*/ void set_Gen(AkMIDIEvent.tGen value);
    /*0x2125388*/ AkMIDIEvent.tGen get_Gen();
    /*0x212545c*/ void set_Cc(AkMIDIEvent.tCc value);
    /*0x21254d4*/ AkMIDIEvent.tCc get_Cc();
    /*0x21255a8*/ void set_NoteOnOff(AkMIDIEvent.tNoteOnOff value);
    /*0x2125620*/ AkMIDIEvent.tNoteOnOff get_NoteOnOff();
    /*0x21256f4*/ void set_PitchBend(AkMIDIEvent.tPitchBend value);
    /*0x212576c*/ AkMIDIEvent.tPitchBend get_PitchBend();
    /*0x2125840*/ void set_NoteAftertouch(AkMIDIEvent.tNoteAftertouch value);
    /*0x21258b8*/ AkMIDIEvent.tNoteAftertouch get_NoteAftertouch();
    /*0x212598c*/ void set_ChanAftertouch(AkMIDIEvent.tChanAftertouch value);
    /*0x2125a04*/ AkMIDIEvent.tChanAftertouch get_ChanAftertouch();
    /*0x2125ad8*/ void set_ProgramChange(AkMIDIEvent.tProgramChange value);
    /*0x2125b50*/ AkMIDIEvent.tProgramChange get_ProgramChange();
    /*0x2125c24*/ void set_WwiseCmd(AkMIDIEvent.tWwiseCmd value);
    /*0x2125c9c*/ AkMIDIEvent.tWwiseCmd get_WwiseCmd();
    /*0x2125d70*/ void set_byType(AkMIDIEventTypes value);
    /*0x2125ddc*/ AkMIDIEventTypes get_byType();
    /*0x2125e38*/ void set_byOnOffNote(byte value);
    /*0x2125ea4*/ byte get_byOnOffNote();
    /*0x2125f00*/ void set_byVelocity(byte value);
    /*0x2125f6c*/ byte get_byVelocity();
    /*0x2125fc8*/ void set_byCc(AkMIDICcTypes value);
    /*0x2126034*/ AkMIDICcTypes get_byCc();
    /*0x2126090*/ void set_byCcValue(byte value);
    /*0x21260fc*/ byte get_byCcValue();
    /*0x2126158*/ void set_byValueLsb(byte value);
    /*0x21261c4*/ byte get_byValueLsb();
    /*0x2126220*/ void set_byValueMsb(byte value);
    /*0x212628c*/ byte get_byValueMsb();
    /*0x21262e8*/ void set_byAftertouchNote(byte value);
    /*0x2126354*/ byte get_byAftertouchNote();
    /*0x21263b0*/ void set_byNoteAftertouchValue(byte value);
    /*0x212641c*/ byte get_byNoteAftertouchValue();
    /*0x2126478*/ void set_byChanAftertouchValue(byte value);
    /*0x21264e4*/ byte get_byChanAftertouchValue();
    /*0x2126540*/ void set_byProgramNum(byte value);
    /*0x21265ac*/ byte get_byProgramNum();
    /*0x2126608*/ void set_uCmd(ushort value);
    /*0x2126674*/ ushort get_uCmd();
    /*0x21266d0*/ void set_uArg(uint value);
    /*0x212673c*/ uint get_uArg();

    class tGen : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x212537c*/ nint getCPtr(AkMIDIEvent.tGen obj);
        /*0x212542c*/ tGen(nint cPtr, bool cMemoryOwn);
        /*0x2126c08*/ tGen();
        /*0x212680c*/ void setCPtr(nint cPtr);
        /*0x212689c*/ void Finalize();
        /*0x2126830*/ void Dispose();
        /*0x212692c*/ void Dispose(bool disposing);
        /*0x2126a78*/ void set_byParam1(byte value);
        /*0x2126ae4*/ byte get_byParam1();
        /*0x2126b40*/ void set_byParam2(byte value);
        /*0x2126bac*/ byte get_byParam2();
    }

    class tNoteOnOff : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x2125614*/ nint getCPtr(AkMIDIEvent.tNoteOnOff obj);
        /*0x21256c4*/ tNoteOnOff(nint cPtr, bool cMemoryOwn);
        /*0x2127078*/ tNoteOnOff();
        /*0x2126c7c*/ void setCPtr(nint cPtr);
        /*0x2126d0c*/ void Finalize();
        /*0x2126ca0*/ void Dispose();
        /*0x2126d9c*/ void Dispose(bool disposing);
        /*0x2126ee8*/ void set_byNote(byte value);
        /*0x2126f54*/ byte get_byNote();
        /*0x2126fb0*/ void set_byVelocity(byte value);
        /*0x212701c*/ byte get_byVelocity();
    }

    class tCc : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x21254c8*/ nint getCPtr(AkMIDIEvent.tCc obj);
        /*0x2125578*/ tCc(nint cPtr, bool cMemoryOwn);
        /*0x21274e8*/ tCc();
        /*0x21270ec*/ void setCPtr(nint cPtr);
        /*0x212717c*/ void Finalize();
        /*0x2127110*/ void Dispose();
        /*0x212720c*/ void Dispose(bool disposing);
        /*0x2127358*/ void set_byCc(byte value);
        /*0x21273c4*/ byte get_byCc();
        /*0x2127420*/ void set_byValue(byte value);
        /*0x212748c*/ byte get_byValue();
    }

    class tPitchBend : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x2125760*/ nint getCPtr(AkMIDIEvent.tPitchBend obj);
        /*0x2125810*/ tPitchBend(nint cPtr, bool cMemoryOwn);
        /*0x2127958*/ tPitchBend();
        /*0x212755c*/ void setCPtr(nint cPtr);
        /*0x21275ec*/ void Finalize();
        /*0x2127580*/ void Dispose();
        /*0x212767c*/ void Dispose(bool disposing);
        /*0x21277c8*/ void set_byValueLsb(byte value);
        /*0x2127834*/ byte get_byValueLsb();
        /*0x2127890*/ void set_byValueMsb(byte value);
        /*0x21278fc*/ byte get_byValueMsb();
    }

    class tNoteAftertouch : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x21258ac*/ nint getCPtr(AkMIDIEvent.tNoteAftertouch obj);
        /*0x212595c*/ tNoteAftertouch(nint cPtr, bool cMemoryOwn);
        /*0x2127dc8*/ tNoteAftertouch();
        /*0x21279cc*/ void setCPtr(nint cPtr);
        /*0x2127a5c*/ void Finalize();
        /*0x21279f0*/ void Dispose();
        /*0x2127aec*/ void Dispose(bool disposing);
        /*0x2127c38*/ void set_byNote(byte value);
        /*0x2127ca4*/ byte get_byNote();
        /*0x2127d00*/ void set_byValue(byte value);
        /*0x2127d6c*/ byte get_byValue();
    }

    class tChanAftertouch : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x21259f8*/ nint getCPtr(AkMIDIEvent.tChanAftertouch obj);
        /*0x2125aa8*/ tChanAftertouch(nint cPtr, bool cMemoryOwn);
        /*0x2128170*/ tChanAftertouch();
        /*0x2127e3c*/ void setCPtr(nint cPtr);
        /*0x2127ecc*/ void Finalize();
        /*0x2127e60*/ void Dispose();
        /*0x2127f5c*/ void Dispose(bool disposing);
        /*0x21280a8*/ void set_byValue(byte value);
        /*0x2128114*/ byte get_byValue();
    }

    class tProgramChange : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x2125b44*/ nint getCPtr(AkMIDIEvent.tProgramChange obj);
        /*0x2125bf4*/ tProgramChange(nint cPtr, bool cMemoryOwn);
        /*0x2128518*/ tProgramChange();
        /*0x21281e4*/ void setCPtr(nint cPtr);
        /*0x2128274*/ void Finalize();
        /*0x2128208*/ void Dispose();
        /*0x2128304*/ void Dispose(bool disposing);
        /*0x2128450*/ void set_byProgramNum(byte value);
        /*0x21284bc*/ byte get_byProgramNum();
    }

    class tWwiseCmd : System.IDisposable
    {
        /*0x10*/ nint swigCPtr;
        /*0x18*/ bool swigCMemOwn;

        static /*0x2125c90*/ nint getCPtr(AkMIDIEvent.tWwiseCmd obj);
        /*0x2125d40*/ tWwiseCmd(nint cPtr, bool cMemoryOwn);
        /*0x2128988*/ tWwiseCmd();
        /*0x212858c*/ void setCPtr(nint cPtr);
        /*0x212861c*/ void Finalize();
        /*0x21285b0*/ void Dispose();
        /*0x21286ac*/ void Dispose(bool disposing);
        /*0x21287f8*/ void set_uCmd(ushort value);
        /*0x2128864*/ ushort get_uCmd();
        /*0x21288c0*/ void set_uArg(uint value);
        /*0x212892c*/ uint get_uArg();
    }
}

class AkMIDIEventCallbackInfo : AkEventCallbackInfo
{
    /*0x28*/ nint swigCPtr;

    static /*0x2128a80*/ nint getCPtr(AkMIDIEventCallbackInfo obj);
    /*0x21289fc*/ AkMIDIEventCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x2129174*/ AkMIDIEventCallbackInfo();
    /*0x2128a8c*/ void setCPtr(nint cPtr);
    /*0x2128b08*/ void Dispose(bool disposing);
    /*0x2128c6c*/ byte get_byChan();
    /*0x2128cc8*/ byte get_byParam1();
    /*0x2128d24*/ byte get_byParam2();
    /*0x2128d80*/ AkMIDIEventTypes get_byType();
    /*0x2128ddc*/ byte get_byOnOffNote();
    /*0x2128e38*/ byte get_byVelocity();
    /*0x2128e94*/ AkMIDICcTypes get_byCc();
    /*0x2128ef0*/ byte get_byCcValue();
    /*0x2128f4c*/ byte get_byValueLsb();
    /*0x2128fa8*/ byte get_byValueMsb();
    /*0x2129004*/ byte get_byAftertouchNote();
    /*0x2129060*/ byte get_byNoteAftertouchValue();
    /*0x21290bc*/ byte get_byChanAftertouchValue();
    /*0x2129118*/ byte get_byProgramNum();
}

enum AkMIDIEventTypes
{
    NOTE_OFF = 128,
    NOTE_ON = 144,
    NOTE_AFTERTOUCH = 160,
    CONTROLLER = 176,
    PROGRAM_CHANGE = 192,
    CHANNEL_AFTERTOUCH = 208,
    PITCH_BEND = 224,
    SYSEX = 240,
    ESCAPE = 247,
    META = 255,
}

class AkMIDIPost : AkMIDIEvent
{
    /*0x20*/ nint swigCPtr;

    static /*0x2129264*/ nint getCPtr(AkMIDIPost obj);
    static /*0x2129f70*/ int GetSizeOf();
    /*0x21291d8*/ AkMIDIPost(nint cPtr, bool cMemoryOwn);
    /*0x2129fc0*/ AkMIDIPost();
    /*0x2129270*/ void setCPtr(nint cPtr);
    /*0x21292ec*/ void Dispose(bool disposing);
    /*0x2129448*/ void set_uOffset(ulong value);
    /*0x21294b4*/ ulong get_uOffset();
    /*0x2129510*/ uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts);
    /*0x2129678*/ uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets);
    /*0x2129740*/ uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    /*0x21299c0*/ uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID);
    /*0x2129b14*/ uint PostOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uNumPosts);
    /*0x2129bec*/ uint PostOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets);
    /*0x2129ccc*/ uint PostOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie);
    /*0x2129ddc*/ uint PostOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID);
    /*0x2129f04*/ void Clone(AkMIDIPost other);
}

enum AkMonitorErrorCode
{
    ErrorCode_NoError = 0,
    ErrorCode_FileNotFound = 1,
    ErrorCode_CannotOpenFile = 2,
    ErrorCode_CannotStartStreamNoMemory = 3,
    ErrorCode_IODevice = 4,
    ErrorCode_IncompatibleIOSettings = 5,
    ErrorCode_PluginUnsupportedChannelConfiguration = 6,
    ErrorCode_PluginMediaUnavailable = 7,
    ErrorCode_PluginInitialisationFailed = 8,
    ErrorCode_PluginProcessingFailed = 9,
    ErrorCode_PluginExecutionInvalid = 10,
    ErrorCode_PluginAllocationFailed = 11,
    ErrorCode_VorbisSeekTableRecommended = 12,
    ErrorCode_VorbisDecodeError = 13,
    ErrorCode_ATRAC9DecodeFailed = 14,
    ErrorCode_ATRAC9LoopSectionTooSmall = 15,
    ErrorCode_InvalidAudioFileHeader = 16,
    ErrorCode_AudioFileHeaderTooLarge = 17,
    ErrorCode_LoopTooSmall = 18,
    ErrorCode_TransitionNotAccurateChannel = 19,
    ErrorCode_TransitionNotAccuratePluginMismatch = 20,
    ErrorCode_TransitionNotAccurateRejectedByPlugin = 21,
    ErrorCode_TransitionNotAccurateStarvation = 22,
    ErrorCode_TransitionNotAccurateCodecError = 23,
    ErrorCode_NothingToPlay = 24,
    ErrorCode_PlayFailed = 25,
    ErrorCode_StingerCouldNotBeScheduled = 26,
    ErrorCode_TooLongSegmentLookAhead = 27,
    ErrorCode_CannotScheduleMusicSwitch = 28,
    ErrorCode_TooManySimultaneousMusicSegments = 29,
    ErrorCode_PlaylistStoppedForEditing = 30,
    ErrorCode_MusicClipsRescheduledAfterTrackEdit = 31,
    ErrorCode_CannotPlaySource_Create = 32,
    ErrorCode_CannotPlaySource_VirtualOff = 33,
    ErrorCode_CannotPlaySource_TimeSkip = 34,
    ErrorCode_CannotPlaySource_InconsistentState = 35,
    ErrorCode_MediaNotLoaded = 36,
    ErrorCode_VoiceStarving = 37,
    ErrorCode_StreamingSourceStarving = 38,
    ErrorCode_XMADecoderSourceStarving = 39,
    ErrorCode_XMADecodingError = 40,
    ErrorCode_InvalidXMAData = 41,
    ErrorCode_PluginNotRegistered = 42,
    ErrorCode_CodecNotRegistered = 43,
    ErrorCode_PluginVersionMismatch = 44,
    ErrorCode_EventIDNotFound = 45,
    ErrorCode_InvalidGroupID = 46,
    ErrorCode_SelectedNodeNotAvailable = 47,
    ErrorCode_SelectedMediaNotAvailable = 48,
    ErrorCode_NoValidSwitch = 49,
    ErrorCode_BankLoadFailed = 50,
    ErrorCode_ErrorWhileLoadingBank = 51,
    ErrorCode_InsufficientSpaceToLoadBank = 52,
    ErrorCode_LowerEngineCommandListFull = 53,
    ErrorCode_SeekNoMarker = 54,
    ErrorCode_CannotSeekContinuous = 55,
    ErrorCode_SeekAfterEof = 56,
    ErrorCode_UnknownGameObject = 57,
    ErrorCode_GameObjectNeverRegistered = 58,
    ErrorCode_DeadGameObject = 59,
    ErrorCode_GameObjectIsNotEmitter = 60,
    ErrorCode_ExternalSourceNotResolved = 61,
    ErrorCode_FileFormatMismatch = 62,
    ErrorCode_CommandQueueFull = 63,
    ErrorCode_CommandTooLarge = 64,
    ErrorCode_XMACreateDecoderLimitReached = 65,
    ErrorCode_XMAStreamBufferTooSmall = 66,
    ErrorCode_ModulatorScopeError_Inst = 67,
    ErrorCode_ModulatorScopeError_Obj = 68,
    ErrorCode_SeekAfterEndOfPlaylist = 69,
    ErrorCode_OpusRequireSeekTable = 70,
    ErrorCode_OpusDecodeError = 71,
    ErrorCode_SourcePluginNotFound = 72,
    ErrorCode_VirtualVoiceLimit = 73,
    ErrorCode_NotEnoughMemoryToStart = 74,
    ErrorCode_UnknownOpusError = 75,
    ErrorCode_AudioDeviceInitFailure = 76,
    ErrorCode_AudioDeviceRemoveFailure = 77,
    ErrorCode_AudioDeviceNotFound = 78,
    ErrorCode_AudioDeviceNotValid = 79,
    ErrorCode_SpatialAudio_ListenerAutomationNotSupported = 80,
    ErrorCode_MediaDuplicationLength = 81,
    ErrorCode_HwVoicesSystemInitFailed = 82,
    ErrorCode_HwVoicesDecodeBatchFailed = 83,
    ErrorCode_HwVoiceLimitReached = 84,
    ErrorCode_HwVoiceInitFailed = 85,
    ErrorCode_OpusHWCommandFailed = 86,
    ErrorCode_AddOutputListenerIdWithZeroListeners = 87,
    ErrorCode_3DObjectLimitExceeded = 88,
    ErrorCode_OpusHWFatalError = 89,
    ErrorCode_OpusHWDecodeUnavailable = 90,
    ErrorCode_OpusHWTimeout = 91,
    ErrorCode_SystemAudioObjectsUnavailable = 92,
    ErrorCode_AddOutputNoDistinctListener = 93,
    ErrorCode_PluginCannotRunOnObjectConfig = 94,
    ErrorCode_SpatialAudio_ReflectionBusError = 95,
    ErrorCode_VorbisHWDecodeUnavailable = 96,
    ErrorCode_ExternalSourceNoMemorySize = 97,
    ErrorCode_MonitorQueueFull = 98,
    ErrorCode_MonitorMsgTooLarge = 99,
    ErrorCode_NonCompliantDeviceMemory = 100,
    ErrorCode_JobWorkerFuncCallMismatch = 101,
    ErrorCode_JobMgrOutOfMemory = 102,
    ErrorCode_InvalidFileSize = 103,
    ErrorCode_PluginMsg = 104,
    ErrorCode_SinkOpenSL = 105,
    ErrorCode_AudioOutOfRange = 106,
    ErrorCode_AudioOutOfRangeOnBus = 107,
    ErrorCode_AudioOutOfRangeOnBusFx = 108,
    ErrorCode_AudioOutOfRangeRay = 109,
    ErrorCode_UnknownDialogueEvent = 110,
    ErrorCode_FailedPostingEvent = 111,
    ErrorCode_OutputDeviceInitializationFailed = 112,
    ErrorCode_UnloadBankFailed = 113,
    ErrorCode_PluginFileNotFound = 114,
    ErrorCode_PluginFileIncompatible = 115,
    ErrorCode_PluginFileNotEnoughMemoryToStart = 116,
    ErrorCode_PluginFileInvalid = 117,
    ErrorCode_PluginFileRegisterFailed = 118,
    ErrorCode_UnknownArgument = 119,
    ErrorCode_DynamicSequenceAlreadyClosed = 120,
    ErrorCode_PendingActionDestroyed = 121,
    ErrorCode_CrossFadeTransitionIgnored = 122,
    ErrorCode_MusicRendererSeekingFailed = 123,
    ErrorCode_DynamicSequenceIdNotFound = 124,
    ErrorCode_BusNotFoundByName = 125,
    ErrorCode_AudioDeviceShareSetNotFound = 126,
    ErrorCode_AudioDeviceShareSetNotFoundByName = 127,
    ErrorCode_SoundEngineTooManyGameObjects = 128,
    ErrorCode_SoundEngineTooManyPositions = 129,
    ErrorCode_SoundEngineCantCallOnChildBus = 130,
    ErrorCode_SoundEnginePlayingIdNotFound = 131,
    ErrorCode_SoundEngineInvalidTransform = 132,
    ErrorCode_SoundEngineTooManyEventPosts = 133,
    ErrorCode_AudioSubsystemStoppedResponding = 134,
    ErrorCode_NotEnoughMemInFunction = 135,
    ErrorCode_FXNotFound = 136,
    ErrorCode_SetMixerNotABus = 137,
    ErrorCode_AudioNodeNotFound = 138,
    ErrorCode_SetMixerFailed = 139,
    ErrorCode_SetBusConfigUnsupported = 140,
    ErrorCode_BusNotFound = 141,
    ErrorCode_MismatchingMediaSize = 142,
    ErrorCode_IncompatibleBankVersion = 143,
    ErrorCode_UnexpectedPrepareGameSyncsCall = 144,
    ErrorCode_MusicEngineNotInitialized = 145,
    ErrorCode_LoadingBankMismatch = 146,
    ErrorCode_MasterBusStructureNotLoaded = 147,
    ErrorCode_TooManyChildren = 148,
    ErrorCode_BankContainUneditableEffect = 149,
    ErrorCode_MemoryAllocationFailed = 150,
    ErrorCode_InvalidFloatPriority = 151,
    ErrorCode_SoundLoadFailedInsufficientMemory = 152,
    ErrorCode_NXDeviceRegistrationFailed = 153,
    ErrorCode_MixPluginOnObjectBus = 154,
    ErrorCode_XboxXMAVoiceResetFailed = 155,
    ErrorCode_XboxACPMessage = 156,
    ErrorCode_XboxFrameDropped = 157,
    ErrorCode_XboxACPError = 158,
    ErrorCode_XboxXMAFatalError = 159,
    ErrorCode_MissingMusicNodeParent = 160,
    ErrorCode_HardwareOpusDecoderError = 161,
    ErrorCode_SetGeometryTooManyTriangleConnected = 162,
    ErrorCode_SetGeometryTriangleTooLarge = 163,
    ErrorCode_SetGeometryFailed = 164,
    ErrorCode_RemovingGeometrySetFailed = 165,
    ErrorCode_SetGeometryInstanceFailed = 166,
    ErrorCode_RemovingGeometryInstanceFailed = 167,
    ErrorCode_RevertingToDefaultAudioDevice = 168,
    ErrorCode_RevertingToDummyAudioDevice = 169,
    ErrorCode_AudioThreadSuspended = 170,
    ErrorCode_AudioThreadResumed = 171,
    ErrorCode_ResetPlaylistActionIgnoredGlobalScope = 172,
    ErrorCode_ResetPlaylistActionIgnoredContinuous = 173,
    ErrorCode_PlayingTriggerRateNotSupported = 174,
    ErrorCode_SetGeometryTriangleIsSkipped = 175,
    ErrorCode_SetGeometryInstanceInvalidTransform = 176,
    ErrorCode_SetGameObjectRadiusSizeError = 177,
    ErrorCode_SetPortalNonDistinctRoom = 178,
    ErrorCode_SetPortalInvalidExtent = 179,
    ErrorCode_SpatialAudio_PortalNotFound = 180,
    ErrorCode_InvalidFloatInFunction = 181,
    ErrorCode_FLTMAXNotSupported = 182,
    ErrorCode_CannotInitializeAmbisonicChannelConfiguration = 183,
    ErrorCode_CannotInitializePassthrough = 184,
    ErrorCode_3DAudioUnsupportedSize = 185,
    ErrorCode_AmbisonicNotAvailable = 186,
    ErrorCode_NoAudioDevice = 187,
    ErrorCode_Support = 188,
    ErrorCode_ReplayMessage = 189,
    ErrorCode_GameMessage = 190,
    ErrorCode_TestMessage = 191,
    ErrorCode_TranslatorStandardTagTest = 192,
    ErrorCode_TranslatorWwiseTagTest = 193,
    ErrorCode_TranslatorStringSizeTest = 194,
    ErrorCode_InvalidParameter = 195,
    ErrorCode_MaxAudioObjExceeded = 196,
    ErrorCode_MMSNotEnabled = 197,
    ErrorCode_NotEnoughSystemObj = 198,
    ErrorCode_NotEnoughSystemObjWin = 199,
    ErrorCode_TransitionNotAccurateSourceTooShort = 200,
    ErrorCode_AlreadyInitialized = 201,
    ErrorCode_WrongNumberOfArguments = 202,
    ErrorCode_DataAlignement = 203,
    ErrorCode_PluginMsgWithShareSet = 204,
    ErrorCode_SoundEngineNotInit = 205,
    ErrorCode_NoDefaultSwitch = 206,
    ErrorCode_CantSetBoundSwitch = 207,
    ErrorCode_IODeviceInitFailed = 208,
    ErrorCode_SwitchListEmpty = 209,
    ErrorCode_NoSwitchSelected = 210,
    ErrorCode_FilePermissionError = 211,
    ErrorCode_SetEffectOnRendered = 212,
    ErrorCode_GeometryNotWatertight = 213,
    ErrorCode_CannotInitialize3DAudio = 214,
    ErrorCode_CannotInitializeInputCallbacks = 215,
    ErrorCode_CannotConnectAVAudioEngineSource = 216,
    ErrorCode_ChannelConfigRequestDenied = 217,
    ErrorCode_MediaUpdatedFromWwise = 218,
    ErrorCode_MediaErrorFromWwise = 219,
    ErrorCode_OutputAlreadyExists = 220,
    ErrorCode_UnknownStateGroup = 221,
    ErrorCode_MediaErrorWwiseMRUFull = 222,
    ErrorCode_AudioOut2ContextCreateError = 223,
    ErrorCode_AudioOut2UserCreateError = 224,
    ErrorCode_FeedbackOnAudioObjectsBus = 225,
    ErrorCode_AssetSwapEnabled = 226,
    ErrorCode_SpatialAudio_SiblingPortal = 227,
    Num_ErrorCodes = 228,
}

enum AkMonitorErrorLevel
{
    ErrorLevel_Message = 1,
    ErrorLevel_Error = 2,
    ErrorLevel_All = 3,
}

class AkMonitoringCallbackInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212a054*/ nint getCPtr(AkMonitoringCallbackInfo obj);
    /*0x212a024*/ AkMonitoringCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x212a4d0*/ AkMonitoringCallbackInfo();
    /*0x212a060*/ void setCPtr(nint cPtr);
    /*0x212a0f0*/ void Finalize();
    /*0x212a084*/ void Dispose();
    /*0x212a180*/ void Dispose(bool disposing);
    /*0x212a2cc*/ AkMonitorErrorCode get_errorCode();
    /*0x212a328*/ AkMonitorErrorLevel get_errorLevel();
    /*0x212a384*/ uint get_playingID();
    /*0x212a3e0*/ ulong get_gameObjID();
    /*0x212a43c*/ string get_message();
}

enum AkMultiPositionType
{
    MultiPositionType_SingleSource = 0,
    MultiPositionType_MultiSources = 1,
    MultiPositionType_MultiDirections = 2,
}

class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
{
    /*0x28*/ nint swigCPtr;

    static /*0x212a5c8*/ nint getCPtr(AkMusicPlaylistCallbackInfo obj);
    /*0x212a544*/ AkMusicPlaylistCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x212a924*/ AkMusicPlaylistCallbackInfo();
    /*0x212a5d4*/ void setCPtr(nint cPtr);
    /*0x212a650*/ void Dispose(bool disposing);
    /*0x212a7b4*/ uint get_playlistID();
    /*0x212a810*/ uint get_uNumPlaylistItems();
    /*0x212a86c*/ uint get_uPlaylistSelection();
    /*0x212a8c8*/ uint get_uPlaylistItemDone();
}

class AkMusicSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212a9b8*/ nint getCPtr(AkMusicSettings obj);
    /*0x212a988*/ AkMusicSettings(nint cPtr, bool cMemoryOwn);
    /*0x212a9c4*/ void setCPtr(nint cPtr);
    /*0x212aa54*/ void Finalize();
    /*0x212a9e8*/ void Dispose();
    /*0x212aae4*/ void Dispose(bool disposing);
    /*0x212ac30*/ void set_fStreamingLookAheadRatio(float value);
    /*0x212ac9c*/ float get_fStreamingLookAheadRatio();
}

class AkMusicSyncCallbackInfo : AkCallbackInfo
{
    /*0x20*/ nint swigCPtr;

    static /*0x212ad7c*/ nint getCPtr(AkMusicSyncCallbackInfo obj);
    /*0x212acf8*/ AkMusicSyncCallbackInfo(nint cPtr, bool cMemoryOwn);
    /*0x212b3f0*/ AkMusicSyncCallbackInfo();
    /*0x212ad88*/ void setCPtr(nint cPtr);
    /*0x212ae04*/ void Dispose(bool disposing);
    /*0x212af68*/ uint get_playingID();
    /*0x212afc4*/ int get_segmentInfo_iCurrentPosition();
    /*0x212b020*/ int get_segmentInfo_iPreEntryDuration();
    /*0x212b07c*/ int get_segmentInfo_iActiveDuration();
    /*0x212b0d8*/ int get_segmentInfo_iPostExitDuration();
    /*0x212b134*/ int get_segmentInfo_iRemainingLookAheadTime();
    /*0x212b190*/ float get_segmentInfo_fBeatDuration();
    /*0x212b1ec*/ float get_segmentInfo_fBarDuration();
    /*0x212b248*/ float get_segmentInfo_fGridDuration();
    /*0x212b2a4*/ float get_segmentInfo_fGridOffset();
    /*0x212b300*/ AkCallbackType get_musicSyncType();
    /*0x212b35c*/ string get_userCueName();
}

class AkObjectInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212b484*/ nint getCPtr(AkObjectInfo obj);
    static /*0x212b9b0*/ int GetSizeOf();
    /*0x212b454*/ AkObjectInfo(nint cPtr, bool cMemoryOwn);
    /*0x212ba6c*/ AkObjectInfo();
    /*0x212b490*/ void setCPtr(nint cPtr);
    /*0x212b520*/ void Finalize();
    /*0x212b4b4*/ void Dispose();
    /*0x212b5b0*/ void Dispose(bool disposing);
    /*0x212b6fc*/ void set_objID(uint value);
    /*0x212b768*/ uint get_objID();
    /*0x212b7c4*/ void set_parentID(uint value);
    /*0x212b830*/ uint get_parentID();
    /*0x212b88c*/ void set_iDepth(int value);
    /*0x212b8f8*/ int get_iDepth();
    /*0x212b954*/ void Clear();
    /*0x212ba00*/ void Clone(AkObjectInfo other);
}

class AkObstructionOcclusionValues : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212bb10*/ nint getCPtr(AkObstructionOcclusionValues obj);
    static /*0x212bf74*/ int GetSizeOf();
    /*0x212bae0*/ AkObstructionOcclusionValues(nint cPtr, bool cMemoryOwn);
    /*0x212c030*/ AkObstructionOcclusionValues();
    /*0x212bb1c*/ void setCPtr(nint cPtr);
    /*0x212bbac*/ void Finalize();
    /*0x212bb40*/ void Dispose();
    /*0x212bc3c*/ void Dispose(bool disposing);
    /*0x212bd88*/ void set_occlusion(float value);
    /*0x212bdf4*/ float get_occlusion();
    /*0x212be50*/ void set_obstruction(float value);
    /*0x212bebc*/ float get_obstruction();
    /*0x212bf18*/ void Clear();
    /*0x212bfc4*/ void Clone(AkObstructionOcclusionValues other);
}

class AkOutputSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212c0d4*/ nint getCPtr(AkOutputSettings obj);
    /*0x212c0a4*/ AkOutputSettings(nint cPtr, bool cMemoryOwn);
    /*0x212c34c*/ AkOutputSettings();
    /*0x212c3c0*/ AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning);
    /*0x212c478*/ AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig);
    /*0x212c528*/ AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice);
    /*0x212c5b4*/ AkOutputSettings(string in_szDeviceShareSet);
    /*0x212c0e0*/ void setCPtr(nint cPtr);
    /*0x212c170*/ void Finalize();
    /*0x212c104*/ void Dispose();
    /*0x212c200*/ void Dispose(bool disposing);
    /*0x212c638*/ void set_audioDeviceShareset(uint value);
    /*0x212c6a4*/ uint get_audioDeviceShareset();
    /*0x212c700*/ void set_idDevice(uint value);
    /*0x212c76c*/ uint get_idDevice();
    /*0x212c7c8*/ void set_ePanningRule(AkPanningRule value);
    /*0x212c834*/ AkPanningRule get_ePanningRule();
    /*0x212c894*/ void set_channelConfig(AkChannelConfig value);
    /*0x212c914*/ AkChannelConfig get_channelConfig();
}

enum AkPanningRule
{
    AkPanningRule_Speakers = 0,
    AkPanningRule_Headphones = 1,
}

class AkPlaylist : AkPlaylistArray
{
    /*0x20*/ nint swigCPtr;

    static /*0x212ca74*/ nint getCPtr(AkPlaylist obj);
    /*0x212c9b8*/ AkPlaylist(nint cPtr, bool cMemoryOwn);
    /*0x212d064*/ AkPlaylist();
    /*0x212ca80*/ void setCPtr(nint cPtr);
    /*0x212cb20*/ void Dispose(bool disposing);
    /*0x212cdc8*/ AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, nint in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources);
    /*0x212ce74*/ AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, nint in_pCustomInfo, uint in_cExternals);
    /*0x212cf00*/ AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, nint in_pCustomInfo);
    /*0x212cf84*/ AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay);
    /*0x212cff8*/ AKRESULT Enqueue(uint in_audioNodeID);
}

class AkPlaylistArray : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212d0c8*/ nint getCPtr(AkPlaylistArray obj);
    /*0x212ca44*/ AkPlaylistArray(nint cPtr, bool cMemoryOwn);
    /*0x212d1d0*/ AkPlaylistArray();
    /*0x212cafc*/ void setCPtr(nint cPtr);
    /*0x212d140*/ void Finalize();
    /*0x212d0d4*/ void Dispose();
    /*0x212cc7c*/ void Dispose(bool disposing);
    /*0x212d244*/ AkIterator Begin();
    /*0x212d2e4*/ AkIterator End();
    /*0x212d384*/ AkIterator FindEx(AkPlaylistItem in_Item);
    /*0x212d434*/ AkIterator Erase(AkIterator in_rIter);
    /*0x212d4e4*/ void Erase(uint in_uIndex);
    /*0x212d550*/ AkIterator EraseSwap(AkIterator in_rIter);
    /*0x212d600*/ void EraseSwap(uint in_uIndex);
    /*0x212d66c*/ bool IsGrowingAllowed();
    /*0x212d6c8*/ AKRESULT Reserve(uint in_ulReserve);
    /*0x212d734*/ AKRESULT ReserveExtra(uint in_ulReserve);
    /*0x212d7a0*/ uint Reserved();
    /*0x212d7fc*/ void Term();
    /*0x212d858*/ uint Length();
    /*0x212d8b4*/ AkPlaylistItem Data();
    /*0x212d958*/ bool IsEmpty();
    /*0x212d9b4*/ AkPlaylistItem Exists(AkPlaylistItem in_Item);
    /*0x212da68*/ AkPlaylistItem AddLast();
    /*0x212db0c*/ AkPlaylistItem AddLast(AkPlaylistItem in_rItem);
    /*0x212dbc0*/ AkPlaylistItem Last();
    /*0x212dc5c*/ void RemoveLast();
    /*0x212dcb8*/ AKRESULT Remove(AkPlaylistItem in_rItem);
    /*0x212dd24*/ AKRESULT RemoveSwap(AkPlaylistItem in_rItem);
    /*0x212dd90*/ void RemoveAll();
    /*0x212ddec*/ AkPlaylistItem ItemAtIndex(uint uiIndex);
    /*0x212de98*/ AkIterator Insert(AkIterator in_rIter);
    /*0x212df48*/ AkPlaylistItem Insert(uint in_uIndex);
    /*0x212dffc*/ bool GrowArray();
    /*0x212e058*/ bool GrowArray(uint in_uGrowBy);
    /*0x212e0c4*/ bool Resize(uint in_uiSize);
    /*0x212e130*/ void Transfer(AkPlaylistArray in_rSource);
    /*0x212e19c*/ AKRESULT Copy(AkPlaylistArray in_rSource);
}

class AkPlaylistItem : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2124780*/ nint getCPtr(AkPlaylistItem obj);
    /*0x2124830*/ AkPlaylistItem(nint cPtr, bool cMemoryOwn);
    /*0x212e474*/ AkPlaylistItem();
    /*0x212e4e8*/ AkPlaylistItem(AkPlaylistItem in_rCopy);
    /*0x212e208*/ void setCPtr(nint cPtr);
    /*0x212e298*/ void Finalize();
    /*0x212e22c*/ void Dispose();
    /*0x212e328*/ void Dispose(bool disposing);
    /*0x212e56c*/ AkPlaylistItem Assign(AkPlaylistItem in_rCopy);
    /*0x212e618*/ bool IsEqualTo(AkPlaylistItem in_rCopy);
    /*0x212e684*/ AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc);
    /*0x212e710*/ void set_audioNodeID(uint value);
    /*0x212e77c*/ uint get_audioNodeID();
    /*0x212e7d8*/ void set_msDelay(int value);
    /*0x212e844*/ int get_msDelay();
    /*0x212e8a0*/ void set_pCustomInfo(nint value);
    /*0x212e90c*/ nint get_pCustomInfo();
}

enum AkPluginType
{
    AkPluginTypeNone = 0,
    AkPluginTypeCodec = 1,
    AkPluginTypeSource = 2,
    AkPluginTypeEffect = 3,
    AkPluginTypeMixer = 6,
    AkPluginTypeSink = 7,
    AkPluginTypeGlobalExtension = 8,
    AkPluginTypeMetadata = 9,
    AkPluginTypeMask = 15,
}

class AkPositioningData : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212e998*/ nint getCPtr(AkPositioningData obj);
    /*0x212e968*/ AkPositioningData(nint cPtr, bool cMemoryOwn);
    /*0x212ee58*/ AkPositioningData();
    /*0x212e9a4*/ void setCPtr(nint cPtr);
    /*0x212ea34*/ void Finalize();
    /*0x212e9c8*/ void Dispose();
    /*0x212eac4*/ void Dispose(bool disposing);
    /*0x212ec10*/ void set_threeD(Ak3dData value);
    /*0x212ec90*/ Ak3dData get_threeD();
    /*0x212ed34*/ void set_behavioral(AkBehavioralPositioningData value);
    /*0x212edb4*/ AkBehavioralPositioningData get_behavioral();
}

class AkPositioningInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x212eefc*/ nint getCPtr(AkPositioningInfo obj);
    /*0x212eecc*/ AkPositioningInfo(nint cPtr, bool cMemoryOwn);
    /*0x212ff90*/ AkPositioningInfo();
    /*0x212ef08*/ void setCPtr(nint cPtr);
    /*0x212ef98*/ void Finalize();
    /*0x212ef2c*/ void Dispose();
    /*0x212f028*/ void Dispose(bool disposing);
    /*0x212f174*/ void set_fCenterPct(float value);
    /*0x212f1e0*/ float get_fCenterPct();
    /*0x212f23c*/ void set_pannerType(AkSpeakerPanningType value);
    /*0x212f2a8*/ AkSpeakerPanningType get_pannerType();
    /*0x212f308*/ void set_e3dPositioningType(Ak3DPositionType value);
    /*0x212f374*/ Ak3DPositionType get_e3dPositioningType();
    /*0x212f3d4*/ void set_bHoldEmitterPosAndOrient(bool value);
    /*0x212f440*/ bool get_bHoldEmitterPosAndOrient();
    /*0x212f49c*/ void set_e3DSpatializationMode(Ak3DSpatializationMode value);
    /*0x212f508*/ Ak3DSpatializationMode get_e3DSpatializationMode();
    /*0x212f568*/ void set_bEnableAttenuation(bool value);
    /*0x212f5d4*/ bool get_bEnableAttenuation();
    /*0x212f630*/ void set_bUseConeAttenuation(bool value);
    /*0x212f69c*/ bool get_bUseConeAttenuation();
    /*0x212f6f8*/ void set_fInnerAngle(float value);
    /*0x212f764*/ float get_fInnerAngle();
    /*0x212f7c0*/ void set_fOuterAngle(float value);
    /*0x212f82c*/ float get_fOuterAngle();
    /*0x212f888*/ void set_fConeMaxAttenuation(float value);
    /*0x212f8f4*/ float get_fConeMaxAttenuation();
    /*0x212f950*/ void set_LPFCone(float value);
    /*0x212f9bc*/ float get_LPFCone();
    /*0x212fa18*/ void set_HPFCone(float value);
    /*0x212fa84*/ float get_HPFCone();
    /*0x212fae0*/ void set_fMaxDistance(float value);
    /*0x212fb4c*/ float get_fMaxDistance();
    /*0x212fba8*/ void set_fVolDryAtMaxDist(float value);
    /*0x212fc14*/ float get_fVolDryAtMaxDist();
    /*0x212fc70*/ void set_fVolAuxGameDefAtMaxDist(float value);
    /*0x212fcdc*/ float get_fVolAuxGameDefAtMaxDist();
    /*0x212fd38*/ void set_fVolAuxUserDefAtMaxDist(float value);
    /*0x212fda4*/ float get_fVolAuxUserDefAtMaxDist();
    /*0x212fe00*/ void set_LPFValueAtMaxDist(float value);
    /*0x212fe6c*/ float get_LPFValueAtMaxDist();
    /*0x212fec8*/ void set_HPFValueAtMaxDist(float value);
    /*0x212ff34*/ float get_HPFValueAtMaxDist();
}

enum AkPreparationType
{
    Preparation_Load = 0,
    Preparation_Unload = 1,
    Preparation_LoadAndDecode = 2,
}

enum AkQueryRTPCValue
{
    RTPCValue_Default = 0,
    RTPCValue_Global = 1,
    RTPCValue_GameObject = 2,
    RTPCValue_PlayingID = 3,
    RTPCValue_Unavailable = 4,
}

class AkRamp : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2130034*/ nint getCPtr(AkRamp obj);
    /*0x2130004*/ AkRamp(nint cPtr, bool cMemoryOwn);
    /*0x21302ac*/ AkRamp();
    /*0x2130320*/ AkRamp(float in_fPrev, float in_fNext);
    /*0x2130040*/ void setCPtr(nint cPtr);
    /*0x21300d0*/ void Finalize();
    /*0x2130064*/ void Dispose();
    /*0x2130160*/ void Dispose(bool disposing);
    /*0x21303ac*/ void set_fPrev(float value);
    /*0x2130418*/ float get_fPrev();
    /*0x2130474*/ void set_fNext(float value);
    /*0x21304e0*/ float get_fNext();
}

class AkReflectionPathInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x213056c*/ nint getCPtr(AkReflectionPathInfo obj);
    static /*0x2130bcc*/ int GetSizeOf();
    /*0x213053c*/ AkReflectionPathInfo(nint cPtr, bool cMemoryOwn);
    /*0x2130e0c*/ AkReflectionPathInfo();
    /*0x2130578*/ void setCPtr(nint cPtr);
    /*0x2130608*/ void Finalize();
    /*0x213059c*/ void Dispose();
    /*0x2130698*/ void Dispose(bool disposing);
    /*0x21307e4*/ void set_imageSource(AkVector64 value);
    /*0x2130850*/ AkVector64 get_imageSource();
    /*0x21308ac*/ void set_numPathPoints(uint value);
    /*0x2130918*/ uint get_numPathPoints();
    /*0x2130974*/ void set_numReflections(uint value);
    /*0x21309e0*/ uint get_numReflections();
    /*0x2130a3c*/ void set_level(float value);
    /*0x2130aa8*/ float get_level();
    /*0x2130b04*/ void set_isOccluded(bool value);
    /*0x2130b70*/ bool get_isOccluded();
    /*0x2130c1c*/ UnityEngine.Vector3 GetPathPoint(uint idx);
    /*0x2130c88*/ AkAcousticSurface GetAcousticSurface(uint idx);
    /*0x2130d34*/ float GetDiffraction(uint idx);
    /*0x2130da0*/ void Clone(AkReflectionPathInfo other);
}

class AkResourceMonitorDataSummary : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2130eb0*/ nint getCPtr(AkResourceMonitorDataSummary obj);
    /*0x2130e80*/ AkResourceMonitorDataSummary(nint cPtr, bool cMemoryOwn);
    /*0x21315d8*/ AkResourceMonitorDataSummary();
    /*0x2130ebc*/ void setCPtr(nint cPtr);
    /*0x2130f4c*/ void Finalize();
    /*0x2130ee0*/ void Dispose();
    /*0x2130fdc*/ void Dispose(bool disposing);
    /*0x2131128*/ void set_totalCPU(float value);
    /*0x2131194*/ float get_totalCPU();
    /*0x21311f0*/ void set_pluginCPU(float value);
    /*0x213125c*/ float get_pluginCPU();
    /*0x21312b8*/ void set_physicalVoices(uint value);
    /*0x2131324*/ uint get_physicalVoices();
    /*0x2131380*/ void set_virtualVoices(uint value);
    /*0x21313ec*/ uint get_virtualVoices();
    /*0x2131448*/ void set_totalVoices(uint value);
    /*0x21314b4*/ uint get_totalVoices();
    /*0x2131510*/ void set_nbActiveEvents(uint value);
    /*0x213157c*/ uint get_nbActiveEvents();
}

enum AKRESULT
{
    AK_NotImplemented = 0,
    AK_Success = 1,
    AK_Fail = 2,
    AK_PartialSuccess = 3,
    AK_NotCompatible = 4,
    AK_AlreadyConnected = 5,
    AK_InvalidFile = 7,
    AK_AudioFileHeaderTooLarge = 8,
    AK_MaxReached = 9,
    AK_InvalidID = 14,
    AK_IDNotFound = 15,
    AK_InvalidInstanceID = 16,
    AK_NoMoreData = 17,
    AK_InvalidStateGroup = 20,
    AK_ChildAlreadyHasAParent = 21,
    AK_InvalidLanguage = 22,
    AK_CannotAddItselfAsAChild = 23,
    AK_InvalidParameter = 31,
    AK_ElementAlreadyInList = 35,
    AK_PathNotFound = 36,
    AK_PathNoVertices = 37,
    AK_PathNotRunning = 38,
    AK_PathNotPaused = 39,
    AK_PathNodeAlreadyInList = 40,
    AK_PathNodeNotInList = 41,
    AK_DataNeeded = 43,
    AK_NoDataNeeded = 44,
    AK_DataReady = 45,
    AK_NoDataReady = 46,
    AK_InsufficientMemory = 52,
    AK_Cancelled = 53,
    AK_UnknownBankID = 54,
    AK_BankReadError = 56,
    AK_InvalidSwitchType = 57,
    AK_FormatNotReady = 63,
    AK_WrongBankVersion = 64,
    AK_FileNotFound = 66,
    AK_DeviceNotReady = 67,
    AK_BankAlreadyLoaded = 69,
    AK_RenderedFX = 71,
    AK_ProcessNeeded = 72,
    AK_ProcessDone = 73,
    AK_MemManagerNotInitialized = 74,
    AK_StreamMgrNotInitialized = 75,
    AK_SSEInstructionsNotSupported = 76,
    AK_Busy = 77,
    AK_UnsupportedChannelConfig = 78,
    AK_PluginMediaNotAvailable = 79,
    AK_MustBeVirtualized = 80,
    AK_CommandTooLarge = 81,
    AK_RejectedByFilter = 82,
    AK_InvalidCustomPlatformName = 83,
    AK_DLLCannotLoad = 84,
    AK_DLLPathNotFound = 85,
    AK_NoJavaVM = 86,
    AK_OpenSLError = 87,
    AK_PluginNotRegistered = 88,
    AK_DataAlignmentError = 89,
    AK_DeviceNotCompatible = 90,
    AK_DuplicateUniqueID = 91,
    AK_InitBankNotLoaded = 92,
    AK_DeviceNotFound = 93,
    AK_PlayingIDNotFound = 94,
    AK_InvalidFloatValue = 95,
    AK_FileFormatMismatch = 96,
    AK_NoDistinctListener = 97,
    AK_ACP_Error = 98,
    AK_ResourceInUse = 99,
    AK_InvalidBankType = 100,
    AK_AlreadyInitialized = 101,
    AK_NotInitialized = 102,
    AK_FilePermissionError = 103,
    AK_UnknownFileError = 104,
    AK_TooManyConcurrentOperations = 105,
    AK_InvalidFileSize = 106,
    AK_Deferred = 107,
    AK_FilePathTooLong = 108,
    AK_InvalidState = 109,
}

class AkRoomParams : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x213167c*/ nint getCPtr(AkRoomParams obj);
    /*0x213164c*/ AkRoomParams(nint cPtr, bool cMemoryOwn);
    /*0x21318f4*/ AkRoomParams();
    /*0x2131688*/ void setCPtr(nint cPtr);
    /*0x2131718*/ void Finalize();
    /*0x21316ac*/ void Dispose();
    /*0x21317a8*/ void Dispose(bool disposing);
    /*0x2131968*/ void set_Front(UnityEngine.Vector3 value);
    /*0x21319ec*/ UnityEngine.Vector3 get_Front();
    /*0x2131a48*/ void set_Up(UnityEngine.Vector3 value);
    /*0x2131acc*/ UnityEngine.Vector3 get_Up();
    /*0x2131b28*/ void set_ReverbAuxBus(uint value);
    /*0x2131b94*/ uint get_ReverbAuxBus();
    /*0x2131bf0*/ void set_ReverbLevel(float value);
    /*0x2131c5c*/ float get_ReverbLevel();
    /*0x2131cb8*/ void set_TransmissionLoss(float value);
    /*0x2131d24*/ float get_TransmissionLoss();
    /*0x2131d80*/ void set_RoomGameObj_AuxSendLevelToSelf(float value);
    /*0x2131dec*/ float get_RoomGameObj_AuxSendLevelToSelf();
    /*0x2131e48*/ void set_RoomGameObj_KeepRegistered(bool value);
    /*0x2131eb4*/ bool get_RoomGameObj_KeepRegistered();
    /*0x2131f10*/ void set_RoomPriority(uint value);
    /*0x2131f7c*/ uint get_RoomPriority();
}

class AkSegmentInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2132008*/ nint getCPtr(AkSegmentInfo obj);
    /*0x2131fd8*/ AkSegmentInfo(nint cPtr, bool cMemoryOwn);
    /*0x2132988*/ AkSegmentInfo();
    /*0x2132014*/ void setCPtr(nint cPtr);
    /*0x21320a4*/ void Finalize();
    /*0x2132038*/ void Dispose();
    /*0x2132134*/ void Dispose(bool disposing);
    /*0x2132280*/ void set_iCurrentPosition(int value);
    /*0x21322ec*/ int get_iCurrentPosition();
    /*0x2132348*/ void set_iPreEntryDuration(int value);
    /*0x21323b4*/ int get_iPreEntryDuration();
    /*0x2132410*/ void set_iActiveDuration(int value);
    /*0x213247c*/ int get_iActiveDuration();
    /*0x21324d8*/ void set_iPostExitDuration(int value);
    /*0x2132544*/ int get_iPostExitDuration();
    /*0x21325a0*/ void set_iRemainingLookAheadTime(int value);
    /*0x213260c*/ int get_iRemainingLookAheadTime();
    /*0x2132668*/ void set_fBeatDuration(float value);
    /*0x21326d4*/ float get_fBeatDuration();
    /*0x2132730*/ void set_fBarDuration(float value);
    /*0x213279c*/ float get_fBarDuration();
    /*0x21327f8*/ void set_fGridDuration(float value);
    /*0x2132864*/ float get_fGridDuration();
    /*0x21328c0*/ void set_fGridOffset(float value);
    /*0x213292c*/ float get_fGridOffset();
}

class AkSerializedCallbackHeader : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2132a2c*/ nint getCPtr(AkSerializedCallbackHeader obj);
    /*0x21329fc*/ AkSerializedCallbackHeader(nint cPtr, bool cMemoryOwn);
    /*0x2132e5c*/ AkSerializedCallbackHeader();
    /*0x2132a38*/ void setCPtr(nint cPtr);
    /*0x2132ac8*/ void Finalize();
    /*0x2132a5c*/ void Dispose();
    /*0x2132b58*/ void Dispose(bool disposing);
    /*0x2132ca4*/ nint get_pPackage();
    /*0x2132d00*/ uint get_eType();
    /*0x2132d5c*/ nint GetData();
    /*0x2132db8*/ AkSerializedCallbackHeader get_pNext();
}

enum AkSetPositionFlags
{
    AkSetPositionFlags_Emitter = 1,
    AkSetPositionFlags_Listener = 2,
    AkSetPositionFlags_Default = 3,
}

enum AkSourceChannelOrdering
{
    SourceChannelOrdering_Standard = 0,
    SourceChannelOrdering_Film = 1,
    SourceChannelOrdering_FuMa = 2,
    SourceChannelOrdering_Last = 3,
}

class AkSourceSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2132f00*/ nint getCPtr(AkSourceSettings obj);
    static /*0x213342c*/ int GetSizeOf();
    /*0x2132ed0*/ AkSourceSettings(nint cPtr, bool cMemoryOwn);
    /*0x21334e8*/ AkSourceSettings();
    /*0x2132f0c*/ void setCPtr(nint cPtr);
    /*0x2132f9c*/ void Finalize();
    /*0x2132f30*/ void Dispose();
    /*0x213302c*/ void Dispose(bool disposing);
    /*0x2133178*/ void set_sourceID(uint value);
    /*0x21331e4*/ uint get_sourceID();
    /*0x2133240*/ void set_pMediaMemory(nint value);
    /*0x21332ac*/ nint get_pMediaMemory();
    /*0x2133308*/ void set_uMediaSize(uint value);
    /*0x2133374*/ uint get_uMediaSize();
    /*0x21333d0*/ void Clear();
    /*0x213347c*/ void Clone(AkSourceSettings other);
}

class AkSpatialAudioInitSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x213358c*/ nint getCPtr(AkSpatialAudioInitSettings obj);
    /*0x213355c*/ AkSpatialAudioInitSettings(nint cPtr, bool cMemoryOwn);
    /*0x2133804*/ AkSpatialAudioInitSettings();
    /*0x2133598*/ void setCPtr(nint cPtr);
    /*0x2133628*/ void Finalize();
    /*0x21335bc*/ void Dispose();
    /*0x21336b8*/ void Dispose(bool disposing);
    /*0x2133878*/ void set_uMaxSoundPropagationDepth(uint value);
    /*0x21338e4*/ uint get_uMaxSoundPropagationDepth();
    /*0x2133940*/ void set_fMovementThreshold(float value);
    /*0x21339ac*/ float get_fMovementThreshold();
    /*0x2133a08*/ void set_uNumberOfPrimaryRays(uint value);
    /*0x2133a74*/ uint get_uNumberOfPrimaryRays();
    /*0x2133ad0*/ void set_uMaxReflectionOrder(uint value);
    /*0x2133b3c*/ uint get_uMaxReflectionOrder();
    /*0x2133b98*/ void set_uMaxDiffractionOrder(uint value);
    /*0x2133c04*/ uint get_uMaxDiffractionOrder();
    /*0x2133c60*/ void set_uMaxEmitterRoomAuxSends(uint value);
    /*0x2133ccc*/ uint get_uMaxEmitterRoomAuxSends();
    /*0x2133d28*/ void set_uDiffractionOnReflectionsOrder(uint value);
    /*0x2133d94*/ uint get_uDiffractionOnReflectionsOrder();
    /*0x2133df0*/ void set_fMaxPathLength(float value);
    /*0x2133e5c*/ float get_fMaxPathLength();
    /*0x2133eb8*/ void set_fCPULimitPercentage(float value);
    /*0x2133f24*/ float get_fCPULimitPercentage();
    /*0x2133f80*/ void set_uLoadBalancingSpread(uint value);
    /*0x2133fec*/ uint get_uLoadBalancingSpread();
    /*0x2134048*/ void set_bEnableGeometricDiffractionAndTransmission(bool value);
    /*0x21340b4*/ bool get_bEnableGeometricDiffractionAndTransmission();
    /*0x2134110*/ void set_bCalcEmitterVirtualPosition(bool value);
    /*0x213417c*/ bool get_bCalcEmitterVirtualPosition();
}

enum AkSpeakerPanningType
{
    AK_DirectSpeakerAssignment = 0,
    AK_BalanceFadeHeight = 1,
    AK_SteeringPanner = 2,
}

class AkStdMovePolicy : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2134208*/ nint getCPtr(AkStdMovePolicy obj);
    static /*0x2134480*/ bool IsTrivial();
    /*0x21341d8*/ AkStdMovePolicy(nint cPtr, bool cMemoryOwn);
    /*0x21344d0*/ AkStdMovePolicy();
    /*0x2134214*/ void setCPtr(nint cPtr);
    /*0x21342a4*/ void Finalize();
    /*0x2134238*/ void Dispose();
    /*0x2134334*/ void Dispose(bool disposing);
}

class AkStreamMgrSettings : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2134574*/ nint getCPtr(AkStreamMgrSettings obj);
    /*0x2134544*/ AkStreamMgrSettings(nint cPtr, bool cMemoryOwn);
    /*0x2134580*/ void setCPtr(nint cPtr);
    /*0x2134610*/ void Finalize();
    /*0x21345a4*/ void Dispose();
    /*0x21346a0*/ void Dispose(bool disposing);
}

class AkTransform : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x213481c*/ nint getCPtr(AkTransform obj);
    /*0x21347ec*/ AkTransform(nint cPtr, bool cMemoryOwn);
    /*0x2135008*/ AkTransform();
    /*0x2134828*/ void setCPtr(nint cPtr);
    /*0x21348b8*/ void Finalize();
    /*0x213484c*/ void Dispose();
    /*0x2134948*/ void Dispose(bool disposing);
    /*0x2134a94*/ UnityEngine.Vector3 Position();
    /*0x2134af0*/ UnityEngine.Vector3 OrientationFront();
    /*0x2134b4c*/ UnityEngine.Vector3 OrientationTop();
    /*0x2134ba8*/ void Set(UnityEngine.Vector3 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop);
    /*0x2134cac*/ void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ);
    /*0x2134db8*/ void SetPosition(UnityEngine.Vector3 in_position);
    /*0x2134e3c*/ void SetPosition(float in_x, float in_y, float in_z);
    /*0x2134ec0*/ void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop);
    /*0x2134f64*/ void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ);
}

class AkTriangle : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x21350ac*/ nint getCPtr(AkTriangle obj);
    static /*0x21357b8*/ int GetSizeOf();
    /*0x213507c*/ AkTriangle(nint cPtr, bool cMemoryOwn);
    /*0x2135324*/ AkTriangle();
    /*0x2135398*/ AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo);
    /*0x21350b8*/ void setCPtr(nint cPtr);
    /*0x2135148*/ void Finalize();
    /*0x21350dc*/ void Dispose();
    /*0x21351d8*/ void Dispose(bool disposing);
    /*0x213543c*/ void set_point0(ushort value);
    /*0x21354a8*/ ushort get_point0();
    /*0x2135504*/ void set_point1(ushort value);
    /*0x2135570*/ ushort get_point1();
    /*0x21355cc*/ void set_point2(ushort value);
    /*0x2135638*/ ushort get_point2();
    /*0x2135694*/ void set_surface(ushort value);
    /*0x2135700*/ ushort get_surface();
    /*0x213575c*/ void Clear();
    /*0x2135808*/ void Clone(AkTriangle other);
}

class AkTrivialStdMovePolicy : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x21358a4*/ nint getCPtr(AkTrivialStdMovePolicy obj);
    static /*0x2135b1c*/ bool IsTrivial();
    /*0x2135874*/ AkTrivialStdMovePolicy(nint cPtr, bool cMemoryOwn);
    /*0x2135b6c*/ AkTrivialStdMovePolicy();
    /*0x21358b0*/ void setCPtr(nint cPtr);
    /*0x2135940*/ void Finalize();
    /*0x21358d4*/ void Dispose();
    /*0x21359d0*/ void Dispose(bool disposing);
}

class AkWorldTransform : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2135c10*/ nint getCPtr(AkWorldTransform obj);
    /*0x2135be0*/ AkWorldTransform(nint cPtr, bool cMemoryOwn);
    /*0x2136394*/ AkWorldTransform();
    /*0x2135c1c*/ void setCPtr(nint cPtr);
    /*0x2135cac*/ void Finalize();
    /*0x2135c40*/ void Dispose();
    /*0x2135d3c*/ void Dispose(bool disposing);
    /*0x2135e88*/ AkVector64 Position();
    /*0x2135ee4*/ UnityEngine.Vector3 OrientationFront();
    /*0x2135f40*/ UnityEngine.Vector3 OrientationTop();
    /*0x2135f9c*/ void Set(AkVector64 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop);
    /*0x2136050*/ void Set(double in_positionX, double in_positionY, double in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ);
    /*0x213615c*/ void SetPosition(AkVector64 in_position);
    /*0x21361c8*/ void SetPosition(double in_x, double in_y, double in_z);
    /*0x213624c*/ void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop);
    /*0x21362f0*/ void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ);
}

class MonitorErrorInfo : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2136438*/ nint getCPtr(MonitorErrorInfo obj);
    /*0x2136408*/ MonitorErrorInfo(nint cPtr, bool cMemoryOwn);
    /*0x21366b0*/ MonitorErrorInfo(string in_name, string in_message);
    /*0x213673c*/ MonitorErrorInfo(string in_name);
    /*0x21367c0*/ MonitorErrorInfo();
    /*0x2136444*/ void setCPtr(nint cPtr);
    /*0x21364d4*/ void Finalize();
    /*0x2136468*/ void Dispose();
    /*0x2136564*/ void Dispose(bool disposing);
    /*0x2136834*/ void set_m_name(string value);
    /*0x21368a0*/ string get_m_name();
    /*0x2136934*/ void set_m_message(string value);
    /*0x21369a0*/ string get_m_message();
}

class MsgContext : System.IDisposable
{
    /*0x10*/ nint swigCPtr;
    /*0x18*/ bool swigCMemOwn;

    static /*0x2136a64*/ nint getCPtr(MsgContext obj);
    /*0x2136a34*/ MsgContext(nint cPtr, bool cMemoryOwn);
    /*0x2136cdc*/ MsgContext(uint pId, ulong goId, uint nodeId, bool isBus);
    /*0x2136d80*/ MsgContext(uint pId, ulong goId, uint nodeId);
    /*0x2136e1c*/ MsgContext(uint pId, ulong goId);
    /*0x2136ea8*/ MsgContext(uint pId);
    /*0x2136f2c*/ MsgContext();
    /*0x2136a70*/ void setCPtr(nint cPtr);
    /*0x2136b00*/ void Finalize();
    /*0x2136a94*/ void Dispose();
    /*0x2136b90*/ void Dispose(bool disposing);
    /*0x2136fa0*/ void set_in_playingID(uint value);
    /*0x213700c*/ uint get_in_playingID();
    /*0x2137068*/ void set_in_gameObjID(ulong value);
    /*0x21370d4*/ ulong get_in_gameObjID();
    /*0x2137130*/ void set_in_soundID(uint value);
    /*0x213719c*/ uint get_in_soundID();
    /*0x21371f8*/ void set_in_bIsBus(bool value);
    /*0x2137264*/ bool get_in_bIsBus();
}

class AkBasePathGetter
{
    static string DecodedBankFolder = "DecodedBanks";
    static /*0x0*/ string DefaultPlatformName;
    static /*0x8*/ AkBasePathGetter.CustomPlatformNameGetter GetCustomPlatformName;
    static /*0x10*/ string DefaultBasePath;
    static /*0x18*/ bool LogWarnings_Internal;
    static /*0x20*/ AkBasePathGetter Instance;
    /*0x10*/ string <SoundBankBasePath>k__BackingField;
    /*0x18*/ string <PersistentDataPath>k__BackingField;
    /*0x20*/ string <DecodedBankFullPath>k__BackingField;

    static /*0x2137b40*/ AkBasePathGetter();
    static /*0x21372c0*/ string GetPlatformName();
    static /*0x2137384*/ bool get_LogWarnings();
    static /*0x21373dc*/ void set_LogWarnings(bool value);
    static /*0x213743c*/ string GetPlatformBasePath();
    static /*0x21376c0*/ AkBasePathGetter Get();
    /*0x2137784*/ AkBasePathGetter();
    /*0x213778c*/ void EvaluateGamePaths();
    /*0x2137b10*/ string get_SoundBankBasePath();
    /*0x2137b18*/ void set_SoundBankBasePath(string value);
    /*0x2137b20*/ string get_PersistentDataPath();
    /*0x2137b28*/ void set_PersistentDataPath(string value);
    /*0x2137b30*/ string get_DecodedBankFullPath();
    /*0x2137b38*/ void set_DecodedBankFullPath(string value);

    class CustomPlatformNameGetter : System.MulticastDelegate
    {
        /*0x2137c38*/ CustomPlatformNameGetter(object object, nint method);
        /*0x2137ce8*/ void Invoke(ref string platformName);
        /*0x2137cfc*/ System.IAsyncResult BeginInvoke(ref string platformName, System.AsyncCallback callback, object object);
        /*0x2137d20*/ void EndInvoke(ref string platformName, System.IAsyncResult result);
    }
}

class AkCommonUserSettings
{
    /*0x10*/ string m_BasePath;
    /*0x18*/ string m_StartupLanguage;
    /*0x20*/ bool m_EngineLogging;
    /*0x24*/ float m_DefaultScalingFactor;
    /*0x28*/ uint m_MaximumNumberOfPositioningPaths;
    /*0x2c*/ uint m_CommandQueueSize;
    /*0x30*/ uint m_SamplesPerFrame;
    /*0x38*/ AkCommonOutputSettings m_MainOutputSettings;
    /*0x40*/ float m_StreamingLookAheadRatio;
    /*0x44*/ uint m_SampleRate;
    /*0x48*/ ushort m_NumberOfRefillsInVoice;
    /*0x50*/ AkCommonUserSettings.SpatialAudioSettings m_SpatialAudioSettings;

    static /*0x2137d38*/ string GetPluginPath();
    /*0x213811c*/ AkCommonUserSettings();
    /*0x2137d40*/ void CopyTo(AkInitSettings settings);
    /*0x2137f30*/ void CopyTo(AkMusicSettings settings);
    /*0x2137f48*/ void CopyTo(AkStreamMgrSettings settings);
    /*0x2137f4c*/ void CopyTo(AkDeviceSettings settings);
    /*0x2137f50*/ void SetSampleRate(AkPlatformInitSettings settings);
    /*0x2137f70*/ void CopyTo(AkPlatformInitSettings settings);
    /*0x2137fb0*/ void CopyTo(AkSpatialAudioInitSettings settings);
    /*0x21380c0*/ void CopyTo(AkUnityPlatformSpecificSettings settings);
    /*0x21380c4*/ void Validate();

    class SpatialAudioSettings
    {
        /*0x10*/ uint m_MaxSoundPropagationDepth;
        /*0x14*/ float m_MovementThreshold;
        /*0x18*/ uint m_NumberOfPrimaryRays;
        /*0x1c*/ uint m_MaxReflectionOrder;
        /*0x20*/ uint m_MaxDiffractionOrder;
        /*0x24*/ uint m_DiffractionOnReflectionsOrder;
        /*0x28*/ uint m_MaxEmitterRoomAuxSends;
        /*0x2c*/ float m_MaxPathLength;
        /*0x30*/ float m_CPULimitPercentage;
        /*0x34*/ bool m_EnableGeometricDiffractionAndTransmission;
        /*0x35*/ bool m_CalcEmitterVirtualPosition;
        /*0x38*/ uint m_LoadBalancingSpread;

        /*0x21381e8*/ SpatialAudioSettings();
    }
}

class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings
{
    /*0x30*/ AkCommonUserSettings UserSettings;
    /*0x38*/ AkAndroidSettings.PlatformAdvancedSettings AdvancedSettings;
    /*0x40*/ AkCommonCommSettings CommsSettings;

    /*0x2138224*/ AkAndroidSettings();
    /*0x21385d8*/ AkCommonUserSettings GetUserSettings();
    /*0x21385e0*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x21385e8*/ AkCommonCommSettings GetCommsSettings();

    class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        /*0x54*/ AkAndroidSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI;
        /*0x58*/ bool m_RoundFrameSizeToHardwareSize;
        /*0x59*/ bool m_UseLowLatencyMode;

        /*0x2138640*/ PlatformAdvancedSettings();
        /*0x21385f0*/ void CopyTo(AkPlatformInitSettings settings);

        enum AudioAPI
        {
            None = 0,
            AAudio = 1,
            OpenSL_ES = 2,
            Default = -1,
        }
    }
}

class AkAudioInputManager
{
    static /*0x0*/ bool initialized;
    static /*0x8*/ System.Collections.Generic.Dictionary<uint, AkAudioInputManager.AudioSamplesDelegate> audioSamplesDelegates;
    static /*0x10*/ System.Collections.Generic.Dictionary<uint, AkAudioInputManager.AudioFormatDelegate> audioFormatDelegates;
    static /*0x18*/ AkAudioFormat audioFormat;
    static /*0x20*/ AkAudioInputManager.AudioSamplesInteropDelegate audioSamplesDelegate;
    static /*0x28*/ AkAudioInputManager.AudioFormatInteropDelegate audioFormatDelegate;

    static /*0x2138f18*/ AkAudioInputManager();
    static /*0x2138928*/ uint PostAudioInputEvent(uint akEventID, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate);
    static /*0x2138ce0*/ uint PostAudioInputEvent(string akEventName, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate);
    static /*0x21386dc*/ bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames);
    static /*0x21387f8*/ void InternalAudioFormatDelegate(uint playingID, nint format);
    static /*0x2138a2c*/ void TryInitialize();
    static /*0x2138bf0*/ void AddPlayingID(uint playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate);
    static /*0x2138de4*/ void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);

    class AudioFormatDelegate : System.MulticastDelegate
    {
        /*0x2139234*/ AudioFormatDelegate(object object, nint method);
        /*0x21392d4*/ void Invoke(uint playingID, AkAudioFormat format);
        /*0x21392e8*/ System.IAsyncResult BeginInvoke(uint playingID, AkAudioFormat format, System.AsyncCallback callback, object object);
        /*0x2139358*/ void EndInvoke(System.IAsyncResult result);
    }

    class AudioFormatInteropDelegate : System.MulticastDelegate
    {
        /*0x2139194*/ AudioFormatInteropDelegate(object object, nint method);
        /*0x2139364*/ void Invoke(uint playingID, nint format);
        /*0x2139378*/ System.IAsyncResult BeginInvoke(uint playingID, nint format, System.AsyncCallback callback, object object);
        /*0x21393f4*/ void EndInvoke(System.IAsyncResult result);
    }

    class AudioSamplesDelegate : System.MulticastDelegate
    {
        /*0x2139400*/ AudioSamplesDelegate(object object, nint method);
        /*0x21394a0*/ bool Invoke(uint playingID, uint channelIndex, float[] samples);
        /*0x21394b4*/ System.IAsyncResult BeginInvoke(uint playingID, uint channelIndex, float[] samples, System.AsyncCallback callback, object object);
        /*0x2139538*/ bool EndInvoke(System.IAsyncResult result);
    }

    class AudioSamplesInteropDelegate : System.MulticastDelegate
    {
        /*0x21390f4*/ AudioSamplesInteropDelegate(object object, nint method);
        /*0x2139560*/ bool Invoke(uint playingID, float[] samples, uint channelIndex, uint frames);
        /*0x2139574*/ System.IAsyncResult BeginInvoke(uint playingID, float[] samples, uint channelIndex, uint frames, System.AsyncCallback callback, object object);
        /*0x2139610*/ bool EndInvoke(System.IAsyncResult result);
    }
}

class AkBankManager
{
    static /*0x0*/ System.Collections.Generic.Dictionary<string, AkBankManager.BankHandle> m_BankHandles;
    static /*0x8*/ System.Collections.Generic.List<AkBankManager.BankHandle> BanksToUnload;

    static /*0x213ae0c*/ AkBankManager();
    static /*0x2139638*/ void DoUnloadBanks();
    static /*0x21397a4*/ void Reset();
    static /*0x2139964*/ void ReloadAllBanks();
    static /*0x2139e60*/ void LoadInitBank(bool doReset);
    static /*0x2139df4*/ void UnloadInitBank();
    static /*0x2139fa8*/ void LoadBank(string name, bool decodeBank, bool saveDecodedBank);
    static /*0x213a64c*/ void LoadBankAsync(string name, AkCallbackManager.BankCallback callback);
    static /*0x213a8b4*/ void UnloadBank(string name);
    static /*0x213aabc*/ void UnloadAllBanks();

    class BankHandle
    {
        /*0x10*/ string bankName;
        /*0x18*/ uint m_BankID;
        /*0x1c*/ int <RefCount>k__BackingField;

        /*0x213a2ac*/ BankHandle(string name);
        /*0x213aefc*/ int get_RefCount();
        /*0x213af04*/ void set_RefCount(int value);
        /*0x213af0c*/ AKRESULT DoLoadBank();
        /*0x213a59c*/ void LoadBank();
        /*0x213b15c*/ void UnloadBank(bool remove);
        /*0x213a214*/ void IncRef();
        /*0x213aa20*/ void DecRef();
        /*0x213af6c*/ void LogLoadResult(AKRESULT result);
    }

    class AsyncBankHandle : AkBankManager.BankHandle
    {
        /*0x20*/ AkCallbackManager.BankCallback bankCallback;

        static /*0x213b2f4*/ void GlobalBankCallback(uint in_bankID, nint in_pInMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie);
        /*0x213a870*/ AsyncBankHandle(string name, AkCallbackManager.BankCallback callback);
        /*0x213b4ec*/ AKRESULT DoLoadBank();
    }

    class DecodableBankHandle : AkBankManager.BankHandle
    {
        /*0x20*/ bool decodeBank;
        /*0x28*/ string decodedBankPath;
        /*0x30*/ bool saveDecodedBank;

        /*0x213a2dc*/ DecodableBankHandle(string name, bool save);
        /*0x213b63c*/ AKRESULT DoLoadBank();
        /*0x213b790*/ void UnloadBank(bool remove);
    }
}

class AkCallbackManager
{
    static /*0x0*/ bool <IsLoggingEnabled>k__BackingField;
    static /*0x8*/ AkEventCallbackInfo AkEventCallbackInfo;
    static /*0x10*/ AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;
    static /*0x18*/ AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;
    static /*0x20*/ AkMarkerCallbackInfo AkMarkerCallbackInfo;
    static /*0x28*/ AkDurationCallbackInfo AkDurationCallbackInfo;
    static /*0x30*/ AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;
    static /*0x38*/ AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;
    static /*0x40*/ AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;
    static /*0x48*/ AkMonitoringCallbackInfo AkMonitoringCallbackInfo;
    static /*0x50*/ AkBankCallbackInfo AkBankCallbackInfo;
    static /*0x58*/ System.Collections.Generic.Dictionary<int, AkCallbackManager.EventCallbackPackage> m_mapEventCallbacks;
    static /*0x60*/ System.Collections.Generic.Dictionary<int, AkCallbackManager.BankCallbackPackage> m_mapBankCallbacks;
    static /*0x68*/ AkCallbackManager.EventCallbackPackage m_LastAddedEventPackage;
    static /*0x70*/ AkCallbackManager.MonitoringCallback m_MonitoringCB;
    static /*0x78*/ AkCallbackManager.BGMCallbackPackage ms_sourceChangeCallbackPkg;

    static /*0x213d6a0*/ AkCallbackManager();
    static /*0x213b818*/ bool get_IsLoggingEnabled();
    static /*0x213b870*/ void set_IsLoggingEnabled(bool value);
    static /*0x213b8d0*/ void RemoveEventCallback(uint in_playingID);
    static /*0x213bd24*/ void RemoveEventCallbackCookie(object in_cookie);
    static /*0x213c198*/ void RemoveBankCallback(object in_cookie);
    static /*0x21295d0*/ void SetLastAddedPlayingID(uint in_playingID);
    static /*0x213c60c*/ void Init(AkCallbackManager.InitializationSettings settings);
    static /*0x213c6ac*/ void Term();
    static /*0x213c6b4*/ void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB);
    static /*0x213c6a8*/ void SetLocalOutput(AkMonitorErrorLevel in_Level);
    static /*0x213c714*/ void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, object in_cookie);
    static /*0x213c7d8*/ void ParseCallbackInfoMessage(ref string in_message);
    static /*0x213caf0*/ int PostCallbacks();

    class EventCallback : System.MulticastDelegate
    {
        /*0x2138ae4*/ EventCallback(object object, nint method);
        /*0x213da30*/ void Invoke(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
        /*0x213da44*/ System.IAsyncResult BeginInvoke(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info, System.AsyncCallback callback, object object);
        /*0x213dae0*/ void EndInvoke(System.IAsyncResult result);
    }

    class MonitoringCallback : System.MulticastDelegate
    {
        /*0x213daec*/ MonitoringCallback(object object, nint method);
        /*0x213db8c*/ void Invoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg);
        /*0x213dba0*/ System.IAsyncResult BeginInvoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg, System.AsyncCallback callback, object object);
        /*0x213dc98*/ void EndInvoke(System.IAsyncResult result);
    }

    class BankCallback : System.MulticastDelegate
    {
        /*0x213b59c*/ BankCallback(object object, nint method);
        /*0x213dca4*/ void Invoke(uint in_bankID, nint in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie);
        /*0x213dcb8*/ System.IAsyncResult BeginInvoke(uint in_bankID, nint in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie, System.AsyncCallback callback, object object);
        /*0x213dd84*/ void EndInvoke(System.IAsyncResult result);
    }

    class EventCallbackPackage
    {
        /*0x10*/ bool m_bNotifyEndOfEvent;
        /*0x18*/ AkCallbackManager.EventCallback m_Callback;
        /*0x20*/ object m_Cookie;
        /*0x28*/ uint m_playingID;

        static /*0x2129884*/ AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback in_cb, object in_cookie, ref uint io_Flags);
        /*0x213dd90*/ EventCallbackPackage();
    }

    class BankCallbackPackage
    {
        /*0x10*/ AkCallbackManager.BankCallback m_Callback;
        /*0x18*/ object m_Cookie;

        /*0x213dd98*/ BankCallbackPackage(AkCallbackManager.BankCallback in_cb, object in_cookie);
    }

    class BGMCallback : System.MulticastDelegate
    {
        /*0x213de7c*/ BGMCallback(object object, nint method);
        /*0x213df1c*/ AKRESULT Invoke(bool in_bOtherAudioPlaying, object in_Cookie);
        /*0x213df30*/ System.IAsyncResult BeginInvoke(bool in_bOtherAudioPlaying, object in_Cookie, System.AsyncCallback callback, object object);
        /*0x213dfa0*/ AKRESULT EndInvoke(System.IAsyncResult result);
    }

    class BGMCallbackPackage
    {
        /*0x10*/ AkCallbackManager.BGMCallback m_Callback;
        /*0x18*/ object m_Cookie;

        /*0x213c7d0*/ BGMCallbackPackage();
    }

    class InitializationSettings
    {
        static bool DefaultIsLoggingEnabled = true;
        /*0x10*/ bool IsLoggingEnabled;

        /*0x213dfc8*/ InitializationSettings();
    }
}

class AkBasePlatformSettings : UnityEngine.ScriptableObject
{
    /*0x213e1fc*/ AkBasePlatformSettings();
    /*0x213dfd8*/ AkInitializationSettings get_AkInitializationSettings();
    /*0x213e02c*/ AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings();
    /*0x213e07c*/ AkCallbackManager.InitializationSettings get_CallbackManagerInitializationSettings();
    /*0x213e0d8*/ string get_SoundBankPersistentDataPath();
    /*0x213e0e0*/ string get_InitialLanguage();
    /*0x213e120*/ bool get_LoadBanksAsynchronously();
    /*0x213e128*/ bool get_SuspendAudioDuringFocusLoss();
    /*0x213e130*/ bool get_RenderDuringFocusLoss();
    /*0x213e138*/ string get_SoundbankPath();
    /*0x213e190*/ AkCommunicationSettings get_AkCommunicationSettings();
    /*0x213e1e4*/ uint get_MemoryAllocationSizeLimit();
    /*0x213e1ec*/ uint get_MemoryDebugLevel();
    /*0x213e1f4*/ float get_DefaultScalingFactor();
}

class AkCommonOutputSettings
{
    /*0x10*/ string m_AudioDeviceShareset;
    /*0x18*/ uint m_DeviceID;
    /*0x1c*/ AkCommonOutputSettings.PanningRule m_PanningRule;
    /*0x20*/ AkCommonOutputSettings.ChannelConfiguration m_ChannelConfig;

    /*0x2138394*/ AkCommonOutputSettings();
    /*0x2137e74*/ void CopyTo(AkOutputSettings settings);

    enum PanningRule
    {
        Speakers = 0,
        Headphones = 1,
    }

    class ChannelConfiguration
    {
        /*0x10*/ AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType m_ChannelConfigType;
        /*0x14*/ AkCommonOutputSettings.ChannelConfiguration.ChannelMask m_ChannelMask;
        /*0x18*/ uint m_NumberOfChannels;

        /*0x2138420*/ ChannelConfiguration();
        /*0x213e31c*/ void CopyTo(AkChannelConfig config);

        enum ChannelConfigType
        {
            Anonymous = 0,
            Standard = 1,
            Ambisonic = 2,
        }

        enum ChannelMask
        {
            NONE = 0,
            FRONT_LEFT = 1,
            FRONT_RIGHT = 2,
            FRONT_CENTER = 4,
            LOW_FREQUENCY = 8,
            BACK_LEFT = 16,
            BACK_RIGHT = 32,
            BACK_CENTER = 256,
            SIDE_LEFT = 512,
            SIDE_RIGHT = 1024,
            TOP = 2048,
            HEIGHT_FRONT_LEFT = 4096,
            HEIGHT_FRONT_CENTER = 8192,
            HEIGHT_FRONT_RIGHT = 16384,
            HEIGHT_BACK_LEFT = 32768,
            HEIGHT_BACK_CENTER = 65536,
            HEIGHT_BACK_RIGHT = 131072,
            SETUP_MONO = 4,
            SETUP_0POINT1 = 8,
            SETUP_1POINT1 = 12,
            SETUP_STEREO = 3,
            SETUP_2POINT1 = 11,
            SETUP_3STEREO = 7,
            SETUP_3POINT1 = 15,
            SETUP_4 = 1539,
            SETUP_4POINT1 = 1547,
            SETUP_5 = 1543,
            SETUP_5POINT1 = 1551,
            SETUP_6 = 1587,
            SETUP_6POINT1 = 1595,
            SETUP_7 = 1591,
            SETUP_7POINT1 = 1599,
            SETUP_SURROUND = 259,
            SETUP_DPL2 = 1539,
            SETUP_HEIGHT_4 = 184320,
            SETUP_HEIGHT_5 = 192512,
            SETUP_HEIGHT_ALL = 258048,
            SETUP_AURO_222 = 22019,
            SETUP_AURO_8 = 185859,
            SETUP_AURO_9 = 185863,
            SETUP_AURO_9POINT1 = 185871,
            SETUP_AURO_10 = 187911,
            SETUP_AURO_10POINT1 = 187919,
            SETUP_AURO_11 = 196103,
            SETUP_AURO_11POINT1 = 196111,
            SETUP_AURO_11_740 = 185911,
            SETUP_AURO_11POINT1_740 = 185919,
            SETUP_AURO_13_751 = 196151,
            SETUP_AURO_13POINT1_751 = 196159,
            SETUP_DOLBY_5_0_2 = 22023,
            SETUP_DOLBY_5_1_2 = 22031,
            SETUP_DOLBY_6_0_2 = 22067,
            SETUP_DOLBY_6_1_2 = 22075,
            SETUP_DOLBY_6_0_4 = 185907,
            SETUP_DOLBY_6_1_4 = 185915,
            SETUP_DOLBY_7_0_2 = 22071,
            SETUP_DOLBY_7_1_2 = 22079,
            SETUP_DOLBY_7_0_4 = 185911,
            SETUP_DOLBY_7_1_4 = 185919,
            SETUP_ALL_SPEAKERS = 261951,
        }
    }
}

class AkCommonAdvancedSettings
{
    /*0x10*/ uint m_IOMemorySize;
    /*0x14*/ float m_TargetAutoStreamBufferLengthMs;
    /*0x18*/ bool m_UseStreamCache;
    /*0x19*/ bool m_LoadBankAsynchronously;
    /*0x1c*/ uint m_MaximumPinnedBytesInCache;
    /*0x20*/ bool m_EnableGameSyncPreparation;
    /*0x24*/ uint m_ContinuousPlaybackLookAhead;
    /*0x28*/ uint m_MonitorQueuePoolSize;
    /*0x2c*/ uint m_MaximumHardwareTimeoutMs;
    /*0x30*/ bool m_DebugOutOfRangeCheckEnabled;
    /*0x34*/ float m_DebugOutOfRangeLimit;
    /*0x38*/ bool m_SuspendAudioDuringFocusLoss;
    /*0x39*/ bool m_RenderDuringFocusLoss;
    /*0x40*/ string m_SoundBankPersistentDataPath;
    /*0x48*/ uint m_MemoryAllocationSizeLimit;
    /*0x4c*/ uint m_MemoryDebugLevel;
    /*0x50*/ AkCommonAdvancedSettings.MemSpanCount m_MemorySpanCount;

    /*0x2138694*/ AkCommonAdvancedSettings();
    /*0x213e398*/ void CopyTo(AkDeviceSettings settings);
    /*0x213e3f8*/ void CopyTo(AkInitSettings settings);
    /*0x213e478*/ void CopyTo(AkPlatformInitSettings settings);
    /*0x213e47c*/ void CopyTo(AkUnityPlatformSpecificSettings settings);

    enum MemSpanCount
    {
        Small = 0,
        Medium = 1,
        Huge = 2,
    }
}

class AkCommonCommSettings
{
    static /*0x0*/ ushort DefaultDiscoveryBroadcastPort;
    /*0x10*/ uint m_PoolSize;
    /*0x14*/ ushort m_DiscoveryBroadcastPort;
    /*0x16*/ ushort m_CommandPort;
    /*0x18*/ ushort m_NotificationPort;
    /*0x1a*/ bool m_InitializeSystemComms;
    /*0x20*/ string m_NetworkName;
    /*0x28*/ AkCommunicationSettings.AkCommSystem m_commSystem;

    static /*0x213e5d4*/ AkCommonCommSettings();
    /*0x213e55c*/ AkCommonCommSettings();
    /*0x213e480*/ void CopyTo(AkCommunicationSettings settings);
    /*0x213e558*/ void Validate();
}

class AkCommonPlatformSettings : AkBasePlatformSettings
{
    /*0x213ea64*/ AkCommonPlatformSettings();
    /*0x1f30214*/ AkCommonUserSettings GetUserSettings();
    /*0x1f30214*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x1f30214*/ AkCommonCommSettings GetCommsSettings();
    /*0x213e620*/ AkInitializationSettings get_AkInitializationSettings();
    /*0x213e7d8*/ AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings();
    /*0x213e828*/ AkCallbackManager.InitializationSettings get_CallbackManagerInitializationSettings();
    /*0x213e8ac*/ string get_InitialLanguage();
    /*0x213e8d4*/ bool get_LoadBanksAsynchronously();
    /*0x213e8fc*/ string get_SoundBankPersistentDataPath();
    /*0x213e924*/ bool get_SuspendAudioDuringFocusLoss();
    /*0x213e94c*/ bool get_RenderDuringFocusLoss();
    /*0x213e974*/ string get_SoundbankPath();
    /*0x213e99c*/ uint get_MemoryAllocationSizeLimit();
    /*0x213e9c4*/ uint get_MemoryDebugLevel();
    /*0x213e9ec*/ float get_DefaultScalingFactor();
    /*0x213ea14*/ AkCommunicationSettings get_AkCommunicationSettings();
}

class AkEnumFlagAttribute : UnityEngine.PropertyAttribute
{
    /*0x18*/ System.Type Type;

    /*0x213ea6c*/ AkEnumFlagAttribute(System.Type type);
}

class AkLogger
{
    static /*0x0*/ AkLogger ms_Instance;
    /*0x10*/ AkLogger.ErrorLoggerInteropDelegate errorLoggerDelegate;

    static /*0x213f1a4*/ AkLogger();
    static /*0x213ed5c*/ AkLogger get_Instance();
    static /*0x213ea9c*/ void WwiseInternalLogError(string message);
    static /*0x213eef8*/ void Message(string message);
    static /*0x213efdc*/ void Warning(string message);
    static /*0x213f0c0*/ void Error(string message);
    /*0x213eb80*/ AkLogger();
    /*0x213edb4*/ void Finalize();
    /*0x213eef4*/ void Init();

    class ErrorLoggerInteropDelegate : System.MulticastDelegate
    {
        /*0x213ecac*/ ErrorLoggerInteropDelegate(object object, nint method);
        /*0x213f208*/ void Invoke(string message);
        /*0x213f21c*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
        /*0x213f23c*/ void EndInvoke(System.IAsyncResult result);
    }
}

class AkShowOnlyAttribute : UnityEngine.PropertyAttribute
{
    /*0x213f248*/ AkShowOnlyAttribute();
}

class AkSoundEngineInitialization
{
    static /*0x0*/ AkSoundEngineInitialization m_Instance;
    /*0x10*/ AkSoundEngineInitialization.InitializationDelegate initializationDelegate;
    /*0x18*/ AkSoundEngineInitialization.TerminationDelegate terminationDelegate;

    static /*0x213f250*/ AkSoundEngineInitialization get_Instance();
    /*0x213f2d8*/ AkSoundEngineInitialization();
    /*0x213f2e0*/ bool InitializeSoundEngine();
    /*0x213f770*/ void LoadInitBank();
    /*0x213f7c0*/ void ClearBanks();
    /*0x213f810*/ void ResetBanks();
    /*0x213f85c*/ bool ResetSoundEngine(bool isInPlayMode);
    /*0x213f924*/ bool ShouldKeepSoundEngineEnabled();
    /*0x213f92c*/ void ResetSoundEngine();
    /*0x213fa88*/ void TerminateSoundEngine();
    /*0x213f934*/ void TerminateSoundEngine(bool forceReset);

    class InitializationDelegate : System.MulticastDelegate
    {
        /*0x213fa90*/ InitializationDelegate(object object, nint method);
        /*0x213fb2c*/ void Invoke();
        /*0x213fb40*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x213fb5c*/ void EndInvoke(System.IAsyncResult result);
    }

    class TerminationDelegate : System.MulticastDelegate
    {
        /*0x213fb68*/ TerminationDelegate(object object, nint method);
        /*0x213fc04*/ void Invoke();
        /*0x213fc18*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x213fc34*/ void EndInvoke(System.IAsyncResult result);
    }
}

class AkUtilities
{
    static /*0x213fc40*/ void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash);
    static /*0x213764c*/ void FixSlashes(ref string path);
    static /*0x213fd4c*/ string GetPathInPackage(string relativePath);
    /*0x214009c*/ AkUtilities();

    class ShortIDGenerator
    {
        static uint s_prime32 = 16777619;
        static uint s_offsetBasis32 = 2166136261;
        static /*0x0*/ byte s_hashSize;
        static /*0x4*/ uint s_mask;

        static /*0x21400a4*/ ShortIDGenerator();
        static /*0x2140118*/ byte get_HashSize();
        static /*0x21400ac*/ void set_HashSize(byte value);
        static /*0x213e204*/ uint Compute(string in_name);
        /*0x2140170*/ ShortIDGenerator();
    }
}

class AkVector
{
    /*0x10*/ UnityEngine.Vector3 Vector;

    static /*0x21401b4*/ UnityEngine.Vector3 op_Implicit(AkVector vector);
    /*0x21401cc*/ AkVector();
    /*0x2140178*/ void Zero();
    /*0x2140184*/ void set_X(float value);
    /*0x214018c*/ float get_X();
    /*0x2140194*/ void set_Y(float value);
    /*0x214019c*/ float get_Y();
    /*0x21401a4*/ void set_Z(float value);
    /*0x21401ac*/ float get_Z();
}

class AkVector64
{
    /*0x10*/ double X;
    /*0x18*/ double Y;
    /*0x20*/ double Z;

    static /*0x2140238*/ AkVector64 op_Implicit(UnityEngine.Vector3 vector);
    /*0x21402c4*/ AkVector64();
    /*0x214022c*/ void Zero();
}

class AkVertex
{
    /*0x10*/ UnityEngine.Vector3 Vector;

    static /*0x2140308*/ UnityEngine.Vector3 op_Implicit(AkVertex vector);
    static /*0x2140414*/ int GetSizeOf();
    /*0x2140320*/ AkVertex();
    /*0x2140380*/ AkVertex(float x, float y, float z);
    /*0x21402cc*/ void Zero();
    /*0x21402d8*/ void set_X(float value);
    /*0x21402e0*/ float get_X();
    /*0x21402e8*/ void set_Y(float value);
    /*0x21402f0*/ float get_Y();
    /*0x21402f8*/ void set_Z(float value);
    /*0x2140300*/ float get_Z();
    /*0x2140408*/ void Clear();
    /*0x214041c*/ void Clone(AkVertex other);
}

class AkVertexArray : AkBaseArray<AkVertex>
{
    /*0x214043c*/ AkVertexArray(int count);
    /*0x2140494*/ int get_StructureSize();
    /*0x214049c*/ AkVertex CreateNewReferenceFromIntPtr(nint address);
    /*0x21404a4*/ void CloneIntoReferenceFromIntPtr(nint address, AkVertex other);
}

class AkWwiseInitializationSettings : AkCommonPlatformSettings
{
    static /*0x0*/ string[] AllGlobalValues;
    static /*0x8*/ AkWwiseInitializationSettings m_Instance;
    static /*0x10*/ AkBasePlatformSettings m_ActivePlatformSettings;
    /*0x18*/ System.Collections.Generic.List<string> PlatformSettingsNameList;
    /*0x20*/ System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList;
    /*0x28*/ System.Collections.Generic.List<string> InvalidReferencePlatforms;
    /*0x30*/ AkCommonUserSettings UserSettings;
    /*0x38*/ AkCommonAdvancedSettings AdvancedSettings;
    /*0x40*/ AkCommonCommSettings CommsSettings;

    static /*0x2140be4*/ AkWwiseInitializationSettings();
    static /*0x214058c*/ AkWwiseInitializationSettings get_Instance();
    static /*0x21406d0*/ AkBasePlatformSettings GetPlatformSettings(string platformName);
    static /*0x213753c*/ AkBasePlatformSettings get_ActivePlatformSettings();
    /*0x21409fc*/ AkWwiseInitializationSettings();
    /*0x21404a8*/ bool get_IsValid();
    /*0x2140510*/ int get_Count();
    /*0x2140558*/ AkCommonUserSettings GetUserSettings();
    /*0x2140560*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x2140568*/ AkCommonCommSettings GetCommsSettings();
    /*0x2140570*/ void ResetSoundEngine(bool _);
    /*0x214089c*/ void OnEnable();

    class PlatformSettings : AkCommonPlatformSettings
    {
        /*0x18*/ System.Collections.Generic.List<string> IgnorePropertyNameList;
        /*0x20*/ System.Collections.Generic.List<string> GlobalPropertyNameList;
        /*0x28*/ System.Collections.Generic.HashSet<string> _GlobalPropertyHashSet;

        /*0x2138428*/ PlatformSettings();
        /*0x21416bc*/ void IgnorePropertyValue(string propertyPath);
        /*0x2141740*/ bool IsPropertyIgnored(string propertyPath);
        /*0x213850c*/ void SetUseGlobalPropertyValue(string propertyPath, bool use);
        /*0x2141798*/ void SetGlobalPropertyValues(System.Collections.IEnumerable enumerable);
        /*0x2141aa4*/ bool IsUsingGlobalPropertyValue(string propertyPath);
        /*0x2141afc*/ System.Collections.Generic.HashSet<string> get_GlobalPropertyHashSet();
        /*0x2141b94*/ void set_GlobalPropertyHashSet(System.Collections.Generic.HashSet<string> value);
    }

    class CommonPlatformSettings : AkWwiseInitializationSettings.PlatformSettings
    {
        /*0x30*/ AkCommonUserSettings UserSettings;
        /*0x38*/ AkCommonAdvancedSettings AdvancedSettings;
        /*0x40*/ AkCommonCommSettings CommsSettings;

        /*0x2141bb4*/ CommonPlatformSettings();
        /*0x2141b9c*/ AkCommonUserSettings GetUserSettings();
        /*0x2141ba4*/ AkCommonAdvancedSettings GetAdvancedSettings();
        /*0x2141bac*/ AkCommonCommSettings GetCommsSettings();
    }
}

class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
    /*0x2141bb8*/ AkAcousticSurfaceArray(int count);
    /*0x2141c10*/ int get_StructureSize();
    /*0x2141c60*/ void DefaultConstructAtIntPtr(nint address);
    /*0x2141cb8*/ AkAcousticSurface CreateNewReferenceFromIntPtr(nint address);
    /*0x2141d18*/ void CloneIntoReferenceFromIntPtr(nint address, AkAcousticSurface other);
}

class AkAuxSendArray : System.IDisposable
{
    static int MAX_COUNT = 4;
    /*0x10*/ int SIZE_OF_AKAUXSENDVALUE;
    /*0x18*/ nint m_Buffer;
    /*0x20*/ int m_Count;

    /*0x2141d94*/ AkAuxSendArray();
    /*0x2141e38*/ AkAuxSendValue get_Item(int index);
    /*0x2141f50*/ bool get_isFull();
    /*0x2141f74*/ void Dispose();
    /*0x2141fe0*/ void Finalize();
    /*0x2142064*/ void Reset();
    /*0x214206c*/ bool Add(UnityEngine.GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue);
    /*0x214217c*/ bool Add(uint in_AuxBusID, float in_fValue);
    /*0x2142248*/ bool Contains(UnityEngine.GameObject in_listenerGameObj, uint in_AuxBusID);
    /*0x2142368*/ bool Contains(uint in_AuxBusID);
    /*0x2142444*/ AKRESULT SetValues(UnityEngine.GameObject gameObject);
    /*0x21424f0*/ AKRESULT GetValues(UnityEngine.GameObject gameObject);
    /*0x21425ac*/ nint GetBuffer();
    /*0x21425b4*/ int Count();
    /*0x2141f18*/ nint GetObjectPtr(int index);
}

class AkBaseArray<T> : System.IDisposable
{
    /*0x0*/ int <Capacity>k__BackingField;
    /*0x0*/ nint m_Buffer;

    /*0x1f30b78*/ AkBaseArray(int capacity);
    /*0x1f309e4*/ void Dispose();
    /*0x1f309e4*/ void Finalize();
    /*0x1f2ffc8*/ int get_Capacity();
    /*0x1f30b78*/ void set_Capacity(int value);
    /*0x1f2ffc8*/ int Count();
    /*0x1f2ffc8*/ int get_StructureSize();
    void DefaultConstructAtIntPtr(nint address);
    void ReleaseAllocatedMemoryFromReferenceAtIntPtr(nint address);
    /*0x1ffc854*/ T CreateNewReferenceFromIntPtr(nint address);
    /*0x1ffc854*/ void CloneIntoReferenceFromIntPtr(nint address, T other);
    /*0x1ffc854*/ T get_Item(int index);
    /*0x1ffc854*/ void set_Item(int index, T value);
    nint GetBuffer();
    nint GetObjectPtr(int index);
}

class AkChannelEmitterArray : System.IDisposable
{
    /*0x10*/ nint m_Buffer;
    /*0x18*/ nint m_Current;
    /*0x20*/ uint m_MaxCount;
    /*0x24*/ uint <Count>k__BackingField;

    /*0x21425bc*/ AkChannelEmitterArray(uint in_Count);
    /*0x214263c*/ uint get_Count();
    /*0x2142644*/ void set_Count(uint value);
    /*0x214264c*/ void Dispose();
    /*0x21426b8*/ void Finalize();
    /*0x214273c*/ void Reset();
    /*0x214274c*/ void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top, uint in_ChannelMask);
}

class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription>
{
    /*0x2142b08*/ AkDeviceDescriptionArray(int count);
    /*0x2142b60*/ int get_StructureSize();
    /*0x2142bb0*/ void DefaultConstructAtIntPtr(nint address);
    /*0x2142c08*/ AkDeviceDescription CreateNewReferenceFromIntPtr(nint address);
    /*0x2142c68*/ void CloneIntoReferenceFromIntPtr(nint address, AkDeviceDescription other);
}

class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo>
{
    /*0x2142ce4*/ AkDiffractionPathInfoArray(int count);
    /*0x2142d3c*/ int get_StructureSize();
    /*0x2142d8c*/ AkDiffractionPathInfo CreateNewReferenceFromIntPtr(nint address);
    /*0x2142dec*/ void CloneIntoReferenceFromIntPtr(nint address, AkDiffractionPathInfo other);
}

class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
    /*0x2142e68*/ AkExternalSourceInfoArray(int count);
    /*0x2142ec0*/ int get_StructureSize();
    /*0x2142f10*/ void DefaultConstructAtIntPtr(nint address);
    /*0x2142f68*/ void ReleaseAllocatedMemoryFromReferenceAtIntPtr(nint address);
    /*0x2142fc4*/ AkExternalSourceInfo CreateNewReferenceFromIntPtr(nint address);
    /*0x2143024*/ void CloneIntoReferenceFromIntPtr(nint address, AkExternalSourceInfo other);
}

class AkMIDIPostArray
{
    /*0x10*/ int m_Count;
    /*0x14*/ int SIZE_OF;
    /*0x18*/ nint m_Buffer;

    /*0x21430a0*/ AkMIDIPostArray(int size);
    /*0x2143154*/ AkMIDIPost get_Item(int index);
    /*0x2143268*/ void set_Item(int index, AkMIDIPost value);
    /*0x2143354*/ void Finalize();
    /*0x214342c*/ void PostOnEvent(uint in_eventID, UnityEngine.GameObject gameObject);
    /*0x21434ec*/ void PostOnEvent(uint in_eventID, UnityEngine.GameObject gameObject, int count);
    /*0x2143608*/ nint GetBuffer();
    /*0x2143610*/ int Count();
    /*0x2143230*/ nint GetObjectPtr(int index);
}

class AkObjectInfoArray : AkBaseArray<AkObjectInfo>
{
    /*0x2143618*/ AkObjectInfoArray(int count);
    /*0x2143670*/ int get_StructureSize();
    /*0x21436c0*/ void DefaultConstructAtIntPtr(nint address);
    /*0x2143718*/ AkObjectInfo CreateNewReferenceFromIntPtr(nint address);
    /*0x2143778*/ void CloneIntoReferenceFromIntPtr(nint address, AkObjectInfo other);
}

class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
    /*0x21437e0*/ AkObstructionOcclusionValuesArray(int count);
    /*0x2143838*/ int get_StructureSize();
    /*0x2143888*/ void DefaultConstructAtIntPtr(nint address);
    /*0x21438e0*/ AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(nint address);
    /*0x2143940*/ void CloneIntoReferenceFromIntPtr(nint address, AkObstructionOcclusionValues other);
}

class AkPositionArray : System.IDisposable
{
    /*0x10*/ nint m_Buffer;
    /*0x18*/ nint m_Current;
    /*0x20*/ uint m_MaxCount;
    /*0x24*/ uint <Count>k__BackingField;

    /*0x21439a8*/ AkPositionArray(uint in_Count);
    /*0x2143a28*/ uint get_Count();
    /*0x2143a30*/ void set_Count(uint value);
    /*0x2143a38*/ void Dispose();
    /*0x2143aa4*/ void Finalize();
    /*0x2143b28*/ void Reset();
    /*0x2143b38*/ void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top);
}

class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
    /*0x2143ec0*/ AkReflectionPathInfoArray(int count);
    /*0x2143f18*/ int get_StructureSize();
    /*0x2143f68*/ AkReflectionPathInfo CreateNewReferenceFromIntPtr(nint address);
    /*0x2143fc8*/ void CloneIntoReferenceFromIntPtr(nint address, AkReflectionPathInfo other);
}

class AkSourceSettingsArray : AkBaseArray<AkSourceSettings>
{
    /*0x2144030*/ AkSourceSettingsArray(int count);
    /*0x2144088*/ int get_StructureSize();
    /*0x21440d8*/ void DefaultConstructAtIntPtr(nint address);
    /*0x2144130*/ AkSourceSettings CreateNewReferenceFromIntPtr(nint address);
    /*0x2144190*/ void CloneIntoReferenceFromIntPtr(nint address, AkSourceSettings other);
}

class AkTriangleArray : AkBaseArray<AkTriangle>
{
    /*0x21441f8*/ AkTriangleArray(int count);
    /*0x2144250*/ int get_StructureSize();
    /*0x21442a0*/ void DefaultConstructAtIntPtr(nint address);
    /*0x21442f8*/ AkTriangle CreateNewReferenceFromIntPtr(nint address);
    /*0x2144358*/ void CloneIntoReferenceFromIntPtr(nint address, AkTriangle other);
}

class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings
{
    /*0x30*/ AkCommonUserSettings UserSettings;
    /*0x38*/ AkiOSSettings.PlatformAdvancedSettings AdvancedSettings;
    /*0x40*/ AkCommonCommSettings CommsSettings;

    /*0x21443c0*/ AkiOSSettings();
    /*0x2144578*/ AkCommonUserSettings GetUserSettings();
    /*0x2144580*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x2144588*/ AkCommonCommSettings GetCommsSettings();

    class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        /*0x54*/ AkiOSSettings.PlatformAdvancedSettings.Category m_AudioSessionCategory;
        /*0x58*/ AkiOSSettings.PlatformAdvancedSettings.CategoryOptions m_AudioSessionCategoryOptions;
        /*0x5c*/ AkiOSSettings.PlatformAdvancedSettings.Mode m_AudioSessionMode;
        /*0x60*/ uint NumSpatialAudioPointSources;
        /*0x64*/ bool VerboseSystemOutput;

        /*0x2144594*/ PlatformAdvancedSettings();
        /*0x2144590*/ void CopyTo(AkPlatformInitSettings settings);

        enum Category
        {
            Ambient = 0,
            SoloAmbient = 1,
            PlayAndRecord = 2,
            Playback = 3,
        }

        enum CategoryOptions
        {
            MixWithOthers = 1,
            DuckOthers = 2,
            AllowBluetooth = 4,
            DefaultToSpeaker = 8,
        }

        enum Mode
        {
            Default = 0,
            VoiceChat = 1,
            GameChat = 2,
            VideoRecording = 3,
            Measurement = 4,
            MoviePlayback = 5,
            VideoChat = 6,
        }
    }
}

class AkMacSettings : AkWwiseInitializationSettings.PlatformSettings
{
    /*0x30*/ AkCommonUserSettings UserSettings;
    /*0x38*/ AkMacSettings.PlatformAdvancedSettings AdvancedSettings;
    /*0x40*/ AkCommonCommSettings CommsSettings;

    /*0x2144608*/ AkMacSettings();
    /*0x21445f0*/ AkCommonUserSettings GetUserSettings();
    /*0x21445f8*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x2144600*/ AkCommonCommSettings GetCommsSettings();

    class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        /*0x54*/ uint NumSpatialAudioPointSources;
        /*0x58*/ bool VerboseSystemOutput;

        /*0x2144610*/ PlatformAdvancedSettings();
        /*0x214460c*/ void CopyTo(AkPlatformInitSettings settings);
    }
}

class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings
{
    /*0x30*/ AkCommonUserSettings UserSettings;
    /*0x38*/ AkWindowsSettings.PlatformAdvancedSettings AdvancedSettings;
    /*0x40*/ AkCommonCommSettings CommsSettings;

    /*0x2144674*/ AkWindowsSettings();
    /*0x214465c*/ AkCommonUserSettings GetUserSettings();
    /*0x2144664*/ AkCommonAdvancedSettings GetAdvancedSettings();
    /*0x214466c*/ AkCommonCommSettings GetCommsSettings();

    class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        /*0x54*/ uint MaxSystemAudioObjects;

        /*0x214467c*/ PlatformAdvancedSettings();
        /*0x2144678*/ void CopyTo(AkPlatformInitSettings settings);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x21446c8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x21447bc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 7DF0078CF26D135CDB13133FC8FB7E96076CDFDC67AE690FE8BCA60CA49D637F;
    static /*0x1e57*/ <PrivateImplementationDetails> B063BAFD8E287B64B725ED09FC13D57B86DC87E5EB24F8087CD91BD8EC86014D;

    struct __StaticArrayInitTypeSize=3642
    {
    }

    struct __StaticArrayInitTypeSize=7767
    {
    }
}
