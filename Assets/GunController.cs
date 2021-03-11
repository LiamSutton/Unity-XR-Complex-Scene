using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform barrelPoint;
    private LineRenderer lineRenderer;

    public AudioClip[] gunFireSounds;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireGun() {
        int idx = Random.Range(0, gunFireSounds.Length);
        AudioSource.PlayClipAtPoint(gunFireSounds[idx], transform.position);
        RaycastHit hit;
       

        if (Physics.Raycast(barrelPoint.transform.position, barrelPoint.transform.forward, out hit, 1000.0f)) {
            if (hit.collider.gameObject.tag.Equals("Target")) {
                hit.collider.gameObject.SendMessage("Hit");
            }
            else {
            }
        }
    }
}
