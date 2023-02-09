using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace ProjetoFinal_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar as cidades
            City ARAGUARI = new City("ARAGUARI");
            City CAPINÓPOLIS = new City("CAPINÓPOLIS");
            City CASCALHO_RICO = new City("CASCALHO RICO");
            City CENTRALINA = new City("CENTRALINA");
            City DOURADINHOS = new City("DOURADINHOS");
            City ESTRELA_DO_SUL = new City("ESTRELA DO SUL");
            City GRUPIARA = new City("GRUPIARA");
            City INDIANÓPOLIS = new City("INDIANÓPOLIS");
            City ITUIUTABA = new City("ITUIUTABA");
            City ITUMBIARA = new City("ITUMBIARA");
            City MONTE_ALEGRE_DE_MINAS = new City("MONTE ALEGRE DE MINAS");
            City ROMARIA = new City("ROMARIA");
            City SÃO_JULIANA = new City("SÃO JULIANA");
            City TUPACIGUARA = new City("TUPACIGUARA");
            City UBERLÂNDIA = new City("UBERLÂNDIA");

            // Adicionar as estradas entre as cidades
            CAPINÓPOLIS.AddRoad(CENTRALINA, 40);
            CAPINÓPOLIS.AddRoad(ITUIUTABA, 30);

            ITUIUTABA.AddRoad(CAPINÓPOLIS, 30);
            ITUIUTABA.AddRoad(MONTE_ALEGRE_DE_MINAS, 85);
            ITUIUTABA.AddRoad(DOURADINHOS, 90);

            CENTRALINA.AddRoad(CAPINÓPOLIS, 40);
            CENTRALINA.AddRoad(ITUMBIARA, 20);
            CENTRALINA.AddRoad(MONTE_ALEGRE_DE_MINAS, 75);

            ITUMBIARA.AddRoad(CENTRALINA, 20);
            ITUMBIARA.AddRoad(TUPACIGUARA, 55);

            TUPACIGUARA.AddRoad(ITUMBIARA, 55);
            TUPACIGUARA.AddRoad(MONTE_ALEGRE_DE_MINAS, 44);
            TUPACIGUARA.AddRoad(UBERLÂNDIA, 60);

            MONTE_ALEGRE_DE_MINAS.AddRoad(TUPACIGUARA, 44);
            MONTE_ALEGRE_DE_MINAS.AddRoad(CENTRALINA, 75);
            MONTE_ALEGRE_DE_MINAS.AddRoad(ITUIUTABA, 85);
            MONTE_ALEGRE_DE_MINAS.AddRoad(DOURADINHOS, 28);
            MONTE_ALEGRE_DE_MINAS.AddRoad(UBERLÂNDIA, 60);

            DOURADINHOS.AddRoad(ITUIUTABA, 90);
            DOURADINHOS.AddRoad(UBERLÂNDIA, 63);
            DOURADINHOS.AddRoad(MONTE_ALEGRE_DE_MINAS, 28);

            UBERLÂNDIA.AddRoad(TUPACIGUARA, 60);
            UBERLÂNDIA.AddRoad(MONTE_ALEGRE_DE_MINAS, 60);
            UBERLÂNDIA.AddRoad(DOURADINHOS, 63);
            UBERLÂNDIA.AddRoad(ARAGUARI, 30);
            UBERLÂNDIA.AddRoad(ROMARIA, 78);
            UBERLÂNDIA.AddRoad(INDIANÓPOLIS, 45);

            ARAGUARI.AddRoad(UBERLÂNDIA, 30);
            ARAGUARI.AddRoad(ESTRELA_DO_SUL, 34);
            ARAGUARI.AddRoad(CASCALHO_RICO, 28);

            CASCALHO_RICO.AddRoad(ARAGUARI, 28);
            CASCALHO_RICO.AddRoad(GRUPIARA, 32);

            GRUPIARA.AddRoad(CASCALHO_RICO, 32);
            GRUPIARA.AddRoad(ESTRELA_DO_SUL, 38);

            ESTRELA_DO_SUL.AddRoad(GRUPIARA, 38);
            ESTRELA_DO_SUL.AddRoad(ARAGUARI, 34);
            ESTRELA_DO_SUL.AddRoad(ROMARIA, 27);

            ROMARIA.AddRoad(ESTRELA_DO_SUL, 27);
            ROMARIA.AddRoad(UBERLÂNDIA, 78);
            ROMARIA.AddRoad(SÃO_JULIANA, 28);

            INDIANÓPOLIS.AddRoad(UBERLÂNDIA, 45);
            INDIANÓPOLIS.AddRoad(SÃO_JULIANA, 40);

            SÃO_JULIANA.AddRoad(ROMARIA, 28);
            SÃO_JULIANA.AddRoad(INDIANÓPOLIS, 40);

            // Criar o mapa
            Map map = new Map();
            map.AddCity(ARAGUARI);
            map.AddCity(CAPINÓPOLIS);
            map.AddCity(CASCALHO_RICO);
            map.AddCity(CENTRALINA);
            map.AddCity(DOURADINHOS);
            map.AddCity(ESTRELA_DO_SUL);
            map.AddCity(GRUPIARA);
            map.AddCity(INDIANÓPOLIS);
            map.AddCity(ITUIUTABA);
            map.AddCity(ITUMBIARA);
            map.AddCity(MONTE_ALEGRE_DE_MINAS);
            map.AddCity(ROMARIA);
            map.AddCity(SÃO_JULIANA);
            map.AddCity(TUPACIGUARA);
            map.AddCity(UBERLÂNDIA);

            // Criar as cidades
            string origem = comboBoxOrigem.Text;
            string destino = comboBoxDestino.Text;
            City cidadeOrigem = new City(origem);
            City cidadeDestino = new City(destino);

            if (origem == "ARAGUARI")
                cidadeOrigem = ARAGUARI;
            else if (origem == "CAPINÓPOLIS")
                cidadeOrigem = CAPINÓPOLIS;
            else if (origem == "CASCALHO RICO")
                cidadeOrigem = CASCALHO_RICO;
            else if (origem == "CENTRALINA")
                cidadeOrigem = CENTRALINA;
            else if (origem == "DOURADINHOS")
                cidadeOrigem = DOURADINHOS;
            else if (origem == "ESTRELA DO SUL")
                cidadeOrigem = ESTRELA_DO_SUL;
            else if (origem == "GRUPIARA")
                cidadeOrigem = GRUPIARA;
            else if (origem == "INDIANÓPOLIS")
                cidadeOrigem = INDIANÓPOLIS;
            else if (origem == "ITUIUTABA")
                cidadeOrigem = ITUIUTABA;
            else if (origem == "ITUMBIARA")
                cidadeOrigem = ITUMBIARA;
            else if (origem == "MONTE ALEGRE DE MINAS")
                cidadeOrigem = MONTE_ALEGRE_DE_MINAS;
            else if (origem == "ROMARIA")
                cidadeOrigem = ROMARIA;
            else if (origem == "SÃO JULIANA")
                cidadeOrigem = SÃO_JULIANA;
            else if (origem == "TUPACIGUARA")
                cidadeOrigem = TUPACIGUARA;
            else if (origem == "UBERLÂNDIA")
                cidadeOrigem = UBERLÂNDIA;

            if (destino == "ARAGUARI")
                cidadeDestino = ARAGUARI;
            else if (destino == "CAPINÓPOLIS")
                cidadeDestino = CAPINÓPOLIS;
            else if (destino == "CASCALHO RICO")
                cidadeDestino = CASCALHO_RICO;
            else if (destino == "CENTRALINA")
                cidadeDestino = CENTRALINA;
            else if (destino == "DOURADINHOS")
                cidadeDestino = DOURADINHOS;
            else if (destino == "ESTRELA DO SUL")
                cidadeDestino = ESTRELA_DO_SUL;
            else if (destino == "GRUPIARA")
                cidadeDestino = GRUPIARA;
            else if (destino == "INDIANÓPOLIS")
                cidadeDestino = INDIANÓPOLIS;
            else if (destino == "ITUIUTABA")
                cidadeDestino = ITUIUTABA;
            else if (destino == "ITUMBIARA")
                cidadeDestino = ITUMBIARA;
            else if (destino == "MONTE ALEGRE DE MINAS")
                cidadeDestino = MONTE_ALEGRE_DE_MINAS;
            else if (destino == "ROMARIA")
                cidadeDestino = ROMARIA;
            else if (destino == "SÃO JULIANA")
                cidadeDestino = SÃO_JULIANA;
            else if (destino == "TUPACIGUARA")
                cidadeDestino = TUPACIGUARA;
            else if (destino == "UBERLÂNDIA")
                cidadeDestino = UBERLÂNDIA;


            if (comboBoxOrigem.Text == "" || comboBoxDestino.Text == "")
            {
                MessageBox.Show("INSIRA AS CIDADES!");
            }
            else
            {
                richTextBox1.Clear();
                List<City> path = Dijkstra.ShortestPath(map, cidadeOrigem, cidadeDestino);

                richTextBox1.Text += "Partindo de: " + comboBoxOrigem.Text + ", e indo para: " + comboBoxDestino.Text + Environment.NewLine;

                foreach (City city in path)
                {
                    richTextBox1.Text += city.Name;

                    if (city.Name != comboBoxDestino.Text)
                    {
                        richTextBox1.Text += " -> ";
                    }
                }

                richTextBox1.Text += Environment.NewLine;
                richTextBox1.Text += "Tamanho do caminho: " + CalculateDistance(path) + "Km" + Environment.NewLine + Environment.NewLine;

            }

        }

        static int CalculateDistance(List<City> path)
        {
            int distance = 0;
            for (int i = 0; i < path.Count - 1; i++)
            {
                distance += path[i].GetRoadTo(path[i + 1]).Distance;
            }
            return distance;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            comboBoxDestino.Text = "";
            comboBoxOrigem.Text = "";

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

            
        }
    }
}