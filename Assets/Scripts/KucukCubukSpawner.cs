using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubukSpawner : MonoBehaviour
{
    
    public GameObject kucukcubuk;
   

        void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            KucukCubukSpawn();
        }
    }


       void KucukCubukSpawn()
       {
        Instantiate(kucukcubuk,transform.position,transform.rotation);
       }


}
