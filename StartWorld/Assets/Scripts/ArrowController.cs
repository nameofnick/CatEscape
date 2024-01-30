using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 1f;

    //동적으로 생성되는 것은 Assign 불가능
    private CatEscapeGameDirector gameDirector;

    private GameObject playerGo;


    private void Start()
    {
        //이름으로 게임오브젝트 탐색
        this.playerGo = GameObject.Find("player");
        //타입으로 컴포넌트 탐색
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        //방향*속도*시간
        
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);
        
        //현재 y좌표가 -3보다 낮아졌을 때 씬에서 제거.
        if (this.transform.position.y <= -3)
        {
            //Debug.LogError("제거");
            //Destroy(this);//화살이 아닌 Arrowcontroller가 삭제됨
            Destroy(this.gameObject);   //게임 오브젝트를 씬에서 제거
        }
        //거리
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2;  //방향
        float distance = dir.magnitude; //거리
        //float distance = Vector2.Distance(p1, p2);

        float r1 = this.radius;
        //float r2 = this.playerGo.radius;    //불가능 : playerGo가 게임 오브젝트
        //float r2 = this.GetComponent<PlayerController>().radius;
        PlayerController controller = this.playerGo.GetComponent<PlayerController>();
        float r2 = controller.radius;

        float sumRadius = r1 + r2;
        if (distance < sumRadius)   //충돌함(겹쳤다)
        {
            Debug.LogFormat("충돌함: {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject);   //충돌시 제거

            this.gameDirector.DecreaseHp();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

}
