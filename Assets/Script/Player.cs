using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rig;
    [SerializeField]
    int velocidade;
    [SerializeField]
    Animator anima;

   // public Joystick joy;
 
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void FixedUpdate()
    {
        mover();
    }
   void mover(){
        float vertical=Input.GetAxis("Vertical");
        float horizontal=Input.GetAxis("Horizontal"); 
        rig.velocity=new Vector2( horizontal * velocidade,vertical* velocidade);
        
        if(rig.velocity.y < 0){
           anima.SetBool("frente",true);
            anima.SetBool("atras",false);
             anima.SetBool("esquerda",false);
             anima.SetBool("direita",false);
        } else if(rig.velocity.y >0){
            anima.SetBool("atras",true);
              anima.SetBool("frente",false);
               anima.SetBool("esquerda",false);
               anima.SetBool("direita",false);
        }else if(rig.velocity.x < 0){
            anima.SetBool("esquerda",true);
            anima.SetBool("frente",false);
            anima.SetBool("atras",false);
            anima.SetBool("direita",false);
        }else if(rig.velocity.x > 0){
            anima.SetBool("direita",true);
            anima.SetBool("frente",false);
            anima.SetBool("atras",false);
            anima.SetBool("esquerda",false);
        }
        else{
            anima.SetBool("frente",false);
            anima.SetBool("atras",false);
            anima.SetBool("esquerda",false);
            anima.SetBool("direita",false);
        }
   
    }


}