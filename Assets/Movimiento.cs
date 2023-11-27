using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f; 
    private SpriteRenderer sr; 

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(Horizontal, Vertical) * velocidad * Time.deltaTime;

        Vector2 newPosition = (Vector2)transform.position + movimiento;
        transform.position = newPosition;
    }

}
