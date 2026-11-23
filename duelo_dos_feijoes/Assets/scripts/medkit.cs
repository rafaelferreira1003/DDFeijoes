using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class medkit : MonoBehaviour
{
    public GameObject vida;
    public int regeneração = 5;
    public SpriteRenderer imagemp1;
    public SpriteRenderer imagemp2;
    public SpriteRenderer imagemobj;
    public bool estar_no_tutorial;
    void Start()
    {
            imagemp1 = GameObject.Find("perso1/imagem").GetComponent<SpriteRenderer>();
            imagemp2 = GameObject.Find("perso2/imagemp2").GetComponent<SpriteRenderer>();
        imagemobj = GetComponent<SpriteRenderer>();
     vida = GameObject.Find("vida");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && vida.GetComponent<vida>().player1life < 5)
        {
            vida.GetComponent<vida>().player1life = regeneração;
            vida.GetComponent<vida>().UpdateVidaUI();
            imagemobj.enabled = false;
            StartCoroutine(DestruirObjeto("Player"));
        }
        if (other.CompareTag("player2") && vida.GetComponent<vida>().player2life < 5)
            {
             vida.GetComponent<vida>().player2life = regeneração;
             vida.GetComponent<vida>().UpdateVidaUI();
            imagemobj.enabled = false;
            StartCoroutine(DestruirObjeto("Player2"));
        }
    }
    public IEnumerator DestruirObjeto(string player)
    {
        if (player == "Player")
        {
            imagemp1.color = Color.greenYellow;
        }
        else if (player == "player2")
        {
            imagemp2.color = Color.greenYellow;
        }
        yield return new WaitForSeconds(0.3f);
        {
            imagemp1.color = Color.white;
            imagemp2.color = Color.white;
            Destroy(gameObject);
        }

    }
}
