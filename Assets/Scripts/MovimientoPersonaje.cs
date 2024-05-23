using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private float velocidadCaminando = 2f;
    private float velocidadCorriendo = 5f;
    private bool estaCorriendo = false;
    private Vector2 fuerzaMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        fuerzaMovimiento = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        if (estaCorriendo)
        {
            fuerzaMovimiento.x = inputX * velocidadCorriendo * Time.deltaTime; 
        }
        else
        {
            fuerzaMovimiento.x = inputX * velocidadCaminando * Time.deltaTime; 
        }

        GetComponent<Rigidbody2D>().AddForce(fuerzaMovimiento);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            estaCorriendo = true;
        }
        else
        {
            estaCorriendo = false;
        }
    }
}

