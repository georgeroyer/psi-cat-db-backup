using UnityEngine;
using System.Collections;

public class ragdollControl : MonoBehaviour {
		
		
		public Component[] bones;
		public Animator anim;
		public bool isDead;
	
		void Start () {
			
			bones = gameObject.GetComponentsInChildren<Rigidbody> (); 
			anim = gameObject.GetComponent<Animator> ();
			
		}

		void Update (){


			
		{
			if (isDead)
				killRagdoll ();
				
				
			
		}
	}
		
		// Update is called once per frame
		void killRagdoll () 
		{
			foreach (Rigidbody ragdoll in bones)
			{
				ragdoll.isKinematic = false;
			}
			
			anim.enabled = false;
			//anim.StopPlayback();
		}


}
