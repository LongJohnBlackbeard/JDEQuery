using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0120 - .
/// </summary>
public class F74U0120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MVKCO.
        /// </summary>
        public const string MVKCO = "MVKCO";

        /// <summary>
        /// MVDOC.
        /// </summary>
        public const string MVDOC = "MVDOC";

        /// <summary>
        /// MVDCT.
        /// </summary>
        public const string MVDCT = "MVDCT";

        /// <summary>
        /// MVSFX.
        /// </summary>
        public const string MVSFX = "MVSFX";

        /// <summary>
        /// MVSFXE.
        /// </summary>
        public const string MVSFXE = "MVSFXE";

        /// <summary>
        /// MVEV01.
        /// </summary>
        public const string MVEV01 = "MVEV01";

        /// <summary>
        /// MVUSER.
        /// </summary>
        public const string MVUSER = "MVUSER";

        /// <summary>
        /// MVPID.
        /// </summary>
        public const string MVPID = "MVPID";

        /// <summary>
        /// MVUPDJ.
        /// </summary>
        public const string MVUPDJ = "MVUPDJ";

        /// <summary>
        /// MVUPMT.
        /// </summary>
        public const string MVUPMT = "MVUPMT";

        /// <summary>
        /// MVJOBN.
        /// </summary>
        public const string MVJOBN = "MVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MVKCO", "MVKCO", JdeDataType.String, 10, true, true),
        new JdeField("MVDOC", "MVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MVDCT", "MVDCT", JdeDataType.String, 4, true, true),
        new JdeField("MVSFX", "MVSFX", JdeDataType.String, 6, true, true),
        new JdeField("MVSFXE", "MVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("MVEV01", "MVEV01", JdeDataType.String, 2),
        new JdeField("MVUSER", "MVUSER", JdeDataType.String, 20),
        new JdeField("MVPID", "MVPID", JdeDataType.String, 20),
        new JdeField("MVUPDJ", "MVUPDJ", JdeDataType.Numeric),
        new JdeField("MVUPMT", "MVUPMT", JdeDataType.Numeric),
        new JdeField("MVJOBN", "MVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0120_0", "Primary Key on MVKCO, MVDOC, MVDCT, MVSFX, MVSFXE", new[] { "MVKCO", "MVDOC", "MVDCT", "MVSFX", "MVSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
