using UnityEngine;
using System.Collections;

public class ShootOnDetection : MonoBehaviour {

	public GameObject bullet;
	public float bulletSpeed;
	public float shootFrequency;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot(Transform target){
		GameObject bulletInstance = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		bulletInstance.GetComponent<Rigidbody> ().velocity = (target.transform.position - transform.position).normalized * bulletSpeed;
		Destroy (bulletInstance, 3f);
	
	}
}
