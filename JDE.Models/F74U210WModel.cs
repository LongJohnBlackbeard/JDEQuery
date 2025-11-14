namespace JDE.Models;

/// <summary>
/// F74U210W - .
/// </summary>
public class F74U210WModel
{
    /// <summary>
    /// PLPID (Primary Key).
    /// </summary>
    public string PLPID { get; set; }

    /// <summary>
    /// PLJOBN (Primary Key).
    /// </summary>
    public string PLJOBN { get; set; }

    /// <summary>
    /// PLUPMJ (Primary Key).
    /// </summary>
    public decimal PLUPMJ { get; set; }

    /// <summary>
    /// PLUPMT (Primary Key).
    /// </summary>
    public decimal PLUPMT { get; set; }

    /// <summary>
    /// PLDOCO (Primary Key).
    /// </summary>
    public decimal PLDOCO { get; set; }

    /// <summary>
    /// PLLSVR (Primary Key).
    /// </summary>
    public decimal PLLSVR { get; set; }

    /// <summary>
    /// PL74UCRCD (Primary Key).
    /// </summary>
    public string PL74UCRCD { get; set; }

    /// <summary>
    /// PL74UGAMT.
    /// </summary>
    public decimal? PL74UGAMT { get; set; }

    /// <summary>
    /// PLUSER.
    /// </summary>
    public string? PLUSER { get; set; }
}
