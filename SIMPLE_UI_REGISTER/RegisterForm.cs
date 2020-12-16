using System.Linq;
using System.Windows.Forms;

namespace SIMPLE_UI_REGISTER
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
			RefreshData();
		}

		//----------Beginning of the code!----------

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) )
				{
					System.Windows.Forms.MessageBox.Show("لطفا فیلد های نام و نام خانوادگی و آدرس را\n تکمیل نمایید!",caption:"",buttons: MessageBoxButtons.OK,icon: MessageBoxIcon.Error,defaultButton:  MessageBoxDefaultButton.Button1 , options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
					firstNameTextBox.Focus();
					return;
				}


				dataBaseContext =
					new Models.DataBaseContext();

				Models.User username =
							dataBaseContext.Users
							.Where(current => string.Compare(current.Address, addressTextBox.Text) == 0)
							.FirstOrDefault();

				if (username != null)
				{
					System.Windows.Forms.MessageBox.Show("آدرس مورد نظر در سیستم موجود میباشد!\n لطفا از ادرس دیگری استفاده نمایید.");
					addressTextBox.Clear();
					addressTextBox.Focus();

					return;
				}
				else
				{
					username =
						new Models.User
						{
							First_Name = firstNameTextBox.Text,
							Last_Name = lastNameTextBox.Text,
							Address = addressTextBox.Text,
						};

					dataBaseContext.Users.Add(username);
					dataBaseContext.SaveChanges();

					RefreshData();
				}
				string successMessage =
					$"اطلاعات کاربر {lastNameTextBox.Text} با موفقیت ذخیره گرید!";

				System.Windows.Forms.MessageBox.Show(successMessage);


				ClearData();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion

		#region ClearButton_Click
		private void ClearButton_Click(object sender, System.EventArgs e)
		{
			ClearData();
		}
		#endregion /ClearButton_Click

		#region CancelBtton_Click
		private void CancelBtton_Click(object sender, System.EventArgs e)
		{
			ExitAppliction();
		}
		#endregion /CancelBtton_Click

		//----------End of code!----------

		#region Founction
		//---------------
		#region Clear
		private void ClearData()
		{
			System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show
				(text:"آیا اطلاعات وارد شده حذف گردد؟",
				caption:"حذف اطلاعات",
				buttons: MessageBoxButtons.YesNo,
				icon: MessageBoxIcon.Question,
				defaultButton: MessageBoxDefaultButton.Button2,
				options: MessageBoxOptions.RtlReading);

			if (dialogResult == DialogResult.Yes)
			{
				firstNameTextBox.Clear();
				firstNameTextBox.Focus();

				lastNameTextBox.Clear();
				addressTextBox.Clear();
			}

		}
		#endregion Clear

		#region ExitAppliction
		private void ExitAppliction()
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show
				(text: "از برنامه خارج می شوید؟؟",
				caption: "خروج",
				buttons: MessageBoxButtons.YesNo,
				icon: MessageBoxIcon.Question,
				defaultButton: MessageBoxDefaultButton.Button2,
				options: MessageBoxOptions.RtlReading);

			if (dialogResult == DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /ExitAppliction

		#region RefreshData
		private void RefreshData()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.User> users = null;

				users =
					dataBaseContext.Users
					.OrderBy(currnet => currnet.First_Name)
					.ToList();

				userListDataGridView.DataSource = users;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /RefreshData

		#region ResetControls
		private	void ResetControls()
		{
			firstNameTextBox.Clear();
			firstNameTextBox.Focus();

			lastNameTextBox.Clear();
			addressTextBox.Clear();
		}
		#endregion /ResetControls
		//-------------------
		#endregion /Founction

		
	}
}
