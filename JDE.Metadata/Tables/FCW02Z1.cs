using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW02Z1 - .
/// </summary>
public class FCW02Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAC9STRC.
        /// </summary>
        public const string RAC9STRC = "RAC9STRC";

        /// <summary>
        /// RAC9LVNO.
        /// </summary>
        public const string RAC9LVNO = "RAC9LVNO";

        /// <summary>
        /// RAC9LVNM.
        /// </summary>
        public const string RAC9LVNM = "RAC9LVNM";

        /// <summary>
        /// RAITM.
        /// </summary>
        public const string RAITM = "RAITM";

        /// <summary>
        /// RAC9LVCO.
        /// </summary>
        public const string RAC9LVCO = "RAC9LVCO";

        /// <summary>
        /// RAC9PLNM.
        /// </summary>
        public const string RAC9PLNM = "RAC9PLNM";

        /// <summary>
        /// RAC9ITMP.
        /// </summary>
        public const string RAC9ITMP = "RAC9ITMP";

        /// <summary>
        /// RAC9LVL0.
        /// </summary>
        public const string RAC9LVL0 = "RAC9LVL0";

        /// <summary>
        /// RAC9LVL1.
        /// </summary>
        public const string RAC9LVL1 = "RAC9LVL1";

        /// <summary>
        /// RAC9LVL2.
        /// </summary>
        public const string RAC9LVL2 = "RAC9LVL2";

        /// <summary>
        /// RAC9LVL3.
        /// </summary>
        public const string RAC9LVL3 = "RAC9LVL3";

        /// <summary>
        /// RAC9LVL4.
        /// </summary>
        public const string RAC9LVL4 = "RAC9LVL4";

        /// <summary>
        /// RAC9LVL5.
        /// </summary>
        public const string RAC9LVL5 = "RAC9LVL5";

        /// <summary>
        /// RAC9LVL6.
        /// </summary>
        public const string RAC9LVL6 = "RAC9LVL6";

        /// <summary>
        /// RAC9LVL7.
        /// </summary>
        public const string RAC9LVL7 = "RAC9LVL7";

        /// <summary>
        /// RAC9LVL8.
        /// </summary>
        public const string RAC9LVL8 = "RAC9LVL8";

        /// <summary>
        /// RAC9LVL9.
        /// </summary>
        public const string RAC9LVL9 = "RAC9LVL9";

        /// <summary>
        /// RAC9STS.
        /// </summary>
        public const string RAC9STS = "RAC9STS";

        /// <summary>
        /// RAC9CAT1.
        /// </summary>
        public const string RAC9CAT1 = "RAC9CAT1";

        /// <summary>
        /// RAC9CAT2.
        /// </summary>
        public const string RAC9CAT2 = "RAC9CAT2";

        /// <summary>
        /// RAC9CAT3.
        /// </summary>
        public const string RAC9CAT3 = "RAC9CAT3";

        /// <summary>
        /// RAC9CAT4.
        /// </summary>
        public const string RAC9CAT4 = "RAC9CAT4";

        /// <summary>
        /// RAC9CAT5.
        /// </summary>
        public const string RAC9CAT5 = "RAC9CAT5";

        /// <summary>
        /// RAC9CAT6.
        /// </summary>
        public const string RAC9CAT6 = "RAC9CAT6";

        /// <summary>
        /// RAC9CAT7.
        /// </summary>
        public const string RAC9CAT7 = "RAC9CAT7";

        /// <summary>
        /// RACAT08.
        /// </summary>
        public const string RACAT08 = "RACAT08";

        /// <summary>
        /// RACAT09.
        /// </summary>
        public const string RACAT09 = "RACAT09";

        /// <summary>
        /// RACAT10.
        /// </summary>
        public const string RACAT10 = "RACAT10";
    }

    /// <inheritdoc />
    public override string TableName => "FCW02Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAC9STRC", "RAC9STRC", JdeDataType.String, 6),
        new JdeField("RAC9LVNO", "RAC9LVNO", JdeDataType.Numeric),
        new JdeField("RAC9LVNM", "RAC9LVNM", JdeDataType.String, 100, true, true),
        new JdeField("RAITM", "RAITM", JdeDataType.Numeric),
        new JdeField("RAC9LVCO", "RAC9LVCO", JdeDataType.String, 50),
        new JdeField("RAC9PLNM", "RAC9PLNM", JdeDataType.String, 100),
        new JdeField("RAC9ITMP", "RAC9ITMP", JdeDataType.Numeric),
        new JdeField("RAC9LVL0", "RAC9LVL0", JdeDataType.String, 50),
        new JdeField("RAC9LVL1", "RAC9LVL1", JdeDataType.String, 12),
        new JdeField("RAC9LVL2", "RAC9LVL2", JdeDataType.String, 12),
        new JdeField("RAC9LVL3", "RAC9LVL3", JdeDataType.String, 12),
        new JdeField("RAC9LVL4", "RAC9LVL4", JdeDataType.String, 12),
        new JdeField("RAC9LVL5", "RAC9LVL5", JdeDataType.String, 12),
        new JdeField("RAC9LVL6", "RAC9LVL6", JdeDataType.String, 12),
        new JdeField("RAC9LVL7", "RAC9LVL7", JdeDataType.String, 12),
        new JdeField("RAC9LVL8", "RAC9LVL8", JdeDataType.String, 12),
        new JdeField("RAC9LVL9", "RAC9LVL9", JdeDataType.String, 12),
        new JdeField("RAC9STS", "RAC9STS", JdeDataType.String, 2),
        new JdeField("RAC9CAT1", "RAC9CAT1", JdeDataType.String, 20),
        new JdeField("RAC9CAT2", "RAC9CAT2", JdeDataType.String, 20),
        new JdeField("RAC9CAT3", "RAC9CAT3", JdeDataType.String, 20),
        new JdeField("RAC9CAT4", "RAC9CAT4", JdeDataType.String, 20),
        new JdeField("RAC9CAT5", "RAC9CAT5", JdeDataType.String, 20),
        new JdeField("RAC9CAT6", "RAC9CAT6", JdeDataType.String, 20),
        new JdeField("RAC9CAT7", "RAC9CAT7", JdeDataType.String, 20),
        new JdeField("RACAT08", "RACAT08", JdeDataType.String, 6),
        new JdeField("RACAT09", "RACAT09", JdeDataType.String, 6),
        new JdeField("RACAT10", "RACAT10", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW02Z1_0", "Primary Key on RAC9LVNM", new[] { "RAC9LVNM" }, isUnique: true, isPrimaryKey: true)
    };
}
