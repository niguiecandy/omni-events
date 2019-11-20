using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker_Texture2D : OmniEventInvoker<Texture2D>
	{
		[SerializeField] OmniEvent_Texture2D[] _tex2DEvents;
		
		protected override void OverrideGenericEvents()
		{
			base._genericEvents = _tex2DEvents;
		}
	}
}