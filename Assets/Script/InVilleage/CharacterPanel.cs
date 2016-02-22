using UnityEngine;
using System.Collections;

public class CharacterPanel : MonoBehaviour {
    UILabel playerName;
    UILabel playerLevel;
    UISlider exp;
    UILabel hpVal;
    UILabel strVal;
    UILabel agiVal;
    UILabel intVal;
    UILabel rVal;
    UILabel gVal;
    UILabel bVal;
    Equipment[] eqs;    
    Transform myTransform;
    // Use this for initialization
    void Awake() {
        myTransform = transform;
        Transform simplePanel = myTransform.Find("Simple");        
        playerName = simplePanel.Find("Name").GetComponent<UILabel>();
        playerLevel = simplePanel.Find("Level").GetComponent<UILabel>();
        exp = simplePanel.Find("ExpProgress").GetComponent<UISlider>();

        Transform statusPanel = myTransform.Find("Full").Find("Status");
        hpVal  = statusPanel.Find("HP").Find("Value").GetComponentInChildren<UILabel>();
        strVal = statusPanel.Find("Str").Find("Value").GetComponentInChildren<UILabel>();
        intVal = statusPanel.Find("Int").Find("Value").GetComponentInChildren<UILabel>();
        agiVal = statusPanel.Find("Agi").Find("Value").GetComponentInChildren<UILabel>();
        rVal = statusPanel.Find("Red").Find("Value").GetComponentInChildren<UILabel>();
        gVal = statusPanel.Find("Blue").Find("Value").GetComponentInChildren<UILabel>();
        bVal = statusPanel.Find("Green").Find("Value").GetComponentInChildren<UILabel>();
        Transform equipmentPanel = myTransform.Find("Full").Find("Equipment");
        eqs = new Equipment[2];
        eqs[0] = equipmentPanel.Find("Eq1").GetComponent<Equipment>();
        eqs[1] = equipmentPanel.Find("Eq2").GetComponent<Equipment>();
    }
    void Start () {
       
	}
    public void UpdateUI() {
        if (GameMaster.playerStatus != null)
        {
            Status status = GameMaster.playerStatus;
            playerName.text = status.name;
            playerLevel.text = "LV." + status.level.ToString();
            exp.value = (float)status.curExp / status.expToLevel;
            hpVal.text  = status.maxHp.ToString();
            strVal.text = status.strength.ToString();
            agiVal.text = status.agility.ToString();
            intVal.text = status.intelligent.ToString();
            rVal.text = status.r.ToString();
            gVal.text = status.g.ToString();
            bVal.text = status.b.ToString();
            for (int i = 0; i < eqs.Length; i++)
            {
                if (i < status.items.Length)
                {
                    eqs[i].UpdateUI(status.items[i]);
                }
                else {
                    eqs[i].Clear();
                }
            }
        }
    }
	
}
