
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // Establishing values
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update () {
        transform.position = player.position + offset;// Here we are making the camera's position equal to the player's, plus the offset, which we can edit in the inspector.
    }
}
