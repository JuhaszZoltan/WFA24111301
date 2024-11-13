using System.Text;
using WFA24111301.Properties;

namespace WFA24111301;

public partial class FrmAkasztofa : Form
{
    private string feladvany;
    private string rejtveny;
    private List<char> talalatok = [];
    private int rosszTipp = 0;


    public FrmAkasztofa()
    {
        InitializeComponent();
        this.Load += FrmAkasztofa_Load;
        btnTipp.Click += BtnTipp_Click;
        txbTipp.TextChanged += TxbTipp_TextChanged;
    }

    private void TxbTipp_TextChanged(object? sender, EventArgs e)
    {
        txbTipp.Text = $"{txbTipp.Text[0]}";
    }

    private void BtnTipp_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txbTipp.Text)) return;

        char tipp = char.Parse(txbTipp.Text.ToUpper());

        if (feladvany.Contains(tipp))
        {
            talalatok.Add(tipp);

            rejtveny = string.Empty;
            foreach (var c in feladvany)
            {
                if (c == ' ') rejtveny += "  ";
                else if (talalatok.Contains(c))
                    rejtveny += $"{c} ";
                else rejtveny += "_ ";
            }

            lblFeladvany.Text = rejtveny;
        }
        else
        {
            rosszTipp++;
            pbAkasztofa.Image = Image.FromFile(
                $"E:\\PROJECTS\\WFA24111301\\Resources\\akasztofa_{rosszTipp:00}.png");
        }

    }

    private void FrmAkasztofa_Load(object? sender, EventArgs e)
    {
        List<string> feladvanyok = [];

        using StreamReader sr = new("E:\\PROJECTS\\WFA24111301\\Resources\\feladvanyok.txt", Encoding.UTF8);

        while (!sr.EndOfStream) feladvanyok.Add(sr.ReadLine());

        feladvany = feladvanyok[Random.Shared.Next(feladvanyok.Count)].ToUpper();

        rejtveny = "";
        foreach (var c in feladvany)
        {
            if (c == ' ') rejtveny += "  ";
            else rejtveny += "_ ";
        }

        lblFeladvany.Text = rejtveny;

        lblTippek.Text = "";
    }
}
