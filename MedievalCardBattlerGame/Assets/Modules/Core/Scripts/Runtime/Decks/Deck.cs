using System;
using System.Collections.Generic;
using Modules.Core.Scripts.Runtime.Cards;
using UnityEngine;

namespace Modules.Core.Scripts.Runtime.Decks
{
    public class Deck : MonoBehaviour
    {
        [SerializeField] private List<CardData> drawPile = new List<CardData>();

        private void Start()
        {
            DrawCard();
        }

        public CardData DrawCard()
        {
            if (drawPile.Count > 0)
            {
                // Draw and remove top card
                var topIndex = drawPile.Count - 1;
                var data = drawPile[topIndex];
                drawPile.RemoveAt(topIndex);
                return data;
            }

            return null;
        }
    }
}