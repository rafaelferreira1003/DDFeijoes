using UnityEngine;

public class movimento_p1 : MonoBehaviour
{
    int velocidade = 5;
    int rotacao = 30;
    int movimento_y = 0;
    int movimento_x = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movimento_y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movimento_y = -1;
        }
        else
        {
            movimento_y = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movimento_x = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movimento_x = -1;
        }
        else
        {
            movimento_x = 0;
        }

        transform.Translate(new Vector3(0, movimento_y, 0) * velocidade * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, movimento_x) * rotacao * Time.deltaTime);
    }
}
