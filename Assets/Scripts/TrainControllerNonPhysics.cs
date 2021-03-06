using Config;
using UnityEngine;
namespace Trains
{
    public class TrainControllerNonPhysics : MonoBehaviour
    {
        int waterCount;
        [SerializeField] TrainConfig config;
        Rigidbody rb;
        [SerializeField] float speed;
        /// <summary>
        /// This Variable is a multiplier of train speed.
        /// </summary>
        [SerializeField] float lspeed;
        public static bool _IsMounted;

        [SerializeField] bool isPlayerIsOnTheTrain;
        public bool Handbrake;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
    
        }
        private void FixedUpdate()
        {
            float actualForceType = Input.GetKey(KeyCode.Space) ? config.breakingForce : config.accelerationForce;

            lspeed = Mathf.Lerp(lspeed, speed, Time.deltaTime * actualForceType);

            transform.position += Vector3.right * Time.deltaTime * lspeed;
        }

        void Update()
        {
            if (isPlayerIsOnTheTrain)
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    _IsMounted = !_IsMounted;
                }
            }

            if (Handbrake)
            {
                lspeed = speed = 0;
            }

            if (_IsMounted)
            {
                if (speed < 1)
                {
                    if (Input.GetKeyDown(KeyCode.B))
                    {
                        Handbrake = !Handbrake;
                    }
                }
                if (Input.GetKey(KeyCode.Space))
                {
                    speed = Mathf.SmoothStep(speed, 0, Time.deltaTime * config.breakingForce);
                    if (speed < 1)
                    {
                        Handbrake = true;
                    }
                }
                if (Input.GetKey(KeyCode.W))
                {
                    speed = Mathf.SmoothStep(speed, config.speed, Time.deltaTime * config.accelerationForce);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    speed = Mathf.SmoothStep(speed, 0, Time.deltaTime * config.accelerationForce);
                }

            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                other.transform.parent = transform;
                isPlayerIsOnTheTrain = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                other.transform.parent = null;
                isPlayerIsOnTheTrain = false;
                _IsMounted = false;
            }
        }
    }

}