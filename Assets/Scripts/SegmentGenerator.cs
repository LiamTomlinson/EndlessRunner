using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    
    [SerializeField] int zPos = 0;
    [SerializeField] int segmentNum;
    [SerializeField] int segmentCap = 5;
   

    
    void Start()
    {
        for (int segments = 0; segments < segmentCap; segments++)
        {
            segmentNum = Random.Range(0,4);
            Instantiate(segment[segmentNum], new Vector3(0,0,zPos), Quaternion.identity);
            zPos += 40;
        }
     
    }


}
