using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]

public class OpenClose : Openable {

	private Animator animController;

	private void Start() {
		animController = GetComponent<Animator>();
	}

	public override void Open() {
		animController.SetBool("open", true);
	}

	public override void Close() {
		animController.SetBool("open", false);
	}

}
