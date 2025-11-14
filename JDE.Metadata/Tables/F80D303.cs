using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D303 - .
/// </summary>
public class F80D303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDMETRIC.
        /// </summary>
        public const string MDMETRIC = "MDMETRIC";

        /// <summary>
        /// MDSBC.
        /// </summary>
        public const string MDSBC = "MDSBC";

        /// <summary>
        /// MDPRETC.
        /// </summary>
        public const string MDPRETC = "MDPRETC";

        /// <summary>
        /// MDCHARTID.
        /// </summary>
        public const string MDCHARTID = "MDCHARTID";

        /// <summary>
        /// MDDFV.
        /// </summary>
        public const string MDDFV = "MDDFV";

        /// <summary>
        /// MDBEUP.
        /// </summary>
        public const string MDBEUP = "MDBEUP";

        /// <summary>
        /// MDAOD.
        /// </summary>
        public const string MDAOD = "MDAOD";

        /// <summary>
        /// MDANCD1.
        /// </summary>
        public const string MDANCD1 = "MDANCD1";

        /// <summary>
        /// MDANCD2.
        /// </summary>
        public const string MDANCD2 = "MDANCD2";

        /// <summary>
        /// MDANCD3.
        /// </summary>
        public const string MDANCD3 = "MDANCD3";

        /// <summary>
        /// MDCTD.
        /// </summary>
        public const string MDCTD = "MDCTD";

        /// <summary>
        /// MDGYN.
        /// </summary>
        public const string MDGYN = "MDGYN";

        /// <summary>
        /// MDDGYN.
        /// </summary>
        public const string MDDGYN = "MDDGYN";

        /// <summary>
        /// MDURCD.
        /// </summary>
        public const string MDURCD = "MDURCD";

        /// <summary>
        /// MDURDT.
        /// </summary>
        public const string MDURDT = "MDURDT";

        /// <summary>
        /// MDURAT.
        /// </summary>
        public const string MDURAT = "MDURAT";

        /// <summary>
        /// MDURAB.
        /// </summary>
        public const string MDURAB = "MDURAB";

        /// <summary>
        /// MDURRF.
        /// </summary>
        public const string MDURRF = "MDURRF";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDMKEY.
        /// </summary>
        public const string MDMKEY = "MDMKEY";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDUUPMJ.
        /// </summary>
        public const string MDUUPMJ = "MDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDMETRIC", "MDMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("MDSBC", "MDSBC", JdeDataType.String, 8),
        new JdeField("MDPRETC", "MDPRETC", JdeDataType.String, 2),
        new JdeField("MDCHARTID", "MDCHARTID", JdeDataType.String, 100),
        new JdeField("MDDFV", "MDDFV", JdeDataType.Numeric),
        new JdeField("MDBEUP", "MDBEUP", JdeDataType.Numeric),
        new JdeField("MDAOD", "MDAOD", JdeDataType.Date),
        new JdeField("MDANCD1", "MDANCD1", JdeDataType.String, 20),
        new JdeField("MDANCD2", "MDANCD2", JdeDataType.String, 20),
        new JdeField("MDANCD3", "MDANCD3", JdeDataType.String, 20),
        new JdeField("MDCTD", "MDCTD", JdeDataType.Numeric),
        new JdeField("MDGYN", "MDGYN", JdeDataType.Numeric),
        new JdeField("MDDGYN", "MDDGYN", JdeDataType.Numeric),
        new JdeField("MDURCD", "MDURCD", JdeDataType.String, 4),
        new JdeField("MDURDT", "MDURDT", JdeDataType.Numeric),
        new JdeField("MDURAT", "MDURAT", JdeDataType.Numeric),
        new JdeField("MDURAB", "MDURAB", JdeDataType.Numeric),
        new JdeField("MDURRF", "MDURRF", JdeDataType.String, 30),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDMKEY", "MDMKEY", JdeDataType.String, 30),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDUUPMJ", "MDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D303_0", "Primary Key on MDMETRIC", new[] { "MDMETRIC" }, isUnique: true, isPrimaryKey: true)
    };
}
