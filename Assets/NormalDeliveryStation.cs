using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Trains;
namespace Stations {
    public class NormalDeliveryStation : MonoBehaviour
    {
        public bool canInteract;
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
