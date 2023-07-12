using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilledTypeTest : MonoBehaviour
{
    public Image filledTypeImg;
    private void Awake()
    {
    filledTypeImg.fillAmount = 1.0f;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(passedCoolTime(1f));
    }

    // Update is called once per frame
    void Update()
    {
    }

    //private void FixedUpdate()
    //{
    //    if(0 < filledTypeImg.fillAmount)
    //    {

    //        filledTypeImg.fillAmount -= (Time.deltaTime * 0.5f);
    //    }
    //}
    private IEnumerator passedCoolTime(float cooltimeDealy)
    {
        float cooltimePercent = 1f / 300f;
        while(true)
        { 
            //이만큼 시간이 자란다
            yield return new WaitForSeconds(cooltimeDealy);

            //시간이 시나간 다음에 처리한다.
            filledTypeImg.fillAmount -= cooltimePercent;
        }
    }
}
