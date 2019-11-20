using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Quaternion : OmniEventInvoker<Quaternion>
	{
		[SerializeField] OmniEvent_Quaternion[] _quaternionEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _quaternionEvents;
		}
	}
}