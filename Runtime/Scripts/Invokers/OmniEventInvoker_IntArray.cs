using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_IntArray : OmniEventInvoker<int[]>
	{
		[SerializeField] OmniEvent_IntArray[] _intArrayEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _intArrayEvents;
		}
	}
}