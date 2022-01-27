using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Trains;
namespace Stations {
    public class NormalDeliveryStation : MonoBehaviour
    {
        public bool canInteract;
        public List<Task> Tasks;
        private void Start()
        {
            int iter = Random.Range(1, 5);
            for(int i = 0; i < iter; i++)
            {
                Priority questPriority = (Priority)Random.Range(0, 3);
                Station station = (Station)Random.Range(0, 2);
                if()
                Tasks.Add(new Task(questPriority,station,));
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
