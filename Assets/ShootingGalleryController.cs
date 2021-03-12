using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootingGalleryController : MonoBehaviour
{
    public GameObject[] targets;
    private GameObject currentTarget;

    public GameObject startButton;
    public GameObject stopButton;

    public TMP_Text scoreText;
    public TMP_Text timeLeftText;

    private float respawnTimer;
    private int score;

    private float gameTimer;

    private bool isPlaying = false;
    void Start()
    {
        Reset();
        currentTarget = targets[Random.Range(0, targets.Length)];
        
    }
    void Update()
    {
        if (isPlaying && gameTimer >= 0.0f)
        {
            timeLeftText.text = gameTimer.ToString("F2");
            gameTimer -= Time.deltaTime;
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0.0f)
            {
                DisplayTarget();
            }
        }
    }

    void DisplayTarget()
    {
        if (currentTarget != null) {
            currentTarget.SendMessage("Hide");
        }

        currentTarget = targets[Random.Range(0, targets.Length)];
        currentTarget.SetActive(true);
        respawnTimer = 2.0f;
    }

    public void Hit(GameObject hitObject)
    {
        if (isPlaying && gameTimer > 0.0f) {
            hitObject.SendMessage("ChangeMaterial");
            score++;
        scoreText.text = score.ToString();
        DisplayTarget();
        }
    }

    public void BeginGame()
    {
        startButton.SetActive(false);
        stopButton.SetActive(true);
        isPlaying = true;
    }

    public void StopGame()
    {
        startButton.SetActive(true);
        stopButton.SetActive(false);
        isPlaying = false;
        Reset();
    }

    public void Reset() {
        respawnTimer = 2.0f;
        gameTimer = 25.0f;
        score = 0;

        timeLeftText.text = gameTimer.ToString("F2");
        scoreText.text = score.ToString();
    }
}
