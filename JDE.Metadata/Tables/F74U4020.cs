using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4020 - .
/// </summary>
public class F74U4020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSU74LAN8.
        /// </summary>
        public const string VSU74LAN8 = "VSU74LAN8";

        /// <summary>
        /// VSU74SCVN.
        /// </summary>
        public const string VSU74SCVN = "VSU74SCVN";

        /// <summary>
        /// VSU74SCMF.
        /// </summary>
        public const string VSU74SCMF = "VSU74SCMF";

        /// <summary>
        /// VSU74SCUD.
        /// </summary>
        public const string VSU74SCUD = "VSU74SCUD";

        /// <summary>
        /// VSU74SCDV.
        /// </summary>
        public const string VSU74SCDV = "VSU74SCDV";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSUPMT.
        /// </summary>
        public const string VSUPMT = "VSUPMT";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSU74LAN8", "VSU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VSU74SCVN", "VSU74SCVN", JdeDataType.String, 26),
        new JdeField("VSU74SCMF", "VSU74SCMF", JdeDataType.String, 2),
        new JdeField("VSU74SCUD", "VSU74SCUD", JdeDataType.Numeric),
        new JdeField("VSU74SCDV", "VSU74SCDV", JdeDataType.Numeric),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSUPMT", "VSUPMT", JdeDataType.Numeric),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4020_0", "Primary Key on VSU74LAN8", new[] { "VSU74LAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
