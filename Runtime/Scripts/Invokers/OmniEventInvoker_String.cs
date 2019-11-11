using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_String : OmniEventInvoker<string>
	{
		[SerializeField] OmniEvent_String[] _stringEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _stringEvents;
		}
	}
}