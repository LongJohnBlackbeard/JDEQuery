using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99099 - .
/// </summary>
public class F99099 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSOBNM.
        /// </summary>
        public const string FSOBNM = "FSOBNM";

        /// <summary>
        /// FSCTRLID.
        /// </summary>
        public const string FSCTRLID = "FSCTRLID";

        /// <summary>
        /// FSGNCID1.
        /// </summary>
        public const string FSGNCID1 = "FSGNCID1";

        /// <summary>
        /// FSMD.
        /// </summary>
        public const string FSMD = "FSMD";

        /// <summary>
        /// FSSY.
        /// </summary>
        public const string FSSY = "FSSY";

        /// <summary>
        /// FSAPPLID.
        /// </summary>
        public const string FSAPPLID = "FSAPPLID";

        /// <summary>
        /// FSDSCR.
        /// </summary>
        public const string FSDSCR = "FSDSCR";

        /// <summary>
        /// FSDTAI.
        /// </summary>
        public const string FSDTAI = "FSDTAI";

        /// <summary>
        /// FSDDID.
        /// </summary>
        public const string FSDDID = "FSDDID";

        /// <summary>
        /// FSVERS.
        /// </summary>
        public const string FSVERS = "FSVERS";

        /// <summary>
        /// FSFMNM.
        /// </summary>
        public const string FSFMNM = "FSFMNM";

        /// <summary>
        /// FSFMID.
        /// </summary>
        public const string FSFMID = "FSFMID";

        /// <summary>
        /// FSPID.
        /// </summary>
        public const string FSPID = "FSPID";

        /// <summary>
        /// FSDSCA.
        /// </summary>
        public const string FSDSCA = "FSDSCA";
    }

    /// <inheritdoc />
    public override string TableName => "F99099";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSOBNM", "FSOBNM", JdeDataType.String, 20, true, true),
        new JdeField("FSCTRLID", "FSCTRLID", JdeDataType.Numeric, null, true, true),
        new JdeField("FSGNCID1", "FSGNCID1", JdeDataType.Numeric, null, true, true),
        new JdeField("FSMD", "FSMD", JdeDataType.String, 120),
        new JdeField("FSSY", "FSSY", JdeDataType.String, 8),
        new JdeField("FSAPPLID", "FSAPPLID", JdeDataType.Numeric),
        new JdeField("FSDSCR", "FSDSCR", JdeDataType.String, 80),
        new JdeField("FSDTAI", "FSDTAI", JdeDataType.String, 20),
        new JdeField("FSDDID", "FSDDID", JdeDataType.Numeric),
        new JdeField("FSVERS", "FSVERS", JdeDataType.String, 20),
        new JdeField("FSFMNM", "FSFMNM", JdeDataType.String, 20),
        new JdeField("FSFMID", "FSFMID", JdeDataType.Numeric),
        new JdeField("FSPID", "FSPID", JdeDataType.String, 20),
        new JdeField("FSDSCA", "FSDSCA", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99099_0", "Primary Key on FSOBNM, FSCTRLID, FSGNCID1", new[] { "FSOBNM", "FSCTRLID", "FSGNCID1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F99099_4", "Index on FSPID, FSVERS", new[] { "FSPID", "FSVERS" })
    };
}
