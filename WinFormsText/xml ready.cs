////using System.Xml.Serialization;
//////XmlSerializer serializer = new XmlSerializer(typeof(Root));
////using (StringReader reader = new StringReader(xml))
////{
////    //var test = (Root)serializer.Deserialize(reader);
////}

//[XmlRoot(ElementName="_templates")]
//public class Templates { 

//	[XmlAttribute(AttributeName="Include")] 
//	public string Include { get; set; } 
//}

//[XmlRoot(ElementName="AnimationSettings")]
//public class AnimationSettings { 

//	[XmlAttribute(AttributeName="HideAnimationDistance")] 
//	public int HideAnimationDistance { get; set; } 
//}

//[XmlRoot(ElementName="MeshLod")]
//public class MeshLod { 

//	[XmlAttribute(AttributeName="HidingDistance")] 
//	public int HidingDistance { get; set; } 

//	[XmlAttribute(AttributeName="MeshName")] 
//	public string MeshName { get; set; } 
//}

//[XmlRoot(ElementName="Material")]
//public class Material { 

//	[XmlAttribute(AttributeName="Name")] 
//	public string Name { get; set; } 

//	[XmlAttribute(AttributeName="AlbedoMap")] 
//	public string AlbedoMap { get; set; } 

//	[XmlAttribute(AttributeName="ShadingMap")] 
//	public string ShadingMap { get; set; } 

//	[XmlAttribute(AttributeName="NormalMap")] 
//	public string NormalMap { get; set; } 
//}

//[XmlRoot(ElementName="CombineXMesh")]
//public class CombineXMesh { 

//	[XmlElement(ElementName="AnimationSettings")] 
//	public AnimationSettings AnimationSettings { get; set; } 

//	[XmlElement(ElementName="MeshLod")] 
//	public List<MeshLod> MeshLod { get; set; } 

//	[XmlElement(ElementName="Material")] 
//	public List<Material> Material { get; set; } 

//	[XmlAttribute(AttributeName="Type")] 
//	public string Type { get; set; } 
//}

//[XmlRoot(ElementName="Root")]
//public class Root { 

//	[XmlElement(ElementName="_templates")] 
//	public Templates Templates { get; set; } 

//	[XmlElement(ElementName="CombineXMesh")] 
//	public CombineXMesh CombineXMesh { get; set; } 
//}

