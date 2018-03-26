using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beelanceanime: MonoBehaviour
{

    public Animator Sword;


    // Use this for initialization
    void Start()
    {
        Sword = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Sword.Play("beelance");
        }
    }
}
