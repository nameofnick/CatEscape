using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowGenerator : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    private float delta;    //����� �ð� ����
    // Start is called before the first frame update
    /*
    void Start()
    {
        GameObject go = Instantiate(this.arrowPrefab);  //������ �ν��Ͻ�
        //������ ���¿� ������ ��ġ
        //��ġ �缳��
        Debug.LogFormat("go : {0}", go);
    }
    */

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;    //���� �����Ӱ� ���� ������ ������ �ð�
        Debug.Log(delta);
        if (delta > 3)
        {
            //����
            GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);
            //��ġ �缳��
            float randX = UnityEngine.Random.Range(-8, 9);  //-8~8 //UnityEngine : �����
            go.transform.position = new Vector3(randX, go.transform.position.y, go.transform.position.z);
            delta = 0;  //����ð� �ʱ�ȭ.
        }
    }
}
