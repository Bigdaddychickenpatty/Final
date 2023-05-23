using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;

    public int Speed = 1;
    private Rigidbody _enemyRb;
    public GameObject _player;
    public float Range;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) <= Range)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Speed * Time.deltaTime);
        }

        transform.LookAt(target);
       //Vector3 localposition = _player.transform.position - transform.position;
       //localposition = localposition.normalized; // The normalized direction in LOCAL space
       //transform.Translate(-localposition.x * Time.deltaTime * Speed, -localposition.y * Time.deltaTime * Speed, -localposition.z * Time.deltaTime * Speed);
    }

       private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Magic"))
        {
            Destroy(this.gameObject);
        }
    }
}