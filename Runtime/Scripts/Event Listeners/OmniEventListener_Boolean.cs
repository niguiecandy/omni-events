using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Boolean : OmniEventListener<bool>
	{
		[Space]
		[Header("Boolean Event Listener")]
		[SerializeField] OmniEvent_Boolean[] _omniEvent_boolean;
		[SerializeField] BoolEvent _invoked;
		
		protected override void OverrideGenericEvents()
		{
			genericOmniEvents_1param = _omniEvent_boolean;
			genericUnityEvent_1param = _invoked;
		}
	}
}