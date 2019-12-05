using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLock : MonoBehaviour
{
	public int lockvalue = 0;

	bool raised = false;    
	public float speed = 0.1f;
	public int displacement = 0;
	public int displacementMax = 10;
	public int displacementMin = 0;

	//public bool leftkeypressed = false;
	//public bool rightkeypressed = false;

	public int total = 0;

	// Start is called before the first frame update
    void Start()
    {
		//lockvalue = Random.Range(1,16);
    }

    // Update is called once per frame
    void Update()
    {
		total = GameObject.Find("AirRoomHandler").GetComponent<AirRoomHandler>().sumTotal;

		/*

		// Used for debugging with keyboard

		if(Input.GetKeyDown(KeyCode.LeftControl) && raised == false)
		{
			leftkeypressed = true;
		}

		if(Input.GetKeyDown(KeyCode.RightControl) && raised == true)
		{
			rightkeypressed = true;
		}
		*/

		//if (leftkeypressed)
		if (total == lockvalue)
        {
            if(displacement < displacementMax && raised == false)
			{
				transform.Translate(0.0f, 0.0f, -speed);
				displacement++;
				//Debug.Log("Raising the lock.");
			}
			else
			{
				raised = true;
				displacement = displacementMax;
				//leftkeypressed = false;
				//Debug.Log("Lock is now raised.");
			}
        }

		//if (rightkeypressed)
		else
        {
            if(displacement > displacementMin && raised == true)
			{
				transform.Translate(0.0f, 0.0f, speed);
				displacement--;
				//Debug.Log("Lowering the lock.");
			}
			else
			{
				raised = false;
				displacement = displacementMin;
				//rightkeypressed = false;
				//Debug.Log("Lock is now lowered.");
			}
        }
    }
}
