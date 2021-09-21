using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public GameObject[] Health;
    public int LifePoints;
    public EnemyAttack enemy;

    private void Start()
    {

        LifePoints = Health.Length;
    }

    private void Update()
    {

    }


    #region CLASS_METHODS

    public void TakeDamage(int damagePoints)
    {
        if (LifePoints >= 1)
        {
            LifePoints -= damagePoints;
            SoundManager.PlaySound("Player");
            Destroy(Health[LifePoints].gameObject);
            
        }
        
    }
    #endregion
}
