using UnityEngine;

// We dragged and dropped the previously created pipe object to the Assets
// This created a prefabricated game object or prefab
// This is like a blueprint for a game object
// We can create new version of this entire game object with all of it's children , components and properties.

public class PipeSpawnScript : MonoBehaviour
{

    // First we need to create a reference to the prefab
    public GameObject pipe;

    // We need to more variables to following

    // How many seconds between spawns
    public float spawnRate = 2;

    // Number that counts up (time)
    // We can make this private becuase we won't be changing this in the editor or anywhere else
    private float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // We are going to use a if condition to 

        if (timer < spawnRate)
        {
            // Creating a number that counts up no matter the frame rate.
            timer = timer + Time.deltaTime;
        }
        else
        {
            // We can use the following method to spawn game objects
            // By using transform.postion and transform. rotation we are using the same position and the rotation as the spawner
            Instantiate(pipe, transform.position, transform.rotation);
            // When the timer is equal to spawn rate it will be reset to 0
            timer = 0;
        }
    }
}
