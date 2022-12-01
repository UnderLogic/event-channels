using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnderLogic.Channels.Samples
{
    public class GameRestarter : MonoBehaviour
    {
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}