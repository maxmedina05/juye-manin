using UnityEngine;
using System.Collections;

public class oldLady : MonoBehaviour {

	// Use this for initialization
    public Vector2 velocity;
    private Vector3 position;
    Animator anim;
	void Start () {
        
	
	}
	
	// Update is called once per frame
    void Update() {
        gameObject.transform.Translate(-Vector3.right * Time.deltaTime);
        gameObject.transform.Translate(-Vector3.up * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter2D(Collision2D coll){
        if  (coll.gameObject.tag == "Player"){
            Debug.Log("Chocaron");
            anim.SetTrigger("collision");
            
        }
    }
}
