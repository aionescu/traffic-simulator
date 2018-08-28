﻿using UnityEngine;

public abstract class Lane : MonoBehaviour
{
    public abstract Transform End { get; }

    public abstract Lane Next { get; }

    public abstract void SetNextLane(Lane lane);
}