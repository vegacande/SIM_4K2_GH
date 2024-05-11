using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_SIM_G6.LogicaNegocio;

namespace TP3_SIM_G6.LogicaNegocio
{
    public class Neg_Simulacion
    {
        //generacion de simulacion - dias con sus clientes y su demanda
        public static List<Neg_Dia> generarSimulacion(int n, DataTable probabilidades)
        {
            int rndClientes = 0;
            double rndPastelitos = 0;
            int cantPastelitos = 0;
            List<Neg_Dia> dias = new List<Neg_Dia>();

            //generar dias
            for (int d = 0; d < n; d++)
            {
                Random rnd = new Random();

                rndClientes = rnd.Next(10, 30);
                List<Neg_Cliente> clientes = new List<Neg_Cliente>();
                int stockPastelitos = 200;
                double precio = 0;

                //generar clientes por dia
                for (int c = 0; c < rndClientes; c++)
                {
                    rndPastelitos = rnd.NextDouble();

                    // Representa la funcion BUSCAR de LibreOffice
                    if (stockPastelitos != 0)
                    {
                        foreach (DataRow prob in probabilidades.Rows)
                        {
                            if (rndPastelitos >= Convert.ToDouble(prob["LI"]) && rndPastelitos < Convert.ToDouble(prob["LS"]))
                            {
                                cantPastelitos = Convert.ToInt32(prob["DEMANDA"]);
                                precio = Convert.ToDouble(prob["PRECIO"]);
                                break;
                            }
                        }
                        Neg_Cliente cliente = new Neg_Cliente(c, cantPastelitos, precio);
                        clientes.Add(cliente);
                        stockPastelitos =- cantPastelitos;
                    }
                    else
                    {
                        break;
                    }
                }

                Neg_Dia dia = new Neg_Dia(d+1, clientes, stockPastelitos);
                dias.Add(dia);
            }

            return dias;
        }


    }
}
