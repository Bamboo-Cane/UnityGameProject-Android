using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkill : MonoBehaviour
{
    private GameObject player;
    private Rigidbody skillRB;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        skillRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        skillRB.AddForceAtPosition((player.transform.position - transform.position),new Vector3(0,0,0));
    }
}
