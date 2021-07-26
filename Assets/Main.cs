using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        GameObject[] myObjArray;
        myObjArray = GameObject.FindGameObjectsWithTag("Default");

        foreach (GameObject obj in myObjArray)
        {
            obj.AddComponent<Click>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
