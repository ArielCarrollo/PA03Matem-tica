using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private float velocidadCaminando = 2f;
    private float velocidadCorriendo = 5f;
    private bool estaCorriendo = false;
    private Vector2 fuerzaMovimiento;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        fuerzaMovimiento = Vector2.zero;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        estaCorriendo = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        float velocidadActual = estaCorriendo ? velocidadCorriendo : velocidadCaminando;

        fuerzaMovimiento.x = inputX * velocidadActual;

        rb2d.AddForce(new Vector2(fuerzaMovimiento.x, 0f));
    }
}

