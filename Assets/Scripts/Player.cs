using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Config;
using Trains;
public class Player : MonoBehaviour
{
    public static Player _player;
    Rigidbody rb;
    public List<Task> PlayerTask = new List<Task>();
   [SerializeField] PlayerConfig config;
    void Awake()
    {
        _player = this;
    }

    void FixedUpdate()
    {
        if (!TrainController.isMounted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
             
            }
            else
            {

            }
            if (Input.GetKey(KeyCode.W))
            {
            
            }
            else
            {

            }
            if (Input.GetKey(KeyCode.S))
            {
             
             
            }
            else
            {

            }
            if (Input.GetKey(KeyCode.A))
            {
            
              
            }
            else
            {

            }
            if (Input.GetKey(KeyCode.D))
            {
             

            }
            else
            {

            }
        }
    }
               

    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Train")||other.CompareTag("Wagon"))
        {
      
        }
        if (other.CompareTag("Station"))
        {
            if (Input.GetButtonDown("Use"))
            {
                other.GetComponent<IInteractable>().Use(this.gameObject);
            }
        }
    }
 
}
