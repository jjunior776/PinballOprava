using UnityEngine;
using System.Collections;

public class scoreBoard : MonoBehaviour {
	/*
	const string filename = "score.txt";


	Hashtable score;



	// Use this for initialization
	void Start () {
		clearTable ();
		loadScore ();
	}



	void clearTable(){
		score = new Hashtable ();
		for (int i = 0; i<10; i++) {
			score.Add(i+1, "jméno", 0);	
		}
	}

	Hashtable loadScore(){
		Hashtable loaded = new Hashtable ();
		string content = "";
		try{
			using (System.IO.StreamReader sr = new System.IO.StreamReader(filename)){
				content = sr.ReadToEnd();

			}
		}catch(UnityException e){
			Debug.Log("Chyba čtení souboru!");
		}
		ArrayList lines = content.Split (";");
		for (int i = 1; i<11;i++) {
			//ArrayList line =  lines[i-1].Split(":");
			loaded.Add(i, line[0]+line[1]);
		}
		return loaded;
	}

	void saveScore(){
		System.IO.StreamWriter file = new System.IO.StreamWriter (filename);
		foreach (DictionaryEntry entry in score) {
			file.WriteLine(entry.Key+":"+entry.Value+";");
		}
		file.Close ();
	}

	void addScore(string name, int sc){
		int position = -1;
		foreach (DictionaryEntry d in score) {
			ArrayList line = d.Value.Split(":");
			if(line[1]<sc){ 
				position=d.Key;
				break;
			}
		}

		if (position > -1) {
			Hashtable newScores = new Hashtable ();

			foreach (DictionaryEntry d in score) {
				if (d.Key < position) {
					newScores.Add (d.Key, d.Value);
				}
				if (d.Key = position) {
					newScores.Add (position, name + ":" + sc);
				}
				if (d.Key >= position) {
					newScores.Add (position + 1, d.Value);
				}

			}


			score = newScores;
		}
		return score;

}*/
}
