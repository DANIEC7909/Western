using System.Collections.Generic;
using Trains;
using UnityEngine;
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
    Camera camera;
    public FixedJoint hand;
    void Awake()
    {
        _player = this;
        camera = Camera.main;
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
        if (Input.GetButton("Fire1"))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.GetComponent<Rigidbody>() != null)
                {
                    hand.connectedBody = hit.transform.GetComponent<Rigidbody>();
                }
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            hand.connectedBody = null;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Train") || other.CompareTag("Wagon"))
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
