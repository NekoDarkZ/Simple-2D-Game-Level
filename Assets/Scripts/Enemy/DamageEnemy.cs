using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    #region CLASS_VARIABLE
    public PlayerHealth playerhealth;
    public int DamageEnemyPoints = 1;

    #endregion

    #region METODOS

    public void DealDamage(){

        playerhealth.TakeDamage(DamageEnemyPoints);
    }

    #endregion
}
