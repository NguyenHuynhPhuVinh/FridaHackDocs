class <Module>
{
}

struct NimbleBridge_NexusPersona
{
    /*0x10*/ string anonymousPlayerKey;
    /*0x18*/ string personaId;
    /*0x20*/ string pidId;
    /*0x28*/ string name;
    /*0x30*/ string displayName;
    /*0x38*/ string nickName;
    /*0x40*/ string namespaceName;
    /*0x48*/ bool isVisible;
    /*0x50*/ string status;
    /*0x58*/ string statusReasonCode;
    /*0x60*/ string privacyLevel;
    /*0x68*/ string dateCreated;
    /*0x70*/ string lastAuthenticated;
    /*0x78*/ SimpleJSON.JSONNode personaProperties;

    /*0x2bc5cd8*/ string ToString();
}
