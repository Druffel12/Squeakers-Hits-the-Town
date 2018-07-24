using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatPhysics : MonoBehaviour
{
    static bool Ragdoll;
    Rigidbody[] RB;

	void Start ()
    {
        Ragdoll = false;
	}
	
	void Update ()
    {

        if (Ragdoll == true)
        {
            Fired();
        }
    }

    void Fired()
    {
        GameObject[] BodyParts = GameObject.FindGameObjectsWithTag("Rat");
        RB = new Rigidbody[BodyParts.Length];
        for (int i = 0; i < RB.Length; i++)
        {
            RB[i] = BodyParts[i].GetComponent<Rigidbody>();
        }

    }
}
