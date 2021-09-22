using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region CLASS_Variables

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
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damagePoints);
            Destroy(this.gameObject);

        }
    }
    #endregion
}
