using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = transform.position + Vector3.back;
    }
}
