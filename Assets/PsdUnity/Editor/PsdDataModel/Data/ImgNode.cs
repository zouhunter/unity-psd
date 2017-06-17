﻿using System;
using UnityEngine;

namespace PSDUnity
{
    [Serializable]
    public class ImgNode
    {
        public string picturename = "";
        public string clampname = "";
        public int id;
        public string AddressedName { get { return clampname + id; } }
        public ImgType type;
        public ImgSource source;
        public Rect rect;
        public Sprite sprite;
        public Texture2D texture;
        public string text = "";
        public string font;
        public int fontSize = 0;
        public Color color = UnityEngine.Color.white;

        public ImgNode() { }
        public ImgNode(int id,string name, Rect rect, Texture2D texture) : this(id,name, rect)
        {
            //利用name 解析type和source
            type = ImgType.AtlasImage;
            //type = ImgType.Image;
            //type = ImgType.Texture;
            source = ImgSource.Custom;
            this.rect = rect;
            this.texture = texture;
            //添加后缀
            texture.name = AddressedName;
        }
        public ImgNode(int id,string name, Rect rect, Color color) : this(id, name, rect)
        {
            type = ImgType.Color;
            this.color = color;
        }
        public ImgNode(int id, string name, Rect rect, string font, int fontSize, string text, Color color):this(id, name,rect)
        {
            type = ImgType.Label;
            this.font = font;
            this.fontSize = fontSize;
            this.text = text;
            this.color = color;
        }

        private ImgNode(int id,string name,Rect rect)
        {
            this.picturename = name;
            this.clampname = ClampName(name);
            this.rect = rect;
            this.id = id;
        }

        /// <summary>
        /// 将名字转换（去除标记性字符）
        /// </summary>
        /// <returns></returns>
        public static string ClampName(string name)
        {
            string clampName = name;
            if (clampName.Contains("#"))
            {
                var index = clampName.IndexOf("#");
                clampName.Remove(index);
            }

            return clampName;
        }
    }

}