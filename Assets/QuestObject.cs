using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using T3Z.UIController;
public class QuestObject : MonoBehaviour
{
    public int id;
    [HideInInspector]
    public StationQuestUICotroller uICotroller;
    public void AssignQuest ()
        {
        uICotroller.TakeQuest(id);
        }


}
