using UnityEngine;
using System.Collections;

public class Card {

	public Card () {
		
	}

	public Card (int a, int b, int c, int d){
		Atributo1 = a;
		Atributo2 = b;
		Atributo3 = c;
		Atributo4 = d;
	}

	public Card (int a, int b, int c, int d, string nome){
		Atributo1 = a;
		Atributo2 = b;
		Atributo3 = c;
		Atributo4 = d;
		Nome = nome;
	}

	[SerializeField]
	public string nome;

	public string Nome {
		get {
			return nome;
		}
		set {
			nome = value;
		}
	}

	[SerializeField]
	public int atributo1;

	public int Atributo1 {
		get {
			return atributo1;
		}
		set {
			atributo1 = value;
		}
	}

	[SerializeField]
	public int atributo2;

	public int Atributo2 {
		get {
			return atributo2;
		}
		set {
			atributo2 = value;
		}
	}

	[SerializeField]
	public int atributo3;

	public int Atributo3 {
		get {
			return atributo3;
		}
		set {
			atributo3 = value;
		}
	}

	[SerializeField]
	public int atributo4;

	public int Atributo4 {
		get {
			return atributo4;
		}
		set {
			atributo4 = value;
		}
	}
		
}
