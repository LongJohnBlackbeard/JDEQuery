namespace JDE.Models;

/// <summary>
/// F4208 - .
/// </summary>
public class F4208Model
{
    /// <summary>
    /// PGCPGP (Primary Key).
    /// </summary>
    public string PGCPGP { get; set; }

    /// <summary>
    /// PGDESC.
    /// </summary>
    public string? PGDESC { get; set; }

    /// <summary>
    /// PGMCAT (Primary Key).
    /// </summary>
    public string PGMCAT { get; set; }

    /// <summary>
    /// PGCLV (Primary Key).
    /// </summary>
    public string PGCLV { get; set; }

    /// <summary>
    /// PGTYDS.
    /// </summary>
    public string? PGTYDS { get; set; }

    /// <summary>
    /// PGCXPJ.
    /// </summary>
    public decimal? PGCXPJ { get; set; }

    /// <summary>
    /// PGCEFJ.
    /// </summary>
    public decimal? PGCEFJ { get; set; }

    /// <summary>
    /// PGUPMJ.
    /// </summary>
    public decimal? PGUPMJ { get; set; }

    /// <summary>
    /// PGTDAY.
    /// </summary>
    public decimal? PGTDAY { get; set; }
}
