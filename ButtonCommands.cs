using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for BUttons

public class ButtonCommands : MonoBehaviour
{
    public Button btnOne;
    public Button btnTwo;

    public void PressedButtonOne()
    {
        btnTwo.gameObject.SetActive(false);
        Invoke("btnTwoAppear", 3.0f);
    }
    public void PressedButtonTwo()
    {
        btnOne.gameObject.SetActive(false);
        Invoke("btnOneAppear", 3.0f);
    }

    private void btnOneAppear()
    {
        if (btnOne.gameObject.activeSelf == false)
        {
            btnOne.gameObject.SetActive(true);
        }
    }
    private void btnTwoAppear()
    {
        if (btnTwo.gameObject.activeSelf == false)
        {
            btnTwo.gameObject.SetActive(true);
        }
    }
}