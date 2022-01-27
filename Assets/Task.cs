using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Task
{
    public bool isHealthMatters;
    public int minimalCountToPass;
    public int price;
    
    public Station stationToPass;
    public Priority taskPriority;

    public Task(Priority taskPriority_, Station stationPass_, int price_, bool isHealthMatters_=false, int minimalCountToPass_=1)
    {
        isHealthMatters = isHealthMatters_;
        minimalCountToPass = minimalCountToPass_;
        price = price_;
        stationToPass = stationPass_;
        taskPriority = taskPriority_;
    }
}

public enum Station{
    Tombstone_Arizona, VirginiaCity_Nevada, Deadwood_SouthDakota
}
public enum Priority
{
    Low,Medium,High,VeryHigh,Mayhem
}