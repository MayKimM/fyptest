
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace fyptest.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Rating
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Rating()
    {

        this.Providers = new HashSet<Provider>();

        this.Requests = new HashSet<Request>();

    }


    public string RId { get; set; }

    public int attitude { get; set; }

    public int quality { get; set; }

    public int efficiency { get; set; }

    public int professionalism { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Provider> Providers { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Request> Requests { get; set; }

}

}
