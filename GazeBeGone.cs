using CallOfTheWild;
using dnlib.DotNet;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Experience;
using Kingmaker.Blueprints.Classes.Selection;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Blueprints.Items.Equipment;
using Kingmaker.Blueprints.Items;
using Kingmaker.Blueprints.Items.Shields;
using Kingmaker.Blueprints.Items.Armors;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.Controllers.Brain.Blueprints;
using Kingmaker.Controllers.Brain.Blueprints.Considerations;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.Localization;
using Kingmaker.ResourceLinks;
using Kingmaker.UnitLogic;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyJson;

using UnityEngine.UI;

namespace GazeBeGone

{
    class GazeBeGone
    {
        static LibraryScriptableObject library = Main.library;
        


        static internal void load()
        {

            RemoveGaze_BloodmoonWildHuntMonarch();
            RemoveGaze_CR13_WildHunt_ArcherHaste();
            RemoveGaze_CR13_WildHunt_ArcherStandart();
            RemoveGaze_CR15_WildHunt_ScoutStandart();
            RemoveGaze_CR19_WildHunt_MonarchStandart();
            RemoveGaze_WildHunt_ArcherSummon();
            RemoveGaze_WildHunt_ScoutSummon();
            RemoveGaze_HATEOT_WildArcher();
            RemoveGaze_HATEOT_WildHunt_Monarch();
            RemoveGaze_HATEOT_WildHunt_Scout();
            RemoveGaze_FinalDungeon_WildHunt_Archer();
            RemoveGaze_FinalDungeon_WildHunt_Monarch();
            RemoveGaze_FinalDungeon_WildHunt_Scout();
            RemoveGaze_HATEOT_WildHunt_Archer_1();
            RemoveGaze_HATEOT_WildHunt_Monarch_1();
            RemoveGaze_HATEOT_WildHunt_Scout_1();

        }

        
     
    



        static void RemoveGaze_BloodmoonWildHuntMonarch()
        {


            var BloodmoonWildHuntMonarch = library.Get<BlueprintUnit>("5a855ed523725fb4baa71c92caa3bb5a");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            BloodmoonWildHuntMonarch.AddFacts = BloodmoonWildHuntMonarch.AddFacts.RemoveFromArray(WildGazeFeature);


        }


        static void RemoveGaze_CR13_WildHunt_ArcherHaste()
        {


            var CR13_WildHunt_ArcherHaste = library.Get<BlueprintUnit>("7bd0996e15059fc4aaef9b1fddcc0760");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            CR13_WildHunt_ArcherHaste.AddFacts = CR13_WildHunt_ArcherHaste.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_CR13_WildHunt_ArcherStandart()
        {


            var CR13_WildHunt_ArcherStandart = library.Get<BlueprintUnit>("e21b6536b40aaad4e9c9cd6c216778a3");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            CR13_WildHunt_ArcherStandart.AddFacts = CR13_WildHunt_ArcherStandart.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_CR15_WildHunt_ScoutStandart()
        {


            var CR15_WildHunt_ScoutStandart = library.Get<BlueprintUnit>("6f5ff0f1e359ee042ba49a746a507190");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            CR15_WildHunt_ScoutStandart.AddFacts = CR15_WildHunt_ScoutStandart.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_CR19_WildHunt_MonarchStandart()
        {


            var CR19_WildHunt_MonarchStandart = library.Get<BlueprintUnit>("573009c2f6493514188a2844ba53bdf8");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            CR19_WildHunt_MonarchStandart.AddFacts = CR19_WildHunt_MonarchStandart.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_WildHunt_ArcherSummon()
        {


            var WildHunt_ArcherSummon = library.Get<BlueprintUnit>("5333ac43535e27b4bb4cd13ebff95faf");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            WildHunt_ArcherSummon.AddFacts = WildHunt_ArcherSummon.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_WildHunt_ScoutSummon()
        {


            var WildHunt_ScoutSummon = library.Get<BlueprintUnit>("9ce94d8b91d08114f9f9db68c2e8b537");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            WildHunt_ScoutSummon.AddFacts = WildHunt_ScoutSummon.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_HATEOT_WildArcher()
        {


            var HATEOT_WildArcher = library.Get<BlueprintUnit>("e1d82bca92b0efc4db4432fba7e846b6");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildArcher.AddFacts = HATEOT_WildArcher.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_HATEOT_WildHunt_Monarch()
        {


            var HATEOT_WildHunt_Monarch = library.Get<BlueprintUnit>("51f074c44a38785428d62f7f59149886");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildHunt_Monarch.AddFacts = HATEOT_WildHunt_Monarch.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_HATEOT_WildHunt_Scout()
        {


            var HATEOT_WildHunt_Scout = library.Get<BlueprintUnit>("2bf602a36f490b54b840a6177786e91f");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildHunt_Scout.AddFacts = HATEOT_WildHunt_Scout.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_FinalDungeon_WildHunt_Archer()
        {


            var FinalDungeon_WildHunt_Archer = library.Get<BlueprintUnit>("c24521b5b98c2bb40853743737bc0c65");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            FinalDungeon_WildHunt_Archer.AddFacts = FinalDungeon_WildHunt_Archer.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_FinalDungeon_WildHunt_Monarch()
        {


            var FinalDungeon_WildHunt_Monarch = library.Get<BlueprintUnit>("9617071804e42824cbe240a0c5c77b79");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            FinalDungeon_WildHunt_Monarch.AddFacts = FinalDungeon_WildHunt_Monarch.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_FinalDungeon_WildHunt_Scout()
        {


            var FinalDungeon_WildHunt_Scout = library.Get<BlueprintUnit>("67ccc1f6aabee4e4cb7cc2de70702ab5");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            FinalDungeon_WildHunt_Scout.AddFacts = FinalDungeon_WildHunt_Scout.AddFacts.RemoveFromArray(WildGazeFeature);


        }



        static void RemoveGaze_HATEOT_WildHunt_Archer_1()
        {


            var HATEOT_WildHunt_Archer_1 = library.Get<BlueprintUnit>("68f8d8090ed88194782bce7a1d32348d");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildHunt_Archer_1.AddFacts = HATEOT_WildHunt_Archer_1.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_HATEOT_WildHunt_Monarch_1()
        {


            var HATEOT_WildHunt_Monarch_1 = library.Get<BlueprintUnit>("80449c72e68c7bb40a80a46111b847be");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildHunt_Monarch_1.AddFacts = HATEOT_WildHunt_Monarch_1.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        static void RemoveGaze_HATEOT_WildHunt_Scout_1()
        {


            var HATEOT_WildHunt_Scout_1 = library.Get<BlueprintUnit>("d78af2d7e8a78f347a29419432cc9640");
            var WildGazeFeature = library.Get<BlueprintFeature>("330624ea5dafe804f9c976b4781b4e15");



            HATEOT_WildHunt_Scout_1.AddFacts = HATEOT_WildHunt_Scout_1.AddFacts.RemoveFromArray(WildGazeFeature);


        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
