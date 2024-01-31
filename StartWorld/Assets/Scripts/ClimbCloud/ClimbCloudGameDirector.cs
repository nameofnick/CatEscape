using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClimbCloudGameDirector : MonoBehaviour
{
    [SerializeField] private Text velocityText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateVelocityText(Vector2 velocity)
    {
        float velocityX = Mathf.Abs(velocity.x);
        this.velocityText.text = velocity.ToString();
    }
}
