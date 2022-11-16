using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        var movementDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
