using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody _rb;
    public float Downz = 0.5f;
    public float moveSpeed = 20f;
    public float turnSpeed = 80f;
    public Transform last_point;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     _rb.AddForce(25, 0f, 0f);
        //  }

        //  if (Input.GetKey(KeyCode.A))
        //  {
        //      _rb.AddForce(0f, 0f, 25);
        //  }

        // if (Input.GetKey(KeyCode.D))
        //  {
        //     _rb.AddForce(0f, 0f, -25);
        //  }

        // if (Input.GetKey(KeyCode.S))
        //  {
        //      _rb.AddForce(-25, 0f, 0f);
        //  }

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * moveSpeed * Downz * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Z))

            _rb.AddForce(Vector3.up * 30f, ForceMode.Force);

        if (Input.GetKeyDown(KeyCode.X))
{
            transform.position = last_point.position;
            transform.rotation = Quaternion.identity;
}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "C_Point1")
        {
            last_point.position = other.transform.position;

            //Destroy(other.gameObject);
        }
    }
}