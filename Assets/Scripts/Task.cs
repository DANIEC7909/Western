using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Task
{

    public int price;
    
    public Station stationToPass;
    public Priority taskPriority;
    public CargoType cargoType;

    public Task(Priority taskPriority_, Station stationPass_, int price_,CargoType cargoType_)
    {
        price = price_;
        stationToPass = stationPass_;
        taskPriority = taskPriority_;
        cargoType = cargoType_;
    }
}

public enum Station
{
    Tombstone_Arizona, VirginiaCity_Nevada, Deadwood_SouthDakota
}
public enum Priority
{
    Low,Medium,High,VeryHigh,Mayhem
}
public enum CargoType
{
    MoneyBags,None
}
