﻿namespace Figures;

public interface ITriangle
{
    int SideA { get; }
    int SideB { get; }
    int SideC { get; }
    bool IsRight();
}