namespace JDE.Models;

/// <summary>
/// F4101 - Item Master model.
/// Maps to JDE Item Master table (F4101).
/// </summary>
public class F4101Model
{
    /// <summary>
    /// Item Number - Short (Primary Key).
    /// </summary>
    public decimal IMITM { get; set; }

    /// <summary>
    /// Description.
    /// </summary>
    public string? IMDSC1 { get; set; }

    /// <summary>
    /// Description - Line 2.
    /// </summary>
    public string? IMDSC2 { get; set; }

    /// <summary>
    /// 2nd Item Number.
    /// </summary>
    public string? IMLITM { get; set; }

    /// <summary>
    /// 3rd Item Number.
    /// </summary>
    public string? IMAITM { get; set; }

    /// <summary>
    /// Product Code - Major.
    /// </summary>
    public string? IMSRP1 { get; set; }

    /// <summary>
    /// Product Code - Minor.
    /// </summary>
    public string? IMSRP2 { get; set; }

    /// <summary>
    /// Product Code - Tier 3.
    /// </summary>
    public string? IMSRP3 { get; set; }

    /// <summary>
    /// Product Code - Tier 4.
    /// </summary>
    public string? IMSRP4 { get; set; }

    /// <summary>
    /// Product Code - Tier 5.
    /// </summary>
    public string? IMSRP5 { get; set; }

    /// <summary>
    /// Stocking Type.
    /// </summary>
    public string? IMSTKT { get; set; }

    /// <summary>
    /// GL Category Code.
    /// </summary>
    public string? IMGLPT { get; set; }

    /// <summary>
    /// Unit of Measure - Primary.
    /// </summary>
    public string? IMUOM1 { get; set; }

    /// <summary>
    /// Unit of Measure - Secondary.
    /// </summary>
    public string? IMUOM2 { get; set; }

    /// <summary>
    /// Procurement Type.
    /// </summary>
    public string? IMPRP1 { get; set; }

    /// <summary>
    /// Inventory Unit of Measure.
    /// </summary>
    public string? IMURCD { get; set; }

    /// <summary>
    /// Unit of Measure - Reorder.
    /// </summary>
    public string? IMURRF { get; set; }

    /// <summary>
    /// Commodity Class - Major.
    /// </summary>
    public string? IMSRP6 { get; set; }

    /// <summary>
    /// Commodity Class - Minor.
    /// </summary>
    public string? IMSRP7 { get; set; }

    /// <summary>
    /// Commodity Class - Tier 3.
    /// </summary>
    public string? IMSRP8 { get; set; }

    /// <summary>
    /// Commodity Class - Tier 4.
    /// </summary>
    public string? IMSRP9 { get; set; }

    /// <summary>
    /// Commodity Class - Tier 5.
    /// </summary>
    public string? IMSRP0 { get; set; }

    /// <summary>
    /// Lead Time - Manufacturing.
    /// </summary>
    public decimal? IMLTLV { get; set; }

    /// <summary>
    /// Lead Time - Cumulative.
    /// </summary>
    public decimal? IMLTPU { get; set; }

    /// <summary>
    /// Lot Control.
    /// </summary>
    public string? IMLNTY { get; set; }

    /// <summary>
    /// Category Code 01.
    /// </summary>
    public string? IMCRCD01 { get; set; }

    /// <summary>
    /// Category Code 02.
    /// </summary>
    public string? IMCRCD02 { get; set; }

    /// <summary>
    /// Category Code 03.
    /// </summary>
    public string? IMCRCD03 { get; set; }

    /// <summary>
    /// Category Code 04.
    /// </summary>
    public string? IMCRCD04 { get; set; }

    /// <summary>
    /// Category Code 05.
    /// </summary>
    public string? IMCRCD05 { get; set; }

    /// <summary>
    /// Category Code 06.
    /// </summary>
    public string? IMCRCD06 { get; set; }

    /// <summary>
    /// Category Code 07.
    /// </summary>
    public string? IMCRCD07 { get; set; }

    /// <summary>
    /// Category Code 08.
    /// </summary>
    public string? IMCRCD08 { get; set; }

    /// <summary>
    /// Category Code 09.
    /// </summary>
    public string? IMCRCD09 { get; set; }

    /// <summary>
    /// Category Code 10.
    /// </summary>
    public string? IMCRCD10 { get; set; }

    /// <summary>
    /// Date - Updated (Julian format).
    /// </summary>
    public decimal? IMUPMJ { get; set; }

    /// <summary>
    /// Time of Day.
    /// </summary>
    public decimal? IMTDAY { get; set; }

    /// <summary>
    /// User ID.
    /// </summary>
    public string? IMUSER { get; set; }

    /// <summary>
    /// Program ID.
    /// </summary>
    public string? IMPID { get; set; }

    /// <summary>
    /// Work Station ID.
    /// </summary>
    public string? IMJOBN { get; set; }
}
