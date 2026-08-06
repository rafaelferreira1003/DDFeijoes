using UnityEngine;

public class vida : MonoBehaviour
{
    public int player1life = 7;
    public int player2life = 7;
    public bool player1morto = false;
    public bool player2morto = false;
    [SerializeField] TMPro.TMP_Text vidap1Text;
    [SerializeField] TMPro.TMP_Text vidap2Text;


    void Start()
    {
        UpdateVidaUI();
    }
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
    public void UpdateVidaUI()
    {
        vidap1Text.text = player1life.ToString();
        vidap2Text.text = player2life.ToString();
    }


}

