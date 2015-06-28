using UnityEngine;
using System.Collections;

public class AmetController : MonoBehaviour {

    public bool back;
    public bool goahead;
    public float topemin;
    public float topemax;
    Pipes pipe;
    public float steps;
    public GameObject gameover;
    float tope = -1f;
    // Use this for initialization

    void Start() {
        back = false;
    }

    // Update is called once per frame
    void Update() {
        //Vector3 position = gameObject.transform.position;
        // position.x += 100;
        // gameObject.transform.position = position;
    }

    void FixedUpdate() {
        AmetMove();

    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player"){
            gameover.active = true;
            Destroy(other);
            NavigationManager.NavigateTo("game_over");
            Debug.Log("End Game");
        }


    }

    void AmetMove() {
        Vector3 position = transform.position;
        if (back) {
            tope = -1f;
            position.x -= 2f * Time.deltaTime;
            transform.position = position;
            if (position.x < topemin) {
                back = false;
            }
        } else if (position.x < topemax) {
            position.x += 0.3f * Time.deltaTime;
            transform.position = position;
        }

        Debug.Log(transform.position.x);
        Debug.Log("Tope: " + tope);
        if (goahead && transform.position.x < tope) {
            movefoward();
        } else if (goahead) {
            tope += steps;
            goahead = false;
        }
    }

    public void movefoward() {
        Vector3 position = transform.position;
        position.x += 0.3f * Time.deltaTime;
        transform.position = position;
    }
}
