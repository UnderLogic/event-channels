using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Channels.Samples.Listeners.Scripts
{
    public class PlayerGoldDisplay : MonoBehaviour
    {
        private int _gold;
        
        [SerializeField] private Text goldText;
        [SerializeField] private Button buyButton;

        private void Start()
        {
            UpdateDisplay();
            UpdateBuyButton();
        }

        public void AddGold(int amount)
        {
            AdjustGold(amount);
            Debug.Log($"Gold is now {_gold}, earned {amount}!");
        }

        public void SubtractGold(int amount)
        {
            AdjustGold(-amount);
            Debug.Log($"Gold is now {_gold}, spent {amount}!");
        }

        private void AdjustGold(int amount)
        {
            _gold = Mathf.Clamp(_gold + amount, 0, 1000000);
            
            UpdateDisplay();
            UpdateBuyButton();
        }

        private void UpdateDisplay()
        {
            if (goldText != null)
                goldText.text = _gold.ToString("n0");
        }
        
        private void UpdateBuyButton()
        {
            if (buyButton == null)
                return;

            buyButton.interactable = _gold >= 500;
        }
    }
}