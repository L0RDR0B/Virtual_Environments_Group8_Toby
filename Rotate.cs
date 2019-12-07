using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float speed = 50;
	public int valveValue = 0;
	public bool isOn = false;
	public int rotateCount = 0;

	public float lastAngle = 0.0f;

	int maxRotations = 2;

    // Start is called before the first frame update
    void Start()
    {
        lastAngle = transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
	     //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Space))
            Cursor.lockState = CursorLockMode.None;
    }

	void OnMouseDrag()
	{
		float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
		float rotY = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;
		float rotZ = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;

		float currentAngle = lastAngle + rotX;

		if (currentAngle >= -10.0f && currentAngle <= (maxRotations * 360.0f + 10.0f))
		{
			lastAngle = currentAngle;

			//Cursor.lockState = CursorLockMode.Locked;

			transform.Rotate(0, -rotX, 0, Space.Self);

			rotateCount = (int) ((lastAngle + 10.0f) / 360);

            // Switches valves on/off once sufficient rotations have bee
			if(rotateCount >= maxRotations)
			{
				isOn = true;
			}

			if(rotateCount <= 0)
			{
				isOn = false;
			}

		}

	}
}
