using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4320 - .
/// </summary>
public class F4320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCCUKID.
        /// </summary>
        public const string PCCUKID = "PCCUKID";

        /// <summary>
        /// PCSEQN.
        /// </summary>
        public const string PCSEQN = "PCSEQN";

        /// <summary>
        /// PCINMG.
        /// </summary>
        public const string PCINMG = "PCINMG";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCTORG.
        /// </summary>
        public const string PCTORG = "PCTORG";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUUPMJ.
        /// </summary>
        public const string PCUUPMJ = "PCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCCUKID", "PCCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCSEQN", "PCSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCINMG", "PCINMG", JdeDataType.String, 20),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCTORG", "PCTORG", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUUPMJ", "PCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4320_0", "Primary Key on PCCUKID, PCSEQN", new[] { "PCCUKID", "PCSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
