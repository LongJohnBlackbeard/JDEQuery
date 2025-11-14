using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I404 - .
/// </summary>
public class F75I404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPYMNTH.
        /// </summary>
        public const string CPYMNTH = "CPYMNTH";

        /// <summary>
        /// CPDYR.
        /// </summary>
        public const string CPDYR = "CPDYR";

        /// <summary>
        /// CPMCU.
        /// </summary>
        public const string CPMCU = "CPMCU";

        /// <summary>
        /// CPI75CGPA.
        /// </summary>
        public const string CPI75CGPA = "CPI75CGPA";

        /// <summary>
        /// CPI75PCPA.
        /// </summary>
        public const string CPI75PCPA = "CPI75PCPA";

        /// <summary>
        /// CPI75TSPA.
        /// </summary>
        public const string CPI75TSPA = "CPI75TSPA";

        /// <summary>
        /// CPI75SOPA.
        /// </summary>
        public const string CPI75SOPA = "CPI75SOPA";

        /// <summary>
        /// CPI75SDMO.
        /// </summary>
        public const string CPI75SDMO = "CPI75SDMO";

        /// <summary>
        /// CPI75EDMO.
        /// </summary>
        public const string CPI75EDMO = "CPI75EDMO";

        /// <summary>
        /// CPI75CGDE.
        /// </summary>
        public const string CPI75CGDE = "CPI75CGDE";

        /// <summary>
        /// CPI75PCDE.
        /// </summary>
        public const string CPI75PCDE = "CPI75PCDE";

        /// <summary>
        /// CPI75TSDE.
        /// </summary>
        public const string CPI75TSDE = "CPI75TSDE";

        /// <summary>
        /// CPI75SODE.
        /// </summary>
        public const string CPI75SODE = "CPI75SODE";

        /// <summary>
        /// CPI75CGAD.
        /// </summary>
        public const string CPI75CGAD = "CPI75CGAD";

        /// <summary>
        /// CPI75PCAD.
        /// </summary>
        public const string CPI75PCAD = "CPI75PCAD";

        /// <summary>
        /// CPI75TSAD.
        /// </summary>
        public const string CPI75TSAD = "CPI75TSAD";

        /// <summary>
        /// CPI75SOAD.
        /// </summary>
        public const string CPI75SOAD = "CPI75SOAD";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPYMNTH", "CPYMNTH", JdeDataType.String, 4, true, true),
        new JdeField("CPDYR", "CPDYR", JdeDataType.Numeric, null, true, true),
        new JdeField("CPMCU", "CPMCU", JdeDataType.String, 24, true, true),
        new JdeField("CPI75CGPA", "CPI75CGPA", JdeDataType.Numeric),
        new JdeField("CPI75PCPA", "CPI75PCPA", JdeDataType.Numeric),
        new JdeField("CPI75TSPA", "CPI75TSPA", JdeDataType.Numeric),
        new JdeField("CPI75SOPA", "CPI75SOPA", JdeDataType.Numeric),
        new JdeField("CPI75SDMO", "CPI75SDMO", JdeDataType.Numeric),
        new JdeField("CPI75EDMO", "CPI75EDMO", JdeDataType.Numeric),
        new JdeField("CPI75CGDE", "CPI75CGDE", JdeDataType.Numeric),
        new JdeField("CPI75PCDE", "CPI75PCDE", JdeDataType.Numeric),
        new JdeField("CPI75TSDE", "CPI75TSDE", JdeDataType.Numeric),
        new JdeField("CPI75SODE", "CPI75SODE", JdeDataType.Numeric),
        new JdeField("CPI75CGAD", "CPI75CGAD", JdeDataType.Numeric),
        new JdeField("CPI75PCAD", "CPI75PCAD", JdeDataType.Numeric),
        new JdeField("CPI75TSAD", "CPI75TSAD", JdeDataType.Numeric),
        new JdeField("CPI75SOAD", "CPI75SOAD", JdeDataType.Numeric),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I404_0", "Primary Key on CPYMNTH, CPDYR, CPMCU", new[] { "CPYMNTH", "CPDYR", "CPMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
