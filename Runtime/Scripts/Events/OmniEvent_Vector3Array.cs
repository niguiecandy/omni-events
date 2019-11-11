using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "Vector3[]", fileName = "New Vector3Array Event.asset")]
	public class OmniEvent_Vector3Array: OmniEvent<Vector3[]> {}
}