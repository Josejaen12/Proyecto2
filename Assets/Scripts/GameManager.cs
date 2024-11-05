using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;

    public void vidaperdida()
    {
        vidas--;
        if (vidas <= 0)
        {
            SceneManager.LoadScene("FindelJuego");

        }
        else 
        {
            ResetLevel(); 
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Bola>().ResetBola();
        FindObjectOfType<Jugador>().ResetJugador();
    }
    //Metodo para pasar de nivel 
    public void CheckNivel()
    {
        if (transform.childCount <=1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }



}
