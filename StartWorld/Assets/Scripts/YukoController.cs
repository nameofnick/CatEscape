using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukoController : MonoBehaviour
{
    private Coroutine coroutine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 20, Color.red, 5);
            RaycastHit hit;
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                Vector3 tpos = this.transform.position;
                tpos.x = hit.point.x;
                tpos.y = 0;
                tpos.z = hit.point.z;
                Debug.Log(tpos);
                //this.transform.position = tpos;
                if (this.coroutine != null) StopCoroutine(this.coroutine);

                this.coroutine = StartCoroutine(this.CoMove(tpos));
            }
        }
    }
    IEnumerator CoMove(Vector3 tpos)
    {
        /*
        while (true)
        {
            yield return null;
        }
        */
        this.transform.LookAt(tpos);//�ٶ󺻴�.
        while (true)
        {
            this.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
            float distance = (tpos = this.transform.position).magnitude;
            Debug.LogFormat("distance : {0}", distance);
            if (distance <= 0.1f)
            {
                break;
            }
            yield return null;
        }
        Debug.Log("�̵� �Ϸ�");
        //�ڷ�ƾ�� �ߺ���
        //�ڷ�ƾ�� ���������� ���� �ڷ�ƾ ����.
    }
}
