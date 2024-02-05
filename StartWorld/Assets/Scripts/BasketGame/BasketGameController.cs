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
        //�ð�ǥ��
        countDown.GetComponent<Text>().text = "���� �ð� : " + timer.ToString("F2") + "��";
        timer -= Time.deltaTime;
        //����ǥ��
        scoreCount.GetComponent<Text>().text = "���� : " + timer.ToString("N0") + "��";

    }
    //�ð�ǥ��
    //����ǥ��
    //������ ����
    //�� ��ȯ �� ����ǥ��
    //����
    public void Up()
    {
        score += 200;
    }
    public void Down()
    {
        score -= 200;
    }
    //�� ��ȯ
    //SceneManager.LoadScene("Clear");
    //private 

}
