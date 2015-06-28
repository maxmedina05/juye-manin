using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Again(){
        NavigationManager.NavigateTo("main");
    }

    public void toMenu(){
        NavigationManager.NavigateTo("start_screen");
    }
}
