﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class BackgroundResize : MonoBehaviour {

     void Update () {
        var sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;
        
        transform.localScale = new Vector3(1,1,1);
        
        var width = sr.sprite.bounds.size.x;
        var height = sr.sprite.bounds.size.y;
        
        var worldScreenHeight = Camera.main.orthographicSize * 2.0;
        var worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
        
        transform.localScale = new Vector3((float)(worldScreenWidth / width), (float)(worldScreenHeight / height), 1);
     }
 }