using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW105 - .
/// </summary>
public class FCW105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFC9CMRL.
        /// </summary>
        public const string WFC9CMRL = "WFC9CMRL";

        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFUORG.
        /// </summary>
        public const string WFUORG = "WFUORG";

        /// <summary>
        /// WFSOQS.
        /// </summary>
        public const string WFSOQS = "WFSOQS";

        /// <summary>
        /// WFRATE.
        /// </summary>
        public const string WFRATE = "WFRATE";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFCRDJ.
        /// </summary>
        public const string WFCRDJ = "WFCRDJ";

        /// <summary>
        /// WFTDAY.
        /// </summary>
        public const string WFTDAY = "WFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFC9CMRL", "WFC9CMRL", JdeDataType.String, 20, true, true),
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFUORG", "WFUORG", JdeDataType.Numeric),
        new JdeField("WFSOQS", "WFSOQS", JdeDataType.Numeric),
        new JdeField("WFRATE", "WFRATE", JdeDataType.Numeric),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFCRDJ", "WFCRDJ", JdeDataType.Numeric),
        new JdeField("WFTDAY", "WFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW105_0", "Primary Key on WFC9CMRL, WFITM, WFMCU", new[] { "WFC9CMRL", "WFITM", "WFMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
