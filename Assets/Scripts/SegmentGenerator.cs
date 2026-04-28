using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    
    [SerializeField] int zPos = 0;
    [SerializeField] int segmentNum;
    [SerializeField] int segmentCap = 8;
    private int doubleNegCount = 0;

   
    
    void Start()
    {
        for (int segments = 0; segments < segmentCap + LevelManager.instance.level ; segments++)
        {
            segmentNum = Random.Range(0,4);
            if (segmentNum == 1)
            {
                doubleNegCount++;
                if (doubleNegCount <= LevelManager.instance.level)
                {
                    
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
            zPos -= 20;
            
        }

        int wallCount = LevelManager.instance.level;

        for (int walls = 0; walls < wallCount ; walls++)
        {
            Instantiate(segment[4], new Vector3(0,0,zPos), Quaternion.identity);
            zPos += 10;
        }

        Instantiate(segment[5], new Vector3(0,0,zPos), Quaternion.identity);
    }


}
