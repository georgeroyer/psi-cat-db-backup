﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityRectTransform{
	[Category(Category.RectTransform)]    
	[Tooltip("The normalized position in the parent RectTransform that the lower left corner is anchored to.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/RectTransform-anchorMin.html")]
	[System.Serializable]
	public class GetAnchorMin : RectTransformAction {
		[Shared]
		[Tooltip("Store the result.")]
		public FsmVector2 store;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;
		
		public override void OnEnter ()
		{
			base.OnEnter ();
			store.Value = transform.anchorMin;
			if (!everyFrame) {
				Finish ();
			}
		}
		
		public override void OnUpdate ()
		{
			store.Value = transform.anchorMin;
		}
	}
}