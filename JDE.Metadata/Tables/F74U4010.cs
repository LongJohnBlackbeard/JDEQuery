using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4010 - .
/// </summary>
public class F74U4010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIU74LAN8.
        /// </summary>
        public const string SIU74LAN8 = "SIU74LAN8";

        /// <summary>
        /// SIU74UTR.
        /// </summary>
        public const string SIU74UTR = "SIU74UTR";

        /// <summary>
        /// SIUKCRN.
        /// </summary>
        public const string SIUKCRN = "SIUKCRN";

        /// <summary>
        /// SIUKNTIN.
        /// </summary>
        public const string SIUKNTIN = "SIUKNTIN";

        /// <summary>
        /// SIU74SCBT.
        /// </summary>
        public const string SIU74SCBT = "SIU74SCBT";

        /// <summary>
        /// SIUKACTF.
        /// </summary>
        public const string SIUKACTF = "SIUKACTF";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";

        /// <summary>
        /// SIJOBN.
        /// </summary>
        public const string SIJOBN = "SIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIU74LAN8", "SIU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SIU74UTR", "SIU74UTR", JdeDataType.Numeric),
        new JdeField("SIUKCRN", "SIUKCRN", JdeDataType.String, 16),
        new JdeField("SIUKNTIN", "SIUKNTIN", JdeDataType.String, 18),
        new JdeField("SIU74SCBT", "SIU74SCBT", JdeDataType.String, 2),
        new JdeField("SIUKACTF", "SIUKACTF", JdeDataType.Numeric),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4010_0", "Primary Key on SIU74LAN8", new[] { "SIU74LAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4010_3", "Index on SIU74UTR", new[] { "SIU74UTR" })
    };
}
