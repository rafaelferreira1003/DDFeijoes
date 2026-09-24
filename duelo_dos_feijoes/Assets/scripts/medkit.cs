using UnityEditor.AssetImporters;
using UnityEngine;

public class medkit : MonoBehaviour
{
    public GameObject vida;
    public int regeneração = 5;
    void Start()
    {
     vida = GameObject.Find("vida");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            vida.GetComponent<vida>().player1life = regeneração;
            vida.GetComponent<vida>().UpdateVidaUI();
            Destroy(gameObject);
        }
        if (other.CompareTag("player2"))
            {
             vida.GetComponent<vida>().player2life = regeneração;
             vida.GetComponent<vida>().UpdateVidaUI();
             Destroy(gameObject);
        }
    }
}
