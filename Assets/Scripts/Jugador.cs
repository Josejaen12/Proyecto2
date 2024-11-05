using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Rigidbody2D ribidbody2D;

    private float inputValue;

    public float moveSpeed = 25;

    private Vector2 direction;

    Vector2 PocisionInicial;



    private void Start()
    {
        PocisionInicial = transform.position;
    }


    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");
        if (inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if (inputValue == -1)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        ribidbody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);


    }
    public void ResetJugador()
    {
        transform.position = PocisionInicial;
        ribidbody2D.velocity = Vector2.zero;

    }



}
