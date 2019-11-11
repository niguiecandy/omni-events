using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Vector3Array : OmniEventInvoker<Vector3[]>
	{
		[SerializeField] OmniEvent_Vector3Array[] _vec3ArrayEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _vec3ArrayEvents;
		}
	}
}