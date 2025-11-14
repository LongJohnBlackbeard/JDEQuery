using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0770 - .
/// </summary>
public class F76B0770 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICCO.
        /// </summary>
        public const string ICCO = "ICCO";

        /// <summary>
        /// ICADDS.
        /// </summary>
        public const string ICADDS = "ICADDS";

        /// <summary>
        /// ICCTRY.
        /// </summary>
        public const string ICCTRY = "ICCTRY";

        /// <summary>
        /// ICFY.
        /// </summary>
        public const string ICFY = "ICFY";

        /// <summary>
        /// ICPN.
        /// </summary>
        public const string ICPN = "ICPN";

        /// <summary>
        /// ICB76ICTP.
        /// </summary>
        public const string ICB76ICTP = "ICB76ICTP";

        /// <summary>
        /// ICB76ICST.
        /// </summary>
        public const string ICB76ICST = "ICB76ICST";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0770";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICCO", "ICCO", JdeDataType.String, 10, true, true),
        new JdeField("ICADDS", "ICADDS", JdeDataType.String, 6, true, true),
        new JdeField("ICCTRY", "ICCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ICFY", "ICFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ICPN", "ICPN", JdeDataType.Numeric, null, true, true),
        new JdeField("ICB76ICTP", "ICB76ICTP", JdeDataType.Numeric),
        new JdeField("ICB76ICST", "ICB76ICST", JdeDataType.Numeric),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0770_0", "Primary Key on ICCO, ICADDS, ICCTRY, ICFY, ICPN", new[] { "ICCO", "ICADDS", "ICCTRY", "ICFY", "ICPN" }, isUnique: true, isPrimaryKey: true)
    };
}
