using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotManager : MonoBehaviour
{
    [Header("Setup")]
    public MouseLook mouse;
    public Transform squeaker;
    public RatPhysics ratPhysics;
    Rigidbody rb;

    [Header("Firing Stats")]
    public int minFirePower = 0;
    public int maxFirePower = 1000;
    public float firePower;

    private bool aiming = false;
    private bool firePositionSet;
    private bool firePowerSet;
    
    // Use this for initialization
    void Start()
    {
        mouse = GetComponent<MouseLook>();
        rb = GetComponentInChildren<Rigidbody>();
        ratPhysics = FindObjectOfType<RatPhysics>();
        mouse.enabled = false;
        aiming = false;
        firePower = 0;
        firePositionSet = false;
        firePowerSet = false;
    }

    void FireSqueaker()
    {
        
        rb.useGravity = true;
        rb.AddForce(transform.forward * firePower, ForceMode.Impulse);
        rb.AddForce(transform.up * (firePower * 0.5f), ForceMode.Impulse);
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

        if (firePositionSet == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            firePower++;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
        }
        else if (firePositionSet == true && Input.GetKeyDown(KeyCode.DownArrow))
        {
            firePower--;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
        }

        if (firePositionSet == true && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            firePower += 9;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
        }
        else if (firePositionSet == true && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            firePower -= 9;
            firePower = Mathf.Clamp(firePower, minFirePower, maxFirePower);
            Debug.Log("Fire Power: " + firePower);
            firePowerSet = true;
        }

        if (firePowerSet == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireSqueaker(); // Replace this with Cole's squeaker fire function
        }
    }
}
