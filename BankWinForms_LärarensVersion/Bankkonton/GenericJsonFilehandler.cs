namespace Bankkonton
{
    using Newtonsoft.Json;

    using System;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="GenericJsonFilehandler{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class GenericJsonFilehandler<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericJsonFilehandler{T}"/> class.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        public GenericJsonFilehandler(string filename)
        {
            Filename = filename;
        }

        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        public T Data { get; set; } = default;

        /// <summary>
        /// Gets or sets the Filename.
        /// </summary>
        public string Filename { get; set; } = "";

        /// <summary>
        /// The Load.
        /// </summary>
        public void Load()
        {
            string data = string.Empty;
            if (File.Exists(Filename + ".json"))
            {
                try
                {
                    data = File.ReadAllText(Filename + ".json");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    data = "{}";
                }
            }
            try
            {
                Data = JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// The Save.
        /// </summary>
        public void Save()
        {
            File.WriteAllText(
                Filename + ".json",
                JsonConvert.SerializeObject(Data, Formatting.Indented,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                })
                );
        }
    }
}