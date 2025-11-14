using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX09 - .
/// </summary>
public class FY5AHX09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDY5AHE1RL.
        /// </summary>
        public const string SDY5AHE1RL = "SDY5AHE1RL";

        /// <summary>
        /// SDY5AHMDID.
        /// </summary>
        public const string SDY5AHMDID = "SDY5AHMDID";

        /// <summary>
        /// SDY5AHRLID.
        /// </summary>
        public const string SDY5AHRLID = "SDY5AHRLID";

        /// <summary>
        /// SDY5AHITEM.
        /// </summary>
        public const string SDY5AHITEM = "SDY5AHITEM";

        /// <summary>
        /// SDY5AHVSNM.
        /// </summary>
        public const string SDY5AHVSNM = "SDY5AHVSNM";

        /// <summary>
        /// SDY5AHICFG.
        /// </summary>
        public const string SDY5AHICFG = "SDY5AHICFG";

        /// <summary>
        /// SDY5AHOTYP.
        /// </summary>
        public const string SDY5AHOTYP = "SDY5AHOTYP";

        /// <summary>
        /// SDY5AHLGOP.
        /// </summary>
        public const string SDY5AHLGOP = "SDY5AHLGOP";

        /// <summary>
        /// SDOBNM.
        /// </summary>
        public const string SDOBNM = "SDOBNM";

        /// <summary>
        /// SDY5AHSQNO.
        /// </summary>
        public const string SDY5AHSQNO = "SDY5AHSQNO";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AHX09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHRLID", "SDY5AHRLID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHITEM", "SDY5AHITEM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHVSNM", "SDY5AHVSNM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHICFG", "SDY5AHICFG", JdeDataType.String, 2),
        new JdeField("SDY5AHOTYP", "SDY5AHOTYP", JdeDataType.String, 8),
        new JdeField("SDY5AHLGOP", "SDY5AHLGOP", JdeDataType.String, 2),
        new JdeField("SDOBNM", "SDOBNM", JdeDataType.String, 20),
        new JdeField("SDY5AHSQNO", "SDY5AHSQNO", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX09_0", "Primary Key on SDY5AHE1RL, SDY5AHMDID, SDY5AHRLID, SDY5AHITEM, SDY5AHVSNM", new[] { "SDY5AHE1RL", "SDY5AHMDID", "SDY5AHRLID", "SDY5AHITEM", "SDY5AHVSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
