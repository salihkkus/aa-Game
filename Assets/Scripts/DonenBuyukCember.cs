using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonenBuyukCember : MonoBehaviour
{
    
    public float hız;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0,0,hız*Time.deltaTime);
    }
}
