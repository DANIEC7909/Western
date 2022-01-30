using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Config {
    [CreateAssetMenu(fileName = "StationData", menuName = "Configs/Station", order = 1)]
    public class StationConfig : ScriptableObject
    {
        #region Tresures
        #region Moneybag
        public GameObject MoneyBag;
        public int AmountInLowPriority;
        public int AmountInMediumPriority;
        public int AmountInHighPriority;
        public int AmountInVeryHighPriority;
        public int AmountInMayhemPriority;
        #endregion
        #endregion
    }
}
