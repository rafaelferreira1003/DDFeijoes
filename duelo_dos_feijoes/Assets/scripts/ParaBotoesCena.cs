using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaBotoesCena : MonoBehaviour
{

    public void OnClickButton(string cenaParaOndeEuQuero)
    {
        SceneManager.LoadScene(cenaParaOndeEuQuero);
    }
}
