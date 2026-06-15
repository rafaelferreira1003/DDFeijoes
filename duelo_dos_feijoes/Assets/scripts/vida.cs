using UnityEngine;

public class vida : MonoBehaviour
{
    public int player1life = 7;
    public int player2life = 7;
    public bool player1morto = false;
    public bool player2morto = false;
    public GameObject player1;
    public GameObject player2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

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

    public void MORTOP1()
    {
        player1.SetActive(false);
    }

    public void MORTOP2()
    {
        player2.SetActive(false);
    }
 }

