using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //This handles everything with the Health value. A float will only go up or down.
    
    [SerializeField]
    float hp;
    [SerializeField]
    GameObject ui;//or get Component/getchild

    public UnityEvent onHealthZero;

    public void ChangeHealth(float amountToChange)
    {
        hp += amountToChange;
        ui.GetComponent<TextMesh>().text = ((int)hp).ToString();

        if(hp <= 0 )
        {
            onHealthZero.Invoke();
        }
    }
}
