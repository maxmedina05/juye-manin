using UnityEngine;
using System.Collections;

public class AmetController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
       //Vector3 position = gameObject.transform.position;
       // position.x += 100;
       // gameObject.transform.position = position;
	}

    void FixedUpdate(){

    }

    void OnTriggerEnter2D(Collider2D other) {

        NavigationManager.NavigateTo("game_over");
        Debug.Log("End Game");
    }
}
