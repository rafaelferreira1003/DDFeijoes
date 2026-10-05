using UnityEngine;

public class gerenciar_camera : MonoBehaviour
{
   public Canvas canvas;

    public void Update()
    {
        if (canvas.worldCamera == null)
        {
            canvas.worldCamera = Camera.main;
        }
    }
}
