﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    SFXController SFXController;
    GameSession gameSession;

    int points = 1;
    bool isPickedUp = false;

    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isPickedUp)
        {
            gameSession.AddPoints(points);
            SFXController = FindObjectOfType<SFXController>();
            SFXController.PlaySFX("music note", 1f);
            Destroy(gameObject);
            isPickedUp = true;
        }
    }
}
