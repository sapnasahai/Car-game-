using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lapcompltetime : MonoBehaviour
{
    public GameObject lapcompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBOX;

     void OnTriggerEnter()    {

        if(Laptimemnager.secondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + Laptimemnager.secondCount + ".";

        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + Laptimemnager.secondCount + ".";
        }

        if (Laptimemnager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + Laptimemnager.MinuteCount + ".";

        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + Laptimemnager.MinuteCount + ".";
        }


        MilliDisplay.GetComponent<Text>().text = "" + Laptimemnager.MilliCount + ".";
        Laptimemnager.MinuteCount = 0;
        Laptimemnager.secondCount = 0;
        Laptimemnager.MilliCount = 0;


        HalfLapTrig.SetActive(true);
        lapcompleteTrig.SetActive(false);



    }




}
