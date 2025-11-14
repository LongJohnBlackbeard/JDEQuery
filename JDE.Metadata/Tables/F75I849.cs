using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I849 - .
/// </summary>
public class F75I849 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROKCOO.
        /// </summary>
        public const string ROKCOO = "ROKCOO";

        /// <summary>
        /// RODCTO.
        /// </summary>
        public const string RODCTO = "RODCTO";

        /// <summary>
        /// RODOCO.
        /// </summary>
        public const string RODOCO = "RODOCO";

        /// <summary>
        /// ROLNID.
        /// </summary>
        public const string ROLNID = "ROLNID";

        /// <summary>
        /// ROSFXO.
        /// </summary>
        public const string ROSFXO = "ROSFXO";

        /// <summary>
        /// RODOC.
        /// </summary>
        public const string RODOC = "RODOC";

        /// <summary>
        /// RODCT.
        /// </summary>
        public const string RODCT = "RODCT";

        /// <summary>
        /// ROKCO.
        /// </summary>
        public const string ROKCO = "ROKCO";

        /// <summary>
        /// ROSFX.
        /// </summary>
        public const string ROSFX = "ROSFX";

        /// <summary>
        /// ROPYID.
        /// </summary>
        public const string ROPYID = "ROPYID";

        /// <summary>
        /// ROI75CATTY.
        /// </summary>
        public const string ROI75CATTY = "ROI75CATTY";

        /// <summary>
        /// ROI75CATVL.
        /// </summary>
        public const string ROI75CATVL = "ROI75CATVL";

        /// <summary>
        /// ROI75CATCO.
        /// </summary>
        public const string ROI75CATCO = "ROI75CATCO";

        /// <summary>
        /// ROI75CGSTA.
        /// </summary>
        public const string ROI75CGSTA = "ROI75CGSTA";

        /// <summary>
        /// ROI75SGSTA.
        /// </summary>
        public const string ROI75SGSTA = "ROI75SGSTA";

        /// <summary>
        /// ROI75IGSTA.
        /// </summary>
        public const string ROI75IGSTA = "ROI75IGSTA";

        /// <summary>
        /// ROI75CESSA.
        /// </summary>
        public const string ROI75CESSA = "ROI75CESSA";

        /// <summary>
        /// ROI75ATX1A.
        /// </summary>
        public const string ROI75ATX1A = "ROI75ATX1A";

        /// <summary>
        /// ROI75ATX2A.
        /// </summary>
        public const string ROI75ATX2A = "ROI75ATX2A";

        /// <summary>
        /// ROI75ATX3A.
        /// </summary>
        public const string ROI75ATX3A = "ROI75ATX3A";

        /// <summary>
        /// ROI75AT4A.
        /// </summary>
        public const string ROI75AT4A = "ROI75AT4A";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";

        /// <summary>
        /// ROYFUTDT1.
        /// </summary>
        public const string ROYFUTDT1 = "ROYFUTDT1";

        /// <summary>
        /// ROFUT6.
        /// </summary>
        public const string ROFUT6 = "ROFUT6";

        /// <summary>
        /// ROYT04.
        /// </summary>
        public const string ROYT04 = "ROYT04";

        /// <summary>
        /// ROYFLAG.
        /// </summary>
        public const string ROYFLAG = "ROYFLAG";

        /// <summary>
        /// ROYNUM1.
        /// </summary>
        public const string ROYNUM1 = "ROYNUM1";

        /// <summary>
        /// ROAN8.
        /// </summary>
        public const string ROAN8 = "ROAN8";

        /// <summary>
        /// RODE.
        /// </summary>
        public const string RODE = "RODE";

        /// <summary>
        /// ROI75GSTRA.
        /// </summary>
        public const string ROI75GSTRA = "ROI75GSTRA";

        /// <summary>
        /// ROI75IPOS.
        /// </summary>
        public const string ROI75IPOS = "ROI75IPOS";

        /// <summary>
        /// RODGL.
        /// </summary>
        public const string RODGL = "RODGL";

        /// <summary>
        /// RODMTJ.
        /// </summary>
        public const string RODMTJ = "RODMTJ";

        /// <summary>
        /// ROI75REVBN.
        /// </summary>
        public const string ROI75REVBN = "ROI75REVBN";

        /// <summary>
        /// ROICUT.
        /// </summary>
        public const string ROICUT = "ROICUT";

        /// <summary>
        /// ROI75RECU.
        /// </summary>
        public const string ROI75RECU = "ROI75RECU";

        /// <summary>
        /// ROFFU4.
        /// </summary>
        public const string ROFFU4 = "ROFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F75I849";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROKCOO", "ROKCOO", JdeDataType.String, 10),
        new JdeField("RODCTO", "RODCTO", JdeDataType.String, 4),
        new JdeField("RODOCO", "RODOCO", JdeDataType.Numeric),
        new JdeField("ROLNID", "ROLNID", JdeDataType.Numeric),
        new JdeField("ROSFXO", "ROSFXO", JdeDataType.String, 6),
        new JdeField("RODOC", "RODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RODCT", "RODCT", JdeDataType.String, 4, true, true),
        new JdeField("ROKCO", "ROKCO", JdeDataType.String, 10, true, true),
        new JdeField("ROSFX", "ROSFX", JdeDataType.String, 6, true, true),
        new JdeField("ROPYID", "ROPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROI75CATTY", "ROI75CATTY", JdeDataType.String, 6, true, true),
        new JdeField("ROI75CATVL", "ROI75CATVL", JdeDataType.String, 40, true, true),
        new JdeField("ROI75CATCO", "ROI75CATCO", JdeDataType.Numeric),
        new JdeField("ROI75CGSTA", "ROI75CGSTA", JdeDataType.Numeric),
        new JdeField("ROI75SGSTA", "ROI75SGSTA", JdeDataType.Numeric),
        new JdeField("ROI75IGSTA", "ROI75IGSTA", JdeDataType.Numeric),
        new JdeField("ROI75CESSA", "ROI75CESSA", JdeDataType.Numeric),
        new JdeField("ROI75ATX1A", "ROI75ATX1A", JdeDataType.Numeric),
        new JdeField("ROI75ATX2A", "ROI75ATX2A", JdeDataType.Numeric),
        new JdeField("ROI75ATX3A", "ROI75ATX3A", JdeDataType.Numeric),
        new JdeField("ROI75AT4A", "ROI75AT4A", JdeDataType.Numeric),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric),
        new JdeField("ROYFUTDT1", "ROYFUTDT1", JdeDataType.Numeric),
        new JdeField("ROFUT6", "ROFUT6", JdeDataType.String, 60),
        new JdeField("ROYT04", "ROYT04", JdeDataType.String, 2),
        new JdeField("ROYFLAG", "ROYFLAG", JdeDataType.String, 2),
        new JdeField("ROYNUM1", "ROYNUM1", JdeDataType.Numeric),
        new JdeField("ROAN8", "ROAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RODE", "RODE", JdeDataType.Numeric),
        new JdeField("ROI75GSTRA", "ROI75GSTRA", JdeDataType.String, 4),
        new JdeField("ROI75IPOS", "ROI75IPOS", JdeDataType.String, 4),
        new JdeField("RODGL", "RODGL", JdeDataType.Numeric),
        new JdeField("RODMTJ", "RODMTJ", JdeDataType.Numeric),
        new JdeField("ROI75REVBN", "ROI75REVBN", JdeDataType.Numeric),
        new JdeField("ROICUT", "ROICUT", JdeDataType.String, 4),
        new JdeField("ROI75RECU", "ROI75RECU", JdeDataType.String, 2),
        new JdeField("ROFFU4", "ROFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I849_0", "Primary Key on RODOC, RODCT, ROKCO, ROSFX, ROPYID, ROI75CATTY, ROI75CATVL, ROAN8", new[] { "RODOC", "RODCT", "ROKCO", "ROSFX", "ROPYID", "ROI75CATTY", "ROI75CATVL", "ROAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
