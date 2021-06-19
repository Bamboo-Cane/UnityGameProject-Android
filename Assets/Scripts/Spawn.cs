using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject live;
    public GameObject cake;
    public GameObject enemy;
    public float spawnLiveSpeed;
    public float spawnCakeSpeed;
    public float spawnEnemySpeed;
    private Vector3 setRotation = new Vector3(-90,0,0);
    public float randomRangeX;
    public float randomRangeZ;
    private Movement player;
    // Start is called before the first frame update
    public void StartSpawn()
    {

        player = GameObject.Find("Player").GetComponent<Movement>();

        if (player.isGameActive)
        {
            InvokeRepeating("spawnLive", spawnLiveSpeed, spawnLiveSpeed);
            InvokeRepeating("spawnCake", spawnCakeSpeed, spawnCakeSpeed);
            InvokeRepeating("spawnEnemy", spawnCakeSpeed, spawnCakeSpeed);
        }
    }

    // Update is called once per frame


    void spawnLive()
    {
        Instantiate(live.gameObject, spawnRandom(), Quaternion.Euler(setRotation));
    }

    void spawnCake()
    {
        Instantiate(cake.gameObject, spawnRandom(), transform.rotation);
    }

    void spawnEnemy()
    {
        Instantiate(enemy.gameObject, spawnRandom(), transform.rotation);
    }

    Vector3 spawnRandom()
    {
        return new Vector3 (Random.Range(-randomRangeX,randomRangeX),0.5f,Random.Range(-randomRangeZ,randomRangeZ));
    }
}
