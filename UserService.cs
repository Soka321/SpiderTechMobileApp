using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Spide_Tech_App
{
   public  class UserService
    {
		//initiallizing databasep[;'
		private SQLiteAsyncConnection connect ;
		public async Task InitializeDB()
		{ 
		
		
	if(connect!=null)
	{
		return;
	}
		connect= new SQLiteAsyncConnection("_dbPath");
          await  connect.CreateTableAsync<User>();
		await	connect.CreateTableAsync<Quotations>();
		await	connect.CreateTableAsync<Invoice>();
		await	connect.CreateTableAsync<Bookings>();
			
			
			
        }
		//registering a user
		public async Task Register(int ID, string name, string surname,string email, string password,int contact, string type )
		{
			int i=0;
			await InitializeDB();
			
		i= await	connect.InsertAsync(new User{UserId=ID,UserName=name, UserSurname=surname, UserEmail=email,UserPassword=password,UserContact=contact, UserType=type});
			
		}
		
		//login user
		
		public async Task Login(string email, string password)
		{
			
			await InitializeDB();
			
			if(ViewEmail(email) && ViewPassword(password)!=NULL)
			{
				Navigation.PushAsync(new MainPage());
			}
			
			
			else{
			await DisplayAlert("Not a member", "Cannot verify who you are, try again","OK");	
			}
		}
		//booking a slot

		public async Task Book(int id, int vin, string number, string model, string type, string date)
		{
			int i = 0;
			await InitializeDB();
			i = await connect.InsertAsync(new Bookings{BookID=id, vinNumber= vin, NumberPlate= number, UserEmail = model, Type = type Date = date });
		}
	//enter qoutation
	public async Task Qoutation(int id,string part, int num, string labour,string date)
	
		{
			int i=0;
			await InitializeDB();
			i= await	connect.InsertAsync(new Quotations{QuotationId=id,Part=part, NumPart=num,Labour=labour, Date=date});
		}
	//view quotation
	public async Task ViewQuotation(int id)
		{
			int i=0;
			await InitializeDB();
			if(ID==id)
			{
			i= await	connect.;
			}
		}
	//View user
		public async Task<User> ViewUser(int id)
		{
			
			await InitializeDB();
			return await connect.Table<User>().where.(i=UserId.Id==id).FirstOrDefaultAsync();
			}
		}
		
		//View more users
		public List<User> ViewUsers(int id)
		{
			//if mananger write
			List<User> users= connect.Table<User>.ToList();
			return users;
		}
		
		//View user
		public async Task<User> ViewEmail(string email)
		{
			
			await InitializeDB();
			return await connect.Table<User>().where.(i=UserEmail.email==email).FirstOrDefaultAsync();
			}
		}
		
		//View user
		public async Task<User> ViewPassword(string password)
		{
			
			await InitializeDB();
			return await connect.Table<User>().where.(i=UserPassword.password==password).FirstOrDefaultAsync();
			}
		}
    }
	
