using UnityEngine;
using Enemies;
public class MetaEnemie : MonoBehaviour
{
    public int Id;
    public EnemieType MyType;
    private HealthEnemie _me;

    public void SetData(int id, EnemieType type)
    {
        Id = id;
        MyType = type;
    }

    private void Start()
    {
        _me = GetComponent<HealthEnemie>();
    }

    public void PauseMe(bool isPause)
    {
        StartCoroutine(isPause ? _me.MeDied() : _me.MeRescued());
    }
}
