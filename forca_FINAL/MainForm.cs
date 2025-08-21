/*
 * Criado por SharpDevelop.
 * Usuário: Vinicius Almeida
 * Data: 20/08/2025
 * Hora: 08:58
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace forca_FINAL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string palavra;
        string aux = "";
        int cont = 0;

        void Button1Click(object sender, EventArgs e)
        {
            palavra = textBox1.Text;
            button1.Visible = false;
            textBox1.Visible = false;
            label1.Visible = true;
            aux = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                aux += "?";
            }
            label1.Text = aux;
        }

        // ======================= Letras =======================

        void AClick(object sender, EventArgs e)
        {
            char letra = 'A';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) A.BackColor = Color.Green;
            else
            {
                A.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;


                }
            }
        }

        void BClick(object sender, EventArgs e)
        {
            char letra = 'B';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) B.BackColor = Color.Green;
            else
            {
                B.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

                }
            }
        }

        void CClick(object sender, EventArgs e)
        {
            char letra = 'C';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) C.BackColor = Color.Green;
            else
            {
                C.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

                }
            }
        }

        void DClick(object sender, EventArgs e)
        {
            char letra = 'D';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) D.BackColor = Color.Green;
            else
            {
                D.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

                }
            }
        }

        void EClick(object sender, EventArgs e)
        {
            char letra = 'E';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) E.BackColor = Color.Green;
            else
            {
                E.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

                }
            }
        }

        void FClick(object sender, EventArgs e)
        {
            char letra = 'F';
            bool acertou = false;
            char[] exibir = label1.Text.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    exibir[i] = letra;
                    acertou = true;
                }
            }
            label1.Text = new string(exibir);
            if (acertou) F.BackColor = Color.Green;
            else
            {
                F.BackColor = Color.Red;
                cont++;
                switch (cont)
                {
                    case 1: pictureBox1.Load("1.png"); break;
                    case 2: pictureBox1.Load("2.png"); break;
                    case 3: pictureBox1.Load("3.png"); break;
                    case 4: pictureBox1.Load("4.png"); break;
                    case 5: pictureBox1.Load("5.png"); break;
                    case 6: pictureBox1.Load("6.png"); break;
                     case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

                }
            }
        }
        void GClick(object sender, EventArgs e)
{
    char letra = 'G';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        G.BackColor = Color.Green;
    }
    else
    {
        G.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void HClick(object sender, EventArgs e)
{
    char letra = 'H';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        H.BackColor = Color.Green;
    }
    else
    {
        H.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void IClick(object sender, EventArgs e)
{
    char letra = 'I';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        I.BackColor = Color.Green;
    }
    else
    {
        I.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void JClick(object sender, EventArgs e)
{
    char letra = 'J';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        J.BackColor = Color.Green;
    }
    else
    {
        J.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void KClick(object sender, EventArgs e)
{
    char letra = 'K';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        K.BackColor = Color.Green;
    }
    else
    {
        K.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void LClick(object sender, EventArgs e)
{
    char letra = 'L';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        L.BackColor = Color.Green;
    }
    else
    {
        L.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}
		void MClick(object sender, EventArgs e)
{
    char letra = 'M';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        M.BackColor = Color.Green;
    }
    else
    {
        M.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void NClick(object sender, EventArgs e)
{
    char letra = 'N';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        N.BackColor = Color.Green;
    }
    else
    {
        N.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void OClick(object sender, EventArgs e)
{
    char letra = 'O';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        O.BackColor = Color.Green;
    }
    else
    {
        O.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void PClick(object sender, EventArgs e)
{
    char letra = 'P';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        P.BackColor = Color.Green;
    }
    else
    {
        P.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void QClick(object sender, EventArgs e)
{
    char letra = 'Q';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        Q.BackColor = Color.Green;
    }
    else
    {
        Q.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void RClick(object sender, EventArgs e)
{
    char letra = 'R';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        R.BackColor = Color.Green;
    }
    else
    {
        R.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void SClick(object sender, EventArgs e)
{
    char letra = 'S';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        S.BackColor = Color.Green;
    }
    else
    {
        S.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void TClick(object sender, EventArgs e)
{
    char letra = 'T';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        T.BackColor = Color.Green;
    }
    else
    {
        T.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void UClick(object sender, EventArgs e)
{
    char letra = 'U';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        U.BackColor = Color.Green;
    }
    else
    {
        U.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void VClick(object sender, EventArgs e)
{
    char letra = 'V';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        V.BackColor = Color.Green;
    }
    else
    {
        V.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void WClick(object sender, EventArgs e)
{
    char letra = 'W';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        W.BackColor = Color.Green;
    }
    else
    {
        W.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void XClick(object sender, EventArgs e)
{
    char letra = 'X';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        X.BackColor = Color.Green;
    }
    else
    {
        X.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void YClick(object sender, EventArgs e)
{
    char letra = 'Y';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        Y.BackColor = Color.Green;
    }
    else
    {
        Y.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void ZClick(object sender, EventArgs e)
{
    char letra = 'Z';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        Z.BackColor = Color.Green;
    }
    else
    {
        Z.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
             case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}

void ÇClick(object sender, EventArgs e)
{
    char letra = 'Ç';
    bool acertou = false;
    char[] exibir = label1.Text.ToCharArray();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            exibir[i] = letra;
            acertou = true;
        }

        label1.Text = new string(exibir);
    }
    if (acertou)
    {
        Ç.BackColor = Color.Green;
    }
    else
    {
        Ç.BackColor = Color.Red;
        cont++;
        switch (cont)
        {
            case 1: pictureBox1.Load("1.png"); break;
            case 2: pictureBox1.Load("2.png"); break;
            case 3: pictureBox1.Load("3.png"); break;
            case 4: pictureBox1.Load("4.png"); break;
            case 5: pictureBox1.Load("5.png"); break;
            case 6: pictureBox1.Load("6.png"); break;
            case 7: pictureBox1.Load("7.png"); MessageBox.Show("Você perdeu, caia na real !!!"); label1.Visible = false; break;

        }
    }
}
		void Button2Click(object sender, EventArgs e)
		{			Application.Restart();
		}
    }
}