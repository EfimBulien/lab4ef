//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba2ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class drivers
    {
        public int id_driver { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string middlename { get; set; }
        public int car_id { get; set; }
    
        public virtual cars cars { get; set; }
    }
}
