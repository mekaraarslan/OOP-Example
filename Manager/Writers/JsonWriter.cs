using Newtonsoft.Json;
using OOP_FileWriting_Example.Models;
using System.Collections.Generic;

namespace OOP_FileWriting_Example.Manager.Writers {
    class JsonWriter : BaseWriter, IWriter {

        public JsonWriter(List<Product> products) {
            this.products = products;
        }

        public FileModel Write() {
            string json = JsonConvert.SerializeObject(this.products);

            return new FileModel() {
                Extension = ".json",
                Content = json
            };
        }
    }
}
