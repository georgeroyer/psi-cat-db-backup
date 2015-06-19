using UnityEngine;
using System.Collections;

public class cubesfx : MonoBehaviour {

	public AudioClip dink;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//void OnCollissionEnter(Collider other){
	void OnTriggerEnter(Collider other){
		audio.clip = dink;
		audio.pitch = Random.Range (.6f, 1.0f);
		audio.Play ();		
	}
}
