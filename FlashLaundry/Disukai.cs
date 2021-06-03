using System;
using System.Collections.Generic;
using System.Text;

namespace Disukai
{
    // Nama Class Disukai
    public class Disukai
    {
        // Deklarasi variabel id jasa & id pengguna
        private String _idJasa, _idPengguna;

        // Mengambil nilai id jasa
        public String getIdJasa()
        {
            return _idJasa;
        }

        // Mengeset nilai id jasa
        public void setIdJasa(String idJasa)
        {
            this._idJasa = idJasa;
        }

        // Mengambil nilai id Pengguna
        public String getIdPengguna()
        {
            return _idPengguna;
        }

        // Mengeset nilai id Pengguna
        public void setIdPengguna(String idPengguna)
        {
            this._idPengguna = idPengguna;
        }

        //Mengisi data variabel dengan data yang dibutuhkan (constructor)
        public Disukai(String idJasa, String idPengguna)
        {
            this._idJasa = idJasa;
            this._idPengguna = idPengguna;
        }
    }
}