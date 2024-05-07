using System.Data;

namespace GeoGame
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            string basePath = Application.StartupPath;
            string relativePath = @"..\..\..\Ranking.txt";
            string fullPath = Path.Combine(basePath, relativePath);
            if (File.Exists(fullPath))
            {
                // Leer todas las líneas del archivo
                var lines = File.ReadAllLines(fullPath);

                // Crear una lista para almacenar pares de (nombre, puntuación)
                var scoreList = new List<(string Username, int Score)>();

                // Procesar cada línea para separar el nombre y la puntuación
                foreach (string line in lines)
                {
                    var parts = line.Split(' ');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        scoreList.Add((parts[0], score));
                    }
                }

                // Ordenar por puntuación en orden descendente
                var sortedScores = scoreList.OrderByDescending(x => x.Score).ToList();

                // Mostrar los resultados en un ListBox u otro control
                lstResultados.Items.Clear();
                lstResultados.Items.Add("# - Nombre - Puntuacion");
                for (int i = 0; i < sortedScores.Count; i++)
                {
                    var entry = sortedScores[i];
                    lstResultados.Items.Add($"{i + 1}. - {entry.Username} - {entry.Score}");
                }

                // Si deseas, puedes reescribir el archivo ordenado para conservar los resultados
                using (StreamWriter sw = new StreamWriter(fullPath, false))
                {
                    foreach (var entry in sortedScores)
                    {
                        sw.WriteLine($"{entry.Username} {entry.Score}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de puntuaciones.");
            }
        }
    }
}
