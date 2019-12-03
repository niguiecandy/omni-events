using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "Quaternion", fileName = "New Quaternion Event.asset", order = 11)]
	public class OmniEvent_Quaternion : OmniEvent<Quaternion> { }
}
