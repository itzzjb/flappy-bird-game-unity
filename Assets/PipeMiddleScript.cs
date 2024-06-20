using UnityEngine;

// We are using this invicible component with a box colider to act as a trigger
// So we are going to use that to it as a trigger to identify whether the bird passed a set of pipes from the middle
public class PipeMiddleScript : MonoBehaviour
{
    // We need to write a reference here
    // Because we need to use the addScore() function that we created in LogicScript.cs
    // We can't drag and drop the logicScipt to the slot in the Unity UI
    // That's because the pipe doesn't exist until the game is started. (Pipes are spawned by the pipeSpawner)
    // We need to use tags instead
    // Created a new tag called Logic in the middle object and used the same tag in the logicManager object
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As soon as a new pipe spawns it will look through the hierarchy to find a game object with the tag "Logic"
        // Then it will look through the object's components to find the script of the class LogicScript
        // And if it finds one if will put that in our reference slot
        // It does the exact same thing as dragging and dropping to the slot
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Anything in this function will run whenever a object first hit the trigger
    // There are more funtions like OnTriggerExit and OnTriggerStay too
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Calling the addScore function in the LogicScript
        logic.addScore();
    }
}
