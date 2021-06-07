using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squish : MonoBehaviour
{
    private bool contract = true;
    private float xSpeed = 0.02F;//0.02F;
    private float ySpeed = 0.05F;//0.005F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xScale = (1 + Mathf.Cos(transform.localScale.x - Mathf.PI)) * xSpeed;
        float yScale = (1 + Mathf.Cos(transform.localScale.y - Mathf.PI)) * (xSpeed/2);
        
        if (contract && transform.localScale.x < 2F) // contract
        {
           transform.localScale += new Vector3(xScale, -yScale, 0); 
        }
        else if (!contract && transform.localScale.x > 1F) // expand
        {
            transform.localScale += new Vector3(-xScale, yScale, 0);
        }
        else if (transform.localScale.x > 2F || transform.localScale.x <= 1F) //swap
        {
            contract = !contract;
        }
        
    }
}
