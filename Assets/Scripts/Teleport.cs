using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{


    // Tracks if this specific teleporter is currently on cooldown
    private bool isCoolingDown = false;
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;
    
    [Tooltip("How long to wait before allowing another teleportation.")]
    [SerializeField] float cooldownTime = 3f;

    void Start() 
    {
        // CHALLENGE TIP: Make sure all relevant lights are turned off until you need them on
        // because, you know, that would look cool.
    }

    void OnTriggerEnter(Collider other) 
    {
        if (isCoolingDown == true)
        {
            return;
        }
        TeleportPlayer(other,player,teleportTarget);
        // Challenge 3: DeactivateObject();
        // Challenge 4: IlluminateArea();
        // Challenge 5: StartCoroutine ("BlinkWorldLight");
        // Challenge 6: TeleportPlayerRandom();
    }
    


    // Public method so other teleporters can trigger this one's cooldown
    public void StartCooldown()
    {
        StartCoroutine(CooldownRoutine());
    }

    // The Coroutine that handles the 3-second wait
    private IEnumerator CooldownRoutine()
    {
        isCoolingDown = true;

        // Pause execution of this coroutine for 'cooldownTime' seconds
        yield return new WaitForSeconds(cooldownTime);

        isCoolingDown = false;
    }
    void TeleportPlayer(Collider other, GameObject player, Transform teleportTarget)
    {
        

        // when player collides with teleportA (after standing on it for 3 seconds),
        // spawn at teleportB
        if (other.tag == "Player")
        {
            player.transform.position = teleportTarget.position;

        }
    }
    void DeactivateObject()
    {
       // If player spawns on teleporter, deactivate until collision = false
    }

    void IlluminateArea()
    {
       // code goes here 
    }

    // IEnumerator BlinkWorldLight()
    // {
            // code goes here
    // }

    void TeleportPlayerRandom()
    {
        // code goes here... or you could modify one of your other methods to do the job.
    }

}
