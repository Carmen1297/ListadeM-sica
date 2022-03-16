using System;

namespace FormListaReproduccionG2_2022_II
{
    class Musica
    {
        #region Atributos
        private string cancion;
        private string artista;
        private string album;
        #endregion

        #region Constructor
        public Musica(string cancion, string artista, string album)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
        }
        #endregion

        #region Propiedades
        public string Cancion { 
            get => cancion; 
            set            
            {
                if( value == "")
                {
                    cancion = "Zafiro";
                }
                else
                {
                    cancion = value;
                }

            }
            
        }
        public string Artista { 
            get => artista;
            set
            {
                if( value == "")
                {
                    artista = "Rubytates";
                }else
                {
                    artista = value;
                }
                
            }
        }
        public string Album { 
            get => album; 
            set
            {
                if ( value == "")
                {
                    album = "RE";
                }
                else
                {
                    album = value;
                }
                
            }
                
        }
        #endregion






    }
}
