using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;
    void Start()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void setDifficulty()
    {
        Debug.Log(gameObject.name + " is selected");
        gameManager.StartGame(difficulty);
    }
}
