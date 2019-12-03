using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "float", fileName = "New Float Event.asset", order = 3)]
	public class OmniEvent_Float : OmniEvent<float> {}	
}
