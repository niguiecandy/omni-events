using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Vector2 : OmniEventListener<Vector2> 
	{
		[Space]
		[Header("Vector2 Event Listener")]
		[SerializeField] OmniEvent_Vector2[] _omniEvent_Vector2;
		[SerializeField] Vector2Event _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_Vector2;
			genericUnityEvent_1param = _invoked;
		}
	}
}
