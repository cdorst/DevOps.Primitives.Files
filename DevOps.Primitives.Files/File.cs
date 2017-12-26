namespace DevOps.Primitives.Files
{
    public class File
    {
        public File() { }
        public File(string content, string name, string path, PathType pathType = PathType.Absolute)
        {
            Content = content;
            Name = name;
            Path = path;
            PathType = pathType;
        }

        public string Content { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public PathType PathType { get; set; }
    }
}
