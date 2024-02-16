using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
    private CharacterAnimation characterAnimation;


    private void Awake()
    {
        characterAnimation = GetComponent<CharacterAnimation>();
    }
}
