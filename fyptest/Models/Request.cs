
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
    
public partial class Request
{

    public string SId { get; set; }

    public string title { get; set; }

    public string address { get; set; }

    public string description { get; set; }

    public string image { get; set; }

    public string file { get; set; }

    public int status { get; set; }

    public bool immediate { get; set; }

    public System.DateTime dateCreated { get; set; }

    public Nullable<bool> seekerComplete { get; set; }

    public Nullable<bool> providerComplete { get; set; }

    public Nullable<System.DateTime> dateCompleted { get; set; }

    public bool repeat { get; set; }

    public double price { get; set; }

    public string Category { get; set; }

    public string Type { get; set; }

    public string Seeker { get; set; }

    public string Provider { get; set; }

    public string Rating { get; set; }



    public virtual Provider Provider1 { get; set; }

    public virtual Rating Rating1 { get; set; }

    public virtual Service_Category Service_Category { get; set; }

    public virtual Service_Type Service_Type { get; set; }

    public virtual Seeker Seeker1 { get; set; }

}

}
