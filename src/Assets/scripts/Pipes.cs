using UnityEngine;
using System.Collections;

public class Pipes : MonoBehaviour {

    Thief Player;
    AmetController amet;
    public float Offset;
    PolygonCollider2D pipecollide;

    public float[] tope;
    public float steps;
    float asa;
    int pos = 0;
    void Awake() {
        Player = GameObject.FindGameObjectWithTag(Tags.Player).GetComponent<Thief>();
        pipecollide = GameObject.FindGameObjectWithTag(Tags.Obsctacle).GetComponent<PolygonCollider2D>();
        amet = GameObject.FindGameObjectWithTag(Tags.amet).GetComponent<AmetController>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == Tags.Player && !amet.back) {
            amet.goahead = true;
            //Vector3 position = amet.transform.position;
            //position.x += 25f*Time.deltaTime;
            //amet.transform.position = position;
        }
    }





    // Use this for initialization
    //void Start () 
    //{

    //}

    //// Update is called once per frame
    //void Update () 
    //{
    //    if(Player.Position - Offset < transform.position.x && Player.Vive100On)
    //    {
    //        pipecollide.isTrigger = false;
    //    }
    //    else
    //        pipecollide.isTrigger = true;
    //}

}
