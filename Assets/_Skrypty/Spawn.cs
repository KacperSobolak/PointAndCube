using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public Transform[] spawnpoint;
    public float SpawnTime = 1.5f;
    public GameObject punkt;

	void Start () {
        InvokeRepeating("SpawnPunkty", SpawnTime, SpawnTime);
	}

	void Update () {
	
	}

    void SpawnPunkty()
    {
        int spawnindex = Random.Range(0, spawnpoint.Length);

        //SpawnTime -= 
        
        Instantiate(punkt, spawnpoint[spawnindex].position, spawnpoint[0].rotation);
    }
}
