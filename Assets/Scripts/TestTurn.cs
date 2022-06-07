using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTurn : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion rotation = Quaternion.Euler(0f, speed, 0f);
        rigidbody.MoveRotation(rigidbody.rotation * rotation);
        //float turn = Input.GetAxis("Horizontal");
        //rigidbody.AddTorque(transform.up * speed * turn);
    }
}
