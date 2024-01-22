using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;
using System.Threading.Tasks;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("The number of times the spaceship will get hit before dying")]
    [SerializeField] private int health;

    [Tooltip("attach component of the visual of the spaceship")]
    [SerializeField] private SpriteRenderer spaceShipVisibility ;
    
    //for enabling and disabling the original scripts
    [SerializeField] private DestroyOnTrigger2D destroyScript;
    [SerializeField] private GameOverOnTrigger2D gameOverScript;

    [Tooltip("Respawn location after getting hit")]
    [SerializeField] private Vector3 respawnLocation;

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [Tooltip("component for showing the health on screen")]
    [SerializeField] private GameObject livesField;

    //for while is respawning, can't get hit
    private bool isRespawning;


    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled && !isRespawning)
        {
            if(health > 0) 
            {
                reduceHealth();
                yield return this.StartCoroutine(Respawn()); // waiting to be respawned
                if (health <= 0) 
                {
                    destroyScript.enabled = true;
                    gameOverScript.enabled = true;
                }
            }
            
            
        }
    }

    IEnumerator Respawn()
    {
        isRespawning = true;
        transform.position = respawnLocation;

        //add a few seconds of invincibility, prompted to the player from flashes
        for (int i = 0; i < 3; i++) 
        {
        yield return new WaitForSeconds(0.5f);
        spaceShipVisibility.enabled = false;
        yield return new WaitForSeconds(0.5f);
        spaceShipVisibility.enabled = true;
        }
        isRespawning = false;
    }

    private void reduceHealth()
    {
        health--;
        livesField.GetComponent<HealthField>().SetNumber(health);
        
    }

    void Start()
    {
        //destroyScript = GetComponent<DestroyOnTrigger2D>(); should I have this line? not sure...
        destroyScript.enabled = false;
        gameOverScript.enabled= false;
        spaceShipVisibility = GetComponent<SpriteRenderer>();
        isRespawning = false;
        livesField.GetComponent<HealthField>().SetNumber(health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
