using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dano_dummy : MonoBehaviour
{
    public int dano = 1;
    public GameObject vida;
    public SpriteRenderer imagem;

    void Start()
    {
        vida = GameObject.Find("vida");
        imagem = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vida.GetComponent<vida>().player1life -= dano;
            vida.GetComponent<vida>().UpdateVidaUI();
            vida.GetComponent<vida>().animacao_danoP1 = true;
        }
        else if (collision.gameObject.CompareTag("player2"))
        {
            vida.GetComponent<vida>().player2life -= dano;
            vida.GetComponent<vida>().UpdateVidaUI();
            vida.GetComponent<vida>().animacao_danoP2 = true;
        }
        else { }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("tiro"))
        {
            Destroy(other.gameObject);
            StartCoroutine(Parar());
        }
    }

    public IEnumerator Parar()
    {
        print("Parar");
        GetComponent<Dummy>().velocidade = 0;
        imagem.color = Color.antiqueWhite;
        yield return new WaitForSeconds(0.5f);
        { GetComponent<Dummy>().velocidade = 3; 
            imagem.color = Color.white;
        }
    }
}
