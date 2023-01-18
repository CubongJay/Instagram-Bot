using InstagramApiSharp;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

namespace Instagram_Bot
{
	public partial class Form1 : Form
	{
		private static UserSessionData user;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			user = new UserSessionData();
			user.UserName = txtUsername.Text;
			user.Password = txtPassword.Text;


			apiClass.api = InstaApiBuilder.CreateBuilder()
				.SetUser(user)
				.UseLogger(new DebugLogger(LogLevel.All))
				.SetRequestDelay(RequestDelay.FromSeconds(0, 1))
				.Build();

			var isLog = await apiClass.api.LoginAsync();


			if(isLog.Succeeded)
			{
				MessageBox.Show("LOGIN SUCCESSFUL", "SUCCESFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("USERNAME OR PASSWORD INCORRECT", "SUCCESFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
					

		}

		private async void btnFollowers_Click(object sender, EventArgs e)
		{
			var followers = await apiClass.api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(1));

			foreach(var item in followers.Value)
			{
				gridFollowers.Rows.Add(item.FullName, item.UserName);
			}

		}

		private async void btnFollow_Click(object sender, EventArgs e)
		{
			var user = await  apiClass.api.UserProcessor.GetUserAsync(txtNew.Text);
			var followback =  await apiClass.api.UserProcessor.FollowUserAsync(user.Value.Pk);

			if(followback.Succeeded)
			{
				MessageBox.Show("THIS USER HAS BEEN FOLLOWED BACK SUCCESFULLY", "FOLLOW BACK", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	} 
}