using UnityEngine;

public class arbusto_mov : MonoBehaviour
{
    public int velocidade = 5;
    public GameObject vida;
    void Start()
    {
        vida = GameObject.Find("vida");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            vida.GetComponent<vida>().player1life = vida.GetComponent<vida>().player1life - 1;
            vida.GetComponent<vida>().animacao_danoP1 = true;
            vida.GetComponent<vida>().UpdateVidaUI();
            Destroy(gameObject);
        }
        if (collision.CompareTag("player2"))
        {
            vida.GetComponent<vida>().player2life = vida.GetComponent<vida>().player2life - 1;
            vida.GetComponent<vida>().animacao_danoP2 = true;
            vida.GetComponent<vida>().UpdateVidaUI();
            Destroy(gameObject);
        }
        if (collision.CompareTag("tiro"))
        {
            Destroy(gameObject);

        }
       

    }
}
