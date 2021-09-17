using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region Variables

    public PlayerHealth playerhealth;
    public int damagePoints = 2;

    #endregion

    #region Metodos

    public void DealDamage()
    {

        playerhealth.TakeDamage(damagePoints);
    }

    #endregion
}
