using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisManager : MonoBehaviour
{

    IEnumerator ClearDebris()
    {
        //GameObject.FindGameObjectsWithTag("Debris");
        yield return new WaitForSeconds(10.0f);
        Destroy(gameObject);
        yield return null;

    }
}
