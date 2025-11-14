using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H092H - .
/// </summary>
public class F44H092H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHSDTYP.
        /// </summary>
        public const string EHSDTYP = "EHSDTYP";

        /// <summary>
        /// EHSDKY.
        /// </summary>
        public const string EHSDKY = "EHSDKY";

        /// <summary>
        /// EHHBAREA.
        /// </summary>
        public const string EHHBAREA = "EHHBAREA";

        /// <summary>
        /// EHEXDTA.
        /// </summary>
        public const string EHEXDTA = "EHEXDTA";

        /// <summary>
        /// EHDSCR.
        /// </summary>
        public const string EHDSCR = "EHDSCR";

        /// <summary>
        /// EHCH1.
        /// </summary>
        public const string EHCH1 = "EHCH1";

        /// <summary>
        /// EHCH2.
        /// </summary>
        public const string EHCH2 = "EHCH2";

        /// <summary>
        /// EHCRTU.
        /// </summary>
        public const string EHCRTU = "EHCRTU";

        /// <summary>
        /// EHCRTJ.
        /// </summary>
        public const string EHCRTJ = "EHCRTJ";

        /// <summary>
        /// EHCRTT.
        /// </summary>
        public const string EHCRTT = "EHCRTT";

        /// <summary>
        /// EHWRKSTNID.
        /// </summary>
        public const string EHWRKSTNID = "EHWRKSTNID";

        /// <summary>
        /// EHJPID.
        /// </summary>
        public const string EHJPID = "EHJPID";

        /// <summary>
        /// EHUPMB.
        /// </summary>
        public const string EHUPMB = "EHUPMB";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHUPMT.
        /// </summary>
        public const string EHUPMT = "EHUPMT";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H092H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHSDTYP", "EHSDTYP", JdeDataType.String, 6, true, true),
        new JdeField("EHSDKY", "EHSDKY", JdeDataType.String, 20, true, true),
        new JdeField("EHHBAREA", "EHHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("EHEXDTA", "EHEXDTA", JdeDataType.String, 16, true, true),
        new JdeField("EHDSCR", "EHDSCR", JdeDataType.String, 80),
        new JdeField("EHCH1", "EHCH1", JdeDataType.String, 40),
        new JdeField("EHCH2", "EHCH2", JdeDataType.String, 40),
        new JdeField("EHCRTU", "EHCRTU", JdeDataType.String, 20),
        new JdeField("EHCRTJ", "EHCRTJ", JdeDataType.Numeric),
        new JdeField("EHCRTT", "EHCRTT", JdeDataType.Numeric),
        new JdeField("EHWRKSTNID", "EHWRKSTNID", JdeDataType.String, 20),
        new JdeField("EHJPID", "EHJPID", JdeDataType.String, 20),
        new JdeField("EHUPMB", "EHUPMB", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHUPMT", "EHUPMT", JdeDataType.Numeric),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H092H_0", "Primary Key on EHSDTYP, EHSDKY, EHHBAREA, EHEXDTA", new[] { "EHSDTYP", "EHSDKY", "EHHBAREA", "EHEXDTA" }, isUnique: true, isPrimaryKey: true)
    };
}
