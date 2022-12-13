using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    public float speed = 40.0f;
    public Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //https://answers.unity.com/questions/641200/rotate-on-z-axis.html
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 0, -speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, 0, speed * Time.deltaTime);


        // https://answers.unity.com/questions/1416684/rotate-an-object-with-keyboard.html
        if (Input.GetKey(KeyCode.UpArrow))
            transform.RotateAround(point, Vector3.right, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.RotateAround(point, Vector3.left, speed * Time.deltaTime);
    }
}
