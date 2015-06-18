﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityInput{
	[Category(Category.Input)]
	[Tooltip("Returns true during the frame the user releases the given mouse button.")]
	[HelpUrl("https://docs.unity3d.com/Documentation/ScriptReference/Input.GetMouseButtonUp.html")]
	[System.Serializable]
	public class GetMouseButtonUp : StateAction {
		[Tooltip("Button values are 0 for left button, 1 for right button, 2 for the middle button.")]
		public FsmInt button;
		[Shared]
		[Tooltip("Store the result.")]
		public FsmBool store;
		
		public override void OnUpdate ()
		{
			store.Value = Input.GetMouseButtonUp (button.Value);	
		}
	}
}