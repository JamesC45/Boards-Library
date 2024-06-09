using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using UnityEngine;

namespace BoardsLibrary
{
    [BepInPlugin("AZORA", "BOARDSCONFIG", "1.0.0")]
    public class Load : BaseUnityPlugin
    {
        public void Update()
        {
            // Updating boards every frame

            // strings
            var list = new List<string>()
            {
                "BOARDS LIBRARY", // MOTD TOP
                "BOARDS LIBRARY", // COC TOP
                "this is a modification for gorilla tag that allows you to change the boards as you like.", // COC BOTTOM
                "FOLLOW MY GITHUB :PRAY: - (github.com/JamesC45)", // MOTD BOTTOM
            };
            var Colors = new List<Color>() // this is for motd and coc btw.
            {
                Color.black, // Color 1
                new Color(0.2f, 0.2f, 0.2f, 1f) // Color 2
            };
            BoardsLibrary.Plugin.LibraryItsSelf.Board.Setcoc(list[1], list[2].ToUpper(), Color.Lerp(Colors[0], Colors[1], Mathf.PingPong(Time.time, 1f)));
            BoardsLibrary.Plugin.LibraryItsSelf.Board.SetMOTD(list[0], list[3].ToUpper());
        }

    }
}
