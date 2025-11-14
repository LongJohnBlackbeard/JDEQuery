using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H591 - .
/// </summary>
public class F44H591 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWHBMCUS.
        /// </summary>
        public const string CWHBMCUS = "CWHBMCUS";

        /// <summary>
        /// CWHBLOT.
        /// </summary>
        public const string CWHBLOT = "CWHBLOT";

        /// <summary>
        /// CWCLSRT.
        /// </summary>
        public const string CWCLSRT = "CWCLSRT";

        /// <summary>
        /// CWOPTION.
        /// </summary>
        public const string CWOPTION = "CWOPTION";

        /// <summary>
        /// CWEXR.
        /// </summary>
        public const string CWEXR = "CWEXR";

        /// <summary>
        /// CWCLDESC.
        /// </summary>
        public const string CWCLDESC = "CWCLDESC";

        /// <summary>
        /// CWCLMCD.
        /// </summary>
        public const string CWCLMCD = "CWCLMCD";

        /// <summary>
        /// CWMCU.
        /// </summary>
        public const string CWMCU = "CWMCU";

        /// <summary>
        /// CWOBJ.
        /// </summary>
        public const string CWOBJ = "CWOBJ";

        /// <summary>
        /// CWSUB.
        /// </summary>
        public const string CWSUB = "CWSUB";

        /// <summary>
        /// CWLT.
        /// </summary>
        public const string CWLT = "CWLT";

        /// <summary>
        /// CWCLSCD.
        /// </summary>
        public const string CWCLSCD = "CWCLSCD";

        /// <summary>
        /// CWSBL.
        /// </summary>
        public const string CWSBL = "CWSBL";

        /// <summary>
        /// CWSBLT.
        /// </summary>
        public const string CWSBLT = "CWSBLT";

        /// <summary>
        /// CWCLDBCR.
        /// </summary>
        public const string CWCLDBCR = "CWCLDBCR";

        /// <summary>
        /// CWAA.
        /// </summary>
        public const string CWAA = "CWAA";

        /// <summary>
        /// CWDMF.
        /// </summary>
        public const string CWDMF = "CWDMF";

        /// <summary>
        /// CWRECERR.
        /// </summary>
        public const string CWRECERR = "CWRECERR";

        /// <summary>
        /// CWU.
        /// </summary>
        public const string CWU = "CWU";

        /// <summary>
        /// CWCRTU.
        /// </summary>
        public const string CWCRTU = "CWCRTU";

        /// <summary>
        /// CWCRTJ.
        /// </summary>
        public const string CWCRTJ = "CWCRTJ";

        /// <summary>
        /// CWCRTT.
        /// </summary>
        public const string CWCRTT = "CWCRTT";

        /// <summary>
        /// CWWRKSTNID.
        /// </summary>
        public const string CWWRKSTNID = "CWWRKSTNID";

        /// <summary>
        /// CWHBOPID.
        /// </summary>
        public const string CWHBOPID = "CWHBOPID";

        /// <summary>
        /// CWUPMB.
        /// </summary>
        public const string CWUPMB = "CWUPMB";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWUPMT.
        /// </summary>
        public const string CWUPMT = "CWUPMT";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H591";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWHBMCUS", "CWHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("CWHBLOT", "CWHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("CWCLSRT", "CWCLSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("CWOPTION", "CWOPTION", JdeDataType.String, 16, true, true),
        new JdeField("CWEXR", "CWEXR", JdeDataType.String, 60),
        new JdeField("CWCLDESC", "CWCLDESC", JdeDataType.String, 100),
        new JdeField("CWCLMCD", "CWCLMCD", JdeDataType.String, 6),
        new JdeField("CWMCU", "CWMCU", JdeDataType.String, 24),
        new JdeField("CWOBJ", "CWOBJ", JdeDataType.String, 12),
        new JdeField("CWSUB", "CWSUB", JdeDataType.String, 16),
        new JdeField("CWLT", "CWLT", JdeDataType.String, 4),
        new JdeField("CWCLSCD", "CWCLSCD", JdeDataType.String, 6),
        new JdeField("CWSBL", "CWSBL", JdeDataType.String, 16),
        new JdeField("CWSBLT", "CWSBLT", JdeDataType.String, 2),
        new JdeField("CWCLDBCR", "CWCLDBCR", JdeDataType.String, 4),
        new JdeField("CWAA", "CWAA", JdeDataType.Numeric),
        new JdeField("CWDMF", "CWDMF", JdeDataType.String, 2),
        new JdeField("CWRECERR", "CWRECERR", JdeDataType.String, 20),
        new JdeField("CWU", "CWU", JdeDataType.Numeric),
        new JdeField("CWCRTU", "CWCRTU", JdeDataType.String, 20),
        new JdeField("CWCRTJ", "CWCRTJ", JdeDataType.Numeric),
        new JdeField("CWCRTT", "CWCRTT", JdeDataType.Numeric),
        new JdeField("CWWRKSTNID", "CWWRKSTNID", JdeDataType.String, 20),
        new JdeField("CWHBOPID", "CWHBOPID", JdeDataType.String, 20),
        new JdeField("CWUPMB", "CWUPMB", JdeDataType.String, 20),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric),
        new JdeField("CWUPMT", "CWUPMT", JdeDataType.Numeric),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H591_0", "Primary Key on CWHBMCUS, CWHBLOT, CWCLSRT, CWOPTION", new[] { "CWHBMCUS", "CWHBLOT", "CWCLSRT", "CWOPTION" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H591_2", "Index on CWHBMCUS, CWHBLOT", new[] { "CWHBMCUS", "CWHBLOT" })
    };
}
