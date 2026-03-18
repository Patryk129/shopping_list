using CloudKit;
using SQLite;

namespace shopping_list
{
    public partial class MainPage : ContentPage
    {
        SQLiteAsyncConnection database;

        public MainPage()
        {
            InitializeComponent();
            
            //CreateTableAsync<T>();
            //Table<T>().ToListAsync();
            //InsertAsync(obiekt);
            //DeleteAsync(obiekt);
        }
        async public Database()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await database.CreateTableAsync<Products>();
        }

    }
}