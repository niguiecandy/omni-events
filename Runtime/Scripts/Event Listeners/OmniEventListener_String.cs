using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_String : OmniEventListener<string> 
	{
		[Space]
		[Header("String Event Listener")]
		[SerializeField] OmniEvent_String[] _omniEvent_string;
		
		[SerializeField] StringEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_string;
			genericUnityEvent_1param = _invoked;
		}
	}
}
