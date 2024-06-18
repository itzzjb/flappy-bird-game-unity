using UnityEngine;

// We added writing this script to the parent object.
// So when we are moving the parent object all the child objects will move all of them at once.
public class PipeMovesScript : MonoBehaviour
{

    // Creating a variable for the move speed of the pipes
    // We can give a default value for the variable and change the value from the UI if needed
    public float moveSpeed = 5;

    // When new and new pipes gets created from the pipeSpawner they will be there until the aplication is stopped.
    // So even after we can't see the pipe from the displa it will continuesly using resources of the device
    // We can define a deadzone by giving a x value (When the pipe reaches that x value it will be deleted)
    public float deadZone = -45;

    void Start()
    {
        
    }

    void Update()
    {
        // We are going to change the positions using vectors (x,y,z) -> Vector3
        // Vector2.left will decrease the  from 1 (-1,0,0)
        // We can multiply the value to create more values (moveSpeed = Multiplier)
        // By multiplying by Time.deltaTime, it ensures that 
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // When the pipe reaches that x value it will be deleted
        if (transform.position.x < deadZone)
        {

            // We can maintain a debug log.
            // When pipes are deleted a message will get logged.
            // We can view the logs from the console section of Unity. ( Tab next to Project)
            Debug.Log("A Pipe Got Deleted.");

            // Destoying the pipe that was created using this template
            Destroy(gameObject);
        }
    }
}

