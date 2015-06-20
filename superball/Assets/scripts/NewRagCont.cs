using UnityEngine;
using System.Collections;

public class NewRagCont : MonoBehaviour {


	public GameObject HitReciever;
	public ragdollControl ragScript;
	public ICode.ICodeBehaviour aiScript;
	private string hitobject;
	public ContactPoint[] hitpoint;
	public GameObject hitter;
	public float force;
	public Component hips;


	
	void Start (){
		//ragScript.enabled = true; 

		foreach (Collider collide in GetComponentsInChildren<Collider>()) {
			collide.gameObject.AddComponent<Pickupable>();
		}
	} 
	
	void Update() {

	}
	 
	void OnPickableCollision(object obj) 
	{
		Collision other = (Collision)obj;
		foreach (ContactPoint contact in other.contacts) {
			hitpoint = other.contacts;

			if (other.gameObject.tag.Equals ("canHit")) {
				Debug.Log ("hit green man");
				if (other.relativeVelocity.magnitude > 20) {
					//if (collision.relativeVelocity.magnitude > 2) {
					//gameObject.GetComponent<ragdollControl>().enabled = true;
					ragScript.enabled = true;
					aiScript.SetNode ("Ded");
					rigidbody.AddRelativeForce (contact.point * 10);
					AddForce ();
					break;
				}

			}
		}
	}

	IEnumerator AddForce (){
		//foreach (ContactPoint contact in hitpoint) {
			//Vector3 direction = gameObject.transform.position - hitter.transform.position;
		yield return new WaitForSeconds (3f);	
		hips = gameObject.rigidbody.GetComponent<hips> ();
		hips.rigidbody.AddForce (Vector3.forward * force);

		}
	}

//Pickupable p = hit.collider.GetComponent<Pickupable> ();



	
