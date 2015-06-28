using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class StartMenu : MonoBehaviour {

    public Button startButton;

	// Use this for initialization
	void Awake () {
        startButton = GetComponent<Button>();
        //startButton.onClick.AddListener();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadGame() {
        NavigationManager.NavigateTo("main");
    }
}
