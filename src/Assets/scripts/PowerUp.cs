using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour{

    public GameObject amet;
    public float tope =
	// Use this for initialization
	void Start () {
        amet = GameObject.FindGameObjectWithTag("Amet");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            Debug.Log("Go away");

            Vector3 position = amet.transform.position;
            if (position.x > tope){
                position.x -= 2f;
                amet.gameObject.transform.position = position;
            }
        }
    }
}
