using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;

namespace BoardsLibrary.Plugin.LibraryItsSelf
{
    internal class Board
    {
        public static void Setcoc(string COCTOP, string COCBOTTOM, Color col)
        {
            var Objects = new[]
            {
                GameObject.Find("CodeOfConduct"), // Top
                GameObject.Find("COC Text"), // Bottom
                GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/forestatlas (combined by EdMeshCombinerSceneProcessor)") // bg
            };
            Objects[0].GetComponent<Text>().text = COCTOP;
            Objects[1].GetComponent<Text>().text = COCBOTTOM;
            Material gdg = new Material(Shader.Find("GorillaTag/UberShader"))
            {
                color = col,
            };
            Objects[2].GetComponent<MeshRenderer>().material = gdg;
        }
        public static void SetMOTD(string Top, string bottom)
        {
            var objects = new[]{
                GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/motd"), // TOP
                GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/motd/motdtext"), // BOTTOM
            };
            objects[0].GetComponent<Text>().text = Top;
            objects[1].GetComponent<Text>().text = bottom;
        }

    }
}
