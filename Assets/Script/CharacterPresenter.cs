using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterPresenter : Presenter
{
    public CharacterPresenter(SelectionContainer<CharacterModel> characterContainer, View view) : base (characterContainer, view) { }
    public List<CharacterModel> characters = new List<CharacterModel>();

    //Adding a character to the pool
    public override void AddCharacter(CharacterModel character)
    {
        characters.Add(character);
    }

    public override void SelectCharacter(int index)
    {
        if (index >= 0 && index < characters.Count)
        {
            currentCharacter = characters[index];
            currentCharacter.LoadData(); //Uploading character data
            _view.ShowCharacter(currentCharacter.Name, currentCharacter.Level, currentCharacter.GetAvatarSprite().name);//Send the character data to the exit
            Debug.Log($"Character {currentCharacter.Name} selected.");
        }
        else
        {
            Debug.LogWarning("Invalid character index.");
        }
    }
}
