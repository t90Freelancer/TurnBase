using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transform prCharacterBattle;

    private void Start()
    {
        SpawnCharacter(true);
        SpawnCharacter(false);
    }

    private void SpawnCharacter(bool isPlayerTeam)
    {
        Vector3 spawnPosition;
        if (isPlayerTeam)
        {
            spawnPosition = new Vector3(-3.5f, 0);
        }
        else
        {
            spawnPosition = new Vector3(3.5f,0);
        }

        Instantiate(prCharacterBattle, spawnPosition, Quaternion.identity);
    }
}
