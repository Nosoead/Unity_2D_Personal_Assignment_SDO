using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameObject StartImage;
    public GameObject joinButton;
    public GameObject ChosenCharacter;
    public GameObject ChooseCharacter;
    public GameObject ChoosePlayer;
    public GameObject CharacterTag;
    public Text ChooseName;
    public Text CharacterName;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        Application.targetFrameRate = 60;
        Time.timeScale = 0.0f;
        StartImage.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (ChooseName != CharacterName)
        {
            ChangeNameTag();
        }
    }

    private void ChangeNameTag()
    {
        if (ChooseName != null && CharacterName != null)
            CharacterName.text = ChooseName.text;
    }

}
