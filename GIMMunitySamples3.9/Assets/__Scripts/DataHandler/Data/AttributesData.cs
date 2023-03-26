using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AttributesData
{
    public int vitality;
    public int might;
    public int magic;
    public int intelligence;
    public int dexterity;

    public AttributesData()
    {
        this.vitality = 1;
        this.might = 1;
        this.magic = 1;
        this.intelligence = 1;
        this.dexterity = 1;
    }
}
