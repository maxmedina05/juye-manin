using UnityEngine;
using System.Collections;

public class StreetSpeed : MonoBehaviour
{
    public float world_velocity = 7f;
   // Rigidbody2D Player;

    // Use this for initialization
    void Start()
    {

    }
    void FixedUpdate()
    {
        transform.position += Vector3.right * -world_velocity * Time.deltaTime;
    }

}
