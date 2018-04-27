using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChoiceBox : MonoBehaviour {
	
	public Transform choiceBoxTransform;

	public void LoadNewPage (string page_name) {
		Debug.Log(page_name);
		Transform myBox = Instantiate (choiceBoxTransform, new Vector3 (gameObject.transform.position.x + 200, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
		myBox.SetParent(gameObject.transform.parent);
		myBox.Rotate (0, myBox.transform.rotation.y+45, 0);
		Debug.Log (gameObject.name);
		Debug.Log (gameObject.transform.rotation.y);

	}
		
	public void LoadOneChoice (string choice_name) {
		Debug.Log (choice_name);
		Transform myBox = Instantiate (choiceBoxTransform, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 100, gameObject.transform.position.z), gameObject.transform.rotation);
		myBox.SetParent (gameObject.transform.parent);
		Debug.Log (gameObject.name);
		Debug.Log (gameObject.transform.rotation.y);
	}
}
