using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum EventType
{
    Pause,
    Resume,
}

public enum StepNames
{
    CPU,
    CPUHeatSink,
    Memory,
    SSD,
    MotherBoard,
    ATX,
    Jumper,
    GPU,
}

