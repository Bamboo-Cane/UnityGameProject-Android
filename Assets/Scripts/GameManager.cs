using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Toggle toggle;
    public Camera camera1;
    public Camera camera2;
    public Text text;
    public Text offsetZone;
    private Movement walao;
    public string zone;
    public int calculateZone = 6;
    public int time = 6;

    // Start is called before the first frame update
    private void Start()
    {
        walao = GameObject.Find("Player").GetComponent<Movement>();
    }
    public void StartTime()
    {
  
        
            InvokeRepeating("plusTime", 11.45f, 11.45f);
        
    }

    void Update()
    {
        if (walao.isGameActive)
        {
            if (toggle.isOn)
            {
                camera1.gameObject.SetActive(true);
                camera2.gameObject.SetActive(false);
            }

            else
            {
                camera1.gameObject.SetActive(false);
                camera2.gameObject.SetActive(true);
            }

            time %= 12;
            calculateZone %= 24;

            if (calculateZone >= 11 & calculateZone <= 22)
            {
                zone = "PM";
            }
            else
            {
                zone = "AM";
            }

            text.text = (time ).ToString();
            offsetZone.text = zone;
        }
    }
    public void plusTime()
    {
        time++;
        calculateZone++;
    }
}
