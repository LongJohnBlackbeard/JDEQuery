using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D114 - .
/// </summary>
public class F80D114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMGRID.
        /// </summary>
        public const string GMGRID = "GMGRID";

        /// <summary>
        /// GMDESCGR.
        /// </summary>
        public const string GMDESCGR = "GMDESCGR";

        /// <summary>
        /// GMPRCSID.
        /// </summary>
        public const string GMPRCSID = "GMPRCSID";

        /// <summary>
        /// GMDTCRTD.
        /// </summary>
        public const string GMDTCRTD = "GMDTCRTD";

        /// <summary>
        /// GMUSER.
        /// </summary>
        public const string GMUSER = "GMUSER";

        /// <summary>
        /// GMPID.
        /// </summary>
        public const string GMPID = "GMPID";

        /// <summary>
        /// GMMKEY.
        /// </summary>
        public const string GMMKEY = "GMMKEY";

        /// <summary>
        /// GMUTIME.
        /// </summary>
        public const string GMUTIME = "GMUTIME";

        /// <summary>
        /// GMURCD.
        /// </summary>
        public const string GMURCD = "GMURCD";

        /// <summary>
        /// GMURDT.
        /// </summary>
        public const string GMURDT = "GMURDT";

        /// <summary>
        /// GMURAB.
        /// </summary>
        public const string GMURAB = "GMURAB";

        /// <summary>
        /// GMURRF.
        /// </summary>
        public const string GMURRF = "GMURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMGRID", "GMGRID", JdeDataType.String, 40, true, true),
        new JdeField("GMDESCGR", "GMDESCGR", JdeDataType.String, 60),
        new JdeField("GMPRCSID", "GMPRCSID", JdeDataType.String, 40, true, true),
        new JdeField("GMDTCRTD", "GMDTCRTD", JdeDataType.Numeric),
        new JdeField("GMUSER", "GMUSER", JdeDataType.String, 20),
        new JdeField("GMPID", "GMPID", JdeDataType.String, 20),
        new JdeField("GMMKEY", "GMMKEY", JdeDataType.String, 30),
        new JdeField("GMUTIME", "GMUTIME", JdeDataType.Date),
        new JdeField("GMURCD", "GMURCD", JdeDataType.String, 4),
        new JdeField("GMURDT", "GMURDT", JdeDataType.Numeric),
        new JdeField("GMURAB", "GMURAB", JdeDataType.Numeric),
        new JdeField("GMURRF", "GMURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D114_0", "Primary Key on GMGRID, GMPRCSID", new[] { "GMGRID", "GMPRCSID" }, isUnique: true, isPrimaryKey: true)
    };
}
