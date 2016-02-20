using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

	public WorldTurn worldTurn;
	
	public void Move(){
		if (this.worldTurn.CanPlay (this)) {
			//Bon, il fait semblant mais on va faire comme
			Debug.Log(this.gameObject.name + " bouge !");
			this.worldTurn.NextStep();
		} else {
			Debug.Log("Non mais tu rigoles ? C'est pas ton tour !");
		}
	}

	// Ne sait pas dire, en anglais, "foutre une grosse torgnole dans ta gueule"
	public void PutASlap(){
		if (this.worldTurn.CanPlay (this)) {
			//Il a quand meme un peu mal mais on ne va pas trop dire comment
			Debug.Log(this.gameObject.name + " fout une claque de ouf !");
			this.worldTurn.NextStep ();
		} else {
			Debug.Log("Tu crois que tu peux taper ? C'est pas ton tour !");
		}
	}

}
