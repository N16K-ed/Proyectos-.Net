using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // Mostrar "Cargando..."
            lblCargando.Visible = true;

            // Ocultar controles con datos
            lblDatos.Visible = false;
            lstTipos.Visible = false;
            lstHabilidades.Visible = false;
            lstEstadisticas.Visible = false;
            lstMovimientos.Visible = false;
            picSprite.Visible = false;

            string nombre = txtNombre.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(nombre))
            {
                lblCargando.Visible = false;
                MessageBox.Show("Por favor ingresa un nombre de Pokémon.");
                return;
            }

            string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";

            using HttpClient client = new HttpClient();

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(json);

                // Actualiza datos
                double alturaMetros = pokemon.height / 10.0;
                double pesoKg = pokemon.weight / 10.0;

                lblDatos.Text = $"{pokemon.name.ToUpper()} (ID: {pokemon.id})\n" +
                                $"Altura: {alturaMetros} m  |  Peso: {pesoKg} kg\n" +
                                $"Base XP: {pokemon.base_experience}";

                lstTipos.Items.Clear();
                foreach (var tipo in pokemon.types)
                    lstTipos.Items.Add(tipo.type.name);

                lstHabilidades.Items.Clear();
                foreach (var hab in pokemon.abilities)
                    lstHabilidades.Items.Add(hab.ability.name);

                lstEstadisticas.Items.Clear();
                foreach (var stat in pokemon.stats)
                    lstEstadisticas.Items.Add($"{stat.stat.name}: {stat.base_stat} (Esfuerzo {stat.effort})");

                lstMovimientos.Items.Clear();
                foreach (var mov in pokemon.moves)
                    lstMovimientos.Items.Add(mov.move.name);

                if (!string.IsNullOrEmpty(pokemon.sprites.front_default))
                {
                    using var stream = await client.GetStreamAsync(pokemon.sprites.front_default);
                    picSprite.Image?.Dispose();
                    picSprite.Image = Image.FromStream(stream);
                }
                else
                {
                    picSprite.Image?.Dispose();
                    picSprite.Image = null;
                }

                // Ocultar "Cargando..." y mostrar controles
                lblCargando.Visible = false;
                lblDatos.Visible = true;
                lstTipos.Visible = true;
                lstHabilidades.Visible = true;
                lstEstadisticas.Visible = true;
                lstMovimientos.Visible = true;
                picSprite.Visible = true;
            }
            catch (HttpRequestException)
            {
                lblCargando.Visible = false;
                MessageBox.Show("No se pudo obtener información del Pokémon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblCargando.Visible = false;
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

    }
}
