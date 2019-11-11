using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Vector4 : OmniEventInvoker<Vector4>
	{
		[SerializeField] OmniEvent_Vector4[] _vector4Events;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _vector4Events;
		}
	}
}