using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public bool isUnlocked = false;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnlocked && counter < 90)
        {
            transform.Rotate(0, 1, 0);
            counter++;
        }
    }
}
