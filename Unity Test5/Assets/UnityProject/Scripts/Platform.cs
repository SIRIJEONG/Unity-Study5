using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    private bool stepped = false;

    private void OnEnable()
    {
        stepped = false;

        for(int i = 0; i < obstacles.Length; i++)
        {
            if(Random.Range(0,6) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("Player") && stepped == false)
        {
            stepped=true; 
            GameManager.Instance.AddScore(1);
        }
    }

}
