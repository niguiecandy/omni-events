using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Int : OmniEventInvoker<int>
	{
		[SerializeField] OmniEvent_Int[] _intEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _intEvents;
		}
	}
}