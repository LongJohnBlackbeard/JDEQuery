using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D272 - .
/// </summary>
public class F80D272 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCPRDJ.
        /// </summary>
        public const string PCPRDJ = "PCPRDJ";

        /// <summary>
        /// PCCO.
        /// </summary>
        public const string PCCO = "PCCO";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCAMPRF.
        /// </summary>
        public const string PCAMPRF = "PCAMPRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCMKEY.
        /// </summary>
        public const string PCMKEY = "PCMKEY";

        /// <summary>
        /// PCUTIME.
        /// </summary>
        public const string PCUTIME = "PCUTIME";

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
    }

    /// <inheritdoc />
    public override string TableName => "F80D272";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCPRDJ", "PCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCO", "PCCO", JdeDataType.String, 10, true, true),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PCAMPRF", "PCAMPRF", JdeDataType.Numeric),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCMKEY", "PCMKEY", JdeDataType.String, 30),
        new JdeField("PCUTIME", "PCUTIME", JdeDataType.Date),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D272_0", "Primary Key on PCPRDJ, PCCO, PCAN8", new[] { "PCPRDJ", "PCCO", "PCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
