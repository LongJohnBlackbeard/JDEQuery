using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74101W - .
/// </summary>
public class F74101W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VWAN8.
        /// </summary>
        public const string VWAN8 = "VWAN8";

        /// <summary>
        /// VWALPH.
        /// </summary>
        public const string VWALPH = "VWALPH";

        /// <summary>
        /// VWADD1.
        /// </summary>
        public const string VWADD1 = "VWADD1";

        /// <summary>
        /// VWADD2.
        /// </summary>
        public const string VWADD2 = "VWADD2";

        /// <summary>
        /// VWADD3.
        /// </summary>
        public const string VWADD3 = "VWADD3";

        /// <summary>
        /// VWADD4.
        /// </summary>
        public const string VWADD4 = "VWADD4";

        /// <summary>
        /// VW74VAT.
        /// </summary>
        public const string VW74VAT = "VW74VAT";

        /// <summary>
        /// VW74CTR.
        /// </summary>
        public const string VW74CTR = "VW74CTR";

        /// <summary>
        /// VW74CNO.
        /// </summary>
        public const string VW74CNO = "VW74CNO";

        /// <summary>
        /// VW74RVAT.
        /// </summary>
        public const string VW74RVAT = "VW74RVAT";

        /// <summary>
        /// VW74RCTR.
        /// </summary>
        public const string VW74RCTR = "VW74RCTR";

        /// <summary>
        /// VW74RSD.
        /// </summary>
        public const string VW74RSD = "VW74RSD";

        /// <summary>
        /// VWEV01.
        /// </summary>
        public const string VWEV01 = "VWEV01";

        /// <summary>
        /// VWDTAI.
        /// </summary>
        public const string VWDTAI = "VWDTAI";

        /// <summary>
        /// VWMSGTEXT.
        /// </summary>
        public const string VWMSGTEXT = "VWMSGTEXT";

        /// <summary>
        /// VWFFG1.
        /// </summary>
        public const string VWFFG1 = "VWFFG1";

        /// <summary>
        /// VWFFU4.
        /// </summary>
        public const string VWFFU4 = "VWFFU4";

        /// <summary>
        /// VWFUT3.
        /// </summary>
        public const string VWFUT3 = "VWFUT3";

        /// <summary>
        /// VWUSER.
        /// </summary>
        public const string VWUSER = "VWUSER";

        /// <summary>
        /// VWPID.
        /// </summary>
        public const string VWPID = "VWPID";

        /// <summary>
        /// VWJOBN.
        /// </summary>
        public const string VWJOBN = "VWJOBN";

        /// <summary>
        /// VWUPMJ.
        /// </summary>
        public const string VWUPMJ = "VWUPMJ";

        /// <summary>
        /// VWUPMT.
        /// </summary>
        public const string VWUPMT = "VWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74101W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VWAN8", "VWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VWALPH", "VWALPH", JdeDataType.String, 80),
        new JdeField("VWADD1", "VWADD1", JdeDataType.String, 80),
        new JdeField("VWADD2", "VWADD2", JdeDataType.String, 80),
        new JdeField("VWADD3", "VWADD3", JdeDataType.String, 80),
        new JdeField("VWADD4", "VWADD4", JdeDataType.String, 80),
        new JdeField("VW74VAT", "VW74VAT", JdeDataType.String, 40),
        new JdeField("VW74CTR", "VW74CTR", JdeDataType.String, 6),
        new JdeField("VW74CNO", "VW74CNO", JdeDataType.String, 80),
        new JdeField("VW74RVAT", "VW74RVAT", JdeDataType.String, 40),
        new JdeField("VW74RCTR", "VW74RCTR", JdeDataType.String, 6),
        new JdeField("VW74RSD", "VW74RSD", JdeDataType.Numeric),
        new JdeField("VWEV01", "VWEV01", JdeDataType.String, 2),
        new JdeField("VWDTAI", "VWDTAI", JdeDataType.String, 20),
        new JdeField("VWMSGTEXT", "VWMSGTEXT", JdeDataType.String, 510),
        new JdeField("VWFFG1", "VWFFG1", JdeDataType.String, 2),
        new JdeField("VWFFU4", "VWFFU4", JdeDataType.Numeric),
        new JdeField("VWFUT3", "VWFUT3", JdeDataType.String, 60),
        new JdeField("VWUSER", "VWUSER", JdeDataType.String, 20),
        new JdeField("VWPID", "VWPID", JdeDataType.String, 20),
        new JdeField("VWJOBN", "VWJOBN", JdeDataType.String, 20),
        new JdeField("VWUPMJ", "VWUPMJ", JdeDataType.Numeric),
        new JdeField("VWUPMT", "VWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74101W_0", "Primary Key on VWAN8", new[] { "VWAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
