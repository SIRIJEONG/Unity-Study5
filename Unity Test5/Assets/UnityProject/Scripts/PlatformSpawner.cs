using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject PlatformPrefab;


    public int count = 3;

    public float timeBetSpawnerMin = 1.25f;
    public float timeBetSpawnerMax = 2.25f;
    private float timeBatSpawn;

    public float yMin = -3.5f;
    public float yMax = 1.5f;
    private float xPos = 20f;

    private GameObject[] platforms;

    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -25f);


    private float lastSpawnTime;


    // Start is called before the first frame update
    void Start()
    {
        platforms = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(PlatformPrefab, poolPosition , Quaternion.identity);

            

        }

        lastSpawnTime = 0f;
        timeBatSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.isGameOver)
        {
            return;
        }
        if(lastSpawnTime + timeBatSpawn <= Time.time)
        {
            lastSpawnTime = Time.time;
            timeBatSpawn = Random.Range(timeBetSpawnerMin, timeBetSpawnerMax);

            float yPos = Random.Range(yMin, yMax);
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);
            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            currentIndex += 1;

            if(count <= currentIndex)
            {
                currentIndex = 0;
            }

        }
    }
}
