using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{
    float direction = 0.01f;
    float scale = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction = direction * (-1);
            scale = scale * (-1);
            transform.localScale = new Vector3(scale, 1, 1);
        }
        if(transform.position.x > 2.8f)
        {
            direction = - 0.01f;
            scale = scale * (-1);
            transform.localScale = new Vector3(scale, 1, 1);
        }
        else if(transform.position.x < -2.8f)
        {
            direction = 0.01f;
            scale = scale * (-1);
            transform.localScale = new Vector3(scale, 1, 1);
        }
        transform.position += new Vector3(direction, 0, 0);
    }
}
