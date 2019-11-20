using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NGC6543.OmniEvents
{
	[System.Serializable]
	public class OmniEventListener_Vector2Array : OmniEventListener<Vector2[]> 
	{
		[Space]
		[Header("Vector2[] Event Listener")]
		[SerializeField] OmniEvent_Vector2Array[] _omniEvent_Vector2Array;
		[SerializeField] Vector2ArrayEvent _invoked;

		protected override void OverrideGenericEvents()
		{
			genericOmniEvents_1param = _omniEvent_Vector2Array;
			genericUnityEvent_1param = _invoked;
		}
	}
}
