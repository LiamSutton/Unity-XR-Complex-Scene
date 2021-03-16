using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeSpawnerController : MonoBehaviour
{
    public GameObject cubePrefab;

    public GameObject spawnButton;

    public GameObject resetButton;

    public Transform spawnPoint;

    private float spawnDelay = 0.1f;

    public int n;
    void Start()
    {

    }

    public void SpawnButtonPressed() {
        spawnButton.SetActive(false);
        StartCoroutine("BeginSpawning");
    }
    public IEnumerator BeginSpawning()
    {
        Debug.Log("Spawning " + this.n.ToString() + " Cubes.");
        for (int i = 0; i <= this.n; i++)
        {
            SpawnCube();
            yield return new WaitForSeconds(spawnDelay);
        }
        resetButton.SetActive(true);
    }

    public void Reset()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Spawned");

        for (int i = 0; i < cubes.Length; i++) {
            DestroyImmediate(cubes[i]);
        }
        resetButton.SetActive(false);
        spawnButton.SetActive(true);
    }

    public void SetCubeAmount(int n)
    {
        this.n = n;
    }

    private void SpawnCube()
    {
        Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);
    }
}
