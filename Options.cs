using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Text soundTxt;
    public bool sounds = true;

    public Text vibrationTxt;
    public bool vibrations = true;
    

    public void SoundsButton()
    {
        if (sounds)
        {
            soundTxt.text = "> SOUNDS: OFF <";
            sounds = false;
        }
        else if(sounds==false)
        {
            soundTxt.text = "> SOUNDS: ON <";
            sounds = true;
        }
    }

    public void VibrationsButton()
    {
        if (vibrations)
        {
            vibrationTxt.text = "> VIBRATIONS: OFF <";
            vibrations = false;
        }
        else if (vibrations == false)
        {
            vibrationTxt.text = "> VIBRATIONS: ON <";
            vibrations = true;
        }
    }
}
