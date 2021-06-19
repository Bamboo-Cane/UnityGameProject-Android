using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject bossSkill;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("releaseSkill", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void releaseSkill()
    {
        Instantiate(bossSkill, transform.position, bossSkill.transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
    }
}
