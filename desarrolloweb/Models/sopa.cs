using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desarrolloweb.Models
{
    public class sopa
    {
        static string[] sopa_filas;
        static ListaBuscar[] palabras_objetivo;

        static List<string> _rows;
        static string[] _search;

        public sopa(List<string> rows, string[] search)
        {
            _rows = rows;
            _search = search;
        }

        public List<string> datos()
        {
            bool tmpbool = Cargar_Datos_Post();
            if (tmpbool)
            {
                // Proceso de búsqueda.
                foreach (ListaBuscar objetivos in palabras_objetivo)
                {
                    // Buscar para cada uno de los 8 posibles sentidos.
                    for (int fila_actual = 0; fila_actual < sopa_filas.Length; fila_actual++)
                    {
                        for (int col_actual = 0; col_actual < sopa_filas[fila_actual].Length; col_actual++)
                        {
                            for (int incx = -1; incx < 2; incx++)
                            {
                                for (int incy = -1; incy < 2; incy++)
                                {
                                    if (!(incx == 0 && incy == 0))
                                    {
                                        if (buscar_palabra(objetivos.palabra(), fila_actual, col_actual, incx, incy))
                                        {
                                            objetivos.encontrada();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // Proceso de muestra de resultados.
                List<string> result = new List<string>();
                foreach (ListaBuscar objetivos in palabras_objetivo)
                {
                    result.Add(string.Format("{0}  --> {1} Veces.", objetivos.palabra(), objetivos.veces()));
                    //Console.WriteLine();
                }
                return result;
            }
            return null;
        }

        static bool Cargar_Datos_Post()
        {
            sopa_filas = _rows.ToArray();
            string linealeida;
            palabras_objetivo = new ListaBuscar[_search.Length];
            for (int indice = 0; indice < palabras_objetivo.Length; indice++)
            { 
                linealeida = _search[indice];
                if (linealeida.Length < 2)
                {
                    Console.WriteLine("No se admiten palabras de menos de dos caracteres.\n Se cancela el proceso.");
                    Console.ReadKey(); // Para hacer una pausa y dar tiempo a leer el mensaje.
                    return false;
                }
                palabras_objetivo[indice] = new ListaBuscar(linealeida);
            }
            return true;
        }

        static bool Cargar_Datos_Teclado()
        {
            // Primera línea de datos: Nº de filas y columnas de nuestra Sopa de letras.
            string linealeida;
            int filas, columnas;

            Console.WriteLine("Introduce el número de FILAS y COLUMNAS de la Sopa de letras separados por un Espacio.");
            linealeida = Console.ReadLine();

            filas = Convert.ToInt32(linealeida.Substring(0, linealeida.IndexOf(" ")));
            columnas = Convert.ToInt32(linealeida.Substring(linealeida.IndexOf(" ")));
            sopa_filas = new string[filas];

            // Cargar los caracteres de la matriz.
            for (int indice = 0; indice < filas; indice++)
            {
                Console.WriteLine("Introduce la fila número {0} de la Sopa de Letras.", indice + 1);
                linealeida = Console.ReadLine();
                if (linealeida.Length < columnas) // Por si nos falta algún caracter en alguna de las líneas.
                {
                    Console.WriteLine("La línea " + indice + " no tiene el número de caracteres necesarios.");
                }
                sopa_filas[indice] = linealeida.Substring(0, columnas); // Para que no tome más columnas de las debidas.
            }
            // Capturar el número de palabras a buscar y las palabras.
            Console.Clear();
            Console.WriteLine("Introduce el número de palabras a buscar.");
            linealeida = Console.ReadLine();
            palabras_objetivo = new ListaBuscar[Convert.ToInt32(linealeida)];
            for (int indice = 0; indice < palabras_objetivo.Length; indice++)
            {
                Console.WriteLine("Escribe la palabra a buscar Num. {0}.", indice);
                linealeida = Console.ReadLine();
                if (linealeida.Length < 2)
                {
                    Console.WriteLine("No se admiten palabras de menos de dos caracteres.\n Se cancela el proceso.");
                    Console.ReadKey(); // Para hacer una pausa y dar tiempo a leer el mensaje.
                    return false;
                }
                palabras_objetivo[indice] = new ListaBuscar(linealeida);
            }
            return true;
        }
        static bool buscar_palabra(string palabra, int xinicial, int yinicial, int inc_x, int inc_y)
        {
            bool retorno = false;
            bool seguir = true;
            int iteraciones = 0;

            while (seguir)
            {
                if (xinicial < 0 || yinicial < 0 || xinicial + 1 > sopa_filas.Length || yinicial + 1 > sopa_filas[0].Length)
                {
                    seguir = false;
                }
                else
                {
                    if (palabra.Substring(iteraciones, 1) == sopa_filas[xinicial].Substring(yinicial, 1))
                    {
                        iteraciones++;
                        xinicial += inc_x;
                        yinicial += inc_y;
                        if (iteraciones == palabra.Length) // Hemos encontrado una coincidencia.
                        {
                            retorno = true;
                            seguir = false;
                        }
                    }
                    else
                    {
                        seguir = false;
                    }
                }
            }

            return retorno;
        }
        
    }
}
