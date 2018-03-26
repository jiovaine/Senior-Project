using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falchion : MonoBehaviour
{
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

   

    private void OnMouseEnter()
    {
        Debug.Log("Hello");
    }

    private void OnMouseExit()
    {
        Debug.Log("Goodbye");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.parent = player.transform;
            transform.localPosition = new Vector3(1, 0.8f, 1.5f);
               
        if (Input.GetMouseButtonDown(1))
                transform.parent = null;
        }
      

    }
}
