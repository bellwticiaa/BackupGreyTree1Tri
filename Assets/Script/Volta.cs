using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Cinemachine;
 
 
 
public class Volta : MonoBehaviour
{
    public Transform destino; // Ponto para onde o jogador será teleportado
    public GameObject colisor;
      public PolygonCollider2D[] limites; // definir quem são os limites do jogo
    public CinemachineConfiner2D confinamentoCam; // extensão da camera virtual de confinamento
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que entrou no trigger é o jogador
        if (other.CompareTag("Player"))
        {
                    other.transform.position = destino.position;
                    colisor.SetActive(false);
                    confinamentoCam.m_BoundingShape2D=limites[0];
               
        }
    }
 
}