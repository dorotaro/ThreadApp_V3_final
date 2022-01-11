using Domain.Services;
using SharedModels.WriteModels;

namespace ThreadApp
{
	public partial class Form1 : Form
	{
		private int _tableRows = 0;
		private readonly IThreadService _threadService;
		private bool _threadWoringState = true;
		private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		public Form1(IThreadService threadService)
		{
			_threadService = threadService;
			InitializeComponent();
			AddExistingThreads();

		}

		private async Task<int?> AddThreadToTable(int? taskID)
		{
			var randomString = GenerateRandomString();
			var date = DateTime.Now.ToString();
			_tableRows++;
			var item = new ListViewItem(_tableRows.ToString());
			item.SubItems.Add(randomString);
			item.SubItems.Add(date);
			item.SubItems.Add(taskID.ToString());

			var thread = new ThreadWriteModel()
			{
				ThreadID = taskID.ToString(),
				Data = randomString,
				Time = DateTime.Now,

			};

			await _threadService.AddThread(thread);

			if (listView1.Items.Count == 20)
			{
				
				listView1.Invoke((MethodInvoker)(() => listView1.Items.RemoveAt(0)));
			}

			listView1.Invoke((MethodInvoker)(() => listView1.Items.Add(item)));

			return taskID;
		}

		private static string GenerateRandomString()
		{
			
			var random = new Random();

			var randomLength = random.Next(5, 10);

			var totalAmountOfChars = new char[randomLength];

			for (int i = 0; i < totalAmountOfChars.Length; i++)
			{
				totalAmountOfChars[i] = chars[random.Next(chars.Length)];
			}

			return new string(totalAmountOfChars);
		}

		private void Stop_threading_button(object sender, EventArgs e)
		{
			button2.Enabled = false;
			_threadWoringState = false;
			button1.Enabled = true;
		}

		private void Start_threading_button(object sender, EventArgs e)
		{
			button1.Enabled = false;
			button2.Enabled = true;
			_threadWoringState = true;

			for (var i = 0; i < (int)numericUpDown1.Value; i++)
				{
					var thread = new Thread(async () =>
					{
						var threadId = Thread.CurrentThread.ManagedThreadId;
						while (_threadWoringState)
						{
							await AddThreadToTable(threadId);
							var randomTime = new Random();
							Thread.Sleep(randomTime.Next(500, 5000));
						}
						return;
					});

					thread.Start();
				}
		}
		
		private async Task AddExistingThreads()
		{
			var threads = await _threadService.GetThreads();
			if (threads != null)
			{
				foreach (var thread in threads)
				{
					_tableRows++;
					var item = new ListViewItem(_tableRows.ToString());
					item.SubItems.Add(thread.Data);
					item.SubItems.Add(thread.Time.ToString());
					item.SubItems.Add(thread.ThreadID); listView1.Items.Add(item);
				}
			}
		}
	}
}
