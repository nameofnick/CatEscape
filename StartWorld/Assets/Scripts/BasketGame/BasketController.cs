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
        //ȭ���� Ŭ���Ͽ� ��ġ ǥ��:ray�� �浹����.
        if (Input.GetMouseButtonDown(0))
        {
            //ray ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //�������� RaycastHit ����
            RaycastHit hit;
            //if�� �ۼ�
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                //Debug.LogFormat("��ġ : {0}", hit.point);
                int posX = Mathf.RoundToInt(hit.point.x);
                int posZ = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(posX, 0, posZ);
            }
        }
        
    }
    //�ٱ��� �̵�
    //������ ����
    //������ �̵�
    //�浹 ����
    //������ UI�� ǥ��
    //ȭ���� Ŭ���Ͽ� ��ġ ǥ��
    //������ ����: ���,��ź
    //������ ����
    //�����۰� �ٱ��� �浹����(�±�):�� �� �ϳ��� �����ٵ�, �� �� �ݶ��̴�
    //collision mode:OnCollisionEnter
    //trigger mode:OnTriggerEnter
    //��� ȹ��� ����, ��ź ȹ��� ���� UIǥ��
    //�Ӽ�: ����
    //XXXGameDirector
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("ȹ�� : {0}", other.gameObject.tag);
        /*
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("����");
        }
        */
        if (other.CompareTag("Apple"))
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.bombSfx);
        }
        Destroy(other.gameObject);

    }
}
