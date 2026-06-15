using UnityEngine;

public class mortop1 : MonoBehaviour
{
    public GameObject vida;
    void Start()
    {
        if (vida.GetComponent<vida>().player1morto == true)
        {
            GetComponent<Animator>().SetBool("morto", true);
          
        }
    }


}
