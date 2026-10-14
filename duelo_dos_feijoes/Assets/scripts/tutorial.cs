using UnityEngine;

public class tutorial : MonoBehaviour
{
    public int tutorialStage_p1 = 0;
    public int tutorialStage_p2 = 0;
    public GameObject pensamento_p1;
    public GameObject pensamento_p2;

    void Update()
    {
        if (tutorialStage_p1 == 0)
        { 
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 1f);
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                tutorialStage_p1 = 1;
            }
        }
        else if (tutorialStage_p1 == 1)
        {
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 2f);
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                tutorialStage_p1 = 2;
            }
        }
        else if (tutorialStage_p1 == 2)
        {
            pensamento_p1.GetComponent<Animator>().SetFloat("pensamento", 3f);
            if (Input.GetKeyDown(KeyCode.G))
            {
                tutorialStage_p1 = 3;
            }
        }

        if (tutorialStage_p2 == 0)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 1f);
            if (Input.GetAxisRaw("Vertical2") != 0)
            {
                tutorialStage_p2 = 1;
            }
        }
        else if (tutorialStage_p2 == 1)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 2f);
            if (Input.GetAxisRaw("Horizontal2") != 0)
            {
                tutorialStage_p2 = 2;
            }
        }
        else if (tutorialStage_p2 == 2)
        {
            pensamento_p2.GetComponent<Animator>().SetFloat("pensamento", 3f);
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                tutorialStage_p2 = 3;
            }
        }
    }
}
