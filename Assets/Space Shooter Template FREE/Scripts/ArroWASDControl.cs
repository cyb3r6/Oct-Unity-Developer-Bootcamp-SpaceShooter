using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArroWASDControl : MonoBehaviour
{
    [SerializeField]
    float speed = 0.1f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.up*speed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * speed);
        }
    }
}
