using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
    public static Status playerStatus;

	// Use this for initialization
	void Start () {
        LoadData();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void LoadData() {
        playerStatus = Status.Load();
        if (GameObject.Find("CharacterPanel") != null) {
            GameObject.Find("CharacterPanel").GetComponent<CharacterPanel>().UpdateUI();
        }
    }

    
}
