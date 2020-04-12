using UnityEngine;

public class MainCharacterHP : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private new MainCamera camera;
    [SerializeField] private LevelCreator lc;
    void Start()
    {
        hp = 6;
        camera = Camera.main.GetComponent<MainCamera>();
        lc = GameObject.Find("Canvas").GetComponent<LevelCreator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Enemie")) return;
        --hp;
        if (hp <= 0)
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        camera.enabled = false;
        lc.EndLevel();
    }
}
