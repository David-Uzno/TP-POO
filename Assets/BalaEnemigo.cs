using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    public float velocidad;
    public int da�o;
    
    void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * Vector2.right);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Jugador jugador))
        {
            jugador.PerderVida();
        }
    }
}