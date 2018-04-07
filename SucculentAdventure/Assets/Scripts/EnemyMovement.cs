using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
	//ScoreManager scoreManager;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
		if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0) {
			nav.SetDestination (player.position);
		}
			/*if (ScoreManager.score >= 500) {
				nav.speed = 5f;
				nav.angularSpeed = 240f;
			}
			if (ScoreManager.score >= 1000) {
				nav.speed = 10f;
				nav.angularSpeed = 360f;
			}
			if (ScoreManager.score >= 1500) {
				nav.speed = 12f;
				nav.angularSpeed = 360f;
			}
		}*/
        else
        {
            nav.enabled = false;
        }
    }
}

