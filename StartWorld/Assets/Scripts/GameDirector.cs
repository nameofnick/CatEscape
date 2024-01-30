using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo;
    //멤버변수 : 지속적으로 사용해야할때 사용.

    // Start is called before the first frame update
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.LogFormat("this.carGo: {0}",this.carGo);  //car 게임 오브젝트 인스턴스
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGo);  //flag 게임 오브젝트 인스턴스
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);  //distance 게임 오브젝트 인스턴스

        Text distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);

        distanceText.text = "안녕하세요";

    }

    // Update is called once per frame
    void Update()
    {
        //매 프레임마다 자동차와 깃발의 거리를 계산
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
    }
}
