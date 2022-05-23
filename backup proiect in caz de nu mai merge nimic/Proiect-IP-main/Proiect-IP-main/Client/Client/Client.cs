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
            
            Comanda comanda = new Comanda(_idClient, _produsList);
            Chelner.Instance().PreiaComanda(comanda, _indexMasa);

        }

        //client cere nota?
        /*
        public String CereNota()
        {

        }
        */   
    }
}
