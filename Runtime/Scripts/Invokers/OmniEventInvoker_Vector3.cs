using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Vector3 : OmniEventInvoker<Vector3>
	{
		[SerializeField] OmniEvent_Vector3[] _vector3Events;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _vector3Events;
		}
	}
}