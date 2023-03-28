using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halfpointtrigger : MonoBehaviour
{
    public GameObject Halflaptrig;
    public GameObject completelaptrig;

    void OnTriggerenter()
    {
        completelaptrig.SetActive(true);
        Halflaptrig.SetActive(false);
    }


        
}
