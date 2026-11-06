using UnityEngine;

public class rot_icone_recarga : MonoBehaviour
{    
    public float diferenca;
   
    public float angle;

    // Update is called once per frame
    void Update()
    {
        angle = transform.parent.eulerAngles.z;
        if (angle > 160 || angle < -90 )
        {
            gameObject.transform.localPosition = new Vector3(-diferenca, 0.0f, 0.0f);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(diferenca, 0.0f, 0.0f);
        }
    }
}
