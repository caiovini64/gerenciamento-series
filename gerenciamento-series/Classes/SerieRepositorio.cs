using gerenciamento_series.Interfaces;
using System.Collections.Generic;

namespace gerenciamento_series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        public List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}