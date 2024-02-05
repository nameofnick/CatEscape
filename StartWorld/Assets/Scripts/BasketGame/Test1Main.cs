using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{
    [SerializeField] Transform cubetransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //화면을 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            //픽셀 좌표를 가지고 필드 안에서 레이 객체 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이 객체가 지닌 속성
            //ray.origin : 시작 위치
            //ray.direction : 방향
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10f/*시작위치,방향,색상,조사시간*/);

            //ray와 컬라이더 충돌 체크

            //Raycast
            //1.Raycast 호출 전에 먼저 RaycastHit 지역변수 선언.
            RaycastHit hit;//충돌했다면 충돌 정보를 담는 변수
            //2.Physics.Raycast(시작위치,방향,out hit,length);
            //레이와 컬라이더 충돌시 true를 반환 아닐 시 false 반환.
            //3.선택문 if(condition)
            //4.만약에 충돌 했다면 선택문 본문
            //if(condition){
            //레이와 컬라이더가 충돌함
            //충돌 정보 중 임팩트 지점의 위치 파악 가능
            //위에서 선언한 지역변수 hit에 담겨있음}
            if(Physics.Raycast(ray.origin, ray.direction * 20f, out hit, 10f))
            {
                //레이와 컬라이더가 충돌
                Debug.Log("충돌함");
                Debug.LogFormat(" : {0}", hit.point);
                this.cubetransform.position = hit.point;
            }

            //trigger mode : OnTriggerEnter
            //사과 먹으면 득점 폭탄 먹으면 감점
        }
    }
}
