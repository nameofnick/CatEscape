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
        this.btnLeft.onClick.AddListener(() => { Debug.Log("왼쪽 화살표 버튼 클릭");});
        this.btnRight.onClick.AddListener(() => { Debug.Log("오른쪽 화살표 버튼 클릭"); });

    }


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
    public void LeftButtonClick()
    {
        Debug.Log("Left Button Click");
    }
    public void RightButtonClick()
    {
        Debug.Log("Right Button Click");
    }

}
