using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 1f;

    //�������� �����Ǵ� ���� Assign �Ұ���
    private CatEscapeGameDirector gameDirector;

    private GameObject playerGo;


    private void Start()
    {
        //�̸����� ���ӿ�����Ʈ Ž��
        this.playerGo = GameObject.Find("player");
        //Ÿ������ ������Ʈ Ž��
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        //����*�ӵ�*�ð�
        
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);
        
        //���� y��ǥ�� -3���� �������� �� ������ ����.
        if (this.transform.position.y <= -3)
        {
            //Debug.LogError("����");
            //Destroy(this);//ȭ���� �ƴ� Arrowcontroller�� ������
            Destroy(this.gameObject);   //���� ������Ʈ�� ������ ����
        }
        //�Ÿ�
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2;  //����
        float distance = dir.magnitude; //�Ÿ�
        //float distance = Vector2.Distance(p1, p2);

        float r1 = this.radius;
        //float r2 = this.playerGo.radius;    //�Ұ��� : playerGo�� ���� ������Ʈ
        //float r2 = this.GetComponent<PlayerController>().radius;
        PlayerController controller = this.playerGo.GetComponent<PlayerController>();
        float r2 = controller.radius;

        float sumRadius = r1 + r2;
        if (distance < sumRadius)   //�浹��(���ƴ�)
        {
            Debug.LogFormat("�浹��: {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject);   //�浹�� ����

            this.gameDirector.DecreaseHp();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

}
