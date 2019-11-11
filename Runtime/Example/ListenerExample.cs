using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerExample : MonoBehaviour 
{
	public void ListeningIntEvent(int _v)
	{
		Debug.Log("IntEvent received : " + _v);
	}
}
