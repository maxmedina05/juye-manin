using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
    public GameObject prefab;
    public float minSpawnTime = 0.75f;
    public float maxSpawnTime = 3f;

	// Use this for initialization
	void Start () {
        Invoke("SpawnObstacle", minSpawnTime);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void SpawnObstacle() {

        Vector3 pos = new Vector3(6.75f, -0.943f, 0);
        GameObject obstacle = Instantiate(prefab, pos, Quaternion.identity) as GameObject;

        Invoke("SpawnObstacle", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
