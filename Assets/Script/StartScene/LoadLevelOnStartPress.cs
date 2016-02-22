using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelOnStartPress : MonoBehaviour {
   
    void OnClick() {
        if (PlayerPrefs.HasKey(Status.DATA_KEY))
        {
            SceneManager.LoadScene("InVilleage");
        }
        else {
            SceneManager.LoadScene("Create");
        }
    }
}
