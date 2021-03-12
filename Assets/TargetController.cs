using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Material baseMaterial;
    public Material hitMaterial;

    public AudioClip hitSound;

    private Renderer renderer;
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    public void ChangeMaterial()
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
