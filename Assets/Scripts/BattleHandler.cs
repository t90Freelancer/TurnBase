using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transform prCharacterBattle;
    [SerializeField] private AnimatorOverrideController PlayerClip;
    [SerializeField] private AnimatorOverrideController MonsterClip;
    private void Start()
    {
        SpawnCharacter(true);
        SpawnCharacter(false);
    }

    private void SpawnCharacter(bool isPlayerTeam)
    {
        Vector3 spawnPosition;
        AnimatorOverrideController charClipSo;
        if (isPlayerTeam)
        {
            spawnPosition = new Vector3(-3.5f, 0);
            charClipSo = PlayerClip;
        }
        else
        {
            spawnPosition = new Vector3(3.5f,0);
            charClipSo = MonsterClip;
        }

        Transform character =  Instantiate(prCharacterBattle, spawnPosition, Quaternion.identity);
        character.transform.GetComponent<CharacterAnimation>().ApplyAnimationClips(charClipSo);

        if(!isPlayerTeam)
        {
            character.transform.localScale = Vector3.one*2;
        }
    }
}
