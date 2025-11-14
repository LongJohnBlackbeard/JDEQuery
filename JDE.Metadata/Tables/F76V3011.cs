using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V3011 - .
/// </summary>
public class F76V3011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFKCO.
        /// </summary>
        public const string CFKCO = "CFKCO";

        /// <summary>
        /// CFAN8.
        /// </summary>
        public const string CFAN8 = "CFAN8";

        /// <summary>
        /// CFDCT.
        /// </summary>
        public const string CFDCT = "CFDCT";

        /// <summary>
        /// CFDOC.
        /// </summary>
        public const string CFDOC = "CFDOC";

        /// <summary>
        /// CFV76ICNV.
        /// </summary>
        public const string CFV76ICNV = "CFV76ICNV";

        /// <summary>
        /// CFURRF.
        /// </summary>
        public const string CFURRF = "CFURRF";

        /// <summary>
        /// CFURAT.
        /// </summary>
        public const string CFURAT = "CFURAT";

        /// <summary>
        /// CFURAB.
        /// </summary>
        public const string CFURAB = "CFURAB";

        /// <summary>
        /// CFURCD.
        /// </summary>
        public const string CFURCD = "CFURCD";

        /// <summary>
        /// CFURDT.
        /// </summary>
        public const string CFURDT = "CFURDT";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V3011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFKCO", "CFKCO", JdeDataType.String, 10, true, true),
        new JdeField("CFAN8", "CFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CFDCT", "CFDCT", JdeDataType.String, 4, true, true),
        new JdeField("CFDOC", "CFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CFV76ICNV", "CFV76ICNV", JdeDataType.String, 20),
        new JdeField("CFURRF", "CFURRF", JdeDataType.String, 30),
        new JdeField("CFURAT", "CFURAT", JdeDataType.Numeric),
        new JdeField("CFURAB", "CFURAB", JdeDataType.Numeric),
        new JdeField("CFURCD", "CFURCD", JdeDataType.String, 4),
        new JdeField("CFURDT", "CFURDT", JdeDataType.Numeric),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V3011_0", "Primary Key on CFKCO, CFAN8, CFDCT, CFDOC", new[] { "CFKCO", "CFAN8", "CFDCT", "CFDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
