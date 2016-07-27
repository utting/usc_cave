using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public int speed;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		var direction = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); 
		rb.AddForce (direction * speed);
	}
}
