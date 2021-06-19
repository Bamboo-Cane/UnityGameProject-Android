using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMove : MonoBehaviour
{
    public float angle;
    public float force;
    private GameObject FixRotation;
    private Rigidbody skillRB;
    // Start is called before the first frame update
    void Start()
    {
        FixRotation = GameObject.Find("Fix");
        skillRB = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float xcomponent = Mathf.Cos(FixRotation.transform.eulerAngles.y * Mathf.PI / 180) * force;
        float ycomponent = Mathf.Sin(FixRotation.transform.eulerAngles.y * Mathf.PI / 180) * force;
        skillRB.AddForceAtPosition(new Vector3(ycomponent * 0.1f, 0, xcomponent * 0.1f), new Vector3(1, 1, 1), ForceMode.Impulse);
        Invoke("DestroyObject", 10f);
    }
    

    void DestroyObject()
    {
        Destroy(skillRB.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
