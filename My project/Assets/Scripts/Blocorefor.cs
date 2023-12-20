using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocorefor : MonoBehaviour
{
    public int hp = 3;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out renderer);
    }
    public void Tomouhit()
    {
        hp--;
        renderer.color *= 1.5f;
        if (hp <= 0){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
