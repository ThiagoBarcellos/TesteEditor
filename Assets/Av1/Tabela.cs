using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabela : MonoBehaviour {
	public List<int> tabela = new List<int>();
	public List<string> tabelastring = new List<string>();

	public class entry
	{
		public string nome;
		public int valor;

		public entry (string n, int v)
		{
			nome = n;
			valor = v;
		}
	}

	public List<entry> tabela1 = new List<entry>();

	public void Reset()
	{
		tabela1.Clear ();
		tabela1.Add (new entry("", 0));

		/*    com duas listas
		tabelastring.Clear ();
		tabela.Clear();
		tabelastring.Add ("ghjhrgsefad");		
		tabela.Add (0);*/
	}

	public void addline(){
		/*   com duas listas
		tabelastring.Add ("");
		tabela.Add (0);*/
		tabela1.Add (new entry ("",0));
	}

	public void removeline(){
		/*   com duas listas
		tabelastring.Remove ("");
		tabela.Remove (0);*/
		tabela1.RemoveAt(tabela1.Count - 1);
	}

}
