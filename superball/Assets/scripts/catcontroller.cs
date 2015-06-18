using UnityEngine;
using System.Collections;

public class catcontroller : MonoBehaviour {

	public Animator anim;
	int attackHash = Animator.StringToHash("attack");

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Vertical");
		//float move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed", move);
		anim.SetFloat ("Attack", 0f);

		if (Input.GetButton ("Fire1")) {
			Attack ();
		}
	}
	
	void Attack (){
		anim.SetFloat ("Attack", 1f);
}

		//if (Input.GetButtonDown ("Fire1")) 
		//{
			//anim.SetTrigger (attackHash);
		//}
	
}
