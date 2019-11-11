using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_FloatArray : OmniEventInvoker<float[]>
	{
		[SerializeField] OmniEvent_FloatArray[] _floatArrayEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _floatArrayEvents;
		}
	}
}