using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_FloatArray : OmniEventListener<float[]> 
	{
		[Space]
		[Header("Float[] Event Listener")]
		[SerializeField] OmniEvent_FloatArray[] _omniEvent_floatArray;
		[SerializeField] FloatArrayEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericOmniEvents_1param = _omniEvent_floatArray;
			genericUnityEvent_1param = _invoked;
		}
	}
}