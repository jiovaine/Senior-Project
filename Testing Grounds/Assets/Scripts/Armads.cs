using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armads : MonoBehaviour
{
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
   private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.parent = player.transform;
            transform.localPosition = new Vector3(1, 0.8f, 1.5f);
        }
        if (Input.GetMouseButtonDown(1))
            transform.DetachChildren();
            
     
    }

    private void OnMouseEnter()
    {
        Debug.Log("Hello");
    }

    private void OnMouseExit()
    {
        Debug.Log("Goodbye");
    }

    
}
