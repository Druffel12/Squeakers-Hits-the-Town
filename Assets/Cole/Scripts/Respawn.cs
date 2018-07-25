using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 SqueakStart;
    public GameObject squeakStartPositionOnSling;
    public SlingshotManager sling;

	// Use this for initialization
	void Start ()
    {
        SqueakStart = squeakStartPositionOnSling.transform.position;
        sling = FindObjectOfType<SlingshotManager>();
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ground")
        {
            StartCoroutine("RespawnTimer");
        }
    }

    IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.transform.position = SqueakStart;
        sling.ResetSqueaker();
        yield return null;
    }
}
