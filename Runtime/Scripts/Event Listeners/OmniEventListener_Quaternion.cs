using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventListener_Quaternion : OmniEventListener<Quaternion>
	{
		[Space]
		
		[Header("Quaternion Event Listener")]
		
		[SerializeField] OmniEvent_Quaternion[] _omniEvent_Quaternion;
		
		[SerializeField] QuaternionEvent _Invoked;
		
		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_Quaternion;
			genericUnityEvent_1param = _Invoked;
		}
	}

}
