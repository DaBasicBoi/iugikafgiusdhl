using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

public bool gameHasEnded = false;
   public GameObject gameManager;
   public class Uded {

        void EndGame()
        {
            if (gameHasEnded == false)
            {
            gameHasEnded = true;
            Uded = SetActive(true);
            Restart();
            }
        }

        void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
