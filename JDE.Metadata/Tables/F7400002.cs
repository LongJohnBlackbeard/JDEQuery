using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400002 - .
/// </summary>
public class F7400002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDK74LEDT.
        /// </summary>
        public const string LDK74LEDT = "LDK74LEDT";

        /// <summary>
        /// LDDL01.
        /// </summary>
        public const string LDDL01 = "LDDL01";

        /// <summary>
        /// LDK74LDTG.
        /// </summary>
        public const string LDK74LDTG = "LDK74LDTG";

        /// <summary>
        /// LDK74CTAX.
        /// </summary>
        public const string LDK74CTAX = "LDK74CTAX";

        /// <summary>
        /// LDK74DTAX.
        /// </summary>
        public const string LDK74DTAX = "LDK74DTAX";

        /// <summary>
        /// LDK74ONEP.
        /// </summary>
        public const string LDK74ONEP = "LDK74ONEP";

        /// <summary>
        /// LDK74PTB.
        /// </summary>
        public const string LDK74PTB = "LDK74PTB";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7400002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDK74LEDT", "LDK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("LDDL01", "LDDL01", JdeDataType.String, 60),
        new JdeField("LDK74LDTG", "LDK74LDTG", JdeDataType.String, 4),
        new JdeField("LDK74CTAX", "LDK74CTAX", JdeDataType.String, 2),
        new JdeField("LDK74DTAX", "LDK74DTAX", JdeDataType.String, 2),
        new JdeField("LDK74ONEP", "LDK74ONEP", JdeDataType.String, 2),
        new JdeField("LDK74PTB", "LDK74PTB", JdeDataType.String, 2),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400002_0", "Primary Key on LDK74LEDT", new[] { "LDK74LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
