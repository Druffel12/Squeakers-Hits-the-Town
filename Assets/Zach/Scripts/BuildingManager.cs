using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public PlayerStats player;
    public SlingshotManager sling;
    //public GameObject destroyedBuilding;
    Vector3 startPos;

	// Use this for initialization
	void Start ()
    { 
        player = FindObjectOfType<PlayerStats>();
        sling = FindObjectOfType<SlingshotManager>();
        startPos = transform.position;
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Squeakers")
        {
            Destroy(gameObject);
            //Instantiate(destroyedBuilding, startPos, Quaternion.identity);
            player.score += 10;
        }
    }
}
