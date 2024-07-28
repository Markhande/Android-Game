using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float force = 1000f;
    public float speed = 10f;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // You can add initialization code here if needed.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        // Make sure to check if the Rigidbody component is not null before applying force.
        if (rigidbody != null)
        {
            rigidbody.AddForce(0, 0, force * Time.deltaTime);
        }
    }
}
