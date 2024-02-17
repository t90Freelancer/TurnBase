using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterProperties : MonoBehaviour
{
    [SerializeField] private Slider sliderHp;
    [SerializeField] private Slider sliderMp;

    private int maxHp=120;
    private int maxMp=60;

    private int currentHp= 50;
    private int currentMp= 60;

    private void Start()
    {
        sliderHp.maxValue = maxHp;
        sliderMp.maxValue = maxMp;
        sliderHp.value = currentHp;
        sliderMp.value = currentMp;
    }

}
