using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {
    int numBG = 6;
    float size = 13.3f;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D collider) {
        //Debug.Log ("The trigger name is:" + collider.name);
        float widthBGCollider = 0;
        Vector3 pos = collider.transform.position;
        switch (collider.tag) {
            case Tags.Street:
                widthBGCollider = ((BoxCollider2D)collider).size.x;
                pos.x += widthBGCollider * numBG - 0.14f;
                collider.transform.position = pos;
                break;
            case Tags.houses:
                pos.x += size - 0.14f - 0.68f;
                collider.transform.position = pos;
                break;
            default:
                Destroy(collider.gameObject);
                break;
        }

       
    }
}
