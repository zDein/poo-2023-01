using System;

namespace CSharp.Entities
{
    class Casa
    {
        private Garagem _garagem;
        private Quarto[] _quarto;
        private Banheiro[] _banheiro;
        private Sala _sala;
        private Area _area;

        public Casa()
        {

        }

        public Casa(Garagem garagem, Quarto quarto, Sala sala, Banheiro banheiro, Area area)
        {
            this._garagem = garagem;
            this._quarto = quarto;
            this._sala = sala;
            this._area = area;
            this._banheiro = banheiro;
        }
    }
}