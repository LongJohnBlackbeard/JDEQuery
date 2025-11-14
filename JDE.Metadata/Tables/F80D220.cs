using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D220 - .
/// </summary>
public class F80D220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INPRDJ.
        /// </summary>
        public const string INPRDJ = "INPRDJ";

        /// <summary>
        /// INMCU.
        /// </summary>
        public const string INMCU = "INMCU";

        /// <summary>
        /// INITM.
        /// </summary>
        public const string INITM = "INITM";

        /// <summary>
        /// INCOGS.
        /// </summary>
        public const string INCOGS = "INCOGS";

        /// <summary>
        /// INPDSI.
        /// </summary>
        public const string INPDSI = "INPDSI";

        /// <summary>
        /// INITU.
        /// </summary>
        public const string INITU = "INITU";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INMKEY.
        /// </summary>
        public const string INMKEY = "INMKEY";

        /// <summary>
        /// INUTIME.
        /// </summary>
        public const string INUTIME = "INUTIME";

        /// <summary>
        /// INURCD.
        /// </summary>
        public const string INURCD = "INURCD";

        /// <summary>
        /// INURDT.
        /// </summary>
        public const string INURDT = "INURDT";

        /// <summary>
        /// INURAT.
        /// </summary>
        public const string INURAT = "INURAT";

        /// <summary>
        /// INURAB.
        /// </summary>
        public const string INURAB = "INURAB";

        /// <summary>
        /// INURRF.
        /// </summary>
        public const string INURRF = "INURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INPRDJ", "INPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("INMCU", "INMCU", JdeDataType.String, 24, true, true),
        new JdeField("INITM", "INITM", JdeDataType.Numeric, null, true, true),
        new JdeField("INCOGS", "INCOGS", JdeDataType.Numeric),
        new JdeField("INPDSI", "INPDSI", JdeDataType.Numeric),
        new JdeField("INITU", "INITU", JdeDataType.Numeric),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INMKEY", "INMKEY", JdeDataType.String, 30),
        new JdeField("INUTIME", "INUTIME", JdeDataType.Date),
        new JdeField("INURCD", "INURCD", JdeDataType.String, 4),
        new JdeField("INURDT", "INURDT", JdeDataType.Numeric),
        new JdeField("INURAT", "INURAT", JdeDataType.Numeric),
        new JdeField("INURAB", "INURAB", JdeDataType.Numeric),
        new JdeField("INURRF", "INURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D220_0", "Primary Key on INPRDJ, INMCU, INITM", new[] { "INPRDJ", "INMCU", "INITM" }, isUnique: true, isPrimaryKey: true)
    };
}
