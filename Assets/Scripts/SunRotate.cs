using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    private Movement player;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameActive)
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
    }
}
