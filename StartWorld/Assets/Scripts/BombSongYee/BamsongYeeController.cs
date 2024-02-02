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
        //파티클 시스템 컴포넌트에 접근하여 Play메소드 호출.
        this.particleSystem.Play();
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
    //밤송이 -> 프리팹
    //화면을 터치할 시 밤송이 생성 이후 사출.
    //프리팹 인스턴스를 만들어주는 스크립트:BamSongYeeGenerator
}
