using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    /*
    private int hp
    {
        get
        {
            return this.hp;
        }
        set 
        { 
            this.hp = value; 
        }
    }//������.
    */

    public int MaxHP
    {
        get; set;
    }

    public int HP
    {
        get; set;
    }
    public System.Action onHit;

    // Start is called before the first frame update
    void Start()
    {
        this.HP = this.MaxHP;
        Debug.LogFormat("{0}/{1}", this.HP, this.MaxHP);
    }

    // Update is called once per frame
    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���ظ� �޴´�.
        if (Input.GetMouseButtonDown(0))
        {
            this.HP -= 1;
            if(this.HP <= 0)this.HP = 0;
            Debug.LogFormat("{0}/{1}", this.HP, this.MaxHP);
            this.onHit();//�븮�� ȣ��
        }
    }
}
