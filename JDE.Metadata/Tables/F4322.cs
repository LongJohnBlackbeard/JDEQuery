using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4322 - .
/// </summary>
public class F4322 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PZFNTY.
        /// </summary>
        public const string PZFNTY = "PZFNTY";

        /// <summary>
        /// PZITM.
        /// </summary>
        public const string PZITM = "PZITM";

        /// <summary>
        /// PZPRP1.
        /// </summary>
        public const string PZPRP1 = "PZPRP1";

        /// <summary>
        /// PZCO.
        /// </summary>
        public const string PZCO = "PZCO";

        /// <summary>
        /// PZCDCD.
        /// </summary>
        public const string PZCDCD = "PZCDCD";

        /// <summary>
        /// PZRPQT.
        /// </summary>
        public const string PZRPQT = "PZRPQT";

        /// <summary>
        /// PZRUQT.
        /// </summary>
        public const string PZRUQT = "PZRUQT";

        /// <summary>
        /// PZRPPR.
        /// </summary>
        public const string PZRPPR = "PZRPPR";

        /// <summary>
        /// PZRUAT.
        /// </summary>
        public const string PZRUAT = "PZRUAT";

        /// <summary>
        /// PZMPPR.
        /// </summary>
        public const string PZMPPR = "PZMPPR";

        /// <summary>
        /// PZMUAT.
        /// </summary>
        public const string PZMUAT = "PZMUAT";

        /// <summary>
        /// PZMPQT.
        /// </summary>
        public const string PZMPQT = "PZMPQT";

        /// <summary>
        /// PZMUQT.
        /// </summary>
        public const string PZMUQT = "PZMUQT";

        /// <summary>
        /// PZBCRC.
        /// </summary>
        public const string PZBCRC = "PZBCRC";
    }

    /// <inheritdoc />
    public override string TableName => "F4322";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PZFNTY", "PZFNTY", JdeDataType.String, 2, true, true),
        new JdeField("PZITM", "PZITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PZPRP1", "PZPRP1", JdeDataType.String, 6, true, true),
        new JdeField("PZCO", "PZCO", JdeDataType.String, 10, true, true),
        new JdeField("PZCDCD", "PZCDCD", JdeDataType.String, 30),
        new JdeField("PZRPQT", "PZRPQT", JdeDataType.Numeric),
        new JdeField("PZRUQT", "PZRUQT", JdeDataType.Numeric),
        new JdeField("PZRPPR", "PZRPPR", JdeDataType.Numeric),
        new JdeField("PZRUAT", "PZRUAT", JdeDataType.Numeric),
        new JdeField("PZMPPR", "PZMPPR", JdeDataType.Numeric),
        new JdeField("PZMUAT", "PZMUAT", JdeDataType.Numeric),
        new JdeField("PZMPQT", "PZMPQT", JdeDataType.Numeric),
        new JdeField("PZMUQT", "PZMUQT", JdeDataType.Numeric),
        new JdeField("PZBCRC", "PZBCRC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4322_0", "Primary Key on PZFNTY, PZITM, PZPRP1, PZCO", new[] { "PZFNTY", "PZITM", "PZPRP1", "PZCO" }, isUnique: true, isPrimaryKey: true)
    };
}
