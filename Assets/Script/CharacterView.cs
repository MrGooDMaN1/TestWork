using UnityEngine.UI;
using UnityEngine;

public class CharacterView : View
{
    [SerializeField] private Text characterNameText;
    [SerializeField] private Text characterLevelText;
    [SerializeField] private Image avatarImage;

    public override void ShowCharacter(string name, int level, string avatar)
    {
        characterNameText.text = $"Name: {name}";
        characterLevelText.text = $"Level: {level}";
        avatarImage.sprite = LoadSpriteFromResources(avatar);
    }

    public override Sprite LoadSpriteFromResources(string imagePath)
    {
        return Resources.Load<Sprite>(imagePath);
    }
}
