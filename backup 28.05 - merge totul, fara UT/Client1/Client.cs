using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Client 
    {
        private int _idClient;
        private int _indexMasa;
        private List<Produs> _produsList = new List<Produs>();
        private String _observatii;

        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }
        public int IndexMasa
        {
            get { return _indexMasa; }
            set { _indexMasa = value; }
        }

        public String Observatii
        {
            get { return _observatii; }
            set { _observatii = value; }
        }
        public Client(int idClient, int indexMasa)
        {
            _idClient = idClient;
            _indexMasa = indexMasa;
        }

        public void  AdaugaProdus(Produs produs)
        {
            _produsList.Add(produs);
        }

        public void TrimiteComanda()
        {
            
            IComanda comanda = new Comanda(_idClient, _produsList, _observatii);
            Chelner.Instance().PreiaComanda(comanda, _indexMasa);
        }
    }
}
