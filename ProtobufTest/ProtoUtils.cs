﻿namespace ProtobufTest
{
    using System.IO;

    using ProtoBuf;

    public class ProtoUtils
    {
        public static T ProtoDeserialize<T>(byte[] data)
            where T : class
        {
            if (null == data) return null;

            try
            {
                using (var stream = new MemoryStream(data))
                {
                    return Serializer.Deserialize<T>(stream);
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        public static byte[] ProtoSerialize<T>(T record)
            where T : class
        {
            if (null == record) return null;

            try
            {
                using (var stream = new MemoryStream())
                {
                    Serializer.Serialize(stream, record);
                    return stream.ToArray();
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }
    }
}