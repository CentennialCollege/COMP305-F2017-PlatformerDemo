using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
	// private properties
	private Animator animator;
	private bool _isFacingRight = true;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Horizontal");
		float jump = Input.GetAxis ("Jump");

		// if the right button is pressed (either d or right arrow)
		if (move > 0.3f) {
			animator.SetInteger ("AnimState", 1);
			_isFacingRight = true;
		}
		else if (move < -0.3f) {
				animator.SetInteger ("AnimState", 1);
			_isFacingRight = false;
		} else {
			animator.SetInteger ("AnimState", 0);
		}
			

		if (jump > 0.3f) {
			animator.SetInteger ("AnimState", 2);
		}

		gameObject.transform.localScale = (!_isFacingRight) 
			? new Vector3 (-1f, 1f, 1f) : new Vector3 (1f, 1f, 1f);
	}
}
