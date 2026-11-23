
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartucho : MonoBehaviour
{
    public int quantidade = 5;
    public SpriteRenderer imagemp1;
    public SpriteRenderer imagemp2;
    public SpriteRenderer imagemobj;
    void Start()
    {
        imagemp1 = GameObject.Find("perso1/imagem").GetComponent<SpriteRenderer>();
        imagemp2 = GameObject.Find("perso2/imagemp2").GetComponent<SpriteRenderer>();
        imagemobj = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        try
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponentInChildren<atirar>().municao += quantidade;
                other.GetComponentInChildren<atirar>().updateAmmoUI();
                imagemobj.enabled = false;
                StartCoroutine(DestruirObjeto("Player"));
            }
            else if (other.CompareTag("player2"))
            {
                other.GetComponentInChildren<atirar2>().municao += quantidade;
                other.GetComponentInChildren<atirar2>().updateAmmoUI();
                imagemobj.enabled = false;
                StartCoroutine(DestruirObjeto("player2"));
            }

        }
        catch { }
    }

    public IEnumerator DestruirObjeto(string player)
    {
        if (player == "Player")
        {
            imagemp1.color = Color.orange;
        }
        else if (player == "player2")
        {
            imagemp2.color = Color.orange;
        }
        yield return new WaitForSeconds(0.3f);
        {
            imagemp1.color = Color.white;
            imagemp2.color = Color.white;
            Destroy(gameObject);
        }
        
    }
}
