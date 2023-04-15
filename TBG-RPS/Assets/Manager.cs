using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Fire, Water, Grass;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Fire":
                switch (myChoice)
                {
                    case "Fire":
                        Result.text = "It doesn't affect the opponent...";
                        break;

                    case "Water":
                        Result.text = "It's not very effective...";
                        break;

                    case "Grass":
                        Result.text = "It's super effective!";
                        break;
                }
                break;

            case "Water":
                switch (myChoice)
                {
                    case "Fire":
                        Result.text = "It's super effective!";
                        break;

                    case "Water":
                        Result.text = "It doesn't affect the opponent...";
                        break;

                    case "Grass":
                        Result.text = "It's not very effective...";
                        break;
                }
                break;

            case "Grass":
                switch (myChoice)
                {
                    case "Fire":
                        Result.text = "It's not very effective...";
                        break;

                    case "Water":
                        Result.text = "It's not very effective...";
                        break;

                    case "Grass":
                        Result.text = "It doesn't affect the opponent...";
                        break;
                }
                break;
        }
    }
}
