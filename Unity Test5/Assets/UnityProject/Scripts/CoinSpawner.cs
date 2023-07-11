using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin = default;

    private float surviveTime = default;
    private float surviveTimeMax = default;


    public float spawnerRateMin = 0.0f;
    public float spawnerRateMax = 1.0f;

    private int randomNumber = default;

    private float spawnerRate = default;
    private float timeAfterSpawner = default;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawner = 0f;
        spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);
        
        surviveTime = 0f;
        surviveTimeMax = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawner += Time.deltaTime;

        if (timeAfterSpawner >= spawnerRate)
        {
            timeAfterSpawner = 0f;

            spawnerRate = Random.Range(spawnerRateMin, spawnerRateMax);


        }
    }
}
