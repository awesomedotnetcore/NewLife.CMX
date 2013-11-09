﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NewLife.Xml;

namespace NewLife.CMX.Config
{
    [XmlConfigFile("config/UploadImage.config", 15000)]
    /// <summary>上传图片</summary>
    [Description("上传图片")]
    [Serializable]
    public class UploadImage : CMXmlConfig<UploadImage>
    {
        private String _ImagePath = "UploadImage";
        /// <summary>图片目录</summary>
        public String ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }
    }
}