using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject prefab;
    float speed = -3.0f;
    GameObject ninjaObj;
    public float minSpawnTime = 0.75f;
    public float maxSpawnTime = 2f;

	// Use this for initialization
	void Start () {
        Invoke("SpawnObstacle", minSpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnObstacle() {
        // 1
        Camera camera = Camera.main;
        Vector3 cameraPos = camera.transform.position;
        float xMax = camera.aspect * camera.orthographicSize;
        float xRange = camera.aspect * camera.orthographicSize * 1.75f;
        float yMax = camera.orthographicSize - 0.5f;
        // 2
        Vector3 catPos =
          new Vector3(cameraPos.x + Random.Range(xMax - xRange, xMax),
                      Random.Range(-yMax, yMax),
                      prefab.transform.position.z);
        Instantiate(prefab, catPos, Quaternion.identity);

        Invoke("SpawnObstacle", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
