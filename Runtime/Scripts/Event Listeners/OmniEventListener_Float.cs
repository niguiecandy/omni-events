using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Float : OmniEventListener<float> 
	{
		[Space]
		[Header("Float Event Listener")]
		[SerializeField] OmniEvent_Float[] _omniEvent_float;
		[SerializeField] FloatEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_float;
			genericUnityEvent_1param = _invoked;
		}
	}
}