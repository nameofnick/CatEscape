using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatContoller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rBody;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private float moveForce = 10f;

    [SerializeField] private ClimbCloudGameDirector gameDirector;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //this.gameDirector = GameObject.Find("GameDirector");  //�ȵ�

        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();

        //this.gameObject.GetComponent<Animator>();
        //this.anim = GetComponent<Animator>();
        anim = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.rBody.velocity.y == 0)
        {
            //���� ����
            this.rBody.AddForce(this.transform.up * this.jumpForce);
            //this.rBody.AddForce(Vector3.up * this.force);

        }
        int dirX = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
            //transform.localScale = new Vector3(dirX, 1, 1);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
            //transform.localScale = new Vector3(dirX, 1, 1);

        }
        Debug.Log(dirX); //����

        //�¿����
        if(dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);

        }

        //������ ��
        Debug.Log(this.transform.right * dirX);  //����3

        //�ӵ��� ����.=Mathf //Mathf.Abs: ���밪 ��ȯ
        if (Mathf.Abs(this.rBody.velocity.x) < 2)
        {
            this.rBody.AddForce(this.transform.right * dirX * moveForce);
        }
        this.gameDirector.UpdateVelocityText(this.rBody.velocity);

        //�ִϸ��̼� ���ǵ�
        //this.anim.speed = Mathf.Abs(dirX) / 2.0f;
        this.anim.speed = (Mathf.Abs(this.rBody.velocity.x) / 2f);

        float clampX = Mathf.Clamp(this.transform.position.x, -2.6f, 2.6f);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;

    }
    //trigger ����� ��� �浹������ ���ִ� �̺�Ʈ �Լ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� �浹�� �� �� ���� ȣ��
        Debug.LogFormat("OnTriggerEnter2D :{0}", collision);
        //����� ��ȯ.
        SceneManager.LoadScene("ClimbCloudClear");
        //�ڵ带 �����Ͽ� �ѹ��� ȣ��ǰԲ�.
        //collision�� ���� other�� ���� 2�� ȣ��� if��?
        /* ��� ���ų־���ϴ°�?
        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene("ClimbCloud");
        }
        */
    }
    /*
    private void OnTriggerExit2D(Collider2D collision)
    {
        //�浹���� ��� �� �� ���� ȣ��
        Debug.LogFormat("OnTriggerExit2D: {0}", collision);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //�浹 ���Ͻ� ���.
        Debug.LogFormat("OnTriggerStay2D: {0}", collision);

    }
    */
    //��ü�� ����.�������� ����

    //��ü�� ����.���� �ѹ��� �ǵ���

    //��ü�� �̵�.ī�޶� �÷��̾ ���󰡵���.
    //����ī�޶� ������ Ŭ���� ����.
}
