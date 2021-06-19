using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    GameObject yes;
    public GameObject spawnManager;
    public float speed;
    public Joystick joyStick;
    public int healthCount;
    public Image[] life;
    public Text cake;
    public int cakeCount;
    Rigidbody rb;
    public ParticleSystem boomEffect;
    public bool isGameActive = false;
    public float leftOrRight = 0f;
    public float upOrDown = 0f;
    public AudioSource sound1;
    public AudioSource sound2;
    public AudioClip ermm;
    public int explosionRadius;
    public GameObject enemy;
    public Button attack;
    public int pushForce;
    public GameObject moon;
    public bool isColliding;
    public int winCakeCount;
    public GameObject skill1;
    // Start is called before the first frame update
    public void StartGame(int number)
    {
            isGameActive = true;
            rb = GetComponent<Rigidbody>();
            yes = GameObject.Find("Fix");
            sound1.Play();
            transform.GetChild(number).gameObject.SetActive(true);
            enemy = GameObject.Find("Enemy");
            attack.onClick.AddListener(checkAttack);

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            leftOrRight = joyStick.Horizontal;
            upOrDown = joyStick.Vertical;

            //transform.Translate(leftOrRight / 10, 0, upOrDown / 10);
            rb.AddForce(yes.transform.forward * speed * upOrDown * Time.deltaTime);
            rb.AddForce(yes.transform.right * speed * leftOrRight * Time.deltaTime);

            cake.text = cakeCount.ToString();

            if (healthCount == 0)
            {
                for (int i = 0; i < life.Length; i++)
                {
                    life[i].gameObject.SetActive(false);
                }
            }
            else if (healthCount == 1)
            {
                for (int i = 0; i < life.Length; i++)
                {
                    bool check;
                    if (i >= 1)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                    life[i].gameObject.SetActive(check);
                }
            }
            else if (healthCount == 2)
            {
                for (int i = 0; i < life.Length; i++)
                {
                    bool check;
                    if (i >= 2)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                    life[i].gameObject.SetActive(check);
                }
            }
            else if (healthCount == 3)
            {
                for (int i = 0; i < life.Length; i++)
                {
                    bool check;
                    if (i >= 3)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                    life[i].gameObject.SetActive(check);
                }
            }

            else if (healthCount == 4)
            {
                for (int i = 0; i < life.Length; i++)
                {
                    bool check;
                    if (i >= 4)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                    life[i].gameObject.SetActive(check);
                }
            }

            else
            {
                for (int i = 0; i < life.Length; i++)
                {
                    life[i].gameObject.SetActive(true);
                }
            }
            isColliding = false;
        }

        if(cakeCount == winCakeCount)
        {
            moon.gameObject.SetActive(true);
        }

        if(cakeCount == winCakeCount)
        {
            Destroy(spawnManager.gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    { 
        if (isColliding) return;
        isColliding = true;

        if (other.gameObject.CompareTag("Heart"))
        {
            if(healthCount<5)
            healthCount++;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Cake"))
        {
            Destroy(other.gameObject);
            Debug.Log(other.gameObject.name);
            cakeCount++;
            
        }

        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce((other.gameObject.transform.position - transform.position), ForceMode.Impulse);
        }
    }
 
    public void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("WALAO");
                if (healthCount > 0)
                    healthCount--;
            
        }
    }


    void checkAttack()
    {
        //float distance = Vector3.Distance(enemy.transform.position, transform.position);
        //if (distance <= explosionRadius)
        Instantiate(skill1, transform.position, transform.rotation);
        boomEffect.Play();
            
            //enemy.GetComponent<Rigidbody>().AddForce((enemy.transform.position - transform.position) * pushForce, ForceMode.Impulse);
        //}
        
    }
}
