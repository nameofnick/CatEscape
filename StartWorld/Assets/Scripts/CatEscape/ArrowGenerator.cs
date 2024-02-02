using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowGenerator : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    private float delta;    //경과된 시간 변수
    // Start is called before the first frame update
    /*
    void Start()
    {
        GameObject go = Instantiate(this.arrowPrefab);  //프리팹 인스턴스
        //프리펩 에셋에 설정된 위치
        //위치 재설정
        Debug.LogFormat("go : {0}", go);
    }
    */

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;    //이전 프레임과 현재 프레임 사이의 시간
        Debug.Log(delta);
        if (delta > 3)
        {
            //생성
            GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);
            //위치 재설정
            float randX = UnityEngine.Random.Range(-8, 9);  //-8~8 //UnityEngine : 명시적
            go.transform.position = new Vector3(randX, go.transform.position.y, go.transform.position.z);
            delta = 0;  //경과시간 초기화.
        }
    }
}
