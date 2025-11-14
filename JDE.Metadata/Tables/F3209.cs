using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3209 - .
/// </summary>
public class F3209 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFMCU.
        /// </summary>
        public const string CFMCU = "CFMCU";

        /// <summary>
        /// CFSECD.
        /// </summary>
        public const string CFSECD = "CFSECD";

        /// <summary>
        /// CFAPLR.
        /// </summary>
        public const string CFAPLR = "CFAPLR";

        /// <summary>
        /// CFCAVL.
        /// </summary>
        public const string CFCAVL = "CFCAVL";

        /// <summary>
        /// CFLNTY.
        /// </summary>
        public const string CFLNTY = "CFLNTY";

        /// <summary>
        /// CFSQRT.
        /// </summary>
        public const string CFSQRT = "CFSQRT";

        /// <summary>
        /// CFCCSQ.
        /// </summary>
        public const string CFCCSQ = "CFCCSQ";

        /// <summary>
        /// CFDCSG.
        /// </summary>
        public const string CFDCSG = "CFDCSG";

        /// <summary>
        /// CFCEC.
        /// </summary>
        public const string CFCEC = "CFCEC";

        /// <summary>
        /// CFURCD.
        /// </summary>
        public const string CFURCD = "CFURCD";

        /// <summary>
        /// CFURDT.
        /// </summary>
        public const string CFURDT = "CFURDT";

        /// <summary>
        /// CFURAT.
        /// </summary>
        public const string CFURAT = "CFURAT";

        /// <summary>
        /// CFURAB.
        /// </summary>
        public const string CFURAB = "CFURAB";

        /// <summary>
        /// CFURRF.
        /// </summary>
        public const string CFURRF = "CFURRF";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFTDAY.
        /// </summary>
        public const string CFTDAY = "CFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3209";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFMCU", "CFMCU", JdeDataType.String, 24, true, true),
        new JdeField("CFSECD", "CFSECD", JdeDataType.String, 2),
        new JdeField("CFAPLR", "CFAPLR", JdeDataType.String, 2),
        new JdeField("CFCAVL", "CFCAVL", JdeDataType.String, 2),
        new JdeField("CFLNTY", "CFLNTY", JdeDataType.String, 4),
        new JdeField("CFSQRT", "CFSQRT", JdeDataType.String, 4),
        new JdeField("CFCCSQ", "CFCCSQ", JdeDataType.String, 2),
        new JdeField("CFDCSG", "CFDCSG", JdeDataType.String, 2),
        new JdeField("CFCEC", "CFCEC", JdeDataType.String, 2),
        new JdeField("CFURCD", "CFURCD", JdeDataType.String, 4),
        new JdeField("CFURDT", "CFURDT", JdeDataType.Numeric),
        new JdeField("CFURAT", "CFURAT", JdeDataType.Numeric),
        new JdeField("CFURAB", "CFURAB", JdeDataType.Numeric),
        new JdeField("CFURRF", "CFURRF", JdeDataType.String, 30),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFTDAY", "CFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3209_0", "Primary Key on CFMCU", new[] { "CFMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
