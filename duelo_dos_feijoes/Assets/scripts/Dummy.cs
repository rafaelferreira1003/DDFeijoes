using Unity.VisualScripting;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public float velocidade = 1f;
    public Transform min_pos;
    public Transform max_pos;
    public bool move_up = true;
    public bool move_down = false;


    void Update()
    {
        if (gameObject.transform.position.y < max_pos.position.y && move_up)
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0);
        }
        else
        {
            move_up = false;
            move_down = true;
        }
        if (gameObject.transform.position.y > min_pos.position.y && move_down)
        {
            transform.Translate(0, -velocidade * Time.deltaTime, 0);
        }
        else
        {
            move_down = false;
            move_up = true;
        }





    }
}
