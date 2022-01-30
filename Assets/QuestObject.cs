using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using T3Z.UIController;
using TMPro;

public class QuestObject : MonoBehaviour
{
    public int id;
    [HideInInspector]
    public StationQuestUICotroller uICotroller;
    public Task thisQust;
   public  TextMeshProUGUI name  ;
   public  TextMeshProUGUI priority  ;
   public  TextMeshProUGUI price ;
    public TextMeshProUGUI endstation  ;
 
    public void AssignQuest ()
        {
        uICotroller.TakeQuest(id);
        }


}
