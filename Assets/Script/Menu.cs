using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class Menu : MonoBehaviour
{
    public string cena;
    public void Inicio(){
       
        SceneManager.LoadScene(cena);
    }
}