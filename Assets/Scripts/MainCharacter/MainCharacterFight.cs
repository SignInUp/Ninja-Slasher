using System.Collections;
using MainCharacter.Ammunition.Swords;
using UnityEngine;

public class MainCharacterFight : MonoBehaviour
{
    [SerializeField] private ISword currentSword;
    [SerializeField] private GameObject damageArea;
    private PolygonCollider2D _damageAreaCollider;
    private DamageArea _damageAreaDamageSystem;
    [SerializeField] private SpriteRenderer swordSprite;
    [SerializeField] private new Camera camera;

    private float _div;
    private void Start()
    {
        _div = (16.0f / 9.0f) / ((float) Screen.height / Screen.width);
        
        damageArea = transform.Find("DamageArea").gameObject;
        _damageAreaDamageSystem = damageArea.GetComponent<DamageArea>();
        _damageAreaCollider = damageArea.GetComponent<PolygonCollider2D>();
        for(var i = 0; i < _damageAreaCollider.points.Length; ++i)
        {
            _damageAreaCollider.points[i] *= _div;
        }
        damageArea.SetActive(false);
        swordSprite = transform.Find("Sword").gameObject.GetComponent<SpriteRenderer>();
        SetSword(new DefaultSword());
        camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Hit());
        }
    }

    public void SetSword(ISword sword)
    {
        currentSword = sword;
        swordSprite.sprite = currentSword.Sprite;
        _damageAreaDamageSystem.Damage = sword.Damage;
        var points = _damageAreaCollider.points;
        points[1] = new Vector2(0f, sword.MainDistance);
        points[0] = new Vector2(
            points[0].x,
            sword.MainDistance * 0.9f
        );
        points[2] = new Vector2(
            points[2].x,
            sword.MainDistance * 0.9f
        );
        points[3] = new Vector2(
            points[3].x,
            sword.MainDistance * 0.8f
        );
        points[5] = new Vector2(
            points[5].x,
            sword.MainDistance * 0.8f
        );
    }
    private IEnumerator Hit()
    {
        damageArea.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        damageArea.SetActive(false);
        yield return null;
    }
}
