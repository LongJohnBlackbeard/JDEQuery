using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430050 - .
/// </summary>
public class F7430050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHUKID.
        /// </summary>
        public const string BHUKID = "BHUKID";

        /// <summary>
        /// BHK74LECO.
        /// </summary>
        public const string BHK74LECO = "BHK74LECO";

        /// <summary>
        /// BHK74LEDT.
        /// </summary>
        public const string BHK74LEDT = "BHK74LEDT";

        /// <summary>
        /// BHK74ISPL.
        /// </summary>
        public const string BHK74ISPL = "BHK74ISPL";

        /// <summary>
        /// BHK74PBST.
        /// </summary>
        public const string BHK74PBST = "BHK74PBST";

        /// <summary>
        /// BHTORG.
        /// </summary>
        public const string BHTORG = "BHTORG";

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
        /// BHUPMT.
        /// </summary>
        public const string BHUPMT = "BHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7430050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHUKID", "BHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BHK74LECO", "BHK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("BHK74LEDT", "BHK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("BHK74ISPL", "BHK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("BHK74PBST", "BHK74PBST", JdeDataType.String, 2),
        new JdeField("BHTORG", "BHTORG", JdeDataType.String, 20),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHJOBN", "BHJOBN", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430050_0", "Primary Key on BHUKID, BHK74LECO, BHK74LEDT, BHK74ISPL", new[] { "BHUKID", "BHK74LECO", "BHK74LEDT", "BHK74ISPL" }, isUnique: true, isPrimaryKey: true)
    };
}
