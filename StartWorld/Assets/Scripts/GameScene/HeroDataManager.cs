using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataManager : MonoBehaviour
{
    private int heroHP = 0;
    private int heroMaxHP = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void UpdateHeroHpAndMaxHp(int heroHP, int heroMaxHP)
    {
        this.heroHP = heroHP;
        this.heroMaxHP = heroMaxHP;
    }
    public int GetHeroHP()
    {
        return this.heroHP;
    }
    public int GetHeroMaxHP()
    {
        return this.heroMaxHP;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
