﻿namespace StricterJudge;

public sealed partial class Main : MelonMod
{
    public override void OnInitializeMelon()
    {
        Load();
        LoggerInstance.Msg("StricterJudge has loaded correctly!");
    }
}