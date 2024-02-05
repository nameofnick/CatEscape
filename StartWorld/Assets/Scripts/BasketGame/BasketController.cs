using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //화면을 클릭하여 위치 표시:ray와 충돌판정.
        if (Input.GetMouseButtonDown(0))
        {
            //ray 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //지역변수 RaycastHit 선언
            RaycastHit hit;
            //if문 작성
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                //Debug.LogFormat("위치 : {0}", hit.point);
                int posX = Mathf.RoundToInt(hit.point.x);
                int posZ = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(posX, 0, posZ);
            }
        }
        
    }
    //바구니 이동
    //아이템 생성
    //아이템 이동
    //충돌 판정
    //점수를 UI에 표시
    //화면을 클릭하여 위치 표시
    //아이템 생성: 사과,폭탄
    //아이템 낙하
    //아이템과 바구니 충돌판정(태그):둘 중 하나에 리짓바디, 둘 다 콜라이더
    //collision mode:OnCollisionEnter
    //trigger mode:OnTriggerEnter
    //사과 획득시 득점, 폭탄 획득시 감점 UI표시
    //속성: 점수
    //XXXGameDirector
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("획득 : {0}", other.gameObject.tag);
        /*
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("득점");
        }
        */
        if (other.CompareTag("Apple"))
        {
            Debug.Log("득점");
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("감점");
            this.audioSource.PlayOneShot(this.bombSfx);
        }
        Destroy(other.gameObject);

    }
}
