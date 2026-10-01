using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public void OnClickButton(string cenaqquero)
    {
        SceneManager.LoadScene(cenaqquero);
    }
}
