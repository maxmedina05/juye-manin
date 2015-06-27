using UnityEngine;
using System.Collections;

public class Controllers : MonoBehaviour
{
    public KeyCode Jump_Key = KeyCode.Space;
    public bool JumpTime;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        chk_controllers();
    }

    void chk_controllers()
    {
        if (Input.GetKeyDown(Jump_Key))
            JumpTime = true;
        else
            JumpTime = false;
    }
}
