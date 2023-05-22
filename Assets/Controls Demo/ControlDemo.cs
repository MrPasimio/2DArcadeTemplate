using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDemo : MonoBehaviour
{
    public TextMeshProUGUI joystickDisplay;
    public string joystickText;
    public TextMeshProUGUI buttonDisplay;
    public string buttonText;

    public string[] buttonNames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetJoystick();
        GetButton();
    }

    public void GetJoystick()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        joystickDisplay.text = $"x: {xInput} \n  y: {yInput}";
    }

    public void GetButton()
    {
        foreach(string buttonName in buttonNames)
        {
            if(Input.GetButtonDown(buttonName))
            {
                buttonDisplay.text = buttonName;
            }
        }
    }
}
