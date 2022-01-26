using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Config;
namespace Trains
{
    public class TrainController : MonoBehaviour
    {
        int waterCount;
        [SerializeField] TrainConfig config;
        Rigidbody rb;
        [SerializeField] float speed;
        public static bool isMounted;
     
        [SerializeField]bool isPlayerIsOnTheTrain, Handbrake;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            //  speed = config.speed;
        }
        private void FixedUpdate()
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        void Update()
        {
            if (isPlayerIsOnTheTrain)
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    isMounted = !isMounted;
                }
            }
             else
            {
                    isMounted = false;
                }


                if (Handbrake)
                {
                    rb.constraints = RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezePositionY|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationZ;
                }
                else
                {
                    rb.constraints = ~RigidbodyConstraints.FreezePositionX;
                }

                if (isMounted)
                {
                    Debug.Log("Player Mounted into Train");
                if (speed >= 0 && speed < 0.5f)
                {
                    if (Input.GetKeyDown(KeyCode.B))
                    {
                        Handbrake = !Handbrake;
                    }
                }
                    if (Input.GetKey(KeyCode.W))
                    {
                        speed = Mathf.SmoothStep(speed, config.speed, Time.deltaTime);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        speed = Mathf.SmoothStep(speed, 0, Time.deltaTime);
                    }
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        if (Input.GetKey(KeyCode.W))
                        {
                            speed = Mathf.SmoothStep(speed, config.speed, Time.deltaTime * config.accelerationForce);
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            speed = Mathf.SmoothStep(speed, -config.speed, Time.deltaTime * config.breakingForce);
                        }
                    }
                    if (Input.GetKey(KeyCode.Space))
                    {
                        rb.drag = 5;
                        speed = 0;
                    }
                    else
                    {
                        rb.drag = 0;
                    }
                }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                isPlayerIsOnTheTrain = true;

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                isPlayerIsOnTheTrain = false;
            }
        }
    }
}
