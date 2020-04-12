using System.Collections;
using UnityEngine;

public class MovementEnemie : MonoBehaviour
{
    [SerializeField] private Transform mainCharacter;
    [SerializeField] private Rigidbody2D myRg;
    public float Velocity { get; set; }
    private void Start()
    {
        mainCharacter = GameObject.Find("MainCharacter").GetComponent<Transform>();
        myRg = GetComponent<Rigidbody2D>();
        Velocity = 1f;
    }

    private void Update()
    {
        // Look to mc
        var sight = ((Vector2) mainCharacter.position - (Vector2) transform.position).normalized;    
        transform.up = sight;

        // Go to mc
        myRg.velocity = sight * Velocity;
    }
}
