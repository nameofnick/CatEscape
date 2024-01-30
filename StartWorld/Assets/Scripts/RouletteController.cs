using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    //1. 마우스 왼쪽 클릭 시 2. 회전.
    //마우스 버튼을 누를때마다 5도씩 변경
    [SerializeField]
    private float maxSpeed = 2;
    [SerializeField]
    private float attenuation = 0.95f;
    private float speed = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Button Down");
            speed = maxSpeed;
        }
        this.transform.Rotate(0, 0, speed);
        speed *= attenuation;

        Debug.Log(speed);

    }
}
