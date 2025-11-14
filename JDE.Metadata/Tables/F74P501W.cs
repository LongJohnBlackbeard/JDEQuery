using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P501W - .
/// </summary>
public class F74P501W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWDOC.
        /// </summary>
        public const string SWDOC = "SWDOC";

        /// <summary>
        /// SWDCT.
        /// </summary>
        public const string SWDCT = "SWDCT";

        /// <summary>
        /// SWKCO.
        /// </summary>
        public const string SWKCO = "SWKCO";

        /// <summary>
        /// SWSFX.
        /// </summary>
        public const string SWSFX = "SWSFX";

        /// <summary>
        /// SWFFU2.
        /// </summary>
        public const string SWFFU2 = "SWFFU2";

        /// <summary>
        /// SWUKID.
        /// </summary>
        public const string SWUKID = "SWUKID";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";

        /// <summary>
        /// SWDATF01.
        /// </summary>
        public const string SWDATF01 = "SWDATF01";

        /// <summary>
        /// SWDEPFUT2.
        /// </summary>
        public const string SWDEPFUT2 = "SWDEPFUT2";

        /// <summary>
        /// SWACTFU1.
        /// </summary>
        public const string SWACTFU1 = "SWACTFU1";

        /// <summary>
        /// SWFLAG.
        /// </summary>
        public const string SWFLAG = "SWFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F74P501W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWDOC", "SWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDCT", "SWDCT", JdeDataType.String, 4, true, true),
        new JdeField("SWKCO", "SWKCO", JdeDataType.String, 10, true, true),
        new JdeField("SWSFX", "SWSFX", JdeDataType.String, 6, true, true),
        new JdeField("SWFFU2", "SWFFU2", JdeDataType.String, 2),
        new JdeField("SWUKID", "SWUKID", JdeDataType.Numeric),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric),
        new JdeField("SWDATF01", "SWDATF01", JdeDataType.Numeric),
        new JdeField("SWDEPFUT2", "SWDEPFUT2", JdeDataType.String, 60),
        new JdeField("SWACTFU1", "SWACTFU1", JdeDataType.String, 2),
        new JdeField("SWFLAG", "SWFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P501W_0", "Primary Key on SWDOC, SWDCT, SWKCO, SWSFX", new[] { "SWDOC", "SWDCT", "SWKCO", "SWSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
