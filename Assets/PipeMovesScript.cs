using UnityEngine;

// We added writing this script to the parent object.
// So when we are moving the parent object all the child objects will move all of them at once.
public class PipeMovesScript : MonoBehaviour
{

    // Creating a variable for the move speed of the pipes
    // We can give a default value for the variable and change the value from the UI if needed
    public float moveSpeed = 5;

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
    }
}
