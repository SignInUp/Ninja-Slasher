using System.Collections.Generic;
using Enemies;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField] private Transform enemiesFolder;
    [SerializeField] private List<MetaEnemie> enemies;
    [SerializeField] private GameObject zombie;

    private void Start()
    {
        zombie = Resources.Load<GameObject>("Prefabs\\Enemies\\Zombie");
        enemiesFolder = GameObject.Find("EnemiesFolder").GetComponent<Transform>();
        CreateLevel();
    }

    public void CreateLevel()
    {
        for (var i = 0; i < 4; ++i)
        {
            var zombieNew = Instantiate(zombie, enemiesFolder);
            var me = zombieNew.GetComponent<MetaEnemie>();
            me.SetData(i, EnemieType.Zombie);
            enemies.Add(zombieNew.GetComponent<MetaEnemie>());
        }
    }
    
    public void EndLevel()
    {
        foreach (var enemie in enemies)
        {
            enemie.PauseMe(true);
        }
    }    
    
}
