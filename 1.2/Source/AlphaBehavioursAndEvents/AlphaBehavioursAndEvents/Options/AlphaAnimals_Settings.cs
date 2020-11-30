﻿using RimWorld;
using UnityEngine;
using Verse;
using System.Collections.Generic;
using System.Linq;


namespace AlphaBehavioursAndEvents
{
    public class AlphaAnimals_Settings : ModSettings

    {
        private static Vector2 scrollPosition = Vector2.zero;
        public Dictionary<string, bool> pawnSpawnStates = new Dictionary<string, bool>();
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Collections.Look(ref pawnSpawnStates, "pawnSpawnStates", LookMode.Value, LookMode.Value, ref pawnKeys, ref boolValues);

          


        }
        private List<string> pawnKeys;
        private List<bool> boolValues;

       

        public void DoWindowContents(Rect inRect)
        {

            List<string> keys = pawnSpawnStates.Keys.ToList().OrderByDescending(x => x).ToList();
            Listing_Standard ls = new Listing_Standard();
            Rect rect = new Rect(inRect.x, inRect.y, inRect.width, inRect.height);
            Rect rect2 = new Rect(0f, 0f, inRect.width - 30f, ((keys.Count/2)+2) * 24);
            Widgets.BeginScrollView(rect, ref scrollPosition, rect2, true);
            ls.ColumnWidth = rect2.width / 2.2f;
            ls.Begin(rect2);
            for (int num = keys.Count - 1; num >= 0; num--)
            {
                if (num == keys.Count/2-1) { ls.NewColumn(); }
                bool test = pawnSpawnStates[keys[num]];
                ls.CheckboxLabeled("AA_DisableAnimal".Translate(PawnKindDef.Named(keys[num]).LabelCap), ref test);
                pawnSpawnStates[keys[num]] = test;
            }
           
            ls.End();
            Widgets.EndScrollView();
            base.Write();


        }


    }

    public class AlphaAnimalsEvents_Settings : ModSettings

    {


        public static bool flagBlackHiveRaids = true;
        public static bool flagStalkingLions = true;
        public static bool flagCactipineDroppods = true;
        public static bool flagSpiderClutchMothers = true;
        public static bool flagAerofleets = true;
        public static bool flagGallatross = true;
        public static bool flagSummitCrab = true;
        public static bool flagBumbledrones = true;
        public static bool flagFrostmites = true;
        public static bool flagAsteroids = true;
        public static bool flagAnimalisk = true;
        public static bool flagMime = true;
        public static bool flagAlphaMechanoids = true;
        public static bool flagAlphaMechanoidsSappers = true;
        public static bool flagHelixienCorpseEffect = true;
        public static bool removeAnimalParticles = false;


        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref flagBlackHiveRaids, "flagBlackHiveRaids", true, true);
            Scribe_Values.Look(ref flagStalkingLions, "flagStalkingLions", true, true);
            Scribe_Values.Look(ref flagCactipineDroppods, "flagCactipineDroppods", true, true);
            Scribe_Values.Look(ref flagSpiderClutchMothers, "flagSpiderClutchMothers", true, true);
            Scribe_Values.Look(ref flagAerofleets, "flagAerofleets", true, true);
            Scribe_Values.Look(ref flagGallatross, "flagGallatross", true, true);
            Scribe_Values.Look(ref flagSummitCrab, "flagSummitCrab", true, true);
            Scribe_Values.Look(ref flagBumbledrones, "flagBumbledrones", true, true);
            Scribe_Values.Look(ref flagFrostmites, "flagFrostmites", true, true);
            Scribe_Values.Look(ref flagAsteroids, "flagAsteroid", true, true);
            Scribe_Values.Look(ref flagAnimalisk, "flagAnimalisk", true, true);
            Scribe_Values.Look(ref flagMime, "flagMime", true, true);
            Scribe_Values.Look(ref flagAlphaMechanoids, "flagAlphaMechanoids", true, true);
            Scribe_Values.Look(ref flagAlphaMechanoidsSappers, "flagAlphaMechanoidsSappers", true, true);
            Scribe_Values.Look(ref flagHelixienCorpseEffect, "flagHelixienCorpseEffect", true, true);
            Scribe_Values.Look(ref removeAnimalParticles, "removeAnimalParticles", false, true);




        }

        public static void DoWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();


            ls.Begin(inRect);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowBlackHive".Translate(), ref flagBlackHiveRaids, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowStalkingLions".Translate(), ref flagStalkingLions, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowCactipineDroppods".Translate(), ref flagCactipineDroppods, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowSpiderClutchMothers".Translate(), ref flagSpiderClutchMothers, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowAerofleet".Translate(), ref flagAerofleets, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowGallatross".Translate(), ref flagGallatross, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowSummitCrab".Translate(), ref flagSummitCrab, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowBumbledrones".Translate(), ref flagBumbledrones, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowFrostmiteCorpses".Translate(), ref flagFrostmites, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowAsteroids".Translate(), ref flagAsteroids, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowAnimalisk".Translate(), ref flagAnimalisk, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowMime".Translate(), ref flagMime, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowAlphaMechanoids".Translate(), ref flagAlphaMechanoids, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowMechanoidSappers".Translate(), ref flagAlphaMechanoidsSappers, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("allowHelixienCorpseEffect".Translate(), ref flagHelixienCorpseEffect, null);
            ls.Gap(12f);
            ls.CheckboxLabeled("removeAnimalParticles".Translate(), ref removeAnimalParticles, null);
            ls.End();
        }



    }










}
