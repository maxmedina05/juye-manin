using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour
{
    int numBG = 6;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == Tags.Street)
        {
            //Debug.Log ("The trigger name is:" + collider.name);
            float widthBGCollider = 0;
            widthBGCollider = ((BoxCollider2D)collider).size.x;
            Vector3 pos = collider.transform.position;
            pos.x += widthBGCollider * numBG-0.14f;
            collider.transform.position = pos;
        }

        if (collider.tag == Tags.Obsctacle) {
           Destroy(collider.gameObject);
        }
    }
}
