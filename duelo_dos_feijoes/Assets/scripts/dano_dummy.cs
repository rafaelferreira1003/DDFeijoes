using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dano_dummy : MonoBehaviour
{
    public int dano = 1;
    public GameObject vida;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vida.GetComponent<vida>().player1life -= dano;
            vida.GetComponent<vida>().UpdateVidaUI();
            vida.GetComponent<vida>().animacao_danoP1 = true;
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            vida.GetComponent<vida>().player2life -= dano;
            vida.GetComponent<vida>().UpdateVidaUI();
            vida.GetComponent<vida>().animacao_danoP2 = true;
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
           Parar();
            Destroy(collision.gameObject);
        }
    }

    public IEnumerator Parar()
    {
        print("Parar");
        GetComponent<Dummy>().velocidade = 0;
        yield return new WaitForSeconds(0.5f);
        { GetComponent<Dummy>().velocidade = 3; }
    }
}
