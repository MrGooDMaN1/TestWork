using System;
using UnityEngine;

public abstract class Model : MonoBehaviour
{
    public string Name { get; protected set; }
    public int Level { get; protected set; }
    public string Avatar { get; protected set; }

    public Model(string name, int level, string avatar)
    {
        Name = name;
        Level = level;
        Avatar = avatar;
    }
    public abstract void LoadData();
    public abstract Sprite GetAvatarSprite();
}
