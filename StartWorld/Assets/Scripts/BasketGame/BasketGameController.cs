using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BasketGameController : MonoBehaviour
{
    [SerializeField] private GameObject countDown;
    [SerializeField] private float timer = 60f;
    [SerializeField] private GameObject scoreCount;
    [SerializeField] private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        countDown = GameObject.Find("CountDown");
        scoreCount = GameObject.Find("ScorePoint");
    }

    // Update is called once per frame
    void Update()
    {
        //시간표시
        countDown.GetComponent<Text>().text = "남은 시간 : " + timer.ToString("F2") + "초";
        timer -= Time.deltaTime;
        //점수표시
        scoreCount.GetComponent<Text>().text = "점수 : " + timer.ToString("N0") + "점";

    }
    //시간표시
    //점수표시
    //득점과 감점
    //씬 전환 후 점수표시
    //득점
    public void Up()
    {
        score += 200;
    }
    public void Down()
    {
        score -= 200;
    }
    //씬 전환
    //SceneManager.LoadScene("Clear");
    //private 

}
