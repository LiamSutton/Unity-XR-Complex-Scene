using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Material baseMaterial;
    public Material hitMaterial;

    public AudioClip hitSound;

    public float hitDelay = 2.0f;

    private Renderer renderer;
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    public void Hit()
    {
        AudioSource.PlayClipAtPoint(hitSound, transform.position);
        renderer.material = hitMaterial;
    }

    public void Hide() {
        renderer.material = baseMaterial;
        gameObject.SetActive(false);
    }

    void Show() {
    }
}
