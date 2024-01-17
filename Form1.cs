using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fufrus_Simulator
{
	public partial class Form1 : Form
	{
		private int Dinheiro;
		private List<Task> tasks = new List<Task>();
		
		public Form1()
		{
			InitializeComponent();
			
		}

		private void AtualizarPontuacao()
		{
			txtMoney.Text = $"$: {Dinheiro}";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	
		private async Task UpdateStatusBarAsync(Button btn, ProgressBar progressBar) 
		{
			progressBar.Maximum = 100; // Defina o valor máximo da barra de progresso
			progressBar.Step = 1;      // Defina o incremento da barra de progresso
			btn.Enabled = false;
			for (int i = 0; i <= 100; i++)
			{

				progressBar.PerformStep(); // Atualiza a barra de progresso

				// Aguarde um pequeno intervalo para simular o carregamento
				Thread.Sleep(50);

				// Atualize a interface gráfica
				Application.DoEvents();

			}
			Dinheiro += 10;
			AtualizarPontuacao();
			btn.Enabled = true;
			progressBar.Value = 0;

		}

		private async void btn1_Click_1(object sender, EventArgs e)
		{
			await HandleTaskAsync(() => UpdateStatusBarAsync(btn1, progressBar1));
		}

		private async void btn2_Click(object sender, EventArgs e)
		{
			await HandleTaskAsync(() => UpdateStatusBarAsync(btn2, progressBar2));
		}

		private async void btn3_Click(object sender, EventArgs e)
		{
			await Task.Run(() => UpdateStatusBarAsync(btn1, progressBar1));
			await Task.Run(() => UpdateStatusBarAsync(btn2, progressBar2));
		}

		private async Task HandleTaskAsync(Action action)
		{
			var task = Task.Run(() =>
			{
				if (InvokeRequired)
				{
					Invoke(action);
				}
				else
				{
					action();
				}
			});

			tasks.Add(task);
			await task;
		}


	}
}

