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
        //�ٴڿ� ��� y���� ���� 0���� �۾��� ��� ������ ����.
        if (this.transform.position.y < 0)
        {
            Destroy(this.gameObject);//������ ����.
        }
    }
    //������ ����: ���,��ź
    //������ ����
    //�����۰� �ٱ��� �浹����(�±�):�� �� �ϳ��� �����ٵ�, �� �� �ݶ��̴�
    //collision mode:OnCollisionEnter
    //trigger mode:OnTriggerEnter
    //��� ȹ��� ����, ��ź ȹ��� ���� UIǥ��
    //�Ӽ�: ����
    //XXXGameDirector

}
