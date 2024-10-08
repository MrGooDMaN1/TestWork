using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Presenter : MonoBehaviour
{
    protected SelectionContainer<CharacterModel> _characterContainer;
    protected View _view;
    protected CharacterModel currentCharacter;
    protected int _charactersCount;

    public Presenter(SelectionContainer<CharacterModel> characterContainer, View view)
    {
        _characterContainer = characterContainer;
        _view = view;
    }

    public abstract void AddCharacter(CharacterModel character);
    public abstract void SelectCharacter(int index);
}
