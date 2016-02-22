using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;


public class Status
{
    public const string DATA_KEY = "Status";
    public const string ITEM_DATA_KEY = "Items";
    public string name;
    public int curHp;
    public int maxHp;
    public int strength;
    public int agility;
    public int intelligent;
    public int curExp;
    public int level;
    public int expToLevel;
    public int r;
    public int g;
    public int b;
    public BaseItem[] items;
    public Status() {
        items = new BaseItem[2];
        items[0] = new BaseItem(100);
        items[1] = new BaseItem(1);
    }
    public static Status Load()
    {
        string data = PlayerPrefs.GetString(DATA_KEY);
        Debug.Log("Load data : " + data);
        return JsonUtility.FromJson<Status>(data);
    }
    public void Save() {        
        PlayerPrefs.SetString(DATA_KEY, JsonUtility.ToJson(this));
    }
}
