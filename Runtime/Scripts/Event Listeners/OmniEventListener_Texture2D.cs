using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Texture2D : OmniEventListener<Texture2D>
	{
		[Space]
		
		[Header("Texture2D Event Listener")]
		
		[SerializeField] OmniEvent_Texture2D[] _omniEvent_Tex2D;
		[SerializeField] Texture2DEvent _invoked;
		
		protected override void OverrideGenericEvents()
		{
			base.genericGameEvents_1param = _omniEvent_Tex2D;
			base.genericUnityEvent_1param = _invoked;
		}
	}	
}