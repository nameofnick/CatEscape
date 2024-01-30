using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] private float maxSpeed = 0.1f;
    [SerializeField] private float attenuation = 0.95f;
    [SerializeField] private float divideNum = 500f;

    private float speed = 0;
    private Vector3 startPosition;

    // Update is called once per frame
    void Update()
    {
        //왼쪽 버튼을 눌렀다면
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touch Down");
            //speed = maxSpeed;
            //화면을 터지한 위치 가져오기
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;

        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("Touch");

            //터치한 지점
            Debug.Log(Input.mousePosition);

            //화면에서 손을 뗀 지점의 x - 터지한 지점의 x
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length / divideNum);
            speed = length / divideNum;
            Debug.LogFormat("<color=green>speed: {0}</color>", speed);  //<color=ㅁㅁ> : 폰트 색상

        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Touch Up");
        }


        ////0.1유닛씩 매 프레임마다 이동.
        //this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
        ////매 프레임마다 스피드 감속
        //speed *= attenuation;
    }
}
