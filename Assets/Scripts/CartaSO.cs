using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "ScriptableObject/Carta", order = 1)]

public class CartaSO : ScriptableObject
{
    public string _nombre; 
    public string _ataque;
    public Sprite _sprite;
}
