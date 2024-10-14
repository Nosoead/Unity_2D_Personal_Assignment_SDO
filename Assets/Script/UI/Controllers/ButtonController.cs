using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public event Action OnButtonEvent;

    public void OnButtonClick()
    {
        CallButtonEvent();
    }

    public void CallButtonEvent()
    {
        OnButtonEvent?.Invoke();
    }
}
