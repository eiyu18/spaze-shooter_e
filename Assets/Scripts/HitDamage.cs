using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class HitDamage : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color hitColor = Color.red;
    public int jumlahKaki = 100;
    public String nama = "";
    public GameObject[] gameObjects; 
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer.color = hitColor;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
