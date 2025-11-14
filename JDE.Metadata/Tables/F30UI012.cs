using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI012 - .
/// </summary>
public class F30UI012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPEID.
        /// </summary>
        public const string PCPEID = "PCPEID";

        /// <summary>
        /// PCJOBS.
        /// </summary>
        public const string PCJOBS = "PCJOBS";

        /// <summary>
        /// PCCMCU.
        /// </summary>
        public const string PCCMCU = "PCCMCU";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCMMCU.
        /// </summary>
        public const string PCMMCU = "PCMMCU";

        /// <summary>
        /// PCKIT.
        /// </summary>
        public const string PCKIT = "PCKIT";

        /// <summary>
        /// PCOPSQ.
        /// </summary>
        public const string PCOPSQ = "PCOPSQ";

        /// <summary>
        /// PCCPNB.
        /// </summary>
        public const string PCCPNB = "PCCPNB";

        /// <summary>
        /// PCBQTY.
        /// </summary>
        public const string PCBQTY = "PCBQTY";

        /// <summary>
        /// PCQNTY.
        /// </summary>
        public const string PCQNTY = "PCQNTY";

        /// <summary>
        /// PCUOM.
        /// </summary>
        public const string PCUOM = "PCUOM";

        /// <summary>
        /// PCUOM1.
        /// </summary>
        public const string PCUOM1 = "PCUOM1";

        /// <summary>
        /// PCFORQ.
        /// </summary>
        public const string PCFORQ = "PCFORQ";

        /// <summary>
        /// PCSCRP.
        /// </summary>
        public const string PCSCRP = "PCSCRP";

        /// <summary>
        /// PCSTPP.
        /// </summary>
        public const string PCSTPP = "PCSTPP";

        /// <summary>
        /// PCKITL.
        /// </summary>
        public const string PCKITL = "PCKITL";

        /// <summary>
        /// PCKITA.
        /// </summary>
        public const string PCKITA = "PCKITA";

        /// <summary>
        /// PCF$RP.
        /// </summary>
        public const string PCF_RP = "PCF$RP";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCCWC.
        /// </summary>
        public const string PCCWC = "PCCWC";

        /// <summary>
        /// PCQNTY9.
        /// </summary>
        public const string PCQNTY9 = "PCQNTY9";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20, true, true),
        new JdeField("PCPEID", "PCPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCJOBS", "PCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCMCU", "PCCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCMMCU", "PCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCKIT", "PCKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("PCOPSQ", "PCOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCPNB", "PCCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("PCBQTY", "PCBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("PCQNTY", "PCQNTY", JdeDataType.Numeric),
        new JdeField("PCUOM", "PCUOM", JdeDataType.String, 4),
        new JdeField("PCUOM1", "PCUOM1", JdeDataType.String, 4),
        new JdeField("PCFORQ", "PCFORQ", JdeDataType.String, 2),
        new JdeField("PCSCRP", "PCSCRP", JdeDataType.Numeric),
        new JdeField("PCSTPP", "PCSTPP", JdeDataType.Numeric),
        new JdeField("PCKITL", "PCKITL", JdeDataType.String, 50),
        new JdeField("PCKITA", "PCKITA", JdeDataType.String, 50),
        new JdeField("PCF$RP", "PCF$RP", JdeDataType.Numeric),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24),
        new JdeField("PCCWC", "PCCWC", JdeDataType.String, 2),
        new JdeField("PCQNTY9", "PCQNTY9", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI012_0", "Primary Key on PCPEID, PCUSER, PCJOBS, PCCMCU, PCITM, PCMMCU, PCOPSQ, PCKIT, PCCPNB, PCBQTY", new[] { "PCPEID", "PCUSER", "PCJOBS", "PCCMCU", "PCITM", "PCMMCU", "PCOPSQ", "PCKIT", "PCCPNB", "PCBQTY" }, isUnique: true, isPrimaryKey: true)
    };
}
