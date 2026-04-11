using Unity.VisualScripting;
using UnityEngine;

public class GateMovement : MonoBehaviour
{
   
    public float rightLimit = 3f;
    public float leftLimit = -4.2f;
    public float horizontalSpeed = 2;
   
    public bool movingLeft = true;
   
    void Update()
    { 
        
        if (movingLeft)
    {
        transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);

        if (transform.localPosition.x <= leftLimit)
        {
            movingLeft = false;
        }
    }
    else
    {
        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);

        if (transform.localPosition.x >= rightLimit)
        {
            movingLeft = true;
        }
    }
    }
}
