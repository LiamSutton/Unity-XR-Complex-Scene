using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject shootingGallery;
    private ShootingGalleryController shootingGalleryController;
    public Transform barrelPoint;
    private LineRenderer lineRenderer;

    public AudioClip[] gunFireSounds;
    void Start()
    {
     shootingGalleryController = shootingGallery.GetComponent<ShootingGalleryController>();   
    }
    public void FireGun() {
        int idx = Random.Range(0, gunFireSounds.Length);
        AudioSource.PlayClipAtPoint(gunFireSounds[idx], transform.position);
        RaycastHit hit;
       
        if (Physics.Raycast(barrelPoint.transform.position, barrelPoint.transform.forward, out hit, 1000.0f)) {
            if (hit.collider.gameObject.tag.Equals("Target")) {
                shootingGalleryController.SendMessage("Hit", hit.collider.gameObject);
            }
            else {
            }
        }
    }
}
