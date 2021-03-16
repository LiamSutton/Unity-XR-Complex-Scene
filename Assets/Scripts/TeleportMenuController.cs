using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMenuController : MonoBehaviour
{
    public GameObject player;
    public Transform mainStagePosition;
    public Transform shootingGalleryStagePosition;

    public Transform cubeSpawnerStagePosition;

    public void TeleportToMainStage()
    {
        player.transform.position = mainStagePosition.position;
        player.transform.rotation = mainStagePosition.rotation;
        Debug.Log("Teleporting to Main Stage");
    }

    public void TeleportToShootingGallery() {
        player.transform.position = shootingGalleryStagePosition.position;
        player.transform.rotation = shootingGalleryStagePosition.rotation;
        Debug.Log("Teleporting to Shooting Gallery");
    }

    public void TeleportToCubeSpawner() {
        player.transform.position = cubeSpawnerStagePosition.position;
        player.transform.rotation = cubeSpawnerStagePosition.rotation;
        Debug.Log("Teleporting to Cube Spawner");
    }
}
