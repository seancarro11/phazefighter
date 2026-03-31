using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject fodderPrefab;
    public GameObject bossPrefab;
    public int waveNumber = 1;
    public int fodderCount;
    public int bossActive;
    public Rigidbody fodderRb;
    public Rigidbody bossRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnFodderWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        fodderCount = GameObject.FindGameObjectsWithTag("Fodder").Length;
        if (fodderCount == 0)
        {
            waveNumber++;
            SpawnFodderWave(waveNumber);
        }
    }

    void SpawnFodderWave(int fodderToSpawn)
    {
        for (int i=0; i < fodderToSpawn; i++)
        {
            Instantiate(fodderPrefab, new Vector3(7, 26, 13), fodderPrefab.transform.rotation);
        }
    }

    void SpawnBoss()
    {
        bossActive = GameObject.FindGameObjectsWithTag("Fodder").Length;
        if (bossActive == 0)
        {
            Instantiate(bossPrefab, new Vector3(12, 18, 13), bossPrefab.transform.rotation);
        }
    }

}
