using UnityEngine;
using System.Collections;

public class Pipes : MonoBehaviour {

    Thief Player;
    public float Offset;
    PolygonCollider2D pipecollide;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag(Tags.Player).GetComponent<Thief>();
        pipecollide = GameObject.FindGameObjectWithTag(Tags.Obsctacle).GetComponent<PolygonCollider2D>();
    }


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Player.Position - Offset < transform.position.x && Player.Vive100On)
        {
            pipecollide.isTrigger = true;
        }
        else
            pipecollide.isTrigger = false;
	}

}
