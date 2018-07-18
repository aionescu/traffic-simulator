﻿using System.Collections.Generic;
using UnityEngine;

public class IntersectionLane : Lane
{

    [SerializeField]
    private List<Lane> possibleNextLanes = new List<Lane>();
    [SerializeField]
    private List<GameObject> possibleEndLanes = new List<GameObject>();
    private int nextIndex;

    private void Awake()
    {
        nextIndex = Random.Range(0, possibleNextLanes.Count);
    }

    public override Transform End
    {
        get
        {
            return possibleEndLanes[nextIndex].transform;
        }
    }

    public override Lane Next
    {
        get
        {
            
            return possibleNextLanes[nextIndex];
        }
    }
}
