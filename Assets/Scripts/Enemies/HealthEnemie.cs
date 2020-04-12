using System.Collections;
using UnityEngine;

public class HealthEnemie : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float armor;
    [SerializeField] private MovementEnemie myMove;
    [SerializeField] private Rigidbody2D myRg;
    public void SetState(float hp, float armour)
    {
        health = hp;
        armor = armour;
        myMove = GetComponent<MovementEnemie>();
    }

    public void DamageMe(float damage)
    {
        var hDamage = damage / 2;
        var credit = armor - hDamage;
        if (credit < 0)
        {
            armor = 0;
            health -= hDamage - credit;
        }
        else
        {
            armor -= hDamage;
            health -= hDamage;
        }

        if (health < 0)
            StartCoroutine(MeDied());
        
    }
    
    public IEnumerator MeDied()
    {
        myMove.enabled = false;
        myRg.simulated = false;
        // TODO: make animation of death
        yield return null;
    }

    public IEnumerator MeRescued()
    {
        myMove.enabled = true;
        myRg.simulated = true;
        // TODO: make animation of death
        yield return null;
    }
    
    private void Start()
    {
        SetState(100f, 20f);
        myRg = GetComponent<Rigidbody2D>();
    }
    
}
