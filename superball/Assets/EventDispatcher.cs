using UnityEngine;
using System.Collections;
public delegate void EventHandler ();
public class EventDispatcher : MonoBehaviour {

	public event EventHandler OnEvent;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
