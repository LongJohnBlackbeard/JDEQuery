using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI95 - .
/// </summary>
public class F74UI95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHJOBS.
        /// </summary>
        public const string RHJOBS = "RHJOBS";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHE74RENA.
        /// </summary>
        public const string RHE74RENA = "RHE74RENA";

        /// <summary>
        /// RHE74RT01.
        /// </summary>
        public const string RHE74RT01 = "RHE74RT01";

        /// <summary>
        /// RHE74RT02.
        /// </summary>
        public const string RHE74RT02 = "RHE74RT02";

        /// <summary>
        /// RHE74PRFG.
        /// </summary>
        public const string RHE74PRFG = "RHE74PRFG";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHJOBS", "RHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHE74RENA", "RHE74RENA", JdeDataType.String, 40),
        new JdeField("RHE74RT01", "RHE74RT01", JdeDataType.String, 200),
        new JdeField("RHE74RT02", "RHE74RT02", JdeDataType.String, 200),
        new JdeField("RHE74PRFG", "RHE74PRFG", JdeDataType.String, 2),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI95_0", "Primary Key on RHJOBS", new[] { "RHJOBS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74UI95_2", "Index on RHE74RENA, RHUSER, SYS_NC00009$", new[] { "RHE74RENA", "RHUSER", "SYS_NC00009$" }),
        new JdeIndex("F74UI95_3", "Index on RHUSER, SYS_NC00009$", new[] { "RHUSER", "SYS_NC00009$" }),
        new JdeIndex("F74UI95_4", "Index on RHUSER, RHE74RENA, SYS_NC00010$, SYS_NC00011$", new[] { "RHUSER", "RHE74RENA", "SYS_NC00010$", "SYS_NC00011$" })
    };
}
