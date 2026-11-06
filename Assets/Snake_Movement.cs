using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake_Movement : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
