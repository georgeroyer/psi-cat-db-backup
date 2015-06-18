using UnityEngine;
using System.Collections;

public class collisionNoise : MonoBehaviour {

	public AudioClip cubecollide;
	public GameObject holdpoint;
	public GameObject weirdo;
	public AudioClip weirdohit;


	// Use this for initialization
	void Start () {
		holdpoint = GameObject.FindGameObjectWithTag ("holdpoint");
		weirdo = GameObject.FindGameObjectWithTag ("HitReciever");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other != holdpoint) {
			audio.clip = cubecollide;
			audio.pitch = Random.Range (.6f, 1.0f);
			audio.Play ();

		}
		/*else if(other == GameObject.FindGameObjectWithTag ("HitReciever")) {
			audio.clip = weirdohit;
			audio.pitch = Random.Range (.6f, 1.0f);
			audio.Play ();
		} */
}
}