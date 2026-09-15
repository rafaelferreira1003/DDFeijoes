using UnityEngine;
using UnityEngine.Audio;

public class destruirCaixa : MonoBehaviour
{
    public int vida = 4;
    public int dano = 1;
    public SpriteRenderer imagem;
    public AudioSource audioSource;

    void Start()
    {
        imagem = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("tiro"))
        {
            vida = vida - dano;
            Destroy(other.gameObject);
            if (vida < 0)
            {GetComponent<Animator>().SetBool("destruir_caixa", true);
                GetComponent<BoxCollider2D>().enabled = false;
                imagem.sortingLayerName  = "default";
                audioSource.Play();
            }

            else {
                GetComponent<Animator>().SetBool("dano_caixa", true);
            }

        }
    }
}
