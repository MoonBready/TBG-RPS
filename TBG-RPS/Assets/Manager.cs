using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public TMP_Text Result;
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
                        Result.text = "It's super effective!";
                        break;

                    case "Grass":
                        Result.text = "It's not very effective...";
                        break;
                }

                AIChoice.sprite = Fire;

                break;

            case "Water":
                switch (myChoice)
                {
                    case "Fire":
                        Result.text = "It's not very effective...";
                        break;

                    case "Water":
                        Result.text = "It doesn't affect the opponent...";
                        break;

                    case "Grass":
                        Result.text = "It's super effective!";
                        break;
                }

                AIChoice.sprite = Water;

                break;

            case "Grass":
                switch (myChoice)
                {
                    case "Fire":
                        Result.text = "It's super effective!";
                        break;

                    case "Water":
                        Result.text = "It's not very effective...";
                        break;

                    case "Grass":
                        Result.text = "It doesn't affect the opponent...";
                        break;
                }

                AIChoice.sprite = Grass;

                break;
        }
    }
}
