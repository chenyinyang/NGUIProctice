using UnityEngine;
using System.Collections;

public class GetRandomAttr : MonoBehaviour {

    public UILabel[] attrs;
    public int MaxPoint;
    void Start() {
        GetRandomValue();
    }
    public void GetRandomValue() {
        if (attrs.Length == 0|| MaxPoint ==0)
            return;
        int attrCount = attrs.Length;        
        int basicPoint = MaxPoint / (attrCount + 1);
        int modPoint = MaxPoint - basicPoint * attrCount;
        for (int i = 0; i < attrCount-1; i++)
        {
            int val = Random.Range(0, modPoint);
            modPoint -= val;
            attrs[i].text = (basicPoint +val).ToString();
        }
        attrs[attrCount-1].text = (basicPoint + modPoint).ToString();
    }
}
