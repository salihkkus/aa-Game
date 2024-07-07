using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(KucukCubuk.oyunbitti == true)
        {
            anim.SetBool("OyunBitti", true);
        }
    }

}
