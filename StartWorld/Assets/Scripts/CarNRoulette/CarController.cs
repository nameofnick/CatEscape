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
        //���� ��ư�� �����ٸ�
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touch Down");
            //speed = maxSpeed;
            //ȭ���� ������ ��ġ ��������
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;

        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("Touch");

            //��ġ�� ����
            Debug.Log(Input.mousePosition);

            //ȭ�鿡�� ���� �� ������ x - ������ ������ x
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length / divideNum);
            speed = length / divideNum;
            Debug.LogFormat("<color=green>speed: {0}</color>", speed);  //<color=����> : ��Ʈ ����

        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Touch Up");
        }


        ////0.1���־� �� �����Ӹ��� �̵�.
        //this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
        ////�� �����Ӹ��� ���ǵ� ����
        //speed *= attenuation;
    }
}
