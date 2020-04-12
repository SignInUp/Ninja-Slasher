using System.Collections.Generic;

namespace MainCharacter.Ammunition
{
    public enum SpecialAbilityType
    {
        Nothing,
        Fire,
        Electricity,
        Freeze
    }
    public class SpecialAbility
    {
        public SpecialAbilityType[] Abilities { get; }
        public SpecialAbility(SpecialAbilityType[] abilities)
        {
            Abilities = abilities;
        }
        
    }
}