using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zigzag : MonoBehaviour
{

    [Tooltip("Zigzag speed on X axis in local space")]
    public float speed = 15;


    //moving the object with the defined speed
    private void Update()
    {
        transform.Translate(new Vector3(10,0,0) * Mathf.Sin(Time.time * speed) * Time.deltaTime);
    }
}
