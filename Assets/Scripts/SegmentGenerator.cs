using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    
    [SerializeField] int zPos = 0;
    [SerializeField] int segmentNum;
    [SerializeField] int segmentCap = 8;
    private bool doubleNeg = false;

    
    void Start()
    {
        for (int segments = 0; segments < segmentCap; segments++)
        {
            segmentNum = Random.Range(0,4);
            if (segmentNum == 1)
            {
                if (doubleNeg == false)
                {
                    doubleNeg = true;
                    Instantiate(segment[segmentNum], new Vector3(0,0,zPos), Quaternion.identity);
                    zPos += 40;
                }
                else
                {
                    Instantiate(segment[0], new Vector3(0,0,zPos), Quaternion.identity);
                    zPos += 40;
                }
            }
            else
            {
                Instantiate(segment[segmentNum], new Vector3(0,0,zPos), Quaternion.identity);
                zPos += 40;
            }

            
        }

        Instantiate(segment[4], new Vector3(0,0,zPos), Quaternion.identity);
     
    }


}
