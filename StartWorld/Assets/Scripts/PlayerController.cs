using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float radius = 1f;

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

}
