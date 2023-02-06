using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTxt : MonoBehaviour
{

    int currentTimeSecond = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTimer());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator UpdateTimer()
    {
        while (true)
        {
            // { 시간을 Ui에 업데이트 하는 로직
            string timeStrFormat = "{0} : {1}";

            string minuteFormat =
                $"{Mathf.FloorToInt(currentTimeSecond / 60.0f):D2}";
            string secondFormat =
                $"{Mathf.FloorToInt(currentTimeSecond % 60.0f):D2}";

            string timeStr = string.Format(timeStrFormat,
                minuteFormat, secondFormat);

            gameObject.SetTmpText(timeStr);

            // } 시간을 Ui에 업데이트 하는 로직



            // { 시간이 1초씩 흘러가는 로직
            yield return new WaitForSeconds(1.0f);
            currentTimeSecond += 1;

            // } 시간이 1초씩 흘러가는 로직

        }

    }   // UpdateTimer()
}
