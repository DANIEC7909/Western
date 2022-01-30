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
        private bool isStationInitializedInSQUIC;

        private void Start()
        {
            int iter = Random.Range(1, 5);
            for(int i = 0; i < iter; i++)
            {
                Priority questPriority = (Priority)Random.Range(0, 3);
                Station station = (Station)Random.Range(0, 2);
                CargoType cargoType=CargoType.None;
                int price = 0;
                switch (questPriority)
                {
                    case Priority.Low:
                        price = Random.Range(50, 100);
                        cargoType = CargoType.MoneyBags;//Random MB and something else 
                        break;
                    case Priority.Medium:
                        price = Random.Range(160, 250);
                        cargoType = CargoType.MoneyBags;//temp
                        break;
                    case Priority.High:
                        price = Random.Range(250, 390);
                        cargoType = CargoType.MoneyBags;//temp
                        break;
                    case Priority.VeryHigh:
                        price = Random.Range(390, 550);
                        cargoType = CargoType.MoneyBags;//temp
                        break;
                    case Priority.Mayhem:
                        price = Random.Range(550, 700);
                        cargoType = CargoType.MoneyBags;//temp
                        break;
                }

                Tasks.Add(new Task(questPriority,station,price,cargoType));
                Debug.Log(Tasks[i].stationToPass);
                Debug.Log(Tasks[i].taskPriority);
                Debug.Log(Tasks[i].price);
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
                if (isStationInitializedInSQUIC==false)
                {
                    isStationInitializedInSQUIC = true;
                    playerSender.UIStation.GetComponent<StationQuestUICotroller>().Init(Tasks);
                }
            }
        }

    } 
}
