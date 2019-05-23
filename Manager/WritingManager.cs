using OOP_FileWriting_Example.Manager.Writers;
using OOP_FileWriting_Example.Models;
using System.IO;

namespace OOP_FileWriting_Example.Manager {
    class WritingManager {

        internal void WriteFile(IWriter writer) {
            FileModel fileModel = writer.Write();

            using (var sw = new StreamWriter("sample" + fileModel.Extension)) {
                sw.Write(fileModel.Content);
            }
        }
    }
}
