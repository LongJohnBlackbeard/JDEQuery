using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1511B1 - .
/// </summary>
public class F1511B1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWGENT.
        /// </summary>
        public const string NWGENT = "NWGENT";

        /// <summary>
        /// NWICUT.
        /// </summary>
        public const string NWICUT = "NWICUT";

        /// <summary>
        /// NWICU.
        /// </summary>
        public const string NWICU = "NWICU";

        /// <summary>
        /// NWDIC.
        /// </summary>
        public const string NWDIC = "NWDIC";

        /// <summary>
        /// NWUSR0.
        /// </summary>
        public const string NWUSR0 = "NWUSR0";

        /// <summary>
        /// NWURCD.
        /// </summary>
        public const string NWURCD = "NWURCD";

        /// <summary>
        /// NWURDT.
        /// </summary>
        public const string NWURDT = "NWURDT";

        /// <summary>
        /// NWURAT.
        /// </summary>
        public const string NWURAT = "NWURAT";

        /// <summary>
        /// NWURAB.
        /// </summary>
        public const string NWURAB = "NWURAB";

        /// <summary>
        /// NWURRF.
        /// </summary>
        public const string NWURRF = "NWURRF";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1511B1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWGENT", "NWGENT", JdeDataType.String, 2, true, true),
        new JdeField("NWICUT", "NWICUT", JdeDataType.String, 4, true, true),
        new JdeField("NWICU", "NWICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NWDIC", "NWDIC", JdeDataType.Numeric),
        new JdeField("NWUSR0", "NWUSR0", JdeDataType.String, 20),
        new JdeField("NWURCD", "NWURCD", JdeDataType.String, 4),
        new JdeField("NWURDT", "NWURDT", JdeDataType.Numeric),
        new JdeField("NWURAT", "NWURAT", JdeDataType.Numeric),
        new JdeField("NWURAB", "NWURAB", JdeDataType.Numeric),
        new JdeField("NWURRF", "NWURRF", JdeDataType.String, 30),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1511B1_0", "Primary Key on NWGENT, NWICU, NWICUT", new[] { "NWGENT", "NWICU", "NWICUT" }, isUnique: true, isPrimaryKey: true)
    };
}
