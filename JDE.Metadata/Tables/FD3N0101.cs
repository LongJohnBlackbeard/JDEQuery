using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0101 - .
/// </summary>
public class FD3N0101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDDTI1.
        /// </summary>
        public const string PDDTI1 = "PDDTI1";

        /// <summary>
        /// PDWKDY.
        /// </summary>
        public const string PDWKDY = "PDWKDY";

        /// <summary>
        /// PDDYUD.
        /// </summary>
        public const string PDDYUD = "PDDYUD";

        /// <summary>
        /// PDBEG1.
        /// </summary>
        public const string PDBEG1 = "PDBEG1";

        /// <summary>
        /// PDBEG2.
        /// </summary>
        public const string PDBEG2 = "PDBEG2";

        /// <summary>
        /// PDBEG3.
        /// </summary>
        public const string PDBEG3 = "PDBEG3";

        /// <summary>
        /// PDBEG4.
        /// </summary>
        public const string PDBEG4 = "PDBEG4";

        /// <summary>
        /// PDBEG5.
        /// </summary>
        public const string PDBEG5 = "PDBEG5";

        /// <summary>
        /// PDBEG6.
        /// </summary>
        public const string PDBEG6 = "PDBEG6";

        /// <summary>
        /// PDECV1.
        /// </summary>
        public const string PDECV1 = "PDECV1";

        /// <summary>
        /// PDECV2.
        /// </summary>
        public const string PDECV2 = "PDECV2";

        /// <summary>
        /// PDECV3.
        /// </summary>
        public const string PDECV3 = "PDECV3";

        /// <summary>
        /// PDECV4.
        /// </summary>
        public const string PDECV4 = "PDECV4";

        /// <summary>
        /// PDECV5.
        /// </summary>
        public const string PDECV5 = "PDECV5";

        /// <summary>
        /// PDECV6.
        /// </summary>
        public const string PDECV6 = "PDECV6";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDDTI1", "PDDTI1", JdeDataType.String, 20, true, true),
        new JdeField("PDWKDY", "PDWKDY", JdeDataType.String, 2),
        new JdeField("PDDYUD", "PDDYUD", JdeDataType.Numeric, null, true, true),
        new JdeField("PDBEG1", "PDBEG1", JdeDataType.Numeric),
        new JdeField("PDBEG2", "PDBEG2", JdeDataType.Numeric),
        new JdeField("PDBEG3", "PDBEG3", JdeDataType.Numeric),
        new JdeField("PDBEG4", "PDBEG4", JdeDataType.Numeric),
        new JdeField("PDBEG5", "PDBEG5", JdeDataType.Numeric),
        new JdeField("PDBEG6", "PDBEG6", JdeDataType.Numeric),
        new JdeField("PDECV1", "PDECV1", JdeDataType.Numeric),
        new JdeField("PDECV2", "PDECV2", JdeDataType.Numeric),
        new JdeField("PDECV3", "PDECV3", JdeDataType.Numeric),
        new JdeField("PDECV4", "PDECV4", JdeDataType.Numeric),
        new JdeField("PDECV5", "PDECV5", JdeDataType.Numeric),
        new JdeField("PDECV6", "PDECV6", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0101_0", "Primary Key on PDDTI1, PDDYUD", new[] { "PDDTI1", "PDDYUD" }, isUnique: true, isPrimaryKey: true)
    };
}
