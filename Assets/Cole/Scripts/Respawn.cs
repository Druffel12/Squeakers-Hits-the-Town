using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 SqueakStart;
    public RatPhysics RP;
	// Use this for initialization
	void Start ()
    {
        SqueakStart = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        	
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            RP.Ragdoll = false;
            StartCoroutine("RespawnTimer");
        }
    }

    IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.transform.position = SqueakStart;
        yield return null;
    }
}
