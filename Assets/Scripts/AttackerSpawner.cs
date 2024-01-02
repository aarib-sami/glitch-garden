using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    int whichIndex;
    [SerializeField] Attacker[] attackerArray;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker(); 
        }
    }

    public void stopSpawning()
    {
        spawn = false;
    }


    private void SpawnAttacker()
    {
        whichIndex = Random.Range(0, attackerArray.Length);
        Spawn(attackerArray[whichIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

}
