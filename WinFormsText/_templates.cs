using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WinFormsText
{
   
 public   class _templates
    {
       public string fileName { get; set; }
        [XmlAttribute(AttributeName = "Type")]
      public  string M = "Model";
        public List<Material> CombineXMesh { get; set; } = new List<Material>();


    }
    [Serializable]
    public class Material
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "AlbedoMap")]
        public string Texture { get; set; }
        [XmlAttribute(AttributeName = "ShadingMap")]
        public string Shading { get; set; }
        [XmlAttribute(AttributeName = "NormalMap")]
        public string NormalMap { get; set; }

        public Material() { }
        public Material(string Name, string Texture, string Shading, string NormalMap)
        {
            this.Name = Name;
            this.Texture = Texture;
            this.Shading = Shading;
            this.NormalMap = NormalMap;
        }
    }
}
