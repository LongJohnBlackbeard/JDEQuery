using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4722 - .
/// </summary>
public class F4722 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PZEDST.
        /// </summary>
        public const string PZEDST = "PZEDST";

        /// <summary>
        /// PZAN8.
        /// </summary>
        public const string PZAN8 = "PZAN8";

        /// <summary>
        /// PZEDER.
        /// </summary>
        public const string PZEDER = "PZEDER";

        /// <summary>
        /// PZCO.
        /// </summary>
        public const string PZCO = "PZCO";

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
        /// PZDTOL.
        /// </summary>
        public const string PZDTOL = "PZDTOL";

        /// <summary>
        /// PZGAN8.
        /// </summary>
        public const string PZGAN8 = "PZGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F4722";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PZEDST", "PZEDST", JdeDataType.String, 12, true, true),
        new JdeField("PZAN8", "PZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PZEDER", "PZEDER", JdeDataType.String, 2, true, true),
        new JdeField("PZCO", "PZCO", JdeDataType.String, 10, true, true),
        new JdeField("PZRPQT", "PZRPQT", JdeDataType.Numeric),
        new JdeField("PZRUQT", "PZRUQT", JdeDataType.Numeric),
        new JdeField("PZRPPR", "PZRPPR", JdeDataType.Numeric),
        new JdeField("PZRUAT", "PZRUAT", JdeDataType.Numeric),
        new JdeField("PZMPPR", "PZMPPR", JdeDataType.Numeric),
        new JdeField("PZMUAT", "PZMUAT", JdeDataType.Numeric),
        new JdeField("PZDTOL", "PZDTOL", JdeDataType.Numeric),
        new JdeField("PZGAN8", "PZGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4722_0", "Primary Key on PZEDST, PZAN8, PZEDER, PZCO", new[] { "PZEDST", "PZAN8", "PZEDER", "PZCO" }, isUnique: true, isPrimaryKey: true)
    };
}
