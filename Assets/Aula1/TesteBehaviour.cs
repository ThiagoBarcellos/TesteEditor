using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteBehaviour : MonoBehaviour {
	public int properties;
	public Transform lookAtTarget;
	public string texto;
	public float volume = 0.5f;

	public int[] arrg = new int[]{1,2,3,5,7,9};

	public void DoSomething()
	{
		//Debug.Log("Koeh");
		transform.localPosition = Vector3.zero;
		transform.LookAt (lookAtTarget);
	}
}
