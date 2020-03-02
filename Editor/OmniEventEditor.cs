using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace NGC6543.OmniEvents
{
	[CustomEditor(typeof(OmniEvent))]
	public class OmniEventEditor : Editor
	{
		OmniEvent _component;

		void OnEnable()
		{
			_component = target as OmniEvent;
		}


		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			if (Application.isPlaying && GUILayout.Button("Trigger Event"))
			{
				_component.Invoke();
			}
		}
	}

	
	[CustomEditor(typeof(OmniEvent<>), true)]
	public class GenericOmniEventEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			EditorGUILayout.LabelField(target.GetType().ToString());
			base.OnInspectorGUI();
			
			if (Application.isPlaying && GUILayout.Button("Trigger Event"))
			{
				var targetType = target.GetType();
				
				var paramToSendFieldInfo = targetType.GetField("parameterToSend", BindingFlags.NonPublic | BindingFlags.Instance);
				
				var invokeMethodInfo = targetType.GetMethod("Invoke", BindingFlags.Public | BindingFlags.Instance);

				var paramToSend = paramToSendFieldInfo?.GetValue(target);
				invokeMethodInfo.Invoke(target, new object[] { paramToSend });
			}
		}
	}
}