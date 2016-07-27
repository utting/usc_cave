using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Application.LoadLevel ("Stage");
	}
}
