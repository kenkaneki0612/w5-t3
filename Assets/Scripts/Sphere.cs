using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public Rigidbody rb;

    private void FixedUpdate()
    {
        Sphere[] attracters = FindObjectsOfType<Sphere>();
        foreach (Sphere attracter in attracters)
        {
            if (attracter != this)
            {
                Attract(attracter);
            }
        }
    }

    void Attract (Sphere objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
