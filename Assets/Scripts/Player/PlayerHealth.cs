using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public GameObject[] Health;
    public int LifePoints;
    public EnemyAttack enemy;

    private bool canTakeDamage;

    private void Start()
    {

        LifePoints = Health.Length;
        canTakeDamage = true;
    }

    private void Update()
    {

    }


    #region CLASS_METHODS

    public void TakeDamage(int damagePoints)
    {
        if (canTakeDamage)
        {
            if (LifePoints >= 1) 
            {
                LifePoints -= damagePoints;
                SoundManager.PlaySound("Player");
                Destroy(Health[LifePoints].gameObject);
                canTakeDamage = false;
            }
        }
        else
        {
            StartCoroutine(Counter());
        }
        
    }

    IEnumerator Counter()
    {
        yield return new WaitForSeconds(2);
        canTakeDamage = true;
    }
    #endregion
}
