using TMPro;
using UnityEngine;

namespace Modules.Core.Scripts.Runtime.Cards
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer iconRenderer;
        [SerializeField] private TextMeshPro cardNameText;
        [SerializeField] private TextMeshPro descriptionText;
        [SerializeField] private TextMeshPro actionsText;

        [SerializeField] private CardData tempCardData;

        private void Start()
        {
            LoadCardData(tempCardData);
        }

        public void LoadCardData(CardData cardData)
        {
            iconRenderer.sprite = cardData.Icon;
            cardNameText.text = cardData.CardName;
            descriptionText.text = cardData.Description;
            actionsText.text = cardData.ActionCost.ToString();
        }
    }
}