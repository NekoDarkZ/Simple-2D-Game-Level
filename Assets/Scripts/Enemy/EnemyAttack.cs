using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region CLASS_Variables

    public PlayerHealth playerhealth;
    public int damagePoints = 2;

    #endregion


    #region unity_Metodos

    public void Start()
    {

        DealDamage();
    }

    #endregion

    #region CLASS_METHODS

    public void DealDamage()
    {
        playerhealth.TakeDamage(damagePoints);
    }

    #endregion
}
