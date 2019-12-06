using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "Texture2D", fileName = "New Texture2D Event.asset", order = 100)]
	public class OmniEvent_Texture2D : OmniEvent<Texture2D> {}
}