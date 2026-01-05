namespace TP3_DotNet.Models
{
    public class Documents
    {
        public List<Document> GetListeDocuments()
        {
            List<Document> Id = new ();
            string path = Path.GetFullPath("wwwroot/Files");
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.EnumerateFiles()) {
                Document document = new();
                document.Nom = file.Name;
                document.Taille = file.Length /1024 + "Kb";
                document.Extension = file.Extension;
                Id.Add(document);
            }

            return Id;
        }

        public class Document
        {
            public string Nom { get; set; }
            public string Taille { get; set; }
            public string Extension { get; set; }
        }
    }
}
