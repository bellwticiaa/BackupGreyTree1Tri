using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class Chave : MonoBehaviour
{

    public float tempoMaximo = 120f; // Tempo inicial em segundos (2 minutos)
    private float tempoAtual;
    private bool timerAtivo = true;
 
    public TMP_Text textoTimer; // Arraste um Text do Canvas aqui no Inspector
    public GameObject cadeado;
 
    public TMP_Text textoObjetivo;
    
    void Start()
    {
        tempoAtual = tempoMaximo;
    }
 
    void Update()
    {
        if (timerAtivo)
        {
            tempoAtual -= Time.deltaTime; // Contagem regressiva
 
            // Atualiza o texto do Timer no UI
            textoTimer.text = "Tempo: " + Mathf.CeilToInt(tempoAtual) + "s";
 
            // Se o tempo acabar, o jogador perde
            if (tempoAtual <= 0)
            {
                PerderJogo();
            }
        }
    }
 
    public void PararTimer()
    {
        textoTimer.text = "";
        timerAtivo = false; // Para o timer
    }
 
   public void SumirObjetivo()
    {
        textoObjetivo.text = " ";
        
    }

    void PerderJogo()
    {
        Debug.Log("Tempo esgotado! Você perdeu!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
       
    void OnTriggerEnter2D(Collider2D col)
    {
          if(col.gameObject.tag=="Player"){
            transform.SetParent(col.transform);
            cadeado.SetActive(true);
            PararTimer();
            SumirObjetivo();
        }
    }

    
}