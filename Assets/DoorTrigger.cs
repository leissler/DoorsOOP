using UnityEngine;
using System.Collections;
//using UnityEngine.Events;


[RequireComponent (typeof (Collider))]

public class DoorTrigger : MonoBehaviour {

	public delegate void OnExitEvent();
	public event OnExitEvent OnExit;

	public delegate void OnEnterEvent();
	public event OnEnterEvent OnEnter;

	void Start() {
		Openable[] openableObjects = Object.FindObjectsOfType<Openable>();
		foreach (Openable o in openableObjects) {
			OnEnter += o.Open;
			OnExit += o.Close;
		}

	}

	void OnTriggerExit(Collider other) {
		OnExit();
	}

	void OnTriggerEnter(Collider other) {
		OnEnter();
	}
		
}
