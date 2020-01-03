using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;

namespace wf_demoCustomVision
{
    public partial class Form1 : Form
    {
        string apikey_ = "0d20eeaca56e46508069e489f6d00394";
        string proyectID_s = "ff1b5502-18ba-467f-97df-7df97a509d8a";
        string endpoint = "https://southcentralus.api.cognitive.microsoft.com/";
            public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (exploradorArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbxImagen.ImageLocation = exploradorArchivos.FileName;
            }
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            var imagenStream = File.OpenRead(pbxImagen.ImageLocation);

            CustomVisionPredictionClient predictor = new CustomVisionPredictionClient
                { ApiKey = apikey_, Endpoint = endpoint };

            var proyID = Guid.Parse(proyectID_s);
            var results = predictor.ClassifyImage(proyID, "Iteration1", imagenStream);
            string str_restults = "";
            foreach (var c in results.Predictions)
            {
                str_restults = str_restults + ($"\t{c.TagName}: {c.Probability:P1}") + "\n";
            }
            txtResultado.Text = str_restults;
        }
    }
}
