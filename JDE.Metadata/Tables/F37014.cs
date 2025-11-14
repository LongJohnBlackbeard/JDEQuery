using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37014 - .
/// </summary>
public class F37014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCRSCONVID.
        /// </summary>
        public const string RCRSCONVID = "RCRSCONVID";

        /// <summary>
        /// RCDSC1.
        /// </summary>
        public const string RCDSC1 = "RCDSC1";

        /// <summary>
        /// RCRSCNVTYP.
        /// </summary>
        public const string RCRSCNVTYP = "RCRSCNVTYP";

        /// <summary>
        /// RCEFTJ.
        /// </summary>
        public const string RCEFTJ = "RCEFTJ";

        /// <summary>
        /// RCEXDJ.
        /// </summary>
        public const string RCEXDJ = "RCEXDJ";

        /// <summary>
        /// RCRSBFNM.
        /// </summary>
        public const string RCRSBFNM = "RCRSBFNM";

        /// <summary>
        /// RCNUMT2.
        /// </summary>
        public const string RCNUMT2 = "RCNUMT2";

        /// <summary>
        /// RCCDEC.
        /// </summary>
        public const string RCCDEC = "RCCDEC";

        /// <summary>
        /// RCNUMT3.
        /// </summary>
        public const string RCNUMT3 = "RCNUMT3";

        /// <summary>
        /// RCCDEC2.
        /// </summary>
        public const string RCCDEC2 = "RCCDEC2";

        /// <summary>
        /// RCFRMRSUM.
        /// </summary>
        public const string RCFRMRSUM = "RCFRMRSUM";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCTDAY.
        /// </summary>
        public const string RCTDAY = "RCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F37014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCRSCONVID", "RCRSCONVID", JdeDataType.String, 60, true, true),
        new JdeField("RCDSC1", "RCDSC1", JdeDataType.String, 60),
        new JdeField("RCRSCNVTYP", "RCRSCNVTYP", JdeDataType.String, 2),
        new JdeField("RCEFTJ", "RCEFTJ", JdeDataType.Numeric),
        new JdeField("RCEXDJ", "RCEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RCRSBFNM", "RCRSBFNM", JdeDataType.String, 64),
        new JdeField("RCNUMT2", "RCNUMT2", JdeDataType.String, 2),
        new JdeField("RCCDEC", "RCCDEC", JdeDataType.String, 2),
        new JdeField("RCNUMT3", "RCNUMT3", JdeDataType.String, 2),
        new JdeField("RCCDEC2", "RCCDEC2", JdeDataType.String, 2),
        new JdeField("RCFRMRSUM", "RCFRMRSUM", JdeDataType.String, 6),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCTDAY", "RCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37014_0", "Primary Key on RCRSCONVID, RCEXDJ", new[] { "RCRSCONVID", "RCEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
