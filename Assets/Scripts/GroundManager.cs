using Config;
using UnityEngine;
public class GroundManager : MonoBehaviour
{
    [SerializeField] GroundConfig gconfig;
    [SerializeField] static GroundConfig sgconfig;
    GameObject player;
    [SerializeField] GameObject startTile;
    static int addDist = 100;
    [SerializeField] Vector3 apos => pos;
    static Vector3 pos;
    private void Start()
    {
        sgconfig = gconfig;
        //  localtiles.Add(startTile);
        player = GameObject.FindGameObjectWithTag("Player");//prawdopodobnie bêdê musia³ to zminiæ na identyfikator sieciowy gracza
        for (int i = 0; i < 6; i++)
        {
            spawn();
        }
    }
    public static void spawn()
    {
        if (sgconfig != null)
        {
            pos += new Vector3(addDist, 0);
            GameObject tile = Instantiate(sgconfig.Grounds[Random.Range(0, sgconfig.Grounds.Length)], pos, Quaternion.identity);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            spawn();
        }

    }



}
