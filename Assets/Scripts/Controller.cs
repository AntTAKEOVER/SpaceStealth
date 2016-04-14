using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveSpeed; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime);

		
	
	}
}
