using System;
namespace MOD12_1302194089
{
    public class Jasa
    {
        private String _namaJasa, _deskripsiJasa;
        private int _idJasa, _idToko, _harga, _diskon, _totalDisukai;

        //Constructor Jasa
        public Jasa(int idJasa, int idToko, String namaJasa, 
                    String deskripsiJasa, int harga, int diskon)
        { 
            _idJasa = idJasa;
            _idToko = idToko;
            _namaJasa = namaJasa;
            _deskripsiJasa = deskripsiJasa;
            _harga = harga;
            _diskon = diskon;
        }

        //Mendapatkan value _idJasa
        public int getIdJasa() 
        { 
            return _idJasa; 
        }

        //Men-set _idJasa
        public void setIdJasa(int idJasa) 
        { 
            _idJasa = idJasa; 
        }

        //Mendapatkan value _idToko
        public int getIdToko() 
        { 
            return _idToko; 
        }

        //Men-set _idToko
        public void setIdToko(int idToko) 
        { 
            _idToko = idToko; 
        }

        //Mendapatkan value _namaJasa
        public String getNamaJasa() 
        { 
            return _namaJasa; 
        }
        
        //Men-set  _namaJasa
        public void setNamaJasa(String namaJasa) 
        { 
            _namaJasa = namaJasa; 
        }

        //Mendapatkan value _deskripsiJasa
        public String getDeskripsiJasa() 
        { 
            return _deskripsiJasa; 
        }

        //Men-set _deskripsiJasa
        public void setDeskripsiJasa(String deskripsiJasa) 
        { 
            _deskripsiJasa = deskripsiJasa; 
        }

        //Mendapatkan value _harga
        public int getHarga() 
        { 
            return _harga; 
        }

        //Men-set _harga
        public void setHarga(int harga) 
        { 
            _harga = harga; 
        }

        //Mendapatkan value _diskon
        public int getDiskon() 
        { 
            return _diskon; 
        }

        //Men-set _diskon
        public void setDiskon(int diskon) 
        { 
            _diskon = diskon; 
        }

        //Mendapatkan value _totalDisukai
        public int getTotalDisukai() 
        { 
            return _totalDisukai; 
        }

        //Men-set _totalDisukai
        public void setTotalDisukai(int totalDisukai) 
        { 
            _totalDisukai = totalDisukai; 
        }
    }
}