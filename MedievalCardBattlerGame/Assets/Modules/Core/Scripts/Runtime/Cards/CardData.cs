using UnityEngine;

namespace Modules.Core.Scripts.Runtime.Cards
{
    [CreateAssetMenu(fileName = "CardData", menuName = "Modules/Core/Data/Card Data")]
    public class CardData : ScriptableObject
    {
        public string CardName;
        public string Description;
        public int ActionCost;
        public Sprite Icon;
        public int AttackPower;
        public int HealPower;
    }
}