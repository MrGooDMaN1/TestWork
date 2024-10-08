using System;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void ShowCharacter(string name, int level, string avatar);
    public abstract Sprite LoadSpriteFromResources(string imagePath);
}
