using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Invader_Animation : MonoBehaviour
{

    public Sprite[] animationSprites = new Sprite[2];
    public float animationTime;

    SpriteRenderer spRend;
    int animationFrame;


    private void Awake()
    {
        spRend = GetComponent<SpriteRenderer>();
        spRend.sprite = animationSprites[0];
    }

    private void Start()
    {

    }

    private void AnimateSprite()
    {
        animationFrame++;
        if (animationFrame >= animationSprites.Length)
        {
            animationFrame = 0;
        }
        spRend.sprite = animationSprites[animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.gameObject.layer == LayerMask.NameToLayer("Layer"))
        {
            GameManager.Instance.OnInvaderKilled(this);
        }
        else if (Collision.gameObject.layer == LayerMask.NameToLayer("Boundary"))
        {
            GameManager.Instance.OnBoundaryReached();
        }
    }

}
