namespace UnitTests
{
    using NFluent;

    using NUnit.Framework;

    using ProtobufTest;

    public class ProtoSerializationShould
    {
        [Test]
        public void Proto_Obtain_the_original_object_when_serialize_then_deserialize()
        {
            for (int i = 0; i < 100000; i++)
            {
                var project = new Project(10, "hello protobuf");
                var bytes = ProtoUtils.ProtoSerialize(project);

                var deserializedProject = ProtoUtils.ProtoDeserialize<Project>(bytes);

                Check.That(deserializedProject.Id).IsEqualTo(10);
                Check.That(deserializedProject.Name).IsEqualTo("hello protobuf");
            }
        }
    }
}