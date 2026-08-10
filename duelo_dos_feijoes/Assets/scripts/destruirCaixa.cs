using UnityEngine;

public class destruirCaixa : MonoBehaviour
{
    public int vida = 4;
    public int dano = 1;
    public SpriteRenderer imagem;


    void Start()
    {
        imagem = GetComponent<SpriteRenderer>();
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
            }

            else {
                GetComponent<Animator>().SetBool("dano_caixa", true);
            }

        }
    }
}
