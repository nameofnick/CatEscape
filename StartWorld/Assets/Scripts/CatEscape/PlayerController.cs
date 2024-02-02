using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CatEscapeGameDirector gameDirector;
    [SerializeField] private Button btnLeft;
    [SerializeField] private Button btnRight;


    public float radius = 1f;


    public void Start()
    {
        //this.btnLeft.onClick.AddListener(this.LeftButtonClick);
        //this.btnRight.onClick.AddListener(this.RightButtonClick);
        this.btnLeft.onClick.AddListener(() => { Debug.Log("���� ȭ��ǥ ��ư Ŭ��");});
        this.btnRight.onClick.AddListener(() => { Debug.Log("������ ȭ��ǥ ��ư Ŭ��"); });

    }


    // Update is called once per frame
    void Update()
    {
        //Ű���� �Է��� �޴� �ڵ�.
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� 1���ָ�ŭ �̵�");
            //x������ -2��ŭ
            this.transform.Translate(-1, 0, 0); //2������ �ʹ� ���� �̵�

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� 1���ָ�ŭ �̵�");
            //x������ 2��ŭ
            this.transform.Translate(1, 0, 0);

        }
        float clampX = Mathf.Clamp(this.transform.position.x, -8, 8);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;
        //Mathf.Clamp �ٽ� Ȯ���Ұ�.
    }
    //�̺�Ʈ �Լ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
    public void LeftButtonClick()
    {
        Debug.Log("Left Button Click");
    }
    public void RightButtonClick()
    {
        Debug.Log("Right Button Click");
    }

}
