using UnityEngine;
using System.Collections;

public class TestSpawn : MonoBehaviour
{

    public Transform sp;
    public float st = 1.5f;
    public GameObject p;
    public Vector2 size, center;

    void Start()
    {
        InvokeRepeating("SpawnPunkty", st, st);
    }

    void Update()
    {

    }

    void SpawnPunkty()
    {
        Vector2 position = center + new Vector2(Random.Range(-size.x/2, size.x/2), 9);
        //SpawnTime -= 

        Instantiate(p, position, sp.rotation);
    }
}
