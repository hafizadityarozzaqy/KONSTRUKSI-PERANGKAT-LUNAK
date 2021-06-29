using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_Software_Construction_BEN_ID
{
    class Automata
    {
        // Attribut pada state.
        public enum State { SIGN_UP, LOGIN, PROFILE, ISIBBM, PEMBAYARAN, LOGOUT };
        public static State posisi, nextPosisi;

        public Automata() { }

        // Mensetter keadaan posisi pada automata.
        public static void setPosisi(State pos, State nextPos)
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        // Mengambil data posisi.
        public static State getPosisi()
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            // Jika keadaan pada posisi masuk pada login.
            if (posisi == State.LOGIN)
            {
                if (nextPos == State.PROFILE)
                {
                    Profile profile = new Profile();
                    profile.Show();
                }
            }
            // Kemudian jika tidak masuk posisi profile masuk ke tampilan isibbm.
            else if (posisi == State.PROFILE)
            {
                if (nextPos == State.ISIBBM)
                {
                    isiBBM isibbm = new isiBBM();
                    isibbm.Show();
                }
                // Kemudian jika tidak masuk posisi profile masuk ke tampilan pembayaran.
                else if (nextPos == State.PEMBAYARAN)
                {
                    Pembayaran pembayaran = new Pembayaran();
                    pembayaran.Show();
                }
                // Maka jika tidak posisi profile masuk ke tampilan logout.
                else if (nextPos == State.LOGOUT)
                {
                    DialogResult dialogResult = MessageBox.Show("yakin?", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            // Keadaan jika posisi semua tampilan akan kembali pada tampilan profile.
            else if (State.ISIBBM == posisi || State.PEMBAYARAN == posisi)
            {
                if (nextPos == State.PROFILE)
                {
                    Profile profile = new Profile();
                    profile.Show();
                }
            }
        }
    }
}
