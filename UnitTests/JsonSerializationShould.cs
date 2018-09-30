namespace UnitTests
{
    using Newtonsoft.Json;

    using NFluent;

    using NUnit.Framework;

    using ProtobufTest;

    public class JsonSerializationShould
    {
        [Test]
        public void Json_Obtain_the_original_object_when_serialize_then_deserialize()
        {
            for (int i = 0; i < 100000; i++)
            {
                var project = new Project(10, "hello protobuf");
                var json = JsonConvert.SerializeObject(project);

                var deserializedProject = JsonConvert.DeserializeObject<Project>(json);

                Check.That(deserializedProject.Id).IsEqualTo(10);
                Check.That(deserializedProject.Name).IsEqualTo("hello protobuf");
            }
        }
    }
}
