using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    public Image versoCarta;
    public Text[] Player1Atributos = new Text[4];
    public Text[] Player2Atributos = new Text[4];
    public Text[] Pontuacao = new Text[2];
	public int jogador1Pontuacao = 0;
	public int jogador2Pontuacao = 0;
	public static List <Card> jogador1 = new List<Card> ();
	public static List <Card> jogador2 = new List<Card> ();
	List <Card> deck = new List<Card> ();

	void Start () {
		InicializarListaDeck ();
		AddJogador1 (deck);
		AddJogador2 (deck);
		print (jogador1[0].nome);
		print (jogador2[0].Nome);
        
    }

    void Update () {
        DisplayHUD ();
       
    }

	public void InicializarListaDeck () {
		
		deck.Add (new Card (7,11,3,9,"Elefante"));
		deck.Add (new Card (24,69,11,13, "Rola"));
		deck.Add (new Card (4, 22, 15, 96, "Leão"));
		deck.Add (new Card (12,13,14,15,"Adriel"));
		deck.Add (new Card (1,2,3,4, "Rafael"));
		deck.Add (new Card (78,45,12,54, "jr"));
		deck.Add (new Card (17,55,32,69, "Meia"));
		deck.Add (new Card (3,14,42,48, "Pi"));
		deck.Add (new Card (1,1,2,3, "Fibinho"));
		deck.Add (new Card (44,44,44,44, "Quatro"));
	}

	public void AddJogador1 (List<Card> deck){

		Card randomCard = deck [Random.Range (0,  (int) Mathf.Round(deck.Count - 1))];
		deck.Remove (randomCard);
		jogador1.Add (randomCard);
	}

	public void AddJogador2 (List<Card> deck){

		Card randomCard = deck [Random.Range (0,  (int) Mathf.Round(deck.Count - 1))];
		deck.Remove (randomCard);
		jogador2.Add (randomCard);
	}

	public static void CompararAtributo1 () {
		Card a = jogador1 [0];
		Card b = jogador2 [0];

		if (a.Atributo1 > b.Atributo1) {
			print ("JOGADOR 1 GANHA");
		} 

		else if (a.Atributo1 == b.Atributo1) {
			print ("EMPATE");
		} 

		else if (a.Atributo1 < b.Atributo1) {
			print ("JOGADOR 2 GANHA");
		}

	}

	public static void CompararAtributo2 () {
		Card a = jogador1 [0];
		Card b = jogador2 [0];

		if (a.Atributo2 > b.Atributo2) {
			print ("JOGADOR 1 GANHA");
		} 

		else if (a.Atributo2 == b.Atributo2) {
			print ("EMPATE");
		} 

		else if (a.Atributo2 < b.Atributo2) {
			print ("JOGADOR 2 GANHA");
		}
	}

	public static void CompararAtributo3 () {
		Card a = jogador1 [0];
		Card b = jogador2 [0];

		if (a.Atributo1 > b.Atributo3) {
			print ("JOGADOR 1 GANHA");
		} 

		else if (a.Atributo3 == b.Atributo3) {
			print ("EMPATE");
		} 

		else if (a.Atributo3 < b.Atributo3) {
			print ("JOGADOR 2 GANHA");
		}
	}

	public static void CompararAtributo4 () {
		Card a = jogador1 [0];
		Card b = jogador2 [0];

		if (a.Atributo4 > b.Atributo4) {
			print ("JOGADOR 1 GANHA");
		} 

		else if (a.Atributo4 == b.Atributo4) {
			print ("EMPATE");
		} 

		else if (a.Atributo1 < b.Atributo1) {
			print ("JOGADOR 2 GANHA");
		}
        
	}
		
    public void DisplayHUD () {
        Player1Atributos[0].text = jogador1[0].Atributo1.ToString ();
        Player1Atributos[1].text = jogador1[0].Atributo2.ToString ();
        Player1Atributos[2].text = jogador1[0].Atributo3.ToString ();
        Player1Atributos[3].text = jogador1[0].Atributo4.ToString ();
        Player2Atributos[0].text = jogador2[0].Atributo1.ToString ();
        Player2Atributos[1].text = jogador2[0].Atributo2.ToString ();
        Player2Atributos[2].text = jogador2[0].Atributo3.ToString ();
        Player2Atributos[3].text = jogador2[0].Atributo4.ToString ();
        Pontuacao[0].text = jogador1Pontuacao.ToString ();
        Pontuacao[1].text = jogador2Pontuacao.ToString ();
    }
}
