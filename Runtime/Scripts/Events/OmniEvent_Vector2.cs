using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "Vector2", fileName = "New Vector2 Event.asset", order = 5)]
	public class OmniEvent_Vector2 : OmniEvent<Vector2> {}
}