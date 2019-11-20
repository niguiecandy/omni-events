using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NGC6543.OmniEvents
{
	[CustomEditor(typeof(OmniEventInvoker))]
	public class OmniEventInvokerEditor : Editor
	{	
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			
			EditorGUILayout.Space();
			GUI.backgroundColor = new Color(0.1f, 1f, 0.3f);
			if (GUILayout.Button("Invoke"))
			{
				var component = target as OmniEventInvoker;
				component.Invoke();
			}
		}
	}
	

	[CustomEditor(typeof(OmniEventInvoker<>), true)]
	public class GenericOmniEventInvokerEditor : Editor
	{
		// Excludes unnecessary field in base class.
		string[] excludedProperties = {"_events"};
		
		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			DrawPropertiesExcluding(serializedObject, excludedProperties);
			serializedObject.ApplyModifiedProperties();
			
			EditorGUILayout.Space();
			GUI.backgroundColor = new Color(0.1f, 1f, 0.3f);
			if (GUILayout.Button("Invoke"))
			{
				var component = target as OmniEventInvoker;
				component.Invoke();
			}
		}
	}
}