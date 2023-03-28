using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfpointTrigger: MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLaptrig;


     void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfLaptrig.SetActive(false);

    }
}
