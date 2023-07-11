using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isGameOver = false;
    public TMP_Text scoreText; // Text mesh pro������Ʈ �� ���
    public Text scoreText_;  //Legacy Text������Ʈ ����� 
    public GameObject gameoverUi;

    private int score = 0;

    private void Awake()
    {
        if(Instance.IsValid() == false)
        {
            Instance = this;
        }
        else
        {
            GFunc.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ� !");
            Destroy(gameObject);            
        }

        //List<int> intList = new List<int>();
        //intList.Add(0);

        //Debug.LogFormat("intList�� ��ȿ����? (�����ϴ���?) : {0}", intList.IsValid());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver ==  true && Input.GetMouseButtonDown(0))
        {
            GFunc.LoadScene(GFunc.GetActiveSceneName());
        }
    }

    public void AddScore(int newScore)
    {
        if(isGameOver == false)
        {
            score += newScore;
            scoreText.text = string.Format("Score : {0}", score);
        }
    }

    public void OnPlayerDead()
    {
        isGameOver = true;
        gameoverUi.SetActive(true);
    }
}
