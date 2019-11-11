using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Vector2Array : OmniEventInvoker<Vector2[]>
	{
		[SerializeField] OmniEvent_Vector2Array[] _vec2ArrayEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _vec2ArrayEvents;
		}
	}
}