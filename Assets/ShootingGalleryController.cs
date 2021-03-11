using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGalleryController : MonoBehaviour
{
    public GameObject[] targets;
    private GameObject currentTarget;

    private float timer = 2.0f;

    public float targetDelay = 2f;
    void Start()
    {
        currentTarget = targets[Random.Range(0, targets.Length)];
        currentTarget.SetActive(true);
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0f) {
            DisplayTarget();
            timer = 2.0f;
        }
    }

    void DisplayTarget() {
        currentTarget.SendMessage("Hide");
        currentTarget = targets[Random.Range(0, targets.Length)];
        currentTarget.SetActive(true);
    }
}
