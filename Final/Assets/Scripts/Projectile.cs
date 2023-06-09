using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
