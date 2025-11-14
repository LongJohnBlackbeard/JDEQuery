using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0041Z1 - .
/// </summary>
public class F0041Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZFCTID.
        /// </summary>
        public const string ZFCTID = "ZFCTID";

        /// <summary>
        /// ZFUSER.
        /// </summary>
        public const string ZFUSER = "ZFUSER";

        /// <summary>
        /// ZFTRNM.
        /// </summary>
        public const string ZFTRNM = "ZFTRNM";

        /// <summary>
        /// ZFTRNY.
        /// </summary>
        public const string ZFTRNY = "ZFTRNY";

        /// <summary>
        /// ZFTRNK.
        /// </summary>
        public const string ZFTRNK = "ZFTRNK";

        /// <summary>
        /// ZFPID.
        /// </summary>
        public const string ZFPID = "ZFPID";

        /// <summary>
        /// ZFSERK.
        /// </summary>
        public const string ZFSERK = "ZFSERK";

        /// <summary>
        /// ZFAPVC.
        /// </summary>
        public const string ZFAPVC = "ZFAPVC";

        /// <summary>
        /// ZFTSC.
        /// </summary>
        public const string ZFTSC = "ZFTSC";

        /// <summary>
        /// ZFCNF.
        /// </summary>
        public const string ZFCNF = "ZFCNF";

        /// <summary>
        /// ZFUPTY.
        /// </summary>
        public const string ZFUPTY = "ZFUPTY";
    }

    /// <inheritdoc />
    public override string TableName => "F0041Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZFCTID", "ZFCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZFUSER", "ZFUSER", JdeDataType.String, 20, true, true),
        new JdeField("ZFTRNM", "ZFTRNM", JdeDataType.String, 30, true, true),
        new JdeField("ZFTRNY", "ZFTRNY", JdeDataType.String, 4, true, true),
        new JdeField("ZFTRNK", "ZFTRNK", JdeDataType.String, 44, true, true),
        new JdeField("ZFPID", "ZFPID", JdeDataType.String, 20, true, true),
        new JdeField("ZFSERK", "ZFSERK", JdeDataType.Numeric),
        new JdeField("ZFAPVC", "ZFAPVC", JdeDataType.String, 2),
        new JdeField("ZFTSC", "ZFTSC", JdeDataType.String, 2),
        new JdeField("ZFCNF", "ZFCNF", JdeDataType.String, 2),
        new JdeField("ZFUPTY", "ZFUPTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0041Z1_0", "Primary Key on ZFCTID, ZFUSER, ZFTRNM, ZFTRNY, ZFTRNK, ZFPID", new[] { "ZFCTID", "ZFUSER", "ZFTRNM", "ZFTRNY", "ZFTRNK", "ZFPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0041Z1_2", "Index on ZFSERK, ZFTRNM", new[] { "ZFSERK", "ZFTRNM" }),
        new JdeIndex("F0041Z1_3", "Index on ZFCTID, ZFTRNM, ZFTRNY, ZFTRNK, ZFPID", new[] { "ZFCTID", "ZFTRNM", "ZFTRNY", "ZFTRNK", "ZFPID" }),
        new JdeIndex("F0041Z1_5", "Index on ZFTRNK, ZFTRNY, ZFTRNM", new[] { "ZFTRNK", "ZFTRNY", "ZFTRNM" })
    };
}
