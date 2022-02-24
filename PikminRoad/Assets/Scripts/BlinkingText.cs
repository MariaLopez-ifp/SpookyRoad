using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    Text text;

    [SerializeField]
    TextMeshProUGUI textOnScreen;

    string originalText;

    bool isBlinking = true;
    bool blinkState = true;

    void Start()
    {
        originalText = textOnScreen.text;
        StartCoroutine(TextBlink());
    }

    public IEnumerator TextBlink()
    {
        while(isBlinking)
        {
            if(blinkState)
            {
                blinkState = false;
                textOnScreen.text = originalText;
                yield return new WaitForSeconds(.5f);
            }
            
            else
            {
                blinkState = true;
                textOnScreen.text = "";
                yield return new WaitForSeconds(.5f);
            }
            
        }
    }
}
