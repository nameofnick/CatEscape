using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.move();
        /*
        float clampX = Mathf.Clamp(this.transform.position.x, 0, 0);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;
        */
    }
    void move()
    {
        /*
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
        input.GetAxisRaw
        */
        
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, moveY, 0);

        //transform.Translate(new Vector2(moveX, moveY) * Time.deltaTime * moveSpeed);

    }
}
