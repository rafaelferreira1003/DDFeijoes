using UnityEngine;

public class vida : MonoBehaviour
{
    public int player1life = 7;
    public int player2life = 7;
    public bool player1morto = false;
    public bool player2morto = false;
    public GameObject player1;
    public GameObject player2;


    // Update is called once per frame
    void Update()
    {
        if (player1life <= 0)
        {
           player1morto = true;
        }

        if (player2life <= 0)
        {
           player2morto = true;
        }

    }

   
 }

