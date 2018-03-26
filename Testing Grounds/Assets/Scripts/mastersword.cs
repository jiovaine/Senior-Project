using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mastersword : MonoBehaviour
{
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        if (Input.GetMouseButton(0))
        {
            transform.parent = player.transform;
            Debug.Log("yeet");
            transform.localPosition = new Vector3(4, 0.2f, 0.5f);
            transform.localRotation = Quaternion.Euler(-40, 180, -19);
            print(transform.localPosition.y);

            if (Input.GetMouseButton(1))
                transform.parent = null;


        }

    }
}
