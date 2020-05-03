using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace NGC6543.OmniEvents
{
	//------------------------------------------------ Event without a parameter
	
	[CreateAssetMenu(menuName = OmniEvent.menuPath + "No Parameter", fileName = "New Omni Event.asset", order = -99)]
	public class OmniEvent : ScriptableObject
	{
		public const string menuPath = "Omni Events/";
		
		//#if UNITY_EDITOR	//UNDONE this can cause Deserialization error!!
		[FormerlySerializedAs("memo")]
		[SerializeField, TextArea(3, 6)] string _memo;
		//#endif
		List<OmniEventListener> _listeners = new List<OmniEventListener>();

		public void RegisterListener(OmniEventListener listener)
		{
			_listeners.Add(listener);
		}
		
		public void UnregisterListener(OmniEventListener listener)
		{
			_listeners.Remove(listener);
		}
		
		public void Invoke()
		{
			for (int i = 0; i < _listeners.Count; i++)
			{
				_listeners[i].OnInvoked();
			}
		}
	}

	//------------------------------------------------ Events with 1 parameter
	#region Events with 1 parameter
	public abstract class OmniEvent<T0> : ScriptableObject
	{
		//#if UNITY_EDITOR	//UNDONE this can cause Deserialization error!!
		[FormerlySerializedAs("memo")]
		[SerializeField, TextArea(3, 6)] string _memo;
		[SerializeField] protected T0 _parameterToSend;
		//#endif
		List<OmniEventListener<T0>> _listeners = new List<OmniEventListener<T0>>();

		public void RegisterListener(OmniEventListener<T0> listener)
		{
			_listeners.Add(listener);
		}

		public void UnregisterListener(OmniEventListener<T0> listener)
		{
			_listeners.Remove(listener);
		}

		public void Invoke(T0 t0)
		{
			#if UNITY_EDITOR
			_parameterToSend = t0;
			#endif
			for (int i = 0; i < _listeners.Count; i++)
			{
				_listeners[i].OnInvoked(t0);
			}
		}
	}
	
	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> {}

	[System.Serializable]
	public class IntEvent : UnityEvent<int> {}

	[System.Serializable]
	public class FloatEvent : UnityEvent<float> {}

	[System.Serializable]
	public class StringEvent : UnityEvent<string> {}

	[System.Serializable]
	public class Vector2Event : UnityEvent<Vector2> {}

	[System.Serializable]
	public class Vector3Event : UnityEvent<Vector3> {}

	[System.Serializable]
	public class Vector4Event : UnityEvent<Vector4> {}

	[System.Serializable]
	public class IntArrayEvent : UnityEvent<int[]> {}

	[System.Serializable]
	public class FloatArrayEvent : UnityEvent<float[]> {}

	[System.Serializable]
	public class StringArrayEvent : UnityEvent<string[]> {}

	[System.Serializable]
	public class Vector2ArrayEvent : UnityEvent<Vector2[]> {}

	[System.Serializable]
	public class Vector3ArrayEvent : UnityEvent<Vector3[]> {}

	[System.Serializable]
	public class Vector4ArrayEvent : UnityEvent<Vector4[]> {}
	
	[System.Serializable]
	public class QuaternionEvent : UnityEvent<Quaternion> {}
	
	[System.Serializable]
	public class Texture2DEvent : UnityEvent<Texture2D> {}
	
    #endregion
}