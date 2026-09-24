using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class destruirCaixa : MonoBehaviour
{
    public int vida = 4;
    public int dano = 1;
    public SpriteRenderer imagem;
    public AudioSource audioSource;
    public GameObject medkit;
    public GameObject cartucho;
    int tipo_item;
    void Start()
    {
        imagem = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        medkit = GameObject.Find("medkit");
        cartucho = GameObject.Find("cartucho");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colidiu com: " + other.gameObject.name);
        if (other.CompareTag ("tiro"))
        {
            Destroy(other.gameObject);
            levarDano();
        }
       
    }
    public void levarDano()
    {
        vida = vida - dano;

        if (vida < 0)
        {
            GetComponent<Animator>().SetBool("destruir_caixa", true);
            GetComponent<BoxCollider2D>().enabled = false;
            imagem.sortingLayerName = "default";
            audioSource.Play();
            int chance = Random.Range(1, 101);
            if (chance > 75)
            {
                int tipo_item = Random.Range(0, 2);
                if ( tipo_item == 0)
                {
                Instantiate(medkit, transform.position, Quaternion.identity);
                }
                else if ( tipo_item == 1)
                {
                Instantiate(cartucho, transform.position, Quaternion.identity);
                }
            }
            
        }

        else
        {
            GetComponent<Animator>().SetBool("dano_caixa", true);
        }
    }

}
