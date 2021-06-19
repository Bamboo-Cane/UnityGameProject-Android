using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    Rigidbody rb;
    public float speed;
    private Movement ok;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ok = GameObject.Find("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ok.isGameActive)
        {
            rb.AddForce((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

        }
    }
}
