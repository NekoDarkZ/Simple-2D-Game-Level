using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region Variables

    public int lifePoints = 10;

    #endregion

    
    #region Metodos
    public void TakeDamage(int damagePoints)
    {

        lifePoints = lifePoints - damagePoints;

    }
    #endregion
}
