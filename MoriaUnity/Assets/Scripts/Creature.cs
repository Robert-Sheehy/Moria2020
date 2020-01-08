﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Creature
    {
        private int strengthBonus;
        private int dexterityBonus;
        private int intelligenceBonus;
        private int HP;
        private int damageNumber;
        private int damageRange;
        private int hitBonus;
        private int damageBonus;
        private int totalAC;
        private Boolean player;

    internal string modelFilename;
    internal string name;
    internal string description;
    internal bool GOCreated;

    public Creature(Character_Stats character)
        {
            // Division by 10 is assuming max stats of 100, may need tweaking
            this.strengthBonus = (int)(character.getStrength() / 10);
            this.dexterityBonus = (int)(character.getDex() / 10);
            this.intelligenceBonus = (int)(character.getIntell() / 10);
            this.HP = (character.getHealth());
            //Values below here (aside from player) are placeholders and will be changed.
            this.damageNumber = 1;
            this.damageRange = 6;
            this.hitBonus = 1;
            this.damageBonus = 1;
            this.totalAC = 14;
            this.player = true;
        }

        public Creature()
        {
            //Enemy creature generation here
            //Values below (aside from player) are placeholders
            this.strengthBonus = 2;
            this.dexterityBonus = 2;
            this.intelligenceBonus = 2;
            this.HP = 30;
            this.damageNumber = 2;
            this.damageRange = 6;
            this.hitBonus = 1;
            this.damageBonus = 1;
            this.totalAC = 14;
            this.player = false;
        }

    public Creature(string name, string description, string filename,int str, int dex, int intel, int hp, int dnum, int drange, int hitbonus, int dbonus,int ac)
    {
        //Enemy creature generation here
        //Values below (aside from player) are placeholders
        this.strengthBonus = 2;
        this.dexterityBonus = 2;
        this.intelligenceBonus = 2;
        this.HP = 30;
        this.damageNumber = 2;
        this.damageRange = 6;
        this.hitBonus = 1;
        this.damageBonus = 1;
        this.totalAC = 14;
        this.player = false;
        this.name = name;
        this.description = description;
        this.modelFilename = filename;
    }
    public void damaged(int damageDealt)
        {
            this.HP = getHealth() - damageDealt;
        }

        public int getStrengthBonus()
        {
            return this.strengthBonus;
        }

        public int getDexterityBonus()
        {
            return this.dexterityBonus;
        }

        public int getIntelligenceBonus()
        {
            return this.intelligenceBonus;
        }

        public int getHealth()
        {
            return this.HP;
        }

        public int getDamageNumber()
        {
            return this.damageNumber;
        }

        public int getDamageRange()
        {
            return this.damageRange;
        }

        public int getHitBonus()
        {
            return this.hitBonus;
        }

        public int getDamageBonus()
        {
            return this.damageBonus;
        }

        public int getAC()
        {
            return this.totalAC;
        }
    }

