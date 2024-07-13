using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace asinc
{
    public class CharGeneratorClass
    {
        Form form;
        Button startButton;
        Label winConsole;

        Label letter;
        Point letterLocation;
        Button letterPlus;
        Button letterMinus;

        Label digit;
        Point digitLocation;
        Button digitPlus;
        Button digitMinus;

        Label symbol;
        Point symbolLocation;
        Button symbolPlus;
        Button symbolMinus;

        Size buttonSize;
        Size labelSize;

        Thread letterThread;
        Thread digitThread;
        Thread symbolThread;
        private void InitElements(Form form)
        {

            this.form = form;

            buttonSize = new Size(25, 25);
            labelSize = new Size(50, 20);

            this.startButton = new Button
            {
                Text = "Start",
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(100, 40),
                Location = new Point(form.Width / 2 - 100 / 2, form.Height / 2),
                Visible = true
            };
            startButton.Click += Start_Click;

            int tmp = form.Width / 3 - form.Width / 5;
            letterLocation = new Point(tmp, form.Height / 10);
            digitLocation = new Point(tmp + form.Width / 3, form.Height / 10);
            symbolLocation = new Point(tmp + 2 * form.Width / 3, form.Height / 10);

            letter = new Label
            {
                Location = letterLocation,
                AutoSize = false,
                Size = labelSize,
                Text = "Letters",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };

            digit = new Label
            {
                Location = digitLocation,
                AutoSize = false,
                Size = labelSize,
                Text = "Digits",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };

            symbol = new Label
            {
                Location = symbolLocation,
                AutoSize = false,
                Size = labelSize,
                Text = "Symbols",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };


            letterPlus = new Button
            {
                Text = "+",
                Size = buttonSize,
                Location = new Point(letterLocation.X + letter.Width / 2 + buttonSize.Width, letterLocation.Y + letter.Height + 10),
                Visible = false
            };

            letterMinus = new Button
            {
                Text = "-",
                Size = buttonSize,
                Location = new Point(letterLocation.X + letter.Width / 2 - 2 * buttonSize.Width, letterLocation.Y + letter.Height + 10),
                Visible = false
            };

            digitPlus = new Button
            {
                Text = "+",
                Size = buttonSize,
                Location = new Point(digitLocation.X + digit.Width / 2 + buttonSize.Width, digitLocation.Y + digit.Height + 10),
                Visible = false
            };
            digitMinus = new Button
            {
                Text = "-",
                Size = buttonSize,
                Location = new Point(digitLocation.X + digit.Width / 2 - 2 * buttonSize.Width, digitLocation.Y + digit.Height + 10),
                Visible = false
            };
            symbolPlus = new Button
            {
                Text = "+",
                Size = buttonSize,
                Location = new Point(symbolLocation.X + symbol.Width / 2 + buttonSize.Width, symbolLocation.Y + symbol.Height + 10),
                Visible = false
            };
            symbolMinus = new Button
            {
                Text = "-",
                Size = buttonSize,
                Location = new Point(symbolLocation.X + symbol.Width / 2 - 2 * buttonSize.Width, symbolLocation.Y + symbol.Height + 10),
                Visible = false
            };

            winConsole = new Label();
            winConsole.AutoSize = false;
            winConsole.Size = new Size(form.Width - 50, form.Height /2+50);
            winConsole.Visible = false;
            winConsole.BackColor = Color.Gray;
            winConsole.Location = new Point(15, form.Height - winConsole.Height - 50);

            letterPlus.Click += Plus;

            form.Controls.Add(startButton);
            form.Controls.Add(letter);
            form.Controls.Add(digit);
            form.Controls.Add(symbol);
            form.Controls.Add(letterPlus);
            form.Controls.Add(letterMinus);
            form.Controls.Add(symbolPlus);
            form.Controls.Add(symbolMinus);
            form.Controls.Add(digitPlus);
            form.Controls.Add(digitMinus);
            form.Controls.Add(winConsole);




        }
        private void LetterFunc()
        {

        }
        private void StartThreads()
        {
           
        }

        private void setPriority(Thread thread, bool plus)
        {
            int priorityRate = (int)thread.Priority;
            if (plus)
            {
                if (priorityRate != 4)
                {
                    thread.Priority = (ThreadPriority)(priorityRate+1);
                }
                return;
            }
            if (priorityRate != 0)
            {
                thread.Priority = ((ThreadPriority)(priorityRate - 1));
            }
        }

        private void Plus(object sender, System.EventArgs e)
        {
            if(sender == letterPlus)
            {
                setPriority(letterThread, true);
            }
            else if(sender == symbolPlus)
            {
                setPriority(symbolThread, true);
            }
            else if(sender == digitPlus)
            {
                setPriority(digitThread, true);
            }
        }

        private void Minus(object sender, System.EventArgs e)
        {
            if (sender == letterPlus)
            {
                setPriority(letterThread, false);
            }
            else if (sender == symbolPlus)
            {
                setPriority(symbolThread, false);
            }
            else if (sender == digitPlus)
            {
                setPriority(digitThread, false);
            }
        }
        private void Start_Click(object sender, System.EventArgs e)
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = true;
            }
            startButton.Visible = false;

        }

        public CharGeneratorClass(Form form)
        {
            InitElements(form);

        }

    }
}
