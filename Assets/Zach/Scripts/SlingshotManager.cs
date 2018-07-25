using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlingshotManager : MonoBehaviour
{
    [Header("Setup")]
    public MouseLook mouse;
    public Transform squeaker;
    public RatPhysics ratPhysics;
    public Slider powerBar;
    public Rigidbody rb;
    public GameObject squeakersObject;
    public GameObject canonObject;

    [Header("Firing Stats")]
    public int minFirePower = 0;
    public int maxFirePower = 1000;
    public float firePower;

    [HideInInspector]
    public bool aiming = false;
    [HideInInspector]
    public bool firePositionSet;
    [HideInInspector]
    public bool firePowerSet;
    [HideInInspector]
    public bool shotFired;

    // Use this for initialization
    void Start()
    {
        mouse = GetComponent<MouseLook>();
        ratPhysics = FindObjectOfType<RatPhysics>();
        mouse.enabled = false;
        aiming = false;
        firePower = 0;
        firePositionSet = false;
        firePowerSet = false;
    }

    void FireSqueaker()
    {
        squeakersObject.transform.parent = null;
        rb.isKinematic = false;
        shotFired = true;
        ratPhysics.Ragdoll = true;
        rb.useGravity = true;
        rb.AddForce(transform.forward * (firePower * 2), ForceMode.Impulse);
        rb.AddForce(transform.up * (firePower * 0.5f), ForceMode.Impulse);
    }

    public void ResetSqueaker()
    {
        squeakersObject.transform.parent = canonObject.transform;
        shotFired = false;
        ratPhysics.Ragdoll = false;
        //rb.useGravity = false;
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (aiming == false)
            {
                mouse.enabled = true;
                aiming = true;
            }
            else
            {
                mouse.enabled = false;
                aiming = false;
                firePositionSet = true;
            }
        }

        if (firePositionSet == true && Input.GetKey(KeyCode.UpArrow))
        {
            firePower++;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
            powerBar.value--;
        }
        else if (firePositionSet == true && Input.GetKey(KeyCode.DownArrow))
        {
            firePower--;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
            powerBar.value++;
        }

        if (firePositionSet == true && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            firePower += 9;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
            powerBar.value -= 9;
        }
        else if (firePositionSet == true && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            firePower -= 9;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
            powerBar.value += 9;
        }

        if (firePowerSet == true && Input.GetKeyDown(KeyCode.Return))
        {
            FireSqueaker(); // Replace this with Cole's squeaker fire function
        }
    }
}
