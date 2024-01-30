using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    //1. ���콺 ���� Ŭ�� �� 2. ȸ��.
    //���콺 ��ư�� ���������� 5���� ����
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
