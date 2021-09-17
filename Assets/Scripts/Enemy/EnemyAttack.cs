using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region CLASS_VARIABLE
    public PlayerHealth playerhealth;
    public int DamageEnemyPoints = 2;

    #endregion

    #region METODOS

    public void DealDamage(){

        playerhealth.TakeDamage(DamageEnemyPoints);
    }

    #endregion
}
