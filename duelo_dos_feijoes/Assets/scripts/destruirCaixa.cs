using UnityEngine;

public class destruirCaixa : MonoBehaviour
{
    public int vida = 5;
    public int dano = 1;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("player2"))
        {
            vida = vida - dano;
            if (vida < 0)
            {


            }

        }
    }
}
