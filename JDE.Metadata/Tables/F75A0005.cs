using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0005 - .
/// </summary>
public class F75A0005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A5AN8.
        /// </summary>
        public const string A5AN8 = "A5AN8";

        /// <summary>
        /// A5CKCN.
        /// </summary>
        public const string A5CKCN = "A5CKCN";

        /// <summary>
        /// A5PAAP.
        /// </summary>
        public const string A5PAAP = "A5PAAP";

        /// <summary>
        /// A5DTPD.
        /// </summary>
        public const string A5DTPD = "A5DTPD";

        /// <summary>
        /// A5NUMD1.
        /// </summary>
        public const string A5NUMD1 = "A5NUMD1";

        /// <summary>
        /// A5NUMD2.
        /// </summary>
        public const string A5NUMD2 = "A5NUMD2";

        /// <summary>
        /// A5NUMD5.
        /// </summary>
        public const string A5NUMD5 = "A5NUMD5";

        /// <summary>
        /// A5NUMD10.
        /// </summary>
        public const string A5NUMD10 = "A5NUMD10";

        /// <summary>
        /// A5NUMD20.
        /// </summary>
        public const string A5NUMD20 = "A5NUMD20";

        /// <summary>
        /// A5NUMD50.
        /// </summary>
        public const string A5NUMD50 = "A5NUMD50";

        /// <summary>
        /// A5NUMD100.
        /// </summary>
        public const string A5NUMD100 = "A5NUMD100";

        /// <summary>
        /// A5UPMJ.
        /// </summary>
        public const string A5UPMJ = "A5UPMJ";

        /// <summary>
        /// A5UPMT.
        /// </summary>
        public const string A5UPMT = "A5UPMT";

        /// <summary>
        /// A5PID.
        /// </summary>
        public const string A5PID = "A5PID";

        /// <summary>
        /// A5USER.
        /// </summary>
        public const string A5USER = "A5USER";

        /// <summary>
        /// A5JOBN.
        /// </summary>
        public const string A5JOBN = "A5JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A5AN8", "A5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A5CKCN", "A5CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("A5PAAP", "A5PAAP", JdeDataType.Numeric),
        new JdeField("A5DTPD", "A5DTPD", JdeDataType.Numeric),
        new JdeField("A5NUMD1", "A5NUMD1", JdeDataType.Numeric),
        new JdeField("A5NUMD2", "A5NUMD2", JdeDataType.Numeric),
        new JdeField("A5NUMD5", "A5NUMD5", JdeDataType.Numeric),
        new JdeField("A5NUMD10", "A5NUMD10", JdeDataType.Numeric),
        new JdeField("A5NUMD20", "A5NUMD20", JdeDataType.Numeric),
        new JdeField("A5NUMD50", "A5NUMD50", JdeDataType.Numeric),
        new JdeField("A5NUMD100", "A5NUMD100", JdeDataType.Numeric),
        new JdeField("A5UPMJ", "A5UPMJ", JdeDataType.Numeric),
        new JdeField("A5UPMT", "A5UPMT", JdeDataType.Numeric),
        new JdeField("A5PID", "A5PID", JdeDataType.String, 20),
        new JdeField("A5USER", "A5USER", JdeDataType.String, 20),
        new JdeField("A5JOBN", "A5JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0005_0", "Primary Key on A5AN8, A5CKCN", new[] { "A5AN8", "A5CKCN" }, isUnique: true, isPrimaryKey: true)
    };
}
