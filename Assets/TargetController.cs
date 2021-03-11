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
        StartCoroutine("IChangeMaterial");
    }

    IEnumerator IChangeMaterial() {
        Debug.Log("STARTING HIT");
        AudioSource.PlayClipAtPoint(hitSound, transform.position);
        renderer.material = hitMaterial;
        yield return new WaitForSeconds(hitDelay);
        renderer.material = baseMaterial;
        Debug.Log("ENDING HIT");
    }
}
