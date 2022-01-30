using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Stations;
namespace T3Z.UIController
{
    public class StationQuestUICotroller : MonoBehaviour
    {
        public Task[] Tasks;
        public GameObject[] TasksGo;
        [SerializeField] Transform rootGameObject;
        [SerializeField] GameObject UIQuestRef;
        [SerializeField] Player player;
        public  NormalDeliveryStation currentStation;
        bool generated=true;
        public void Init(List<Task> Tasks_)
        {
            Tasks = Tasks_.ToArray();
            Debug.LogWarning("Loaded " + Tasks.Length + " Tasks");
        }
        private void Update()
        {
            if (Tasks != null)
            {
                if (generated)
                {
                    List<GameObject> questsobj=new List<GameObject>();
                    if (TasksGo.Length < Tasks.Length)
                        for (int i = 0; i < Tasks.Length; i++)
                        {
                            GameObject go = Instantiate(UIQuestRef, rootGameObject.transform);

                            QuestObject qo = go.GetComponent<QuestObject>();
                            TasksGo = new GameObject[Tasks.Length];
                            qo.name.text = "Quest number:" + i;
                            qo.price.text = Tasks[i].price.ToString();
                            qo.endstation.text = Tasks[i].stationToPass.ToString();
                            qo.priority.text = Tasks[i].taskPriority.ToString();
                            qo.uICotroller = this;
                            qo.id = i;
                            questsobj.Add(go);
                        }
                    TasksGo = questsobj.ToArray();
                    generated = false;
                }
            }
        }
       public void TakeQuest(int id) {
            player.PlayerTask.Add(Tasks[id]);
            Destroy(TasksGo[id]);
            TasksGo[id] = null;
        }

    }
}

