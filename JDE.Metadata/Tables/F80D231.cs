using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D231 - .
/// </summary>
public class F80D231 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCDRQJ.
        /// </summary>
        public const string PCDRQJ = "PCDRQJ";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCDFCC.
        /// </summary>
        public const string PCDFCC = "PCDFCC";

        /// <summary>
        /// PCPLAT.
        /// </summary>
        public const string PCPLAT = "PCPLAT";

        /// <summary>
        /// PCCPAT.
        /// </summary>
        public const string PCCPAT = "PCCPAT";

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
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCMKEY.
        /// </summary>
        public const string PCMKEY = "PCMKEY";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F80D231";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCDRQJ", "PCDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric),
        new JdeField("PCDFCC", "PCDFCC", JdeDataType.String, 6),
        new JdeField("PCPLAT", "PCPLAT", JdeDataType.Numeric),
        new JdeField("PCCPAT", "PCCPAT", JdeDataType.Numeric),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCMKEY", "PCMKEY", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D231_0", "Primary Key on PCDRQJ, PCMCU, PCITM", new[] { "PCDRQJ", "PCMCU", "PCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
