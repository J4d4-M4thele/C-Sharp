﻿namespace Packt.Shared;

[Flags]
//decorating the enum type with the System.Flags attribute allows Program.cs
//to automatically match with multiple values as a comma-separated string instead of
//returning an int value.
public enum WondersOfTheAncientWorld : byte
{
    None = 0b_0000_0000, //0
    GreatPyramidOfGiza = 0b_0000_0001,//1
    HangingGardensOfBabylon = 0b_0000_0010,//2
    StatueOfZeusAtOlympia = 0b_0000_0100,//4
    TempleOfArtemisAtEphesus = 0b_0000_1000,//8
    MausoleumAtHalicarnassus = 0b_0001_0000,//16
    ColossusOfRhodes = 0b_0010_0000,//32
    LighthouseOfAlexandria = 0b_0100_0000//64
}
