using UnityEngine;

public class Tresure : MonoBehaviour
{
    public int TresureCount;
    public int hp;
    public enum Type { Draggable, Loose, Liquid }
    public Type TransportType;
    public enum Importance { Low, Medium, Hight, VeryHight }
    public Importance CargoImportance;
}
