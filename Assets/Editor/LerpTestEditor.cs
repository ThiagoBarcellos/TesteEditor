using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LerpTest))]

public class LerpTestEditor : Editor {

	public override void OnInspectorGUI(){
		LerpTest lp = target as LerpTest;

		lp.min = EditorGUILayout.FloatField ("min", lp.min);
		lp.max = EditorGUILayout.FloatField ("max", lp.max);

		if (lp.min <= lp.max) 
		{
			lp.t = EditorGUILayout.Slider ("t", lp.t, 0f, 1f);
		}
		if (lp.min > lp.max) 
		{
			lp.min = lp.max;	
			lp.t = EditorGUILayout.Slider ("t", lp.t, 0f, 1f);
		}

		float x = Mathf.Lerp (lp.min, lp.max, lp.t);

		EditorGUILayout.FloatField ("Lerp", x);
	}
}
