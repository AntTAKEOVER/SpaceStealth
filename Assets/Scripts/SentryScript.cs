using UnityEngine;
using System.Collections;

public class SentryScript : MonoBehaviour {

	public float rotateSpeed;
	public float minRotate;
	public float maxRotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.eulerAngles.y > maxRotate) {
			rotateSpeed = -rotateSpeed;
		} else if (transform.eulerAngles.y < minRotate) {
			rotateSpeed = -rotateSpeed;
		}

		transform.Rotate (0, rotateSpeed * Time.deltaTime, 0);

	}

}