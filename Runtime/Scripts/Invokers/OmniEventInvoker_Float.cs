using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Float : OmniEventInvoker<float>
	{
		[SerializeField] OmniEvent_Float[] _floatEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _floatEvents;
		}
	}
}