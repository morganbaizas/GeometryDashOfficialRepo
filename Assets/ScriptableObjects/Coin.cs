using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Coin", menuName = "Coin")]

public class Coin : ScriptableObject
{
    public int coinValue;
    public Color color1;
    public Color color2;
}
