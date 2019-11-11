using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Vector3: OmniEventListener<Vector3> 
	{
		[Space]
		[Header("Vector3 Event Listener")]
		[SerializeField] OmniEvent_Vector3[] _omniEvent_Vector3;
		[SerializeField] Vector3Event _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_Vector3;
			genericUnityEvent_1param = _invoked;
		}
	}
}
