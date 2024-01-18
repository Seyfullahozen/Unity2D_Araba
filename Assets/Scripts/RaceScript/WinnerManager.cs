using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinnerManager : MonoBehaviour
{
    
    public static float WinnerNumber;
    public TextMeshProUGUI WinnerPlayer;

    private void Start()
    {
        SetWinnerText(WinnerNumber);
    } 

    public void SetWinnerText(float winnerIndex)
    {
        if (winnerIndex == 1)
        {
            WinnerPlayer.text = "Kazanan: Oyuncu1";
        }
        else if (winnerIndex == 2)
        {
            WinnerPlayer.text = "Kazanan: Oyuncu2";
        }
    }
}
