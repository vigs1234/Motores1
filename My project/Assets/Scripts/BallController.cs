using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int velocidade = 5;
    private Vector2 direcao;

   
    void Start()
    {
        TryGetComponent(out rb);
        direcao = Random.insideUnitCircle.normalized;
        direcao = new Vector2(direcao.x, 1).normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bloco"))
        {
            Destroy(collision.gameObject);
        }        

         if(collision.gameObject.CompareTag("refB"))
        {
            collision.gameObject.GetComponent<Blocorefor>().Tomouhit();
        }      
         if(collision.gameObject.CompareTag("Dangerzona"))
         {
            GameManager.instance.GameOver();
            Destroy(gameObject);
         }
        direcao = Vector2.Reflect(direcao, collision.contacts[0].normal);        
    }
    void FixedUpdate()
    {
        rb.velocity = direcao * velocidade;
    }
}
