using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NGC6543.OmniEvents
{
	public class OmniEventInvoker : MonoBehaviour
	{
		[SerializeField, TextArea(3, 6)] string _memo = "Leave memo here!";
		
		[SerializeField] OmniEvent[] _events;
		
		public virtual void Invoke()
		{
			for (int i = 0; i < _events.Length; i++)
			{
				if (_events[i] == null) continue;
				_events[i].Invoke();
			}
		}
	}
	
	public abstract class OmniEventInvoker<T> : OmniEventInvoker
	{	
		[SerializeField] T _parameterToSend;

		protected OmniEvent<T>[] _genericEvents;


		protected abstract void OverrideGenericEvents();
		
		public override void Invoke()
		{
			Invoke(_parameterToSend);
		}
		
		public void Invoke(T parameter)
		{
			OverrideGenericEvents();
			for (int i = 0; i < _genericEvents.Length; i++)
			{
				if (_genericEvents[i] == null) continue;
				_genericEvents[i].Invoke(parameter);
			}
		}
	}
}
