﻿using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {


    public Occupant occupant
    {//TODO
        get { return null; }
    }

    //Possibly use an enum
    public GameConstants.terrainType terrainType
    {//TODO
        get { return 0; }
    }

    public int x
    {//TODO
        get {return 0; }
        set { }
    }
    public int y
    {//TODO
        get { return 0; }
        set { }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addEffect()
    {
        //TODO
    }

    //Called on initialization
    public void addNeighbor(Tile neighbor)
    {
        //TODO
    }


    void dealDamage(AttackInfo info)
    {
        //TODO
    }

    public void enterTile(Occupant newOccupant)
    {
        //TODO
    }

    public void exitTile()
    {
        //TODO
    }

    public Tile[] getNeighbors()
    {
        //TODO
        return null;
    }
}
