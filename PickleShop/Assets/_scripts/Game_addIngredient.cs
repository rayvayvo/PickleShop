using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_addIngredient : MonoBehaviour
{
    [SerializeField] private GameObject[] _ingredientList;
    [SerializeField] private GameObject _plateImage;

    private List<GameObject> _currentIngredientList;

    private void Start()
    {
        _currentIngredientList = new List<GameObject>();
    }

    public void AddIngredient(GameObject _ingredient)
    {
        GameObject _tempIngredient = Instantiate(_ingredient, _plateImage.transform);
        _tempIngredient.SetActive(true);
        _tempIngredient.transform.SetAsFirstSibling();
        _currentIngredientList.Add(_tempIngredient);
    }
}
