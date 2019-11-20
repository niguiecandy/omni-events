using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Vector3Array: OmniEventListener<Vector3[]> 
	{
		[Space]
		[Header("Vector3[] Event Listener")]
		[SerializeField] OmniEvent_Vector3Array[] _omniEvent_Vector3Array;
		[SerializeField] Vector3ArrayEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericOmniEvents_1param = _omniEvent_Vector3Array;
			genericUnityEvent_1param = _invoked;
		}
	}
}
