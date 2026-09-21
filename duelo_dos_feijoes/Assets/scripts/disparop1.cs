using Unity.VisualScripting;
using UnityEngine;

public class disparop1 : MonoBehaviour
{
    public int dano = 1;
    public GameObject vida;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vida = GameObject.Find("vida");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player2"))
        {
            Destroy(GameObject.Find("tiro(Clone)"));
            Debug.Log("acertou");
            vida.GetComponent<vida>().player2life = vida.GetComponent<vida>().player2life - dano;
            vida.GetComponent<vida>().UpdateVidaUI();
            vida.GetComponent<vida>().animacao_danoP2 = true;
            Destroy(gameObject);
        }


        if (collision.CompareTag("Parede"))
        {
            Destroy(gameObject);
        }

    }
}
