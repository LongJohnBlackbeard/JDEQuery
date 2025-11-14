using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A23 - .
/// </summary>
public class F76A23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWKCO.
        /// </summary>
        public const string IWKCO = "IWKCO";

        /// <summary>
        /// IWDCT.
        /// </summary>
        public const string IWDCT = "IWDCT";

        /// <summary>
        /// IWDOC.
        /// </summary>
        public const string IWDOC = "IWDOC";

        /// <summary>
        /// IWPNO.
        /// </summary>
        public const string IWPNO = "IWPNO";

        /// <summary>
        /// IWLNID.
        /// </summary>
        public const string IWLNID = "IWLNID";

        /// <summary>
        /// IWARN.
        /// </summary>
        public const string IWARN = "IWARN";

        /// <summary>
        /// IWAWN.
        /// </summary>
        public const string IWAWN = "IWAWN";

        /// <summary>
        /// IWAG.
        /// </summary>
        public const string IWAG = "IWAG";

        /// <summary>
        /// IWURRF.
        /// </summary>
        public const string IWURRF = "IWURRF";

        /// <summary>
        /// IWURCD.
        /// </summary>
        public const string IWURCD = "IWURCD";

        /// <summary>
        /// IWURDT.
        /// </summary>
        public const string IWURDT = "IWURDT";

        /// <summary>
        /// IWURAT.
        /// </summary>
        public const string IWURAT = "IWURAT";

        /// <summary>
        /// IWURAB.
        /// </summary>
        public const string IWURAB = "IWURAB";

        /// <summary>
        /// IWCTID.
        /// </summary>
        public const string IWCTID = "IWCTID";

        /// <summary>
        /// IWUSER.
        /// </summary>
        public const string IWUSER = "IWUSER";

        /// <summary>
        /// IWPID.
        /// </summary>
        public const string IWPID = "IWPID";

        /// <summary>
        /// IWUPMJ.
        /// </summary>
        public const string IWUPMJ = "IWUPMJ";

        /// <summary>
        /// IWUPMT.
        /// </summary>
        public const string IWUPMT = "IWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWKCO", "IWKCO", JdeDataType.String, 10, true, true),
        new JdeField("IWDCT", "IWDCT", JdeDataType.String, 4, true, true),
        new JdeField("IWDOC", "IWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IWPNO", "IWPNO", JdeDataType.Numeric, null, true, true),
        new JdeField("IWLNID", "IWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IWARN", "IWARN", JdeDataType.String, 16),
        new JdeField("IWAWN", "IWAWN", JdeDataType.String, 40),
        new JdeField("IWAG", "IWAG", JdeDataType.Numeric),
        new JdeField("IWURRF", "IWURRF", JdeDataType.String, 30),
        new JdeField("IWURCD", "IWURCD", JdeDataType.String, 4),
        new JdeField("IWURDT", "IWURDT", JdeDataType.Numeric),
        new JdeField("IWURAT", "IWURAT", JdeDataType.Numeric),
        new JdeField("IWURAB", "IWURAB", JdeDataType.Numeric),
        new JdeField("IWCTID", "IWCTID", JdeDataType.String, 30),
        new JdeField("IWUSER", "IWUSER", JdeDataType.String, 20),
        new JdeField("IWPID", "IWPID", JdeDataType.String, 20),
        new JdeField("IWUPMJ", "IWUPMJ", JdeDataType.Numeric),
        new JdeField("IWUPMT", "IWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A23_0", "Primary Key on IWKCO, IWDCT, IWDOC, IWPNO, IWLNID", new[] { "IWKCO", "IWDCT", "IWDOC", "IWPNO", "IWLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
