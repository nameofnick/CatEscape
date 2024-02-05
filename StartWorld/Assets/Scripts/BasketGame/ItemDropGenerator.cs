using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    private GameObject itemDrop;
    private float delta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > 3)
        {
            int appleDice = Random.Range(1, 10);
            int bombDropping = 4;
            if (appleDice >= bombDropping)
            {
                itemDrop = Object.Instantiate(applePrefab);
            }
            else
            {
                itemDrop = Object.Instantiate(bombPrefab);

            }
            float posX = Random.Range(-1, 2);
            float posZ = Random.Range(-1, 2);

            itemDrop.transform.position=new Vector3(posX, 4, posZ);
            delta = 0;
        }
    }
}
