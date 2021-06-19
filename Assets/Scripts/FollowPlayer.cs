using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offSet;
    // Start is called before the first frame update

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offSet;
    }
}
