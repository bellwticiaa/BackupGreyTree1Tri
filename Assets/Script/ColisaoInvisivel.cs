using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ColisaoInvisivel : MonoBehaviour
{
    SpriteRenderer sr;
    void Start()
    {
        sr=GetComponent<SpriteRenderer>();
    }
 
    void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color=new Color(1f,1f,1f,0.3f);
    }
       void OnTriggerExit2D(Collider2D collision)
    {
        sr.color=new Color(1f,1f,1f,1f);
    }
}