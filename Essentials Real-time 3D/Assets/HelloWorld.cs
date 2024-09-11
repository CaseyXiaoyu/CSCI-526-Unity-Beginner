using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public string myMessage;



    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log(myMessage);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
