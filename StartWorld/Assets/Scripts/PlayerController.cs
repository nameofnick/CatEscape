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
        //키보드 입력을 받는 코드.
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 1유닛만큼 이동");
            //x축으로 -2만큼
            this.transform.Translate(-1, 0, 0); //2유닛은 너무 많이 이동

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 1유닛만큼 이동");
            //x축으로 2만큼
            this.transform.Translate(1, 0, 0);

        }
        float clampX = Mathf.Clamp(this.transform.position.x, -8, 8);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;
        //Mathf.Clamp 다시 확인할것.
    }
    //이벤트 함수
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

}
