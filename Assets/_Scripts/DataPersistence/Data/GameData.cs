using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public long lastUpdated;
    public string currentScene;
    public SerializableDictionary<string, Vector3> playerPosition;
    public SerializableDictionary<string, Combo> combosUnlocked;

    //example of how to save a dictionary; potentially useful for collectibles
    //and even which bosses have been defeated. Make sure to give each a unique
    //string to use as its ID/key in the dictionary
    //public SerializableDictionary<string, bool> bossesDefeated;
    //public SerializableDictionary<string, bool> cutscenesPlayed;

    //values defined in this constructor are the values each save starts with
    public GameData()
    {
        //Set player position at the start of the game
        playerPosition = new SerializableDictionary<string, Vector3>();
        playerPosition.Add("", new Vector3(330.4f, 20, 79.89f));
        currentScene = "BaselineShores";
        combosUnlocked = new SerializableDictionary<string, Combo>();

        //Debug.Log("New save created.");
    }
}