using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackSpawner : MonoBehaviour
{
    public GameObject random_crack_npc;
    bool crack_spawn = true;
    void Start()
    {
        StartCoroutine(bekle());
    }

    IEnumerator bekle()
    {
        while (crack_spawn == true)
        {
            Instantiate(random_crack_npc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(7f);
        }
    }
}
