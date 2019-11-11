using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGC6543.OmniEvents
{
	public class InvokerExample : MonoBehaviour 
	{
		[SerializeField] OmniEvent_Int intEvent;
		[SerializeField] int parameter = 77;
		[SerializeField] bool invoke;

		private void Update()
		{
			if (invoke)
			{
				invoke = false;
				Debug.Log("Invoking GameEvent_Int with parameter " + parameter);
				intEvent.Invoke(parameter);
			}
		}

		public void OnIntGameEventReceived(int _v)
		{
			Debug.Log("Received int " + _v);
		}
	}
	
}
