using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spawnar_gerenciador_de_pontos : MonoBehaviour
{
    public GameObject gerenciador_de_pontos_prefab;
    public GameObject som_prefab;
    public GameObject Som_menu_prefab;
    public GameObject PointMane;
    public GameObject som;
    public GameObject Som_menu;
    void Awake()
    {
        PointMane = GameObject.FindWithTag("PointMane");
        som = GameObject.FindWithTag("som");
        Som_menu = GameObject.FindWithTag("Som_menu");
        if (PointMane == null)
        {
            Instantiate(gerenciador_de_pontos_prefab);
        }
        if (som == null)
        {
            Instantiate(som_prefab);
        }
        if (Som_menu == null)
        {
            Instantiate(Som_menu_prefab);
        }

    }

   
    void Update()
    {
        //while (bad = true)
       // {
           // if (0 > 3)
           // {
              //  helloworld("print");
           // }
      //  }
      //  else { 
      //      helloword("debug.lag");
      //  }


    }
}
