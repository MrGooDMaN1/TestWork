using System;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private CharacterPresenter _characterPresenter;
    [SerializeField] private CharacterView _characterView; //UI binding
    private int _characterList = 0;


    public Button selectCharacterButton;
    public Button selectCharacterButtonRandom;

    void Start()
    {
        var characterContainer = new SelectionContainer<CharacterModel>();

        //Presenter initialization
        _characterPresenter = new CharacterPresenter(characterContainer, _characterView);

        //Cоздания персонажа
        var character1 = new CharacterModel("Knight", 14, "Avatars/knight");
        var character2 = new CharacterModel("Mage", 12, "Avatars/mage");
        var character3 = new CharacterModel("Rogue", 10, "Avatars/rogue");
        var character4 = new CharacterModel("Archer", 13, "Avatars/archer");

        //Adding characters to the pool
        _characterPresenter.AddCharacter(character1);
        _characterPresenter.AddCharacter(character2);
        _characterPresenter.AddCharacter(character3);
        _characterPresenter.AddCharacter(character4);

        //Button binding
        selectCharacterButton.onClick.AddListener(() => CharacterCount(_characterList));
        selectCharacterButtonRandom.onClick.AddListener(() => 
        {
            int randomIndex = Random.Range(0, _characterPresenter.characters.Count);
            _characterPresenter.SelectCharacter(randomIndex);
        });

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
