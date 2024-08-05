using UnityEngine;

// We dragged and dropped the previously created pipe object to the Assets
// This created a prefabricated game object or prefab
// This is like a blueprint for a game object
// We can create new version of this entire game object with all of its children , components and properties.

public class PipeSpawnScript : MonoBehaviour
{

    // First we need to create a reference to the prefab
    public GameObject pipe;

    // We need to more variables to following

    // How many seconds between spawns
    public float spawnRate = 2;

    // Number that counts up (time)
    // We can make this private because we won't be changing this in the editor or anywhere else
    private float timer = 0;

    // We want to make the x value of the pipes to be the same and Y values to change when sawing relative to the spawner
    // For that we are going to create height offset variable
    public float heightOffset = 10;

    void Start()
    {
        // Calling the SpawnPipe function
        SpawnPipe();
    }

    void Update()
    {
        // We are going to use an if condition to 

        if (timer < spawnRate)
        {
            // Creating a number that counts up no matter the frame rate.
            timer = timer + Time.deltaTime;
        }
        else
        {
            // Calling the SpawnPipe function
            SpawnPipe();
            // When the timer is equal to spawn rate it will be reset to 0
            timer = 0;
        }
    }

    // We need to use the spawn code in both Start() and Update()
    // It is not a good idea to duplicate the same code in multiple places
    // So we are going to create a new function for that
    void SpawnPipe()
    {
        // We are making some variables inside the function because only need to use them within the function
        // And also we will be able to set a value to that using a calculation
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // We can use the following method to spawn game objects
        // We are creating a new 3-dimensional vector (new Vector3)
        // We are having the same x value as the spawner
        // A random Y value between the lowestPoint and the highestPoint
        // Then 0 for z value
        // By using transform.rotation we are using the same rotation as the spawner 
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint) ,0), transform.rotation);
    }
}
