using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TesteBehaviour))]

public class TesteBehaviourEditor : Editor 
{
	int alçafrao;
	int arrgValores;

	public override void OnInspectorGUI()
	{

		//base.OnInspectorGUI ();

		TesteBehaviour testbehaviour = target as TesteBehaviour;

		EditorGUILayout.LabelField ("BATATA", EditorStyles.boldLabel);

		for(int i = 0; i < testbehaviour.arrg.Length; i++){
			testbehaviour.arrg[i] = EditorGUILayout.IntField ("array " + i, testbehaviour.arrg[i]);
		}

		testbehaviour.properties = EditorGUILayout.IntField ("ALÇAFRAO", testbehaviour.properties);
		//alçafrao = EditorGUILayout.IntField ("ALÇAFRAO", alçafrao);

		testbehaviour.volume = EditorGUILayout.Slider("Volume", testbehaviour.volume, 0.0f, 1.0f);

		testbehaviour.texto = EditorGUILayout.TextArea (testbehaviour.texto);
			testbehaviour.lookAtTarget = EditorGUILayout.ObjectField("target", testbehaviour.lookAtTarget, typeof(Transform), true) as Transform;

		if (GUILayout.Button ("ME APERTE")) {
			testbehaviour.DoSomething ();
		}
			
		/*if (GUILayout.Button ("FAZER O ARRAY")) {
			for(int i = 0; i < testbehaviour.arrg.Length; i++){
				EditorGUILayout.IntField ("array " + i + " :", testbehaviour.arrg[i]);
			}
		}*/	
	}
}