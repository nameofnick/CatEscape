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
        //ȭ���� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            //�ȼ� ��ǥ�� ������ �ʵ� �ȿ��� ���� ��ü ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //���� ��ü�� ���� �Ӽ�
            //ray.origin : ���� ��ġ
            //ray.direction : ����
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10f/*������ġ,����,����,����ð�*/);

            //ray�� �ö��̴� �浹 üũ

            //Raycast
            //1.Raycast ȣ�� ���� ���� RaycastHit �������� ����.
            RaycastHit hit;//�浹�ߴٸ� �浹 ������ ��� ����
            //2.Physics.Raycast(������ġ,����,out hit,length);
            //���̿� �ö��̴� �浹�� true�� ��ȯ �ƴ� �� false ��ȯ.
            //3.���ù� if(condition)
            //4.���࿡ �浹 �ߴٸ� ���ù� ����
            //if(condition){
            //���̿� �ö��̴��� �浹��
            //�浹 ���� �� ����Ʈ ������ ��ġ �ľ� ����
            //������ ������ �������� hit�� �������}
            if(Physics.Raycast(ray.origin, ray.direction * 20f, out hit, 10f))
            {
                //���̿� �ö��̴��� �浹
                Debug.Log("�浹��");
                Debug.LogFormat(" : {0}", hit.point);
                this.cubetransform.position = hit.point;
            }

            //trigger mode : OnTriggerEnter
            //��� ������ ���� ��ź ������ ����
        }
    }
}
