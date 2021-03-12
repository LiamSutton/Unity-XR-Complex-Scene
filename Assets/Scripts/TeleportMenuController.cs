using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMenuController : MonoBehaviour
{
    public GameObject player;
    public Transform mainStagePosition;
    public Transform shootingGalleryStagePosition;

    public void TeleportToMainStage()
    {
        player.transform.position = mainStagePosition.position;
        player.transform.rotation = mainStagePosition.rotation;
    }

    public void TeleportToShootingGallery() {
        player.transform.position = shootingGalleryStagePosition.position;
        player.transform.rotation = shootingGalleryStagePosition.rotation;
    }
}
