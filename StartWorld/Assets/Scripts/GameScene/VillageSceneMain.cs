using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageSceneMain : MonoBehaviour
{
    private HeroDataManager heroDataManager;
    // Start is called before the first frame update
    void Start()
    {
        this.heroDataManager = GameObject.FindAnyObjectByType<HeroDataManager>();
        Debug.LogFormat("{0}/{1}", this.heroDataManager.GetHeroHP(), heroDataManager.GetHeroMaxHP());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
