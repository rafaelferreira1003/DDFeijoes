using Unity.VisualScripting;
using UnityEngine;

public class movimento_p2 : MonoBehaviour
{
    public float velocidade = 5f;
    public float rotacao = 45f;
    public float movimento_y;
    public float rotacao_x;
    public GameObject vida;
    public bool p2morto = false;
  
    void Update()
    {
        p2morto = vida.GetComponent<vida>().player2morto;
        if (p2morto == false)
        {

            rotacao_x = (Input.GetAxisRaw("Horizontal2"));
            movimento_y = (Input.GetAxisRaw("Vertical2"));
            transform.Translate(0, movimento_y * velocidade * Time.deltaTime, 0);
            transform.Rotate(0, 0, -rotacao_x * rotacao * Time.deltaTime);

            if (movimento_y != 0 || rotacao_x != 0)
            { GetComponent<Animator>().SetBool("andandop2", true); }

            else
            { GetComponent<Animator>().SetBool("andandop2", false); }

        }
        else
        { GetComponent<Animator>().SetBool("mortop2", true); }
        
        
    }

}
