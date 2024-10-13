using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Animator characterAnimator;
    [SerializeField] private Animator targetAnimator;
    [SerializeField] private Image characterImage;  
    [SerializeField] private Image targetImage;

    public void ToJoin()
    {
        GameManager.Instance.StartImage.SetActive(false);
        GameManager.Instance.CharacterTag.SetActive(true);
        Time.timeScale = 1.0f;
        if (characterAnimator != null && targetAnimator != null)
            targetAnimator.runtimeAnimatorController = characterAnimator.runtimeAnimatorController;

        Canvas.ForceUpdateCanvases();
    }

    public void ToChooseCharacter()
    {
        GameManager.Instance.ChooseCharacter.SetActive(true);
    }

    public void ToChosenCharacter()
    {
        ChangeCharacterStat();
        GameManager.Instance.ChooseCharacter.SetActive(false);
    }

    private void ChangeCharacterStat()
    {
        if (characterAnimator != null && targetAnimator != null)
            targetAnimator.runtimeAnimatorController = characterAnimator.runtimeAnimatorController;
        if (characterImage != null && targetImage != null)
            targetImage.sprite = characterImage.sprite;
    }

    public void Change<T>(T target, T Choose)
    {
        if (target != null && Choose != null)
            target = Choose;Debug.Log("??");
    }
}
