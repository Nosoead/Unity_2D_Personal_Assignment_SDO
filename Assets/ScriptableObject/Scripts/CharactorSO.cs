using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Ground,
    Air
}

[CreateAssetMenu(fileName = "DefaultCharacterSO",menuName ="CreatCharacter/Character/Player", order = 0)]
public class CharactorSO : ScriptableObject
{
    // Start is called before the first frame update
    [Header("Charactor Info")]
    public UnitType unitType;
    public string species;
    [Range(1f, 20f)] public float moveSpeed;
}
