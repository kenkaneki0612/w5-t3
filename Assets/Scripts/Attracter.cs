using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attracter : MonoBehaviour
{
    public Rigidbody rb;

    private void FixedUpdate()
    {
        Attracter[] attracters = FindObjectsOfType<Attracter>();
        foreach (Attracter attracter in attracters)
        {
            if (attracter != this)
            {
                Attract(attracter);
            }
        }
    }

    void Attract (Attracter objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;
        Vector3 direction = rb.position - rbToAttract.position;

        float distance = direction.magnitude;
        float forceManitude = (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);

        Vector3 force = direction.normalized * forceManitude;

        rbToAttract.AddForce(force);
    }
}
