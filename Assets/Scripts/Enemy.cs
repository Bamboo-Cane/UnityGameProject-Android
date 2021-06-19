using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    Rigidbody rb;
    public float speed;
    private Movement trigger;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        trigger = GameObject.Find("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.isGameActive)
        {
            rb.AddForce((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

        }
    }
}
