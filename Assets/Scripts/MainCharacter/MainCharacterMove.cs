using UnityEngine;

public class MainCharacterMove : MonoBehaviour
{
    [SerializeField] private new Camera camera;
    [SerializeField] private float velocity;

    private void Start()
    {
        camera = Camera.main;
        velocity = 7f;
    }

    private void FixedUpdate()
    {
        // Rotation toward mouse
        var mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        var sight = (Vector2) mousePos - (Vector2) transform.position;
        transform.up = sight.normalized;
        
        // Move
        if (Input.GetButton("A"))
        {
            transform.position += Vector3.left * (velocity * Time.deltaTime);
        }
        if (Input.GetButton("W"))
        {
            transform.position += Vector3.up * (velocity * Time.deltaTime);
        }
        if (Input.GetButton("D"))
        {
            transform.position += Vector3.right * (velocity * Time.deltaTime);
        }
        if (Input.GetButton("S"))
        {
            transform.position += Vector3.down * (velocity * Time.deltaTime);
        }
    }
}
