using UnityEngine;

public class Enviroment : MonoBehaviour
{
    private Rigidbody2D rb;

    #region Boundaries

    float shipBoundaryRadius = 0.5f;

    private void Boundaries()
    {
        Vector3 pos = transform.position;

        // RESTRICT the player to the camera's boundaries!

        // First to vertical, because it's simpler
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        // Now calculate the orthographic width based on the screen ratio
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        // Now do horizontal bounds
        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        // Finally, update our position!!
        transform.position = pos;
    }

    #endregion
}
