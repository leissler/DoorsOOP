using UnityEngine;

public abstract class Openable : MonoBehaviour, IOpenable {
	public abstract void Open();
	public abstract void Close();
}

