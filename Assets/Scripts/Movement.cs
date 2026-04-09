using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public float playerSpeed = 2;
   public float horizontalSpeed = 3;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if(Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x >= -9.5){
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if(Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x <= 9.5)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
           
        }
    }
}
