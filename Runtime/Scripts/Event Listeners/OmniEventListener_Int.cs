using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Int : OmniEventListener<int> 
	{
		[Space]
		[Header("Int Event Listener")]
		[SerializeField] OmniEvent_Int[] _omniEvent_int;
		[SerializeField] IntEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericOmniEvents_1param = _omniEvent_int;
			genericUnityEvent_1param = _invoked;
		}
	}
}
