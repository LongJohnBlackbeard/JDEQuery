using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW48 - .
/// </summary>
public class FCW48 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHKIT.
        /// </summary>
        public const string BHKIT = "BHKIT";

        /// <summary>
        /// BHMMCU.
        /// </summary>
        public const string BHMMCU = "BHMMCU";

        /// <summary>
        /// BHTBM.
        /// </summary>
        public const string BHTBM = "BHTBM";

        /// <summary>
        /// BHBQTY.
        /// </summary>
        public const string BHBQTY = "BHBQTY";

        /// <summary>
        /// BHITM.
        /// </summary>
        public const string BHITM = "BHITM";

        /// <summary>
        /// BHUSER.
        /// </summary>
        public const string BHUSER = "BHUSER";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";

        /// <summary>
        /// BHJOBN.
        /// </summary>
        public const string BHJOBN = "BHJOBN";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHTDAY.
        /// </summary>
        public const string BHTDAY = "BHTDAY";

        /// <summary>
        /// BHC9STS.
        /// </summary>
        public const string BHC9STS = "BHC9STS";

        /// <summary>
        /// BHQTY.
        /// </summary>
        public const string BHQTY = "BHQTY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW48";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHKIT", "BHKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BHMMCU", "BHMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BHTBM", "BHTBM", JdeDataType.String, 6, true, true),
        new JdeField("BHBQTY", "BHBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BHITM", "BHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHJOBN", "BHJOBN", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHTDAY", "BHTDAY", JdeDataType.Numeric),
        new JdeField("BHC9STS", "BHC9STS", JdeDataType.String, 2),
        new JdeField("BHQTY", "BHQTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW48_0", "Primary Key on BHKIT, BHMMCU, BHTBM, BHBQTY, BHITM", new[] { "BHKIT", "BHMMCU", "BHTBM", "BHBQTY", "BHITM" }, isUnique: true, isPrimaryKey: true)
    };
}
