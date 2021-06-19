using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private Button button;
    public GameObject startScreen;
    private Movement player;
    private Spawn spawn;
    public GameObject menu;
    private GameManager gameManager;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
        button = GetComponent<Button>();
        spawn = GameObject.Find("Spawn Manager").GetComponent<Spawn>();
        button.onClick.AddListener(GetScene);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void GetScene()
    {
        startScreen.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
        SceneManager.GetActiveScene();
        player.StartGame(number);
        spawn.StartSpawn();
        gameManager.StartTime();
    }
}
