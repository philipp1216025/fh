﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelvesSoftware.DataContainer;

namespace SelvesSoftware
{
    /// <summary>
    /// author: ZK
    /// </summary>

    public class PersonalAssistant:Person
    {
        public String Name { get { return this.FirstName + " " + this.LastName; } }
      
        public PersonalAssistant(int id)
        {
            this.Id = id;
            HomeAdress = new Adress();
            
        }
        public PersonalAssistant(Person person)
        {
            this.Id = person.Id;
            this.EMail = person.EMail;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.PhoneNumber = person.PhoneNumber;
            this.HomeAdress = person.HomeAdress;
            this.MobilePhone = person.MobilePhone;
            this.IBAN = person.IBAN;
            this.nationality = person.nationality;
            this.SVN = person.SVN;
            this.BIC = person.BIC;
            this.AccountHolder = person.AccountHolder;
        }

        public PersonalAssistant()
        {
        }

        public PersonalAssistant(bool active,bool SV,bool dienstvertrag,bool bestBH,bool grundkurs, DateTime cl, List<Employment> et, List<Purchaser> purchasers)
        {
            this.Active = active;
            this.ClosingDateDocuments = cl;
            this.EmploymentTimes = et;
            this.Purchasers = purchasers;
            this.Grundkurs = grundkurs;
            this.SV = SV;
            this.Dienstvertrag = dienstvertrag;
            this.BestBH = bestBH;
        }

        public bool Active { get; set; }
        /// <summary>
        /// Abgabedatum wichtiger Unterlagen
        /// </summary>
        public DateTime? ClosingDateDocuments
        {
            get;
            set;
        }
        public bool SV { get; set; }
        public bool Dienstvertrag { get; set; }
        public bool BestBH { get; set; }
        public bool Grundkurs { get; set; }

        /// <summary>
        /// bereits konsumierte Weiterbildungsstunden
        /// </summary>
        public decimal consumedHours { get; set; }

        /// <summary>
        /// Datum bis zu dem die Weiterbildungsstunden konsumiert sein müssen
        /// </summary>
        public DateTime? deadLineHours { get; set; }

        /// <summary>
        /// Liste der Dienste mit Eintrittdatum und ev. Austrittsdatum
        /// </summary>
        public List<Employment> EmploymentTimes { get; set; }
        /// <summary>
        /// Liste aller Dokumente des Assistenten
        /// </summary>
        public List<Document> Documents { get; set; }

        /// <summary>
        /// Liste aller Auftraggeber, bei denen Assistent angestellt ist
        /// </summary>
        public List<Purchaser> Purchasers { get; set; }
    }
}
