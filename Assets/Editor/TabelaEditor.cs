using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Tabela))]

public class TabelaEditor : Editor {
	public override void OnInspectorGUI(){
		Tabela tb = target as Tabela;

		for (int i = 0; i < tb.tabela1.Count; i++) {
			EditorGUILayout.BeginHorizontal ();
			tb.tabela1[i].nome = EditorGUILayout.TextField (tb.tabela1[i].nome);
			tb.tabela1[i].valor = EditorGUILayout.IntField (tb.tabela1[i].valor);
			EditorGUILayout.EndHorizontal ();

			/*Com duas lists

			EditorGUILayout.BeginHorizontal ();
			tb.tabelastring[i] = EditorGUILayout.TextField (tb.tabelastring[i]);
			tb.tabela[i] = EditorGUILayout.IntField (tb.tabela[i]);
			EditorGUILayout.EndHorizontal ();
			*/

		}

		if (GUILayout.Button ("Adicionar linha")) {
			tb.addline();
		}
		if (GUILayout.Button ("Remover linha")) {
			tb.removeline();
		}
	}
}
