using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class BaseItem
{
    public string name;
    public int itemId;
    public int level;
    
    public List<KeyValuePair<StatusAttributes, int>> extandAttr;
    public BaseItem(int itemId) {
        this.itemId = itemId;
        this.level = 1;
        this.name = "Item-"+itemId;
        this.extandAttr = new  List<KeyValuePair<StatusAttributes, int>>();
        this.extandAttr.Add(new KeyValuePair<StatusAttributes, int>(StatusAttributes.Strength, 10));
    }

}