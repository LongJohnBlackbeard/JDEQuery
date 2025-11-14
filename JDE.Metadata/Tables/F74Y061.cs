using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y061 - .
/// </summary>
public class F74Y061 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDCO.
        /// </summary>
        public const string YDCO = "YDCO";

        /// <summary>
        /// YDY74DYR.
        /// </summary>
        public const string YDY74DYR = "YDY74DYR";

        /// <summary>
        /// YDY74DPER.
        /// </summary>
        public const string YDY74DPER = "YDY74DPER";

        /// <summary>
        /// YDY74DPN.
        /// </summary>
        public const string YDY74DPN = "YDY74DPN";

        /// <summary>
        /// YDY74TPUL.
        /// </summary>
        public const string YDY74TPUL = "YDY74TPUL";

        /// <summary>
        /// YDI74SCOD.
        /// </summary>
        public const string YDI74SCOD = "YDI74SCOD";

        /// <summary>
        /// YDAN8.
        /// </summary>
        public const string YDAN8 = "YDAN8";

        /// <summary>
        /// YDKCO.
        /// </summary>
        public const string YDKCO = "YDKCO";

        /// <summary>
        /// YDDCT.
        /// </summary>
        public const string YDDCT = "YDDCT";

        /// <summary>
        /// YDDOC.
        /// </summary>
        public const string YDDOC = "YDDOC";

        /// <summary>
        /// YDTX2.
        /// </summary>
        public const string YDTX2 = "YDTX2";

        /// <summary>
        /// YDTAX.
        /// </summary>
        public const string YDTAX = "YDTAX";

        /// <summary>
        /// YDI74RDOF.
        /// </summary>
        public const string YDI74RDOF = "YDI74RDOF";

        /// <summary>
        /// YDI74RELE.
        /// </summary>
        public const string YDI74RELE = "YDI74RELE";

        /// <summary>
        /// YDI74VNEF.
        /// </summary>
        public const string YDI74VNEF = "YDI74VNEF";

        /// <summary>
        /// YDI74REVCH.
        /// </summary>
        public const string YDI74REVCH = "YDI74REVCH";

        /// <summary>
        /// YDDGJ.
        /// </summary>
        public const string YDDGJ = "YDDGJ";

        /// <summary>
        /// YDY74TAXT.
        /// </summary>
        public const string YDY74TAXT = "YDY74TAXT";

        /// <summary>
        /// YDY74TVAT.
        /// </summary>
        public const string YDY74TVAT = "YDY74TVAT";

        /// <summary>
        /// YDVINV.
        /// </summary>
        public const string YDVINV = "YDVINV";

        /// <summary>
        /// YDCRCD.
        /// </summary>
        public const string YDCRCD = "YDCRCD";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y061";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDCO", "YDCO", JdeDataType.String, 10, true, true),
        new JdeField("YDY74DYR", "YDY74DYR", JdeDataType.Numeric, null, true, true),
        new JdeField("YDY74DPER", "YDY74DPER", JdeDataType.String, 2, true, true),
        new JdeField("YDY74DPN", "YDY74DPN", JdeDataType.Numeric, null, true, true),
        new JdeField("YDY74TPUL", "YDY74TPUL", JdeDataType.String, 2, true, true),
        new JdeField("YDI74SCOD", "YDI74SCOD", JdeDataType.Numeric, null, true, true),
        new JdeField("YDAN8", "YDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YDKCO", "YDKCO", JdeDataType.String, 10, true, true),
        new JdeField("YDDCT", "YDDCT", JdeDataType.String, 4, true, true),
        new JdeField("YDDOC", "YDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("YDTX2", "YDTX2", JdeDataType.String, 40),
        new JdeField("YDTAX", "YDTAX", JdeDataType.String, 40),
        new JdeField("YDI74RDOF", "YDI74RDOF", JdeDataType.String, 2),
        new JdeField("YDI74RELE", "YDI74RELE", JdeDataType.String, 4, true, true),
        new JdeField("YDI74VNEF", "YDI74VNEF", JdeDataType.String, 2),
        new JdeField("YDI74REVCH", "YDI74REVCH", JdeDataType.String, 2),
        new JdeField("YDDGJ", "YDDGJ", JdeDataType.Numeric),
        new JdeField("YDY74TAXT", "YDY74TAXT", JdeDataType.Numeric),
        new JdeField("YDY74TVAT", "YDY74TVAT", JdeDataType.Numeric),
        new JdeField("YDVINV", "YDVINV", JdeDataType.String, 50),
        new JdeField("YDCRCD", "YDCRCD", JdeDataType.String, 6),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y061_0", "Primary Key on YDCO, YDY74DYR, YDY74DPER, YDY74DPN, YDY74TPUL, YDI74SCOD, YDAN8, YDKCO, YDDCT, YDDOC, YDI74RELE", new[] { "YDCO", "YDY74DYR", "YDY74DPER", "YDY74DPN", "YDY74TPUL", "YDI74SCOD", "YDAN8", "YDKCO", "YDDCT", "YDDOC", "YDI74RELE" }, isUnique: true, isPrimaryKey: true)
    };
}
