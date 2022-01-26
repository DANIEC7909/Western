using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Config;
public class TileController : MonoBehaviour
{
  [SerializeField]  GroundConfig groundConfig;
    GameObject player;
   [SerializeField] float distance;
    bool isEntered;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if (isEntered)
        {
            if (Vector3.Distance(transform.position, player.transform.position) >= groundConfig.distanceToClearTiles)
            {
                GroundManager.spawn();

                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            isEntered = true;
            Debug.Log("Train Ariverd to " + name);
        }
    }
}
