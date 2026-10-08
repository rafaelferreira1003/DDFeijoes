using UnityEngine;

public class tutorial : MonoBehaviour
{
    public int tutorialStage_p1 = 0;
    public int tutorialStage_p2 = 0;
    public TMPro.TMP_Text tutorialText_p1;
    public TMPro.TMP_Text tutorialText_p2;
    void Start()
    {
        tutorialText_p1.text = "precione w ou s para se mover para frente e trás";
        tutorialText_p2.text = "precione cima ou baixo para se mover para frente e trás"; 
    }

    void Update()
    {
        if (tutorialStage_p1 == 0)
        { 
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                tutorialStage_p1 = 1;
                tutorialText_p1.text = "precione a ou d para rotacionar";
            }
        }
        else if (tutorialStage_p1 == 1)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                tutorialStage_p1 = 2;
                tutorialText_p1.text = "precione g para atirar";
            }
        }
        else if (tutorialStage_p1 == 2)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                tutorialStage_p1 = 3;
                tutorialText_p1.text = "tutorial completo";
            }
        }

        if (tutorialStage_p2 == 0)
        {
            if (Input.GetAxisRaw("Vertical2") != 0)
            {
                tutorialStage_p2 = 1;
                tutorialText_p2.text = "precione esquerda ou direita para rotacionar";
            }
        }
        else if (tutorialStage_p2 == 1)
        {
            if (Input.GetAxisRaw("Horizontal2") != 0)
            {
                tutorialStage_p2 = 2;
                tutorialText_p2.text = "precione Ctrl para atirar";
            }
        }
        else if (tutorialStage_p2 == 2)
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                tutorialStage_p2 = 3;
                tutorialText_p2.text = "tutorial completo";
            }
        }
    }
}
