using UnityEngine;
using System.Collections;

public class randomvive : MonoBehaviour {

    public GameObject viveprefab;
    float pertime = 1f;

    public float time = 5f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate() {

        time -= Time.deltaTime;
        if (time < 0) {
            Vector3 pos = new Vector3(6.75f, -0.843f, 0);
            GameObject obstacle = Instantiate(viveprefab, pos, Quaternion.identity) as GameObject;
            pertime += 0.2f;
            time = time * pertime;
        }
    }
}
