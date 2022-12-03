using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class timeManager : MonoBehaviour
{
    public int date;
    public TextMeshProUGUI dayAndTime;
    public string day;
    public string hour;
    public string minute;

    // Start is called before the first frame update
    void Start()
    {
        date = 1;
        refreshTime();
    }
    private void Update()
    {
        string currentMinute = System.DateTime.Now.Minute.ToString();
        string currentDate = System.DateTime.Now.ToString().Substring(0, 5);
        if (currentMinute != minute)
        {
            if(currentDate != day)
            {
                date++;
            }
            refreshTime();
        }
    }

    void refreshTime()
    {
        string dateTime = System.DateTime.Now.ToString();
        day = dateTime.Substring(0, 5);
        hour = System.DateTime.Now.Hour.ToString();
        minute = System.DateTime.Now.Minute.ToString();
        dayAndTime.text ="Day "+ date+ " - " + hour + ":" + minute;
        //Debug.Log(System.DateTime.Now.ToString());
    }
}
