using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public WorldTurn worldTurn;
	public Enemy enemy;
	public Unit unit;

	void Start(){

		Debug.Log ("Faites vos jeux !");
		//On initialize les tours
		this.worldTurn.InitializeWorldTurn ();

		//On fait semblant de jouer
		//Tour 1
		this.unit.Move ();
		this.unit.PutASlap ();
		//Tour 2
		this.enemy.Move ();
		this.unit.Move (); //Normalement, il a pas le droit
		this.enemy.PutASlap ();
		//Tour 3
		this.unit.Move ();
		this.enemy.Move (); //Normalement, il a pas le droit
		this.unit.PutASlap ();


	}

}
