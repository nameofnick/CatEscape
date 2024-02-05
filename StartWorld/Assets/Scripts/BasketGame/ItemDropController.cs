using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        //바닥에 닿아 y축의 값이 0보다 작아질 경우 씬에서 제거.
        if (this.transform.position.y < 0)
        {
            Destroy(this.gameObject);//씬에서 제거.
        }
    }
    //아이템 생성: 사과,폭탄
    //아이템 낙하
    //아이템과 바구니 충돌판정(태그):둘 중 하나에 리짓바디, 둘 다 콜라이더
    //collision mode:OnCollisionEnter
    //trigger mode:OnTriggerEnter
    //사과 획득시 득점, 폭탄 획득시 감점 UI표시
    //속성: 점수
    //XXXGameDirector

}
