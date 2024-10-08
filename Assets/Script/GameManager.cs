using System;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private CharacterPresenter _characterPresenter;
    [SerializeField] private CharacterView _characterView; //UI binding
    private int _characterList = 0;


    public Button selectCharacterButton;

    void Start()
    {
        var characterContainer = new SelectionContainer<CharacterModel>();

        //Presenter initialization
        _characterPresenter = new CharacterPresenter(characterContainer, _characterView);

        //Cоздания персонажа
        var character1 = new CharacterModel("Knight", 10, "knight");
        var character2 = new CharacterModel("Mage", 15, "mage");
        var character3 = new CharacterModel("Rogue", 12, "rogue");

        //Adding characters to the pool
        _characterPresenter.AddCharacter(character1);
        _characterPresenter.AddCharacter(character2);
        _characterPresenter.AddCharacter(character3);

        //Button binding
        selectCharacterButton.onClick.AddListener(() => CharacterCount(_characterList));
    }

    //Character shifter
    public void CharacterCount(int characterList)
    {
        _characterPresenter.SelectCharacter(characterList);
        if (characterList >= _characterPresenter.characters.Count - 1)
            _characterList = 0;
        else _characterList++;
    }
}
