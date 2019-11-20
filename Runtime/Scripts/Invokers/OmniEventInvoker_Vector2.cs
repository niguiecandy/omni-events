using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Vector2 : OmniEventInvoker<Vector2>
	{
		[SerializeField] OmniEvent_Vector2[] _vector2Events;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _vector2Events;
		}
	}
}