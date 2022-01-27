using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Trains;
namespace Stations {
    public class NormalDeliveryStation : MonoBehaviour
    {
        public bool canInteract;
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
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Train"))
            {
                Debug.LogWarning("Welcome to station");
                if (other.GetComponent<TrainControllerNonPhysics>().Handbrake)
                {
                    canInteract = true;
                }
            }
           
        }
    } 
}
