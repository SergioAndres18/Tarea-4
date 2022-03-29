namespace Introduccion;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;

    private Label? lblA;
    private TextBox? txtA;
    private Label? lblB;
    private TextBox? txtB;
    private Label? lblC;
    private TextBox? txtC;

       public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Triángulo");
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(60,75);
        txtAltura.Visible=false;

        //Etiqueta Resulatdo
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Resultado
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(85,275);

        //---------------------------------------------------------------------------------
        //Etiquetas del Perimetro del Triangulo y Rectangulo
        lblA = new Label();
        lblA.Text = "Lado a";
        lblA.AutoSize = true;
        lblA.Location = new Point(10, 80);
        lblA.Visible = false;

        lblB = new Label();
        lblB.Text = "Lado b";
        lblB.AutoSize = true;
        lblB.Location = new Point(10, 110);
        lblB.Visible = false;

        lblC = new Label();
        lblC.Text = "Lado c";
        lblC.AutoSize = true;
        lblC.Location = new Point(10, 140);
        lblC.Visible = false;

        //TextBox del Perimetro del Triangulo y Rectangulo
        txtA = new TextBox();
        txtA.Size = new Size(100, 20);
        txtA.Location = new Point(65, 75);
        txtA.Visible = false;

        txtB = new TextBox();
        txtB.Size = new Size(100, 20);
        txtB.Location = new Point(65, 105);
        txtB.Visible = false;

        txtC = new TextBox();
        txtC.Size = new Size(100, 20);
        txtC.Location = new Point(65, 135);
        txtC.Visible = false;
        //---------------------------------------------------------------------------------


        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);

        this.Controls.Add(lblA);
        this.Controls.Add(txtA);
        this.Controls.Add(lblB);
        this.Controls.Add(txtB);
        this.Controls.Add(lblC);
        this.Controls.Add(txtC);


    }
    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado")                 //CUADRADO
            {
                txtA.Visible = false;
                lblA.Visible = false;
                txtB.Visible = false;
                lblB.Visible = false;
                txtC.Visible = false;
                lblC.Visible = false;

                if (cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible = true;
                    lblAltura.Visible = true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible = true;
                    lblAltura.Visible = true;
                }
            }

            if (cmbFiguras.SelectedItem.ToString() == "Triángulo")            //TRIANGULO
            {
                txtAltura.Visible = false;
                lblAltura.Visible = false;

                if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                {
                    txtA.Visible = true;
                    lblA.Visible = true;

                    txtB.Visible = true;
                    lblB.Visible = true;

                    txtC.Visible = true;
                    lblC.Visible = true;
                }
                if (cmbCalculos.SelectedItem.ToString() == "Área")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;

                    txtAltura.Visible = true;
                    lblAltura.Visible = true;

                    txtB.Visible = true;
                    lblB.Visible = true;
                }
            }

            if (cmbFiguras.SelectedItem.ToString() == "Rectángulo")            //RECTANGULO
            {
                txtAltura.Visible = false;
                lblAltura.Visible = false;
                txtC.Visible = false;
                lblC.Visible = false;

                if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                {
                    txtA.Visible = true;
                    lblA.Visible = true;

                    txtB.Visible = true;
                    lblB.Visible = true;
                }
                if (cmbCalculos.SelectedItem.ToString() == "Área")
                {
                    txtA.Visible = true;
                    lblA.Visible = true;

                    txtB.Visible = true;
                    lblB.Visible = true;
                }
            }
        }
        else
        {
            txtAltura.Visible = false;
            lblAltura.Visible = false;

            txtA.Visible = false;
            lblA.Visible = false;

            txtB.Visible = false;
            lblB.Visible = false;

            txtC.Visible = false;
            lblC.Visible = false;
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculos.SelectedItem.ToString();
        string figura = cmbFiguras.SelectedItem.ToString();

        if (figura == "Cuadrado")
        {
            if (txtAltura.Text != "")
            {
                if (calculo == "Périmetro")
                {
                    int altura = Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text = (altura * 4).ToString();
                }
                if (calculo == "Área")
                {
                    int altura = Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text = (altura * altura).ToString();
                }
            }
        }
        if (figura == "Triángulo")
        {
            if (calculo == "Périmetro" && txtA.Text != "" && txtB.Text != "" && txtC.Text != "")
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                int c = Convert.ToInt32(txtC.Text);
                txtResultado.Text = (a + b + c).ToString();
            }
            if (calculo == "Área" && txtAltura.Text != "" && txtB.Text != "")
            {
                int altura = Convert.ToInt32(txtAltura.Text);
                int b = Convert.ToInt32(txtB.Text);
                txtResultado.Text = ((altura * b) / 2).ToString("N2");
            }
        }
        if (figura == "Rectángulo")
        {
            if (txtA.Text != "" && txtB.Text != "")
            {
                if (calculo == "Périmetro")
                {
                    int a = Convert.ToInt32(txtA.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    txtResultado.Text = ((a + b) * 2).ToString();
                }
                if (calculo == "Área")
                {
                    int a = Convert.ToInt32(txtA.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    txtResultado.Text = (a * b).ToString();
                }
            }
        }
    }
}
