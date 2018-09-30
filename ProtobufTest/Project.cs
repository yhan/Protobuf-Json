namespace ProtobufTest
{
    using ProtoBuf;

    [ProtoContract(SkipConstructor = true)]
    //[ProtoContract]
    public class Project
    {
        public Project()
        {
        }

        public Project(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }
    }
}