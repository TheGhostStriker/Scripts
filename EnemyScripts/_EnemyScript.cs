using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class _EnemyScript : MonoBehaviour
{
    private Transform player;

    private NavMeshAgent agent;
    public HealthBar healthBar;
    public int currentHealth;
    public int maxHealth;
    public PlayerData playerData;

    public float enemyDistance = 0.7f;
    
    public bool dealtDamage = false;
    //public PlayerData playerData;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //Call every frame
    void Update()
    {
        //Look at the player
        transform.LookAt(player);

        agent.SetDestination(player.transform.position);

        if (Vector3.Distance(transform.position, player.position) < enemyDistance)
        {
            gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
            //gameObject.GetComponent<Animator>().Play("attack");

            Invoke("FireBullet", 2f);

            
        }
        
    }
    
    public void FireBullet()
    {
        
    }
    
    
    void DealDamage(int damage)
    {
        currentHealth -= damage;
        playerData.health -= damage;

        //if (currentHealth == 0)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
    }

    public void RunAaway()
    {
        if(dealtDamage == true)
        {
            agent.SetDestination(agent.transform.position); 
        }
    }
}
