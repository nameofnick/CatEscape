using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] private GameObject catPlayer;
    // Start is called before the first frame update
    void Start()
    {
        this.catPlayer = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPlayerPos = this.catPlayer.transform.position;
        transform.position = new Vector3(transform.position.x, catPlayerPos.y, transform.position.z);
    }
}
