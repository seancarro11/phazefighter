using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject fodderPrefab;
    public GameObject bossPrefab;
    public int waveNumber = 1;
    public int fodderCount;
    public int bossActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        SpawnFodderWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        fodderCount = FindObjectsByType<Fodder>(FindObjectsSortMode.None).Length;
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
        bossActive = FindObjectsByType<Boss>(FindObjectsSortMode.None).Length;
        if (bossActive == 0)
        {
            Instantiate(bossPrefab, new Vector3(12, 18, 13), bossPrefab.transform.rotation);
        }
    }

}
