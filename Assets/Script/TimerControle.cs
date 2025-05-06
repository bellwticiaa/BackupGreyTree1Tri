using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
 
public class TimerControle : MonoBehaviour
{
    public float tempoMaximo = 120f; // Tempo inicial em segundos (2 minutos)
    private float tempoAtual;
    private bool timerAtivo = true;
 
    public TMP_Text textoTimer; // Arraste um Text do Canvas aqui no Inspector
 
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
        timerAtivo = false; // Para o timer
    }
 
    void PerderJogo()
    {
        Debug.Log("Tempo esgotado! Você perdeu!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
}
