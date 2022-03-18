using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Configs/Player", order = 1)]
public class PlayerConfig : ScriptableObject
{
    public float speed;
    public int hp;
    public float jumpForce;


}
