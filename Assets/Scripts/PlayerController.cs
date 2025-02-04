using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _speed = 10.0f;
    private float _playerWallOffset = 1.5f;
    
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        
        // Calculate the new position
        float newPositionX = transform.position.x + (_horizontalInput * _speed * Time.deltaTime);

        // Check if the new position exceeds the bounds of the walls
        if (newPositionX < leftWall.bounds.max.x + _playerWallOffset)
        {
            newPositionX = leftWall.bounds.max.x + _playerWallOffset;
        }
        else if (newPositionX > rightWall.bounds.min.x - _playerWallOffset)
        {
            newPositionX = rightWall.bounds.min.x - _playerWallOffset;
        }

        // Update the player's position
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
