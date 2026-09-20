using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GaraDroca.Comum
{
    /// <summary>Estilo de botão. Defina via botao.Tag = "primario" (ou pelo helper).</summary>
    public enum EstiloBotao { Primario, Neutro, Alterar, Excluir, Pesquisar }

    public static class Tema
    {
        // ---------- PALETA (única fonte de verdade) ----------
        public static Color Fundo = Color.FromArgb(214, 220, 230); // era 232,236,243
        public static Color Superficie = Color.White;
        public static Color Borda = Color.FromArgb(222, 228, 236);
        public static Color Texto = Color.FromArgb(51, 65, 85);
        public static Color TextoSuave = Color.FromArgb(100, 116, 139);
        public static Color Primaria = Color.FromArgb(23, 42, 88);   // azul do logo
        public static Color PrimariaHover = Color.FromArgb(34, 60, 120);
        public static Color Sucesso = Color.FromArgb(22, 138, 92);
        public static Color Aviso = Color.FromArgb(217, 119, 6);
        public static Color Perigo = Color.FromArgb(200, 51, 51);
        public static Color Neutro = Color.FromArgb(233, 237, 243);
        public static readonly Color Ambar = Color.FromArgb(217, 119, 6);
        public static readonly Color Vermelho = Color.FromArgb(220, 38, 38);
        public static readonly Color Cinza = Color.FromArgb(100, 116, 139);

        // ---------- TIPOGRAFIA ----------
        public static Font FonteBase = new Font("Segoe UI", 12);
        public static Font FonteRotulo = new Font("Segoe UI", 12, FontStyle.Regular);
        public static Font FonteTitulo = new Font("Segoe UI Semibold", 13);
        public static Font FonteBotao = new Font("Segoe UI Semibold", 12);

        public const int Raio = 8;      // cantos arredondados
        public const int AlturaCampo = 32;
        public const int AlturaBotao = 38;

        // ---------- PONTO DE ENTRADA ----------
        public static void Aplicar(Form form)
        {
            form.Icon = new Icon("garadroca.ico");
            form.AutoScaleMode = AutoScaleMode.None; // <- impede que trocar a fonte redimensione o form
            form.BackColor = Fundo;
            form.Font = FonteBase;
            form.ForeColor = Texto;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            AplicarEmFilhos(form);
        }

        private static void AplicarEmFilhos(Control pai)
        {
            foreach (Control c in pai.Controls)
            {
                switch (c)
                {
                    case MenuStrip ms: EstilizarMenuStrip(ms); break;
                    case GroupBox gb: EstilizarGroupBox(gb); break;
                    case Button b: EstilizarBotao(b, LerEstilo(b)); break;
                    case DataGridView g: EstilizarGrid(g); break;
                    case ComboBox cb: EstilizarCombo(cb); break;
                    case MaskedTextBox mtb: EstilizarCampo(mtb); break;
                    case TextBox tb: EstilizarCampo(tb); break;
                    case DateTimePicker dtp: EstilizarData(dtp); break;
                    case CheckBox ck:
                        ck.Font = FonteBase; ck.ForeColor = Texto;
                        ck.FlatStyle = FlatStyle.Flat; break;
                    case Label lb:
                        lb.Font = FonteRotulo; lb.ForeColor = TextoSuave;
                        lb.AutoSize = true; break;
                    case Panel p: p.BackColor = Superficie; break;
                }
                if (c.HasChildren) AplicarEmFilhos(c);
            }
        }

        // ---------- GROUPBOX: card branco, borda fina, título destacado ----------
        public static void EstilizarGroupBox(GroupBox gb)
        {
            gb.BackColor = Superficie;
            gb.ForeColor = Texto;
            gb.Font = FonteTitulo;
            gb.Padding = new Padding(14, 10, 14, 14);
            gb.Paint -= PintarGroupBox;
            gb.Paint += PintarGroupBox;
            Arredondar(gb, Raio);
        }

        private static void PintarGroupBox(object sender, PaintEventArgs e)
        {
            var gb = (GroupBox)sender;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(gb.Parent?.BackColor ?? Fundo);

            var corpo = new Rectangle(0, 0, gb.Width - 1, gb.Height - 1);
            using (var caminho = CaminhoArredondado(corpo, Raio))
            using (var fundo = new SolidBrush(Superficie))
            using (var caneta = new Pen(Borda))
            {
                g.FillPath(fundo, caminho);
                g.DrawPath(caneta, caminho);
            }

            var tam = TextRenderer.MeasureText(gb.Text, FonteTitulo);
            TextRenderer.DrawText(g, gb.Text, FonteTitulo,
                new Point(14, 8), Primaria, Superficie);
            // linha divisória sob o título
            using (var caneta = new Pen(Borda))
                g.DrawLine(caneta, 14, 8 + tam.Height + 6, gb.Width - 15, 8 + tam.Height + 6);
        }

        // ---------- CAMPOS ----------
        public static void EstilizarCampo(TextBoxBase tb)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Superficie;
            tb.ForeColor = Texto;
            tb.Font = FonteBase;

            bool esticaVertical = tb.Multiline || (tb.Anchor & AnchorStyles.Bottom) == AnchorStyles.Bottom;
            if (!esticaVertical)
            {
                tb.AutoSize = false;

                int alturaPreferida = tb is TextBox caixaTexto
                    ? caixaTexto.PreferredHeight
                    : TextRenderer.MeasureText("Wg", tb.Font).Height + 8; // MaskedTextBox não tem PreferredHeight

                tb.Height = alturaPreferida;
            }

            tb.Enter -= AoFocar; tb.Enter += AoFocar;
            tb.Leave -= AoDesfocar; tb.Leave += AoDesfocar;
        }

        private static void AoFocar(object s, EventArgs e)
            => ((Control)s).BackColor = Color.FromArgb(240, 245, 255);
        private static void AoDesfocar(object s, EventArgs e)
            => ((Control)s).BackColor = Superficie;

        public static void EstilizarCombo(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.BackColor = Superficie;
            cb.ForeColor = Texto;
            cb.Font = FonteBase;
            cb.Height = AlturaCampo;
        }

        public static void EstilizarData(DateTimePicker dtp)
        {
            dtp.Font = FonteBase;
            dtp.CalendarMonthBackground = Superficie;
            dtp.CalendarTitleBackColor = Primaria;
            dtp.Height = AlturaCampo;
        }

        // ---------- Botões ----------
        private static EstiloBotao LerEstilo(Button b)
        {
            var tag = (b.Tag as string ?? "").Trim().ToLowerInvariant();
            switch (tag)
            {
                case "sucesso": return EstiloBotao.Primario;
                case "aviso": return EstiloBotao.Alterar;
                case "perigo": return EstiloBotao.Excluir;
                case "neutro": return EstiloBotao.Neutro;
            }

            // sem Tag definida -> tenta adivinhar pelo nome/texto do botão
            var chave = (b.Name + " " + b.Text).ToLowerInvariant();
            if (chave.Contains("cadastr")) return EstiloBotao.Primario;
            if (chave.Contains("cancel")) return EstiloBotao.Neutro;
            if (chave.Contains("alter")) return EstiloBotao.Alterar;
            if (chave.Contains("exclu")) return EstiloBotao.Excluir;
            if (chave.Contains("pesquis") || chave.Contains("acess")) return EstiloBotao.Pesquisar;

            return EstiloBotao.Primario;
        }

        private static readonly Dictionary<Button, Color> _corOriginalBotao = new Dictionary<Button, Color>();

        public static void EstilizarBotao(Button b, EstiloBotao estilo)
        {
            Color cor;
            switch (estilo)
            {
                case EstiloBotao.Primario: cor = Sucesso; break;
                case EstiloBotao.Alterar: cor = Ambar; break;
                case EstiloBotao.Excluir: cor = Vermelho; break;
                case EstiloBotao.Neutro: cor = Cinza; break;
                case EstiloBotao.Pesquisar: cor = Primaria; break;
                default: cor = Primaria; break;
            }

            bool principal = estilo == EstiloBotao.Primario || estilo == EstiloBotao.Pesquisar;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = principal ? 0 : 1;
            b.FlatAppearance.BorderColor = cor;
            b.BackColor = principal ? cor : Superficie;
            b.ForeColor = principal ? Color.White : cor;
            b.Font = FonteBotao;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
            if (b.Height < 34) b.Height = 34;

            if (principal)
            {
                b.FlatAppearance.MouseOverBackColor = Escurecer(cor, 0.10);
                b.FlatAppearance.MouseDownBackColor = Escurecer(cor, 0.20);
            }
            else
            {
                _corOriginalBotao[b] = cor;
                b.MouseEnter -= Botao_MouseEnter; b.MouseEnter += Botao_MouseEnter;
                b.MouseLeave -= Botao_MouseLeave; b.MouseLeave += Botao_MouseLeave;
            }
        }

        private static void Botao_MouseEnter(object s, EventArgs e)
        {
            var b = (Button)s;
            if (!_corOriginalBotao.TryGetValue(b, out var cor)) return;
            b.BackColor = cor;
            b.ForeColor = Color.White;
        }

        private static void Botao_MouseLeave(object s, EventArgs e)
        {
            var b = (Button)s;
            if (!_corOriginalBotao.TryGetValue(b, out var cor)) return;
            b.BackColor = Superficie;
            b.ForeColor = cor;
        }

        // ---------- DATAGRIDVIEW ----------
        public static void EstilizarGrid(DataGridView g)
        {
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Superficie;
            g.GridColor = Borda;
            g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToResizeRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.Dock = DockStyle.Fill;

            g.ColumnHeadersDefaultCellStyle.BackColor = Primaria;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = FonteBotao;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primaria;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 38;

            g.DefaultCellStyle.BackColor = Superficie;
            g.DefaultCellStyle.ForeColor = Texto;
            g.DefaultCellStyle.Font = FonteBase;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 234, 248);
            g.DefaultCellStyle.SelectionForeColor = Primaria;
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 252);
            g.RowTemplate.Height = 32;
        }

        // ---------- UTILITÁRIOS ----------
        public static void Arredondar(Control c, int raio)
        {
            void Aplica(object s, EventArgs e)
            {
                var ctrl = (Control)s;
                if (ctrl.Width <= 0 || ctrl.Height <= 0) return;
                using (var p = CaminhoArredondado(new Rectangle(0, 0, ctrl.Width, ctrl.Height), raio))
                    ctrl.Region = new Region(p);
            }
            c.Resize -= Aplica; c.Resize += Aplica;
            Aplica(c, EventArgs.Empty);
        }

        public static GraphicsPath CaminhoArredondado(Rectangle r, int raio)
        {
            int d = raio * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static Color Clarear(Color c, double fator)
        {
            int Ajusta(int v) => Math.Max(0, Math.Min(255, (int)(v + 255 * fator)));
            return Color.FromArgb(Ajusta(c.R), Ajusta(c.G), Ajusta(c.B));
        }

        private static Color Escurecer(Color c, double fator) =>
            Color.FromArgb(
                (int)(c.R * (1 - fator)),
                (int)(c.G * (1 - fator)),
                (int)(c.B * (1 - fator)));

        public static void EstilizarMenuStrip(MenuStrip ms)
        {
            ms.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            ms.BackColor = Primaria;
            ms.ForeColor = Color.White;
            ms.Font = FonteBase;
            ms.Padding = new Padding(10, 6, 0, 6);

            foreach (ToolStripItem item in ms.Items)
                EstilizarItemMenuTopo(item);
        }

        private static void EstilizarItemMenuTopo(ToolStripItem item)
        {
            item.ForeColor = Color.White;
            item.Font = FonteBase;
            item.Padding = new Padding(12, 10, 12, 10); // <- dá o respiro entre Cadastros/Vendedor/Veículo/etc.

            if (item is ToolStripMenuItem tsmi)
                foreach (ToolStripItem sub in tsmi.DropDownItems)
                    EstilizarItemSubmenu(sub);
        }

        private static void EstilizarItemSubmenu(ToolStripItem item)
        {
            item.ForeColor = Texto;
            item.Font = FonteBase;

            if (item is ToolStripMenuItem tsmi)
                foreach (ToolStripItem sub in tsmi.DropDownItems)
                    EstilizarItemSubmenu(sub);
        }

        private class MenuColorTable : ProfessionalColorTable
        {
            public override Color MenuStripGradientBegin => Primaria;
            public override Color MenuStripGradientEnd => Primaria;
            public override Color MenuBorder => Primaria;
            public override Color MenuItemBorder => Clarear(Primaria, 0.20);
            public override Color MenuItemSelected => Clarear(Primaria, 0.15);
            public override Color MenuItemSelectedGradientBegin => Clarear(Primaria, 0.15);
            public override Color MenuItemSelectedGradientEnd => Clarear(Primaria, 0.15);
            public override Color MenuItemPressedGradientBegin => Escurecer(Primaria, 0.15);
            public override Color MenuItemPressedGradientEnd => Escurecer(Primaria, 0.15);
            public override Color ToolStripDropDownBackground => Superficie;
            public override Color ImageMarginGradientBegin => Superficie;
            public override Color ImageMarginGradientMiddle => Superficie;
            public override Color ImageMarginGradientEnd => Superficie;
            public override Color SeparatorDark => Borda;
            public override Color SeparatorLight => Superficie;
        }
    }
}
