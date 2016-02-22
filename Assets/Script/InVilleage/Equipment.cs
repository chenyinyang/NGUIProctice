using UnityEngine;
using System.Collections;

public class Equipment : MonoBehaviour {
    UILabel itemName;
    UILabel level;
    UILabel[] attrs;
    UITexture icon;
    // Use this for initialization
    void Awake () {
        itemName = transform.Find("Name").GetComponent<UILabel>();
        level = transform.Find("Level").GetComponent<UILabel>();
        attrs = new UILabel[3];
        attrs[0] = transform.Find("Attr1").GetComponent<UILabel>();
        attrs[1] = transform.Find("Attr2").GetComponent<UILabel>();
        attrs[2] = transform.Find("Attr3").GetComponent<UILabel>();
        icon = transform.Find("Icon").GetComponent<UITexture>();
        Clear();
    }
    public void UpdateUI(BaseItem equipment) {
        itemName.text = equipment.name;
        level.text ="Lv."+ equipment.level.ToString();
        Debug.Log(equipment.itemId.ToString("00"));
        if(equipment.itemId<100)
            icon.mainTexture = Resources.Load<Texture2D>("Equipment/gem_" + equipment.itemId.ToString("00"));
        else if (equipment.itemId < 200)
            icon.mainTexture = Resources.Load<Texture2D>("Equipment/Necklace_" + equipment.itemId.ToString("000"));
        else if (equipment.itemId < 300)
            icon.mainTexture = Resources.Load<Texture2D>("Equipment/Ring_" + equipment.itemId.ToString("000"));
        for (int i = 0; i < attrs.Length; i++)
        {
            if (i < equipment.extandAttr.Count)
            {
                attrs[i].text = "+" + equipment.extandAttr[i].Value.ToString() + " " + equipment.extandAttr[i].Key.ToString();
            }
            else
            {
                attrs[i].text = string.Empty;
            }
        }        
    }
    public void Clear() {
        itemName.text = string.Empty;
        level.text = string.Empty;
        icon.mainTexture = null;
        for (int i = 0; i < attrs.Length; i++)
        {
            attrs[i].text = string.Empty;
        }
    }
}
