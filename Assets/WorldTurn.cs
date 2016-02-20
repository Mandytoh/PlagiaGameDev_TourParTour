using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class WorldTurn : MonoBehaviour {
	
	public enum turnStep {MOVEMENT_STEP, FIGHT_STEP};

	public int indexStep = 0;
	public int indexTurn = 0;

	public List<Entity> entities = new List<Entity>();

	public void InitializeWorldTurn(){
		this.ChangeTurn (0);
		this.ChangeStep (0);
	}

	public bool CanPlay ( Entity entity ){
		if (entity.name == this.entities [this.indexTurn].name) {
			return true;
		} else {
			return false;
		}
	}

	public void ChangeTurn( int newIndexTurn ){
		this.indexTurn = newIndexTurn;
		if (this.indexTurn + 1 > entities.Count) {
			this.indexTurn = 0;
		}		
		Debug.Log ("Super ! C'est au tour de " + entities[this.indexTurn].name + " maintenant");
	}

	public void ChangeStep( int indexStep ){
		//Là, on change d'étape
		string stepName = "";
		if (indexStep == (int)WorldTurn.turnStep.MOVEMENT_STEP) {
			stepName = "Mouvement";
		} else {
			stepName = "Combat";
		}

		Debug.Log ("Etape : " + stepName);
	}

	public void NextStep (){
		this.indexStep++;
		if (this.indexStep > Enum.GetValues (typeof(WorldTurn.turnStep)).Length - 1) {
			this.indexStep = 0;
			this.indexTurn++;
			this.ChangeTurn(indexTurn);
		}
		ChangeStep (this.indexStep);
	}
	
	public void PreviousStep (){
		this.indexStep--;
		if (this.indexStep < 0) {
			this.indexStep = Enum.GetValues (typeof(WorldTurn.turnStep)).Length - 1;
		}
		ChangeStep (this.indexStep);
	}
}
