//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Scripting;

namespace Unity.Services.Core.Environments.Client.Http
{
    /// <summary>
    /// JsonObject class for encapsulating generic object types. We use this to
    /// hide internal Json implementation details.
    /// </summary>
    [Preserve]
    [JsonConverter(typeof(JsonObjectConverter))]
    internal class JsonObject : IDeserializable
    {
        /// <summary>
        /// Constructor sets object as the internal object.
        /// </summary>
        [Preserve]
        internal JsonObject(object obj)
        {
            this.obj = obj;
        }

        /// <summary>The encapsulated object.</summary>
        [Preserve]
        internal object obj;

        /// <summary>
        /// Returns the internal object as a string.
        /// </summary>
        /// <returns>The internal object as a string.</returns>
        public string GetAsString()
        {
            try
            {
                if (obj == null)
                {
                    return "";
                }

                if (obj.GetType() == typeof(String))
                {
                    return obj.ToString();
                }
                
                return IsolatedJsonConvert.SerializeObject(obj);
            }
            catch (System.Exception)
            {
                throw new InvalidOperationException("Failed to convert JsonObject to string.");
            }
        }

        /// <summary>
        /// Returns the object as a defined type.
        /// Previously this function restricted use of `object` or `dynamic`
        /// types but validation for these has been removed. As such, be
        /// careful when passing or exposing objects of these types.
        /// </summary>
        /// <typeparam name="T">The type to cast internal object to.</typeparam>
        /// <param name="deserializationSettings">Deserialization settings for how to handle properties like missing members.</param>
        /// <returns>The internal object cast to type T.</returns>
        public T GetAs<T>(DeserializationSettings deserializationSettings = null)
        {
            // Check if deserializationSettings is null so we can use the default value.
            deserializationSettings = deserializationSettings ?? new DeserializationSettings();
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings
            {
                MissingMemberHandling = deserializationSettings.MissingMemberHandling == MissingMemberHandling.Error
                    ? Newtonsoft.Json.MissingMemberHandling.Error
                    : Newtonsoft.Json.MissingMemberHandling.Ignore
            };
            try
            {
                var returnObject = IsolatedJsonConvert.DeserializeObject<T>(IsolatedJsonConvert.SerializeObject(obj), jsonSettings);
                return returnObject;
            }
            catch (JsonSerializationException e)
            {
                throw new DeserializationException(e.Message);
            }
            catch (Exception)
            {
                throw new DeserializationException("Unable to deserialize object.");
            }
        }

        /// <summary>
        /// Overload for returning the object as a defined type but without
        /// needing to specify DeserializationSettings.
        /// </summary>
        /// <typeparam name="T">The type to cast internal object to.</typeparam>
        /// <returns>The internal object case to type T.</returns>
        public T GetAs<T>()
        {
            return this.GetAs<T>(null);
        }

        /// <summary>
        /// Convert object to jsonobject.
        /// </summary>
        /// <param name="o">The object.</param>
        /// <returns>The jsonobject.</returns>
         static IDeserializable GetNewJsonObjectResponse(object o)
        {
            return (IDeserializable) new JsonObject(o);
        }

        /// <summary>
        /// Convert list of object to list of jsonobject.
        /// </summary>
        /// <param name="o">The list of objects.</param>
        /// <returns>The list of jsonobjects.</returns>
         static List<IDeserializable> GetNewJsonObjectResponse(List<object> o)
        {
            if (o == null) {
                return null;
            }
            return o.Select(v => (IDeserializable) new JsonObject(v)).ToList();
        }

        /// <summary>
        /// Convert list of list of object to list of list of jsonobject.
        /// </summary>
        /// <param name="o">The list of list of objects.</param>
        /// <returns>The list of list of jsonobjects.</returns>
         static List<List<IDeserializable>> GetNewJsonObjectResponse(List<List<object>> o)
        {
            if (o == null) {
                return null;
            }
            return o.Select(l => l.Select(v => v == null ? null : (IDeserializable) new JsonObject(v)).ToList()).ToList();
        }

        /// <summary>
        /// Convert dictionary of string, object to dictionary of string, jsonobject.
        /// </summary>
        /// <param name="o">The dictionary of string, objects.</param>
        /// <returns>The dictionary of string, jsonobjects.</returns>
         static Dictionary<string, IDeserializable> GetNewJsonObjectResponse(Dictionary<string, object> o)
        {
            if (o == null) {
                return null;
            }
            return o.ToDictionary(kv => kv.Key, kv => (IDeserializable) new JsonObject(kv.Value));
        }

        /// <summary>
        /// Convert dictionary of string, list of object to dictionary of string, list of jsonobject.
        /// </summary>
        /// <param name="o">The dictionary of string to list of objects.</param>
        /// <returns>The dictionary of string, list of jsonobjects.</returns>
         static Dictionary<string, List<IDeserializable>> GetNewJsonObjectResponse(Dictionary<string, List<object>> o) {
            if (o == null) {
                return null;
            }
            return o.ToDictionary(kv => kv.Key, kv => GetNewJsonObjectResponse(kv.Value));
        }
    }
}
