using UnityEngine;

public class movimento_p2 : MonoBehaviour
{
    public float velocidade = 5f;
    public float rotacao = 45f;
    public float movimento_y;
    public float rotacao_x;

    void Update()
    {
        rotacao_x = (Input.GetAxisRaw("Horizontal2"));
        movimento_y = (Input.GetAxisRaw("Vertical2"));
        transform.Translate(0, movimento_y * velocidade * Time.deltaTime, 0);
        transform.Rotate(0, 0, -rotacao_x * rotacao * Time.deltaTime);
    }
}
