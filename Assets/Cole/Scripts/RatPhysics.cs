﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatPhysics : MonoBehaviour
{
    public bool Ragdoll;
    Rigidbody[] RB;

	void Start ()
    {
        Ragdoll = false;

        GameObject[] BodyParts = GameObject.FindGameObjectsWithTag("Squeakers");
        RB = new Rigidbody[BodyParts.Length];
        for (int i = 0; i < RB.Length; i++)
        {
            RB[i] = BodyParts[i].GetComponent<Rigidbody>();


        }
    }

	
	void Update ()
    {

        if (Ragdoll == true)
        {
            Fired();
        }
    }

    public void Fired()
    {
        foreach(Rigidbody RatPart in RB)
        {
            RatPart.isKinematic = false;
        }

    }
}
