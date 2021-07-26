using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        gameObject.AddComponent<BoxCollider>();
        //GameObject objo = GameObject.FindWithTag("Untagged");
        //GameObject[] myObjArray;
        //myObjArray = GameObject.FindGameObjectsWithTag("Untagged");

        //foreach (GameObject obj in myObjArray)
        //{
        //    obj.AddComponent<Click>();
        //    obj.AddComponent<BoxCollider>();
        //}

    }

    private void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    //RaycastHit hit;
        //    //// Casts the ray and get the first game object hit
        //    //Physics.Raycast(ray, out hit);
        //    //print("11111" + hit.point);
        //    var outline = gameObject.AddComponent<Outline>();

        //    outline.OutlineMode = Outline.Mode.OutlineAll;
        //    outline.OutlineColor = Color.white;
        //    outline.OutlineWidth = 5f;

        //    //GetComponent<Renderer>().material.color = new Color(165, 5, 5, 255);
        //}
    }

    void OnMouseDown()
    {
        //Destroy(GameObject.FindWithTag("Selected").GetComponent<Outline>);
        GameObject preObj = GameObject.FindWithTag("Selected");
        if (preObj)
        {
            Outline preObjCom = preObj.GetComponent<Outline>();
            Destroy(preObjCom);
            preObj.tag = "UnSelected";
        }

        //if (GameObject.FindWithTag("Outline"))
        //{
        //    Destroy(GameObject.FindWithTag("Outline"));
        //}
        //GetComponent<Outline>().gameObject.SetActive(false);

        var outline = gameObject.AddComponent<Outline>();

        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.white;
        outline.OutlineWidth = 5f;

        gameObject.tag = "Selected";
    }

    //void OnMouseUp()
    //{
    //    print("Mouse is up");
    //}

    void OnMouseClick()
    {
        print("Mouse is clicked (down then up its 1 click)");
    }

    //void OnMouseEnter()
    //{
    //    GetComponent<Renderer>().material.color = new Color(165, 5, 5, 255);
    //}
    //void OnMouseExit()
    //{
    //    GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
    //}

    //void OnGUI()
    //{
    //    if (Event.current != null && Event.current.type == EventType.MouseDown)
    //    {
    //        Debug.Log("EventType.mouseDown response");
    //    }
    //}
}
