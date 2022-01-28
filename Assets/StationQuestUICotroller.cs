using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace T3Z.UI
{
    public class StationQuestUICotroller : MonoBehaviour
    {
        public List<Task> Tasks = new List<Task>();
        [SerializeField] Transform rootGameObject;
        [SerializeField] GameObject UIQuestRef;

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
                    Button bt= go.transform.GetChild(8).GetComponent<Button>();
                  //  bt.onClick+=TakeQuest()//it should automatically assign id to button

                }
            }
        }
       public void TakeQuest(int id) {
        }

    }
}
