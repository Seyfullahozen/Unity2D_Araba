using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishSpawner : MonoBehaviour
{
    public GameObject random_finish_npc;
    bool finish_spawn = true;
    void Start()
    {
        StartCoroutine(bekle());
    }

    IEnumerator bekle()
    {
        while (finish_spawn == true)
        {
            yield return new WaitForSeconds(100f);
            Instantiate(random_finish_npc, transform.position, Quaternion.identity);
        }
    }
}
