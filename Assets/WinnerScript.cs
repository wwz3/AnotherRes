using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerScript : MonoBehaviour
{
    public GameObject text;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.layer == 7)
        //{
            text.SetActive(true);
            //GetComponent<Text> ().color = Color.black;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        text.SetActive(false); 
        Destroy(cube);
    }
}
