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
	
	        // Restart
	
			void Button2Click(object sender, EventArgs e)
			{				Application.Restart();
			}
			
			void TeclaClick(object sender, EventArgs e)
			{
				  Button tecla = (Button)sender; // pega o botão clicado
	    		   char letra = tecla.Text[0];    // pega a letra do botão
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
	
	    // muda cor do botão
	    if (acertou)
	    {
	        tecla.BackColor = Color.Green;
	    }
	    else
	    {
	        tecla.BackColor = Color.Red;
	        cont++;
	        switch (cont)
	        {
	            case 1: pictureBox1.Load("1.png"); break;
	            case 2: pictureBox1.Load("2.png"); break;
	            case 3: pictureBox1.Load("3.png"); break;
	            case 4: pictureBox1.Load("4.png"); break;
	            case 5: pictureBox1.Load("5.png"); break;
	            case 6: pictureBox1.Load("6.png"); break;
	            case 7: 
	                pictureBox1.Load("7.png"); 
	                MessageBox.Show("Você perdeu, caia na real !!!"); 
	                label1.Visible = false; 
	                panel1.Visible = false;
	                break;
	        }
	    }
	
	    // checa vitória
	    if (label1.Text == palavra)
	    {
	        MessageBox.Show("Você ganhou, parabéns !!!!");
	        panel1.Visible = false;
	    }
	
	    // desabilita o botão pra não clicar de novo
	    	tecla.Enabled = false;
	}
			}
	    }
