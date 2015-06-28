using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    public GameObject amet;
    AmetController controlamet;

    // Use this for initialization
    void Start() {
        amet = GameObject.FindGameObjectWithTag(Tags.amet);
        controlamet = GameObject.FindGameObjectWithTag(Tags.amet).GetComponent<AmetController>();
    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate() {


    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == Tags.Player) {
            controlamet.back = true;
            //Debug.Log("Go away");
            //Vector3 position = amet.transform.position;
            //if (position.x > tope)
            //{
            //    position.x -= 40f*Time.deltaTime;
            //    amet.gameObject.transform.position = position;
            //}
           Destroy(gameObject);
        }
    }
}
