using UnityEngine;
// We need to use the UnityEngine.UI to get additional functionalities like
using UnityEngine.UI;
// We need to use the UnityEngine.SceneManagement to get additional functionalities to manage scences like restarting
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // The logic manager keeps track of critical data like health, time and score.
    // We can make that information visible to the player using a User Interface
    // For that we are using a Text UI
    // The following script should store the player's score and change the text of the UI acording to that score

    // First we need to store the player score in a variabe
    public int playerScore;

    // We need to reference the Text UI component inorder to do changes to it via the script
    public Text scoreText;

    // We can use the following lines to try out a function from Unity UI itself
    [ContextMenu("Increase Score")]

    // Now we are making a function to add score
    // Because we are going to run this function from other scripts we are setting it to public void
    public void addScore(int scoreToAdd)
    {
        // This function needs to do tw things
        // 1. Add 1 to the player's score
        playerScore = playerScore + scoreToAdd;
        // 2. Then change the Text on the UI
        // We need to transform the int into a string
        scoreText.text = playerScore.ToString();
    }


    // Button's OnClick() event let's us call a public function from a script
    // So we are going to write the restartGame() funtion here
    public void restartGame()
    {
        // Here we're going to write the code to restart the scene
    }
}
