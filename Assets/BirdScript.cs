using UnityEngine;

public class BirdScript : MonoBehaviour

    // We can change aspects of a Game Object and it's components using C# coding.
    // Initially a script can only can talk to the Game Object's top bit and the transform section.
    // The script is initially unaware of the other components.
    // We need to create a speacial slot on the script to talk to these components using commands.
    // These slots are called references.
{
    // We are going to create the references up here.

    // RigidBody2D makes the object a physics object with gravity.
    // Creating a slot to have the rigidbody2d component.
    // We need to give a specific name so that we can to the specific Rigidbody2D component.
    // Becuase we made this public we can access this 
    public Rigidbody2D myRigidBody;

    // We are going to create a variables so we can easily change the value of these fields using the Unity UI's inspector section
    public float flapStrength;

    // Any code that runs as soon as the script is enabled. Ony runs single time.
    void Start()
    {

    }

    // Any code that runs constantly while script is enabled.
    void Update()
    {
        // Any code in the update section will run over and over again every frame
        // We need to use a if condition execute some code if the game meets
        // We need to Vector2.up only if the user hits the spacebar.
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            // Changing the properties of the rigidbody (like velocity)
            // We are going to change the posictions using vectors (x,y)
            // Vector.up will increase the y from 1 (0,1)
            // We can multiply the value to create more values (flapStrength = Multiplier)
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

      
    }
}
