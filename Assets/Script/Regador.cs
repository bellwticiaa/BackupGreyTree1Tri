using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Regador : MonoBehaviour


{
     public TMP_Text textoFinal;

        public Animator animRegador;
    void OnTriggerEnter2D(Collider2D col)
    {
          if(col.gameObject.tag=="Player"){
            transform.SetParent(col.transform);
        }
                if(col.tag=="flores"){
            animRegador.enabled=true;
        }
    }
     public void AparecerObjetivo()
    {
        textoFinal.text = "Objetivo: Volte para o canteiro e regue as flores";
        
    }
        void OnTriggerExit2D(Collider2D col)
    {
          if(col.tag=="flores"){
            animRegador.enabled=false;
        }
         AparecerObjetivo();
    }

}