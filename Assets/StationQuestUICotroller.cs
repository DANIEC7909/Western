using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace T3Z.UIController
{
    public class StationQuestUICotroller : MonoBehaviour
    {
        public List<Task> Tasks = new List<Task>();
        public List<GameObject> TasksGo = new List<GameObject>();
        [SerializeField] Transform rootGameObject;
        [SerializeField] GameObject UIQuestRef;
        [SerializeField] Player player;
        private void Init(List<Task> Tasks_)
        {
            Tasks = Tasks_;
        }
        private void Update()
        {
            if (Tasks != null)
            {
                for (int i = 0; i < Tasks.Count; i++)
                {
                   GameObject go= Instantiate(UIQuestRef, rootGameObject.transform);
                    //1,3,5,7 .b8
                    TextMeshProUGUI name =go.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI priority=go.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI price = go.transform.GetChild(5).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI endstation = go.transform.GetChild(6).GetComponent<TextMeshProUGUI>();
                    QuestObject qo = go.GetComponent<QuestObject>();
                    qo.id = i;
                    TasksGo.Add(go);
                }
            }
        }
       public void TakeQuest(int id) {
            player.PlayerTask.Add(Tasks[id]);
            Destroy(TasksGo[id]);
            TasksGo.Remove(TasksGo[id]);
        }

    }
}
