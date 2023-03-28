using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptimemnager : MonoBehaviour
{
    public static int MinuteCount;
    public static int secondCount;
    public static float MilliCount;
    public static string MilliDisplay;


    public GameObject MiniuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;


    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("f0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if(MilliCount>= 10)
        {
            MilliCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else {
            SecondBox.GetComponent<Text>().text = "" + secondCount + ":";
        }

        if(secondCount >= 60)
        {
            secondCount = 0;
            MinuteCount += 1;
        }
        
        if(MinuteCount<= 9)
        {
            MiniuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MiniuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
    }


}
