using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Config;
using Trains;
public class Player : MonoBehaviour
{
    public static Player _player;
    #region
    public GameObject UIStation;
    #endregion
    Rigidbody rb;
    public List<Task> PlayerTask = new List<Task>();
   [SerializeField] PlayerConfig config;
    [SerializeField] FirstPersonLook CameraLookObj;
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
        Debug.Log(PlayerTask.Count);
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
                other.GetComponent<IInteractable>().Use(this);
                CameraLookObj.enabled = !CameraLookObj.enabled;
                if (CameraLookObj.enabled)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = true;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.None;
                Cursor.visible = false;
                }
            }
        }
    }
 
}
