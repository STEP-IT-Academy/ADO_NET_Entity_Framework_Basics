//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_ADO_NET_HW_5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
    
        public virtual Owner Owner { get; set; }
    }
}
