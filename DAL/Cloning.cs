﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DAL
{
    static class Cloning
    {
        public static T Copy<T>(this T source)
        {
            var isNotSerializable = !typeof(T).IsSerializable;
            if (isNotSerializable)
                throw new ArgumentException("The type must be serializable.", "source");
            var sourceIsNull = ReferenceEquals(source, null);
            if (sourceIsNull)
                return default(T);


            var formatter = new BinaryFormatter(); // Construct a BinaryFormatter and use it to serialize the data to the stream.
            using (var stream = new MemoryStream()) 
            {
                formatter.Serialize(stream, source);//Serialize the source to the stream
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
