using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            gameObject.SetActive(false);
            collision.gameObject.transform.localScale += new Vector3 (0.5f, 0.5f, 0.5f);
            GameManager.Instance.AddScore(1);
            
        }
    }
}
