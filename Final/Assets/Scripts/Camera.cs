using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    public float sensitivity;
    private Vector3 offset;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;

        rb = GetComponent<Rigidbody> ();
    }

    private void LateUpdate() 
    {
        transform.position= Player.transform.position + offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis ("Mouse x");

        float rotateVertcal = Input.GetAxis ("Mouse Y");
        Vector3 rotation = new Vector3 (rotateHorizontal, 0.0f, rotateVertcal);
        rb.AddForce (rotation * sensitivity);
    }
}
