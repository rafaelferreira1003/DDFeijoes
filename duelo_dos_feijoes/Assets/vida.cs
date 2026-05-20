using UnityEngine;

public class vida : MonoBehaviour
{
    public int player1life = 7;
    public int player2life = 7;
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
            Debug.Log("Player 2 ganhou!");
            Destroy(player1);
            
        }

        if (player2life <= 0)
        {
            Debug.Log("Player 1 ganhou!");
            Destroy(player2);
        }
    }
}
