using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndCreate : MonoBehaviour {

    public void SaveAndGo() {
        if (GameObject.Find("Name").GetComponentInChildren<UIInput>().value == string.Empty)
        {
            UIAlert a = UIAlert.create("Need Player Name","Please input player's name.");
            a.padding = new Vector2(10f, 10f);
            a.Add<UIButton>("UIAlert-Button-Template").onClick.Add(new EventDelegate(() => a.Close(true)));
            a.Show();
            return;
        }
        //GameObject.Find("Name").GetComponentInChildren<UIInput>().Submit();
        //UILabel[] attrs = GameObject.Find("RerollBtn").GetComponent<GetRandomAttr>().attrs;
        //for (int i = 0; i < attrs.Length; i++)
        //{
        //    attrs[i].GetComponent<LabelSaveAs>().Save();
        //}
        Status s = new Status();
        s.name = GameObject.Find("Name").GetComponentInChildren<UIInput>().value;
        s.level = 1;
        s.curExp = 0;
        s.expToLevel = 100;
        s.maxHp = s.curHp = 100;
        s.strength = int.Parse(GameObject.Find("strValue").GetComponent<UILabel>().text);
        s.agility = int.Parse(GameObject.Find("agiValue").GetComponent<UILabel>().text);
        s.intelligent = int.Parse(GameObject.Find("intValue").GetComponent<UILabel>().text);
        s.Save();
        SceneManager.LoadScene("InVilleage");
    }
}
