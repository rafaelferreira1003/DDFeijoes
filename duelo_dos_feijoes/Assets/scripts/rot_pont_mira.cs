using UnityEngine;

public class rot_pont_mira : MonoBehaviour
{    
    public Transform parentTransform;
   
    public float angle;

    // Update is called once per frame
    void Update()
    {
        angle = parentTransform.eulerAngles.z;

  
        if (angle > 160 || angle < -90 )
        {
            gameObject.transform.localPosition = new Vector3(-0.5f, 0.0f, 0.0f);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(0.5f, 0.0f, 0.0f);
        }
    }
}
