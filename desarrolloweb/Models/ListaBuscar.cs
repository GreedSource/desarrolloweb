using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desarrolloweb.Models
{
    public class ListaBuscar
    {
        string _palabra;
        int _veces;

        public ListaBuscar(string palabra)
        {
            _palabra = palabra;
            _veces = 0;
        }
        public string veces()
        {
            return _veces.ToString().Trim();
        }
        public string palabra()
        {
            return _palabra;
        }
        public int Longitud()
        {
            return _palabra.Length;
        }
        public void encontrada()
        {
            _veces++;
        }
    }
}
