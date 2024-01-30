using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatEscapeGameDirector : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    public Image HPGauge;
    public bool gameOver=false;

   

    public void DecreaseHp()
    {
        this.HPGauge.GetComponent<Image>().fillAmount -= 0.34f;
        if (this.HPGauge.GetComponent<Image>().fillAmount <= 0)
        {
            this.gameOver = true;
        }
    }

}
