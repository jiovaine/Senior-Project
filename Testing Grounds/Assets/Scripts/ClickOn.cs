﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour {
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        Debug.Log("Hello");
    }

    private void OnMouseExit()
    {
        Debug.Log("Goodby*e");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            transform.parent = player.transform;
            Debug.Log("yeet");
            transform.localPosition = new Vector3(1, 0.8f, 1.5f);
            print(transform.localPosition.y);

            if (Input.GetKeyDown("c"))
            transform.parent = null;
            

        }

    }
}
