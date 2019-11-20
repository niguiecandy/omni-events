using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NGC6543.OmniEvents
{
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
			if (Application.isPlaying && GUILayout.Button("Simulate Event"))
			{
				_component.Invoke();
			}
		}
	}


	public class GenericOmniEventEditor : Editor
	{

		public override void OnInspectorGUI()
		{
			EditorGUILayout.LabelField(target.GetType().ToString());
			base.OnInspectorGUI();


		}
	}
}