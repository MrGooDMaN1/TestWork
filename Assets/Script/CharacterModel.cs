using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : Model
{
    public CharacterModel(string name, int level, string avatar) : base(name, level, avatar) { }
    private Sprite _avatarSprite;  //Sparite for avatar

    public override void LoadData()
    {
        //Uploading an avatar
        if (_avatarSprite == null)
        {
            _avatarSprite = Resources.Load<Sprite>(Avatar);
            if (_avatarSprite == null)
            {
                Debug.LogError($"Avatar image at path {Avatar} could not be loaded.");
            }
        }
    }
    //Get an avatar image
    public override Sprite GetAvatarSprite()
    {
        return _avatarSprite;
    }
}
