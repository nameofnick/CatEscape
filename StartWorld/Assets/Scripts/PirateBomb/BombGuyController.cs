using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    [SerializeField] Transform flagTransform;
    //BombGuyController가 Animator 컴포넌트를 알아야한다 : 애니메이션 전환을 위해서
    //Animator 컴포넌트는 자식 오브젝트 anim에 붙어있다. 이렇게하면 자식 오브젝트에 붙어있는 Animator 컴포넌트를 가져올 수 있다.
    [SerializeField] private Animator anim;
    private Coroutine coroutine;

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start");
        /*
        Transform animTransform = this.transform.Find("anim");
        GameObject animGo = animTransform.gameObject;
        this.anim = animGo.GetComponent<Animator>();
        */
        //코루틴 함수 호출시
        //MonoBehaviour.start; monobehaviour를 상속받는 모든 것들은 this 사용가능.
        //this.coroutine = this.StartCoroutine(this.CoMove());//호출
        //this.StartCoroutine(this.CoMove()); : null
        //Debug.LogFormat("coroutine : {0}", this.coroutine);
        this.coroutine = this.StartCoroutine(this.CoMove(() => { Debug.LogFormat("이동을 모두 완료 했습니다."); }));
    }
    IEnumerator CoMove(System.Action callback)
    {
        //매 프레임마다 앞으로 이동.
        while (true)
        {
            this.transform.Translate(transform.right * 1f * Time.deltaTime);
            Vector3.Distance(this.transform.position, this.flagTransform.position);
            float length = this.flagTransform.position.x - this.transform.position.x;
            Debug.LogFormat("남은 거리 : {0}", length);
            if (length < 1)
            {
                break;
            }
            yield return null;  //다음 프레임으로 넘어감
        }
        Debug.Log("이동완료");
        yield return null;
        Debug.Log("End Of CoMove");
        callback();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //코루틴 멈추기 
            StopCoroutine(this.coroutine);
        }
        /*
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("Idle");
            //애니메이션 전환하기. 전환할 때 파라미터의 값을 변경하기.
            this.anim.SetInteger("State", 0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anim.SetInteger("State", 1);

        }
        */
    }
}
