﻿using GGXrdReversalTool.Library.Memory;

namespace GGXrdReversalTool.Library.Scenarios.Event;

public interface IScenarioEvent
{
    IMemoryReader MemoryReader { get; internal set; }
    ScenarioEventTypes CheckEvent();
}