namespace JDE.Models;

/// <summary>
/// F0101 - Address Book Master data model.
/// </summary>
public class F0101Model
{
    /// <summary>
    /// Gets or sets the Address Number (Primary Key).
    /// </summary>
    public decimal ABAN8 { get; set; }

    /// <summary>
    /// Gets or sets the Alphabetic Name.
    /// </summary>
    public string? ABALPH { get; set; }

    /// <summary>
    /// Gets or sets the Alpha Name/Search Key.
    /// </summary>
    public string? ABALKY { get; set; }

    /// <summary>
    /// Gets or sets the Search Type (E=Employee, C=Customer, V=Vendor, etc.).
    /// </summary>
    public string? ABAT1 { get; set; }

    /// <summary>
    /// Gets or sets the Description - Compressed.
    /// </summary>
    public string? ABDC { get; set; }

    /// <summary>
    /// Gets or sets the Tax ID.
    /// </summary>
    public string? ABTAX { get; set; }

    /// <summary>
    /// Gets or sets the Tax ID Country.
    /// </summary>
    public string? ABTAXC { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 01.
    /// </summary>
    public string? ABAC01 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 02.
    /// </summary>
    public string? ABAC02 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 03.
    /// </summary>
    public string? ABAC03 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 04.
    /// </summary>
    public string? ABAC04 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 05.
    /// </summary>
    public string? ABAC05 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 06.
    /// </summary>
    public string? ABAC06 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 07.
    /// </summary>
    public string? ABAC07 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 08.
    /// </summary>
    public string? ABAC08 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 09.
    /// </summary>
    public string? ABAC09 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 10.
    /// </summary>
    public string? ABAC10 { get; set; }

    /// <summary>
    /// Gets or sets the Business Unit.
    /// </summary>
    public string? ABMCU { get; set; }

    /// <summary>
    /// Gets or sets the Standard Industry Class.
    /// </summary>
    public string? ABSIC { get; set; }

    /// <summary>
    /// Gets or sets the Language.
    /// </summary>
    public string? ABLNGP { get; set; }

    /// <summary>
    /// Gets or sets the Credit Message.
    /// </summary>
    public string? ABCM { get; set; }

    /// <summary>
    /// Gets or sets the Alpha Name - Payee.
    /// </summary>
    public string? ABALP1 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 11.
    /// </summary>
    public string? ABAC11 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 12.
    /// </summary>
    public string? ABAC12 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 13.
    /// </summary>
    public string? ABAC13 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 14.
    /// </summary>
    public string? ABAC14 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 15.
    /// </summary>
    public string? ABAC15 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 16.
    /// </summary>
    public string? ABAC16 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 17.
    /// </summary>
    public string? ABAC17 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 18.
    /// </summary>
    public string? ABAC18 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 19.
    /// </summary>
    public string? ABAC19 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 20.
    /// </summary>
    public string? ABAC20 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 21.
    /// </summary>
    public string? ABAC21 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 22.
    /// </summary>
    public string? ABAC22 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 23.
    /// </summary>
    public string? ABAC23 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 24.
    /// </summary>
    public string? ABAC24 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 25.
    /// </summary>
    public string? ABAC25 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 26.
    /// </summary>
    public string? ABAC26 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 27.
    /// </summary>
    public string? ABAC27 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 28.
    /// </summary>
    public string? ABAC28 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 29.
    /// </summary>
    public string? ABAC29 { get; set; }

    /// <summary>
    /// Gets or sets Category Code - Address Book 30.
    /// </summary>
    public string? ABAC30 { get; set; }

    /// <summary>
    /// Gets or sets the User ID.
    /// </summary>
    public string? ABUSER { get; set; }

    /// <summary>
    /// Gets or sets the Program ID.
    /// </summary>
    public string? ABPID { get; set; }

    /// <summary>
    /// Gets or sets the Work Station ID.
    /// </summary>
    public string? ABJOBN { get; set; }

    /// <summary>
    /// Gets or sets the Date - Updated (Julian format).
    /// </summary>
    public decimal? ABUPMJ { get; set; }

    /// <summary>
    /// Gets or sets the Time - Updated.
    /// </summary>
    public decimal? ABUPMT { get; set; }
}
