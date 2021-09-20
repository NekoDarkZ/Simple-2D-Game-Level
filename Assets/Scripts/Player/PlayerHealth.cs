using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public GameObject[] Health;
    public int LifePoints;



    private void Update()
    {
        if (LifePoints < 1)
        {
            Destroy(Health[0].gameObject);
        }else if (LifePoints < 2)
        {

            Destroy(Health[1].gameObject);
        }else if (LifePoints < 3)
        {
            Destroy(Health[2].gameObject);

        }

    }


    #region CLASS_METHODS

    public void TakeDamage(int damagePoints)
    {
        LifePoints -= damagePoints;
    }

    #endregion
}
