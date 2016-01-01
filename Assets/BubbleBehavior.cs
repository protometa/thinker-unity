using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class BubbleBehavior : MonoBehaviour {
	public bool selected;
	public Material selectedMaterial;

	private Renderer rend;
	private 

	// Use this for initialization
	void Start () {
		Debug.Log("hello");
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Events
	void OnMouseDown () {
		Debug.Log("down");
		Select();
	}

	void OnMouseDrag () {
		Debug.Log("drag");
	}

	void OnMouseExit () {
		Debug.Log("exit");
	}

	void Select () {
		selected = true;
		rend.sharedMaterial = selectedMaterial;
	}

}
