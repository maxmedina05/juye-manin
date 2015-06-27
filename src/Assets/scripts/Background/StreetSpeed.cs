using UnityEngine;
using System.Collections;

public class StreetSpeed : MonoBehaviour
{

   // Rigidbody2D Player;

    // Use this for initialization
    void Start()
    {

    }
    void FixedUpdate()
    {
        float vel = -2f;
        transform.position += Vector3.right * vel * Time.deltaTime;
    }

}
