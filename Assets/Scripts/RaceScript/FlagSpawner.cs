using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagSpawner : MonoBehaviour
{
    public GameObject random_flag_npc;
    bool flag_spawn = true;
    void Start()
    {
        StartCoroutine(bekle());
    }

    IEnumerator bekle()
    {
        while (flag_spawn == true)
        {
            Instantiate(random_flag_npc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(9f);
        }
    }
}
