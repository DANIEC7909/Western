using UnityEngine;
namespace Config
{
    [CreateAssetMenu(fileName = "GroundData", menuName = "Configs/Ground", order = 1)]
    public class GroundConfig : ScriptableObject
    {
        public GameObject[] Grounds;
        public float distanceToClearTiles = 200;//depends on how long is train and all wagonetas 
    }
}