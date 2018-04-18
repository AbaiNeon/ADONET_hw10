namespace hw10
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Контекст настроен для использования строки подключения "Context" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "hw10.Context" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Context" 
        // в файле конфигурации приложения.
        public Context()
            : base("name=Context")
        {
        }

        public DbSet<Deps> Deps { get; set; }
        public DbSet<Emps> Emps { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}