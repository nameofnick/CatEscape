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
        //this.gameDirector = GameObject.Find("GameDirector");  //안됨

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
            //힘을 가함
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
        Debug.Log(dirX); //방향

        //좌우반전
        if(dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);

        }

        //벡터의 곱
        Debug.Log(this.transform.right * dirX);  //벡터3

        //속도의 제한.=Mathf //Mathf.Abs: 절대값 반환
        if (Mathf.Abs(this.rBody.velocity.x) < 2)
        {
            this.rBody.AddForce(this.transform.right * dirX * moveForce);
        }
        this.gameDirector.UpdateVelocityText(this.rBody.velocity);

        //애니메이션 스피드
        //this.anim.speed = Mathf.Abs(dirX) / 2.0f;
        this.anim.speed = (Mathf.Abs(this.rBody.velocity.x) / 2f);

        float clampX = Mathf.Clamp(this.transform.position.x, -2.6f, 2.6f);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;

    }
    //trigger 모드일 경우 충돌판정을 해주는 이벤트 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //최초 충돌할 시 한 번만 호출
        Debug.LogFormat("OnTriggerEnter2D :{0}", collision);
        //장면을 전환.
        SceneManager.LoadScene("ClimbCloudClear");
        //코드를 수정하여 한번만 호출되게끔.
        //collision을 쓰든 other을 쓰든 2번 호출됨 if문?
        /* 어디에 쑤셔넣어야하는가?
        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene("ClimbCloud");
        }
        */
    }
    /*
    private void OnTriggerExit2D(Collider2D collision)
    {
        //충돌에서 벗어날 시 한 번만 호출
        Debug.LogFormat("OnTriggerExit2D: {0}", collision);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //충돌 중일시 계속.
        Debug.LogFormat("OnTriggerStay2D: {0}", collision);

    }
    */
    //객체의 고정.못나가게 고정

    //객체의 조건.점프 한번만 되도록

    //객체의 이동.카메라가 플레이어를 따라가도록.
    //메인카메라에 연결할 클래스 생성.
}
