using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private Transform mainCharacter;

    private void Start()
    {
        mainCharacter = GameObject.Find("MainCharacter").GetComponent<Transform>();
    }

    private void Update()
    {
        // Following MC
        transform.position = new Vector3(
            mainCharacter.position.x,
            mainCharacter.position.y,
            transform.position.z
        );
    }
}
