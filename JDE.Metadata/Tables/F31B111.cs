using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B111 - .
/// </summary>
public class F31B111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSWGID.
        /// </summary>
        public const string GSWGID = "GSWGID";

        /// <summary>
        /// GSWGNA.
        /// </summary>
        public const string GSWGNA = "GSWGNA";

        /// <summary>
        /// GSMCU.
        /// </summary>
        public const string GSMCU = "GSMCU";

        /// <summary>
        /// GSSFNB.
        /// </summary>
        public const string GSSFNB = "GSSFNB";

        /// <summary>
        /// GSSRNM.
        /// </summary>
        public const string GSSRNM = "GSSRNM";

        /// <summary>
        /// GSGNNM.
        /// </summary>
        public const string GSGNNM = "GSGNNM";

        /// <summary>
        /// GSOTNM.
        /// </summary>
        public const string GSOTNM = "GSOTNM";

        /// <summary>
        /// GSAN8.
        /// </summary>
        public const string GSAN8 = "GSAN8";

        /// <summary>
        /// GSALPH.
        /// </summary>
        public const string GSALPH = "GSALPH";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSURCD.
        /// </summary>
        public const string GSURCD = "GSURCD";

        /// <summary>
        /// GSURDT.
        /// </summary>
        public const string GSURDT = "GSURDT";

        /// <summary>
        /// GSURAT.
        /// </summary>
        public const string GSURAT = "GSURAT";

        /// <summary>
        /// GSURRF.
        /// </summary>
        public const string GSURRF = "GSURRF";

        /// <summary>
        /// GSURAB.
        /// </summary>
        public const string GSURAB = "GSURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSWGID", "GSWGID", JdeDataType.String, 16, true, true),
        new JdeField("GSWGNA", "GSWGNA", JdeDataType.String, 60),
        new JdeField("GSMCU", "GSMCU", JdeDataType.String, 24),
        new JdeField("GSSFNB", "GSSFNB", JdeDataType.Numeric, null, true, true),
        new JdeField("GSSRNM", "GSSRNM", JdeDataType.String, 50),
        new JdeField("GSGNNM", "GSGNNM", JdeDataType.String, 50),
        new JdeField("GSOTNM", "GSOTNM", JdeDataType.String, 40),
        new JdeField("GSAN8", "GSAN8", JdeDataType.Numeric),
        new JdeField("GSALPH", "GSALPH", JdeDataType.String, 80),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSURCD", "GSURCD", JdeDataType.String, 4),
        new JdeField("GSURDT", "GSURDT", JdeDataType.Numeric),
        new JdeField("GSURAT", "GSURAT", JdeDataType.Numeric),
        new JdeField("GSURRF", "GSURRF", JdeDataType.String, 30),
        new JdeField("GSURAB", "GSURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B111_0", "Primary Key on GSSFNB, GSWGID", new[] { "GSSFNB", "GSWGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B111_2", "Index on GSWGID", new[] { "GSWGID" })
    };
}
