using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Vector4: OmniEventListener<Vector4> 
	{
		[Space]
		[Header("Vector4 Event Listener")]
		[SerializeField] OmniEvent_Vector4[] _omniEvent_Vector4;
		[SerializeField] Vector4Event _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_Vector4;
			genericUnityEvent_1param = _invoked;
		}
	}
}
