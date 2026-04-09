using Unity.VisualScripting;
using UnityEngine;

public class GateMovement : MonoBehaviour
{
   
    public float rightLimit = -0.44f;
    public float leftLimit = -7.1f;
    public float horizontalSpeed = 0;
    // Update is called once per frame
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
