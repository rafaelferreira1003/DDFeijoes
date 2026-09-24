using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartucho : MonoBehaviour
{
   public int quantidade = 5;
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           other.GetComponentInChildren<atirar>().municao += quantidade;
            other.GetComponentInChildren<atirar>().updateAmmoUI();
           Destroy(gameObject);
        }
        else if (other.CompareTag("player2"))
        {
            other.GetComponentInChildren<atirar2>().municao += quantidade;
            other.GetComponentInChildren<atirar2>().updateAmmoUI();
            Destroy(gameObject);
        }
    }
}
