using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region CLASS_Variables

    public PlayerHealth playerhealth;
    public int damagePoints;
    
    #endregion


    #region unity_Metodos

    public void Start()
    {

        
    }

    #endregion

    #region CLASS_METHODS

    private void OnCollisionEnter2D(Collision2D other)
    {
        playerhealth.TakeDamage(damagePoints);
     
        
    }
    #endregion
}
