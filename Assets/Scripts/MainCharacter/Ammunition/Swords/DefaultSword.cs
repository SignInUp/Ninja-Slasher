using UnityEngine;

namespace MainCharacter.Ammunition.Swords
{
    public class DefaultSword : ISword
    {
        public int Id { get; }
        public string Name { get; }
        public float Damage { get; }
        public float MainDistance { get; }
        public Sprite Sprite { get; }
        public SpecialAbility Ability { get; }
        public DefaultSword()
        {
            Id = 0;
            Name = "Samurai sword";
            Damage = 20f;
            MainDistance = 0.74f;
            Sprite = Resources.Load<Sprite>("Sprites\\Ammunition\\Swords\\DefaultSword");
            Ability = new SpecialAbility(new[]{SpecialAbilityType.Nothing});
        }
    }
}