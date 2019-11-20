using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NGC6543.OmniEvents
{
	//------------------------------------------------ Event listeners without a parameter
	public class OmniEventListener : MonoBehaviour
	{
		//#if UNITY_EDITOR	//UNDONE this can cause Deserialization error!!
		[SerializeField] string memo = "New Listener";
		//#endif
		[SerializeField] OmniEvent[] omniEvents;
		[SerializeField] bool receiveInvocationWhenDisabled = false;
		public UnityEvent onInvoked;

		//=== FLAGS
		bool isRegistered;

		private void OnEnable()
		{
			if (!isRegistered && omniEvents != null)
			{
				for (int i = 0; i < omniEvents.Length; i++)
				{
					if (omniEvents[i] == null) continue;
					omniEvents[i].RegisterListener(this);
				}
				isRegistered = true;
			}
		}
		
		private void OnDisable()
		{
			if (isRegistered && omniEvents != null && !receiveInvocationWhenDisabled)
			{
				for (int i = 0; i < omniEvents.Length; i++)
				{
					if (omniEvents[i] == null) continue;
					omniEvents[i].UnregisterListener(this);
				}
				isRegistered = false;
			}
		}
		
		private void OnDestroy()
		{
			if (isRegistered && omniEvents != null)
			{
				for (int i = 0; i < omniEvents.Length; i++)
				{
					if (omniEvents[i] == null) continue;
					omniEvents[i].UnregisterListener(this);
				}
			}
		}
		
		public void OnInvoked()
		{
			onInvoked.Invoke();
		}
	}

	//------------------------------------------------ Event listeners with 1 parameter
	#region Events with 1 parameter
	
	public abstract class OmniEventListener<T0> : MonoBehaviour
	{
		//#if UNITY_EDITOR	//UNDONE this can cause Deserialization error!!
		[SerializeField] string memo = "New " + typeof(T0).ToString() + " Listener";
		//#endif

		/// <summary>
		/// Override this on OverrideParam1GameEvent()
		/// </summary>
		protected OmniEvent<T0>[] genericOmniEvents_1param;

		/// <summary>
		/// If true, the event will be invoked even if this gameobject is inactive.
		/// </summary>
		[SerializeField] bool receiveInvocationWhenDisabled = false;

		/// <summary>
		/// Override this on OverrideParam1GameEvent()
		/// </summary>
		protected UnityEvent<T0> genericUnityEvent_1param;

		//UNDONE Using UnityEvent<T0> instead to be exposed in the inspector.
		//public delegate void OnInvokedDelegate(T0 _t0);
		//public event OnInvokedDelegate onInvoked;

		[Header("DEBUG")]
		//=== FLAGS
		[SerializeField] bool isRegistered;
		//#if UNITY_EDITOR	//UNDONE this can cause Deserialization error!!
		[SerializeField] T0 receivedParameter;
		//#endif

		private void Awake()
		{
			OverrideGenericEvents();
		}

		private void OnEnable()
		{
			if (!isRegistered && genericOmniEvents_1param != null)
			{
				for (int i = 0; i < genericOmniEvents_1param.Length; i++)
				{
					if (genericOmniEvents_1param[i] == null) continue;
					genericOmniEvents_1param[i].RegisterListener(this);
				}
				isRegistered = true;
			}
		}

		private void OnDisable()
		{
			if (isRegistered && genericOmniEvents_1param != null && !receiveInvocationWhenDisabled)
			{
				for (int i = 0; i < genericOmniEvents_1param.Length; i++)
				{
					if (genericOmniEvents_1param[i] == null) continue;
					genericOmniEvents_1param[i].UnregisterListener(this);
				}
				isRegistered = false;
			}
		}

		private void OnDestroy()
		{
			if (isRegistered && genericOmniEvents_1param != null)
			{
				for (int i = 0; i < genericOmniEvents_1param.Length; i++)
				{
					if (genericOmniEvents_1param[i] == null) continue;
					genericOmniEvents_1param[i].UnregisterListener(this);
				}
			}
		}

		/// <summary>
		/// Must override the OmniEvent&lt;T0&gt; genericOmniEvent_1param to its extended class.
		/// Must override the UnityEvent&lt;T0&gt; genericUnityEvent_1param to its extended class.
		/// </summary>
		protected abstract void OverrideGenericEvents();

		public void OnInvoked(T0 parameter)
		{
			#if UNITY_EDITOR
			receivedParameter = parameter;
			#endif
			genericUnityEvent_1param.Invoke(parameter);
		}
	}
	
	#endregion
}