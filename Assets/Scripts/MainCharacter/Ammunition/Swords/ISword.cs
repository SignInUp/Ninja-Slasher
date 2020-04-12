using UnityEngine;

namespace MainCharacter.Ammunition.Swords
{
    public interface ISword
    {
        int Id { get; }
        float Damage { get; }
        string Name { get; }
        float MainDistance { get; }
        Sprite Sprite { get; }
        SpecialAbility Ability { get; }
    }
}