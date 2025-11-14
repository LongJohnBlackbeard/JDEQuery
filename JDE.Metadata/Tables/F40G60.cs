using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G60 - .
/// </summary>
public class F40G60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HSWOPID.
        /// </summary>
        public const string HSWOPID = "HSWOPID";

        /// <summary>
        /// HSWVID.
        /// </summary>
        public const string HSWVID = "HSWVID";

        /// <summary>
        /// HSHARDD.
        /// </summary>
        public const string HSHARDD = "HSHARDD";

        /// <summary>
        /// HSDELAB.
        /// </summary>
        public const string HSDELAB = "HSDELAB";

        /// <summary>
        /// HSRECVB.
        /// </summary>
        public const string HSRECVB = "HSRECVB";

        /// <summary>
        /// HSHARQTY.
        /// </summary>
        public const string HSHARQTY = "HSHARQTY";

        /// <summary>
        /// HSHAREA.
        /// </summary>
        public const string HSHAREA = "HSHAREA";

        /// <summary>
        /// HSQTYUOM.
        /// </summary>
        public const string HSQTYUOM = "HSQTYUOM";

        /// <summary>
        /// HSAREAUOM.
        /// </summary>
        public const string HSAREAUOM = "HSAREAUOM";

        /// <summary>
        /// HSURCD.
        /// </summary>
        public const string HSURCD = "HSURCD";

        /// <summary>
        /// HSURDT.
        /// </summary>
        public const string HSURDT = "HSURDT";

        /// <summary>
        /// HSURRF.
        /// </summary>
        public const string HSURRF = "HSURRF";

        /// <summary>
        /// HSURAB.
        /// </summary>
        public const string HSURAB = "HSURAB";

        /// <summary>
        /// HSURAT.
        /// </summary>
        public const string HSURAT = "HSURAT";

        /// <summary>
        /// HSUSER.
        /// </summary>
        public const string HSUSER = "HSUSER";

        /// <summary>
        /// HSPID.
        /// </summary>
        public const string HSPID = "HSPID";

        /// <summary>
        /// HSJOBN.
        /// </summary>
        public const string HSJOBN = "HSJOBN";

        /// <summary>
        /// HSTORG.
        /// </summary>
        public const string HSTORG = "HSTORG";

        /// <summary>
        /// HSUUPMJ.
        /// </summary>
        public const string HSUUPMJ = "HSUUPMJ";

        /// <summary>
        /// HSOWNFG.
        /// </summary>
        public const string HSOWNFG = "HSOWNFG";
    }

    /// <inheritdoc />
    public override string TableName => "F40G60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HSWOPID", "HSWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("HSWVID", "HSWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("HSHARDD", "HSHARDD", JdeDataType.Date),
        new JdeField("HSDELAB", "HSDELAB", JdeDataType.Numeric),
        new JdeField("HSRECVB", "HSRECVB", JdeDataType.String, 24),
        new JdeField("HSHARQTY", "HSHARQTY", JdeDataType.Numeric),
        new JdeField("HSHAREA", "HSHAREA", JdeDataType.Numeric),
        new JdeField("HSQTYUOM", "HSQTYUOM", JdeDataType.String, 4),
        new JdeField("HSAREAUOM", "HSAREAUOM", JdeDataType.String, 4),
        new JdeField("HSURCD", "HSURCD", JdeDataType.String, 4),
        new JdeField("HSURDT", "HSURDT", JdeDataType.Numeric),
        new JdeField("HSURRF", "HSURRF", JdeDataType.String, 30),
        new JdeField("HSURAB", "HSURAB", JdeDataType.Numeric),
        new JdeField("HSURAT", "HSURAT", JdeDataType.Numeric),
        new JdeField("HSUSER", "HSUSER", JdeDataType.String, 20),
        new JdeField("HSPID", "HSPID", JdeDataType.String, 20),
        new JdeField("HSJOBN", "HSJOBN", JdeDataType.String, 20),
        new JdeField("HSTORG", "HSTORG", JdeDataType.String, 20),
        new JdeField("HSUUPMJ", "HSUUPMJ", JdeDataType.Date),
        new JdeField("HSOWNFG", "HSOWNFG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G60_0", "Primary Key on HSWOPID, HSWVID", new[] { "HSWOPID", "HSWVID" }, isUnique: true, isPrimaryKey: true)
    };
}
