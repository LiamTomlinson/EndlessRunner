using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;

    [Header("Lane bounds (world-space X)")]
    [SerializeField] private float minX = -5f;
    [SerializeField] private float maxX = 4f;

    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        
        
        int dir = GetHorizontalInput();

        if (dir < 0 && transform.position.x >= minX)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
        }
        else if (dir > 0 && transform.position.x <= maxX)
        {
            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
        }
    }

    
    /// Returns -1 (left), 0 (none), or +1 (right).
    /// Desktop: A/D keys.
    /// Mobile: hold anywhere on the left half of the screen to go left,
    /// right half to go right.
    
    
    private int GetHorizontalInput()
    {
        
        if (Input.GetKey(KeyCode.A)) return -1;
        if (Input.GetKey(KeyCode.D)) return 1;

       
        if (Input.touchCount > 0)
        {
            
            Touch t = Input.GetTouch(0);
            if (t.phase != TouchPhase.Ended && t.phase != TouchPhase.Canceled)
            {
                return t.position.x < Screen.width * 0.5f ? -1 : 1;
            }
        }

       

        return 0;
    }
}
