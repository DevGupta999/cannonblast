using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aspectManager : MonoBehaviour
{
    public SpriteRenderer ground;
    // Start is called before the first frame update
    void Start()
    {
        float orthoSize = ground.bounds.size.x * Screen.height / Screen.width * 0.5f;
        Camera.main.orthographicSize = orthoSize;
    }

    
}
