using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attributes", menuName = "ScriptableObjects/AttributesScriptableObjects", order = 1)]
public class AttributesScriptableObjects : ScriptableObject
{
    public int vitality;
    public int might;
    public int magic;
    public int intelligence;
    public int dexterity;
}

/*
 * Associated with Health, poison resistance
 * Associated with Physical attack and defense
 * Associate with Magical Attack and defense
 * Associated with tactics related features
 * Associated with speed and agility
 */