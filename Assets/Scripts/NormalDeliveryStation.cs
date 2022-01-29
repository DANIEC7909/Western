using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Trains;
using T3Z.UIController;
namespace Stations {
    public class NormalDeliveryStation : MonoBehaviour,IInteractable
    {
        public bool canInteract,isInteracting;
        public List<Task> Tasks=new List<Task>();
        private void Start()
        {
            int iter = Random.Range(1, 5);
            for(int i = 0; i < iter; i++)
            {
                Priority questPriority = (Priority)Random.Range(0, 3);
                Station station = (Station)Random.Range(0, 2);
                int price = 0;
                switch (questPriority)
                {
                    case Priority.Low:
                        price = Random.Range(50, 100);
                        break;
                    case Priority.Medium:
                        price = Random.Range(160, 250);
                        break;
                    case Priority.High:
                        price = Random.Range(250, 390);
                        break;
                    case Priority.VeryHigh:
                        price = Random.Range(390, 550);
                        break;
                    case Priority.Mayhem:
                        price = Random.Range(550, 700);
                        break;
                }

                Tasks.Add(new Task(questPriority,station,price));
            }
            Debug.LogWarning("Generated " + Tasks.Count + " Tasks");
        }
        private void Update()
        {
            if (isInteracting)
            {

            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Train"))
            {
                Debug.LogWarning("Welcome to station");
                if (other.transform.parent.GetComponentInParent<TrainControllerNonPhysics>().Handbrake)
                {
                    canInteract = true;
                }
            }
           
        }

        public void Use(Player playerSender)
        {
            if (canInteract)
            {
                isInteracting = !isInteracting;
                playerSender.UIStation.SetActive(isInteracting);
                playerSender.UIStation.GetComponent<StationQuestUICotroller>().Init(Tasks);
            }
        }

    } 
}
