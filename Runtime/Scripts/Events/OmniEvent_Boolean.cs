using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "boolean", fileName = "New boolean Event.asset", order = 0)]
	public class OmniEvent_Boolean : OmniEvent<bool> {}
}