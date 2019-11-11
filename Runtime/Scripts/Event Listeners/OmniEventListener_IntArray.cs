using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_IntArray : OmniEventListener<int[]> 
	{
		[Space]
		[Header("Int[] Event Listener")]
		[SerializeField] OmniEvent_IntArray[] _omniEvent_int;
		[SerializeField] IntArrayEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericGameEvents_1param = _omniEvent_int;
			genericUnityEvent_1param = _invoked;
		}
	}
}
