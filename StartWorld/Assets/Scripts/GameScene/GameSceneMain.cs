using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject heroPrefab;
    [SerializeField] private Text textHP;
    [SerializeField] private HeroDataManager heroDataManager;

    // Start is called before the first frame update
    void Start()
    {
        //
        this.btnLoadScene.onClick.AddListener(() => { Debug.Log("{VillageSceneMain} 으로 전환"); SceneManager.LoadScene("VillageScene"); });
        this.CreateHero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.heroPrefab);
        Debug.LogFormat("heroGo: {0}",heroGo);
        HeroController heroController = heroGo.GetComponent<HeroController>();
        heroController.onHit = () =>
        {
            Debug.Log("영웅이 피해를 받았습니다."); Debug.LogFormat("{0}/{1}", heroController.HP, heroController.MaxHP);
            this.heroDataManager.UpdateHeroHpAndMaxHp(heroController.HP, heroController.MaxHP);
            this.textHP.text = string.Format("{0}/{1}", heroController.HP, heroController.MaxHP);
        };
    }
}
