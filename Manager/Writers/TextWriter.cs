using OOP_FileWriting_Example.Models;
using OOP_FileWriting_Example.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FileWriting_Example.Manager.Writers {
    class TextWriter : BaseWriter, IWriter {

        public TextWriter(List<Product> products) {
            this.products = products;
        }

        public FileModel Write() {
            string formatted = "";

            int index = 0;
            foreach (var product in products) {
                product.Name = StringUtility.ReplaceTRChars(product.Name);
                string f = $"<{index}: {product.Name}, {product.Price}>";
                formatted += f + ",";
                index++;
            }

            return new FileModel() {
                Extension = ".txt",
                Content = formatted
            };
        }
    }
}
