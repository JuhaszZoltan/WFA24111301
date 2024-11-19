using System.Text;

namespace WFA24111301;

public partial class FrmAkasztofa : Form
{
    private const string RIDDLES_FILE_LOCATION = "D:\\PROJECTS\\WFA24111301\\Resources\\feladvanyok.txt";
    private const string GALLOWS_SPRITE_FOLDER = "D:\\PROJECTS\\WFA24111301\\Resources\\";

    private Riddle riddle;

    public FrmAkasztofa()
    {
        InitializeComponent();
        this.Load += FrmAkasztofa_Load;
        btnTipp.Click += BtnTipp_Click;
        txbTip.TextChanged += TxbTipp_TextChanged;
    }

    private void TxbTipp_TextChanged(object? sender, EventArgs e)
    {
        if (txbTip.Text.Length > 0)
        txbTip.Text = $"{txbTip.Text[0]}".ToUpper();
    }

    private void BtnTipp_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txbTip.Text)) return;

        if (riddle.Check(char.Parse(txbTip.Text)))
            lblPuzzle.Text = string.Join(' ', riddle.Puzzle);

        else pbAkasztofa.Image = Image.FromFile(
            $"{GALLOWS_SPRITE_FOLDER}" +
            $"akasztofa_{riddle.WrongTips.Count:00}.png");

        lblTips.Text = string.Join(", ", riddle.AllTips);
    }

    private void FrmAkasztofa_Load(object? sender, EventArgs e)
    {
        riddle = GetRandomRiddle();
        SetUI();
    }

    private void SetUI()
    {
        lblHint.Text = riddle.Hint;
        lblPuzzle.Text = string.Join(' ', riddle.Puzzle);
        lblTips.Text = string.Empty;
    }

    private Riddle GetRandomRiddle()
    {
        List<Riddle> riddles = [];
        using StreamReader sr = new(RIDDLES_FILE_LOCATION, Encoding.UTF8);
        while (!sr.EndOfStream) riddles.Add(new(sr.ReadLine()));
        return riddles[Random.Shared.Next(riddles.Count)];
    }
}
