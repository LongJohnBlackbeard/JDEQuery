namespace JDE.Models;

/// <summary>
/// F40551 - .
/// </summary>
public class F40551Model
{
    /// <summary>
    /// GLMCU (Primary Key).
    /// </summary>
    public string GLMCU { get; set; }

    /// <summary>
    /// GLOBJ (Primary Key).
    /// </summary>
    public string GLOBJ { get; set; }

    /// <summary>
    /// GLSUB (Primary Key).
    /// </summary>
    public string GLSUB { get; set; }

    /// <summary>
    /// GLCMDCDE.
    /// </summary>
    public string? GLCMDCDE { get; set; }

    /// <summary>
    /// GLPID.
    /// </summary>
    public string? GLPID { get; set; }

    /// <summary>
    /// GLUSER.
    /// </summary>
    public string? GLUSER { get; set; }

    /// <summary>
    /// GLJOBN.
    /// </summary>
    public string? GLJOBN { get; set; }

    /// <summary>
    /// GLUPMJ.
    /// </summary>
    public decimal? GLUPMJ { get; set; }

    /// <summary>
    /// GLUPMT.
    /// </summary>
    public decimal? GLUPMT { get; set; }
}
