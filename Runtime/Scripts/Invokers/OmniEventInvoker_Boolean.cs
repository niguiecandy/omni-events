using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Boolean : OmniEventInvoker<bool>
	{
		[SerializeField] OmniEvent_Boolean[] _boolEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _boolEvents;
		}
	}
}