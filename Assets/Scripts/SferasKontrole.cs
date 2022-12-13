using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SferasKontrole : MonoBehaviour
{
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kapsula"))
        {
            other.gameObject.SetActive(false);
        }
        winText.text = "Tu uzvarçji!";

    }
}
