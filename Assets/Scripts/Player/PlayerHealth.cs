using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region CLASS_VARIABLES
    public int LifePoints = 10;

    #endregion

    #region CLASS_METHODS

    public void TakeDamage(int damagePoints)
    {
        LifePoints = LifePoints - damagePoints;
    }

    #endregion
}
