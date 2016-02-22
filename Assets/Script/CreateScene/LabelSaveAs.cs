using UnityEngine;
using System.Collections;
[RequireComponent(typeof(UILabel))]
public class LabelSaveAs : MonoBehaviour {
    public string savedAs;
    UILabel label;
    void Awake() {
        label = GetComponent<UILabel>();
    }
    public void Save() {
        string val = label.text;
        if (!string.IsNullOrEmpty(savedAs))
        {
            if (string.IsNullOrEmpty(val))
                PlayerPrefs.DeleteKey(savedAs);
            else
                PlayerPrefs.SetString(savedAs, val);
        }
    }
}
