using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Bola : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;

    public float speed = 300;

    private Vector2 velocity;

    Vector2 PocisionInicial;

    public AudioSource audioSource;

    public AudioClip AudioJugador,AudioLadrillo,AudioZonaPerdida;




    void Start()
    {        PocisionInicial = transform.position;
       
        ResetBola();

    }
    //Metodo para verificar cuando se pierde
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ZonaPerdida"))
        {
            audioSource.clip = AudioZonaPerdida;
            audioSource.Play();
            FindAnyObjectByType<GameManager>().vidaperdida();
        }
        if (collision.gameObject.GetComponent<Jugador>())
        {
            audioSource.clip = AudioJugador;
            audioSource.Play();

        }
        if (collision.gameObject.GetComponent<Ladrillos>())
        {
            audioSource.clip = AudioLadrillo;
            audioSource.Play();

        }
        if (collision.transform.CompareTag("Wall"))
        {
            audioSource.clip = AudioZonaPerdida;
            audioSource.Play();

        }

    }

    public void ResetBola()
    {

        transform.position = PocisionInicial;
        rigidbody2D.velocity = Vector2.zero;


        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1;

        rigidbody2D.AddForce(velocity* speed);
        }


}
