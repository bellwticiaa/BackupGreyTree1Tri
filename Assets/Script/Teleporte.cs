using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Cinemachine;
 
 
public class Teleporte : MonoBehaviour
{
    public Transform destino; // Ponto para onde o jogador será teleportado
    public GameObject chave;
    public PolygonCollider2D[] limites; // definir quem são os limites do jogo
    public CinemachineConfiner2D confinamentoCam; // extensão da camera virtual de confinamento
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que entrou no trigger é o jogador
        if (other.CompareTag("Player"))
        {
                    confinamentoCam.m_BoundingShape2D=limites[1];
                    other.transform.position = destino.position;
                    //colisor.SetActive(false);
                    chave.SetActive(false);
        }
    }


 
}