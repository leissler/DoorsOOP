using UnityEngine;
using System.Collections;
using UnityEngine.Events;


[RequireComponent (typeof (Collider))]

public class DoorTrigger : MonoBehaviour {
	
	public UnityEvent OnExit;
	public UnityEvent OnEnter;

	void Start() {
		Openable[] openableObjects = Object.FindObjectsOfType<Openable>();
		foreach (Openable o in openableObjects) {
			OnEnter.AddListener(o.Open);
			OnExit.AddListener(o.Close);
		}

	}

	void OnTriggerExit(Collider other) {
		OnExit.Invoke();
	}

	void OnTriggerEnter(Collider other) {
		OnEnter.Invoke();
	}
		
}
