using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] Stat maxHealth;
    [SerializeField] Stat currentHealth;
    //[SerializeField] bool decreaseHealth;

    float timeToDecrease = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth.amount = maxHealth.amount;

        StartCoroutine(DrainHealth());
    }

    // Update is called once per frame
    void Update()
    {
        /*if (decreaseHealth)
        {
            timeToDecrease -= Time.deltaTime;
            if(timeToDecrease <= 0) 
            {
                currentHealth.amount -= 1;
                timeToDecrease = 1.0f;
            }
        }*/
    }

    public void UserHealth(float amount)
    {
        currentHealth.amount -= (int)amount;

        if (currentHealth.amount <= 0) 
        {
            currentHealth.amount = 0;
        }
    }

    IEnumerator DrainHealth()
    {
        while(currentHealth.amount > 0) 
        {
            currentHealth.amount -= 5;

            yield return new WaitForSeconds(1.0f);
        }
    }
}
