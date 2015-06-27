using UnityEngine;
using System.Collections;

public class PropController : MonoBehaviour {

    private bool isVisible = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Renderer>().isVisible)
            isVisible = true;
        if (isVisible && !GetComponent<Renderer>().isVisible)
            Destroy(gameObject);
	}
}