using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B42 - .
/// </summary>
public class F03B42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDATC.
        /// </summary>
        public const string RDATC = "RDATC";

        /// <summary>
        /// RDDL01.
        /// </summary>
        public const string RDDL01 = "RDDL01";

        /// <summary>
        /// RDRSCO.
        /// </summary>
        public const string RDRSCO = "RDRSCO";

        /// <summary>
        /// RDECBR.
        /// </summary>
        public const string RDECBR = "RDECBR";

        /// <summary>
        /// RDATD.
        /// </summary>
        public const string RDATD = "RDATD";

        /// <summary>
        /// RDCRVC.
        /// </summary>
        public const string RDCRVC = "RDCRVC";

        /// <summary>
        /// RDCDNC.
        /// </summary>
        public const string RDCDNC = "RDCDNC";

        /// <summary>
        /// RDDCMC.
        /// </summary>
        public const string RDDCMC = "RDDCMC";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDDRCO.
        /// </summary>
        public const string RDDRCO = "RDDRCO";
    }

    /// <inheritdoc />
    public override string TableName => "F03B42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDATC", "RDATC", JdeDataType.String, 4, true, true),
        new JdeField("RDDL01", "RDDL01", JdeDataType.String, 60),
        new JdeField("RDRSCO", "RDRSCO", JdeDataType.String, 4),
        new JdeField("RDECBR", "RDECBR", JdeDataType.String, 4),
        new JdeField("RDATD", "RDATD", JdeDataType.Numeric),
        new JdeField("RDCRVC", "RDCRVC", JdeDataType.String, 2),
        new JdeField("RDCDNC", "RDCDNC", JdeDataType.String, 2),
        new JdeField("RDDCMC", "RDDCMC", JdeDataType.String, 2),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDDRCO", "RDDRCO", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B42_0", "Primary Key on RDATC", new[] { "RDATC" }, isUnique: true, isPrimaryKey: true)
    };
}
