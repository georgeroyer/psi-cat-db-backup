using UnityEngine;
using System.Collections;
using ICode;
using System;
public class catdamage : MonoBehaviour {

	public CatHealth catHealth;
	public ICode.ICodeBehaviour healthchange;
	private ICode.FsmVariable damaged;

	void Awake (){
		catHealth = gameObject.GetComponent<CatHealth> ();
	}

	void Start () {
		ICode.ICodeBehaviour healthchange = gameObject.GetBehaviour (1);
		ICode.FsmVariable damaged = healthchange.stateMachine.GetVariable ("Health");
		damaged.onVariableChange.AddListener (OnVariableChange);

	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKey ("o")) {
			//SendDamage ();
		//}
	}

	private void OnVariableChange (object damaged ){
		//object = catHealth;
		Debug.Log ("Value of Health is " + damaged);
		float damage = 25.0f;
		catHealth.TakeDamage (damage);
	}

//	private void SendDamage (float hurt){
//		float damage = 50.0f;
//		catHealth.TakeDamage (damage);
//}
}