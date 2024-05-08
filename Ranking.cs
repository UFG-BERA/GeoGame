namespace GeoGame
{
    public partial class Ranking : Form
    {
        readonly string Username; // Almacena el nombre del usuario
        readonly Guid IdUser; // Almacena el identificador único del usuario

        public Ranking(Guid idUser, string username)
        {
            InitializeComponent();
            Username = username;
            IdUser = idUser; // Inicializa el IdUser con el valor pasado como parámetro
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            // Configura el `ListView` para mostrar detalles y columnas
            lstResultados.View = View.Details;
            lstResultados.Columns.Clear();
            lstResultados.Columns.Add("#", 50, HorizontalAlignment.Center); // Columna para el índice
            lstResultados.Columns.Add("Nombre", 150, HorizontalAlignment.Center); // Columna para el nombre del usuario
            lstResultados.Columns.Add("Puntuación", 120, HorizontalAlignment.Center); // Columna para la puntuación

            // Define la ruta al archivo de puntuaciones
            string basePath = Application.StartupPath;
            string relativePath = @"..\..\..\Ranking.txt";
            string fullPath = Path.Combine(basePath, relativePath);

            if (File.Exists(fullPath))
            {
                // Lee todas las líneas del archivo en una matriz
                var lines = File.ReadAllLines(fullPath);

                // Utiliza un diccionario para mantener el IdUser más reciente
                var scoreDict = new Dictionary<Guid, (string Username, int Score)>();

                // Procesa cada línea para separar los datos en `IdUser`, `Username` y `Score`
                foreach (string line in lines)
                {
                    var parts = line.Split(' ');
                    // Comprueba que la línea tenga el formato correcto
                    if (parts.Length == 3 && Guid.TryParse(parts[0], out Guid idUser) && int.TryParse(parts[2], out int score))
                    {
                        // Reemplaza la entrada anterior si el IdUser ya está en el diccionario
                        scoreDict[idUser] = (parts[1], score);
                    }
                }

                // Convierte el diccionario a una lista ordenada por puntuación en orden descendente
                var sortedScores = scoreDict.Select(kv => (kv.Key, kv.Value.Username, kv.Value.Score))
                    .OrderByDescending(x => x.Score).ToList();

                lstResultados.Items.Clear(); // Limpia cualquier dato anterior en el `ListView`
                ListViewItem highlightedItem = null;



                // Añade cada entrada ordenada al `ListView`
                for (int i = 0; i < sortedScores.Count; i++)
                {
                    var entry = sortedScores[i];
                    var item = new ListViewItem((i + 1).ToString()); // Índice de la posición
                    item.SubItems.Add(entry.Username); // Nombre del usuario
                    item.SubItems.Add(entry.Score.ToString()); // Puntuación

                    // Verifica si es el IdUser que buscamos para resaltar
                    if (entry.Key == IdUser)
                    {
                        item.BackColor = System.Drawing.Color.Yellow; // Cambia el color de fondo para resaltar
                        highlightedItem = item;
                        //item.Selected = true;
                    }

                    lstResultados.Items.Add(item); // Añade el ítem al `ListView`
                }

                // Ajusta automáticamente las columnas según el tamaño del encabezado
                lstResultados.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                if (highlightedItem != null)
                {
                    // Desplázate automáticamente al ítem resaltado
                    highlightedItem.EnsureVisible();
                }


                // Reescribe el archivo para conservar la lista actualizada
                using (StreamWriter sw = new StreamWriter(fullPath, false))
                {
                    foreach (var entry in sortedScores)
                    {
                        sw.WriteLine($"{entry.Key} {entry.Username} {entry.Score}"); // Escribe cada línea
                    }
                }
            }
            else
            {
                // Mensaje si el archivo no existe
                MessageBox.Show("No se encontró el archivo de puntuaciones.");
            }
        }


        // Método vacío para manejar cambios de selección en el `ListView`
        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Evento para el botón que reinicia el cuestionario
        private void btnReintentar_Click(object sender, EventArgs e)
        {
            Reintentar();
        }


        void Reintentar()
        {
            // Crea una nueva instancia del formulario `Preguntas`
            Preguntas preguntas = new(IdUser, Username);
            this.Hide(); // Oculta el formulario actual
            preguntas.ShowDialog(); // Muestra el nuevo formulario y espera a que se cierre
            this.Close(); // Cierra el formulario original
        }

        private void Ranking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Reintentar();
            }
        }

    }
}
