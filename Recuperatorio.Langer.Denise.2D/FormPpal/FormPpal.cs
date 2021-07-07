using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Dispositivo;

namespace FormPpal
{
    public partial class FormPpal : Form
    {
        public FormPpal()
        {
            InitializeComponent();
        }

        private void FormPpal_Load(object sender, EventArgs e)
        {
            List<Aplicacion> listaApps = new List<Aplicacion>()
            {
                new AppJuegos("Super Mario Bros", ESistemaOperativo.ANDROID, 20),
                new AppJuegos("Super Mario Bros", ESistemaOperativo.ANDROID, 20),
                new AppJuegos("Angry Birds", ESistemaOperativo.ANDROID, 100),
                new AppJuegos("League of Legends", ESistemaOperativo.IOS, 500),
                new AppMusical("Spotify", ESistemaOperativo.ANDROID, 50,
                new List<string>()
                {
                "Bohemian Rhapsody - Queen",
                "Billie Jean – Michael Jackson",
                "Another Brick In The Wall – Pink Floyd",
                "Romeo And Juliet – Dire Straits",
                "Where The Streets Have No Name -U2",
                "Let It Be – The Beatles",
                "Could You Be Loved – Bob Marley",
                "Every Breath You Take – The Police",
                "November Rain – Guns n Roses",
                "Crazy Train – Ozzy Osbourne",
                "Volver – Carlos Gardel",
                "En La Ciudad De La Furia – Soda Stereo",
                "Gualicho – Patricio Rey",
                "Paint It Black – Rolling Stones"
                }),
                new AppMusical("Spotify", ESistemaOperativo.ANDROID, 50),
                new AppMusical("YouTube Music", ESistemaOperativo.ANDROID, 30)};

            foreach (Aplicacion app in listaApps)
                if (!Dispositivo.InstalarApp(app))
                    rtbAppNoInstaladas.Text += string.Concat(app.ToString(), "\n");
            this.rtbAppInstaladas.Text = Dispositivo.InformacionDispositivo();
        }
    }
}
