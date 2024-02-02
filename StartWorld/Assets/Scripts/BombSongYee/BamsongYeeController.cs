using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongYeeController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particleSystem;


    // Start is called before the first frame update
    void Start()
    {
        /*
        //this.gameObject.GetComponent<Rigidbody>();
        this.rbody = this.GetComponent<Rigidbody>();
        this.rbody.AddForce(new Vector3(0, 200, 2000));
        */
        this.rbody = this.GetComponent<Rigidbody>();
        this.particleSystem = this.GetComponent<ParticleSystem>();
        this.Shoot();
    }

    private void Shoot()
    {
        this.rbody.AddForce(new Vector3(0, 200, 2000));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("OnCollisionEnter : {0}", collision.gameObject.name);
        this.rbody.isKinematic = true;
        //��ƼŬ �ý��� ������Ʈ�� �����Ͽ� Play�޼ҵ� ȣ��.
        this.particleSystem.Play();
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
    //����� -> ������
    //ȭ���� ��ġ�� �� ����� ���� ���� ����.
    //������ �ν��Ͻ��� ������ִ� ��ũ��Ʈ:BamSongYeeGenerator
}
