﻿using UnityEngine;

[System.Serializable]
public class IntersectionExit
{
    public BasicLane[] nextLane;
    public int nextIntersectionIndex;
}

public class IntersectionLane : Lane
{
    [SerializeField]
    private IntersectionExit[] intersectionExits;
    [SerializeField]
    private int IntersectionIndex;

    public override Transform End
    {
        get
        {
            return null;
        }
    }

    public override Lane Next
    {
        get
        {
            return null;
        }
    }

    public BasicLane GetIntersectionExit(int nextIntersection, Transform carPosition)
    {
        foreach (IntersectionExit i in intersectionExits)
            if (i.nextIntersectionIndex == nextIntersection && carPosition.forward + i.nextLane[Random.Range(0, i.nextLane.Length)].End.transform.forward != Vector3.zero)
                return i.nextLane[Random.Range(0,i.nextLane.Length)];

        return intersectionExits[0].nextLane[0];
    }

    public int GetIndex()
    {
        return IntersectionIndex;
    }
}