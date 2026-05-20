using Unity.VisualScripting;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public int player1life = 7;
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
        }

        if (collision.CompareTag("player"))
        {
            Destroy(GameObject.Find("tiro(Clone)"));
            Debug.Log("acertou");
            vida.GetComponent<vida>().player1life = vida.GetComponent<vida>().player1life - dano;
        }

    }
}
