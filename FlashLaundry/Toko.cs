using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD12_1302190074
{
    class Toko
    {
        //Deklarasi variabel yang dibutuhkan
        private String _idToko, _namaToko, _deskripsiToko, _alamatToko;
        private int _totalDisukai, _totalJasa;

        //Mengisi data Toko dengan data yang terdapat pada parameter (Constructor)
        public Toko(String idToko, String namaToko, String deskripsiToko, String alamatToko, int totalDisukai, int totalJasa)
        {
            this._idToko = idToko;
            this._namaToko = namaToko;
            this._deskripsiToko = deskripsiToko;
            this._alamatToko = alamatToko;
            this._totalDisukai = totalDisukai;
            this._totalJasa = totalJasa;
        }

        //Mengambil nilai _idToko
        public String getidToko()
        {
            return _idToko;
        }

        //Men-set nilai _idToko
        public void setidToko(String idToko)
        {
            this._idToko = idToko;
        }

        //Mengambil nilai _namaToko
        public String getnamaToko()
        {
            return _namaToko;
        }

        //Men-set nilai _namaToko
        public void setnamaToko(String namaToko)
        {
            this._namaToko = namaToko;
        }

        //Mengambil nilai _namaToko
        public String getdeskripsiToko()
        {
            return _deskripsiToko;
        }

        //Men-set nilai _deskripsiToko
        public void setdeskripsiToko(String deskripsiToko)
        {
            this._deskripsiToko = deskripsiToko;
        }

        //Mengambil nilai _alamatToko
        public String getalamatToko()
        {
            return _alamatToko;
        }

        //Men-set nilai _alamatToko
        public void setalamatToko(String alamatToko)
        {
            this._alamatToko = alamatToko;
        }

        //Mengambil nilai _totalDisukai
        public int gettotalDisukai()
        {
            return _totalDisukai;
        }

        //Men-set nilai _totalDisukai
        public void settotalDisukai(int totalDisukai)
        {
            this._totalDisukai = totalDisukai;
        }

        //Mengambil nilai _totalJasa
        public int gettotalJasa()
        {
            return _totalJasa;
        }

        //Men-set nilai _totalJasa
        public void settotalJasa(int totalJasa)
        {
            this._totalJasa = totalJasa;
        }

    }
}
