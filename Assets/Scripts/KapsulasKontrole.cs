using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.frameCount % 60 == 0) // kods, lai nosacijums izpildas ik pec 60 kadriem https://forum.unity.com/threads/coroutine-wait-x-frames-not-seconds.550168/
        {
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            rend.material.color = newColor;
        }
    }
}
