using UnityEngine;

public class movimento_p1 : MonoBehaviour
{
    public float velocidade = 5f;
    public float rotacao = 45f;
    public float movimento_y;
    public float rotacao_x;

    void Update()
    {
        rotacao_x = (Input.GetAxisRaw("Horizontal"));
        movimento_y = (Input.GetAxisRaw("Vertical"));
        transform.Translate(0, movimento_y * velocidade * Time.deltaTime, 0);
        transform.Rotate(0, 0, -rotacao_x * rotacao * Time.deltaTime);
        if (movimento_y != 0)
        {
            GetComponent<Animator>().SetBool("movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("movendo", false);
        }
    }
}

