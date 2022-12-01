using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Channels.Samples
{
    public class PlayerHealth : MonoBehaviour
    {
        private int _health = 100;
        
        [SerializeField] private Slider healthSlider;

        [Header("Input")]
        [SerializeField] private IntEventChannel damageChannel;
        [SerializeField] private IntEventChannel healChannel;
        
        [Header("Output")]
        [SerializeField] private VoidEventChannel diedChannel;

        private void Start() => UpdateHealthDisplay();

        private void OnEnable()
        {
            if (damageChannel != null)
                damageChannel.EventRaised += OnDamageTaken;

            if (healChannel != null)
                healChannel.EventRaised += OnHealDamage;
        }

        private void OnDisable()
        {
            if (damageChannel != null)
                damageChannel.EventRaised -= OnDamageTaken;
            
            if (healChannel != null)
                healChannel.EventRaised -= OnHealDamage;
        }

        private void OnDamageTaken(int amount)
        {
            if (amount <= 0 || _health <= 0)
                return;
            
            var prevHealth = _health;
            _health = Mathf.Clamp(_health - amount, 0, 100);
            UpdateHealthDisplay();
            
            Debug.Log($"Health: {_health}, took {amount} damage!");

            if (prevHealth > 0 && _health <= 0 && diedChannel != null)
                diedChannel.RaiseEvent();
        }

        private void OnHealDamage(int amount)
        {
            if (amount <= 0)
                return;
            
            _health = Mathf.Clamp(_health + amount, 0, 100);
            UpdateHealthDisplay();
            
            Debug.Log($"Health: {_health}, healed by {amount}!");
        }

        private void UpdateHealthDisplay()
        {
            if (healthSlider == null)
                return;

            healthSlider.value = Mathf.FloorToInt(_health);
        }
    }
}
