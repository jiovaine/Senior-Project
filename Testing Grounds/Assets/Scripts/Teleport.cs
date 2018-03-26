using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject ui;
    public GameObject objToTP;
    public Transform tpLoc;

    // Use this for initialization
    void Start()
    {
        ui.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            objToTP.transform.position = tpLoc.transform.position;
        }
    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
