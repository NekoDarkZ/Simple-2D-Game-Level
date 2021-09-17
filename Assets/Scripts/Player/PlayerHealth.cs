using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region Variables

    private int lifePoints = 10;

    #endregion

    #region Metodos
    public void TakeDamage(int damagePoints)
    {

        lifePoints = lifePoints - damagePoints;

    }
    #endregion
}
