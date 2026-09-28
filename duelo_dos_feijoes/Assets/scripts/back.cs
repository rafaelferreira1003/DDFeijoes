using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton(string cenaqquero)
    {
        SceneManager.LoadScene(cenaqquero);
    }
}
