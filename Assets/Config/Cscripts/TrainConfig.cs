using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Config
{
    [CreateAssetMenu(fileName = "TainData", menuName = "Configs/Train", order = 1)]
    public class TrainConfig : ScriptableObject
    {
        public float speed;
        public int hp;
        public int maxWaterCount;
        public int maxCoalCount;
        public float breakingForce;
        public float accelerationForce;

    }
}