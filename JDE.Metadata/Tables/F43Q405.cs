using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q405 - .
/// </summary>
public class F43Q405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RKEVNU.
        /// </summary>
        public const string RKEVNU = "RKEVNU";

        /// <summary>
        /// RKDCTO.
        /// </summary>
        public const string RKDCTO = "RKDCTO";

        /// <summary>
        /// RKKCOO.
        /// </summary>
        public const string RKKCOO = "RKKCOO";

        /// <summary>
        /// RKEVLN.
        /// </summary>
        public const string RKEVLN = "RKEVLN";

        /// <summary>
        /// RKBIDNUM.
        /// </summary>
        public const string RKBIDNUM = "RKBIDNUM";

        /// <summary>
        /// RKAN8.
        /// </summary>
        public const string RKAN8 = "RKAN8";

        /// <summary>
        /// RKRSNT.
        /// </summary>
        public const string RKRSNT = "RKRSNT";

        /// <summary>
        /// RKRCD.
        /// </summary>
        public const string RKRCD = "RKRCD";

        /// <summary>
        /// RKEMAILNFY.
        /// </summary>
        public const string RKEMAILNFY = "RKEMAILNFY";

        /// <summary>
        /// RKURCD.
        /// </summary>
        public const string RKURCD = "RKURCD";

        /// <summary>
        /// RKURDT.
        /// </summary>
        public const string RKURDT = "RKURDT";

        /// <summary>
        /// RKURAT.
        /// </summary>
        public const string RKURAT = "RKURAT";

        /// <summary>
        /// RKURAB.
        /// </summary>
        public const string RKURAB = "RKURAB";

        /// <summary>
        /// RKURRF.
        /// </summary>
        public const string RKURRF = "RKURRF";

        /// <summary>
        /// RKTORG.
        /// </summary>
        public const string RKTORG = "RKTORG";

        /// <summary>
        /// RKUSER.
        /// </summary>
        public const string RKUSER = "RKUSER";

        /// <summary>
        /// RKPID.
        /// </summary>
        public const string RKPID = "RKPID";

        /// <summary>
        /// RKJOBN.
        /// </summary>
        public const string RKJOBN = "RKJOBN";

        /// <summary>
        /// RKUPMJ.
        /// </summary>
        public const string RKUPMJ = "RKUPMJ";

        /// <summary>
        /// RKTDAY.
        /// </summary>
        public const string RKTDAY = "RKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RKEVNU", "RKEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RKDCTO", "RKDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RKKCOO", "RKKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RKEVLN", "RKEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RKBIDNUM", "RKBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RKAN8", "RKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RKRSNT", "RKRSNT", JdeDataType.String, 4),
        new JdeField("RKRCD", "RKRCD", JdeDataType.String, 6),
        new JdeField("RKEMAILNFY", "RKEMAILNFY", JdeDataType.String, 2),
        new JdeField("RKURCD", "RKURCD", JdeDataType.String, 4),
        new JdeField("RKURDT", "RKURDT", JdeDataType.Numeric),
        new JdeField("RKURAT", "RKURAT", JdeDataType.Numeric),
        new JdeField("RKURAB", "RKURAB", JdeDataType.Numeric),
        new JdeField("RKURRF", "RKURRF", JdeDataType.String, 30),
        new JdeField("RKTORG", "RKTORG", JdeDataType.String, 20),
        new JdeField("RKUSER", "RKUSER", JdeDataType.String, 20),
        new JdeField("RKPID", "RKPID", JdeDataType.String, 20),
        new JdeField("RKJOBN", "RKJOBN", JdeDataType.String, 20),
        new JdeField("RKUPMJ", "RKUPMJ", JdeDataType.Numeric),
        new JdeField("RKTDAY", "RKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q405_0", "Primary Key on RKEVNU, RKDCTO, RKKCOO, RKEVLN, RKBIDNUM, RKAN8", new[] { "RKEVNU", "RKDCTO", "RKKCOO", "RKEVLN", "RKBIDNUM", "RKAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q405_2", "Index on RKEVNU, RKDCTO, RKKCOO, RKAN8, RKBIDNUM, RKEVLN", new[] { "RKEVNU", "RKDCTO", "RKKCOO", "RKAN8", "RKBIDNUM", "RKEVLN" })
    };
}
