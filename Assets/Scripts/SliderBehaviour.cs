using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    public Text levelTxt;
    public static int speed_level=4;


    public void Start()
    {
        levelTxt.text = "1" ;
    }

    public void SliderUpdate(float value)
    {
        levelTxt.text = "" + Mathf.RoundToInt(value);
        speed_level = Mathf.RoundToInt(value);
    }

}
