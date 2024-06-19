using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal class Game
    {
        public enum Resultado
        {
            Success, Lose, Draw
        }

        public static Image[] images =
        {
            Image.FromFile("Pedra.png"),
            Image.FromFile("Tesoura.png"),
            Image.FromFile("Pedra.png")
        };

        public  Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar (int jogador)
        {

            int pc = JogadaPC();

            ImgJogador = images[jogador];
            ImgPC = images[pc];
            return Resultado.Draw;
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if (mil <= 333 && mil < 667)
            {
                return 1;
            }
            else { return 2;}
        }
    }
}
