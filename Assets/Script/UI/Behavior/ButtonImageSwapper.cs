using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImageSwapper : MonoBehaviour
{
    private ButtonController controller;

    [SerializeField] private Image selectedImage;
    [SerializeField] private Image targetImage;
    private Image currentImage;

    private void Awake()
    {
        controller = GetComponent<ButtonController>();
        currentImage = targetImage;
        Debug.Log("Awake");
    }

    void Start()
    {
        controller.OnButtonEvent += OnImageSwap;
    }

    private void OnImageSwap()
    {
        if (selectedImage != null)
        {
            currentImage.sprite = selectedImage.sprite;
            ApplyImageSwap(); Debug.Log("event");
        }
    }

    private void ApplyImageSwap()
    {
        Debug.Log("apply");
        if (currentImage != targetImage)
        {
            targetImage.sprite = currentImage.sprite;
        }
    }
}
