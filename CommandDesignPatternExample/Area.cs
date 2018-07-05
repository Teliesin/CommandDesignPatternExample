namespace CommandDesignPatternExample
{
    public class Area
    {
        public string[][] Fields { get; set; }

        public Area()
        {
            Fields = GenerateEmptyArea10x10();

            Fields[2][3] = "Kwiatek";
            Fields[7][8] = "Piłka";
            Fields[7][2] = "Gazeta";
        }

        private string[][] GenerateEmptyArea10x10()
        {
            string[][] fields = new string[10][];

            for (int i = 0; i < 10; i++)
            {
                fields[i] = new string[10];

                for (int j = 0; j < 10; j++)
                {
                    fields[i][j] = string.Empty;
                }
            }

            return fields;
        }
    }
}