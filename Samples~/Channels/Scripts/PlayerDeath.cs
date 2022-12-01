using UnityEngine;

namespace UnderLogic.Channels.Samples
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private RectTransform deathPanel;

        [Header("Input")]
        [SerializeField] private VoidEventChannel diedChannel;

        private void Awake()
        {
            if(deathPanel!=null)
                deathPanel.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            if (diedChannel != null)
                diedChannel.EventRaised += ShowDeathPanel;
        }

        private void OnDisable()
        {
            if (diedChannel != null)
                diedChannel.EventRaised -= ShowDeathPanel;
        }

        private void ShowDeathPanel()
        {
            Debug.Log("You died!");
            
            if (deathPanel != null)
                deathPanel.gameObject.SetActive(true);
        }
    }
}