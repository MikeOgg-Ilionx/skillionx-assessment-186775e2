using System;
using System.Collections.Generic;

public class Contact
{
    public string Naam { get; set; }
    public string Telefoonnummer { get; set; }
}

public class ContactenLijst
{
    private List<Contact> contacten = new List<Contact>();

    public void VoegContactToe(string naam, string telefoonnummer)
    {
        // Implementeer hier de logica om een nieuw contact toe te voegen
    }

    public void ToonAlleContacten()
    {
        // Implementeer hier de logica om alle contacten weer te geven
    }

    public List<Contact> ZoekContactOpNaam(string naam)
    {
        // Implementeer hier de logica om contacten op naam te zoeken
        return new List<Contact>(); // Placeholder
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ContactenLijst mijnLijst = new ContactenLijst();

        // Hier kunt u de functionaliteiten van de ContactenLijst testen
        // Bijvoorbeeld:
        // mijnLijst.VoegContactToe("Jan Jansen", "06-12345678");
        // mijnLijst.ToonAlleContacten();
        // var gevondenContacten = mijnLijst.ZoekContactOpNaam("Jan Jansen");
    }
}

// hallo dit is een test