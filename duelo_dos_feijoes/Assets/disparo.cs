using Unity.VisualScripting;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public int player1life = 7;
    public movimento_p2 movimentoP2;
    public int dano = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player1"))
        {
            movimentoP2.vidap2 -= dano;
            Destroy(GameObject.Find("tiro(Clone)"));
            Debug.Log("acertou");
        }
     
    }
}
