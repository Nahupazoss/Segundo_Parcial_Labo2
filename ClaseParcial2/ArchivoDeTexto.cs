using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public static class ArchivosDeTexto
    {
        /*public static StreamWriter sw;
        public static StreamReader sr;
        public static string path;

        static ArchivosDeTexto()
        {
            if (!Directory.Exists("..\\Archivos"))
            {
                Directory.CreateDirectory("..\\Archivos");
            }

            ArchivosDeTexto.path = "..\\Archivos\\partidasTerminadas.txt";
        }

        public static bool AgregarAlArchivo(List<PartidaTerminada> lista)
        {
            bool agrego = false;

            try
            {
                ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path, true);
                foreach (PartidaTerminada item in lista)
                {
                    ArchivosDeTexto.sw.WriteLine(item.ToString());
                }
                agrego = true;
            }
            catch (Exception e)
            {
                agrego = false;
            }
            finally
            {
                if (ArchivosDeTexto.sw != null)
                    ArchivosDeTexto.sw.Close();
            }

            return agrego;
        }

        public static bool SobreescribirElArchivo(List<PartidaTerminada> lista)
        {
            bool agrego = false;
            try
            {
                using (ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path))
                {
                    foreach (PartidaTerminada item in lista)
                    {
                        ArchivosDeTexto.sw.WriteLine(item.ToString());
                    }
                }
                agrego = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return agrego;
        }

        public static List<PartidaTerminada> LeerArchivoLineaALinea()
        {
            string retorno = "";
            List<PartidaTerminada> lista = new List<PartidaTerminada>();
            try
            {
                if (File.Exists(path))
                {
                    string[] text = File.ReadAllLines(path);

                    for (int i = 0; i < text.Length - 1; i++)
                    {
                        string jugador1 = "";
                        string jugador2 = "";
                        int puntaje1 = 0;
                        int puntaje2 = 0;
                        string jugadorGanador = "";
                        int contador = 0;

                        foreach (string dato in text[i].Split('-'))
                        {
                            switch (contador)
                            {
                                case 0:
                                    jugador1 = dato;
                                    break;
                                case 1:
                                    jugador2 = dato;
                                    break;
                                case 2:
                                    puntaje1 = int.Parse(dato);
                                    break;
                                case 3:
                                    puntaje2 = int.Parse(dato);
                                    break;
                                case 4:
                                    resultado = dato;
                                    break;
                            }
                            contador++;
                        }
                        PartidaTerminada partida = new PartidaTerminada(jugador1, jugador2,jugadorGanador,);
                        lista.Add(partida);
                    }
                    //using (ArchivosDeTexto.sr = new StreamReader(ArchivosDeTexto.path))
                    //{
                    //    while ((retorno = ArchivosDeTexto.sr.ReadLine()) != null)
                    //    {
                    //        string[] partida = retorno.Split(" - ");

                    //        PartidaTerminada p = new PartidaTerminada(partida[0], partida[1], int.Parse(partida[2]), int.Parse(partida[3]), partida[4]);

                    //        lista.Add(p);
                    //    }
                    //}
                }

            }
            catch (Exception e)
            {
                lista = null;
            }

            return lista;
        }

        public static string LeerArchivoHastaElFinal()
        {
            string retorno = "";
            try
            {
                using (ArchivosDeTexto.sr = new StreamReader(ArchivosDeTexto.path))
                {
                    retorno = ArchivosDeTexto.sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }

            return retorno;
        }
        */

    }
}