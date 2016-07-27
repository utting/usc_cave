using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {
	private Renderer rd;
	private GameObject door;
	private int count;
	public TextMesh text;

	void Start()
	{
		rd = GetComponent<Renderer> ();
		door = GameObject.Find ("Door");
	}

	void Update(){
		InputText();
	}

	void InputText(){
		foreach (char c in Input.inputString){
			Debug.Log (c);
			if (c == "\b" [0]) {
				if (text.text.Length != 0)
					text.text = text.text.Substring (0, text.text.Length - 1);
			}
			else 
				text.text += c;
		}
	}


	void OnTriggerEnter (Collider other) {
		if (count == 0) {
			//Debug.Log ("Hello");
			door.SetActive (false);
			transform.localPosition += new Vector3 (0, 0, 0.3f);
			rd.material.color = new Color (1, 0, 0);
		}
		count++;

	}

	void OnTriggerExit (Collider other) {
		count--;
		if (count == 0) {
		//	Debug.Log ("Bye");
			door.SetActive (true);
			transform.localPosition -= new Vector3 (0, 0, 0.3f);
			rd.material.color = new Color (0, 1, 0);
		}
	}
}
