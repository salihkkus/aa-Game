using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk : MonoBehaviour
{
  Rigidbody2D rb;
  public float hız;

  public bool hareketkısıtlımı;

  public GameObject yönetici;

  public static bool oyunbitti;

    void Start()
    {
        yönetici = GameObject.FindGameObjectWithTag("Yonetici");
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if(hareketkısıtlımı == false)
        rb.MovePosition(rb.position+Vector2.up*hız*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
{
     if(col.gameObject.tag == "DonenBuyukCember")
    {
        transform.SetParent(col.transform);
        hareketkısıtlımı = true;
    }

    if(col.gameObject.tag == "KucukCember") 
    {
        oyunbitti = true;
        yönetici.GetComponent<OyununSonu>().OyunuBitir();
    }

}

}