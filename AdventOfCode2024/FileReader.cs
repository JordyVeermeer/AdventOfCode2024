
namespace AdventOfCode2024
{
    public class FileReader
    {
        public List<string> ReadFile(string filePath)
        {
            List<string> lines = new List<string>();

            try
            {
                StreamReader sr = new StreamReader(filePath);

                string? line = sr.ReadLine();

                while (line != null)
                {
                    // do something with line
                    lines.Add(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return lines;
        }
    }
}
